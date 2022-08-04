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
    public partial class Login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["ID"] != null && Request.Cookies["Password"] != null)
                {
                    txt_login_username.Text = Request.Cookies["UserName"].Value;
                    txt_login_password.Attributes["value"] = Request.Cookies["Password"].Value;
                }
            }
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
                SqlCommand cmd = new SqlCommand("select * from register where UserName='" + txt_login_username.Text.Trim() + "' and Password='" + txt_login_password.Text.Trim() + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (CheckBox1.Checked)
                    {
                        Response.Cookies["UserName"].Value = txt_login_username.Text;
                        Response.Cookies["Password"].Value = txt_login_password.Text;
                        Response.Cookies["ID"].Expires = DateTime.Now.AddMinutes(10);
                        Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(10);
                    }
                    else
                    {
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
                    }


                    while (dr.Read())
                    {
                        Response.Write("<script>alert('Log In Successfull.😎');</script>");
                        Session["userid"] = dr.GetValue(0).ToString();
                        Session["username"] = dr.GetValue(1).ToString();
                        Session["role"] = "user";
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}