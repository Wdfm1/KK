Public Class Customer
    Private _editmode As Boolean = True 'true to set readonly to true at load
    Private _chkeditmode = False
    Public Property NoEditMode() As Boolean
        Get
            Return _editmode
        End Get
        Set(ByVal Value As Boolean)
            _editmode = Value
            AddBindings()
        End Set
    End Property
    Public Property ChkEditMode() As Boolean
        Get
            Return _chkeditmode
        End Get
        Set(ByVal Value As Boolean)
            _chkeditmode = Value
            AddBindings()
        End Set
    End Property
    Private Sub CustBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cust)
        Me.NoEditMode = True
        Me.ChkEditMode = False
    End Sub

    Private Sub Customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LkState.states' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Connection.ConnectionString = "User Id=root;server=memserver;Password=3l3phant1;Persist Security Info=True;database=kinderkraft5; "
        Me.StatesTableAdapter.Fill(Me.LkState.states)
        'TODO: This line of code loads data into the 'Cust._cust' table. You can move, or remove it, as needed.
        CustTableAdapter.Connection.ConnectionString = "User Id=root;server=memserver;Password=3l3phant1;Persist Security Info=True;database=kinderkraft5; "
        Me.CustTableAdapter.Fill(Me.Cust._cust)

        Me.AddBindings()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.NoEditMode = False Then
            Me.NoEditMode = True
        Else
            Me.NoEditMode = False
        End If
        If Me.ChkEditMode = False Then
            Me.ChkEditMode = True
        Else
            Me.ChkEditMode = False
        End If
    End Sub
    Private Sub AddBindings()
        CompanyNameTextBox.DataBindings.Clear()
        CompanyNameTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        FnameTextBox.DataBindings.Clear()
        FnameTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        LnameTextBox.DataBindings.Clear()
        LnameTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        Billingaddr1TextBox.DataBindings.Clear()
        Billingaddr1TextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        Billingaddr2TextBox.DataBindings.Clear()
        Billingaddr2TextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        CityTextBox.DataBindings.Clear()
        CityTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        PostalcodeTextBox.DataBindings.Clear()
        PostalcodeTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        CountryTextBox.DataBindings.Clear()
        CountryTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        PhonenumberTextBox.DataBindings.Clear()
        PhonenumberTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        EmailAddressTextBox.DataBindings.Clear()
        EmailAddressTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")

        SfnameTextBox.DataBindings.Clear()
        SfnameTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        SlnameTextBox.DataBindings.Clear()
        SlnameTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        Saddr1TextBox.DataBindings.Clear()
        Saddr1TextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        Billingaddr2TextBox.DataBindings.Clear()
        Billingaddr2TextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        ScityTextBox.DataBindings.Clear()
        ScityTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        SpostalcodeTextBox.DataBindings.Clear()
        SpostalcodeTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        ScountryTextBox.DataBindings.Clear()
        ScountryTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        TextBox1.DataBindings.Clear()
        TextBox1.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        TaxidTextBox.DataBindings.Clear()
        TaxidTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        UsernameTextBox.DataBindings.Clear()
        UsernameTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")
        PasswordTextBox.DataBindings.Clear()
        PasswordTextBox.DataBindings.Add("ReadOnly", Me, "NoEditMode")

        ComboBox1.DataBindings.Clear()
        ComboBox1.DataBindings.Add("Enabled", Me, "chkEditMode")
        ComboBox1.DataBindings.Add("SelectedValue", CustBindingSource, "state")
        ComboBox1.DataBindings.Add("SelectedItem", CustBindingSource, "state")
        InternationalCheckBox.DataBindings.Clear()
        InternationalCheckBox.DataBindings.Add("Enabled", Me, "chkEditMode")
        ComboBox2.DataBindings.Clear()
        ComboBox2.DataBindings.Add("Enabled", Me, "chkEditMode")
        SinternationalCheckBox.DataBindings.Clear()
        SinternationalCheckBox.DataBindings.Add("enabled", Me, "chkEditMode")
        AllowpoCheckBox.DataBindings.Clear()
        AllowpoCheckBox.DataBindings.Add("enabled", Me, "chkEditMode")
        EmailsubscriberCheckBox.DataBindings.Clear()
        EmailsubscriberCheckBox.DataBindings.Add("enabled", Me, "chkEditMode")
        CheckBox2.DataBindings.Clear()
        CheckBox2.DataBindings.Add("enabled", Me, "chkEditMode")
        TaxexemptCheckBox.DataBindings.Clear()
        TaxexemptCheckBox.DataBindings.Add("enabled", Me, "chkEditMode")
        TaxexemptconfirmedCheckBox.DataBindings.Clear()
        TaxexemptconfirmedCheckBox.DataBindings.Add("enabled", Me, "chkEditMode")
        CheckBox1.DataBindings.Clear()
        CheckBox1.DataBindings.Add("enabled", Me, "chkEditMode")
        IsorgCheckBox.DataBindings.Clear()
        IsorgCheckBox.DataBindings.Add("enabled", Me, "chkEditMode")

    End Sub

    Private Sub CompanyNameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CompanyNameTextBox.TextChanged
        Me.ScompanynameTextBox.Text = Me.CompanyNameTextBox.Text
    End Sub
End Class