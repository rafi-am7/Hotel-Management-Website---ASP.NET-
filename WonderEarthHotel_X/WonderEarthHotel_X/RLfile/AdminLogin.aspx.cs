using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderEarthHotel_X.RLfile
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from Admin where UserName='" + txt_login_username.Text.Trim() + "' and Password='" + txt_login_password.Text.Trim() + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // Response.Write("<script>alert('" + dr.GetValue(1).ToString() + "');</script>");
                      
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["role"] = "Admin";
                        // Session["status"] = dr.GetValue(9).ToString();
                    }
                    Response.Redirect("~/users/homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Info');</script>");
                }
            }
            catch (Exception ex)
            {


            }
        }
    }
}