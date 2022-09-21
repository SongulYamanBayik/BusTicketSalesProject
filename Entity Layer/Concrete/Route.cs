using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Route
    {
        public int RouteID { get; set; }
        public string RouteName { get; set; }
        public List<BusActionPlan> BusActionPlans { get; set; }
    }
}
