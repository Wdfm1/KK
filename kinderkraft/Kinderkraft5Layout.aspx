﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Kinderkraft5Layout.aspx.vb" Inherits="Kinderkraft5Layout" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<!-- TemplateBeginEditable name="head" -->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
 <title></title>
<!-- TemplateEndEditable -->

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
  <div id="ssl"> <a href="https://www.volusion.com/ssl.asp?url=shop.jostenskinderkraft.com"><img src="../images/seal_volusion1.png" width="100" height="113" alt="SSL Certificate" /></a></div></div>

<!-- TemplateBeginEditable name="Content" -->








<!-- TemplateEndEditable -->
</div>

<div id="footer">
  <p><a href="../returns.aspx">Shipping Rates and Returns</a> &nbsp; &#124; &nbsp;  <asp:LinkButton ID="ordstatus" runat="server"  OnClick="ordstatus_Click">Order History</asp:LinkButton> 
  &nbsp; &#124; &nbsp; <a href="http://www.jostenskinderkraft.com/contact.html"> Contact Us</a> &nbsp; &#124; &nbsp; <a href="http://www.jostenskinderkraft.com/kinderkraft_home.html">Home</a></p>
  <p><font size="-6">©2012 Jostens, Inc • All Rights Reserved</font></p>
</div></div>



</form>
</body>
</html>
