using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EFBusDal : GenericRepository<Bus>, IBusDal
    {
        Context context = new Context();

        public List<Bus> GetBusListByStatus()
        {
            return context.Buses.Where(x => x.Status == true).ToList();
        }
    }
}
