Public Class FcolRelDoc
    Private Sub FcolRelDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.EnableExternalImages = True
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.ReportEmbeddedResource = "lojaAutomacaoFolha.RelColDoc.rdlc"
        ReportViewer1.LocalReport.EnableExternalImages = True
        MsgBox(FdocMostra.LblArquivo.Text)
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("ArquivoScaner", FdocMostra.LblArquivo.Text))
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class