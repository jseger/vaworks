﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaWorks.Web.Data
{
    public interface IDataWriter
    {
        void Write(System.Data.IDataReader reader);

        int SaveChanges();
    }
}
