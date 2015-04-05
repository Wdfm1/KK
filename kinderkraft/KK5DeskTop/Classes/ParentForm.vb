Public Class ParentForm
    Dim strConnect As String
    Dim strserver As String
    Dim struser As String
    Public Property CurUser() As String
        Get
            Return struser
        End Get
        Set(ByVal Value As String)
            struser = Value
        End Set
    End Property
    Public Property CurServer() As String
        Get
            Return strserver
        End Get
        Set(ByVal Value As String)
            strserver = Value
        End Set
    End Property
    
    Public Property AppConnectionString() As String
        Get
            Return strConnect
        End Get
        Set(ByVal Value As String)
            strConnect = Value
        End Set
    End Property
  
    Public Sub ExitApp()
        Application.Exit()

    End Sub

    Public Sub CascadeWindows()
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)

    End Sub

    Public Sub TileHorizontal()
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Public Sub TileVertical()
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)

    End Sub

    Public Sub ArrangeWindows()
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons)
    End Sub

    Public Sub Copy()
        Dim strName As String

        strName = Me.ActiveMdiChild.ActiveControl.GetType().Name
        If (Not ActiveForm Is Nothing) Then
            Try
                Select Case strName
                    Case "TextBox"
                        Dim theBox As TextBox = CType(Me.ActiveControl, TextBox)
                        theBox.Copy()
                    Case "RichTextBox"
                        Dim theBox As RichTextBox = CType(Me.ActiveControl, RichTextBox)
                        theBox.Copy()
                    Case "MaskedTextBox"
                        Dim theBox As MaskedTextBox = CType(Me.ActiveControl, MaskedTextBox)
                        theBox.Copy()
                    Case "ComboBox" 'combo does not have a cut copy method
                        'active form created in first of method
                        Dim theBox As ComboBox = CType(ActiveForm.ActiveControl, ComboBox)
                        If (Not theBox Is Nothing) Then
                            ' Put selected text on Clipboard.
                            Clipboard.SetDataObject(theBox.SelectedText)
                        End If

                End Select

            Catch
            End Try
        End If
    End Sub
    Public Sub undo()
        Dim strName As String
        Dim activeform As Form = Me.ActiveMdiChild
        strName = Me.ActiveMdiChild.ActiveControl.GetType().Name
        If (Not activeform Is Nothing) Then
            Try
                Select Case strName
                    Case "TextBox"
                        Dim theBox As TextBox = CType(Me.ActiveControl, TextBox)
                        theBox.Undo()
                    Case "RichTextBox"
                        Dim theBox As RichTextBox = CType(Me.ActiveControl, RichTextBox)
                        theBox.Undo()
                    Case "MaskedTextBox"
                        Dim theBox As MaskedTextBox = CType(Me.ActiveControl, MaskedTextBox)
                        theBox.Undo()
                    

                End Select

            Catch
            End Try
        End If
    End Sub
    Public Sub Cut()
        Dim strName As String
        Dim activeform As Form = Me.ActiveMdiChild
        strName = Me.ActiveMdiChild.ActiveControl.GetType().Name
        If (Not activeform Is Nothing) Then
            Try
                Select Case strName
                    Case "TextBox"
                        Dim theBox As TextBox = CType(Me.ActiveControl, TextBox)
                        theBox.Cut()
                    Case "RichTextBox"
                        Dim theBox As RichTextBox = CType(Me.ActiveControl, RichTextBox)
                        theBox.Cut()
                    Case "MaskedTextBox"
                        Dim theBox As MaskedTextBox = CType(Me.ActiveControl, MaskedTextBox)
                        theBox.Cut()
                    Case "ComboBox" 'combo does not have a cut copy method

                        Dim theBox As ComboBox = CType(activeform.ActiveControl, ComboBox)
                        If (Not theBox Is Nothing) Then
                            ' Put selected text on Clipboard.
                            Clipboard.SetDataObject(theBox.SelectedText)
                        End If

                End Select

            Catch
            End Try
        End If
    End Sub

    Public Sub Paste()
        Dim strName As String
        Dim activeform As Form = Me.ActiveMdiChild
        strName = Me.ActiveMdiChild.ActiveControl.GetType().Name
        If (Not activeform Is Nothing) Then
            Try
                Select Case strName
                    Case "TextBox"
                        Dim theBox As TextBox = CType(Me.ActiveControl, TextBox)
                        theBox.Paste()
                    Case "RichTextBox"
                        Dim theBox As RichTextBox = CType(Me.ActiveControl, RichTextBox)
                        theBox.Paste()
                    Case "MaskedTextBox"
                        Dim theBox As MaskedTextBox = CType(Me.ActiveControl, MaskedTextBox)
                        theBox.Paste()
                    Case "ComboBox" 'combo does not have a cut copy method

                        Dim theBox As ComboBox = CType(activeform.ActiveControl, ComboBox)


                        theBox.SelectedText = Clipboard.GetDataObject().GetData(DataFormats.Text)



                End Select

            Catch
            End Try
        End If
    End Sub



End Class
