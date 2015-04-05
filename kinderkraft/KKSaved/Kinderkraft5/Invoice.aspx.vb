Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Net.Mail
Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Activities.Statements
Imports AuthorizeNet




Partial Class Invoice
    Inherits webformbase
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Response.AppendHeader("Cache-Control", "no-store, no-cache, must-revalidate, post-check=0, pre-check=0")
        Page.MaintainScrollPositionOnPostBack = True
       

        Dim SC As ShoppingCart 'if we got this far we know there is a session(shopping cart)
        Dim lt As LookUpTable
        If Not IsPostBack Then
            If IsNothing(Session("ShoppingCart")) Then 'check to be sure haven't time out
                Session.Add("SessionError", "Your session has ended. Please reorder your products.")
                Response.Redirect("Error.aspx")
            Else 'may or may not be logged in
                SC = Session("ShoppingCart")
                lt = Session("LookUp")

                If SC.username <> "GUEST" Then
                    If SC.AdminGuest <> True Then
                        DSCust.SelectCommand = "SELECT * FROM cust where custid=" & SC.custid
                        FormView1.ChangeMode(FormViewMode.Edit)
                        'FormView1.DataBind()

                    Else
                        If Session("guestloggedin") Then 'cust record has been created
                            SC = Session("ShoppingCart")
                            lt = Session("LookUp")
                            DSCust.SelectCommand = "SELECT * FROM cust where custid=" & SC.custid
                            FormView1.ChangeMode(FormViewMode.Edit)
                            'FormView1.DataBind()

                        Else 'cust not created
                            FormView1.ChangeMode(FormViewMode.Insert)
                            'FormView1.DataBind()

                        End If
                    End If

                Else 'is a guest
                    If Session("guestloggedin") Then 'cust record has been created
                        SC = Session("ShoppingCart")
                        lt = Session("LookUp")
                        DSCust.SelectCommand = "SELECT * FROM cust where custid=" & SC.custid
                        FormView1.ChangeMode(FormViewMode.Edit)
                        'FormView1.DataBind()

                    Else 'cust not created
                        FormView1.ChangeMode(FormViewMode.Insert)
                        'FormView1.DataBind()

                    End If

                End If 'not guest

            End If

        Else 'is postback
            If Session("guestloggedin") Then 'cust record has been created
                SC = Session("ShoppingCart")
                lt = Session("LookUp")
                DSCust.SelectCommand = "SELECT * FROM cust where custid=" & SC.custid
                FormView1.ChangeMode(FormViewMode.Edit)
                'FormView1.DataBind()

                Session("guestloggedin") = False
            End If
        End If
       
     

    End Sub
    

	Protected Sub Button1_Click2(ByVal sender As Object, ByVal e As System.EventArgs)
		Page.Validate()
		If Page.IsValid Then

			'insert button
			Dim SC As ShoppingCart = Session("ShoppingCart")
			Dim LT As LookUpTable = Session("LookUp")
			Dim connection1 As New MySqlConnection(LT.ConnectStr)
            Dim custid As Integer
            Dim email As TextBox = FormView1.FindControl("emailaddress")
            If Not IsNothing(email) Then
                SC.useremail = email.Text
            Else
                SC.useremail = ""
            End If

            Dim commandtext As String = "INSERT INTO cust(fname, lname, EmailAddress, CompanyName, billingaddr1, billingaddr2, city, state, postalcode,international,sinternational,country,scountry, phonenumber," _
             & "refby, sfname, slname, scompanyname, saddr1, saddr2, scity, sstate, spostalcode, sphonenumber,username)" _
             & "VALUES (upper(@fname),upper(@lname), @emailaddress, upper(@companyname), @billingaddr1, @billingaddr2,upper(@city), @state, @postalcode,@international,@sinternational,upper(@country),upper(@scountry), @phonenumber, @refby, upper(@sfname),upper(@slname)," _
             & "upper(@scompanyname), @saddr1, @saddr2, @scity, @sstate, @spostalcode, @sphonenumber,'GUEST')"
			Dim cmd As MySqlCommand = New MySqlCommand(commandtext, connection1)

            Dim fname As TextBox = FormView1.FindControl("fname1")
			cmd.Parameters.AddWithValue("@fname", fname.Text)
			Dim lname As TextBox = FormView1.FindControl("lname")
			cmd.Parameters.AddWithValue("@lname", lname.Text)
			Dim emailaddress As TextBox = FormView1.FindControl("emailaddress")
			cmd.Parameters.AddWithValue("@emailaddress", emailaddress.Text)
			Dim companyname As TextBox = FormView1.FindControl("company")
			cmd.Parameters.AddWithValue("@companyname", companyname.Text)
			Dim billingaddr1 As TextBox = FormView1.FindControl("addr1")
			cmd.Parameters.AddWithValue("@billingaddr1", billingaddr1.Text)
			Dim billingaddr2 As TextBox = FormView1.FindControl("addr2")
			cmd.Parameters.AddWithValue("@billingaddr2", billingaddr2.Text)
			Dim city As TextBox = FormView1.FindControl("city")
            cmd.Parameters.AddWithValue("@city", city.Text)

            Dim country As DropDownList = FormView1.FindControl("ddlcountry1")
            cmd.Parameters.AddWithValue("@country", country.SelectedValue)

            Dim scountry As DropDownList = FormView1.FindControl("sddlcountry1")
            cmd.Parameters.AddWithValue("@scountry", scountry.selectedvalue)
            Dim international As CheckBox = FormView1.FindControl("chkinternational")
            cmd.Parameters.AddWithValue("@international", international.Checked)
            Try
                'If international.Checked = False Then
                Dim state As DropDownList = FormView1.FindControl("ddlstateins")
                cmd.Parameters.AddWithValue("@state", state.SelectedValue)
                'Else
                'Dim txtstate1 As TextBox = FormView1.FindControl("Textbox1")
                'cmd.Parameters.AddWithValue("@state", txtstate1.Text)
                'End If

            Catch ex As Exception
                cmd.Parameters.AddWithValue("@sstate", "  ")
            End Try

            Dim postalcode As TextBox = FormView1.FindControl("zip")
            cmd.Parameters.AddWithValue("@postalcode", postalcode.Text)


            Dim phonenumber As TextBox = FormView1.FindControl("phonenumber1")
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber.Text)


            Dim refby As DropDownList = FormView1.FindControl("ddlhear")
            cmd.Parameters.AddWithValue("@refby", refby.SelectedValue)

            Dim sfname As TextBox = FormView1.FindControl("sfname")
            cmd.Parameters.AddWithValue("@sfname", sfname.Text)
            Dim slname As TextBox = FormView1.FindControl("slname")
            cmd.Parameters.AddWithValue("@slname", slname.Text)
            Dim scompanyname As TextBox = FormView1.FindControl("scompany")
            cmd.Parameters.AddWithValue("@scompanyname", scompanyname.Text)
            Dim sbillingaddr1 As TextBox = FormView1.FindControl("saddr1")
            cmd.Parameters.AddWithValue("@saddr1", sbillingaddr1.Text)
            Dim sbillingaddr2 As TextBox = FormView1.FindControl("saddr2")
            cmd.Parameters.AddWithValue("@saddr2", sbillingaddr2.Text)
            Dim scity As TextBox = FormView1.FindControl("scity")
            cmd.Parameters.AddWithValue("@scity", scity.Text)

            Dim sinternational As CheckBox = FormView1.FindControl("chkint11")
            cmd.Parameters.AddWithValue("@sinternational", sinternational.Checked)
            Try
				If sinternational.Checked = False Then
					SC.International = False
					Dim sstate As DropDownList = FormView1.FindControl("sddlstate")
					cmd.Parameters.AddWithValue("@sstate", sstate.SelectedValue)
				Else
					SC.International = True

					Dim txtstate As TextBox = FormView1.FindControl("Textbox2")
					cmd.Parameters.AddWithValue("@sstate", txtstate.Text)
				End If

            Catch ex As Exception
                cmd.Parameters.AddWithValue("@sstate", "  ")
            End Try

            Dim spostalcode As TextBox = FormView1.FindControl("szip")
            cmd.Parameters.AddWithValue("@spostalcode", spostalcode.Text)
            Dim sphonenumber As TextBox = FormView1.FindControl("sphone")
            cmd.Parameters.AddWithValue("@sphonenumber", sphonenumber.Text)

            Try

                connection1.Open()
            Catch ex As Exception 'connection failed
                Session.Add("SessionError", ex.Message)
                Session.Add("errexception", ex)
                Response.Redirect("Error.aspx")

            End Try

            Try
                'insert or update cust
                cmd.ExecuteNonQuery()
                commandtext = "Select Last_Insert_ID();"
                cmd = New MySqlCommand(commandtext, connection1)
                custid = CInt(cmd.ExecuteScalar())
                SC.custid = custid
                Session.Add("guestloggedin", True)


            Catch ex As Exception 'sql failed
                Session.Add("SessionError", ex.Message)
                Session.Add("errexception", ex)
                Response.Redirect("Error.aspx")
            Finally
                connection1.Close()

            End Try

            Dim zip As TextBox = FormView1.FindControl("zip")


            SC.taxrate = LT.Gettax(zip.Text)
            SC.userzip = spostalcode.Text
            Session("ShoppingCart") = SC
            Session("Lookup") = LT
            Response.Redirect("secure/invoice3.aspx?custid=" & custid.ToString)
            'Response.Redirect("secure.jostenskinderkraft.com/invoice3.aspx?custid=" & custid.ToString)

        End If
	End Sub

    Protected Sub FormView1_ItemUpdated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.FormViewUpdatedEventArgs) Handles FormView1.ItemUpdated
        Dim SC As ShoppingCart = Session("ShoppingCart") 'we have a cust id when we get this far
		'Response.Redirect("secure.jostenskinderkraft.com/invoice3.aspx?custid=" & SC.custid)
		Response.Redirect("secure/invoice3.aspx?custid=" & SC.custid)
    End Sub

    Protected Sub FormView1_ItemInserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.FormViewInsertedEventArgs) Handles FormView1.ItemInserted
        Dim SC As ShoppingCart = Session("ShoppingCart") 'we have a cust id when we get this far
		Session.Add("guestloggedin", True)
		'Response.Redirect("secure.jostenskinderkraft.com/invoice3.aspx?custid=" & SC.custid)
		Response.Redirect("secure/invoice3.aspx?custid=" & SC.custid)
    End Sub

    Protected Sub DSCust_Updated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles DSCust.Updated

    End Sub

    Protected Sub btninsertcopy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim fname As TextBox = FormView1.FindControl("fname1")
        Dim lname As TextBox = FormView1.FindControl("lname")
        Dim txtstate As TextBox = FormView1.FindControl("TextBox1")
        Dim companyname As TextBox = FormView1.FindControl("company")
        Dim billingaddr1 As TextBox = FormView1.FindControl("addr1")
        Dim billingaddr2 As TextBox = FormView1.FindControl("addr2")
        Dim city As TextBox = FormView1.FindControl("city")
        Dim country As DropDownList = FormView1.FindControl("ddlcountry1")
		Dim state As DropDownList = FormView1.FindControl("ddlstateins")
        Dim postalcode As TextBox = FormView1.FindControl("zip")
        Dim phonenumber As TextBox = FormView1.FindControl("phonenumber1")
        Dim schname As TextBox = FormView1.FindControl("schname")
        Dim refby As DropDownList = FormView1.FindControl("ddlhear")
        Dim sfname As TextBox = FormView1.FindControl("sfname")
        sfname.Text = fname.Text
        Dim slname As TextBox = FormView1.FindControl("slname")
        slname.Text = lname.Text
        Dim scompanyname As TextBox = FormView1.FindControl("scompany")
        scompanyname.Text = companyname.Text
        Dim sbillingaddr1 As TextBox = FormView1.FindControl("saddr1")
        sbillingaddr1.Text = billingaddr1.Text
        Dim sbillingaddr2 As TextBox = FormView1.FindControl("saddr2")
        sbillingaddr2.Text = billingaddr2.Text
        Dim scity As TextBox = FormView1.FindControl("scity")
        scity.Text = city.Text
        Dim txtstate1 As TextBox = FormView1.FindControl("TextBox2")
        txtstate1.Text = txtstate.Text
        Dim scountry As DropDownList = FormView1.FindControl("sddlcountry1")
        scountry.SelectedValue = country.SelectedValue
		Dim sstate As DropDownList = FormView1.FindControl("sddlstate")
        sstate.SelectedValue = state.SelectedValue
        Dim spostalcode As TextBox = FormView1.FindControl("szip")
        spostalcode.Text = postalcode.Text
        Dim sphonenumber As TextBox = FormView1.FindControl("sphone")
        sphonenumber.Text = phonenumber.Text
    End Sub

    Protected Sub btnupdate_Click(ByVal sender As Object, ByVal e As System.EventArgs)
		'update(buttone)
		Page.Validate()

        If Page.IsValid Then
            Dim SC As ShoppingCart = Session("ShoppingCart")
            Dim LT As LookUpTable = Session("LookUp")
            Dim connection1 As New MySqlConnection(LT.ConnectStr)

            Dim commandtext As String = "UPDATE cust SET fname =upper(@fname), lname = upper(@lname), international=@international,sinternational=@sinternational, country=upper(@country),scountry=upper(@scountry), CompanyName =upper(@companyname), billingaddr1 = @billingaddr1, billingaddr2 = @billingaddr2, city = upper(@city), state = @state," _
   & "postalcode = @postalcode, phonenumber = @phonenumber,   refby = @refby, sfname = @sfname,emailaddress=@emailaddress," _
   & "slname =upper(@slname), scompanyname =upper(@scompanyname), saddr1 = @saddr1, saddr2 = @saddr2, scity =upper(@scity), sstate = @sstate, spostalcode = @spostalcode, sphonenumber = @sphonenumber" _
   & " WHERE (custid =" & SC.custid & ");"
            Dim cmd As MySqlCommand = New MySqlCommand(commandtext, connection1)

            Dim fname As TextBox = FormView1.FindControl("fname")
            cmd.Parameters.AddWithValue("@fname", fname.Text)
			Dim international As CheckBox = FormView1.FindControl("chkint2edt")
            cmd.Parameters.AddWithValue("@international", international.Checked)

			Dim ddlcountry As DropDownList = FormView1.FindControl("ddlcountryedt")
            cmd.Parameters.AddWithValue("@country", ddlcountry.SelectedValue)

            Dim ddlstate As DropDownList = FormView1.FindControl("ddlstate")
            Dim txtstate As TextBox = FormView1.FindControl("TextBox3")
            'If IsNothing(txtstate.Text) Then
            cmd.Parameters.AddWithValue("@state", ddlstate.SelectedValue)
            'Else
            '    cmd.Parameters.AddWithValue("@state", txtstate.Text)
            'End If

			Dim sinternational As CheckBox = FormView1.FindControl("chkint112")
			If sinternational.Checked = True Then
				SC.International = True
				SC.shipmethod = "INTERNATIONAL"
			Else
				SC.International = False
			End If

            cmd.Parameters.AddWithValue("@sinternational", international.Checked)

            Dim ddlsstate As DropDownList = FormView1.FindControl("sddlstateins")
            Dim stxtstate As TextBox = FormView1.FindControl("TextBox4")
            'If Not IsNothing(stxtstate) Then
            '    cmd.Parameters.AddWithValue("@sstate", stxtstate.Text)
            'Else
            cmd.Parameters.AddWithValue("@sstate", ddlsstate.SelectedValue)
            'End If

            Dim sddlcountry As DropDownList = FormView1.FindControl("sddlcountry")
            cmd.Parameters.AddWithValue("@scountry", sddlcountry.SelectedValue)

            Dim lname As TextBox = FormView1.FindControl("lname")
            cmd.Parameters.AddWithValue("@lname", lname.Text)
            Dim emailaddress As TextBox = FormView1.FindControl("EmailAddress")
            cmd.Parameters.AddWithValue("@emailaddress", emailaddress.Text)
            Dim companyname As TextBox = FormView1.FindControl("company")
            cmd.Parameters.AddWithValue("@companyname", companyname.Text)
            Dim billingaddr1 As TextBox = FormView1.FindControl("addr1")
            cmd.Parameters.AddWithValue("@billingaddr1", billingaddr1.Text)
            Dim billingaddr2 As TextBox = FormView1.FindControl("addr2")
            cmd.Parameters.AddWithValue("@billingaddr2", billingaddr2.Text)
            Dim city As TextBox = FormView1.FindControl("city")
            cmd.Parameters.AddWithValue("@city", city.Text)

            Dim postalcode As TextBox = FormView1.FindControl("zip")
            cmd.Parameters.AddWithValue("@postalcode", postalcode.Text)
            Dim phonenumber As TextBox = FormView1.FindControl("phonenumber")
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber.Text)
            'Response.Redirect("secure/invoice3.aspx?custid=" & SC.custid)

            Dim refby As DropDownList = FormView1.FindControl("ddlhear")
            cmd.Parameters.AddWithValue("@refby", refby.SelectedValue)

            Dim sfname As TextBox = FormView1.FindControl("sfname")
            cmd.Parameters.AddWithValue("@sfname", sfname.Text)
            Dim slname As TextBox = FormView1.FindControl("slname")
            cmd.Parameters.AddWithValue("@slname", slname.Text)
            Dim scompanyname As TextBox = FormView1.FindControl("scompany")
            cmd.Parameters.AddWithValue("@scompanyname", scompanyname.Text)
            Dim sbillingaddr1 As TextBox = FormView1.FindControl("saddr1")
            cmd.Parameters.AddWithValue("@saddr1", sbillingaddr1.Text)
            Dim sbillingaddr2 As TextBox = FormView1.FindControl("saddr2")
            cmd.Parameters.AddWithValue("@saddr2", sbillingaddr2.Text)
            Dim scity As TextBox = FormView1.FindControl("scity")
            cmd.Parameters.AddWithValue("@scity", scity.Text)

            Dim spostalcode As TextBox = FormView1.FindControl("szip")
            cmd.Parameters.AddWithValue("@spostalcode", spostalcode.Text)
            Dim sphonenumber As TextBox = FormView1.FindControl("sphone")
            cmd.Parameters.AddWithValue("@sphonenumber", sphonenumber.Text)
            Try

                connection1.Open()
            Catch ex As Exception 'connection failed
                Session.Add("SessionError", ex.Message)
                Session.Add("errexception", ex)
                Response.Redirect("Error.aspx")

            End Try

            Try
                'update(cust)
                cmd.ExecuteNonQuery()

                Session.Add("guestloggedin", True)


            Catch ex As Exception 'sql failed
                Session.Add("SessionError", ex.Message)
                Session.Add("errexception", ex)
                connection1.Close()
                Response.Redirect("Error.aspx")
            Finally
                connection1.Close()

            End Try

            Dim szip As TextBox = FormView1.FindControl("szip")
            'Dim taxexempt As CheckBox = FormView1.FindControl("taxexempt")
            'SC.taxexempt = taxexempt.Checked
            SC.taxrate = LT.Gettax(szip.Text)
            SC.userzip = szip.Text
			Response.Redirect("secure/invoice3.aspx?custid=" & SC.custid.ToString)
			'Response.Redirect("https://www.secure.jostenskinderkraft.com/secure/invoice3.aspx?custid=" & SC.custid.ToString)
        End If
    End Sub

	Protected Sub btneditcopy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
		Dim fname As TextBox = FormView1.FindControl("fname")
		Dim lname As TextBox = FormView1.FindControl("lname")

		Dim companyname As TextBox = FormView1.FindControl("company")
		Dim billingaddr1 As TextBox = FormView1.FindControl("addr1")
		Dim billingaddr2 As TextBox = FormView1.FindControl("addr2")
		Dim city As TextBox = FormView1.FindControl("city")
		Dim state As DropDownList = FormView1.FindControl("ddlstate")
		Dim postalcode As TextBox = FormView1.FindControl("zip")
		Dim phonenumber As TextBox = FormView1.FindControl("phonenumber")
        Dim country As DropDownList = FormView1.FindControl("ddlcountry")
		Dim schname As TextBox = FormView1.FindControl("schname")
		Dim refby As DropDownList = FormView1.FindControl("ddlhear")

		Dim sfname As TextBox = FormView1.FindControl("sfname")
		sfname.Text = fname.Text
		Dim slname As TextBox = FormView1.FindControl("slname")
		slname.Text = lname.Text
		Dim scompanyname As TextBox = FormView1.FindControl("scompany")
		scompanyname.Text = companyname.Text
		Dim sbillingaddr1 As TextBox = FormView1.FindControl("saddr1")
		sbillingaddr1.Text = billingaddr1.Text
		Dim sbillingaddr2 As TextBox = FormView1.FindControl("saddr2")
		sbillingaddr2.Text = billingaddr2.Text
		Dim scity As TextBox = FormView1.FindControl("scity")
		scity.Text = city.Text
        Dim sstate As DropDownList = FormView1.FindControl("sddlstateins")
        sstate.SelectedValue = state.SelectedValue
        Dim scountry As DropDownList = FormView1.FindControl("sddlcountry")
		scountry.SelectedValue = scountry.SelectedValue
		Dim spostalcode As TextBox = FormView1.FindControl("szip")
		spostalcode.Text = postalcode.Text
		Dim sphonenumber As TextBox = FormView1.FindControl("sphone")
		sphonenumber.Text = phonenumber.Text
	End Sub

    Protected Sub ddlstateins_SelectedIndexChanged(sender As Object, e As System.EventArgs)
        Dim ddlstate As DropDownList = FormView1.FindControl("ddlstateins")

        Dim txtstate As TextBox = FormView1.FindControl("TextBox1")

        If ddlstate.SelectedValue = "add" Then
            ddlstate.Visible = False
            txtstate.Visible = True
        Else
            ddlstate.Visible = True
            txtstate.Visible = False
        End If
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs)

        Dim txtstate As TextBox = FormView1.FindControl("TextBox1")
        Dim ddlstate As DropDownList = FormView1.FindControl("ddlstateins")
        Dim sddlstate As DropDownList = FormView1.FindControl("sddlstate")
        If txtstate.Text.Length > 0 And UniqueState(txtstate.Text) = True Then
            dsstates.InsertCommand = "INSERT INTO states(name) VALUES (upper('" & txtstate.Text & "'))"
            Try
                dsstates.Insert()
                ViewState.Add("InsertNewState", txtstate.Text)
                FormView1.DataBind()
            Catch ex As Exception
                ddlstate.Visible = True
                txtstate.Visible = False
            End Try

        Else
            ViewState.Add("InsertNewState", txtstate.Text)

        End If
    End Sub

    Private Function UniqueState(txtval As String) As Boolean
        Dim retval As Boolean
        ddsstates1.SelectCommand = "Select * from states where name=upper('" & txtval & "')"
        Dim dvSql As New DataView
        Try
            dvSql = CType(Me.ddsstates1.Select(DataSourceSelectArguments.Empty), DataView)
        Catch ex As Exception
        End Try
        If dvSql.Count > 0 Then
            retval = False
        Else
            retval = True
        End If
        Return retval
    End Function

    Protected Sub Page_PreRenderComplete(sender As Object, e As System.EventArgs) Handles Me.PreRenderComplete
        'Try


        '    Select Case sender.id.ToString

        '        Case "TextBox1"
        '            Try
        '                Dim ddlstate As DropDownList = FormView1.FindControl("ddlstateins")
        '                ddlstate.SelectedValue = sender.text.ToString.ToUpper

        '            Catch ex As Exception

        '            End Try
        '        Case "TextBox2"
        '            Try
        '                Dim ddlstate As DropDownList = FormView1.FindControl("sddlstate")
        '                ddlstate.SelectedValue = sender.text.ToString.ToUpper

        '            Catch ex As Exception

        '            End Try
        '        Case "TextBox3"
        '            Try
        '                Dim ddlstate As DropDownList = FormView1.FindControl("ddlstate")
        '                ddlstate.SelectedValue = sender.text.ToString.ToUpper

        '            Catch ex As Exception

        '            End Try
        '        Case "TextBox4"
        '            Try
        '                Dim ddlstate As DropDownList = FormView1.FindControl("sddlstateins")
        '                ddlstate.SelectedValue = sender.text.ToString.ToUpper

        '            Catch ex As Exception

        '            End Try
        '    End Select
        'Catch ex As Exception

        'End Try
    End Sub

    Protected Sub sddlstate_SelectedIndexChanged(sender As Object, e As System.EventArgs)
        Dim ddlstate As DropDownList = FormView1.FindControl("sddlstate")
        Dim txtstate As TextBox = FormView1.FindControl("TextBox2")

        If ddlstate.SelectedValue = "add" Then
            ddlstate.Visible = False
            txtstate.Visible = True
        Else
            ddlstate.Visible = True
            txtstate.Visible = False
        End If
    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As System.EventArgs)
        Dim txtstate As TextBox = FormView1.FindControl("TextBox2")
        Dim ddlstate As DropDownList = FormView1.FindControl("sddlstate")
        Dim SC As ShoppingCart = Session("ShoppingCart")
        'make sure we go back to current record
        DSCust.SelectCommand = "SELECT * FROM cust where custid=" & SC.custid
        If txtstate.Text.Length > 0 And UniqueState(txtstate.Text) = True Then
            dsstates.InsertCommand = "INSERT INTO states(name) VALUES (upper('" & txtstate.Text & "'))"
            Try
                dsstates.Insert()
                ViewState.Add("InsertNewSState", txtstate.Text)
               
            Catch ex As Exception
                ddlstate.Visible = True
                txtstate.Visible = False
            End Try
        Else
            ViewState.Add("InsertNewSState", txtstate.Text)

        End If
    End Sub

	Protected Sub ddlstate_SelectedIndexChanged(sender As Object, e As System.EventArgs)
		'Dim ddlstate As DropDownList = FormView1.FindControl("ddlstate")
		'Dim txtstate As TextBox = FormView1.FindControl("TextBox3")

		'If ddlstate.SelectedValue = "add" Then
		'    ddlstate.Visible = False
		'    txtstate.Visible = True
		'Else
		'    ddlstate.Visible = True
		'    txtstate.Visible = False
		'End If

	End Sub

    Protected Sub TextBox3_TextChanged(sender As Object, e As System.EventArgs)
        Dim SC As ShoppingCart = Session("ShoppingCart")
        'make sure we go back to current record
        DSCust.SelectCommand = "SELECT * FROM cust where custid=" & SC.custid
        Dim txtstate As TextBox = FormView1.FindControl("TextBox3")
        Dim ddlstate As DropDownList = FormView1.FindControl("ddlstate")
        'Dim sddlstate As DropDownList = FormView1.FindControl("sddlstateins")
        If txtstate.Text.Length > 0 And UniqueState(txtstate.Text) = True Then
            dsstates.InsertCommand = "INSERT INTO states(name) VALUES (upper('" & txtstate.Text & "'))"
            Try
                dsstates.Insert()
                
                Me.ViewState.Add("NewState", txtstate.Text)
                FormView1.DataBind()
            Catch ex As Exception
                ddlstate.Visible = True
                txtstate.Visible = False
            End Try
        Else
            Me.ViewState.Add("NewState", txtstate.Text)
        End If
    End Sub

    Protected Sub sddlstateins_SelectedIndexChanged(sender As Object, e As System.EventArgs)
		'Dim ddlstate As DropDownList = FormView1.FindControl("sddlstateins")
		'Dim txtstate As TextBox = FormView1.FindControl("TextBox4")

		'If ddlstate.SelectedValue = "add" Then
		'    ddlstate.Visible = False
		'    txtstate.Visible = True
		'Else
		'    ddlstate.Visible = True
		'    txtstate.Visible = False
		'End If
    End Sub

    Protected Sub TextBox4_TextChanged(sender As Object, e As System.EventArgs)
        Dim SC As ShoppingCart = Session("ShoppingCart")
        'make sure we go back to current record
        DSCust.SelectCommand = "SELECT * FROM cust where custid=" & SC.custid
        Dim txtstate As TextBox = FormView1.FindControl("TextBox4")
        Dim ddlstate As DropDownList = FormView1.FindControl("sddlstateins")

        If txtstate.Text.Length > 0 And UniqueState(txtstate.Text) = True Then
            dsstates.InsertCommand = "INSERT INTO states(name) VALUES (upper('" & txtstate.Text & "'))"
            Try
                dsstates.Insert()
                Me.ViewState.Add("NewSState", txtstate.Text)
                'ddlstate.Visible = True

                'txtstate.Visible = False


            Catch ex As Exception
                ddlstate.Visible = True
                txtstate.Visible = False
            End Try
        Else
            Me.ViewState.Add("NewSState", txtstate.Text)
        End If
    End Sub

    Protected Sub ddlstate_DataBound(sender As Object, e As System.EventArgs)
        Dim ddlstate As DropDownList = FormView1.FindControl("ddlstate")
        If Not IsNothing(ViewState("NewState")) Then
            ddlstate.SelectedValue = ViewState("NewState")
        End If
    End Sub

    Protected Sub sddlstateins_DataBound(sender As Object, e As System.EventArgs)
        Dim ddlstate As DropDownList = FormView1.FindControl("sddlstateins")
        If Not IsNothing(ViewState("NewSState")) Then
            ddlstate.SelectedValue = ViewState("NewSState")
        End If
    End Sub

    Protected Sub ddlstateins_DataBound(sender As Object, e As System.EventArgs)
      
        Dim ddlstate As DropDownList = FormView1.FindControl("ddlstateins")
        If Not IsNothing(ViewState("InsertNewState")) Then
            ddlstate.SelectedValue = ViewState("InsertNewState")
        End If
    End Sub

    Protected Sub sddlstate_DataBound(sender As Object, e As System.EventArgs)
        Dim ddlstate As DropDownList = FormView1.FindControl("sddlstate")
        If Not IsNothing(ViewState("InsertNewSState")) Then
            ddlstate.SelectedValue = ViewState("InsertNewSState")
        End If
    End Sub

    Protected Sub Page_Unload(sender As Object, e As System.EventArgs) Handles Me.Unload
        Dim SC As ShoppingCart = Session("ShoppingCart")
        Dim shipzip As TextBox = FormView1.FindControl("szip")

        Try
            Dim izip As Integer = CInt(shipzip.Text)
            If izip > 99500 And izip < 99951 Then
                SC.shipmethod = "AK/HI"
            ElseIf izip > 96700 And izip < 96899 Then
                SC.shipmethod = "AK/HI"
            Else
                If SC.shipmethod = "AK/HI" Then
					SC.shipmethod = "STANDARD"
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

	





	Protected Sub chkint112_CheckedChanged(sender As Object, e As System.EventArgs)	 'edit page
		Dim fvstate As RequiredFieldValidator = FormView1.FindControl("fvstate")
		Dim chk112 As CheckBox = sender
		Dim sdlcountry As DropDownList = FormView1.FindControl("sddlcountry")
		If chk112.Checked = True Then
			fvstate.Enabled = False
		Else
			fvstate.Enabled = True
		End If
		Try
			If chk112.Checked = False Then
				sdlcountry.SelectedValue = "US"
			End If
		Catch ex As Exception

		End Try
	End Sub
	

	
	Protected Sub chkint2edt_CheckedChanged(sender As Object, e As System.EventArgs) 'edit
		Dim RequiredFieldValidator6 As RequiredFieldValidator = FormView1.FindControl("RequiredFieldValidator6")
		Dim chk2 As CheckBox = sender
		Dim ddlcountryedt As DropDownList = FormView1.FindControl("ddlcountryedt")
		If chk2.Checked = True Then
			RequiredFieldValidator6.Enabled = False
		Else
			RequiredFieldValidator6.Enabled = True
		End If
		Try
			If chk2.Checked = False Then
				ddlcountryedt.SelectedValue = "US"
			End If
		Catch ex As Exception

		End Try
	End Sub

	Protected Sub ddlcountryedt_SelectedIndexChanged(sender As Object, e As System.EventArgs) 'edit page
		Dim chkint2edt As CheckBox = FormView1.FindControl("chkint2edt")
		Try
			If sender.selectedvalue <> "US" Then
				chkint2edt.Checked = True
			Else
				chkint2edt.Checked = False
			End If
		Catch ex As Exception

		End Try
		
	End Sub

	Protected Sub sddlcountry_SelectedIndexChanged(sender As Object, e As System.EventArgs)	 'edit page
		Dim chkint112 As CheckBox = FormView1.FindControl("chkint112")
		Try
			If sender.selectedvalue <> "US" Then
				chkint112.Checked = True
			Else
				chkint112.Checked = False
			End If
		Catch ex As Exception

		End Try
	End Sub



	'INSERT PAGE______________________________________________________________________________________________________________________
	'__________________________________________________________________________________________________________________________________

	Protected Sub chkinternational_CheckedChanged1(sender As Object, e As System.EventArgs)	  'insert
		Dim RequiredFieldValidator66 As RequiredFieldValidator = FormView1.FindControl("RequiredFieldValidator66")
		Dim chk2 As CheckBox = sender
		Dim ddlcountry1 As DropDownList = FormView1.FindControl("ddlcountry1")
		If chk2.Checked = True Then
			RequiredFieldValidator66.Enabled = False
		Else
			RequiredFieldValidator66.Enabled = True
		End If
		Try
			If chk2.Checked = False Then
				ddlcountry1.SelectedValue = "US"
			End If
		Catch ex As Exception

		End Try
	End Sub

	Protected Sub ddlcountry1_SelectedIndexChanged1(sender As Object, e As System.EventArgs)	 'insert
		Dim ddlcountry1 As DropDownList = sender
		Dim chkinternational As CheckBox = FormView1.FindControl("chkinternational")
		Try
			If ddlcountry1.SelectedValue <> "US" Then
				chkinternational.Checked = True
			ElseIf ddlcountry1.SelectedValue = "US" Then
				chkinternational.Checked = False
			End If
		Catch ex As Exception

		End Try
	End Sub

	Protected Sub chkint11_CheckedChanged(sender As Object, e As System.EventArgs)	'insert page g
		Dim fvstate1 As RequiredFieldValidator = FormView1.FindControl("fvstate1")
		Dim chk111 As CheckBox = sender
		Dim sddlcountry1 As DropDownList = FormView1.FindControl("sddlcountry1")
		If chk111.Checked = True Then
			fvstate1.Enabled = False
		Else
			fvstate1.Enabled = True
		End If
		Try
			If chk111.Checked = False Then
				sddlcountry1.SelectedValue = True
			End If
		Catch ex As Exception

		End Try
	End Sub
	Protected Sub sddlcountry1_SelectedIndexChanged(sender As Object, e As System.EventArgs)   'insert page	 g
		Dim sddlcountry1 As DropDownList = sender
		Dim chkint11 As CheckBox = FormView1.FindControl("chkint11")
		Try
			If sddlcountry1.SelectedValue <> "US" Then
				chkint11.Checked = True
			ElseIf sddlcountry1.SelectedValue = "US" Then
				chkint11.Checked = False
			End If
		Catch ex As Exception

		End Try
	End Sub

	Protected Sub cvcountryins_ServerValidate(source As Object, args As System.Web.UI.WebControls.ServerValidateEventArgs)
		Dim retval As Boolean = True
		Dim ddlcountry1 As DropDownList = FormView1.FindControl("ddlcountry1")
		Dim chkinternational As CheckBox = FormView1.FindControl("chkinternational")
		If chkinternational.Checked = True Then
			If ddlcountry1.SelectedValue = "US" Then
				retval = False
			Else
				retval = True
			End If
		End If
		args.IsValid = retval

	End Sub

	Protected Sub cvcountry1ins_ServerValidate(source As Object, args As System.Web.UI.WebControls.ServerValidateEventArgs)
		Dim retval As Boolean = True
		Dim sddlcountry1 As DropDownList = FormView1.FindControl("sddlcountry1")
		Dim chkint11 As CheckBox = FormView1.FindControl("chkint11")
		If chkint11.Checked = True Then
			If sddlcountry1.SelectedValue = "US" Then
				retval = False
			Else
				retval = True
			End If
		End If
		args.IsValid = retval
	End Sub
	Protected Sub cvcountryedt_ServerValidate(source As Object, args As System.Web.UI.WebControls.ServerValidateEventArgs)
		Dim retval As Boolean = True
		Dim ddlcountryedt As DropDownList = FormView1.FindControl("ddlcountryedt")
		Dim chkint2edt As CheckBox = FormView1.FindControl("chkint2edt")
		If chkint2edt.Checked = True Then
			If ddlcountryedt.SelectedValue = "US" Then
				retval = False
			Else
				retval = True
			End If
		End If
		args.IsValid = retval
	End Sub

	Protected Sub cvcountry1edt_ServerValidate(source As Object, args As System.Web.UI.WebControls.ServerValidateEventArgs)
		Dim retval As Boolean = True
		Dim sddlcountry As DropDownList = FormView1.FindControl("sddlcountry")
		Dim chkint112 As CheckBox = FormView1.FindControl("chkint112")
		If chkint112.Checked = True Then
			If sddlcountry.SelectedValue = "US" Then
				retval = False
			Else
				retval = True
			End If
		End If
		args.IsValid = retval
	End Sub


	
End Class
