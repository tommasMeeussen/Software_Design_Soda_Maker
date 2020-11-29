using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class Carbonator
    {
        private CO2Regulator co2Regulator;
        private WaterRegulator waterRegulator;
        public Water water { get; private set; }
        private CO2 cO2;

        public Carbonator(CO2Regulator coReg, WaterRegulator waterReg)
        {
            co2Regulator = coReg;
            waterRegulator = waterReg;
            waterRegulator.pressureTarget = 1000;
            waterRegulator.tempTarget = 5;
        }

        public bool carbonateWater()
        {
            if (co2Regulator.refill() & waterRegulator.refill())
            {
                waterRegulator.manageWaterPressure();
                waterRegulator.manageWaterTemp();

                water = waterRegulator.getWater();
                cO2 = co2Regulator.getCO2();

                water.isCarbonated = true;
                cO2 = null; //garbage collector frees object from memory

                return true;
            }

            return false;
        }
    }
}