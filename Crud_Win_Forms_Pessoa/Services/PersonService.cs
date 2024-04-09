using Crud_Win_Forms_Pessoa.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_Crud.Entity;

namespace Crud_Win_Forms_Pessoa.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _reposiotory;

        public PersonService(IPersonRepository reposiotory) 
        { 
            _reposiotory = reposiotory;
        }

        public IEnumerable<Person> FindAll()
        {
            return _reposiotory.FindAll();
        }

        public Person FindById(int id)
        {
            if (int.IsNegative(id))
                return new Person(0, "", "","");
            return _reposiotory.FindById(id);
        }

        public void Insert(Person person)
        {
            _reposiotory.Insert(person);
        }

        public void Update(Person person)
        {
            _reposiotory.Update(person);
        }

        public void Delete(int id)
        {
            _reposiotory.Delete(id);
        }
    }
}
