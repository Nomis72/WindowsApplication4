Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frmsuprcollection

    Private Sub frmsuprcollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select libCollection from COLLECTION"

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            cboSuprC.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub btnSuprC_Click(sender As Object, e As EventArgs) Handles btnSuprC.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn


        cmd.CommandText = "DELETE FROM COLLECTION WHERE libCollection= '" & cboSuprC.Text & "'"


        cmd.ExecuteNonQuery()

        cnn.Close()

    End Sub
End Class