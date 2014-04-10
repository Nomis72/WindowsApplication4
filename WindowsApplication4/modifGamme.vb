Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class modifGamme

    Private Sub modifGamme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo; User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn


        Dim JeuEnr As SqlDataReader


        cmd.CommandText = "Select libGamme from GAMME"
        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            ComboBox1.Items.Add(JeuEnr.GetValue(0))
        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        modifierGamme.Show()
    End Sub
End Class