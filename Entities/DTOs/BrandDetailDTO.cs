using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BrandDetailDTO:IDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
