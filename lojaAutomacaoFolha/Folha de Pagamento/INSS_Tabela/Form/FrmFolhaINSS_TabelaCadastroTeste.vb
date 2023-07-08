Public Class FrmFolhaINSS_TabelaCadastroTeste
    Private Sub MskReferencia_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskReferencia.MaskInputRejected

    End Sub

    Private Sub MskReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskReferencia.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            Dim isValidFormat As Boolean = CheckDateFormat(MskReferencia.Text, "yyyy/MM")

            If isValidFormat Then



                Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_Ref_DB(MskReferencia.Text)

                ListView1.Items.Clear()

                ListView1.Items.Add("1")
                ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1), 8, True))
                ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Porcentagem), 8, True))
                ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor), 8, True))
                ListView1.Items.Add("2")
                ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2), 8, True))
                ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Porcentagem), 8, True))
                ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor), 8, True))
                ListView1.Items.Add("3")
                ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3, 2), 8, True))
                ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Porcentagem, 2), 8, True))
                ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True))

            Else

                MsgBox("Referencia inValida")

            End If

        End If

    End Sub

    Function CheckDateFormat(input As String, format As String) As Boolean

        Dim parsedDate As Date
        Return Date.TryParseExact(input, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, parsedDate)

    End Function

End Class