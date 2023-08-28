Public Class FrmFolhaHoleriteClose_Final_rel
    Private Sub CrystalReportViewer_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub FrmFolhaHoleriteClose_Final_rel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strReferencia As String = FrmFolhaEfetivacao.CmbReferencia.Text

        Dim strRef As String = achaMes(strReferencia.Substring(0, InStr(strReferencia, "/") - 1))
        strRef = strReferencia.Substring(InStr(strReferencia, "/")) + strRef

        'Dim hol_cab As List(Of ClassFolha_holerite_close_cab) = ClassFolha_holerite_close_cabAcao.GetHoleriteCabDB(strRef)
        'Dim hol_corp As List(Of ClassFolha_holerite_close_corp) = ClassFolha_holerite_close_corpAcao.GetHoleriteCorpDB(strRef)
        Dim hf As List(Of ClassHolerite_completo) = ClassHolerite_completoAcao.GetHoleriteCompleto(strRef)


        FolhaHoleriteClose_final.Database.Tables(0).SetDataSource(hf)

    End Sub
End Class