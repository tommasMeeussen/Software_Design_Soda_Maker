using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class SodaMachine
    {
        public CupStorage CupStorage { get; set; }
        public Soda Soda { get; set; }
        public Nozzle Nozzle { get; set; }
        public PouringButton PouringButton { get; set; }
        public CupSizeButton SmallButton { get; set; }
        public CupSizeButton MediumButton { get; set; }
        public CupSizeButton LargeButton { get; set; }
        public Cup SelectedCup { get; set; }

        public WaterSupply  waterSupply { get; set; }
        public Tank tank { get; set; }
        public WaterRegulator waterRegulator { get; set; }
        public CO2Regulator cO2Regulator { get; set; }
        public Carbonator carbonator { get; set; }

        public SodaMachine()
        {
            this.CupStorage= new CupStorage(20, 20, 20);
            this.PouringButton = new PouringButton();
            this.SmallButton = new CupSizeButton("small");
            this.MediumButton = new CupSizeButton("medium");
            this.LargeButton = new CupSizeButton("large");
            
            this.Nozzle = new Nozzle();
            this.Soda = new Soda("Coke");

            waterSupply = new WaterSupply(100, 25);
            tank = new Tank(100);

            waterRegulator = new WaterRegulator(waterSupply);
            cO2Regulator = new CO2Regulator(tank);

            carbonator = new Carbonator(cO2Regulator, waterRegulator);
        }

        public void selectCup(string c)
        {
            SelectedCup = new Cup(c);
        }
    }
}