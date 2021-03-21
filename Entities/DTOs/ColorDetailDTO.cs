using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ColorDetailDTO:IDto
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
