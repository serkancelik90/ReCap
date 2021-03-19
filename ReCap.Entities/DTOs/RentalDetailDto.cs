using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public string BrandName { get; set; }
        public string Name { get; set; }
    }
}
