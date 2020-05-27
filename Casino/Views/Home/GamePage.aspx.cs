using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using Casino.Models;

namespace Casino.Views.Home
{
    public partial class WebForm1 : ViewPage 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Game game = (Game)HttpContext.Current.Session["Game"];
            BeforeStart();
        }

      

        public void BeforeStart()
        {
            coin10.Enabled = false;
            coin25.Enabled = false;
            coin50.Enabled = false;
            coin100.Enabled = false;
            lblBid.Visible = false;
            lblCash.Enabled = false;
            btnDeal.Enabled = false;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
           
        }


        public void AfterStart()
        {
            coin10.Enabled = true;
            coin25.Enabled = true;
            coin50.Enabled = true;
            coin100.Enabled = true;
            lblBid.Visible = true;
            lblCash.Enabled = true;
            btnDeal.Enabled = true;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnStart.Visible = false;

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            AfterStart();
        }
    }
}