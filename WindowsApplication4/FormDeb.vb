Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormDeb
    Dim cnn As SqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String

        connectionString = "Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP"

        cnn = New SqlConnection(connectionString)

        cnn.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAColec.Click
        frmajoutercollection.Show()
    End Sub

    Private Sub btnMColec_Click(sender As Object, e As EventArgs) Handles btnMColec.Click
        frmmodifcollection.Show()
    End Sub

    Private Sub btnSColec_Click(sender As Object, e As EventArgs) Handles btnSColec.Click
        frmsuprcollection.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
