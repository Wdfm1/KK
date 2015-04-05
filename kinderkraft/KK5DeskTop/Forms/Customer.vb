Public Class Customer
    Private _editmode As Boolean = False

    Public Property EditMode() As Boolean
        Get
            Return _editmode
        End Get
        Set(ByVal Value As Boolean)
            _editmode = Value
            AddBindings()
        End Set
    End Property
   
    Private Sub CustBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cust)

        Me.EditMode = False
    End Sub

    Private Sub Customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LkState.states' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Connection.ConnectionString = "User Id=root;server=memserver;Password=3l3phant1;Persist Security Info=True;database=kinderkraft5; "
        Me.StatesTableAdapter.Fill(Me.LkState.states)
        'TODO: This line of code loads data into the 'Cust._cust' table. You can move, or remove it, as needed.
        CustTableAdapter.Connection.ConnectionString = "User Id=root;server=memserver;Password=3l3phant1;Persist Security Info=True;database=kinderkraft5; "
        Me.CustTableAdapter.Fill(Me.Cust._cust)
        AddBindings()

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.EditMode = False Then
            Me.EditMode = True
        Else
            Me.EditMode = False
        End If
      
    End Sub
    Private Sub AddBindings()
        Panel1.DataBindings.Clear()
        Panel1.DataBindings.Add("Enabled", Me, "EditMode")
    End Sub

    Private Sub CompanyNameTextBox_TextChanged(sender As System.Object, e As System.EventArgs)
        Me.ScompanynameTextBox.Text = Me.CompanyNameTextBox.Text
    End Sub


End Class