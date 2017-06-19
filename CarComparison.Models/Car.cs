using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparison.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public float TCCRating { get; set; }
        public float HwyMPG { get; set; }
    }

    public class AvgMpg
    {
        public int Id { get; set; }
        public int year { get; set; }
        public float  AvgMPG { get; set; }
    }
}
