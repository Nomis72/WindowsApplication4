Imports System.Data.SqlClient
Imports Microsoft.VisualBasic


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select IdEntreprise, RaisonSociale from ENTREPRISE"
        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            ComboBox2.Items.Add(JeuEnr.GetValue(1))
            ComboBox3.Items.Add(JeuEnr.GetValue(0))
        End While
        JeuEnr.Close()
        cnn.Close()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim SelIndRS As Integer
        SelIndRS = ComboBox2.SelectedIndex
        ComboBox3.SelectedIndex = SelIndRS
        Dim SelId As Integer
        SelId = CInt(ComboBox3.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Insert Into CONTACT(Titre,NomContact,PrenomContact,MailContact,TelInterneContact,TelPortable,IdEntreprise) Values('" & ComboBox1.SelectedItem & "','" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "'," & TextBox4.Text & "," & TextBox5.Text & "," & CInt(ComboBox3.SelectedItem) & ") "
        cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Nouveau contact ajouté avec succes")

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim SelIndRS As Integer
        SelIndRS = ComboBox2.SelectedIndex
        ComboBox3.SelectedIndex = SelIndRS
    End Sub
End Class
