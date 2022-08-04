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
    public partial class Registration : System.Web.UI.Page
    {

        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        bool CheckUserExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from register where UserName='" + txt_username.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }




            }
            catch (Exception ex)
            {
                Response.Write("<script>Swal.fire('" + ex.Message + "');</script>");
                return false;
            }

        }
        void ClearBox()
        {
            txt_username.Text = null;
            txt_email.Text = null;
            txt_mobile.Text = null;
            txt_password.Text = null;
           

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {

            if (CheckUserExists())
            {
                Response.Write("<script>alert('User ID Already Exists.Try Different User ID');</script>");
            }
            else
            {
                SignUpNewUser();
                ClearBox();
                Response.Redirect("Login.aspx");
            }

        }
        void SignUpNewUser()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO register(UserName,Mobile,Email,Password) values (@UserName,@Mobile,@Email,@Password)", con);
                cmd.Parameters.AddWithValue("@UserName", txt_username.Text.Trim());
                cmd.Parameters.AddWithValue("@Mobile", txt_mobile.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());
             

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Sign Up Successfully.  Go to User Log In Page to Log In');</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }

}