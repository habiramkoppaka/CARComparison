using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarComparison.DataAccessLayer.Repositorys.Interface;
using CarComparison.DataAccessLayer.Repositorys.Generic;
using CarComparison.Models;
using CarComparison.DataAccessLayer.Context;

namespace CarComparison.DataAccessLayer.Repositorys.Classes
{
    public class CarRepository : GenericRepositiory<Car>, ICarRepositoery
    {
        private readonly CarContext _context;
        public CarRepository(CarContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Car> AlphabetizesListofVechicles()
        {
           return _context.Cars.OrderBy(x => x.Make).ThenBy(x => x.Model).ToList();
        }

        public IEnumerable<AvgMpg> AvarageMPGbyYear()
        {
            var Anynomuousresult = _context.Cars.GroupBy(x => x.year).Select(c => new AvgMpg {
                year = c.Key,
                AvgMPG = c.Average(x => x.HwyMPG) 
            }).ToList();






            return Anynomuousresult;


        }

        public void BestValue()
        {
            // assuming  TCC Rating and Year I have decide the best value
            var result = _context.Cars.GroupBy(x => new { x.TCCRating, x.year }).Select(c => new
            {
                TCCRating = c.Key,
                year = c.Key,

                Price = c.Min(x => x.price)
            }).ToList();
        }





        public IEnumerable<Car> NewestVechicalinOrder()
        {
            var result = _context.Cars.OrderByDescending(x => x.year).ToList();
            return result;
        }

        public IEnumerable<Car> OrderedListofVechicalsbyPrice()
        {
            var result = _context.Cars.OrderBy(x => x.price).ToList();
            return result;
        }

        public IEnumerable<Car> RandomCarfromtheList()
        {
            Random rnd = new Random();
            var result = _context.Cars.OrderBy(x => rnd.Next()).Take(1).ToList();

            return result;
        }
    }
}
