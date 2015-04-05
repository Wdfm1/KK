<%@LANGUAGE = VBSCRIPT%> <html>
<style type="text/css">
body,td,th {
	font-size: 14px;
}
</style>
<body>

<%

' Get the form data

contractname = Request.Form("Biz_Agree_Contract_Name")
contractschoolname = Request.Form("Biz_Agree_Contract_School_Name")
pkgpurchase = Request.Form("biz_agree_pkg_purchase")
gradpackageqty = Request.Form("Grad_Pkg_Qty")
scholarpackageqty = Request.Form("Scholar_Pkg_Qty")
achieverpackageqty = Request.Form("Achiever_Pkg_Qty")
milestonepackageqty = Request.Form("Milestone_Pkg_Qty")
learnerpackageqty = Request.Form("Learner_Pkg_Qty")
graddate = Request.Form("Biz_Agree_Grad_Date")
deliverydate = Request.Form("Biz_Agree_Deliv_Date")
enrollment = Request.Form("Biz_Agree_Enrollment")
contact = Request.Form("Biz_Agree_Full_Name")
schoolname = Request.Form("Biz_Agree_School_Name")
address = Request.Form("Biz_Agree_School_Address")
city = Request.Form("Biz_Agree_City")
stat = Request.Form("Biz_Agree_State")
zip = Request.Form("Biz_Agree_Zip")
email = Request.Form("Biz_Agree_Email")
phone = Request.Form("Biz_Agree_Phone")
dat = Request.Form("Biz_Agree_Date")
agreetoterms = Request.Form("Biz_Agree_Term_Cond")


' Create the JMail message Object
set msg = Server.CreateOBject( "jmail.message" )

' Set logging to true to ease any potential debugging
' And set silent to true as we wish to handle our errors ourself
msg.Logging = true
msg.silent = true

' Enter the sender data  
msg.From = "chella@memorybook.com"
msg.FromName = "Kinderkraft"

' Note that as addRecipient is method and not
' a property, we do not use an equals ( = ) sign
msg.AddRecipient "chella@memorybook.com"

' The subject of the message
msg.Subject = "Kinderkraft Business Agreement"

' And the body
msg.body = "Contract Name:                           " & contractname & vbCrlf & vbCrlf&_
"Contract School Name:                               " & contractschoolname & vbCrlf & vbCrlf&_
"Package Purchases:                                  " & pkgpurchase & vbCrlf&_
"Grad Package Qty:                                   " & gradpackageqty & vbCrlf&_
"Scholar Package Qty:                                " & scholarpackageqty & vbCrlf&_
"Achiever Package Qty:                               " & achieverpackageqty & vbCrlf&_
"Milestone Package Qty:                              " & milestonepackageqty & vbCrlf&_
"Learner Package Qty:                                " & learnerpackageqty & vbCrlf & vbCrlf&_
"Graduation Date:                                    " & graddate & vbCrlf&_
"Delivery Date Requested:                            " & deliverydate & vbCrlf&_
"Current Enrollment:                                 " & enrollment & vbCrlf & vbCrlf&_
"Contact:                                            " & contact & vbCrlf&_
"School Name:                                        " & schoolname & vbCrlf&_
"Address:                                            " & address & vbCrlf&_
"City:                                               " & city & vbCrlf & vbCrlf&_
"State:                                              " & stat & vbCrlf&_
"Zip:                                                " & zip & vbCrlf & vbCrlf&_
"Email:                                              " & email & vbCrlf&_
"Phone:                                              " & phone & vbCrlf & vbCrlf&_
"Date:                                               " & dat & vbCrlf&_
"I agree to the terms:                               " & agreetoterms

' Now send the message, using the indicated mailserver
if not msg.Send("192.168.1.245") then
    Response.write "<pre>" & msg.log & "</pre>"
else
    Response.Redirect ("thank_you_page_bizagree.html")
end if


' And we're done! the message has been sent.


%>
</body>
</html>
