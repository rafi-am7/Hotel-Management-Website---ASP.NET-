<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WonderEarthHotel_X.users.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
    <title>Home Page</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Hotel Booking Widget Responsive, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- //For-Mobile-Apps -->

<!-- Style --> <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />

</head>
<body>
    
    <div>
        <h1>Wander Earth Hotel</h1>

	<div class="hotel">

		<ul class="menu">
				<li class="item1" >
					<a href="" >CHOOSE YOUR HOTEL<i class="menu-down"><img src="images/down.png" alt="" /></i> </a>
						<ul class="cute">
							
							
							

							<li class="subitem1"><asp:LinkButton ID="LinkButton1"  runat="server" OnClick="LinkButton1_Click">Hotel Royal Tulip</asp:LinkButton></li>
							<li class="subitem2"><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Hotel Cox Today</asp:LinkButton></li>
							<li class="subitem3"><asp:LinkButton ID="LinkButton3"  runat="server" OnClick="LinkButton3_Click">Hotel Redision Blue</asp:LinkButton></li>
							<li class="subitem3"><asp:LinkButton ID="LinkButton4"  runat="server" OnClick="LinkButton4_Click">Hotel Seagul</asp:LinkButton></li>
							<li class="subitem1"><asp:LinkButton ID="LinkButton5"  runat="server" OnClick="LinkButton5_Click">Hotel Westinn</asp:LinkButton></li>
							<li class="subitem2"><asp:LinkButton ID="LinkButton6"  runat="server" OnClick="LinkButton6_Click">Hotel Tiger Garden</asp:LinkButton></li>
							<li class="subitem3"><asp:LinkButton ID="LinkButton7"  runat="server" OnClick="LinkButton7_Click">Hotel City Inn</asp:LinkButton></li>
							<li class="subitem3"><asp:LinkButton ID="LinkButton8"  runat="server" OnClick="LinkButton8_Click">Hotel Castle Salam</asp:LinkButton></li>
							<li class="subitem3"><asp:LinkButton ID="LinkButton9"  runat="server" OnClick="LinkButton9_Click">Hotel Kaifeng</asp:LinkButton></li>
						</ul>
				</li>
    	</ul>
		
	</div>


    </div>
  
</body>
</html>

    

</asp:Content>
