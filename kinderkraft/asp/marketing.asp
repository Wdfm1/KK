<%@LANGUAGE = VBSCRIPT%> <html>
<style type="text/css">
body,td,th {
	font-size: 14px;
}
</style>
<body>

<%

' Get the form data

contact = Request.Form("Marketing_Mat_Name")
schoolname = Request.Form("Marketing_Mat_School_Name")
address = Request.Form("Marketing_Mat_Address")
city = Request.Form("Marketing_Mat_City")
stat = Request.Form("Marketing_Mat_State")
zip = Request.Form("Marketing_Mat_Zip")
email = Request.Form("Marketing_Mat_Email")
phone = Request.Form("Marketing_Mat_Phone")
schooltype = Request.Form("Marketing_Mat_School_Type")
marketingmaterials = Request.Form("Marketing_Materials")
reminderflyerqty = Request.Form("Marketing_Mat_Remind_Flyer_Qty")
takehomeenvqty = Request.Form("Marketing_Mat_Take_Home_Env_Qty")
reminderstickersqty = Request.Form("Marketing_Mat_Reminder_Stickers_Qty")


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
msg.Subject = "Kinderkraft Free Marketing Material Request"

' And the body
msg.body = "Name:                                           " & contact & vbCrlf & vbCrlf&_
"School Name:                                               " & schoolname & vbCrlf&_
"Address:                                                   " & address & vbCrlf&_
"City:                                                      " & city & vbCrlf&_
"State:                                                     " & stat & vbCrlf&_
"Zip:                                                       " & zip & vbCrlf&_
"Email:                                                     " & email & vbCrlf & vbCrlf&_
"Phone:                                                     " & phone & vbCrlf & vbCrlf&_
"School Type:                                               " & schooltype & vbCrlf & vbCrlf&_
"Material Requested:                                        " & marketingmaterials & vbCrlf&_
"Reminder Flyer Qty:                                        " & reminderflyerqty  & vbCrlf & vbCrlf&_
"Take Home Envelope Qty:                                    " & takehomeenvqty & vbCrlf & vbCrlf&_
"Reminder Stickers Qty:                                     " & reminderstickersqty


' Now send the message, using the indicated mailserver
if not msg.Send("192.168.1.245") then
    Response.write "<pre>" & msg.log & "</pre>"
else
    Response.Redirect ("thank_you_page_marketing.html")
end if


' And we're done! the message has been sent.


%>
</body>
</html>
