using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderEarthHotel_X
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    LinkButton15.Visible=false; //user profile
                    LinkButton1.Visible=false;  //hello
                    LinkButton2.Visible=false; //log out
                    Button1.Visible = false; //github
                    Button2.Visible=false; //fb
                    LinkButton8.Visible = true; //admin
                    LinkButton9.Visible = true; //user log in
                    LinkButton3.Visible = true; //home
                    LinkButton4.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton15.Visible = true;    //user profile
                    LinkButton1.Visible = true;  //hello
                    LinkButton1.Text = "Hello " + Session["username"].ToString();
                    LinkButton2.Visible = true; //log out
                    Button1.Visible = true; //github
                    Button2.Visible = true; //fb
                    LinkButton8.Visible = true; //admin
                    LinkButton9.Visible = false; //user log in
                    LinkButton3.Visible = true; //home
                    LinkButton4.Visible = false;

                }
                else if (Session["role"].Equals("Admin"))
                {
                    LinkButton15.Visible = false;    //user profile
                    LinkButton1.Visible = true;  //hello
                    LinkButton1.Text = "Hello Admin " + Session["username"].ToString();
                    LinkButton2.Visible = true; //log out
                    Button1.Visible = false; //github
                    Button2.Visible = false; //fb
                    LinkButton8.Visible = true; //admin
                    LinkButton9.Visible = true; //user log in
                    LinkButton3.Visible = true; //home
                    LinkButton4.Visible = true;

                }
            }
            catch (Exception ex)
            {


            }
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RLfile/AdminLogin.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RLfile/Login.aspx");
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RLfile/UserProfile.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://github.com/rafi-am7");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.facebook.com/mahmud07119/");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/users/homepage.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["UserName"].ToString() != null)
            {
                    LinkButton1.Text = Session["UserName"].ToString();
            }
            else
            {
                LinkButton1.Visible = false;
            }
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["userid"] = null;
            Session["username"] = null;
            Session["role"] = null;

            LinkButton15.Visible = false;    //user profile
            LinkButton1.Visible = false;  //hello
            LinkButton2.Visible = false; //log out
            Button1.Visible = false; //github
            Button2.Visible = false; //fb
            LinkButton8.Visible = true; //admin
            LinkButton9.Visible = true; //user log in
            LinkButton3.Visible = true; //home

            Response.Redirect("~/users/homepage.aspx");

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RLfile/AdminManagement.aspx");
        }
    }
}