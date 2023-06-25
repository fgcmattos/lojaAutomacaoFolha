Public Class FormRel
    Private Sub FormRel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

        If Val(txtRel.Text) = 0 Then
            '' Relatorio para coleta de informacoes do colaborador
            ReportViewer1.LocalReport.ReportEmbeddedResource = "lojaAutomacaoFolha.repColFichaColeta.rdlc"
        End If
        If Val(txtRel.Text) = 1 Then
            '' Relatorio para Declaracao de Raca e Cor
            ReportViewer1.LocalReport.ReportEmbeddedResource = "lojaAutomacaoFolha.rptRacaCor.rdlc"
        End If
        If Val(txtRel.Text) = 2 Then
            '' Relatorio com lançamento diario do funcionário

            ReportViewer1.LocalReport.ReportEmbeddedResource = "lojaAutomacaoFolha.rptDiario.rdlc"

        End If

    End Sub
End Class