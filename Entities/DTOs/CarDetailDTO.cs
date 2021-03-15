using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class CarDetailDTO:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
