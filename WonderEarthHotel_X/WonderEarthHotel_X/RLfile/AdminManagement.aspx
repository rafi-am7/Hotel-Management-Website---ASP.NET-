<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminManagement.aspx.cs" Inherits="WonderEarthHotel_X.RLfile.AdminManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <div class="container-fluid row">
    <div class="container-fluid col-md-6">
    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
<div class="col-md-4 col-md-offset-4">
<h1>Wander Earth Hotel</h1>
</div>
    <section>
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtStdname"><b>Booking ID</b></asp:Label><br />
            <asp:TextBox runat="server" required="required" Enabled="True" name="BrandName" Width="80%" ID="TextBox1" class="form-control input-sm" placeholder="Booking ID Name"></asp:TextBox>
            <br/>
       
            <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg" Width="120px" runat="server" Text="GO" OnClick="Button1_Click" />
            
        </div>

    </section>

</header>
<div class="panel-body">
<div class="row">
<div class="col-md col-md-offset-1">
<div class="form-group">
    <br/>
<asp:Label runat="server" AssociatedControlID="txtStdname"><b>Customer Name</b></asp:Label>
    <br/>
<asp:TextBox runat="server"  Enabled="True" name="BrandName" ID="txtStdname" class="form-control input-sm" Width="80%" placeholder="Customer Name"></asp:TextBox>
    <br/>
</div>
</div>
</div>
<div class="row col-md-offset-1">
<div class="form-group">
    <br/>
<asp:Label runat="server" AssociatedControlID="txtfname"><b>RoomNo</b></asp:Label>
    <br/>
<asp:TextBox runat="server"  Enabled="True" name="BrandName" ID="txtfname" class="form-control input-sm" Width="80%" placeholder="Room No"></asp:TextBox>
    <br/>
</div>
</div>


<div class="row">
<div class="col-md col-md-offset-1">
    <div class="form-group">
        <br/>
        <asp:Label runat="server" AssociatedControlID="txtfname"><b>Payment</b></asp:Label>
        <br/>
        <asp:TextBox runat="server"  Enabled="True" name="BrandName" ID="TextBox2" class="form-control input-sm" Width="80%" placeholder="Father Name"></asp:TextBox>
    </div>
</div>

</div>

    <br/>
    <br/>
    <br/>
    <br/>

<div class="row">
<div class="col-md-10 col-md-offset-1">
<div class="form-group">

<asp:Button Text="Update" ID="btnupdate"  CssClass="btn btn-primary btn-lg" Width="30%" runat="server" OnClick="btnupdate_Click" />
<asp:Button Text="Delete" ID="btndlt"  CssClass="btn btn-danger btn-lg" Width="30%" runat="server" OnClick="btndlt_Click" />

</div>
</div>

</div>


</div>
</section>
</div>
</div>
</section>
</section>
    </div>
        <div class="container-fluid col-md-6">
            
            
        
                <div class="col-md-10 col-md-offset-1">
                    <div class="form-group">
                        <div class="table-responsive">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HotelManagementConnectionString3 %>" SelectCommand="SELECT [ID], [RoomNo], [status] FROM [booking1] ORDER BY [ID] DESC"></asp:SqlDataSource>
                            <asp:GridView ID="GridView1" Width="100%" SelectedRowStyle-BackColor="Green"  runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" AllowSorting="True">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                                    <asp:BoundField DataField="RoomNo" HeaderText="RoomNo" SortExpression="RoomNo" />
                                    <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                                </Columns>
<SelectedRowStyle BackColor="Green"></SelectedRowStyle>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>

        

    </div>
    
    
    

    
</asp:Content>


