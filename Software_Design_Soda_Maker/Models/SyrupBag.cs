using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class SyrupBag
    {
        public int SyrupLevel { get; set; }


        public SyrupBag(int level)
        {
            SyrupLevel = level;
        }
        public void takeSyrup()
        {
            SyrupLevel = SyrupLevel - 10;
        }

        public void addSyrup()
        {
            SyrupLevel = SyrupLevel + 10;
        }

    }
}