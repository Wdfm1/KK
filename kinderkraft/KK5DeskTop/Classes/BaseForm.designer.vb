<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CaptionPanel = New System.Windows.Forms.Panel
        Me.BottomPanel = New System.Windows.Forms.Panel
        Me.LeftPanel = New System.Windows.Forms.Panel
        Me.RightPanel = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'CaptionPanel
        '
        Me.CaptionPanel.BackColor = System.Drawing.SystemColors.Control
        Me.CaptionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CaptionPanel.Location = New System.Drawing.Point(0, 0)
        Me.CaptionPanel.Name = "CaptionPanel"
        Me.CaptionPanel.Size = New System.Drawing.Size(591, 55)
        Me.CaptionPanel.TabIndex = 0
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 252)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(591, 91)
        Me.BottomPanel.TabIndex = 1
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.SystemColors.Control
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 55)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(291, 197)
        Me.LeftPanel.TabIndex = 2
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightPanel.Location = New System.Drawing.Point(291, 55)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(300, 197)
        Me.RightPanel.TabIndex = 3
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 343)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.CaptionPanel)
        Me.Name = "BaseForm"
        Me.Text = "BaseForm1"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents CaptionPanel As System.Windows.Forms.Panel
    Public WithEvents BottomPanel As System.Windows.Forms.Panel
    Public WithEvents LeftPanel As System.Windows.Forms.Panel
    Public WithEvents RightPanel As System.Windows.Forms.Panel
End Class
