Imports System.Data.SqlClient
Imports Microsoft.VisualBasic


Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim azer As String
        azer = Mid(TextBox1.Text, 1, 3)
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Insert Into PAYS(CodePays,Libpays) Values('" & azer & "' , '" & TextBox1.Text & "') "
        cmd.ExecuteNonQuery()

        Form2.ComboBox1.Items.Clear()

        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select Libpays from PAYS"
        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            Form2.ComboBox1.Items.Add(JeuEnr.GetValue(0))
        End While
        JeuEnr.Close()

        cnn.Close()


        Me.Close()

    End Sub

End Class

