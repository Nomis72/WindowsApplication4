Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frmajouterproduit
    Dim cnn As SqlConnection
    Private Sub btnAjoutG_Click(sender As Object, e As EventArgs) Handles btnAjoutG.Click
        Dim connectionString As String

        connectionString = "Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP"

        cnn = New SqlConnection(connectionString)

        cnn.Open()

        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn


        cmd.CommandText = "INSERT INTO PRODUIT (idProduit,libProduit,numeroProduit,descProduit,PUProduit,image,idGamme) VALUES ( " & txtACode.Text & ", '" & txtNomC.Text & "',  '" & txtDescC.Text & "')"

        cmd.ExecuteNonQuery()

        cnn.Close()
        txtACode.Text = ""
        txtDescC.Text = ""
        txtNomC.Text = ""
    End Sub

    Private Sub frmajouterproduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cboColProd.Items.Add(JeuEnr.GetValue(0))

        End While
        JeuEnr.Close()

        Dim cmn As SqlCommand
        Dim JeEnr As SqlDataReader
        cmn = New SqlCommand()
        cmn.Connection = cnn
        cmn.CommandText = "SELECT libGamme FROM GAMME"
        JeEnr = cmn.ExecuteReader
        While JeEnr.Read()
            cboGamProd.Items.Add(JeEnr.GetValue(0))

        End While

    End Sub
End Class