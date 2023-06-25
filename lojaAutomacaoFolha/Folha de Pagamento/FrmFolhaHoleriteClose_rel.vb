Public Class FrmFolhaHoleriteClose_rel

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
    Private Sub FrmFolhaHoleriteClose_rel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strReferencia As String = FrmFolhaEfetivacao.CmbReferencia.Text

        Dim strRef As String = achaMes(strReferencia.Substring(0, InStr(strReferencia, "/") - 1))
        strRef = strReferencia.Substring(InStr(strReferencia, "/")) + strRef

        Dim hol_cab As List(Of ClassFolha_holerite_close_cab) = ClassFolha_holerite_close_cabAcao.GetHoleriteCabDB(strRef)
        Dim hol_corp As List(Of ClassFolha_holerite_close_corp) = ClassFolha_holerite_close_corpAcao.GetHoleriteCorpDB(strRef)


        FolhaHoleriteClose.Database.Tables(0).SetDataSource(hol_cab)
        FolhaHoleriteClose.Database.Tables(1).SetDataSource(hol_corp)

    End Sub


End Class