<%@ Page Title="Place Order" Language="VB"  AutoEventWireup="false" CodeFile="invoice.aspx.vb" Inherits="invoice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/KK_Storefront_Layout.dwt" codeOutsideHTMLIsLocked="false" -->

<head>
<!-- InstanceBeginEditable name="head" -->

    <style type="text/css">
        #container
        {
            height: 48px;
            width: 671px;
        }
        .style42
        {
            font-size: 90%;
            width: 238px;
        }
        .style44
        {
            font-size: 90%;
            width: 313px;
        }
        .style45
        {
            font-size: 90%;
            width: 313px;
            height: 27px;
        }
        .style47
        {
            font-size: 90%;
            height: 28px;
        }
        .style48
        {
            font-size: 90%;
            height: 27px;
        }
        .style49
        {
            font-size: 90%;
            width: 313px;
            height: 31px;
        }
        .style50
        {
            font-size: 90%;
            height: 31px;
        }
        .style51
        {
            font-size: 90%;
            width: 313px;
            height: 24px;
        }
        .style52
        {
            font-size: 90%;
            height: 24px;
        }
        </style>


<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Check Out</title>
<script type="text/javascript" src="cssverticalmenu.js">

</script>

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

<div id="content" style="height: auto; ">

    <asp:FormView ID="FormView1" runat="server" Height="493px" Width="694px" 
        DataSourceID="DSCust" DefaultMode="Edit" DataKeyNames="custid">
 <ItemTemplate>
           
   </ItemTemplate>
 <InsertItemTemplate>
         
          <div class="step_one">
              <img src="images/KK_billing.jpg" alt="" width="600" height="50" /><br />
          </div>
          <p class="req_field_val">*Required Fields</p> 
          <div class="invoice">
            <table width="700" border="0" cellspacing="1" cellpadding="2">
              <tr align="left" valign="baseline">
                <td colspan="2" class="invoice_heading">Billing Information...</td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">*First Name:</td>
                <td width="445" align="left" valign="top" class="field_label">
					<asp:TextBox ID="fname1" runat="server" Height="24px" 
						Text='<%# Bind("fname") %>'  style="text-transform:uppercase;" Width="244px" 
                        CausesValidation="True" TabIndex="1" ></asp:TextBox> <div class="req_field_val">
						<asp:RequiredFieldValidator ControlToValidate="fname1" Display="Dynamic" 
							ErrorMessage="First Name Required" ID="RequiredFieldValidator1" runat="server" 
							ValidationGroup="g2" TabIndex="60" ></asp:RequiredFieldValidator></div>
                    </td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">*Last Name:</td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="lname" 
                        runat="server" TabIndex="1" Height="24px" Text='<%# Bind("lname") %>'  
                        style="text-transform:uppercase;"  Width="244px" CausesValidation="True" ></asp:TextBox>
               <div class="req_field_val"> 
				   <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
					   ControlToValidate="lname" Display="Dynamic" ErrorMessage="Last Name Required" 
					   validationgroup="g2" TabIndex="60"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">School or Business Name: </td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="company" runat="server" TabIndex="2" Height="24px" Text='<%# Bind("CompanyName") %>'  style="text-transform:uppercase;" Width="244px" CausesValidation="True" ></asp:TextBox></td>
              </tr>
              
              <tr>
                <td align="right" valign="baseline" class="style44">*Address:
           </td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="addr1" 
                        runat="server" TabIndex="3" Width="244px" Height="23px" 
                        Text='<%# Bind("billingaddr1") %>'  style="text-transform:uppercase;" 
                        CausesValidation="True" ></asp:TextBox>
                   <div class="req_field_val"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
						   runat="server" ControlToValidate="addr1" Display="Dynamic" 
						   ErrorMessage="Address Required" ValidationGroup="g2" TabIndex="60"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">Address2:
           </td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="addr2" 
                        runat="server" TabIndex="4" Width="244px" Height="24px" 
                        Text='<%# Bind("billingaddr2") %>'  style="text-transform:uppercase;" 
                        CausesValidation="True" ></asp:TextBox></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">*City:</td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="city" 
                        runat="server" TabIndex="5" Height="24px" Text='<%# Bind("city") %>' 
                        Width="244px"  style="text-transform:uppercase;" CausesValidation="True" ></asp:TextBox>
               <div class="req_field_val"> 
				   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
					   ControlToValidate="city" Display="Dynamic" ErrorMessage="City Required" 
					   ValidationGroup="g2" TabIndex="60"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">
                    
                    &nbsp;&nbsp;&nbsp; *State/Province:</td>
                <td align="left" valign="top" class="field_label">
               
                    <asp:DropDownList ID="ddlstateins" runat="server" Width="150px" TabIndex="6" 
                        Height="24px" DataSourceID="dsstates" DataTextField="name" 
                        DataValueField="abrv" SelectedValue='<%# Bind("state") %>' 
                        CausesValidation="True" AppendDataBoundItems="True" AutoPostBack="True" 
                        onselectedindexchanged="ddlstateins_SelectedIndexChanged" 
                        ondatabound="ddlstateins_DataBound" ToolTip="Check International If Not Listed" 
                        > <asp:ListItem></asp:ListItem> 
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox1" runat="server" Height="21px"  
                        style="text-transform:uppercase;" Width="203px" Visible="False" 
                        AutoPostBack="True" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                <div class="req_field_val">
					<asp:RequiredFieldValidator ID="RequiredFieldValidator66" 
						runat="server" ControlToValidate="ddlstateins" Display="Dynamic" 
						ErrorMessage="State Required" ValidationGroup="g2" TabIndex="60"></asp:RequiredFieldValidator></div> 
                       
                        </td>
              </tr>
                <tr>
                    <td align="right" class="style45" valign="baseline">
                      <asp:CheckBox ID="chkinternational" runat="server" Text="International Address" 
                        Checked='<%# Bind("international") %>' AutoPostBack="True" 
                        oncheckedchanged="chkinternational_CheckedChanged1" />  &nbsp;&nbsp; Country:</td>
                    <td align="left" class="style48" valign="top">
                        <asp:DropDownList ID="ddlcountry1" runat="server" AppendDataBoundItems="True" 
                            Height="25px" DataSourceID="dscountry" 
                            DataTextField="name" DataValueField="abbrev" Width="173px" 
                            AutoPostBack="True"   SelectedValue='<%# Bind("country") %>' 
                            onselectedindexchanged="ddlcountry1_SelectedIndexChanged1" >
                            <asp:ListItem Value="US">UNITED STATES</asp:ListItem>
                        </asp:DropDownList>
                        <div class="req_field_val">
                            <asp:CustomValidator ID="cvcountryins" runat="server" 
                                ErrorMessage="US Is not International" 
                                onservervalidate="cvcountryins_ServerValidate"></asp:CustomValidator>
                        </div>
                    </td>
                </tr>
              <tr>
                <td align="right" valign="baseline" class="style49">*Zip Code:</td>
                <td align="left" valign="top" class="style50">
                    <asp:TextBox ID="zip" 
                        runat="server" TabIndex="7" Height="23px" Text='<%# Bind("postalcode") %>' 
                        CausesValidation="True" Width="244px" MaxLength="6" ></asp:TextBox><div class="req_field_val">
						<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
							ControlToValidate="zip" Display="Dynamic" ErrorMessage="Zip Code Required" 
							ValidationGroup="g2" TabIndex="60"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style51"> *Phone Number:</td>
                <td align="left" valign="top" class="style52"> 
                    <asp:TextBox ID="phonenumber1" runat="server" 
                        TabIndex="8" Height="24px" CausesValidation="True" 
                        Text='<%# bind("phonenumber") %>' Width="244px" MaxLength="15"></asp:TextBox>
                        <div class="req_field_val">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator111112" runat="server" 
                        ErrorMessage="Phone# Required" ControlToValidate="phonenumber1" 
                        Display="Dynamic" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">*Email Address:</td>
                <td align="left" valign="top" class="field_label">
                    <asp:TextBox ID="emailaddress" 
                        runat="server" CausesValidation="True" Text='<%# Bind("EmailAddress") %>' 
                        Height="22px" Width="244px" TabIndex="9" MaxLength="45"></asp:TextBox>
                <div class="req_field_val"><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Email Required" ControlToValidate="emailaddress" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              
                <tr align="left" valign="baseline">
                    <td colspan="2" class="field_label">
                         How did you hear about us?&nbsp; 
                        <asp:DropDownList ID="ddlhear" runat="server" 
           TabIndex="10" Height="22px" Width="259px" 
           SelectedValue='<%# Bind("refby") %>'   >
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Internet Search</asp:ListItem>
        <asp:ListItem>Email</asp:ListItem>
        <asp:ListItem>Word of Mouth</asp:ListItem>
        <asp:ListItem>Returning Customer</asp:ListItem>
        					<asp:ListItem>Catolog Mailing</asp:ListItem>
							<asp:ListItem>Other Direct Mail</asp:ListItem>
							<asp:ListItem>Jostens.com</asp:ListItem>
        					<asp:ListItem> Other Direct Mail</asp:ListItem>
        </asp:DropDownList>                      <asp:Button ID="btninsertcopy" runat="server" 
							 Height="31px" Text="Copy Information To Shipping" 
                            Width="194px" onclick="btninsertcopy_Click" TabIndex="11"  /></td>
                </tr>
  </table>
          </div>

       <hr />
       
      
            
       <div class="invoice"> <table width="700" border="0" cellspacing="1" cellpadding="2">
              <tr align="right" valign="baseline">
                <td colspan="2" align="left" class="invoice_heading">Shipping Information...</td>
              </tr>
              <tr>
                <td width="244" align="right" valign="baseline" class="field_label">*First Name: 
               </td>
                <td width="445" class="field_label">
                    <asp:TextBox ID="sfname" runat="server" 
						Height="22px" Text='<%# Bind("sfname") %>'  style="text-transform:uppercase;"
                        Width="244px" CausesValidation="True" ValidationGroup="g2" TabIndex="12" ></asp:TextBox>
                    <div class="req_field_val"><asp:RequiredFieldValidator ID="fvfname" runat="server" 
                        ControlToValidate="sfname" Display="Dynamic" 
                        ErrorMessage="First Name Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*Last Name:</td>
                <td class="field_label">
					<asp:TextBox 
                        ID="slname" runat="server" TabIndex="13" Height="22px" 
