using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarComparison.Models;
using CarComparison.ServiceLayer;

namespace CarComparisonConsole
{
    public class Program
    {
        private readonly ICarServices carservices;
        public Program(ICarServices carservices)
        {
            this.carservices = carservices;   
        }
        static void Main(string[] args)
        {

        }

    }
}

