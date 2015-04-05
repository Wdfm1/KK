Imports System.IO

Partial Class clearance
    Inherits webformbase

    Protected Sub KMF_Load(sender As Object, e As System.EventArgs) Handles KMF.Load

        Dim prodcode As Label = sender
        Me.KMF.Text = "$" & Me.RetPrice(sender.text.ToString.ToUpper)

    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsNothing(Session("ShoppingCart")) Then
            Dim SC As New ShoppingCart
            Dim lt As New LookUpTable
            lt.ConnectStr = ConfigurationManager.ConnectionStrings("KK5").ToString 



            Session.Add("ShoppingCart", SC) 'contains orderdetail table and options table and any other tables I create in the new sub of shopping cart
            Session.Add("LookUp", lt) 'contains product table and eventually option tables in it.

        Else ' value set with shoppingcart

        End If
    End Sub
    Function RetPrice(ByVal prodcode As String) As Decimal

        Dim lt As LookUpTable = Session("LookUp")
        Dim dprice As Decimal = 0
        Dim a As String
        Dim rowcount As Integer = lt.ProductTable.Rows.Count - 1
        Do While rowcount <> -1
            a = RTrim(lt.ProductTable.Rows(rowcount).Item("ProdCode").ToString.ToUpper)
            If RTrim(lt.ProductTable.Rows(rowcount).Item("ProdCode").ToString.ToUpper) = RTrim(prodcode.ToUpper) Then
                dprice = lt.ProductTable.Rows(rowcount).Item("Price")
                Exit Do
            End If
            rowcount = rowcount - 1
        Loop
        Return dprice
    End Function
End Class
