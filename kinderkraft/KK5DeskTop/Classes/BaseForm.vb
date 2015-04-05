
'Panels Allow for control that are in two rows to stretch to proper dimensions
Imports Cattle.FormHandler


Public Class BaseForm
    Inherits System.Windows.Forms.Form

    Dim iStartingFormWidth As Integer
    Dim iPanelFormDiff As Integer
    Dim iLeftPanelHeight As Integer
    Dim icid As Integer = 1
    Dim val1 As Boolean = False
    Dim val2 As Boolean = False
    Dim curinstance As String
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
       

        ' Add any initialization after the InitializeComponent() call.

    End Sub
   
#Region "Properties"
    Public Property BottomPanelFloat() As Boolean
        Get
            Return val2
        End Get
        Set(ByVal Value As Boolean)
            val2 = Value
        End Set
    End Property

    Private Property CloseForm() As Boolean
        Get
            Return val1
        End Get
        Set(ByVal Value As Boolean)
            val1 = Value
        End Set
    End Property

    Public Property MaxNumForms() As Integer
        Get
            Return icid
        End Get
        Set(ByVal Value As Integer)
            icid = Value
        End Set
    End Property


    Private Property LeftPanelHeight() As Integer
        Get
            Return iLeftPanelHeight
        End Get
        Set(ByVal Value As Integer)
            iLeftPanelHeight = Value
        End Set
    End Property
    Private Property PrevFormWidth() As Integer
        Get
            Return iStartingFormWidth
        End Get
        Set(ByVal Value As Integer)
            iStartingFormWidth = Value
        End Set
    End Property
    Private Property FormHgtMinusBottomPanelHgt() As Integer
        Get
            Return iPanelFormDiff
        End Get
        Set(ByVal Value As Integer)
            iPanelFormDiff = Value
        End Set
    End Property
    Public Property CurrentInstance() As String
        Get
            Return curinstance
        End Get
        Set(ByVal Value As String)
            curinstance = Value
        End Set
    End Property
#End Region
    Private Sub BaseForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        FormHandler.Forms.Decrease(Me.Name)
    End Sub

    
    Private Sub BaseForm_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Me.Layout


        Me.AdustPanels()


    End Sub

    Private Sub BaseForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim a As String = FormHandler.Forms.GetFormInstance(Me.Name)
        Me.curinstance = FormHandler.Forms.GetTextInstance(Me.Name)
        If a >= Me.MaxNumForms Then
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If

        If Me.CurrentInstance = "0" Then
            Me.Text = Me.Text
        Else
            Me.Text = Me.Text & " (" & Me.CurrentInstance & ")"
        End If


        Me.SetProperties()
    End Sub


#Region "Custom Subs"
    Private Sub AdustPanels()
        If Me.DesignMode = False Then


            Dim WidthRatio As Double = (Me.Size.Width / PrevFormWidth)
            Try 'Throw error when form is loaded because PREVFORMWIDTH variable is not initialized yet 
                LeftPanel.Size = New System.Drawing.Size(LeftPanel.Size.Width * WidthRatio, LeftPanelHeight)
                Me.PrevFormWidth = Me.Size.Width
                If Me.BottomPanelFloat = False Then
                    BottomPanel.Size = New System.Drawing.Size(BottomPanel.Size.Width, Me.Size.Height - Me.FormHgtMinusBottomPanelHgt)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub SetProperties()
        Me.PrevFormWidth = Me.Width
        Me.FormHgtMinusBottomPanelHgt = Me.Height - Me.BottomPanel.Height
        Me.LeftPanelHeight = Me.LeftPanel.Height
    End Sub
    Public Overridable Sub Save()

    End Sub
#End Region
End Class