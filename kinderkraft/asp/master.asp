<%@LANGUAGE = VBSCRIPT%> <html>
<style type="text/css">
body,td,th {
	font-size: 14px;
}
</style>
<body>

<%

' Get the form data

Quote = Request.Form("Quote")
fs = Request.Form("Free Sample")
Copies = Request.Form("Copies")
Pages = Request.Form("Number of Pages")
bco = Request.Form("Book Color Option")
howmany = Request.Form("How Many Are Color")
bt = Request.Form("Binding Type")
ccm = Request.Form("Custom Cover Material")
lam = Request.Form("Lamination")
ct = Request.Form("Cover Type")
yir = Request.Form("YIR")
sup = Request.Form("Supplement")
dp = Request.Form("Design Program")
demo = Request.Form("Free Demo")
cn = Request.Form("Contact Name")
unit = Request.Form("School Name")
Address = Request.Form("Mailing Address")
City = Request.Form("City")
sta = Request.Form("State")
Zip = Request.Form("Zip 5 Digit")
ha = Request.Form("Materials To Home Address")
Phone = Request.Form("Phone")
Email = Request.Form("Email")
schtype = Request.Form("School Type")
totenroll = Request.Form("Total Enrollment")
hear = Request.Form("How did you hear about us?")
promocode = Request.Form("Promo Code")
QuestionsorComments = Request.Form("Questions or Comments")

' Create the JMail message Object
set msg = Server.CreateOBject( "jmail.message" )

' Set logging to true to ease any potential debugging
' And set silent to true as we wish to handle our errors ourself
msg.Logging = true
msg.silent = true

' Enter the sender data  
msg.From = "yearbook@memorybook.com"
msg.FromName = "Memory Book Company"

' Note that as addRecipient is method and not
' a property, we do not use an equals ( = ) sign
msg.AddRecipient "yearbook@memorybook.com"

' The subject of the message
msg.Subject = "Memory Book Quote Request"

' And the body
msg.body = "Request A Quote:            " & Quote & vbCrlf & vbCrlf&_
"Free Sample:                " & fs & vbCrlf&_
"Number of Copies:           " & Copies & vbCrlf&_
"Number of Pages:            " & Pages & vbCrlf & vbCrlf&_
"Book Color Option:          " & bco & vbCrlf&_
"How Many Pages Are Color:   " & howmany & vbCrlf&_
"Binding Type:               " & bt & vbCrlf & vbCrlf&_
"Custom Cover Material:      " & ccm & vbCrlf&_
"Lamination:                 " & lam & vbCrlf&_
"Cover Type:                 " & ct & vbCrlf & vbCrlf&_
"Year In Review:             " & yir & vbCrlf&_
"Supplements:                " & sup & vbCrlf&_
"Design Program:             " & dp & vbCrlf & vbCrlf&_
"Free MBO Demo:              " & demo & vbCrlf & vbCrlf&_
"Contact Name:               " & cn & vbCrlf&_
"School Name:                " & unit & vbCrlf&_
"Mailing Address:            " & Address & vbCrlf&_
"City:                       " & City & vbCrlf&_
"State:                      " & sta & vbCrlf&_
"Zip:                        " & Zip & vbCrlf&_
"Materials To Home Address:  " & ha & vbCrlf&_
"Phone:                      " & Phone & vbCrlf&_
"Email:                      " & Email & vbCrlf&_
"School Type:                " & schtype & vbCrlf&_
"Total Enrollment:           " & totenroll & vbCrlf&_
"How did you hear about us?: " & hear & vbCrlf&_
"Promo Code:                 " & promocode & vbCrlf&_
"Questions or Comments:      " & QuestionsorComments

' Now send the message, using the indicated mailserver
if not msg.Send("192.168.1.245") then
    Response.write "<pre>" & msg.log & "</pre>"
else
    Response.Redirect ("quotethankyou.html")
end if


' And we're done! the message has been sent.


%>
</body>
</html>
