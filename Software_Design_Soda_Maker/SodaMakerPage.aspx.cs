using Software_Design_Soda_Maker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Software_Design_Soda_Maker
{
    public partial class SodaMakerPage : System.Web.UI.Page
    {
        SodaMachine sodaMachine;
        public Cup currentCup = new Cup("");
        protected void Page_Load(object sender, EventArgs e)
        {
            sodaMachine = new SodaMachine();
        }

        protected void btnDispense_Click(object sender, EventArgs e)
        {

        }

        protected void btnSmall_Click(object sender, EventArgs e)
        {
            currentCup.size = "small";
            sodaMachine.selectedCup = currentCup;
            lblSelectedCup.Text = currentCup.size;
        }

        protected void btnMedium_Click(object sender, EventArgs e)
        {
            currentCup.size = "medium";
            sodaMachine.selectedCup = currentCup;
            lblSelectedCup.Text = currentCup.size;
        }

        protected void btnLarge_Click(object sender, EventArgs e)
        {
            currentCup.size = "Large";
            sodaMachine.selectedCup = currentCup;
            lblSelectedCup.Text = currentCup.size;
        }
    }
}