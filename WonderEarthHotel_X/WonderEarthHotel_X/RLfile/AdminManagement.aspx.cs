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
    public partial class AdminManagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                GridView1.DataBind();
            
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {

            GridView1.DataBind();
            SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from booking1 where ID='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    TextBox1.Text = dt.Rows[0][0].ToString();
                    txtStdname.Text = dt.Rows[0]["fullname"].ToString();
                    txtfname.Text = dt.Rows[0]["RoomNo"].ToString();
                    TextBox2.Text = dt.Rows[0]["status"].ToString();
                }
        }


        
        void updateUserName()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd =
                    new SqlCommand(
                        "UPDATE booking1 SET RoomNo=@RoomNo,status=@status where ID='" + TextBox1.Text.Trim() + "'", con);
                cmd.Parameters.AddWithValue("RoomNo", txtfname.Text.Trim());
                cmd.Parameters.AddWithValue("status", TextBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                

                
                Response.Write("<script>alert(' Updated Successfully!!!')</script>");

            }
            catch (Exception ex)
            {

            }

            
        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            GridView1.DataBind();
            updateUserName();
            ClearForm();

        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            GridView1.DataBind();
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd =
                new SqlCommand(
                    "Delete from booking1 where ID='" + TextBox1.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ClearForm();
        }

        void ClearForm()
        {
            TextBox1.Text = null;
            txtfname.Text = null;
            txtStdname.Text = null;
            TextBox2.Text = null;


        }
    }
}