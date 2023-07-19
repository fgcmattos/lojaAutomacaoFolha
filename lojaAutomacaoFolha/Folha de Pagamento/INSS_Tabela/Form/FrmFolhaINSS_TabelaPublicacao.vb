﻿Public Class FrmFolhaINSS_TabelaPublicacao
    Dim oi As New MsgShow

    Private Sub FrmFolhaINSS_TabelaPublicacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Oi.Title = Me.Text

        Dim Query As String

        Query = "Select count(*) from inss where INSStabelaStatus=1"            'Conferido

        Dim isQto As Integer = ApontaSQL(Query)

        If isQto = 0 Then

            MsgBox("Não existe tabela conferida para agendar Publicação")

            Me.Close()

            Exit Sub
        ElseIf isQto > 1 Then

            MsgBox("Mais de uma tabela com Status de conferida")

            Me.Close()

            Exit Sub

        End If


        INSS_mostra_tabela(gravaSQLretorno("Select INSSREF from inss where INSStabelaStatus=1"))

        LblAutorizadorChave.Text = usuClass.Usuario_Tipo & usuClass.Usuario_Chave

        LblUsuarioAutorizador.Text = usuClass.Usuario_Nome

        TxtPassWord.Focus()

    End Sub
    Private Function INSS_mostra_tabela(StrReferencia As String)

        Dim IsComparacao As String = "INSSREF = '" & StrReferencia & "'"

        Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_DB(IsComparacao)

        ListView1.Items.Clear()
        LblRef.Text = "REF: " & INSStabela(0).Class_INSSREF.Substring(0, 4) & "/" & INSStabela(0).Class_INSSREF.Substring(4)
        LblDigitadoPor.Text = "Digitado por: " & INSStabela(0).Class_INSSresponsavelDigitacaoTipo & INSStabela(0).Class_INSSresponsavelDigitacao & " - " & INSStabela(0).Class_INSSresponsavelDigitacaoUsuario & " - " & INSStabela(0).Class_INSSdataCriacao
        LblConferidoPor.Text = "Conferido por: " & INSStabela(0).Class_INSSresponsavelConferenciaTipo & INSStabela(0).Class_INSSresponsavelConferencia & " - " & INSStabela(0).Class_INSSresponsavelConferenciaUsuario & " - " & INSStabela(0).Class_INSSdataConferencia
        LblPublicacao.Text = "Data Prevista para Publicação: " & dataLatina(INSStabela(0).Class_INSS_dataInicio)

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

    End Function

    Private Sub BtnAutoriza_Click(sender As Object, e As EventArgs) Handles BtnAutoriza.Click

        Dim isRef As String = LblRef.Text.Substring(5, 4)

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


                    Dim inTabelaINSSNumero As String = gravaSQLretorno("select  concat('2023','.',lpad(convert((select count(*) + 1 from inss where substring(INSSREF,1,4) = '" & isRef & "'  and INSStabelaStatus = 3),char),2,'0'));")
                    Query = "Update inss set "
                    Query += "INSStabelaNumero = '" & inTabelaINSSNumero & "'"
                    Query += ",INSStabelaStatus = 2"
                    Query += ",INSSdataPublicacao = now()"
                    Query += ",INSSresponsavelPublicacao = " & usuClass.Usuario_Chave
                    Query += ",INSSresponsavelPublicacaoTipo = '" & usuClass.Usuario_Tipo & "'"
                    Query += " where "
                    Query += "INSStabelaStatus = 1;"

                    '''

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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class