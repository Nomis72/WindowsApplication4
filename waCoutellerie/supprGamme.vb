Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class supprGamme

    Dim cnn As SqlConnection

    Private Sub supprGamme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String
        Dim JeuEnr As SqlDataReader

        connectionString = " Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo; User ID=SIO1;Password=SIO1MDP"
        cnn = New SqlConnection(connectionString)
        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select libGamme from GAMME"
        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            ComboBox1.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
        cnn.Close()
    End Sub

    Private Sub btnSuprC_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn


        cmd.CommandText = "DELETE FROM GAMME WHERE libGamme= '" & ComboBox1.SelectedItem & "'"


        cmd.ExecuteNonQuery()

        cnn.Close()


    End Sub
End Class