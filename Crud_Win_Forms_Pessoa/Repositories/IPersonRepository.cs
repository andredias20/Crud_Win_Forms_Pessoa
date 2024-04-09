using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_Crud.Entity;
using WindowsForms_Crud.Repositories;

namespace Crud_Win_Forms_Pessoa.Repositories
{
    public interface IPersonRepository
    {
        public void Insert(Person person);
        public void Update(Person person);
        public void Delete(int Id);
        public Person FindById(int Id);
        public IEnumerable<Person> FindAll();
    }
}