Text='<%# Bind("slname") %>'  style="text-transform:uppercase;" Width="244px" 
                        CausesValidation="True"    ></asp:TextBox>			                    <div class="req_field_val"><asp:RequiredFieldValidator ID="fvlname" 
                        runat="server" ControlToValidate="slname" Display="Dynamic" 
                        ErrorMessage="Last Name Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              
              <tr>
                <td align="right" valign="baseline" class="field_label">School or Business Name: 
                </td>
                <td class="field_label"><asp:TextBox ID="scompany" runat="server" TabIndex="14" Height="22px" 
                        Text='<%# Bind("scompanyname") %>'  style="text-transform:uppercase;" 
                        Width="244px"  ></asp:TextBox></td>
              </tr>
              
              <tr>
                <td align="right" valign="baseline" class="field_label">*Address:
           </td>
                <td class="field_label"><asp:TextBox ID="saddr1" runat="server" TabIndex="15" 
                        Width="244px" Height="22px" 
                        Text='<%# Bind("saddr1") %>'  style="text-transform:uppercase;" 
                        CausesValidation="True" ></asp:TextBox>
                        <div class="req_field_val">
                       <asp:RequiredFieldValidator ID="fvaddr" runat="server" 
                        ControlToValidate="saddr1" Display="Dynamic" 
                        ErrorMessage="Address Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div>
           </td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">Address2:</td>
                <td class="field_label"><asp:TextBox ID="saddr2" runat="server" TabIndex="16" 
                        Width="244px" Height="22px" 
                        Text='<%# Bind("saddr2") %>'  style="text-transform:uppercase;" ></asp:TextBox></td>
              </tr>
              
              <tr>
                <td align="right" valign="baseline" class="field_label">City: 
        </td>
                <td class="style42"><asp:TextBox ID="scity" runat="server" TabIndex="17" Height="22px" 
            Text='<%# Bind("scity") %>'  style="text-transform:uppercase;" Width="244px" 
                        CausesValidation="True" ></asp:TextBox> 
                <div class="req_field_val"><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator11111" runat="server" ControlToValidate="scity" 
                        Display="Dynamic" ErrorMessage="City Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">
                    
                    &nbsp;&nbsp;&nbsp; *State/Province:</td>
                <td class="field_label">
                
					<asp:DropDownList 
            ID="sddlstate" runat="server" Width="152px" TabIndex="18" Height="22px" 
                        SelectedValue='<%# Bind("sstate", "{0}") %>' DataSourceID="dsstates" 
                        DataTextField="name" DataValueField="abrv" CausesValidation="True" 
                        AppendDataBoundItems="True" AutoPostBack="True" 
                        onselectedindexchanged="sddlstate_SelectedIndexChanged" 
                        ondatabound="sddlstate_DataBound" 
                        ToolTip="Check International If Not Listed" > <asp:ListItem></asp:ListItem> 
                    </asp:DropDownList>
                       <asp:TextBox ID="TextBox2" runat="server" Height="25px" 
                        Text='<%# Bind("sstate", "{0}") %>'   style="text-transform:uppercase;" 
                        Width="225px" AutoPostBack="True" 
                        ontextchanged="TextBox2_TextChanged" Visible="False"></asp:TextBox>
                       <div class="req_field_val"> 
                           <asp:RequiredFieldValidator ID="fvstate1" runat="server" 
                        ControlToValidate="sddlstate" Display="Dynamic" 
                        ErrorMessage="State Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div>
                 
              
                        </td>
              </tr>
              <tr>
                  <td align="right" class="field_label" valign="baseline">
                      <asp:CheckBox ID="chkint11" runat="server" Text="International Address" 
                        Checked='<%# Bind("sinternational") %>' AutoPostBack="True" 
                        oncheckedchanged="chkint11_CheckedChanged" />&nbsp;&nbsp; Country:</td>
                  <td class="field_label">
                     <asp:DropDownList ID="sddlcountry1" runat="server" AppendDataBoundItems="True" 
                            Height="25px" DataSourceID="dscountry" 
                            DataTextField="name" DataValueField="abbrev" Width="173px" 
                          AutoPostBack="True" SelectedValue='<%# Bind("scountry") %>' 
                          onselectedindexchanged="sddlcountry1_SelectedIndexChanged">
                        <asp:ListItem Value="US">UNITED STATES</asp:ListItem>
                        </asp:DropDownList> <div class="req_field_val">
                            <asp:CustomValidator ID="cvcountry1ins" runat="server" 
                                ErrorMessage="US Is not International" 
                                onservervalidate="cvcountry1ins_ServerValidate"></asp:CustomValidator>
                        </div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*Zip Code:</td>
                <td class="style42">
					<asp:TextBox ID="szip" 
                        runat="server" TabIndex="19" Height="20px" Text='<%# Bind("spostalcode") %>' 
                        Width="244px" CausesValidation="True" MaxLength="6" ></asp:TextBox>
                        <div class="req_field_val"><asp:RequiredFieldValidator ID="fvzip" runat="server" 
                        ControlToValidate="szip" Display="Dynamic" ErrorMessage="Zip Code Required" 
                        ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
             
              <tr>
                <td align="right" valign="baseline" class="field_label"> Phone Number:
                </td>
                <td class="field_label">
                    <asp:TextBox ID="sphone" runat="server" TabIndex="20" Height="22px" 
                        Text='<%# Bind("sphonenumber") %>' Width="244px" MaxLength="15" ></asp:TextBox> </td>
              </tr>
              
              <tr align="right" valign="baseline">
                <td colspan="2" class="field_label">&nbsp;
   </td>
              </tr>
              <tr align="right" valign="baseline">
                <td colspan="2"> <asp:HiddenField ID="hfcustid" runat="server" Value='<%# eval("custid") %>' />
       <asp:Button ID="btninsert" runat="server" Text="Continue" CommandName="Insert" TabIndex="21" 
                        onclick="Button1_Click2" 
                       /></td>
              </tr>
  </table></div>
  
  
