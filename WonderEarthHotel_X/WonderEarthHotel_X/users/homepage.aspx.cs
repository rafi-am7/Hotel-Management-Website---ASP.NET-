using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderEarthHotel_X.users
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Royal Tulip";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Cox Today";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Seagul";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Westinn";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Tiger Garden";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel City Inn";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Castle Salam";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Royal Tulip";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Session["HotelName"] = "Hotel Kaifeng";
            if (Session["userid"] != null)
            {
                Response.Redirect("Booking.aspx");
            }
            else
            {
                Response.Redirect("~/users/DemoBooking.aspx");
            }
        }

        
    }
}