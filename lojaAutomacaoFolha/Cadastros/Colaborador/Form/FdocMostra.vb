Imports System.IO
Public Class FdocMostra
    Private strImagens() As String
    Private intContador As Integer = 0
    Sub CarregaImagens(ByVal pasta As String)
        strImagens = Directory.GetFiles(pasta, ".jpeg")
    End Sub

    Private Sub BtnImprime_Click(sender As Object, e As EventArgs) Handles BtnImprime.Click
        FcolRelDoc.Show()
    End Sub

    Private Sub FdocMostra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class