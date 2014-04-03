Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class ajoutGamme
    Dim cnn As SqlConnection

    Private Sub ajoutGamme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection(" Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo; User ID=SIO1; Password=SIO1MDP")

        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libCollection FROM COLLECTION"
        JeuEnr = cmd.ExecuteReader
        While JeuEnr.Read()
            cboCollection.Items.Add(JeuEnr.GetValue(0))

        End While
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim cnn As SqlConnection

        cnn = New SqlConnection(" Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo; User ID=SIO1; Password=SIO1MDP")

        cnn.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn


        Dim JeuEnr As SqlDataReader
        cmd.CommandText = "SELECT idCollection FROM COLLECTION where libCollection = '" & cboCollection.SelectedItem & "'"
        JeuEnr = cmd.ExecuteReader
        JeuEnr.Read()
        Dim libid As Integer
        libid = JeuEnr.GetValue(0)
        JeuEnr.Close()

        cmd = New SqlCommand
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO GAMME (idCollection, libGamme,descGamme) VALUES (" & libid & ",'" & txtNomG.Text & "','" & txtDescG.Text & "')"


        cmd.ExecuteNonQuery()

        cnn.Close()
        Me.Close()

    End Sub




End Class

