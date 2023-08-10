Public Class FrmFolhaIR_TabelaCadastroTeste
    Dim oi As New MsgShow
    Private Sub FrmFolhaIR_TabelaCadastroTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Oi.Title = Me.Text

        Dim Query As String

        Query = "Select count(*) from folha_tabela_imposto_renda_pf where IRtabelaStatus=0"

        If ApontaSQL(Query) = 0 Then

            MsgBox("Não existe tabela digitada para a conferência")

            Me.Close()

            Exit Sub

        End If


        IR_mostra_tabela(gravaSQLretorno("Select IRREF from folha_tabela_imposto_renda_pf where IRtabelaStatus=0"))

    End Sub

    Private Function IR_mostra_tabela(StrReferencia As String)

        Dim IsComparacao As String = "IRREF = '" & StrReferencia & "'"

        Dim IRtabela As List(Of ClassIRtabela) = ClassIRtabelaAcao.GetIR_DB(IsComparacao)

        ListView1.Items.Clear()

        LblDataCriacao.Text = IRtabela(0).Class_IRdataCriacao
        LblCriadoPor.Text = IRtabela(0).Class_IRresponsavelDigitacao
        LblReferencia.Text = IRtabela(0).Class_IRref.Substring(0, 4) & "/" & IRtabela(0).Class_IRref.Substring(4)

        For i As Integer = 1 To IRtabela(0).Class_IRnumeroDeFaixas

            ListView1.Items.Add(i)

            Select Case i

                Case 1
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Porcentagem, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Acumulado, 2), 8, True))

                Case 2
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Porcentagem, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Acumulado, 2), 8, True))

                Case 3
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Porcentagem, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Acumulado, 2), 8, True))

                Case 4
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Porcentagem, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Acumulado, 2), 8, True))

                Case 5
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Porcentagem, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Valor, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Acumulado, 2), 8, True))

            End Select

        Next

        'Gerando 5 bases aleatórias
        Dim IsMatBaseIR(5, 5) As Decimal
        'Dim numeroAleatorio As Integer = Int((max - min + 1) * Rnd()) + min

        IsMatBaseIR(1, 0) = Math.Round(Int(IRtabela(0).Class_IRfaixa1 - 750 + 1) * Rnd() + 750, 2)
        IsMatBaseIR(2, 0) = Math.Round(Int(IRtabela(0).Class_IRfaixa2 - IRtabela(0).Class_IRfaixa1 + 1) * Rnd() + IRtabela(0).Class_IRfaixa1, 2)
        IsMatBaseIR(3, 0) = Math.Round(Int(IRtabela(0).Class_IRfaixa3 - IRtabela(0).Class_IRfaixa2 + 1) * Rnd() + IRtabela(0).Class_IRfaixa2, 2)
        IsMatBaseIR(4, 0) = Math.Round(Int(IRtabela(0).Class_IRfaixa4 - IRtabela(0).Class_IRfaixa3 + 1) * Rnd() + IRtabela(0).Class_IRfaixa3, 2)
        IsMatBaseIR(5, 0) = Math.Round(Int(40000 - IRtabela(0).Class_IRfaixa4 + 1) * Rnd() + IRtabela(0).Class_IRfaixa4, 2)

        ' Gerando os calculos por base - Gravação no item (base,5)
        IsMatBaseIR(1, 5) = IRcalculo(IsMatBaseIR(1, 0), IsComparacao)
        IsMatBaseIR(2, 5) = IRcalculo(IsMatBaseIR(2, 0), IsComparacao)
        IsMatBaseIR(3, 5) = IRcalculo(IsMatBaseIR(3, 0), IsComparacao)
        IsMatBaseIR(4, 5) = IRcalculo(IsMatBaseIR(4, 0), IsComparacao)
        IsMatBaseIR(5, 5) = IRcalculo(IsMatBaseIR(5, 0), IsComparacao)

        ' Exibindo as base selecionadas
        LblBase1.Text = numeroLatino(IsMatBaseIR(1, 0), 10, True)
        LblBase2.Text = numeroLatino(IsMatBaseIR(2, 0), 10, True)
        LblBase3.Text = numeroLatino(IsMatBaseIR(3, 0), 10, True)
        LblBase4.Text = numeroLatino(IsMatBaseIR(4, 0), 10, True)
        LblBase5.Text = numeroLatino(IsMatBaseIR(5, 0), 10, True)

        ' Exibindo os descontos apurados de cada base 
        LblTotal_b1.Text = numeroLatino(IsMatBaseIR(1, 5), 8, True)
        LblTotal_b2.Text = numeroLatino(IsMatBaseIR(2, 5), 8, True)
        LblTotal_b3.Text = numeroLatino(IsMatBaseIR(3, 5), 8, True)
        LblTotal_b4.Text = numeroLatino(IsMatBaseIR(4, 5), 8, True)
        LblTotal_b5.Text = numeroLatino(IsMatBaseIR(5, 5), 8, True)



        If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa1 Then

            LblFaixa1_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)

            If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa2 Then

                LblFaixa2_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)

                If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa3 Then

                    LblFaixa3_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True)

                    If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa4 Then

                        LblFaixa4_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True)
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
            LblFaixa1_b1.Text = numeroLatino(Math.Round((IsMatBaseIR(1, 0) * IRtabela(0).Class_IRfaixa1Porcentagem) / 100, 2), 8, True)
            LblFaixa2_b1.Text = numeroLatino(0, 8, True)
            LblFaixa3_b1.Text = numeroLatino(0, 8, True)
            LblFaixa4_b1.Text = numeroLatino(0, 8, True)

        End If

        If IsMatBaseIR(2, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b2.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        LblFaixa2_b2.Text = numeroLatino(Math.Round(IsMatBaseIR(2, 5) - IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        LblFaixa3_b2.Text = numeroLatino(0, 8, True)
        LblFaixa4_b2.Text = numeroLatino(0, 8, True)

        If IsMatBaseIR(3, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b3.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        If IsMatBaseIR(3, 0) >= IRtabela(0).Class_IRfaixa2 Then LblFaixa2_b3.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)
        LblFaixa3_b3.Text = numeroLatino(Math.Round(IsMatBaseIR(3, 5) - IRtabela(0).Class_IRfaixa2Acumulado, 2), 8, True)
        LblFaixa4_b3.Text = numeroLatino(0, 8, True)



        If IsMatBaseIR(4, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b4.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        If IsMatBaseIR(4, 0) >= IRtabela(0).Class_IRfaixa2 Then LblFaixa2_b4.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)
        If IsMatBaseIR(4, 0) >= IRtabela(0).Class_IRfaixa3 Then LblFaixa3_b4.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True)

        If IRtabela(0).Class_IRnumeroDeFaixas > 3 Then

            LblFaixa4_b4.Text = numeroLatino(Math.Round(IsMatBaseIR(4, 5) - IRtabela(0).Class_IRfaixa3Acumulado, 2), 8, True)

        Else

            LblFaixa3_b4.Text = numeroLatino(Math.Round(IsMatBaseIR(4, 5) - IRtabela(0).Class_IRfaixa2Acumulado, 2), 8, True)

        End If

        'If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        'If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa2 Then LblFaixa2_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)
        'If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa3 Then LblFaixa3_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True)
        'If IsMatBaseIR(1, 0) >= IRtabela(0).Class_IRfaixa4 Then LblFaixa4_b1.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True)

        'If IsMatBaseIR(2, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b2.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        'If IsMatBaseIR(2, 0) >= IRtabela(0).Class_IRfaixa2 Then LblFaixa2_b2.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)
        'If IsMatBaseIR(2, 0) >= IRtabela(0).Class_IRfaixa3 Then LblFaixa3_b2.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True)
        'If IsMatBaseIR(2, 0) >= IRtabela(0).Class_IRfaixa4 Then LblFaixa4_b2.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True)

        'If IsMatBaseIR(3, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b3.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        'If IsMatBaseIR(3, 0) >= IRtabela(0).Class_IRfaixa2 Then LblFaixa2_b3.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)
        'If IsMatBaseIR(3, 0) >= IRtabela(0).Class_IRfaixa3 Then LblFaixa3_b3.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True)
        'If IsMatBaseIR(3, 0) >= IRtabela(0).Class_IRfaixa4 Then LblFaixa4_b3.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True)

        'If IsMatBaseIR(4, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b4.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        'If IsMatBaseIR(4, 0) >= IRtabela(0).Class_IRfaixa2 Then LblFaixa2_b4.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)
        'If IsMatBaseIR(4, 0) >= IRtabela(0).Class_IRfaixa3 Then LblFaixa3_b4.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True)
        'If IsMatBaseIR(4, 0) >= IRtabela(0).Class_IRfaixa4 Then LblFaixa4_b4.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True)

        If IsMatBaseIR(5, 0) >= IRtabela(0).Class_IRfaixa1 Then LblFaixa1_b5.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True)
        If IsMatBaseIR(5, 0) >= IRtabela(0).Class_IRfaixa2 Then LblFaixa2_b5.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True)
        If IsMatBaseIR(5, 0) >= IRtabela(0).Class_IRfaixa3 Then LblFaixa3_b5.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True)
        If IsMatBaseIR(5, 0) >= IRtabela(0).Class_IRfaixa4 Then LblFaixa4_b5.Text = numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True)
    End Function
End Class