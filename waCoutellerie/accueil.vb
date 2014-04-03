Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class accueil

    Private Sub accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        supprGamme.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        ajoutGamme.Show()

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        modifierGamme.Show()

    End Sub
End Class