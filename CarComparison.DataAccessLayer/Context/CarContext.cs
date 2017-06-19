using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarComparison.Models;

namespace CarComparison.DataAccessLayer.Context
{
    public class CarContext : DbContext
    {
        public CarContext() : base("CarContext")
        {

        }

        public DbSet<Car> Cars { get; set; }

        public System.Data.Entity.DbSet<CarComparison.Models.AvgMpg> AvgMpgs { get; set; }
    }

}
