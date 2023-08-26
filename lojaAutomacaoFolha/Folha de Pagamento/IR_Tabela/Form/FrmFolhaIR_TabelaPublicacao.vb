Public Class FrmFolhaIR_TabelaPublicacao
    Dim oi As New MsgShow
    Private Sub FrmFolhaIR_TabelaPublicacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Oi.Title = Me.Text

        Dim Query As String

        Query = "Select count(*) from folha_tabela_imposto_renda_pf where IRtabelaStatus=1"            'Conferido

        Dim isQto As Integer = ApontaSQL(Query)

        If isQto = 0 Then

            With Oi

                .Msg = "Não existe tabela conferida para agendar Publicação"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)

                Me.Close()

                Exit Sub
            End With

        ElseIf isQto > 1 Then

            With Oi

                .Msg = "Mais de uma tabela com Status de conferida"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)

                Me.Close()

                Exit Sub
            End With
        End If


        IR_mostra_tabela(gravaSQLretorno("Select IRREF from folha_tabela_imposto_renda_pf where IRtabelaStatus=1"))

        LblAutorizadorChave.Text = usuClass.Usuario_Tipo & usuClass.Usuario_Chave

        LblUsuarioAutorizador.Text = usuClass.Usuario_Nome

        TxtPassWord.Focus()
    End Sub
    Private Sub IR_mostra_tabela(StrReferencia As String)

        Dim IsComparacao As String = "IRREF = '" & StrReferencia & "'"

        Dim IRtabela As List(Of ClassIRtabela) = ClassIRtabelaAcao.GetIR_DB(IsComparacao)

        ListView1.Items.Clear()
        LblRef.Text = "REF: " & IRtabela(0).Class_IRref.Substring(0, 4) & "/" & IRtabela(0).Class_IRref.Substring(4)
        LblDigitadoPor.Text = "Digitado por: " & IRtabela(0).Class_IRresponsavelDigitacaoTipo & IRtabela(0).Class_IRresponsavelDigitacao & " - " & IRtabela(0).Class_IRresponsavelDigitacaoUsuario & " - " & IRtabela(0).Class_IRdataCriacao
        LblConferidoPor.Text = "Conferido por: " & IRtabela(0).Class_IRresponsavelConferenciaTipo & IRtabela(0).Class_IRresponsavelConferencia & " - " & IRtabela(0).Class_IRresponsavelConferenciaUsuario & " - " & IRtabela(0).Class_IRdataConferencia
        LblPublicacao.Text = "Data Prevista para Publicação: " & dataLatina(IRtabela(0).Class_IR_dataInicio)

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

    End Sub

    Private Sub BtnAutoriza_Click(sender As Object, e As EventArgs) Handles BtnAutoriza.Click
        Dim isAno As String = LblRef.Text.Substring(5, 4)
        'Dim isRef As String = isAno & LblRef.Text.Substring(10)


        If Replace(TxtPassWord.Text, " ", "") <> usuClass.Usario_senha Then
            With oi

                .Msg = "Senha não confere !"
                .Msg += Chr(13) & Chr(13)
                .Msg += "Por favor, digite novamente a senha"
                .Style = vbInformation
                MsgBox(.Msg, .Style, .Title)

                Exit Sub

            End With

        Else
            With oi

                .Msg = "Publicação Autorizada!"
                .Msg += Chr(13) & Chr(13)
                .Msg += "Confirma Autorização"
                .Style = vbYesNo
                If MsgBox(.Msg, .Style, .Title) = 6 Then

                    ' Realizar o agendamento da publicação 
                    Dim Query As String
                    'Dim IsRef As String = LblRef.Text.Substring(4, 4) & LblRef.Text.Substring(9, 2)

                    Dim inTabelaINSSNumero As String = gravaSQLretorno("select  concat('" & isAno & "','.',lpad(convert((select count(*) + 1 from folha_tabela_imposto_renda_pf where substring(IRREF,1,4) = '" & isAno & "'  and IRtabelaStatus = 3),char),2,'0'));")
                    Query = "Update folha_tabela_imposto_renda_pf set "
                    Query += "IRtabelaNumero = '" & inTabelaINSSNumero & "'"
                    Query += ",IRtabelaStatus = 2"
                    Query += ",IRdataPublicacao = now()"
                    Query += ",IRresponsavelPublicacao = " & usuClass.Usuario_Chave
                    Query += ",IRresponsavelPublicacaoTipo = '" & usuClass.Usuario_Tipo & "'"
                    Query += " where "
                    Query += "IRtabelaStatus = 1;"

                    'Query = "Call sp_Folha_tabela_INSS_agenda ('" & isRef & "'," & usuClass.Usuario_Chave & ",'" & usuClass.Usuario_Tipo & "')"

                    If gravaSQL(Query) Then

                        With oi

                            .Msg = "Gravação realizada com sucesso!"
                            .Msg += Chr(13) & Chr(13)
                            .Msg += "Tabela aguardando data de publicação"
                            .Style = vbInformation
                            MsgBox(.Msg, .Style, .Title)

                            Me.Close()

                            Exit Sub

                        End With

                    Else
                        With oi

                            .Msg = "Gravação não realizada !"
                            .Msg += Chr(13) & Chr(13)
                            .Msg += "Aguarde alguns momento e tente de novo"
                            .Style = vbInformation
                            MsgBox(.Msg, .Style, .Title)

                            Exit Sub

                        End With
                    End If

                Else

                    TxtPassWord.Text = ""

                End If



                Exit Sub

            End With

        End If
    End Sub
End Class