using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderEarthHotel_X.users
{
    public partial class DemoBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt_Demo_submit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RLfile/Registration.aspx");
        }
    }
}