</InsertItemTemplate>


<EditItemTemplate>
          <div class="step_one">
              <img src="images/KK_billing.jpg" alt="" width="600" height="50" /></div>
              <p class="req_field_val">*Required Fields</p> 
           <div class="invoice">
            <table width="700" border="0" cellspacing="1" cellpadding="2">
              <tr align="left" valign="baseline">
                <td colspan="2" class="invoice_heading">Billing Information<asp:Label ID="Label2" 
                        runat="server" Text="e" Font-Size="1pt"></asp:Label></td>
              </tr>
              <tr>
                <td width="293" align="right" valign="baseline" class="field_label">*First Name:</td>
                <td width="396" align="left" valign="top" class="field_label">
					<asp:TextBox ID="fname" runat="server" Height="24px" 
						Text='<%# Bind("fname") %>'  style="text-transform:uppercase;" Width="170px" CausesValidation="True" TabIndex="1" ></asp:TextBox> <div class="req_field_val">
						<asp:RequiredFieldValidator ControlToValidate="fname" Display="Dynamic" 
							ErrorMessage="First Name Required" ID="RequiredFieldValidator1" runat="server" 
							ValidationGroup="g2" TabIndex="60" ></asp:RequiredFieldValidator></div>
                    </td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*Last Name:</td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="lname" runat="server" TabIndex="1" Height="24px" Text='<%# Bind("lname") %>'  style="text-transform:uppercase;" Width="173px" CausesValidation="True" ></asp:TextBox>
               <div class="req_field_val"> 
				   <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
					   ControlToValidate="lname" Display="Dynamic" ErrorMessage="Last Name Required" 
					   validationgroup="g2" TabIndex="60"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">School or Business Name: </td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="company" runat="server" TabIndex="2" Height="24px" Text='<%# Bind("CompanyName") %>'  style="text-transform:uppercase;" Width="244px" CausesValidation="True" ></asp:TextBox></td>
              </tr>
              
              <tr>
                <td align="right" valign="baseline" class="field_label">*Address:
           </td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="addr1" runat="server" TabIndex="3" Width="178px" Height="23px" 
                        Text='<%# Bind("billingaddr1") %>'  style="text-transform:uppercase;" CausesValidation="True" ></asp:TextBox>
                   <div class="req_field_val"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
						   runat="server" ControlToValidate="addr1" Display="Dynamic" 
						   ErrorMessage="Address Required" ValidationGroup="g2" TabIndex="60"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">Address2:
           </td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="addr2" runat="server" TabIndex="4" Width="176px" Height="24px" Text='<%# Bind("billingaddr2") %>'  style="text-transform:uppercase;" CausesValidation="True" ></asp:TextBox></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*City:</td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="city" runat="server" TabIndex="5" Height="24px" Text='<%# Bind("city") %>'  style="text-transform:uppercase;" Width="138px" CausesValidation="True" ></asp:TextBox>
               <div class="req_field_val"> 
				   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
					   ControlToValidate="city" Display="Dynamic" ErrorMessage="City Required" 
					   ValidationGroup="g2" TabIndex="50"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">
                    
                    &nbsp;&nbsp;&nbsp; *State/Province:</td>
                <td align="left" valign="top" class="field_label">
                
                   <asp:DropDownList ID="ddlstate" 
                        runat="server" Width="150px" TabIndex="6" Height="24px" DataSourceID="dsstates" 
                        DataTextField="name" DataValueField="abrv" 
                        CausesValidation="True" AppendDataBoundItems="True" AutoPostBack="True" 
                        onselectedindexchanged="ddlstate_SelectedIndexChanged" 
                       ondatabound="ddlstate_DataBound" SelectedValue='<%# Bind("state") %>' 
                        ToolTip="Check International If Not Listed" > <asp:ListItem></asp:ListItem> 
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox3" runat="server" Height="23px" Visible="False"   
                        style="text-transform:uppercase;" Width="179px" 
                        ontextchanged="TextBox3_TextChanged" AutoPostBack="True" 
                        Text='<%# Bind("state") %>'></asp:TextBox>
                <div class="req_field_val"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlstate" Display="Dynamic" ErrorMessage="State Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div> 
                </td>
              </tr>
                <tr>
                    <td align="right" class="style47" valign="baseline">
                        <asp:CheckBox ID="chkint2edt" runat="server" Text="International Address" 
                        Checked='<%# Bind("international") %>' 
                      AutoPostBack="True" oncheckedchanged="chkint2edt_CheckedChanged"  />&nbsp;&nbsp;&nbsp;&nbsp; Country:</td>
                    <td align="left" class="style47" valign="top">
                      <asp:DropDownList ID="ddlcountryedt" runat="server" AppendDataBoundItems="True" 
                            Height="25px" DataSourceID="dscountry" 
                            DataTextField="name" DataValueField="abbrev" Width="173px" 
                            onselectedindexchanged="ddlcountryedt_SelectedIndexChanged" AutoPostBack="True" 
                            >
                          <asp:ListItem Value="US">UNITED STATES</asp:ListItem>
                        </asp:DropDownList> <div class="req_field_val">
                            <asp:CustomValidator ID="cvcountryedt" runat="server" 
                                ErrorMessage="US Is not International" 
                                onservervalidate="cvcountryedt_ServerValidate"></asp:CustomValidator>
                        </div></td>
                </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*Zip Code:</td>
                <td align="left" valign="top" class="field_label">
                    <asp:TextBox ID="zip" 
                        runat="server" TabIndex="7" Height="25px" Text='<%# Bind("postalcode") %>' 
                        CausesValidation="True" Width="139px" MaxLength="6" ></asp:TextBox><div class="req_field_val"><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="zip" Display="Dynamic" ErrorMessage="Zip Code Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label"> *Phone Number:</td>
                <td align="left" valign="top" class="field_label"> 
                    <asp:TextBox ID="phonenumber" runat="server" 
                        TabIndex="8" Height="24px" CausesValidation="True" 
                        Text='<%# bind("phonenumber") %>' MaxLength="15"></asp:TextBox>
                        <div class="req_field_val"><asp:RequiredFieldValidator ID="RequiredFieldValidator11112" runat="server" 
                        ErrorMessage="Phone# Required" ControlToValidate="phonenumber" 
                        Display="Dynamic" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*Email Address:</td>
                <td align="left" valign="top" class="field_label"><asp:TextBox ID="emailaddress" 
                        runat="server" CausesValidation="True" Text='<%# Bind("EmailAddress") %>' 
                        Height="22px" Width="223px" TabIndex="9" MaxLength="45"></asp:TextBox>
                <div class="req_field_val"><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Email Required" ControlToValidate="emailaddress" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              
                <tr align="left" valign="baseline">
                    <td colspan="2" class="field_label">
                         How did you hear about us?&nbsp; 
                        <asp:DropDownList ID="ddlhear" runat="server" 
           TabIndex="10" Height="22px" Width="259px" 
           SelectedValue='<%# Bind("refby") %>'   >
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Internet Search</asp:ListItem>
        <asp:ListItem>Email</asp:ListItem>
        <asp:ListItem>Word of Mouth</asp:ListItem>
        <asp:ListItem>Returning Customer</asp:ListItem>
        					<asp:ListItem>Catolog Mailing</asp:ListItem>
							<asp:ListItem>Other Direct Mail</asp:ListItem>
							<asp:ListItem>Jostens.com</asp:ListItem>
        </asp:DropDownList>                      
						 <asp:Button ID="btneditcopy" runat="server" 
							 Height="31px" Text="Copy Information To Shipping" 
                            Width="194px" onclick="btneditcopy_Click" TabIndex="11"  /></td>
                </tr>
  </table>
          </div>

       <hr />
       
      
            
       <div class="invoice"> <table width="700" border="0" cellspacing="1" cellpadding="2">
              <tr align="right" valign="baseline">
                <td colspan="2" align="left" class="invoice_heading">Shipping Information</td>
              </tr>
              <tr>
                <td width="295" align="right" valign="baseline" class="field_label">*First Name: 
               </td>
                <td width="394" class="field_label">
					<asp:TextBox ID="sfname" runat="server" 
						Height="22px" Text='<%# Bind("sfname") %>'  style="text-transform:uppercase;"
                        Width="157px" CausesValidation="True" ValidationGroup="g2" TabIndex="12" ></asp:TextBox>
                    <div class="req_field_val"><asp:RequiredFieldValidator ID="fvfname" runat="server" 
                        ControlToValidate="sfname" Display="Dynamic" 
                        ErrorMessage="First Name Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*Last Name:</td>
                <td class="field_label">
					<asp:TextBox 
                        ID="slname" runat="server" TabIndex="13" Height="22px" 
