using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Bus
    {
        public int BusID { get; set; }
        public string Plate { get; set; }
        public string NumberOfSeats { get; set; }
        public bool Status { get; set; }
        public List<BusActionPlan> BusActionPlans { get; set; }
    }
}
