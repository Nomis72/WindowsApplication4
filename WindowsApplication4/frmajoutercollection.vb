Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frmajoutercollection
    Dim cnn As SqlConnection
    Private Sub btnAjoutG_Click(sender As Object, e As EventArgs) Handles btnAjoutG.Click
        Dim connectionString As String

        connectionString = "Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP"

        cnn = New SqlConnection(connectionString)

        cnn.Open()

        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn


        cmd.CommandText = "INSERT INTO COLLECTION (codeCollection,libCollection,descCollection) VALUES ( " & txtACode.Text & ", '" & txtNomC.Text & "',  '" & txtDescC.Text & "')"

        cmd.ExecuteNonQuery()

        cnn.Close()
        txtACode.Text = ""
        txtDescC.Text = ""
        txtNomC.Text = ""

    End Sub

    Private Sub frmajoutercollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class