﻿using EF.LinQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.LinQ.Logic
{
    public class BaseLogic
    {     
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
           context = new NorthwindContext();
        }
    }
}
