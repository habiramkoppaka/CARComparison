using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarComparison.DataAccessLayer.Repositorys.Generic;
using CarComparison.Models;

namespace CarComparison.DataAccessLayer.Repositorys.Interface
{
    public interface ICarRepositoery :IRepository<Car>
    {
        IEnumerable<Car> NewestVechicalinOrder();
        IEnumerable<Car> AlphabetizesListofVechicles();
        IEnumerable<Car> OrderedListofVechicalsbyPrice();
        void BestValue();
        
        IEnumerable<Car> RandomCarfromtheList();
        IEnumerable<AvgMpg> AvarageMPGbyYear();

    }
}
