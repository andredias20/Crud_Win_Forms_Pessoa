using Crud_Win_Forms_Pessoa.Repositories;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_Crud.Entity;

namespace WindowsForms_Crud.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Insert(Person person)
        {
            using NpgsqlConnection conn = (NpgsqlConnection) new DBConection().GetConnection();
            conn.Execute("INSERT INTO Person (Name, Cpf, Email) VALUES(@name,@cpf,@email);",
                new
                {
                    name = person.Name,
                    cpf = person.Cpf,
                    email = person.Email
                });
        }

        public void Update(Person person)
        {
            using NpgsqlConnection conn = (NpgsqlConnection)new DBConection().GetConnection();
            conn.Execute("UPDATE Person SET Name = @name, Cpf = @cpf, Email = @email, Id = @id;",
                new
                {
                    name = person.Name,
                    cpf = person.Cpf,
                    email = person.Email,
                    id = person.Id
                });
        }

        public void Delete(int Id)
        {
            using NpgsqlConnection conn = (NpgsqlConnection)new DBConection().GetConnection();
            conn.Execute("DELETE FROM Person WHERE Id = @id;",
                new
                {
                    id = Id
                });
        }
        public Person FindById(int Id)
        {
            using NpgsqlConnection conn = (NpgsqlConnection)new DBConection().GetConnection();
            return conn.QueryFirstOrDefault<Person>(@"SELECT * FROM Person WHERE Id = @id;", 
                new
                {
                    id = Id
                });
        }

        public IEnumerable<Person> FindAll()
        {
            using NpgsqlConnection conn = (NpgsqlConnection)new DBConection().GetConnection();
            return conn.Query<Person>(@"SELECT * FROM Person;");
        }
    }
}
