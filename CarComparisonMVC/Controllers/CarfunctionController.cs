using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarComparison.Models;
using CarComparison.ServiceLayer;
namespace CarComparisonMVC.Controllers
{
    public class CarfunctionController : Controller
    {
        private readonly ICarServices carservices;

        public CarfunctionController(ICarServices carservice)
        {
            this.carservices = carservice;
        }
        // GET: Carfunction
        public ActionResult Index()
        {
            return View();
        }

        //IEnumerable<Car> NewestVechicalinOrder();
        //IEnumerable<Car> AlphabetizesListofVechicles();
        //IEnumerable<Car> OrderedListofVechicalsbyPrice();
        //void BestValue();
        //void FuelConsumtionForGivenDistance(int distance);
        //IEnumerable<Car> RandomCarfromtheList();
        //void AvarageMPGbyYear();

        public ActionResult NewVechicalinOrder()
        {
            var result = carservices.NewestVechicalinOrder();
            return View(result);
        }

        public ActionResult AlphabetizesListofVechicles()
        {
            var result = carservices.AlphabetizesListofVechicles();
            return View(result);
        }
        public ActionResult OrderedListofVechicalsbyPrice()
        {
            var result = carservices.OrderedListofVechicalsbyPrice();
            return View(result);
        }


        public ActionResult RandomCarfromtheList()
        {
            var result = carservices.RandomCarfromtheList();
            return View(result);
        }

        public ActionResult BestValue()
        {
            carservices.BestValue();
            return View();
        }

        public ActionResult FuelConsumtionForGivenDistance(int distance)
        {
            return View();
        }

        public ActionResult AvarageMPGbyYear()
        {

            var result = carservices.AvarageMPGbyYear();
            return View(result);
        }
    }
}