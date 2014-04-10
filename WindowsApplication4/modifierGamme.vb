Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class modifierGamme


    Dim cnn As SqlConnection

    Private Sub modifierGamme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim cnn As SqlConnection


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo; User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn


        Dim JeuEnr As SqlDataReader


        cmd.CommandText = "Select * from GAMME where libgamme = '" & modifGamme.ComboBox1.SelectedItem & "'"
        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()

        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn


        cmd.CommandText = "UPDATE GAMME SET libGamme= '" & txtModifG.Text & "',  descGamme= '" & richTxtDescG.Text & "', libCollection = '" & cboCollG.Text & " ' "


        cmd.ExecuteNonQuery()

        cnn.Close()

    End Sub


End Class

