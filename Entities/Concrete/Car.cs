﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Car:IEntity
    {
        //, BrandId, ColorId, ModelYear, DailyPrice, Description

        public int CarId { get; set; }  
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
