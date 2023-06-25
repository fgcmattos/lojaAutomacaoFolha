Imports Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel
Imports MySql.Data.MySqlClient
Public Class FreciboHistPadraoInclusao
    Public strResultado As String
    Public Hrp As List(Of ReciboHist) = ReciboRP.GetReciboHist()                ' Históricos de Recibos Prontos
    Public Dv As List(Of ReciboVariaveis) = ReciboRP.GetReciboVariaveis()       ' Dicionário de Variaveis

    Private Sub FreciboHistPadraoInclusao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To Dv.Count() - 1

            LvParametros.Items.Add(Dv(i).Codigo)
            LvParametros.Items(i).SubItems.Add(Dv(i).Descricao)
            LvParametros.Items(i).Group = LvParametros.Groups(Dv(i).GrupoListView)

        Next

    End Sub

    Private Sub RtHistorico_TextChanged(sender As Object, e As EventArgs) Handles RtHistorico.TextChanged

    End Sub

    Private Sub BtnGravaHistorico_Click(sender As Object, e As EventArgs) Handles BtnGravaHistorico.Click


        If ReciboHistoricoCheck(Trim(RtHistorico.Text), 3) Then

            Dim msg As String
            Dim style As String
            Dim title As String
            Dim ctxt As String
            Dim help As String
            Dim resposta As String
            '---------------------
            msg = strResultado & Chr(13) & Chr(13) & "Confirma Gravação  "
            style = vbYesNo + vbQuestion + vbDefaultButton1
            title = "Cadastro de Históricos de Recibo"
            'help = "folha.hlp"
            'ctxt = 1000

            resposta = MsgBox(msg, style, title)

            If resposta <> 6 Then

                Exit Sub

                RtHistorico.Focus()

            End If

            If OpenDB() Then
                Dim query As String
                query = "CALL RECIBOHISCAD ('" + TxNome.Text + "','" + RtHistorico.Text + "','" + TxFuncao.Text + "',1,'" + TextReferencia.Text + "')"
                Dim DTReader As MySqlDataReader
                Dim CMD As New MySqlCommand(query, Conn)
                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()
                Catch ex As Exception
                    MsgBox("Problemas Na Gravação!")
                    Exit Sub
                End Try
                Conn.Close()
            End If

            MsgBox("Gravação realizada com sucesso!", , "Cadastro de Históricos de Recibo")


        Else

            MsgBox("Erro Na criação de Variaveis !", vbCritical, strResultado)

        End If
    End Sub

End Class