Text='<%# Bind("slname") %>'  style="text-transform:uppercase;" Width="171px" CausesValidation="True"    ></asp:TextBox>			                    <div class="req_field_val"><asp:RequiredFieldValidator ID="fvlname" 
                        runat="server" ControlToValidate="slname" Display="Dynamic" 
                        ErrorMessage="Last Name Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="req_field_val"></td>
                <td class="req_field_val">
                </td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">School or Business Name: 
                </td>
                <td class="field_label">
					<asp:TextBox ID="scompany" runat="server" TabIndex="14" Height="22px" 
                        Text='<%# Bind("scompanyname") %>'  style="text-transform:uppercase;" Width="333px"  ></asp:TextBox></td>
              </tr>
              
              <tr>
                <td align="right" valign="baseline" class="field_label">*Address:
           </td>
                <td class="field_label">
					<asp:TextBox ID="saddr1" runat="server" TabIndex="15" 
						Width="178px" Height="22px" 
                        Text='<%# Bind("saddr1") %>'  style="text-transform:uppercase;" CausesValidation="True" ></asp:TextBox>
                        <div class="req_field_val">
                       <asp:RequiredFieldValidator ID="fvaddr" runat="server" 
                        ControlToValidate="saddr1" Display="Dynamic" 
                        ErrorMessage="Address Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div>
           </td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">Address2:</td>
                <td class="field_label">
					<asp:TextBox ID="saddr2" runat="server" TabIndex="16" 
						Width="175px" Height="22px" 
                        Text='<%# Bind("saddr2") %>'  style="text-transform:uppercase;" ></asp:TextBox></td>
              </tr>
              
              <tr>
                <td align="right" valign="baseline" class="field_label">City: 
        </td>
                <td class="style42">
					<asp:TextBox ID="scity" runat="server" TabIndex="17" Height="22px" 
            Text='<%# Bind("scity") %>'  style="text-transform:uppercase;" Width="154px" CausesValidation="True" ></asp:TextBox> 
                <div class="req_field_val"><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator11111" runat="server" ControlToValidate="scity" 
                        Display="Dynamic" ErrorMessage="City Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="style44">
                    
                    &nbsp;&nbsp;&nbsp; *State/Province:</td>
                <td class="field_label">
                
					<asp:DropDownList 
            ID="sddlstateins" runat="server" Width="152px" TabIndex="18" Height="22px" DataSourceID="dsstates" 
                        DataTextField="name" DataValueField="abrv" CausesValidation="True" 
                        AppendDataBoundItems="True" AutoPostBack="True" 
                        onselectedindexchanged="sddlstateins_SelectedIndexChanged" 
                        ondatabound="sddlstateins_DataBound" SelectedValue='<%# Bind("sstate", "{0}") %>' 
                        > <asp:ListItem></asp:ListItem> 
                    </asp:DropDownList>
                       <asp:TextBox ID="TextBox4" runat="server" Height="26px" Visible="False"  
                        style="text-transform:uppercase;" Width="174px" AutoPostBack="True" 
                        ontextchanged="TextBox4_TextChanged"></asp:TextBox>
                       <div class="req_field_val"> 
                           <asp:RequiredFieldValidator ID="fvstate" runat="server" 
                        ControlToValidate="sddlstateins" Display="Dynamic" 
                        ErrorMessage="State Required" ValidationGroup="g2"></asp:RequiredFieldValidator></div>
                       
                        </td>
              </tr>
              <tr>
                  <td align="right" class="style48" valign="baseline">
                      <asp:CheckBox ID="chkint112" runat="server" Text="International Address" 
                        Checked='<%# Bind("sinternational") %>' 
                       AutoPostBack="True" oncheckedchanged="chkint112_CheckedChanged" />&nbsp;&nbsp;&nbsp; Country:</td>
                  <td class="style48">
                     <asp:DropDownList ID="sddlcountry" runat="server" AppendDataBoundItems="True" 
                          Height="28px" Width="175px" DataSourceID="dscountry" DataTextField="name" 
                          DataValueField="abbrev" 
                          onselectedindexchanged="sddlcountry_SelectedIndexChanged" 
                          AutoPostBack="True">
                         <asp:ListItem Value="US">UNITED STATES</asp:ListItem>
                      </asp:DropDownList><div class="req_field_val">
                            <asp:CustomValidator ID="cvcountry1edt" runat="server" 
                                ErrorMessage="US Is not International" 
                                onservervalidate="cvcountry1edt_ServerValidate"></asp:CustomValidator>
                        </div></td>
              </tr>
              <tr>
                <td align="right" valign="baseline" class="field_label">*Zip Code:</td>
                <td class="style42">
					<asp:TextBox ID="szip" 
                        runat="server" TabIndex="19" Height="30px" Text='<%# Bind("spostalcode") %>' 
                        Width="186px" CausesValidation="True" MaxLength="6" ></asp:TextBox>
                        <div class="req_field_val"><asp:RequiredFieldValidator ID="fvzip" runat="server" 
                        ControlToValidate="szip" Display="Dynamic" ErrorMessage="Zip Code Required" 
                        ValidationGroup="g2"></asp:RequiredFieldValidator></div></td>
              </tr>
             
              <tr>
                <td align="right" valign="baseline" class="field_label"> Phone Number:
                </td>
                <td class="field_label">
					<asp:TextBox ID="sphone" runat="server" TabIndex="20" Height="22px" 
                        Text='<%# Bind("sphonenumber") %>' Width="143px" MaxLength="15" ></asp:TextBox> </td>
              </tr>
              
              <tr align="right" valign="baseline">
                <td colspan="2" class="field_label">&nbsp; 

          
   </td>
              </tr>
              <tr align="right" valign="baseline">
                <td colspan="2"> <asp:HiddenField ID="hfcustid" runat="server" Value='<%# eval("custid") %>' />
       <asp:Button ID="btnupdate" runat="server" Text="Continue" CommandName="Insert" TabIndex="21" 
						onclick="btnupdate_Click" ValidationGroup="g2" 
                        
                       /></td>
              </tr>
  </table>
  
  </div>
        </EditItemTemplate>

   </asp:FormView>
 
   </div>
   <asp:SqlDataSource ID="dscountry" runat="server" 
        ConnectionString="<%$ ConnectionStrings:KK5 %>" 
        ProviderName="<%$ ConnectionStrings:KK5.ProviderName %>" 
        
        SelectCommand="SELECT upper(name) as name, abbrev FROM country ORDER BY name"></asp:SqlDataSource>
 <asp:SqlDataSource ID="dsstates" runat="server" 
        ConnectionString="<%$ ConnectionStrings:KK5 %>" 
        ProviderName="<%$ ConnectionStrings:KK5.ProviderName %>" 
        
        
        
        SelectCommand="SELECT trim(name) AS name, trim(abrv) AS abrv, id, selectval FROM states ORDER BY selectval, name"></asp:SqlDataSource>
    <asp:SqlDataSource ID="ddsstates1" runat="server" 
		ConnectionString="<%$ ConnectionStrings:KK5 %>" 
		ProviderName="<%$ ConnectionStrings:KK5.ProviderName %>" 
		SelectCommand="SELECT trim(name) AS name, abrv, id FROM states"></asp:SqlDataSource><br />
    <asp:SqlDataSource 
    ID="DSCust" runat="server" 
    ConnectionString="<%$ ConnectionStrings:KK5 %>" 
    DeleteCommand="DELETE FROM [cust] WHERE [custid] = ?" 
    ProviderName="<%$ ConnectionStrings:KK5.ProviderName %>" 
    
        UpdateCommand="UPDATE cust SET fname = upper(@fname), lname = upper(@lname), CompanyName = upper(@companyname), billingaddr1 = upper(@billingaddr1), billingaddr2 = upper(@billingaddr2), city = upper(@city), state = @state, postalcode = @postalcode, phonenumber = @phonenumber, Schname = upper(@schname), sfname = upper(@sfname), slname = upper(@slname), scompanyname = upper(@scompanyname), saddr1 = upper(@saddr1), saddr2 = upper(@saddr2), scity = upper(@scity), sstate = @sstate, spostalcode = @spostalcode, sphonenumber = @sphonenumber, sfax = @sfax, EmailAddress = @EmailAddress, country = @country, scountry = @scountry, international = @international, sinternational = @sinternational WHERE (custid = @custid)" 
        
        SelectCommand="SELECT custid, fname, lname, EmailAddress, CompanyName, billingaddr1, billingaddr2, city, trim(state) AS state, postalcode, phonenumber, taxid, repofschool, Schname, trim(refby) AS refby, emailsubscriber, iscs, taxexempt, country, scountry, international, sinternational FROM cust" 
          
        InsertCommand="INSERT INTO cust(fname, lname, EmailAddress, CompanyName, billingaddr1, billingaddr2, city, state, postalcode, phonenumber, repofschool, Schname, refby, sfname, slname, scompanyname, saddr1, saddr2, scity, sstate, spostalcode, sphonenumber, sfax, country, scountry, international, sinternational) VALUES (upper(@fname), upper(@lname), @emailaddress, upper(@companyname), upper(@billingaddr1), upper(@billingaddr2), upper(@city), @state, @postalcode, @phonenumber, @repofschool, upper(@schname), @refby, upper(@sfname), upper(@slname), upper(@scompanyname), upper(@saddr1), upper(@saddr2), upper(@scity), @sstate, @spostalcode, @sphonenumber, @sfax, @country, @scountry, @international, @sinternational)">
            <DeleteParameters>
                <asp:Parameter Name="custid" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="FormView1" Name="fname" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="lname" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="emailaddress" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="companyname" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="billingaddr1" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="billingaddr2" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="city" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="state" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="postalcode" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="phonenumber" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="repofschool" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="schname" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="refby" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="counrtry" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="scountry" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="international" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="FormView1" Name="sinternational" 
                    PropertyName="SelectedValue" />
            </InsertParameters>
        </asp:SqlDataSource>
        <asp:HiddenField ID="hftaxabletotal" runat="server" />
        <asp:SqlDataSource ID="Dsmisc" runat="server" 
        ConnectionString="<%$ ConnectionStrings:KK5 %>" 
        ProviderName="<%$ ConnectionStrings:KK5.ProviderName %>"></asp:SqlDataSource>
     

    <asp:HiddenField ID="x_exp_date" runat="server" />



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

