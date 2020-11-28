using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class Water
    {
        public int pressure { get; set; }
        public int temperature { get; set; }
        public bool isCarbonated { get; set; }

        public Water(int press, int temp)
        {
            isCarbonated = false;
            pressure = press;
            temperature = temp;
        }
    }
}