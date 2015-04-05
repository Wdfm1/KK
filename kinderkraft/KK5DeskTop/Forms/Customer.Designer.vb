<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim TaxidLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim PhonenumberLabel As System.Windows.Forms.Label
        Dim PostalcodeLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim Billingaddr2Label As System.Windows.Forms.Label
        Dim Billingaddr1Label As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim LnameLabel As System.Windows.Forms.Label
        Dim FnameLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.Cust = New KK5DeskTop.cust()
        Me.CustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustTableAdapter = New KK5DeskTop.custTableAdapters.custTableAdapter()
        Me.TableAdapterManager = New KK5DeskTop.custTableAdapters.TableAdapterManager()
        Me.CustBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LkState = New KK5DeskTop.lkState()
        Me.StatesTableAdapter = New KK5DeskTop.lkStateTableAdapters.statesTableAdapter()
        Me.TableAdapterManager1 = New KK5DeskTop.lkStateTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TaxexemptCheckBox = New System.Windows.Forms.CheckBox()
        Me.TaxidTextBox = New System.Windows.Forms.TextBox()
        Me.EmailsubscriberCheckBox = New System.Windows.Forms.CheckBox()
        Me.TaxexemptconfirmedCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowpoCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsorgCheckBox = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InternationalCheckBox = New System.Windows.Forms.CheckBox()
        Me.SinternationalCheckBox = New System.Windows.Forms.CheckBox()
        Me.ScountryTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.SpostalcodeTextBox = New System.Windows.Forms.TextBox()
        Me.ScityTextBox = New System.Windows.Forms.TextBox()
        Me.Saddr2TextBox = New System.Windows.Forms.TextBox()
        Me.Saddr1TextBox = New System.Windows.Forms.TextBox()
        Me.ScompanynameTextBox = New System.Windows.Forms.TextBox()
        Me.SlnameTextBox = New System.Windows.Forms.TextBox()
        Me.SfnameTextBox = New System.Windows.Forms.TextBox()
        Me.PhonenumberTextBox = New System.Windows.Forms.TextBox()
        Me.PostalcodeTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Billingaddr2TextBox = New System.Windows.Forms.TextBox()
        Me.Billingaddr1TextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.CustidTextBox = New System.Windows.Forms.TextBox()
        Me.StatesTableAdapter1 = New KK5DeskTop.lkStateTableAdapters.statesTableAdapter()
        Me.StatesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        TaxidLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        PhonenumberLabel = New System.Windows.Forms.Label()
        PostalcodeLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        Billingaddr2Label = New System.Windows.Forms.Label()
        Billingaddr1Label = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        LnameLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        CType(Me.Cust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustBindingNavigator.SuspendLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LkState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.StatesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(467, 64)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(62, 13)
        PasswordLabel.TabIndex = 80
        PasswordLabel.Text = "Pass Word:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(466, 38)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(63, 13)
        UsernameLabel.TabIndex = 79
        UsernameLabel.Text = "User Name:"
        '
        'TaxidLabel
        '
        TaxidLabel.AutoSize = True
        TaxidLabel.Location = New System.Drawing.Point(152, 92)
        TaxidLabel.Name = "TaxidLabel"
        TaxidLabel.Size = New System.Drawing.Size(40, 13)
        TaxidLabel.TabIndex = 45
        TaxidLabel.Text = "Tax Id:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(620, 293)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(81, 13)
        Label11.TabIndex = 128
        Label11.Text = "Phone Number:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(650, 242)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(46, 13)
        Label1.TabIndex = 123
        Label1.Text = "Country:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(643, 218)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 13)
        Label4.TabIndex = 122
        Label4.Text = "Zip Code:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(661, 194)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(35, 13)
        Label5.TabIndex = 121
        Label5.Text = "State:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(669, 170)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(27, 13)
        Label6.TabIndex = 120
        Label6.Text = "City:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(609, 146)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(87, 13)
        Label7.TabIndex = 119
        Label7.Text = "Billing Address 2:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(618, 123)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(78, 13)
        Label8.TabIndex = 118
        Label8.Text = "Billing Address:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(635, 101)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(61, 13)
        Label9.TabIndex = 117
        Label9.Text = "Last Name:"
        '
        'Label10
        '
        Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(651, 77)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(60, 13)
        Label10.TabIndex = 116
        Label10.Text = "First Name:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(105, 242)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 111
        CountryLabel.Text = "Country:"
        '
        'PhonenumberLabel
        '
        PhonenumberLabel.AutoSize = True
        PhonenumberLabel.Location = New System.Drawing.Point(70, 294)
        PhonenumberLabel.Name = "PhonenumberLabel"
        PhonenumberLabel.Size = New System.Drawing.Size(81, 13)
        PhonenumberLabel.TabIndex = 102
        PhonenumberLabel.Text = "Phone Number:"
        '
        'PostalcodeLabel
        '
        PostalcodeLabel.AutoSize = True
        PostalcodeLabel.Location = New System.Drawing.Point(98, 218)
        PostalcodeLabel.Name = "PostalcodeLabel"
        PostalcodeLabel.Size = New System.Drawing.Size(53, 13)
        PostalcodeLabel.TabIndex = 100
        PostalcodeLabel.Text = "Zip Code:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(116, 194)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 99
        StateLabel.Text = "State:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(124, 170)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 97
        CityLabel.Text = "City:"
        '
        'Billingaddr2Label
        '
        Billingaddr2Label.AutoSize = True
        Billingaddr2Label.Location = New System.Drawing.Point(64, 146)
        Billingaddr2Label.Name = "Billingaddr2Label"
        Billingaddr2Label.Size = New System.Drawing.Size(87, 13)
        Billingaddr2Label.TabIndex = 95
        Billingaddr2Label.Text = "Billing Address 2:"
        '
        'Billingaddr1Label
        '
        Billingaddr1Label.AutoSize = True
        Billingaddr1Label.Location = New System.Drawing.Point(73, 123)
        Billingaddr1Label.Name = "Billingaddr1Label"
        Billingaddr1Label.Size = New System.Drawing.Size(78, 13)
        Billingaddr1Label.TabIndex = 93
        Billingaddr1Label.Text = "Billing Address:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(164, 11)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(85, 13)
        CompanyNameLabel.TabIndex = 91
        CompanyNameLabel.Text = "Company Name:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(75, 318)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 89
        EmailAddressLabel.Text = "Email Address:"
        '
        'LnameLabel
        '
        LnameLabel.AutoSize = True
        LnameLabel.Location = New System.Drawing.Point(90, 101)
        LnameLabel.Name = "LnameLabel"
        LnameLabel.Size = New System.Drawing.Size(61, 13)
        LnameLabel.TabIndex = 87
        LnameLabel.Text = "Last Name:"
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.Location = New System.Drawing.Point(91, 77)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(60, 13)
        FnameLabel.TabIndex = 85
        FnameLabel.Text = "First Name:"
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(4, 11)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(38, 13)
        CustidLabel.TabIndex = 83
        CustidLabel.Text = "custid:"
        '
        'Cust
        '
        Me.Cust.DataSetName = "cust"
        Me.Cust.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustBindingSource
        '
        Me.CustBindingSource.DataMember = "cust"
        Me.CustBindingSource.DataSource = Me.Cust
        '
        'CustTableAdapter
        '
        Me.CustTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.custTableAdapter = Me.CustTableAdapter
        Me.TableAdapterManager.UpdateOrder = KK5DeskTop.custTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustBindingNavigator
        '
        Me.CustBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustBindingNavigator.BindingSource = Me.CustBindingSource
        Me.CustBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.CustBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustBindingNavigator.Name = "CustBindingNavigator"
        Me.CustBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustBindingNavigator.Size = New System.Drawing.Size(1050, 25)
        Me.CustBindingNavigator.TabIndex = 0
        Me.CustBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustBindingNavigatorSaveItem
        '
        Me.CustBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustBindingNavigatorSaveItem.Name = "CustBindingNavigatorSaveItem"
        Me.CustBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "states"
        Me.StatesBindingSource.DataSource = Me.LkState
        '
        'LkState
        '
        Me.LkState.DataSetName = "lkState"
        Me.LkState.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.statesTableAdapter = Me.StatesTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KK5DeskTop.lkStateTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Label11)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.InternationalCheckBox)
        Me.Panel1.Controls.Add(Me.SinternationalCheckBox)
        Me.Panel1.Controls.Add(Me.ScountryTextBox)
        Me.Panel1.Controls.Add(CountryLabel)
        Me.Panel1.Controls.Add(Me.CountryTextBox)
        Me.Panel1.Controls.Add(Me.SpostalcodeTextBox)
        Me.Panel1.Controls.Add(Me.ScityTextBox)
        Me.Panel1.Controls.Add(Me.Saddr2TextBox)
        Me.Panel1.Controls.Add(Me.Saddr1TextBox)
        Me.Panel1.Controls.Add(Me.ScompanynameTextBox)
        Me.Panel1.Controls.Add(Me.SlnameTextBox)
        Me.Panel1.Controls.Add(Me.SfnameTextBox)
        Me.Panel1.Controls.Add(PhonenumberLabel)
        Me.Panel1.Controls.Add(Me.PhonenumberTextBox)
        Me.Panel1.Controls.Add(PostalcodeLabel)
        Me.Panel1.Controls.Add(Me.PostalcodeTextBox)
        Me.Panel1.Controls.Add(StateLabel)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(Me.CityTextBox)
        Me.Panel1.Controls.Add(Billingaddr2Label)
        Me.Panel1.Controls.Add(Me.Billingaddr2TextBox)
        Me.Panel1.Controls.Add(Billingaddr1Label)
        Me.Panel1.Controls.Add(Me.Billingaddr1TextBox)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel1.Controls.Add(EmailAddressLabel)
        Me.Panel1.Controls.Add(Me.EmailAddressTextBox)
        Me.Panel1.Controls.Add(LnameLabel)
        Me.Panel1.Controls.Add(Me.LnameTextBox)
        Me.Panel1.Controls.Add(FnameLabel)
        Me.Panel1.Controls.Add(Me.FnameTextBox)
        Me.Panel1.Controls.Add(CustidLabel)
        Me.Panel1.Controls.Add(Me.CustidTextBox)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 550)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(412, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 23)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Copy Billing To Shipping"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(PasswordLabel)
        Me.Panel2.Controls.Add(Me.PasswordTextBox)
        Me.Panel2.Controls.Add(UsernameLabel)
        Me.Panel2.Controls.Add(Me.UsernameTextBox)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TaxexemptCheckBox)
        Me.Panel2.Controls.Add(Me.TaxidTextBox)
        Me.Panel2.Controls.Add(TaxidLabel)
        Me.Panel2.Controls.Add(Me.EmailsubscriberCheckBox)
        Me.Panel2.Controls.Add(Me.TaxexemptconfirmedCheckBox)
        Me.Panel2.Controls.Add(Me.AllowpoCheckBox)
        Me.Panel2.Controls.Add(Me.IsorgCheckBox)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Location = New System.Drawing.Point(7, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1039, 190)
        Me.Panel2.TabIndex = 130
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "repofschool", True))
        Me.CheckBox2.Location = New System.Drawing.Point(17, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox2.TabIndex = 84
        Me.CheckBox2.Text = "Rep of School"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(528, 61)
        Me.PasswordTextBox.MaxLength = 45
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(229, 20)
        Me.PasswordTextBox.TabIndex = 81
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(528, 35)
        Me.UsernameTextBox.MaxLength = 45
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(229, 20)
        Me.UsernameTextBox.TabIndex = 80
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(454, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 24)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Office Use"
        '
        'TaxexemptCheckBox
        '
        Me.TaxexemptCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "taxexempt", True))
        Me.TaxexemptCheckBox.Location = New System.Drawing.Point(196, 42)
        Me.TaxexemptCheckBox.Name = "TaxexemptCheckBox"
        Me.TaxexemptCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.TaxexemptCheckBox.TabIndex = 40
        Me.TaxexemptCheckBox.Text = "Tax Exempt"
        Me.TaxexemptCheckBox.UseVisualStyleBackColor = True
        '
        'TaxidTextBox
        '
        Me.TaxidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "taxid", True))
        Me.TaxidTextBox.Location = New System.Drawing.Point(196, 85)
        Me.TaxidTextBox.MaxLength = 45
        Me.TaxidTextBox.Name = "TaxidTextBox"
        Me.TaxidTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TaxidTextBox.TabIndex = 46
        '
        'EmailsubscriberCheckBox
        '
        Me.EmailsubscriberCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "emailsubscriber", True))
        Me.EmailsubscriberCheckBox.Location = New System.Drawing.Point(17, 66)
        Me.EmailsubscriberCheckBox.Name = "EmailsubscriberCheckBox"
        Me.EmailsubscriberCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.EmailsubscriberCheckBox.TabIndex = 60
        Me.EmailsubscriberCheckBox.Text = "Email Subsciber"
        Me.EmailsubscriberCheckBox.UseVisualStyleBackColor = True
        '
        'TaxexemptconfirmedCheckBox
        '
        Me.TaxexemptconfirmedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "taxexemptconfirmed", True))
        Me.TaxexemptconfirmedCheckBox.Location = New System.Drawing.Point(196, 66)
        Me.TaxexemptconfirmedCheckBox.Name = "TaxexemptconfirmedCheckBox"
        Me.TaxexemptconfirmedCheckBox.Size = New System.Drawing.Size(136, 17)
        Me.TaxexemptconfirmedCheckBox.TabIndex = 48
        Me.TaxexemptconfirmedCheckBox.Text = "Tax Exempt Confirmed"
        Me.TaxexemptconfirmedCheckBox.UseVisualStyleBackColor = True
        '
        'AllowpoCheckBox
        '
        Me.AllowpoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "allowpo", True))
        Me.AllowpoCheckBox.Location = New System.Drawing.Point(17, 42)
        Me.AllowpoCheckBox.Name = "AllowpoCheckBox"
        Me.AllowpoCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.AllowpoCheckBox.TabIndex = 50
        Me.AllowpoCheckBox.Text = "Allow PO"
        Me.AllowpoCheckBox.UseVisualStyleBackColor = True
        '
        'IsorgCheckBox
        '
        Me.IsorgCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "isorg", True))
        Me.IsorgCheckBox.Location = New System.Drawing.Point(351, 66)
        Me.IsorgCheckBox.Name = "IsorgCheckBox"
        Me.IsorgCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.IsorgCheckBox.TabIndex = 42
        Me.IsorgCheckBox.Text = "Organization"
        Me.IsorgCheckBox.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "iscs", True))
        Me.CheckBox1.Location = New System.Drawing.Point(351, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox1.TabIndex = 61
        Me.CheckBox1.Text = "CS Person"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "sphonenumber", True))
        Me.TextBox1.Location = New System.Drawing.Point(706, 286)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 20)
        Me.TextBox1.TabIndex = 129
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustBindingSource, "sstate", True))
        Me.ComboBox2.DataSource = Me.StatesBindingSource1
        Me.ComboBox2.DisplayMember = "name"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(707, 186)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox2.TabIndex = 127
        Me.ComboBox2.ValueMember = "name"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustBindingSource, "state", True))
        Me.ComboBox1.DataSource = Me.StatesBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(156, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.TabIndex = 126
        Me.ComboBox1.ValueMember = "name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(688, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 24)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Shipping Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Billing Information"
        '
        'InternationalCheckBox
        '
        Me.InternationalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "international", True))
        Me.InternationalCheckBox.Location = New System.Drawing.Point(156, 260)
        Me.InternationalCheckBox.Name = "InternationalCheckBox"
        Me.InternationalCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.InternationalCheckBox.TabIndex = 115
        Me.InternationalCheckBox.Text = "International"
        Me.InternationalCheckBox.UseVisualStyleBackColor = True
        '
        'SinternationalCheckBox
        '
        Me.SinternationalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustBindingSource, "sinternational", True))
        Me.SinternationalCheckBox.Location = New System.Drawing.Point(707, 260)
        Me.SinternationalCheckBox.Name = "SinternationalCheckBox"
        Me.SinternationalCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SinternationalCheckBox.TabIndex = 114
        Me.SinternationalCheckBox.Text = "International"
        Me.SinternationalCheckBox.UseVisualStyleBackColor = True
        '
        'ScountryTextBox
        '
        Me.ScountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "scountry", True))
        Me.ScountryTextBox.Location = New System.Drawing.Point(707, 235)
        Me.ScountryTextBox.MaxLength = 45
        Me.ScountryTextBox.Name = "ScountryTextBox"
        Me.ScountryTextBox.Size = New System.Drawing.Size(225, 20)
        Me.ScountryTextBox.TabIndex = 113
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(156, 235)
        Me.CountryTextBox.MaxLength = 45
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(225, 20)
        Me.CountryTextBox.TabIndex = 112
        '
        'SpostalcodeTextBox
        '
        Me.SpostalcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "spostalcode", True))
        Me.SpostalcodeTextBox.Location = New System.Drawing.Point(707, 211)
        Me.SpostalcodeTextBox.Name = "SpostalcodeTextBox"
        Me.SpostalcodeTextBox.Size = New System.Drawing.Size(225, 20)
        Me.SpostalcodeTextBox.TabIndex = 110
        '
        'ScityTextBox
        '
        Me.ScityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "scity", True))
        Me.ScityTextBox.Location = New System.Drawing.Point(707, 163)
        Me.ScityTextBox.MaxLength = 45
        Me.ScityTextBox.Name = "ScityTextBox"
        Me.ScityTextBox.Size = New System.Drawing.Size(225, 20)
        Me.ScityTextBox.TabIndex = 109
        '
        'Saddr2TextBox
        '
        Me.Saddr2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "saddr2", True))
        Me.Saddr2TextBox.Location = New System.Drawing.Point(707, 139)
        Me.Saddr2TextBox.MaxLength = 45
        Me.Saddr2TextBox.Name = "Saddr2TextBox"
        Me.Saddr2TextBox.Size = New System.Drawing.Size(225, 20)
        Me.Saddr2TextBox.TabIndex = 108
        '
        'Saddr1TextBox
        '
        Me.Saddr1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "saddr1", True))
        Me.Saddr1TextBox.Location = New System.Drawing.Point(707, 116)
        Me.Saddr1TextBox.MaxLength = 45
        Me.Saddr1TextBox.Name = "Saddr1TextBox"
        Me.Saddr1TextBox.Size = New System.Drawing.Size(225, 20)
        Me.Saddr1TextBox.TabIndex = 107
        '
        'ScompanynameTextBox
        '
        Me.ScompanynameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "scompanyname", True))
        Me.ScompanynameTextBox.Location = New System.Drawing.Point(911, 11)
        Me.ScompanynameTextBox.Name = "ScompanynameTextBox"
        Me.ScompanynameTextBox.ReadOnly = True
        Me.ScompanynameTextBox.Size = New System.Drawing.Size(1, 20)
        Me.ScompanynameTextBox.TabIndex = 106
        '
        'SlnameTextBox
        '
        Me.SlnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "slname", True))
        Me.SlnameTextBox.Location = New System.Drawing.Point(707, 94)
        Me.SlnameTextBox.MaxLength = 45
        Me.SlnameTextBox.Name = "SlnameTextBox"
        Me.SlnameTextBox.Size = New System.Drawing.Size(225, 20)
        Me.SlnameTextBox.TabIndex = 105
        '
        'SfnameTextBox
        '
        Me.SfnameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SfnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "sfname", True))
        Me.SfnameTextBox.Location = New System.Drawing.Point(710, 70)
        Me.SfnameTextBox.MaxLength = 45
        Me.SfnameTextBox.Name = "SfnameTextBox"
        Me.SfnameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.SfnameTextBox.TabIndex = 104
        '
        'PhonenumberTextBox
        '
        Me.PhonenumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "phonenumber", True))
        Me.PhonenumberTextBox.Location = New System.Drawing.Point(156, 287)
        Me.PhonenumberTextBox.MaxLength = 15
        Me.PhonenumberTextBox.Name = "PhonenumberTextBox"
        Me.PhonenumberTextBox.Size = New System.Drawing.Size(225, 20)
        Me.PhonenumberTextBox.TabIndex = 103
        '
        'PostalcodeTextBox
        '
        Me.PostalcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "postalcode", True))
        Me.PostalcodeTextBox.Location = New System.Drawing.Point(156, 211)
        Me.PostalcodeTextBox.Name = "PostalcodeTextBox"
        Me.PostalcodeTextBox.Size = New System.Drawing.Size(225, 20)
        Me.PostalcodeTextBox.TabIndex = 101
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "city", True))
        Me.CityTextBox.Location = New System.Drawing.Point(156, 163)
        Me.CityTextBox.MaxLength = 45
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(225, 20)
        Me.CityTextBox.TabIndex = 98
        '
        'Billingaddr2TextBox
        '
        Me.Billingaddr2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "billingaddr2", True))
        Me.Billingaddr2TextBox.Location = New System.Drawing.Point(156, 139)
        Me.Billingaddr2TextBox.MaxLength = 45
        Me.Billingaddr2TextBox.Name = "Billingaddr2TextBox"
        Me.Billingaddr2TextBox.Size = New System.Drawing.Size(225, 20)
        Me.Billingaddr2TextBox.TabIndex = 96
        '
        'Billingaddr1TextBox
        '
        Me.Billingaddr1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "billingaddr1", True))
        Me.Billingaddr1TextBox.Location = New System.Drawing.Point(156, 116)
        Me.Billingaddr1TextBox.MaxLength = 45
        Me.Billingaddr1TextBox.Name = "Billingaddr1TextBox"
        Me.Billingaddr1TextBox.Size = New System.Drawing.Size(225, 20)
        Me.Billingaddr1TextBox.TabIndex = 94
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(255, 8)
        Me.CompanyNameTextBox.MaxLength = 100
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.ReadOnly = True
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(267, 20)
        Me.CompanyNameTextBox.TabIndex = 92
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(156, 311)
        Me.EmailAddressTextBox.MaxLength = 45
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(225, 20)
        Me.EmailAddressTextBox.TabIndex = 90
        '
        'LnameTextBox
        '
        Me.LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "lname", True))
        Me.LnameTextBox.Location = New System.Drawing.Point(156, 94)
        Me.LnameTextBox.MaxLength = 45
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(225, 20)
        Me.LnameTextBox.TabIndex = 88
        '
        'FnameTextBox
        '
        Me.FnameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(156, 70)
        Me.FnameTextBox.MaxLength = 45
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(225, 20)
        Me.FnameTextBox.TabIndex = 86
        '
        'CustidTextBox
        '
        Me.CustidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "custid", True))
        Me.CustidTextBox.Location = New System.Drawing.Point(48, 8)
        Me.CustidTextBox.Name = "CustidTextBox"
        Me.CustidTextBox.ReadOnly = True
        Me.CustidTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustidTextBox.TabIndex = 84
        '
        'StatesTableAdapter1
        '
        Me.StatesTableAdapter1.ClearBeforeFill = True
        '
        'StatesBindingSource1
        '
        Me.StatesBindingSource1.DataMember = "states"
        Me.StatesBindingSource1.DataSource = Me.LkState
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 576)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CustBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.Cust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustBindingNavigator.ResumeLayout(False)
        Me.CustBindingNavigator.PerformLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LkState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.StatesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cust As KK5DeskTop.cust
    Friend WithEvents CustBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustTableAdapter As KK5DeskTop.custTableAdapters.custTableAdapter
    Friend WithEvents TableAdapterManager As KK5DeskTop.custTableAdapters.TableAdapterManager
    Friend WithEvents CustBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LkState As KK5DeskTop.lkState
    Friend WithEvents StatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatesTableAdapter As KK5DeskTop.lkStateTableAdapters.statesTableAdapter
    Friend WithEvents TableAdapterManager1 As KK5DeskTop.lkStateTableAdapters.TableAdapterManager
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TaxexemptCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TaxidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailsubscriberCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TaxexemptconfirmedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowpoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsorgCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InternationalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SinternationalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ScountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpostalcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Saddr2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Saddr1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScompanynameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SlnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SfnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhonenumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Billingaddr2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Billingaddr1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StatesTableAdapter1 As KK5DeskTop.lkStateTableAdapters.statesTableAdapter
End Class
