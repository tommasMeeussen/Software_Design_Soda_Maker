using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class WaterSupply
    {
        public int pressure { get; private set; }
        public int temperature { get; private set; }

        public WaterSupply(int press, int temp)
        {
            pressure = press;
            temperature = temp;
        }

        public Water provideWater()
        {
            if (pressure > 0)
            {
                pressure -= 10;
                Water water = new Water(pressure, temperature);
                return water;
            }

            return null;
        }
    }
}