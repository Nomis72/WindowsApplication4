Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select RaisonSociale from ENTREPRISE"
        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            ComboBox1.Items.Add(JeuEnr.GetValue(0))
        End While
        JeuEnr.Close()
        cnn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()

        Dim cmd3 As SqlCommand
        cmd3 = New SqlCommand()
        cmd3.Connection = cnn
        cmd3.CommandText = "Select IdEntreprise from ENTREPRISE where RaisonSociale ='" & ComboBox1.Text & "'"

        Dim JeuEnr As SqlDataReader
        JeuEnr = cmd3.ExecuteReader()
        JeuEnr.Read()
        Dim ident As Integer
        ident = JeuEnr.GetValue(0)

        JeuEnr.Close()

        Dim cmd2 As SqlCommand
        cmd2 = New SqlCommand()
        cmd2.Connection = cnn
        cmd2.CommandText = "DELETE FROM CONTACT WHERE IdEntreprise = " & ident & ""


        cmd2.ExecuteNonQuery()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "DELETE FROM ENTREPRISE WHERE RaisonSociale ='" & ComboBox1.Text & "'"
        cmd.ExecuteNonQuery()


        ComboBox1.Items.Clear()




        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select RaisonSociale from ENTREPRISE"
        Dim JeuEnr2 As SqlDataReader
        JeuEnr2 = cmd.ExecuteReader()

        While JeuEnr2.Read()
            ComboBox1.Items.Add(JeuEnr2.GetValue(0))
        End While

        JeuEnr2.Close()
        cnn.Close()
        ComboBox1.SelectedIndex = 0
    End Sub
End Class