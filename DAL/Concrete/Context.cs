using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
   public class Context:DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusActionPlan> BusActionPlans { get; set; }
        public DbSet<Route> Routes { get; set; }
    }
}
