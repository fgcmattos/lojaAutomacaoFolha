Imports MySql.Data.MySqlClient

Public Class FrmFolhaAdiantamentoSalarialPreliminarTodos
    Public OI As New MsgShow
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        Dim StrReferencia As String = MskReferencia.Text
        Dim DecPorcentagem As Decimal = 0
        DecPorcentagem = (Convert.ToDecimal(MskPorcentagemDoSalario.Text)) / 100
        lblSomaBoleean.Text = "0"

        If DecPorcentagem = 0 Then Exit Sub

        ListView1.Items.Clear()
        StrReferencia = StrReferencia.Substring(3, 4) + StrReferencia.Substring(0, 2)
        'Comnetario feito 
        'Comnetario feito 2
        Dim booGravado As Boolean = False
        Dim query As String = ""
        query += "select "
        query += "FL_key_col"               '0
        query += ",colaboradorNome"         '1
        query += ",colaboradorFuncao"       '2
        query += ",15"                      '3
        query += ",FL_valor_base"           '4
        query += ",FL_valor "               '5
        query += ",FL_folha_tipo "          '6
        query += ",FL_folha2_status"        '7
        query += " From folha_lancamento,colaborador "
        query += " Where "
        query += " FL_referencia = '" & StrReferencia & "'"
        query += " And FL_folha_tipo = 2"
        query += " And chave = FL_key_col"
        query += " And (FL_folha2_Status = 'G'"
        query += " Or  FL_folha2_Status = 'E')"
        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    With ListView1.Items

                        '.Add(DTReader.GetValue(0))
                        'ListView1.Items(.Count - 1).SubItems.Add(DTReader.GetValue(1))

                        .Add(DTReader.GetValue(0))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader.GetValue(1))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader.GetValue(2))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader.GetValue(3))
                        ListView1.Items(.Count - 1).SubItems.Add(MoneyLatino(DTReader.GetValue(4)))
                        ListView1.Items(.Count - 1).SubItems.Add(MoneyLatino(DTReader.GetValue(5)))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader.GetValue(7))
                        ListView1.Items(.Count - 1).Checked = True

                        If DTReader.GetValue(6) = 2 Then

                            booGravado = True

                        End If

                    End With

                End While

            Catch ex As Exception
                With OI
                    .msg = "Referência não gravada"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                End With
            End Try

            Conn.Close()

        End If
        If booGravado Then
            LblSomaSalario.Text = MoneyLatino(SomaSalarioLocal())
            LblSomaAdiantamento.Text = MoneyLatino(SomaAdiantamentoLocal())
            With OI
                .msg = "Adiantamento Aguardando Efetivação!"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
            End With
            GruReferenciaPesquisa.Enabled = False
            'GruAdiantamentoShow.Enabled = False
            BtnGerarArquivo.Enabled = False
            BtnDesfazer.Visible = True
            BtnNovaReferencia.Visible = True
            BtnVoltaPesquisa.Enabled = False
            BtnSair.Visible = True
            BtnSair.Focus()
            Exit Sub
        End If

        query = "select "
        query += "chave"                                                '0
        query += ",colaboradorNome"                                     '1
        query += ",colaboradorFuncao"                                   '2
        query += ",if(TIMESTAMPDIFF(DAY,colaboradorAdmissao,now())>15,15,TIMESTAMPDIFF(DAY,colaboradorAdmissao,now()))" '3
        query += ",ColaboradorSalarioAtual"                             '4
        query += ",round(ColaboradorSalarioAtual*" & Replace(DecPorcentagem.ToString, ",", ".") & ",2)"                '5
        query += ",'S'"
        query += " from colaborador "
        query += " where colaboradorStatus = '100' order by chave"

        Dim CMD1 As New MySqlCommand(query, Conn)
        Dim DTReader1 As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader1 = CMD1.ExecuteReader
                While DTReader1.Read()

                    With ListView1.Items

                        .Add(DTReader1.GetValue(0))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader1.GetValue(1))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader1.GetValue(2))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader1.GetValue(3))
                        ListView1.Items(.Count - 1).SubItems.Add(MoneyLatino(DTReader1.GetValue(4)))
                        ListView1.Items(.Count - 1).SubItems.Add(MoneyLatino(DTReader1.GetValue(5)))
                        ListView1.Items(.Count - 1).SubItems.Add(DTReader1.GetValue(6))
                        ListView1.Items(.Count - 1).SubItems.Add(MoneyLatino("S"))

                        ListView1.Items(.Count - 1).Checked = True

                    End With

                End While

            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            BtnGerarArquivo.Enabled = True
            BtnVoltaPesquisa.Enabled = True
            LblSomaAdiantamento.Text = MoneyLatino(SomaAdiantamentoLocal())
            LblSomaSalario.Text = MoneyLatino(SomaSalarioLocal())
            lblSomaBoleean.Text = "1"
            Conn.Close()

        End If
        GruReferenciaPesquisa.Enabled = False

    End Sub

    Function SomaAdiantamentoLocal() As Decimal

        Dim decSoma As Decimal = 0

        With ListView1
            For i = 0 To .Items.Count - 1
                If .Items(i).Checked Then
                    decSoma += Convert.ToDecimal(Replace(MoneyUSA(.Items(i).SubItems(5).Text), ".", ","))
                End If
            Next
        End With

        Return decSoma

    End Function

    Function SomaSalarioLocal() As Decimal

        Dim decSoma As Decimal = 0

        With ListView1
            For i = 0 To .Items.Count - 1

                If .Items(i).Checked Then

                    decSoma += Convert.ToDecimal(Replace(MoneyUSA(.Items(i).SubItems(4).Text), ".", ","))

                End If
            Next
        End With

        Return decSoma

    End Function

    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        If lblSomaBoleean.Text = 1 Then

            LblSomaSalario.Text = MoneyLatino(SomaSalarioLocal())
            LblSomaAdiantamento.Text = MoneyLatino(SomaAdiantamentoLocal())

        End If
    End Sub

    Private Sub FrmFolhaAdiantamentoSalarialPreliminarTodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ag As List(Of Aponta) = ApontaAcoes.GetApontaDB
        Dim strAgData As String = ag(0).Data
        Dim strValPag As String = "0024"
        Dim strValHol As String = "0025"
        OI.title = Me.Text



        Dim strRef As String = strAgData.Substring(4, 2) & "/" & strAgData.Substring(0, 4)
        Dim strDataPagamento As String = "15/" & strRef
        Dim strPorcentagem As String = "40"

        MskReferencia.Text = strRef
        MskDataPagamento.Text = strDataPagamento
        MskPorcentagemDoSalario.Text = strPorcentagem


        MskVariavelPagamento.Text = strValPag
        MskVariavelHolerite.Text = strValHol

        ' Show das variaveis de lancamento do adiantamento salarial
        Dim query As String = ""
        query += "Select "
        query += "FV_nome"                  '0
        query += ",FV_baseINSS"             '1
        query += ",FV_baseFGTS"             '2
        query += ",FV_baseIR"               '3
        query += ",FV_UNIDADE"              '4
        query += ",FV_tipo_financeiro"      '5
        query += ",FV_QTO"                  '6
        query += ",FV_codigo"               '7
        query += " from folha_variaveis_modelo where FV_codigo In ('" & strValPag & "','" & strValHol & "')"
        query += " Order by FV_codigo"

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(query, Conn)
        If OpenDB() Then

            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    If strValPag = DTReader.GetValue(7) Then

                        LblVariavelDescricaoPagamento.Text = DTReader.GetValue(0)
                        MskINSSpagamento.Text = DTReader.GetValue(1)
                        MskFGTSpagamento.Text = DTReader.GetValue(2)
                        MskIRpagamento.Text = DTReader.GetValue(3)
                        MskUnidadePagamento.Text = DTReader.GetValue(4)
                        MskTipoPagamento.Text = DTReader.GetValue(5)

                    Else

                        LblVariavelDescricaoHolerite.Text = DTReader.GetValue(0)
                        MskINSSHolerite.Text = DTReader.GetValue(1)
                        MskFGTSHolerite.Text = DTReader.GetValue(2)
                        MskIRHolerite.Text = DTReader.GetValue(3)
                        MskUnidadeHolerite.Text = DTReader.GetValue(4)
                        MskTipoHolerite.Text = DTReader.GetValue(5)

                    End If

                End While
            Catch ex As Exception

                MsgBox("Problemas Na Gravação!")

            End Try

            Conn.Close()

        End If
        ' End Show variaveis do lancamento do Adiantamento Salarial 
    End Sub

    Private Sub BtnGerarArquivo_Click(sender As Object, e As EventArgs) Handles BtnGerarArquivo.Click

        Dim strReferencia As String = MskReferencia.Text

        strReferencia = strReferencia.Substring(3,4) & strReferencia.Substring(0,2)

        With OI
            .msg = "Confirma a Geração do Arquivo de Adiantamento Salarial?" & Chr(13) & Chr(13) & "Referência : " & MskReferencia.Text & Chr(13) & Chr(13) & "Pagamento : " & MskDataPagamento.Text & Chr(13) & Chr(13) & "T O T A L  Adiantamento R$ " & LblSomaAdiantamento.Text
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta = 6 Then

                Dim query As String = ""


                For i = 0 To ListView1.Items.Count - 1

                    If ListView1.Items(i).Checked Then

                        query = "insert into folha_lancamento "
                        query += "("
                        query += "FL_Key_col"
                        query += ",FL_referencia"
                        query += ",FL_VARIAVEL"
                        query += ",FL_DESCRICAO"
                        query += ",FL_QTO"
                        query += ",FL_UNIDADE"
                        query += ",FL_USUARIO"
                        query += ",FL_base_INSS"
                        query += ",FL_base_FGTS"
                        query += ",FL_base_IR"
                        query += ",FL_tipo_financeiro"
                        query += ",FL_valor"
                        query += ",FL_data_ocorrencia"
                        query += ",FL_historico"
                        query += ",FL_folha_tipo"
                        query += ",FL_data_Pagamento"
                        query += ",FL_valor_base"
                        query += ",FL_folha2_status"
                        query += ")"
                        query += " values "
                        query += "("
                        query += ListView1.Items(i).SubItems(0).Text
                        query += ",'" & strReferencia & "'"
                        query += ",'" & MskVariavelPagamento.Text & "'"
                        query += ",'" & LblVariavelDescricaoPagamento.Text & "'"
                        query += ",'" & MskPorcentagemDoSalario.Text & "'"
                        query += ",'" & MskUnidadePagamento.Text & "'"
                        query += ",'" & Form1.Form1Chave.Text & "'"
                        query += ",'" & MskINSSpagamento.Text & "'"
                        query += ",'" & MskFGTSpagamento.Text & "'"
                        query += ",'" & MskIRpagamento.Text & "'"
                        query += ",'" & MskTipoPagamento.Text & "'"
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(5).Text)
                        query += ",'" & dataAAAAMMDD(MskDataPagamento.Text) & "'"
                        query += ",'Adiantamento Salarial Ref:" & MskReferencia.Text & "'"
                        query += ",2"
                        query += ",'" & dataAAAAMMDD(MskDataPagamento.Text) & "'"
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(4).Text)
                        query += ",'G'"
                        query += ");"
                        query += "insert into folha_lancamento "
                        query += "("
                        query += "FL_Key_col"
                        query += ",FL_referencia"
                        query += ",FL_VARIAVEL"
                        query += ",FL_DESCRICAO"
                        query += ",FL_QTO"
                        query += ",FL_UNIDADE"
                        query += ",FL_USUARIO"
                        query += ",FL_base_INSS"
                        query += ",FL_base_FGTS"
                        query += ",FL_base_IR"
                        query += ",FL_tipo_financeiro"
                        query += ",FL_valor"
                        query += ",FL_data_ocorrencia"
                        query += ",FL_historico"
                        query += ",FL_folha_tipo"
                        query += ",FL_data_Pagamento"
                        query += ",FL_valor_base"
                        query += ",FL_folha2_status"
                        query += ")"
                        query += " values "
                        query += "("
                        query += ListView1.Items(i).SubItems(0).Text
                        query += ",'" & strReferencia & "'"
                        query += ",'" & MskVariavelHolerite.Text & "'"
                        query += ",'" & LblVariavelDescricaoHolerite.Text & "'"
                        query += ",'" & MskPorcentagemDoSalario.Text & "'"
                        query += ",'" & MskUnidadeHolerite.Text & "'"
                        query += ",'" & Form1.Form1Chave.Text & "'"
                        query += ",'" & MskINSSHolerite.Text & "'"
                        query += ",'" & MskFGTSHolerite.Text & "'"
                        query += ",'" & MskIRHolerite.Text & "'"
                        query += ",'" & MskTipoHolerite.Text & "'"
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(5).Text)
                        query += ",'" & dataAAAAMMDD(MskDataPagamento.Text) & "'"
                        query += ",'Adiantamento Salarial Ref:" & MskReferencia.Text & "'"
                        query += ",2"
                        query += ",'" & dataAAAAMMDD(MskDataPagamento.Text) & "'"
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(4).Text)
                        query += ",'W'"
                        query += ");"


                        If OpenDB() Then

                            Dim DTReader As MySqlDataReader
                            Dim CMD As New MySqlCommand(query, Conn)

                            Try

                                DTReader = CMD.ExecuteReader


                            Catch ex As Exception

                                MsgBox("Problemas Na Gravação!")

                            End Try

                        End If

                        Conn.Close()

                    End If
                Next


            Else

                Exit Sub

            End If
            With OI

                .msg = "Arquivo Gerado com sucesso!" & Chr(13) & Chr(13) & "Aguardando Efetivação"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)

            End With

            ListView1.Items.Clear()
            GruReferenciaPesquisa.Enabled = True
            MskReferencia.Focus()
            BtnVoltaPesquisa.Enabled = False
            BtnGerarArquivo.Enabled = False
        End With
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnDesfazer_Click(sender As Object, e As EventArgs) Handles BtnDesfazer.Click
        Dim strReferencia As String = MskReferencia.Text

        strReferencia = strReferencia.Substring(3, 4) & strReferencia.Substring(0, 2)

        With OI

            .msg = "Confirma desfazer o Arquivo de Adiantamento Salarial?" & Chr(13) & Chr(13) & "Referência  " & MskReferencia.Text & Chr(13) & Chr(13) & "Pagamento : " & MskDataPagamento.Text & Chr(13) & Chr(13) & "T O T A L  Adiantamento R$ " & LblSomaAdiantamento.Text
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta = 6 Then

                Dim query As String = ""

                query = "delete from folha_lancamento "
                query += " where "
                query += "FL_folha_tipo = 2"
                query += " And FL_referencia = '" & strReferencia & "'"
                query += " and FL_data_fechamento is null"

                If OpenDB() Then
                    Dim DTReader As MySqlDataReader
                    Dim CMD As New MySqlCommand(query, Conn)
                    Try
                        DTReader = CMD.ExecuteReader
                    Catch ex As Exception
                        MsgBox("Problemas Na Gravação!")
                    End Try

                End If
                Conn.Close()
            Else
                Exit Sub
            End If
            With OI
                .msg = "Operção efetivada com sucesso!"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
            End With
            GruReferenciaPesquisa.Enabled = True
            'GruAdiantamentoShow.Enabled = True
            BtnGerarArquivo.Enabled = True

            BtnDesfazer.Visible = False
            BtnNovaReferencia.Visible = False
            BtnSair.Visible = False
            BtnGerarArquivo.Enabled = False
            ListView1.Items.Clear()
            MskReferencia.Focus()

        End With
    End Sub

    Private Sub BtnVoltaPesquisa_Click(sender As Object, e As EventArgs) Handles BtnVoltaPesquisa.Click

        BtnGerarArquivo.Enabled = False
        GruReferenciaPesquisa.Enabled = True
        BtnVoltaPesquisa.Enabled = False
        ListView1.Items.Clear()
        BtnPesquisa.Enabled = True

        MskReferencia.Focus()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub BtnNovaReferencia_Click(sender As Object, e As EventArgs) Handles BtnNovaReferencia.Click

        BtnDesfazer.Visible = False
        BtnSair.Enabled = False
        ListView1.Items.Clear()
        GruReferenciaPesquisa.Enabled = True
        MskReferencia.Focus()

    End Sub
End Class