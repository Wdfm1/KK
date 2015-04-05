<%@ Page Title="" Language="VB"  AutoEventWireup="false" CodeFile="returns.aspx.vb" Inherits="returns" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/KK_Storefront_Layout.dwt" codeOutsideHTMLIsLocked="false" -->

<head>
<!-- InstanceBeginEditable name="head" -->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
 <title>Shipping and Returns</title>
<!-- InstanceEndEditable -->

<link href="css/cssverticalmenu.css" rel="stylesheet" type="text/css" />
<link href="css/package.css" rel="stylesheet" type="text/css" />
<link href="css/package_cartpgs.css" rel="stylesheet" type="text/css" />
<link href="css/master.css" rel="stylesheet" type="text/css" />
<link href="css/productboxes.css" rel="stylesheet" type="text/css" />
</head> 

<body>

<form id="form1" runat="server">

<div id="pagewrapper">
	<div id="header">
  		<div id="headleft"><br />
			<a href="shopjostenshome.aspx"> 
	  			<img alt="" height="101" src="images/jostenslogo.PNG" border="0" width="270" /></a>
</div>
			<div id="headright" style="width: 689px"><br />
				<a href="shopjostenshome.aspx">
						<img src="images/Kinderkraft_2.jpg" width="160" height="34" alt="" /></a>
							<p><asp:LinkButton ID="lklogin" runat="server" OnClick="lklogin_Click">Log In </asp:LinkButton> | <a href="scart.aspx">View Cart</a>
                            </p>
                            <br />
                            <br />
						<div class="welcome"><asp:Label ID="Label1" runat="server" Text="Welcome, GUEST" Visible="False" ></asp:Label>
                        </div>
							<div align="left">
   								<asp:Label ID="lblcurrentcustomer" runat="server" Text="Current Customer is:" Font-Italic="True" Font-Size="Larger" Visible="False"></asp:Label>
	</div>
		</div>
			</div>

<div id="menu">
  <div id="browse"> Browse Products 
  </div>
  
  <ul id="verticalmenu" class="glossymenu">
	<li><a href="packages.aspx">Packages</a></li>
	<li><a href="capsandgowns.aspx" >Caps and Gowns</a></li>
	<li><a href="tasselsandsashes.aspx">Tassels and Sashes</a></li>
	<li><a href="diplomasandcertificates.aspx">Diplomas and Certificates</a></li>
	<li><a href="accessories.aspx" >Accessories</a></li>
    <li><a href="clearance.aspx" >Clearance</a></li>
   	<li><asp:LinkButton ID="LinkButton1" runat="server" Visible="False" 
		PostBackUrl="~/Admin/Admin.aspx">Administration</asp:LinkButton></li>
 </ul>
  
  	<div id="ssl"> <img src="images/verisign.png" width="75" height="38" alt="SSL Certificate" />
    </div>
</div>

<!-- InstanceBeginEditable name="Content" -->

<div id="content">

		<table class="style1">
            <tr>
                <td class="style2" colspan="4">
                    Shipping and Returns</td>
            </tr>
            <tr>
                <td colspan="4">
                    <strong>How do I return an item?</strong>
                    <br />
                    Please contact customer service at 855-826-2355 for more infomation on returning 
                    an item.<br />
                    <br /></td>
          </tr></table>
                    <table width="665" class="shipping"><tr><td colspan="4">
                    <strong>Shipping<br />
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Total Amount Spent</td>
                <td>
                    Standard 
                    Delivery<br />
                    <em><span class="style4">(10 business days)</span></em></td>
                <td>
                    Expedited
                    Delivery<br />
                    <em><span class="style4">(2-9 business days)</span></em></td>
                <td>
                    Alaska/Hawaii/Canada<br />
                    International
                    <br />
                    <em><span class="style4">(10 business days)</span></em></td>
            </tr>
            <tr>
                <td class="style3">
                    $.01-$49.99<br />
                    <br />
                </td>
                <td>
                    $11.50<br />
                    <br />
                </td>
                <td>
                    $46.50<br />
                    <br />
                </td>
                <td>
                    $35.50<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    $50.00-$149.99<br />
                    <br />
                </td>
                <td>
                    $14.50<br />
                    <br />
                </td>
                <td>
                    $49.50<br />
                    <br />
                </td>
                <td>
                    $42.50<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    $150.00-$299.00<br />
                    <br />
                </td>
                <td>
                    $16.50<br />
                    <br />
                </td>
                <td>
                    $51.50<br />
                    <br />
                </td>
                <td>
                    $56.50<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    $300.00-$449.99<br />
                    <br />
                </td>
                <td>
                    $21.50<br />
                    <br />
                </td>
                <td>
                    $76.50<br />
                    <br />
                </td>
                <td>
                    $75.50<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    $450.00+<br />
                    <br />
                </td>
                <td>
                    $25.00<br />
                    <br />
                </td>
                <td>
                    $125.00<br />
                    <br />
                </td>
                <td>
                    $100.00<br />
                    <br />
                </td>
            </tr>
        </table><br />
</div>









<!-- InstanceEndEditable -->

<div id="footer">
  		<p><a href="returns.aspx">Shipping Rates and Returns</a> &nbsp; &#124; &nbsp;  <asp:LinkButton ID="ordstatus" runat="server"  OnClick="ordstatus_Click">Order History</asp:LinkButton> &nbsp; &#124; &nbsp; 
          <a href="ChangePassword.aspx">Change Password/User Name</a> &nbsp;  &#124; &nbsp;
          <a href="http://www.jostenskinderkraft.com/contact.html"> Contact Us</a> &nbsp; &#124; &nbsp; 
          <a href="http://www.jostenskinderkraft.com/kinderkraft_home.html">Home</a></p>
  		<p><font size="-6">©2013 Jostens, Inc • All Rights Reserved</font></p>
</div>
</div>
</form>
</body>
<!-- InstanceEnd --></html>
