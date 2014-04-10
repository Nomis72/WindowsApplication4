Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frmLesProds

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnajouterprod_Click(sender As Object, e As EventArgs) Handles btnajouterprod.Click
        frmajouterproduit.Show()
    End Sub

    Private Sub btnmodifierprod_Click(sender As Object, e As EventArgs) Handles btnmodifierprod.Click
        frmmodifproduit.Show()

    End Sub

    Private Sub btnSuprProd_Click(sender As Object, e As EventArgs) Handles btnSuprProd.Click
        frmsuprProduit.Show()
    End Sub
End Class