﻿using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
   public interface IBusDal:IGenericDal<Bus>
    {
        List<Bus> GetBusListByStatus();
    }
}
