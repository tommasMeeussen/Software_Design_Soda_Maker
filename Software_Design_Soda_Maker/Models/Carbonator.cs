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
        }

        public void carbonateWater()
        {

        }
    }
}