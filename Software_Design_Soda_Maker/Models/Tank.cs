using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class Tank
    {
        public int pressure { get; private set; }

        public Tank(int pressure)
        {
            this.pressure = pressure;
        }

        public CO2 provideCO2()
        {

            if (pressure > 0)
            {
                pressure -= 10;
                CO2 gas = new CO2(pressure);
                return gas;
            }

            return null;
        }
    }
}