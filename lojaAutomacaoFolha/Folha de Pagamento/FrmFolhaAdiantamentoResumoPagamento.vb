
Public Class FrmFolhaAdiantamentoResumoPagamento
    Dim oi As New MsgShow
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        Dim strRef As String = MskReferencia.Text

        If Not Referenciacheck(strRef) Then

            With oi
                .msg = "Referência inválida!"
                .msg += Chr(13)
                .msg = "Por favor entre com uma referência válida."
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
                MskReferencia.Focus()
                Exit Sub
            End With

        End If
        Dim strRefPronta As String = Replace(strRef, "/", "")
        strRefPronta = strRefPronta.Substring(2) & strRefPronta.Substring(0, 2)
        Dim emp As List(Of FolhaAdiantamento) = FolhaAdiantamentoAcao.GetFolhaAdiantamento(strRefPronta)
        ListView1.Items.Clear()

        For i = 0 To emp.Count - 1

            With ListView1
                .Items.Add(emp(i).ColChave)
                .Items(.Items.Count - 1).SubItems.Add(emp(i).ColNome)
                .Items(.Items.Count - 1).SubItems.Add(emp(i).ColBanco)
                .Items(.Items.Count - 1).SubItems.Add(emp(i).ColBancoAgencia)
                .Items(.Items.Count - 1).SubItems.Add(emp(i).ColBancoAgenciaContaCorrente)
                .Items(.Items.Count - 1).SubItems.Add(emp(i).ColBancoAgenciaContaCorrenteDigito)
                .Items(.Items.Count - 1).SubItems.Add(emp(i).ColPIX)
                .Items(.Items.Count - 1).SubItems.Add(emp(i).ColPixID)
                .Items(.Items.Count - 1).SubItems.Add(MoneyLatino(emp(i).FL_liquido))
            End With

        Next

        LblSomaParaDeposito.Text = listviewSoma()
        Lblextenso.Text = "(" & Trim(Extenso(LblSomaParaDeposito.Text)) & ")"

    End Sub

    Private Sub FrmFolhaAdiantamentoResumoPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.title = Me.Text
    End Sub

    Private Function listviewSoma() As String

        Dim decSoma As Decimal = 0

        With ListView1

            For i = 0 To .Items.Count() - 1

                decSoma += Convert.ToDecimal(.Items(i).SubItems(8).Text)

            Next


        End With

        Return MoneyLatino(decSoma)

    End Function

    Private Sub BtnImprime_Click(sender As Object, e As EventArgs) Handles BtnImprime.Click

        FrmFolhaAdiantamentoResumoPagamento_rel.show()

    End Sub
End Class