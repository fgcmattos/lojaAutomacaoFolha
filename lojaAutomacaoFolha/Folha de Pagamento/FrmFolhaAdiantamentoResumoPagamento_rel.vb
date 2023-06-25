Public Class FrmFolhaAdiantamentoResumoPagamento_rel

    Private Sub FrmFolhaAdiantamentoResumoPagamento_rel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strReferencia As String = FrmFolhaAdiantamentoResumoPagamento.MskReferencia.Text

        strReferencia = strReferencia.Substring(3, 4) & strReferencia.Substring(0, 2)

        Dim emp As List(Of FolhaAdiantamento) = FolhaAdiantamentoAcao.GetFolhaAdiantamento(strReferencia)
        Dim tempo As List(Of Aponta) = ApontaAcoes.GetApontaDB()
        Dim strData As String = dataLatina(tempo(0).Data) & " " & tempo(0).Tempo
        'Dim empresa As List(Of ClassFolha_holerite_emp) = ClassFolha_holerite_emp_acao.GetholempDB()

        CR_folhaAdiantamentoDeposito.Database.Tables(0).SetDataSource(emp)
        CR_folhaAdiantamentoDeposito.SetParameterValue("extenso", FrmFolhaAdiantamentoResumoPagamento.Lblextenso.Text)
        CR_folhaAdiantamentoDeposito.SetParameterValue("dataImpressao", strData)
        '''FolhaAdiantamentoHolerite.SetParameterValue("mensagem01", FrmFolhaAdiantamentoSalarialHolerite.TxtMens1.Text)
        '''FolhaAdiantamentoHolerite.SetParameterValue("mensagem02", FrmFolhaAdiantamentoSalarialHolerite.TxtMens2.Text)
        '''FolhaAdiantamentoHolerite.SetParameterValue("mensagem03", FrmFolhaAdiantamentoSalarialHolerite.TxtMens3.Text)

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class