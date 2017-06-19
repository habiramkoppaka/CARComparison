using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarComparison.Models;
using CarComparison.DataAccessLayer.Repositorys.Interface;


namespace CarComparison.ServiceLayer
{
    public interface ICarServices
    {
        IEnumerable<Car> NewestVechicalinOrder();
        IEnumerable<Car> AlphabetizesListofVechicles();
        IEnumerable<Car> OrderedListofVechicalsbyPrice();
        void BestValue();
        void FuelConsumtionForGivenDistance(int distance);
        List<dynamic> RandomCarfromtheList();
        IEnumerable<AvgMpg> AvarageMPGbyYear();


        void CreateCar(Car car);
        void DeleteCar(Car car);
        void UpdateCar(Car car);
        IEnumerable<Car> GetAll();




    }
    public class CarServices : ICarServices
    {
        private readonly ICarRepositoery __carRepository;

        public CarServices(ICarRepositoery carrepository)
        {
            __carRepository = carrepository;

        }
        public IEnumerable<Car> AlphabetizesListofVechicles()
        {
            return __carRepository.AlphabetizesListofVechicles();
        }

        public IEnumerable<AvgMpg> AvarageMPGbyYear()
        {
 return     __carRepository.AvarageMPGbyYear();
        }

        public void BestValue()
        {
            __carRepository.BestValue();
        }

        public void CreateCar(Car car)
        {
            __carRepository.Add(car);
        }



        public void DeleteCar(Car car)
        {
            __carRepository.Delete(car);
        }

        public void FuelConsumtionForGivenDistance(int distance)
        {

            __carRepository.GetAll().Select(c => new { FuelConsumed = (distance / c.HwyMPG),c.Make,c.Model});
        }

        public IEnumerable<Car> GetAll()
        {
            return __carRepository.GetAll();
        }

        public IEnumerable<Car> NewestVechicalinOrder()
        {
            return __carRepository.NewestVechicalinOrder();
        }

        public IEnumerable<Car> OrderedListofVechicalsbyPrice()
        {
            return __carRepository.OrderedListofVechicalsbyPrice();
        }

        public List<dynamic> RandomCarfromtheList()
        {
            var result = __carRepository.RandomCarfromtheList().ToList();

            return result.ToList<dynamic>();
        }

        public void UpdateCar(Car entity)
        {
            __carRepository.Update(entity);

        }
    }
}
