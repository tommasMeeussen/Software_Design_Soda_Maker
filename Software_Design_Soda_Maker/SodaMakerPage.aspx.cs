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
        SodaMachine sodaM = new SodaMachine(); 
        Cup currentCup = new Cup("small");
        Cup fuck;

        protected void Page_Load(object sender, EventArgs e)
        {

            ReadData();
            if (sodaM == null)
            {
                //sodaM = new SodaMachine();
            }
            //lblSmallCups.Text = sodaMachine.CupStorage.SmallCups.ToString();
        }

        public void ReadData()
        {
            //fuck = new Cup("small");
            //currentCup = new Cup("small");
            //sodaM = new SodaMachine();
        }

        public void takeCup()
        {
            sodaM.CupStorage.removeCup(sodaM.SelectedCup);
            sodaM.SelectedCup = null;
            sodaM.PouringButton.Indicators.LightStatus = true;
            btnTakeCup.Visible = false;
            btnDispense.Visible = true;
            lblSmallCups.Text = sodaM.CupStorage.SmallCups.ToString();
        }

        public void selectCup(string cupSize)
        {
            //currentCup.selectSize(cupSize);
            Cup tempCup = new Cup(cupSize);
            sodaM.selectCup(cupSize);
            //sodaM.SelectedCup = currentCup;
            //sodaM.SelectedCup.selectSize(currentCup.Size);
            lblSelectedCup.Text = sodaM.SelectedCup.Size;
        }

        public void dispense()
        {
            if (lblSelectedCup.Text == "Pick One")
            {
                lblIndicator.Text = "Cup Size Must Be Selected First";
            }
            else
            {
                lblIndicator.Text = sodaM.SelectedCup.Size;
                sodaM.Nozzle.dispenseSoda(sodaM.Soda, sodaM.SelectedCup);
                sodaM.PouringButton.Indicators.LightStatus = true;
                btnTakeCup.Visible = true;
                btnDispense.Visible = false;
            }
        }

        protected void btnDispense_Click(object sender, EventArgs e)
        {
            dispense();
        }

        protected void btnSmall_Click(object sender, EventArgs e)
        {
            selectCup("small");
        }

        protected void btnMedium_Click(object sender, EventArgs e)
        {
            selectCup("medium");

        }

        protected void btnLarge_Click(object sender, EventArgs e)
        {
            selectCup("large");

        }

        protected void btnTakeCup_Click(object sender, EventArgs e)
        {
            takeCup();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReadData();

        }
    }
}