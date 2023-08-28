Public Class FrmFolhaAdiantamentoSalarialHolerite

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click


        Dim strReferencia As String = MskReferencia.Text

        strReferencia = strReferencia.Substring(3, 4) & strReferencia.Substring(0, 2)

        'Dim emp As List(Of FolhaAdiantamento) = FolhaAdiantamentoAcao.GetFolhaAdiantamento(strReferencia)

        BtnImprime.Visible = True

    End Sub

    Private Sub BtnImprime_Click(sender As Object, e As EventArgs) Handles BtnImprime.Click

        FrmFolhaAdiantamentoHolerite_REL.Show()

    End Sub

    Private Sub FrmFolhaAdiantamentoSalarialHolerite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class