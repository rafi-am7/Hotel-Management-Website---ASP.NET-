<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WonderEarthHotel_X.RLfile.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

    <html>
    <head >
        <title>Login </title>

        <!-- meta tags -->
        <meta charset="UTF-8" />
        <meta content="width=device-width, initial-scale=1.0" name="viewport" />
        <meta content="Art Sign Up Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, 
		Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design" name="keywords" />
        <!-- /meta tags -->
        <!-- custom style sheet -->
        <link href="css/style.css" rel="stylesheet" type="text/css" />
        <!-- /custom style sheet -->
        <!-- fontawesome css -->
        <link href="css/fontawesome-all.css" rel="stylesheet" />
        <!-- /fontawesome css -->
        <!-- google fonts-->
        <link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i"
            rel="stylesheet" />
        <!-- /google fonts-->


    </head>
    <body>
        
            <div>


                <h1>Wander Earth Hotel</h1>
                <div class=" w3l-login-form">
                    <h1>Sign In</h1>
                    


                        <div class=" w3l-form-group">
                            <label>Username:</label>
                            <div class="group">
                                <i class="fas fa-user"></i>
                                <asp:TextBox ID="txt_login_username" runat="server" class="form-control" placeholder="Username"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Username" required="required" />--%>
                            </div>
                        </div>




                        <div class=" w3l-form-group">
                            <label>Password:</label>
                            <div class="group">
                                <i class="fas fa-unlock icon-cog"></i>
                                <asp:TextBox ID="txt_login_password" runat="server" class="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>

                            </div>
                        </div>



                        <div>
                           
                            <p>
                                <asp:CheckBox ID="CheckBox1" runat="server" />  Remember Me
                            </p>
                        </div>
                    <center>
                        <asp:Button ID="btn_login" CssClass="btn btn-lg btn-block btn-success" runat="server" BackColor="#FF018786"
                            Font-Bold="True" Font-Size="Medium" ForeColor="#FFFFCC"
                            
                            Text="Login" OnClick="btn_login_Click" />

                    </center>
                    
                  
                    
                    
                    
                    

                    <p class=" w3l-register-p">
                        <asp:LinkButton ID="LinkButton1" runat="server"  Font-Bold="True"
                            Font-Size="Medium"   ForeColor="#FF018786" OnClick="LinkButton1_Click"
                           >Sign Up</asp:LinkButton>
                    </p>
                    <%--<p class=" w3l-register-p">Sign Up<a href="Registration.aspx" class="register"> Registration</a></p>--%>
                </div>
                <footer>
                    <p class="copyright-agileinfo">&copy; 2022  Login . All Rights Reserved | Design by <a href="#">Rafi</a></p>
                </footer>



            </div>
     
    </body>
    </html>




</asp:Content>
