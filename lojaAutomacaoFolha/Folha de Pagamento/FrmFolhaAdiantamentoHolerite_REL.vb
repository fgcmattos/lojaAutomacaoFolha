Public Class FrmFolhaAdiantamentoHolerite_REL
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub FrmAdiantamentoHolerite_Rel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strReferencia As String = FrmFolhaAdiantamentoSalarialHolerite.MskReferencia.Text

        strReferencia = strReferencia.Substring(3, 4) & strReferencia.Substring(0, 2)

        Dim emp As List(Of FolhaAdiantamento) = FolhaAdiantamentoAcao.GetFolhaAdiantamento(strReferencia)

        'Dim empresa As List(Of ClassFolha_holerite_emp) = ClassFolha_holerite_emp_acao.GetholempDB()

        FolhaAdiantamentoHolerite.Database.Tables(0).SetDataSource(emp)

        FolhaAdiantamentoHolerite.SetParameterValue("mensagem01", FrmFolhaAdiantamentoSalarialHolerite.TxtMens1.Text)
        FolhaAdiantamentoHolerite.SetParameterValue("mensagem02", FrmFolhaAdiantamentoSalarialHolerite.TxtMens2.Text)
        FolhaAdiantamentoHolerite.SetParameterValue("mensagem03", FrmFolhaAdiantamentoSalarialHolerite.TxtMens3.Text)
        'MsgBox(FolhaAdiantamentoHolerite.Database.Tables(0).Name)

        '''For i = 0 To emp.Count - 1

        '''    ' identificacao do empregador
        '''emp(i).ColReferencia = FrmFolhaAdiantamentoSalarialHolerite.MskReferencia.Text
        '''    FolhaAdiantamentoHolerite.SetParameterValue("empNome", emp(i).emprRazaoSocial)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("empCNPJ", emp(i).EmprCNPJ)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("empEndereco", emp(i).EmprEndereco)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("colCodigo", emp(i).ColChave)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("colNome", emp(i).ColNome)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("colCargo", emp(i).ColFuncao)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("colSetor", emp(i).ColSetor)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("colLocal", emp(i).emprRazaoSocial)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("processo", emp(i).Processo)
        '''    FolhaAdiantamentoHolerite.SetParameterValue("folReferencia", emp(i).ColReferencia)

        '''Next
        '''    ' fim da identificacao do emprengador
    End Sub

    Private Sub FolhaAdiantamentoHolerite_InitReport(sender As Object, e As EventArgs) Handles FolhaAdiantamentoHolerite.InitReport

    End Sub
End Class