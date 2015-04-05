Imports ParentForm
Public Class frmMain
    Dim retcalval As Boolean
    Dim retcowid As Integer
    Public Property RetCowNum() As Integer
        Get
            Return retcowid
        End Get
        Set(ByVal Value As Integer)
            retcowid = Value
        End Set
    End Property
    Public Property CalfUpdated() As Boolean
        Get
            Return retcalval
        End Get
        Set(ByVal Value As Boolean)
            retcalval = Value
        End Set
    End Property
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ExitApp()
    End Sub
#Region "EditMenu"
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Me.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Me.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Me.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Me.undo()
    End Sub
#End Region
#Region "ViewMenu"
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.CascadeWindows()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.TileHorizontal()
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.TileHorizontal()
    End Sub

    Private Sub ArrangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeToolStripMenuItem.Click
        Me.ArrangeWindows()
    End Sub
#End Region
#Region "OpenMenu"
    Private Sub CustomerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Me.Cursor = Cursors.AppStarting
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Dim oForm As FarmForm 'Farm Form is the base name change as needed to custom basename
        'oForm = CType(Me.ActiveMdiChild, FarmForm)

        'oForm.Save()

    End Sub
   

  
#End Region
#Region "ToolMenu"
   

   
#End Region
    Private Sub frmMainw_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Hide()
        Dim Login As frmlogin
        Login = New frmlogin()
        Me.WindowState = FormWindowState.Maximized
        Login.Show()
    End Sub


  
  


End Class
