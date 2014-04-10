Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frmmodifcollection

    Private Sub frmmodifcollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cboModifC.Items.Add(JeuEnr.GetValue(0))
        End While
        Me.Close()
    End Sub


    Private Sub cboModifC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModifC.SelectedIndexChanged
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select codeCollection, descCollection FROM COLLECTION WHERE libCollection='" & cboModifC.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()
        txtMcode.Text = JeuEnr.GetValue(0)
        txtMdesc.Text = JeuEnr.GetValue(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "UPDATE COLLECTION SET libCollection='" & cboModifC.Text & "', codeCollection='" & txtMcode.Text & "', descCollection='" & txtMdesc.Text & "' "

        cmd.ExecuteNonQuery()

        cnn.Close()
    End Sub
End Class