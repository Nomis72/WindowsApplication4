Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class modifierGamme


    Dim cnn As SqlConnection

    Private Sub modifierGamme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String

        connectionString = " Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo; User ID=SIO1;Password=SIO1MDP"
        cnn = New SqlConnection(connectionString)
        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn


        Dim JeuEnr As SqlDataReader

        connectionString = " Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo; User ID=SIO1;Password=SIO1MDP"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select libGamme from GAMME"
        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            ComboBox1.Items.Add(JeuEnr.GetValue(0))
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

________________________
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class modifierGamme

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = " update GAMME set RaisonSociale = '" & TextBox1.Text & "',AdresseRue = '" & TextBox6.Text & "',CodePostal = '" & TextBox2.Text & "', Ville = '" & TextBox3.Text & "',TelStandard = '" & TextBox4.Text & "',Mail = '" & TextBox5.Text & "',CodePays = '" & ComboBox2.SelectedItem & "' where idEntreprise = " & TextBox7.Text & ""
        cmd.ExecuteNonQuery()
        Form3.Visible = True
        Me.Close()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1; Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select * FROM ENTREPRISE WHERE RaisonSociale = '" & Form6.ComboBox1.SelectedItem & "'"
        JeuEnr = cmd.ExecuteReader()
        JeuEnr.Read()
        TextBox1.Text = JeuEnr.GetValue(1)
        TextBox2.Text = JeuEnr.GetValue(3)
        TextBox3.Text = JeuEnr.GetValue(4)
        TextBox4.Text = JeuEnr.GetValue(5)
        TextBox5.Text = JeuEnr.GetValue(6)
        TextBox6.Text = JeuEnr.GetValue(2)
        TextBox7.Text = JeuEnr.GetValue(0)
        Dim idpays As String
        idpays = JeuEnr.GetValue(7)
        Dim pospays As Integer
        Dim i As Integer
        i = 0
        JeuEnr.Close()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select CodePays,Libpays from PAYS order by Libpays"
        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()

            ComboBox1.Items.Add(JeuEnr.GetValue(1))
            ComboBox2.Items.Add(JeuEnr.GetValue(0))
            If (JeuEnr.GetValue(0) = idpays) Then
                pospays = i
            End If
            i = i + 1
        End While
        JeuEnr.Close()



        'cmd = New SqlCommand
        'cmd.Connection = cnn
        'cmd.CommandText = "Select LibPays from PAYS where CodePays='" & idpays & "'"
        'JeuEnr = cmd.ExecuteReader
        'JeuEnr.Read()
        'Dim libpays As String
        'libpays = JeuEnr.GetValue(0)
        'JeuEnr.Close()
        '
        'cnn.Close()
        ' ComboBox2.SelectedIndex=pospays
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SelIndRS As Integer
        SelIndRS = ComboBox1.SelectedIndex
        ComboBox2.SelectedIndex = SelIndRS
    End Sub

End Class