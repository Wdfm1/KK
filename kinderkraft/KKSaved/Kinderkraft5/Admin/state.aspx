﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="state.aspx.vb" Inherits="Admin_state" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/KK_Storefront_LayoutSubfolder.dwt" codeOutsideHTMLIsLocked="false" -->

<head>
<!-- InstanceBeginEditable name="head" -->


<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>States/Provinces</title>
<link href="../css/master.css" rel="stylesheet" type="text/css" media="screen"/>
<link href="../css/package.css" rel="stylesheet" type="text/css" media="screen"/>
<link rel="stylesheet" type="text/css" href="../css/cssverticalmenu.css" />
<link href="../css/package_cartpgs.css" rel="stylesheet" type="text/css" />
<link href="../css/productboxes.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../cssverticalmenu.js">

</script>
    
			
		<!-- InstanceEndEditable -->

<link href="../css/cssverticalmenu.css" rel="stylesheet" type="text/css" />
<link href="../css/package.css" rel="stylesheet" type="text/css" />
<link href="../css/package_cartpgs.css" rel="stylesheet" type="text/css" />
<link href="../css/master.css" rel="stylesheet" type="text/css" />
<link href="../css/productboxes.css" rel="stylesheet" type="text/css" />
</head>
 
<body>


<form id="form1" runat="server">

<div id="pagewrapper">
<div id="header">
  <div id="headleft"><br />
	<a href="../shopjostenshome.aspx"> 
	  <img alt="" height="101" src="../images/jostenslogo.PNG" border="0" 
		  width="270" /></a></div>
<div id="headright" style="width: 689px"><br />
	<a href="../shopjostenshome.aspx">
	<img src="../images/Kinderkraft_2.jpg" width="160" height="34" alt="" /></a>
	<p><asp:LinkButton ID="lklogin" runat="server" OnClick="lklogin_Click" 
			>Log In </asp:LinkButton> | <a href="../scart.aspx">View Cart</a></p><br /><br />
<div class="welcome"><asp:Label ID="Label1" runat="server" Text="Welcome, GUEST" Visible="False" ></asp:Label></div>
<div align="left">
  <asp:Label ID="lblcurrentcustomer" runat="server" Text="Current Customer is:" 
        Font-Italic="True" Font-Size="Larger" Visible="False"></asp:Label>
</div>
</div>


<div id="menu">
  <div id="browse"> Browse Products </div>
  <ul id="verticalmenu" class="glossymenu">
	<li><a href="../packages.aspx">Packages</a></li>
	<li><a href="../capsandgowns.aspx" >Caps and Gowns</a></li>
	<li><a href="../tasselsandsashes.aspx">Tassels and Sashes</a></li>
	<li><a href="../diplomasandcertificates.aspx">Diplomas and Certificates</a></li>
	<li><a href="../accessories.aspx" >Accessories</a></li>
   <li><asp:LinkButton ID="LinkButton1" runat="server" Visible="False" 
		PostBackUrl="~/Admin/Admin.aspx">Administration</asp:LinkButton>  </li>
	  
  </ul>
 <div id="ssl"> <img src="../images/verisign.png" width="75" height="38" alt="SSL Certificate" /></div></div>

<!-- InstanceBeginEditable name="Content" -->
<div id="content" style="height: 847px; width: 682px;" align="center">

	<br />
&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        DataSourceID="dsstate" GridLines="Vertical" 
        Width="267px" ShowFooter="True" Height="316px" DataKeyNames="id">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" >
            <ItemStyle Width="25px" />
            </asp:CommandField>
            <asp:TemplateField HeaderText="State Name" SortExpression="name">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtstatename" runat="server" Height="19px" Width="185px"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Height="26px" Text="Insert New Record" 
                        Width="120px" onclick="Button1_Click" />
                    <br />
                </FooterTemplate>
                <ItemTemplate>
                   
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                   
                </ItemTemplate>
                <ItemStyle Width="75px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="State Abrv" SortExpression="abrv">
                <FooterTemplate>
                    <asp:TextBox ID="txtstateabrv" runat="server" Height="19px" Width="145px"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Button" Visible="False" />
                    <br />
                    <br />
                </FooterTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("abrv") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("abrv") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="75px" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" Height="29px" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView><br />
    <asp:Label ID="lblerror" runat="server" ForeColor="Red" Visible="False"></asp:Label>

    <asp:SqlDataSource ID="dsstate" runat="server" 
        ConnectionString="<%$ ConnectionStrings:KK5 %>" 
        ProviderName="<%$ ConnectionStrings:KK5.ProviderName %>" 
        
        SelectCommand="SELECT name, abrv, id FROM states ORDER BY name" 
        
        
        
        
        InsertCommand="INSERT INTO product(prodcode, productprice, productname, prodtype, catopid) VALUES (@Param1, @Param2, @Param3, @Param4, @Param5)" 
        DeleteCommand="DELETE FROM states WHERE (id = @id)">
        <DeleteParameters>
            <asp:ControlParameter ControlID="GridView1" Name="name" 
                PropertyName="SelectedValue" />
        </DeleteParameters>
        <InsertParameters>
            <asp:ControlParameter ControlID="GridView1" Name="productcode" 
                PropertyName="SelectedValue" />
            <asp:ControlParameter ControlID="GridView1" Name="productprice" 
                PropertyName="SelectedValue" />
            <asp:ControlParameter ControlID="GridView1" Name="productname" 
                PropertyName="SelectedValue" />
            <asp:ControlParameter ControlID="GridView1" Name="producttype" 
                PropertyName="SelectedValue" />
            <asp:ControlParameter ControlID="GridView1" Name="catopid" 
                PropertyName="SelectedValue" />
        </InsertParameters>
    </asp:SqlDataSource>

	</div>


<!-- InstanceEndEditable -->
</div>

<div id="footer">
  <p><a href="../returns.aspx">Shipping Rates and Returns</a> &nbsp; &#124; &nbsp;  <asp:LinkButton ID="ordstatus" runat="server"  OnClick="ordstatus_Click">Order History</asp:LinkButton> 
  &nbsp; &#124; &nbsp;<a href="../ChangePassword.aspx">Change Password/User Name</a>  &nbsp; &#124; &nbsp; <a href="http://www.jostenskinderkraft.com/contact.html"> Contact Us</a> &nbsp; &#124; &nbsp; <a href="http://www.jostenskinderkraft.com/kinderkraft_home.html">Home</a></p>
  <p><font size="-6">©2013 Jostens, Inc • All Rights Reserved</font></p>
</div></div>



</form>
</body>
<!-- InstanceEnd --></html>