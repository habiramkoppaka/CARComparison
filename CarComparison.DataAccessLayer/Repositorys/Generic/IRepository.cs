using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparison.DataAccessLayer.Repositorys.Generic
{
    public interface IRepository<T> where T: class
    {
        // add the entity
        void Add(T entity);

        // delete the entity
        void Delete(T entity);

        // update based on entity
        void Update(T enity);

        // returns list of elements
        IEnumerable<T> GetAll();


    }
}
