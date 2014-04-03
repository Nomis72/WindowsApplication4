Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select CodePays,Libpays from PAYS"
        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            ComboBox1.Items.Add(JeuEnr.GetValue(1))
            ComboBox2.Items.Add(JeuEnr.GetValue(0))
        End While
        JeuEnr.Close()
        cnn.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SelIndRS As Integer
        SelIndRS = ComboBox1.SelectedIndex
        ComboBox2.SelectedIndex = SelIndRS
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Insert Into ENTREPRISE(RaisonSociale,AdresseRue,CodePostal,Ville,TelStandard,Mail,CodePays) Values('" & TextBox1.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox2.SelectedItem & "') "
        cmd.ExecuteNonQuery()

        MsgBox("nouvelle entreprise enregistrée avec succes")

        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select IdEntreprise, RaisonSociale from ENTREPRISE"
        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            Form1.ComboBox2.Items.Add(JeuEnr.GetValue(1))
            Form1.ComboBox3.Items.Add(JeuEnr.GetValue(0))
        End While
        JeuEnr.Close()
        cnn.Close()

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class