﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService:IGenericService<Destination>
    {
        int TDestinationCount();
        int TGuidesCount();
        int TUsersCount();
    }
}
