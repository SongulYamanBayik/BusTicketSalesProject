using Business_Layer.Abstract;
using DAL.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class BusManager : IBusService
    {
        IBusDal _busDal;

        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }

        public void TChangeStatu(int id)
        {
            _busDal.ChangeStatu(id);
        }

        public void TDelete(Bus item)
        {
            _busDal.Delete(item);
        }

        public List<Bus> TGetBusListByStatus()
        {
           return _busDal.GetBusListByStatus();
        }

        public Bus TGetByID(int id)
        {
            return _busDal.GetByID(id);
        }

        public List<Bus> TGetList()
        {
            return _busDal.GetList();
        }

        public void TInsert(Bus item)
        {
            _busDal.Insert(item);
        }

        public void TUpdate(Bus item)
        {
            _busDal.Update(item);
        }
    }
}
