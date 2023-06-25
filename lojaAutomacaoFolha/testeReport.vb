Public Class testeReport
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

        'Dim lista As List(Of folCaptDiario) = capturaTeste.GetCaptura1()

        'ReportViewer1.LocalReport.DataSources.Clear()

        'ReportViewer1.LocalReport.ReportEmbeddedResource = "lojaAutomacaoFolha.rptDiario.rdlc"

        'Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource("diarioDS", lista)

        'ReportViewer1.LocalReport.DataSources.Add(ds)

        'ds.Value = lista

        'Me.ReportViewer1.RefreshReport()



    End Sub

    Private Sub testeReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        MsgBox(ListView1.SelectedItems(0).Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(Weekday("01" & "/" & CmbMes.Text & "/" & CmbAno.Text))
        MsgBox(Func_Ultimo_Dia_Mes("01" & "/" & CmbMes.Text & "/" & CmbAno.Text))

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class