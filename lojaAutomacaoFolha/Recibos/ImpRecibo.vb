Public Class ImpRecibo
    Private Sub ImpRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

        Dim lista As List(Of recibo) = captura.GetRecibo()

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.ReportEmbeddedResource = "lojaAutomacaoFolha.recibo.rdlc"

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource("recibo", lista)

        ReportViewer1.LocalReport.DataSources.Add(ds)

        ds.Value = lista

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class