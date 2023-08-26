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

    Private Sub IR_mostra_tabela(StrReferencia As String)

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
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5, 2), 8, True))
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Porcentagem, 2), 8, True))
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Valor, 2), 8, True))
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Acumulado, 2), 8, True))

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
    End Sub

    Private Sub CheckBoxOK1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK1.CheckedChanged

        With CheckBoxOK1
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With

    End Sub



    Private Sub CheckBoxOK2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK2.CheckedChanged
        With CheckBoxOK2
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With

    End Sub

    Private Sub CheckBoxOK3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK3.CheckedChanged
        With CheckBoxOK3
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With
    End Sub

    Private Sub CheckBoxOK4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK4.CheckedChanged
        With CheckBoxOK4
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With
    End Sub

    Private Sub CheckBoxOK5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK5.CheckedChanged
        With CheckBoxOK5
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With
    End Sub

    Private Sub CheckBoxOK6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK6.CheckedChanged
        With CheckBoxOK6
            If .Checked Then

                If TxtValorBase.Text = "0,00" Then

                    With oi

                        .Msg = "Teste Simulado inválido !"
                        .Style = vbCritical
                        MsgBox(.Msg, .Style, .Title)
                        CheckBoxOK6.Checked = False
                        LblINSSValorSimulado.Text = "0,00"
                        TxtValorBase.Focus()
                        Exit Sub

                    End With

                End If
                TxtValorBase.Enabled = False
                LblINSSValorSimulado.Text = numeroLatino(IRcalculo(TxtValorBase.Text, "IRtabelaStatus=0"), 10, True)
                .Text = "OK"
                .ForeColor = Color.Green
                TxtValorBase.Enabled = False

            Else

                .Text = "Não OK"
                .ForeColor = Color.Red
                TxtValorBase.Enabled = True
                TxtValorBase.Enabled = True

            End If
        End With
    End Sub

    Private Sub TxtValorBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorBase.KeyPress

        With TxtValorBase

            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

                Exit Sub

            End If

            If .MaxLength < .Text.Length And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then

                e.KeyChar = ""

                Exit Sub

            End If

            If e.KeyChar = Convert.ToChar(27) Then

                TxtValorBase.Text = "0,00"


            End If

            If e.KeyChar = Convert.ToChar(13) Then


                If .Text <= 0.00 Then

                    MsgBox("A Base deve ter um valor maior que 0.00", vbExclamation, Me.Text)
                    Exit Sub


                End If

                LblINSSValorSimulado.Text = numeroLatino(IRcalculo(TxtValorBase.Text, "IRtabelaStatus=0"), 10, True)


                'SendKeys.Send("{TAB}")


                Exit Sub

            End If

            If Asc(e.KeyChar) = 8 Then       ' BACKSPACE

                e.KeyChar = ""


                If .Text = "0,00" Then Exit Sub
                If .Text.Substring(0, 3) = "0,0" And .Text.Length = 4 Then .Text = "0,00" : SendKeys.Send("{END}") : Exit Sub
                If .Text.Substring(0, 2) = "0," And .Text.Length = 4 Then .Text = "0,0" + .Text.Substring(.Text.Length - 2, 1) : SendKeys.Send("{END}") : Exit Sub
                If .Text.Length = 4 Then .Text = "0," + .Text.Substring(0, 1) + .Text.Substring(2, 1) : SendKeys.Send("{END}") : Exit Sub

                .Text = .Text.Substring(0, .Text.Length - 1)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length


                .Text = retMascara(intSemMascara, strSemMascara)
                SendKeys.Send("{END}")
                Exit Sub

            End If

            If e.KeyChar >= "0" And e.KeyChar <= "9" Then

                Dim strComMascara As String = Trim(.Text)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length
                Dim strRetorno As String = ""
                Dim strPressionada As String = e.KeyChar

                e.KeyChar = ""

                If intSemMascara > 13 Then

                    Exit Sub

                End If

                If intSemMascara < 4 And strSemMascara.Substring(0, 1) = "0" Then

                    strSemMascara += strPressionada
                    strSemMascara = strSemMascara.Substring(1)

                Else

                    strSemMascara += strPressionada
                    intSemMascara += 1

                End If

                .Text = retMascara(intSemMascara, strSemMascara)



                SendKeys.Send("{END}")

            Else

                e.KeyChar = ""

                .Focus()


                ' SendKeys.Send("{END}")


            End If

        End With
    End Sub

    Private Sub TxtValorBase_TextChanged(sender As Object, e As EventArgs) Handles TxtValorBase.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With oi

            .Msg = "Confirma a retirada da tabela?"
            .Style = vbYesNo
            If MsgBox(.Msg, .Style, .Title) <> 6 Then
                .Msg = "Tabela Mantida"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End If

            Dim Query = "delete from folha_tabela_imposto_renda_pf where IRREF= '" & LblReferencia.Text.Replace("/", "") & "'"

            If gravaSQL(Query) Then
                .Msg = "Tabela retirada do sistema com sucesso"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Me.Close()
            Else
                .Msg = "Problema na Retirada da Tabela" & Chr(13)
                .Msg += "Tende de novo"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End If


        End With
    End Sub

    Private Sub BtnConferencia_Click(sender As Object, e As EventArgs) Handles BtnConferencia.Click
        Dim IsSemCheck As Boolean = True

        Dim IsTexto As String = ""

        If Not CheckBoxOK1.Checked Then IsSemCheck = False : IsTexto = "1.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK2.Checked Then IsSemCheck = False : IsTexto += "2.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK3.Checked Then IsSemCheck = False : IsTexto += "3.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK4.Checked Then IsSemCheck = False : IsTexto += "4.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK5.Checked Then IsSemCheck = False : IsTexto += "5.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK6.Checked Then IsSemCheck = False : IsTexto += "6.º Teste não Confirmado " + Chr(13)

        If Not IsSemCheck Then
            With oi

                .Msg = IsTexto & Chr(13) & "Confira todos os testes"
                .Style = vbCritical
                MsgBox(.Msg, .Style, .Title)

                Exit Sub

            End With
        End If

        With oi

            .Msg = " Confirma Checagem para gravação ?"
            .Style = vbYesNo
            If MsgBox(.Msg, .Style, .Title) <> 6 Then



            Else


                Dim Query As String
                Query = "UPDATE folha_tabela_imposto_renda_pf "
                Query += "SET IRtabelaStatus = 1 "
                Query += ",IRresponsavelConferenciaTipo ='" & usuClass.Usuario_Tipo & "'"
                Query += ",IRresponsavelConferencia =" & usuClass.Usuario_Chave
                Query += ",IRresponsavelConferencia =" & usuClass.Usuario_Chave
                Query += ",IRdataConferencia = now()"
                Query += " where "
                Query += "IRREF = '" & Replace(LblReferencia.Text, "/", "") & "'"
                If gravaSQL(Query) Then
                    With oi

                        .Msg = "Conferência Gravada com sucesso !"
                        .Style = vbExclamation
                        MsgBox(.Msg, .Style, .Title)
                        Me.Close()
                        Exit Sub

                    End With
                End If

            End If

            Exit Sub

        End With
    End Sub
End Class