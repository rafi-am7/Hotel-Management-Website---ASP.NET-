﻿using System;
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
    public partial class UserProfile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {

        }

        void updaten()
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd =
                new SqlCommand(
                    "UPDATE register set UserName=@US,Mobile=@mbl,Email=@eml where UserName='" +
                    Session["username"].ToString() + "';", con);

            cmd.Parameters.AddWithValue("@US", txt_username.Text.Trim());
            cmd.Parameters.AddWithValue("@mbl", txt_mobile.Text.Trim());
            cmd.Parameters.AddWithValue("@eml",txt_email.Text.Trim());

            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        //void GetUserData()
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(strcon);
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }

        //        SqlCommand cmd =
        //            new SqlCommand("SELECT * from User_LogIn_tbl where ID='" + Session["userid"].ToString() + "';",
        //                con);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        TextBox1.Text = dt.Rows[0]["UserName"].ToString();
        //        TextBox2.Text = dt.Rows[0]["Date_of_Birth"].ToString();
        //        TextBox3.Text = dt.Rows[0]["Mobile_No"].ToString();
        //        TextBox4.Text = dt.Rows[0]["E_Mail"].ToString();
        //        DropDownList1.SelectedValue = dt.Rows[0]["Division"].ToString().Trim();
        //        TextBox6.Text = dt.Rows[0]["City"].ToString();
        //        TextBox7.Text = dt.Rows[0]["Pin_Code"].ToString();

        //        TextBox8.Text = dt.Rows[0]["ID"].ToString();
        //        //TextBox9.Text = dt.Rows[0]["Password"].ToString();

        //        //  Label1.Text = dt.Rows[0]["account_status"].ToString().Trim();

        //        //   if (dt.Rows[0]["account_status"].ToString().Trim() == "active")
        //        //  {
        //        //   Label1.Attributes.Add("class", "badge badge-pill badge-success");

        //        //   else if (dt.Rows[0]["account_status"].ToString().Trim() == "pending")
        //        //   {
        //        //      Label1.Attributes.Add("class", "badge badge-pill badge-warning");
        //        //  }
        //        //  else if (dt.Rows[0]["account_status"].ToString().Trim() == "deactive")
        //        //  {
        //        //      Label1.Attributes.Add("class", "badge badge-pill badge-danger");
        //        //   }
        //        //   else
        //        //   {
        //        //       Label1.Attributes.Add("class", "badge badge-pill badge-info");
        //        //   }

                 
        //    }
        //    catch (Exception ex)
        //    {


        //    }


        //} 
    }
}