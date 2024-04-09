using Crud_Win_Forms_Pessoa.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_Crud.Entity;

namespace Crud_Win_Forms_Pessoa.Services
{
    public interface IPersonService
    {
        public IEnumerable<Person> FindAll();
        public Person FindById(int id);
        public void Insert(Person person);
        public void Update(Person person);
        public void Delete(int id);

    }
}
