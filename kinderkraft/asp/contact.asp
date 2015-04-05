<%@LANGUAGE = VBSCRIPT%> <html>
<style type="text/css">
body,td,th {
	font-size: 14px;
}
</style>
<body>

<%

' Get the form data

contact = Request.Form("Contact_Name")
schoolname = Request.Form("Contact_School_Name")
address = Request.Form("Contact_Address")
city = Request.Form("Contact_City")
stat = Request.Form("Contact_State")
zip = Request.Form("Contact_Zip")
email = Request.Form("Contact_Email")
phone = Request.Form("Contact_Phone")
schooltype = Request.Form("Contact_School_Type")
ct = Request.Form("Contact_Time")
hdyhau = Request.Form("Contact_How_Did_You_Hear_About_Us")
Comments = Request.Form("Contact_Comments")

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
msg.Subject = "Kinderkraft Contact Information"

' And the body
msg.body = "Contact Name:                                    " & contact & vbCrlf & vbCrlf&_
"Contact School Name:                                        " & schoolname & vbCrlf&_
"Contact Address:                                            " & address & vbCrlf&_
"Contact City:                                               " & city & vbCrlf & vbCrlf&_
"Contact State:                                              " & stat & vbCrlf&_
"Contact Zip:                                                " & zip & vbCrlf&_
"Contact Email:                                              " & email & vbCrlf & vbCrlf&_
"Contact Phone:                                              " & phone & vbCrlf&_
"Contact School Type:                                        " & schooltype & vbCrlf&_
"Contact Time:                                               " & ct & vbCrlf & vbCrlf&_
"How Did You Hear About Us:                                  " & hdyhau & vbCrlf&_
"Contact Comments:                                           " & Comments

' Now send the message, using the indicated mailserver
if not msg.Send("192.168.1.245") then
    Response.write "<pre>" & msg.log & "</pre>"
else
    Response.Redirect ("thank_you_page_contact.html")
end if


' And we're done! the message has been sent.


%>
</body>
</html>
