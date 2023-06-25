Public Class FrmPesquisa
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        frmCartaoManutencao.Lid.Text = ListView1.SelectedItems(0).Text
        frmCartaoManutencao.CmbBandeira.Text = ListView1.SelectedItems(0).SubItems(1).Text
        frmCartaoManutencao.MskNumero.Text = ListView1.SelectedItems(0).SubItems(2).Text
        frmCartaoManutencao.MskValidade.Text = ListView1.SelectedItems(0).SubItems(3).Text
        frmCartaoManutencao.MskSeguranca.Text = ListView1.SelectedItems(0).SubItems(4).Text
        frmCartaoManutencao.MskFatura.Text = ListView1.SelectedItems(0).SubItems(5).Text
        Me.Close()

    End Sub


End Class