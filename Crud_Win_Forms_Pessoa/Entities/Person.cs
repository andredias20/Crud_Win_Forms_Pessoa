using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Crud.Entity
{
    public class Person
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }

        private Person() { }

        public Person(int id, string? name, string? cpf, string? email)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
        }
    }
}
