using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class CO2
    {
        public int pressure { get; set; }
        
        public CO2(int press)
        {
            pressure = press;
        }
    }
}