Imports MySql.Data.MySqlClient
Public Class ClassFolhaVariaveisAcao

    Public Shared Function GetVariavelTELA() As List(Of ClassFolhaVariaveis)

        Dim lista As New List(Of ClassFolhaVariaveis)

        Try

            For i = 0 To frmFolhaLancVar.LvwEdicao.Items.Count - 1

                lista.Add(New ClassFolhaVariaveis() With
        {
        .Ordem = frmFolhaLancVar.LvwEdicao.Items(i).Text,
        .Codigo = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(1).Text,
        .Descricao = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(2).Text,
        .QTO = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(3).Text,
        .UN = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(4).Text,
        .Valor = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(5).Text,
        .TipoFinanceiro = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(6).Text,
        .BaseINSS = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(7).Text,
        .BaseFGTS = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(8).Text,
        .BaseIR = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(9).Text,
        .OcorrenciaData = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(10).Text,
        .Historico = frmFolhaLancVar.LvwEdicao.Items(i).SubItems(11).Text
        }
        )

            Next
        Catch ex As Exception

            MsgBox("Problemas Origem não confirmada!")

        End Try

        Return lista

    End Function

End Class
