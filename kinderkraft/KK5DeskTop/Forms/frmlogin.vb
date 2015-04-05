
Public Class frmlogin
    
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See  ).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Dim ncount As Integer = 0
    Public Property NumTry() As Integer
        Get
            Return ncount
        End Get
        Set(ByVal Value As Integer)
            ncount = Value
        End Set
    End Property
    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cPassword As String = Me.txtPassword.Text
        Dim cUser As String = Me.txtUser.Text
        Dim cServer As String = Me.cmbServer.Text
        '"Driver={MySQL ODBC 5.1 Driver};uid=root;server=chome;port=3306;password=briggitte;database=Farm"

        CustTableAdapter1.Connection.ConnectionString = "User Id=" & cUser & ";server=" & cServer & ";Password=" & cPassword & ";Persist Security Info=True;database=kinderkraft5; "
        'conn.ConnectionString = "DRIVER=MySQL ODBC 3.51 Driver;UID=root;SERVER=cmain1;PORT=3306;OPTION=0;Password=briggitte;DATABASE =Farm"
        frmMain.AppConnectionString = CustTableAdapter1.Connection.ConnectionString
        frmMain.CurServer = cServer
        frmMain.CurUser = cUser

        frmMain.Text = "KinderKraft 5 on server" & cServer & "\User:" & cUser

        Try
            CustTableAdapter1.Fill(Me.Cust._cust)


            Me.Panel1.Visible = False
            Me.lblSuccess.Visible = True
            Me.Timer1.Enabled = True

            'conn.Close()

        Catch ex As MySql.Data.MySqlClient.MySqlException

            If ex.Number = 1045 Then
                MessageBox.Show("Your password is invalid!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ElseIf ex.Number = 1045 Then
                MessageBox.Show("Connection to the Mysql Server is not available!", "No Connection To Server", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                MessageBox.Show(ex.Message, "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Application.Exit()
            End If
            Me.NumTry = Me.NumTry + 1
            If NumTry = 3 Then
                MessageBox.Show("You have reached your limit of 3 tries to connect. Contact your system administrator.", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Application.Exit()
            Else

                Exit Sub

            End If
        Finally

        End Try

    End Sub

    Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.Close()
        frmMain.Show()


    End Sub

    

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.OK_Click_1(Me, e)
        End If
    End Sub

   

    Private Sub frmlogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cust._cust' table. You can move, or remove it, as needed.
        Me.CustTableAdapter1.Fill(Me.Cust._cust)
        '


    End Sub

    Private Sub CustBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles CustBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Cust)

    End Sub
End Class
