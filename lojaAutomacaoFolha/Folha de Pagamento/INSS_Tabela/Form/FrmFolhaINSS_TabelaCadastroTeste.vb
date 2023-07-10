Imports Microsoft.Reporting

Public Class FrmFolhaINSS_TabelaCadastroTeste


    Private Sub MskReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskReferencia.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            Dim isValidFormat As Boolean = CheckDateFormat(MskReferencia.Text, "yyyy/MM")

            If isValidFormat Then



                Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_Ref_DB(MskReferencia.Text)

                ListView1.Items.Clear()

                For i As Integer = 1 To INSStabela(0).Class_INSSnumeroDeFaixas

                    ListView1.Items.Add(i)

                    Select Case i

                        Case 1
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1, 2), 8, True))
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Porcentagem, 2), 8, True))
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True))
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Acumulado, 2), 8, True))

                        Case 2
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2, 2), 8, True))
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Porcentagem, 2), 8, True))
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True))
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True))

                        Case 3
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3, 2), 8, True))
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Porcentagem, 2), 8, True))
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True))
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True))

                        Case 4
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4, 2), 8, True))
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Porcentagem, 2), 8, True))
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True))
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Acumulado, 2), 8, True))

                    End Select



                Next


            Else

                MsgBox("Referencia inValida")

            End If

        End If

    End Sub

    Function CheckDateFormat(input As String, format As String) As Boolean

        Dim parsedDate As Date
        Return Date.TryParseExact(input, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, parsedDate)

    End Function


    Private Sub FrmFolhaINSS_TabelaCadastroTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Query As String

        Query = "Select count(*) from inss where INSStabelaStatus=0"

        If ApontaSQL(Query) = 0 Then

            MsgBox("Não existe tabela digitada para a conferência")

            Me.Close()

        End If


        'INSS_mostra_tabela(gravaSQLretorno("Select concat(substring(INSSREF,1,4) ,'/',substring(INSSREF,5)) from `00000000000000`.inss where INSStabelaStatus=0"))

        INSS_mostra_tabela(gravaSQLretorno("Select INSSREF from `00000000000000`.inss where INSStabelaStatus=0"))



    End Sub

    Private Function INSS_mostra_tabela(StrReferencia As String)

        Dim IsComparacao As String = "INSSREF = '" & StrReferencia & "'"

        Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_DB(IsComparacao)

        ListView1.Items.Clear()

        LblDataCriacao.Text = INSStabela(0).Class_INSSdataCriacao
        LblCriadoPor.Text = INSStabela(0).Class_INSSresponsavelDigitacao
        LblReferencia.Text = INSStabela(0).Class_INSSREF.Substring(0, 4) & "/" & INSStabela(0).Class_INSSREF.Substring(4)

        For i As Integer = 1 To INSStabela(0).Class_INSSnumeroDeFaixas

            ListView1.Items.Add(i)

            Select Case i

                Case 1
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Porcentagem, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Acumulado, 2), 8, True))

                Case 2
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Porcentagem, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True))

                Case 3
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Porcentagem, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True))

                Case 4
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Porcentagem, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Acumulado, 2), 8, True))

            End Select

        Next

        'Gerando 5 bases aleatórias
        Dim IsMatBaseInss(5, 5) As Decimal
        'Dim numeroAleatorio As Integer = Int((max - min + 1) * Rnd()) + min

        IsMatBaseInss(1, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa1 - 750 + 1) * Rnd() + 750, 2)
        IsMatBaseInss(2, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa2 - INSStabela(0).Class_INSSfaixa1 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa1, 2)
        IsMatBaseInss(3, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa3 - INSStabela(0).Class_INSSfaixa2 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa2, 2)
        IsMatBaseInss(4, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa4 - INSStabela(0).Class_INSSfaixa3 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa3, 2)
        IsMatBaseInss(5, 0) = Math.Round(Int(40000 - INSStabela(0).Class_INSSfaixa4 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa4, 2)


        IsMatBaseInss(1, 5) = INSScalculo(IsMatBaseInss(1, 0), IsComparacao)
        IsMatBaseInss(2, 5) = INSScalculo(IsMatBaseInss(2, 0), IsComparacao)
        IsMatBaseInss(3, 5) = INSScalculo(IsMatBaseInss(3, 0), IsComparacao)
        IsMatBaseInss(4, 5) = INSScalculo(IsMatBaseInss(4, 0), IsComparacao)
        IsMatBaseInss(5, 5) = INSScalculo(IsMatBaseInss(5, 0), IsComparacao)


        LblBase1.Text = numeroLatino(IsMatBaseInss(1, 0), 10, True)
        LblBase2.Text = numeroLatino(IsMatBaseInss(2, 0), 10, True)
        LblBase3.Text = numeroLatino(IsMatBaseInss(3, 0), 10, True)
        LblBase4.Text = numeroLatino(IsMatBaseInss(4, 0), 10, True)
        LblBase5.Text = numeroLatino(IsMatBaseInss(5, 0), 10, True)


        LblTotal_b1.Text = numeroLatino(IsMatBaseInss(1, 5), 8, True)
        LblTotal_b2.Text = numeroLatino(IsMatBaseInss(2, 5), 8, True)
        LblTotal_b3.Text = numeroLatino(IsMatBaseInss(3, 5), 8, True)
        LblTotal_b4.Text = numeroLatino(IsMatBaseInss(4, 5), 8, True)
        LblTotal_b5.Text = numeroLatino(IsMatBaseInss(5, 5), 8, True)



        If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa1 Then

            LblFaixa1_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)

            If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa2 Then

                LblFaixa2_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)

                If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa3 Then

                    LblFaixa3_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)

                    If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa4 Then

                        LblFaixa4_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)
                    Else

                        LblFaixa4_b1.Text = numeroLatino(0, 8, True)

                    End If

                Else
                    LblFaixa3_b1.Text = numeroLatino(0, 8, True)
                    LblFaixa4_b1.Text = numeroLatino(0, 8, True)

                End If

            Else
                LblFaixa2_b1.Text = numeroLatino(0, 8, True)
                LblFaixa3_b1.Text = numeroLatino(0, 8, True)
                LblFaixa4_b1.Text = numeroLatino(0, 8, True)

            End If

        Else
            LblFaixa1_b1.Text = numeroLatino(0, 8, True)
            LblFaixa2_b1.Text = numeroLatino(0, 8, True)
            LblFaixa3_b1.Text = numeroLatino(0, 8, True)
            LblFaixa4_b1.Text = numeroLatino(0, 8, True)

        End If

        If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        LblFaixa2_b2.Text = numeroLatino(Math.Round(IsMatBaseInss(2, 5) - INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        LblFaixa3_b2.Text = numeroLatino(0, 8, True)
        LblFaixa4_b2.Text = numeroLatino(0, 8, True)

        If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        LblFaixa3_b3.Text = numeroLatino(Math.Round(IsMatBaseInss(3, 5) - INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True)
        LblFaixa4_b3.Text = numeroLatino(0, 8, True)

        If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        LblFaixa4_b4.Text = numeroLatino(Math.Round(IsMatBaseInss(4, 5) - INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True)

        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)


    End Function
End Class