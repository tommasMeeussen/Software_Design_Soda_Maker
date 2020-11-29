using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class CO2Regulator
    {
        private Tank tank;
        public CO2 cO2 { get; private set; }

        public CO2Regulator(Tank tank)
        {
            this.tank = tank;
        }

        public CO2 getCO2()
        {
            CO2 temp = cO2;
            cO2 = null;
            return temp;
        }

        public bool refill()
        {
            if (cO2 == null) cO2 = tank.provideCO2();
            return cO2 != null;
        }
    }
}