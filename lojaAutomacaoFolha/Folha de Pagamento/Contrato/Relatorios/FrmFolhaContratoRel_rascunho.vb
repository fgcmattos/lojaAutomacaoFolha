Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmFolhaContratoRel_rascunho
    Private Sub FrmFolhaContratoRel_rascunho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As New ReportDocument()
        'report.Load("CaminhoParaSeuRelatorio.rpt") ' Substitua pelo caminho do seu relatório
        'CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class