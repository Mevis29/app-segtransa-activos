﻿using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IBitacoraDAL
    {
        void Add(Bitacora bitacora);

        List<Bitacora> GetBitacora();
    }
}
