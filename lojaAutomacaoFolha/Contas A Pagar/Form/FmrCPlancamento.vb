Public Class FmrCPlancamento
    Dim oi As New MsgShow
    Private Sub BtnTermina_Click(sender As Object, e As EventArgs) Handles BtnTermina.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intIsApuracao As Integer = CheckLancamento()
        If intIsApuracao > 0 Then

            With oi

                .Msg = "(" & intIsApuracao & ")" & "Campos em Vermelho preenchido de forma incorreta!" + Chr(13) + Chr(13)
                .Msg += "Por gentileza certifique os valores digitados "
                .Style = vbCritical
                .Title = Me.Text
                MsgBox(.Msg, .Style, .Title)
            End With

        End If

    End Sub

    Private Sub Cmbcredor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcredor.SelectedIndexChanged
        Select Case Cmbcredor.Text

            Case "Pessoa Juridica PJ"
                GroupBox1.Text = "Fornecedor"
                LblCPF_CNPJ.Text = "C.N.P.J"
                MskIndentifica.Mask = "##.###.###/####-##"

            Case "Pessoa Fisica    PF"
                GroupBox1.Text = "Pessoa Fisica"
                LblCPF_CNPJ.Text = "C.P.F"
                MskIndentifica.Mask = "###.###.###-##"

        End Select
    End Sub

    Private Function CheckLancamento() As Integer

        ' A função checa a tela e devolve o número de inconsistências apuradas

        Dim InIS As Integer = 0

        Dim IsId As String = MskIndentifica.Text.Replace(".", "").Replace("/", "").Replace(",", "").Replace("-", "").Trim
        Dim IsTel As String = MskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim

        If Cmbcredor.Text = "" Then LabelTipo.ForeColor = Color.Red : InIS += 1 Else LabelTipo.ForeColor = Color.Black
        If IsId = "" Then LblCPF_CNPJ.ForeColor = Color.Red : InIS += 1 Else LblCPF_CNPJ.ForeColor = Color.Black
        If TxtNome.Text = "" Then LblIdentificacao.ForeColor = Color.Red : InIS += 1 Else LblIdentificacao.ForeColor = Color.Black
        If IsTel = "" Then LblTelefone.ForeColor = Color.Red : InIS += 1 Else LblTelefone.ForeColor = Color.Black
        If CmbFerramenta.Text = "" Then LabelCobranca.ForeColor = Color.Red : InIS += 1 Else LabelCobranca.ForeColor = Color.Black
        If MskDocNumero.Text = "" Then LabelDocNumero.ForeColor = Color.Red : InIS += 1 Else LabelDocNumero.ForeColor = Color.Black
        If TxtValor.Text = "" Then LabelValor.ForeColor = Color.Red : InIS += 1 Else LabelValor.ForeColor = Color.Black
        If DateTimePicker1.Text > DateTimePicker2.Text Then LabelDataOcorrencia.ForeColor = Color.Red : LabelDataVencimento.ForeColor = Color.Red : InIS += 1 _
            Else LabelDataOcorrencia.ForeColor = Color.Black : LabelDataVencimento.ForeColor = Color.Black

        Return (InIS)

    End Function

End Class