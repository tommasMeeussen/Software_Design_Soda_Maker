using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class WaterRegulator
    {
        private WaterSupply WaterSupply;
        public int pressureTarget { get; set; }
        public int tempTarget { get; set; }
        private BoosterPump boosterPump;
        private ChillingPlate chillingPlate;
        public Water water { get; private set; }

        public WaterRegulator(WaterSupply waterSupply)
        {
            this.WaterSupply = waterSupply;

            boosterPump = new BoosterPump();

            chillingPlate = new ChillingPlate();
        }

        public Water getWater()
        {
            return water;
        }

        public void manageWaterTemp()
        {
            while (water.temperature > tempTarget)
            {
                chillingPlate.lowerTemperature(water);
            }
        }

        public void manageWaterPressure()
        {
            while (water.pressure < pressureTarget)
            {
                boosterPump.increasePressure(water);
            }
        }
    }
}