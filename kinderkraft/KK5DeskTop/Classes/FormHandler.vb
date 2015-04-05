
Namespace FormHandler

    Public Class Forms
        'Field 0 = Form Name
        'Field 1 = Number of Instances
        'Field 2 = Next available instance
        Public Shared Forms(10, 2) As Object 'holds 10 forms with 3 pieces of data
        Public Shared Function GetFormInstance(ByVal strFormName As Object) As String
            Dim i As Integer
            Dim found As Boolean = False
            Dim lastrec As Integer = Forms.GetLength(0) - 1

            For i = 0 To lastrec
                If Forms(i, 0) = strFormName Then
                    found = True
                    Increase(i)
                    Exit For
                End If
                If found = False And String.IsNullOrEmpty(Forms(i, 0)) Then
                    Add(strFormName, i)
                    Exit For
                End If
            Next
            Return Forms(i, 1)
        End Function
        Public Shared Function GetTextInstance(ByVal strFormName As Object) As String
            Dim i As Integer
            Dim found As Boolean = False
            Dim lastrec As Integer = Forms.GetLength(0) - 1
            For i = 0 To lastrec
                If Forms(i, 0) = strFormName Then
                    found = True
                    Return Forms(i, 2)
                    Exit For
                End If
            Next
            If found = False Then
                MessageBox.Show("Form Name Not Found.", "Error", MessageBoxButtons.OK)

            End If
            Return "00"

        End Function
        Private Shared Sub Add(ByVal strFormName As Object, ByVal lastrec As Integer)
            Forms(lastrec, 0) = strFormName
            Forms(lastrec, 1) = "0"
            Forms(lastrec, 2) = "0"
        End Sub
        Private Shared Sub Increase(ByVal i As Integer)
            Forms(i, 1) = CStr(CInt(Forms(i, 1) + 1))
            Forms(i, 2) = CStr(CInt(Forms(i, 2) + 1))
        End Sub
        Public Shared Sub Decrease(ByVal strFormName As Object)
            Dim i As Integer
            Dim lastrec As Integer = Forms.GetLength(0) - 1
            'Dim a As String
            For i = 0 To lastrec
                If Forms(i, 0) = strFormName Then
                    Forms(i, 1) = CStr(CInt(Forms(i, 1) - 1))
                    If Forms(i, 1) = "-1" Then
                        Forms(i, 2) = "-1"
                    End If
                    Exit For
                End If
            Next
        End Sub
    End Class
End Namespace
