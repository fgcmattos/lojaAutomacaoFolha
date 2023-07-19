Public Class FrmFolhaINSS_TabelaPesquisa
    Private Sub FrmFolhaINSS_TabelaPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function LimpaLabel()

        LblDataAtivacao.Text = ""
        LblDataDesativacao.Text = ""
        LblTabelaAnterior.Text = ""
        LblTabelaPosterior.Text = ""
        LblDigitacaoData.Text = ""
        LblDigitacaoOperadorChave.Text = ""
        LblDigitacaoOperadorTipo.Text = ""
        LblConferenciaData.Text = ""
        LblConferenciaAnalistaChave.Text = ""
        LblConferenciaAnalistaTipo.Text = ""
        LblLiberacaoData.Text = ""
        LblLiberacaoResponsavelChave.Text = ""
        LblLiberacaoResponsavelTipo.Text = ""

    End Function

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        Dim InRef As String = Replace(Replace(MskReferencia.Text, ",", ""), " ", "")
        Dim INNUm As String = Replace(MskReferencia.Text, " ", "")
        Dim Query As String
        Query = "Select count(*) from inss where INSStabelaStatus = 3"
        If InRef <> "" Then Query += " and INSStabelaNumero = '" & InRef & "'"
        If INNUm <> "" Then Query += " and INSStabelaNumero = '" & INNUm & "'"
        If gravaSQLretorno(Query) = 0 Then
            MsgBox("Caracteristicas não encontradas na BASE !")
            Exit Sub
        End If
    End Sub
End Class