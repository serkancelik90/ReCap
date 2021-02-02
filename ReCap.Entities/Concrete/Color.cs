﻿using ReCap.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Entities.Concrete
{
   public class Color : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
