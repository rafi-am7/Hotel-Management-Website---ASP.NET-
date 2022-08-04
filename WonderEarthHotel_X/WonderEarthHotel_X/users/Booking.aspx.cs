using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderEarthHotel_X.users
{
    public partial class Booking : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt_submit_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO booking1(adults,children,RoomType,checkin,checkout,fullname,status,HotelName) values (@adults,@children,@RoomType,@checkin,@checkout,@fullname,@status,'"+ Session["HotelName"] +"')", con);
                cmd.Parameters.AddWithValue("@adults", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@children", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@RoomType", DropDownList3.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@checkin", datepicker1.Text.Trim());
                cmd.Parameters.AddWithValue("@checkout", datepicker2.Text.Trim());
                cmd.Parameters.AddWithValue("@fullname", txt_fulname.Text.Trim());
                cmd.Parameters.AddWithValue("@status", "Pending");
                
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Wait for confirmations.');</script>");
                Response.Redirect("homepage.aspx");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}