Imports MySql.Data.MySqlClient
Public Class frmFolhaLancVar
    Public oi As New MsgShow
    Public ed_origem As New List(Of ClassFolhaVariaveis) ' Responsavel pelo registro original

    Private Sub MskColKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskColKey.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then

            MskMesAno.Enabled = True
            MskMesAno.Focus()
            MskColKey.Enabled = False

        End If

        If e.KeyChar = Convert.ToChar(13) Then

            Dim strReferencia As String = MskMesAno.Text.Substring(3, 4) & MskMesAno.Text.Substring(0, 2)

            If Trim(MskColKey.Text) = "" Then
                MsgBox("Código do colaborador inválido!")
                Exit Sub
            End If

            LblColNome.Text = colBuscaNome(MskColKey.Text)
            BtnEdicao.Enabled = True
            BtnEdicao.Focus()
            MskColKey.Enabled = False
            LvwEdicao.Items.Clear()

            carregaVarAuto(MskColKey.Text)

            carregaVarLancadas(MskColKey.Text, strReferencia)

        End If

    End Sub

    Private Function colBuscaNome(key As Integer) As String

        Dim retorna As String = ""
        Dim Query As String = "select colaboradornome from colaborador where chave = " & key
        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()

                retorna = DTReader.GetString(0)

            Catch ex As Exception

                MsgBox("colaborador não encontrado")

                retorna = ""

            End Try
        End If
        Conn.Close()

        Return retorna

    End Function

    Private Sub BtnEdicao_Click(sender As Object, e As EventArgs) Handles BtnEdicao.Click

        'Criar o objeto FolhaVariaveisManual
        'LvwEdicao.Items.Clear()

        'carregaVarAuto(MskColKey.Text)

        Dim strReferencia As String = MskMesAno.Text.Substring(3, 4) & MskMesAno.Text.Substring(0, 2)

        'carregaVarLancadas(MskColKey.Text, strReferencia)

        GruOperacao.Enabled = True

        BtnEdicao.Enabled = False

        BtnEdicaoSai.Enabled = True

        MskMesAno.Enabled = False
        BtnNovo.Enabled = True
        BtnEditar.Enabled = True
        BtnGravaEdicao.Enabled = False

        BtnNovo.Focus()

        ed_origem.Clear()

        ed_origem = ClassFolhaVariaveisAcao.GetVariavelTELA()

    End Sub
    Private Function carregaVarAuto(key As Integer)

        Dim retorna As String = ""
        Dim Query As String = ""
        Query = "select "
        Query += "  FV_codigo"             ' 0
        Query += ", FV_nome"               ' 1
        Query += ", FV_QTO"                ' 2
        Query += ", FV_UNIDADE"            ' 3
        Query += ", FV_valor"              ' 4
        Query += ", FV_tipo_financeiro"    ' 5
        Query += ", FV_baseINSS"           ' 6
        Query += ", FV_baseFGTS"           ' 7
        Query += ", FV_baseIR"             ' 8
        Query += ", ''"                    ' 9
        Query += ",  ''"                   ' 10
        Query += " FROM folha_variaveis_colaborador_auto "
        Query += "where FV_key_col = " & key


        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader

                With LvwEdicao
                    While DTReader.Read()
                        .Items.Add(.Items.Count())
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(0))     ' Variavel
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(1))     ' Descricao
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(2))     ' QTO
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(3))     ' UN
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(4))     ' Valor
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(5))     ' Tipo financeiro D/C
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(6))     ' Base INSS
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(7))     ' Base FGTS
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(8))     ' Base IR
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(9))     ' Data Ocorrencia
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(10))    ' Historico
                        .Items(.Items.Count() - 1).SubItems.Add("(R)")    ' Status  (R) registrada em Lancamentos automaticos
                        .Items(.Items.Count() - 1).Group = .Groups(1)
                        'LvParametros.Items(i).Group = LvParametros.Groups(Dv(i).GrupoListView)
                    End While
                End With
            Catch ex As Exception

                MsgBox("Variáveis automaticas não encontradas")

                retorna = ""

            End Try
        End If
        Conn.Close()

        Return retorna

    End Function
    Private Function carregaVarLancadas(key As Integer, referencia As String)

        Dim retorna As String = ""
        Dim objGroup As Object
        Dim Query As String = ""
        Query = "select "
        Query += "  FL_variavel"            ' 0
        Query += ", FL_descricao"           ' 1
        Query += ", FL_QTO"                 ' 2
        Query += ", FL_unidade"             ' 3
        Query += ", FL_valor"               ' 4
        Query += ", FL_tipo_financeiro"     ' 5
        Query += ", FL_base_INSS"           ' 6
        Query += ", FL_base_FGTS"           ' 7
        Query += ", FL_base_IR"             ' 8
        Query += ", FL_data_ocorrencia"     ' 9
        Query += ", FL_historico"           ' 10
        Query += ", FL_folha2_status"       ' 11
        Query += ", FL_calculo"             ' 12
        Query += ", FL_calculo_parametro"   ' 13
        Query += " FROM folha_lancamento "
        Query += "where FL_key_col = " & key
        Query += " and FL_referencia = '" & referencia & "'"
        Query += " and FL_folha_tipo = 1"
        Query += " order by FL_referencia,FL_key_col"

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        'Grupos do listview
        ''''(1) Lancadas pelo sistema
        ''''(2) Programadas
        ''''(3) Manuais ja gravadas
        ''''(4) Lancadas Manualmente nesta data

        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader

                With LvwEdicao

                    While DTReader.Read()

                        Select Case DTReader.GetString(11)

                            Case "E"        ' status gerado no adiantamento salarial
                                ' Grupo 1 - Lancadas pelo sistema

                                objGroup = .Groups(0)

                            Case "0"         ' Gerada manualmente e ja esta gravada

                                objGroup = .Groups(2)

                            Case Else

                                objGroup = .Groups(3)

                        End Select


                        .Items.Add(.Items.Count())
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(0))     ' Variavel
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(1))     ' Descricao
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(2))     ' QTO
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(3))     ' UN
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(4))     ' Valor
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(5))     ' Tipo financeiro D/C
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(6))     ' Base INSS
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(7))     ' Base FGTS
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(8))     ' Base IR
                        .Items(.Items.Count() - 1).SubItems.Add(dataLatina(DTReader.GetString(9)))     ' Data Ocorrencia
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(10))    ' Historico
                        .Items(.Items.Count() - 1).SubItems.Add("(L)")    ' status de tela
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(12))    ' calculo
                        .Items(.Items.Count() - 1).SubItems.Add(DTReader.GetString(13))    ' calculo parametro
                        .Items(.Items.Count() - 1).Group = objGroup
                        'LvParametros.Items(i).Group = LvParametros.Groups(Dv(i).GrupoListView)
                    End While
                End With
            Catch ex As Exception

                MsgBox("Variáveis lancadas não encontradas")

                retorna = ""

            End Try
        End If
        Conn.Close()

        Return retorna

    End Function
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click

        GruEdicaoDigitacao.Enabled = True
        GruEdicaoDigitacao.Text = "N O V O   R E G I S T R O"
        BtnEditar.Enabled = False
        TxtEdicaoOrdem.Text = "Novo"
        TxtEdicaoOrdem.Enabled = False
        TxtEdicaoVariavel.Focus()

    End Sub

    Private Function preenchevariaveis(ParPesquisa As Integer)

        ' Se parPesquisa = 0 nao pesquisa
        ' Se parPesquisa = 1 pesquisa por parte do nome

        Dim Query As String = ""
        Dim strPesquisa As String = Trim(TextBox1.Text)
        If ParPesquisa = 0 Then
            Query = "select fv_codigo,fv_nome from  folha_variaveis_modelo order by fv_nome"
        Else
            Query = "select fv_codigo,fv_nome from  folha_variaveis_modelo where fv_nome like " & "'%" & Trim(strPesquisa) & "%' order by fv_nome"
        End If

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        ListBox1.Items.Clear()

        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    ListBox1.Items.Add(DTReader(0) & " - " & DTReader(1))

                End While


            Catch ex As Exception

                MsgBox("Problemas comGravação!")

            End Try
        End If
        Conn.Close()

    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            preenchevariaveis(1)

        End If
    End Sub

    Private Sub LblVariavel_DoubleClick(sender As Object, e As EventArgs) Handles LblVariavel.DoubleClick
        GruPesquisaVariavel.Location = New System.Drawing.Point(209, 19)
        GruPesquisaVariavel.Visible = True
        preenchevariaveis(0)

    End Sub

    Private Sub BtnPesquisaCancela_Click(sender As Object, e As EventArgs) Handles BtnPesquisaCancela.Click

        GruPesquisaVariavel.Visible = False
        TxtEdicaoVariavel.Focus()

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        FolVarCarregaEdicao(ListBox1.SelectedItem.ToString().Substring(0, 4))

    End Sub

    Private Function FolVarCarregaEdicao(variavel As String) As Boolean

        FolVarCarregaEdicao = False

        Dim Query As String = ""


        Query = "select "
        Query += "fv_codigo"                        ' 0 - variavel
        Query += ",fv_nome"                         ' 1 - descricao
        Query += ",fv_QTO"                          ' 2 - quantidade
        Query += ",fv_unidade"                      ' 3 - unidade
        Query += ",fv_valor"                        ' 4 - valor
        Query += ",fv_tipo_financeiro"              ' 5 - tipo financeiro D/C
        Query += ",fv_baseINSS"                     ' 6 - base INSS
        Query += ",fv_baseFGTS"                     ' 7 - base FGTS
        Query += ",fv_BaseIR"                       ' 8 - base IR
        Query += ",FV_Calculo"                     ' 9 - Calculo para calculo 
        Query += ",FV_parametro"                    ' 10 - Parametro para o calculo
        Query += " from  folha_variaveis_modelo"
        Query += " where fv_codigo = '" & variavel & "'"


        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        ListBox1.Items.Clear()

        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    TxtEdicaoVariavel.Text = DTReader(0)
                    TxtEdicaoDescricao.Text = DTReader(1)
                    TxtEdicaoQTO.Text = DTReader(2)
                    TxtEdicaoUN.Text = DTReader(3)
                    TxtEdicaovalor.Text = DTReader(4)
                    TxtEdicaoTipo.Text = DTReader(5)
                    TxtEdicaoBaseINSS.Text = DTReader(6)
                    TxtEdicaoBaseFGTS.Text = DTReader(7)
                    TxtEdicaoBaseIR.Text = DTReader(8)
                    LblCalculo.Text = DTReader(9)
                    LblCalculoParametro.Text = DTReader(10)
                    FolVarCarregaEdicao = True

                End While


            Catch ex As Exception

                MsgBox("Problemas comGravação!")

            End Try
        End If
        Conn.Close()
        GruPesquisaVariavel.Visible = False
        TxtEdicaoVariavel.Focus()
    End Function

    Private Sub BtnEdita_Click(sender As Object, e As EventArgs) Handles BtnEdita.Click
        'Checando as entradas
        If TxtEdicaoOrdem.Text = "" Then

            With oi
                .msg = "Por favor, digite um número de ordem válido para a edição !"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
                TxtEdicaoOrdem.Focus()
                Exit Sub
            End With

        End If

        Dim strDta As String = Trim(Replace(TxtEdicaoDataOcorrencia.Text, "/", ""))
        If strDta <> "" Then
            Dim datDataTeste As Date
            Try
                datDataTeste = DateAdd("d", 1, TxtEdicaoDataOcorrencia.Text)
            Catch ex As Exception

                With oi
                    .msg = "Data inválida, por favor digite uma data existente!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    TxtEdicaoDataOcorrencia.Focus()
                    Exit Sub

                End With
            End Try

            If MskMesAno.Text <> Month(TxtEdicaoDataOcorrencia.Text).ToString("D2") & "/" & Year(TxtEdicaoDataOcorrencia.Text) Then

                With oi
                    .msg = "Data fora da referência !"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    TxtEdicaoDataOcorrencia.Focus()
                    Exit Sub
                End With

            End If

        End If

        If Val(TxtEdicaoQTO.Text) + Val(TxtEdicaovalor.Text) = 0 Then

            With oi
                .msg = "Os valores dos Campos QTO e Valor não podem ser simultaneamentes nulos !"
                .msg += Chr(13) & Chr(13) & "Por favor, entre com valores em pelo menos um do Campos"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
                TxtEdicaoQTO.Focus()
                Exit Sub
            End With

        End If



        If TxtEdicaoOrdem.Text = "Novo" Then

            If TxtEdicaoVariavel.Text = "" Then
                With oi
                    .msg = "Por favor, Digite uma variável válida!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    TxtEdicaoVariavel.Focus()
                    Exit Sub
                End With
            End If

            If TxtEdicaoDescricao.Text = "" Then
                With oi
                    .msg = "Por favor, Digite uma variável válida!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    TxtEdicaoVariavel.Focus()
                    Exit Sub
                End With
            End If


            With LvwEdicao
                .Items.Add(.Items.Count())
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoVariavel.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoDescricao.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoQTO.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoUN.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaovalor.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoTipo.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoBaseINSS.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoBaseFGTS.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoBaseIR.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoDataOcorrencia.Text)
                .Items(.Items.Count() - 1).SubItems.Add(TxtEdicaoHistorico.Text)
                .Items(.Items.Count() - 1).SubItems.Add("(D)")
                .Items(.Items.Count() - 1).SubItems.Add(LblCalculo.Text)
                .Items(.Items.Count() - 1).SubItems.Add(LblCalculoParametro.Text)
                .Items(.Items.Count() - 1).Group = .Groups(3)
            End With
            BtnGravaEdicao.Enabled = True

        ElseIf TxtEdicaoVariavel.Text = "" Then         ' retirada de um lancamento do lote ainda nao registrado

            Dim inIndice As Integer = Int(TxtEdicaoOrdem.Text)
            With oi
                .msg = "Lançamento Será retirado do movimento Confirma"
                .style = vbYesNo
                .resposta = MsgBox(.msg, .style, .title)
                If .resposta = 6 Then

                    With LvwEdicao

                        If .Items(inIndice).Group.Name = "Grupo4" Then

                            .Items.RemoveAt(inIndice)

                            For I = 0 To .Items.Count - 1

                                .Items(I).Text = I

                            Next

                        Else

                            .Items(inIndice).SubItems(12).Text = "(-)"

                            BtnGravaEdicao.Enabled = True

                        End If



                    End With
                Else

                    TxtEdicaoVariavel.Focus()

                End If
            End With


        Else

            Dim intIndice As Integer = Int(TxtEdicaoOrdem.Text)
            Dim booAlteracao As Boolean = False

            If ed_origem(intIndice - 1).Codigo <> TxtEdicaoVariavel.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).Descricao <> TxtEdicaoDescricao.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).QTO <> TxtEdicaoQTO.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).UN <> TxtEdicaoUN.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).Valor <> TxtEdicaovalor.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).TipoFinanceiro <> TxtEdicaoTipo.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).BaseINSS <> TxtEdicaoBaseINSS.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).BaseFGTS <> TxtEdicaoBaseFGTS.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).baseir <> TxtEdicaoBaseIR.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).OcorrenciaData <> TxtEdicaoDataOcorrencia.Text Then
                booAlteracao = True
            ElseIf ed_origem(intIndice - 1).Historico <> TxtEdicaoHistorico.Text Then
                booAlteracao = True
            End If

            If booAlteracao Then

                With LvwEdicao

                    If .Items(intIndice).Group.Name <> "Grupo4" Then

                        .Items(intIndice).SubItems(12).Text = "(A)"

                    End If

                    '.Items(intIndice).SubItems(12).Text = "A"
                    .Items(intIndice).SubItems(1).Text = TxtEdicaoVariavel.Text
                    .Items(intIndice).SubItems(2).Text = TxtEdicaoDescricao.Text
                    .Items(intIndice).SubItems(3).Text = TxtEdicaoQTO.Text
                    .Items(intIndice).SubItems(4).Text = TxtEdicaoUN.Text
                    .Items(intIndice).SubItems(5).Text = TxtEdicaovalor.Text
                    .Items(intIndice).SubItems(6).Text = TxtEdicaoTipo.Text
                    .Items(intIndice).SubItems(7).Text = TxtEdicaoBaseINSS.Text
                    .Items(intIndice).SubItems(8).Text = TxtEdicaoBaseFGTS.Text
                    .Items(intIndice).SubItems(9).Text = TxtEdicaoBaseIR.Text
                    .Items(intIndice).SubItems(10).Text = TxtEdicaoDataOcorrencia.Text
                    .Items(intIndice).SubItems(11).Text = TxtEdicaoHistorico.Text

                    BtnGravaEdicao.Enabled = True

                End With
            Else
                With oi
                    .msg = "Registro devolvido sem alteração !"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                End With
            End If

        End If

        limpaGruEdicaoDigitacao()
        GruOperacao.Enabled = True

    End Sub

    Private Sub TxtEdicaoQTO_GotFocus(sender As Object, e As EventArgs) Handles TxtEdicaoQTO.GotFocus

        SendKeys.Send("{END}")

    End Sub

    Private Sub TxtEdicaoQTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdicaoQTO.KeyPress

        With TxtEdicaoQTO
            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                'LblreciboValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'tbcFavorecido.Enabled = True
                'GruFavorecido.Enabled = True
                'GruCaracteristicas.Enabled = False
                'btnFavOK.Focus()

            End If

            If e.KeyChar = Convert.ToChar(13) Then


                'lblExtenso.Text = Extenso(.Text)
                'txtValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                'lblReciboData.ForeColor = System.Drawing.Color.Maroon
                'LblReciboDataAponta.Visible = True
                'mskReciboData.Enabled = True
                'mskReciboData.Focus()

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

            If e.KeyChar >= "0" And e.KeyChar <="9" Then

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


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With

    End Sub

    Private Sub TxtEdicaovalor_GotFocus(sender As Object, e As EventArgs) Handles TxtEdicaovalor.GotFocus

        SendKeys.Send("{END}")

    End Sub

    Private Sub TxtEdicaovalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdicaovalor.KeyPress

        With TxtEdicaovalor

            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                'LblreciboValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'tbcFavorecido.Enabled = True
                'GruFavorecido.Enabled = True
                'GruCaracteristicas.Enabled = False
                'btnFavOK.Focus()

            End If

            If e.KeyChar = Convert.ToChar(13) Then



                'lblExtenso.Text = Extenso(.Text)
                'txtValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                'lblReciboData.ForeColor = System.Drawing.Color.Maroon
                'LblReciboDataAponta.Visible = True
                'mskReciboData.Enabled = True
                'mskReciboData.Focus()

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


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With

    End Sub

    Private Sub BtnGravaEdicao_Click(sender As Object, e As EventArgs) Handles BtnGravaEdicao.Click
        Dim strReferencia As String = ""
        Dim intContador As Integer = 0
        Dim query As String = ""
        Dim queryExtensao As String = ""
        Dim queryPrefixo As String = ""

        strReferencia = MskMesAno.Text.Substring(3, 4) & MskMesAno.Text.Substring(0, 2)





        With LvwEdicao
            For i = 0 To .Items.Count - 1
                Select Case LvwEdicao.Items(i).SubItems(12).Text

                    Case "(D)"

                        queryPrefixo = "Insert into folha_lancamento "
                        queryPrefixo += " ("
                        queryPrefixo += "FL_referencia"
                        queryPrefixo += ",FL_variavel"
                        queryPrefixo += ",FL_descricao"
                        queryPrefixo += ",FL_base_INSS"
                        queryPrefixo += ",FL_base_FGTS"
                        queryPrefixo += ",FL_base_IR"
                        queryPrefixo += ",FL_UNIDADE"
                        queryPrefixo += ",FL_tipo_financeiro"
                        queryPrefixo += ",FL_QTO"
                        queryPrefixo += ",FL_Valor"
                        queryPrefixo += ",FL_data_ocorrencia"
                        queryPrefixo += ",FL_historico"
                        queryPrefixo += ",FL_key_col"
                        queryPrefixo += ",FL_usuario"
                        queryPrefixo += ",FL_folha_tipo"
                        queryPrefixo += ",FL_folha2_status"
                        queryPrefixo += ",FL_calculo"
                        queryPrefixo += ",FL_calculo_parametro"
                        queryPrefixo += ")"


                        queryExtensao = " values "
                        queryExtensao += "('" + strReferencia + "'"                                                         ' referencia
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(1).Text + "'"                                   ' codigo
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(2).Text + "'"                                   ' descricao
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(7).Text + "'"                                   ' base INSS
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(8).Text + "'"                                   ' base FGTS
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(9).Text + "'"                                   ' base IR
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(4).Text + "'"                                   ' unidade
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(6).Text + "'"                                   ' Tipo financeiro D/C
                        queryExtensao += "," + Replace(Replace(LvwEdicao.Items(i).SubItems(3).Text, ".", ""), ",", ".")     ' QTO
                        queryExtensao += "," + Replace(Replace(LvwEdicao.Items(i).SubItems(5).Text, ".", ""), ",", ".")     ' valor
                        queryExtensao += ",'" + dataAAAAMMDD(LvwEdicao.Items(i).SubItems(10).Text) + "'"                    ' data da ocorrecia
                        queryExtensao += ",'" + LvwEdicao.Items(i).SubItems(11).Text + "'"                                  ' historico
                        queryExtensao += "," + MskColKey.Text                                                               ' chave do colaborador
                        queryExtensao += "," + usuClass.Usuario_Chave                                                       ' responsavel pela gravacao
                        queryExtensao += ",1"
                        queryExtensao += ",0"
                        queryExtensao += "," + LvwEdicao.Items(i).SubItems(13).Text                                         ' calculo
                        queryExtensao += "," + MoneyUSA(LvwEdicao.Items(i).SubItems(14).Text)                               ' calculo parametro
                        queryExtensao += ")"

                        query = queryPrefixo + queryExtensao

                    Case "(A)"


                        queryPrefixo = "UPDATE folha_lancamento set"

                        queryPrefixo += " FL_referencia = '" + strReferencia + "'"          ' referencia
                        queryPrefixo += ",FL_variavel = '" + LvwEdicao.Items(i).SubItems(1).Text + "'"  ' codigo
                        queryPrefixo += ",FL_descricao = '" + LvwEdicao.Items(i).SubItems(2).Text + "'" ' descricao
                        queryPrefixo += ",FL_base_INSS = '" + LvwEdicao.Items(i).SubItems(7).Text + "'" ' base INSS
                        queryPrefixo += ",FL_base_FGTS = '" + LvwEdicao.Items(i).SubItems(8).Text + "'" ' base FGTS
                        queryPrefixo += ",FL_base_IR = '" + LvwEdicao.Items(i).SubItems(9).Text + "'"   ' base IR
                        queryPrefixo += ",FL_UNIDADE = '" + LvwEdicao.Items(i).SubItems(4).Text + "'"   ' unidade
                        queryPrefixo += ",FL_tipo_financeiro = '" + LvwEdicao.Items(i).SubItems(6).Text + "'" ' Tipo financeiro D/C
                        queryPrefixo += ",FL_QTO = " + Replace(Replace(LvwEdicao.Items(i).SubItems(3).Text, ".", ""), ",", ".") ' QTO
                        queryPrefixo += ",FL_Valor = " + Replace(Replace(LvwEdicao.Items(i).SubItems(5).Text, ".", ""), ",", ".") ' valor
                        queryPrefixo += ",FL_data_ocorrencia = '" + dataAAAAMMDD(LvwEdicao.Items(i).SubItems(10).Text) + "'" ' data da ocorrecia
                        queryPrefixo += ",FL_historico = '" + LvwEdicao.Items(i).SubItems(11).Text + "'" ' historico
                        queryPrefixo += ",FL_key_col = " + MskColKey.Text ' chave do colaborador
                        queryPrefixo += ",FL_usuario = " + Form1.Form1Chave.Text ' responsavel pela gravacao




                        queryExtensao = " where FL_key_col = " & MskColKey.Text & " and FL_variavel = " & "'" + LvwEdicao.Items(i).SubItems(1).Text + "'"

                        query = queryPrefixo + queryExtensao

                    Case "(-)"

                        query = "Delete from folha_lancamento where FL_key_col = " & MskColKey.Text & " and FL_variavel = " & "'" + LvwEdicao.Items(i).SubItems(1).Text + "'"

                    Case "(R)", "(L)"

                        Continue For


                End Select

                gravaSQL(query)

                'MskMesAno.Text = "__/____"


            Next


            limpaGruEdicaoDigitacao()
            LvwEdicao.Items.Clear()
            GruOperacao.Enabled = False
            BtnNovo.Enabled = False
            BtnEditar.Enabled = False
            BtnGravaEdicao.Enabled = False
            MskColKey.Enabled = True
            MskColKey.Focus()


        End With
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click


        GruEdicaoDigitacao.Enabled = True
        GruEdicaoDigitacao.Text = "E D I Ç Ã O   D E    R E G I S T R O"
        GruOperacao.Enabled = False
        'BtnNovo.Enabled = False
        TxtEdicaoOrdem.Enabled = True
        TxtEdicaoOrdem.Focus()

    End Sub

    Private Sub TxtEdicaoOrdem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdicaoOrdem.KeyPress

        With TxtEdicaoOrdem

            If e.KeyChar = Convert.ToChar(13) Then

                If .Text = "" Then

                    With oi
                        .msg = "Por favor, digite um número de ordem válido para a edição !"
                        .style = vbExclamation
                        MsgBox(.msg, .style, .title)
                        Exit Sub
                    End With

                    'LvwEdicao.Items.RemoveAt(LvwEdicao.SelectedIndices)
                Else
                    Dim intOrdemTeste As Integer = -1

                    Try
                        intOrdemTeste = Int(TxtEdicaoOrdem.Text) + 1
                    Catch ex As Exception
                        With oi
                            .msg = "Por favor, digite um número de ordem válido para a edição !"
                            .style = vbExclamation
                            MsgBox(.msg, .style, .title)
                        End With
                        Exit Sub
                    End Try

                    If LvwEdicao.Items.Count < (intOrdemTeste) Then
                        With oi
                            .msg = "Por favor, digite um número de ordem entre 0 e " & (LvwEdicao.Items.Count - 1) & " !"
                            .style = vbExclamation
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If


                End If

                Dim intIndice As Integer = Int(TxtEdicaoOrdem.Text)

                With LvwEdicao
                    TxtEdicaoVariavel.Text = .Items(intIndice).SubItems(1).Text
                    TxtEdicaoDescricao.Text = .Items(intIndice).SubItems(2).Text
                    TxtEdicaoQTO.Text = .Items(intIndice).SubItems(3).Text
                    TxtEdicaoUN.Text = .Items(intIndice).SubItems(4).Text
                    TxtEdicaovalor.Text = .Items(intIndice).SubItems(5).Text
                    TxtEdicaoTipo.Text = .Items(intIndice).SubItems(6).Text
                    TxtEdicaoBaseINSS.Text = .Items(intIndice).SubItems(7).Text
                    TxtEdicaoBaseFGTS.Text = .Items(intIndice).SubItems(8).Text
                    TxtEdicaoBaseIR.Text = .Items(intIndice).SubItems(9).Text
                    TxtEdicaoDataOcorrencia.Text = .Items(intIndice).SubItems(10).Text
                    TxtEdicaoHistorico.Text = .Items(intIndice).SubItems(11).Text
                    LblCalculo.Text = .Items(intIndice).SubItems(12).Text
                    LblCalculoParametro.Text = .Items(intIndice).SubItems(13).Text
                End With

                TxtEdicaoOrdem.Enabled = False

            End If

            If e.KeyChar <> Convert.ToChar(8) Then


                If Not (e.KeyChar >= "0" And e.KeyChar <= "9") Then
                    e.KeyChar = ""
                End If

            End If

        End With

    End Sub

    Private Function LimpaGruEdicaoDigitacao()

        TxtEdicaoOrdem.Text = ""
        TxtEdicaoVariavel.Text = ""
        TxtEdicaoDescricao.Text = ""
        TxtEdicaoQTO.Text = ""
        TxtEdicaoUN.Text = ""
        TxtEdicaovalor.Text = ""
        TxtEdicaoTipo.Text = Nothing
        TxtEdicaoBaseINSS.Text = Nothing
        TxtEdicaoBaseFGTS.Text = Nothing
        TxtEdicaoBaseIR.Text = Nothing
        TxtEdicaoDataOcorrencia.Text = ""
        TxtEdicaoHistorico.Text = ""
        LblCalculo.Text = ""
        LblCalculoParametro.Text = ""

        BtnNovo.Enabled = True
        BtnEditar.Enabled = True
        GruEdicaoDigitacao.Enabled = False
    End Function

    Private Sub frmFolhaLancVar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstData As List(Of Aponta) = ApontaAcoes.GetApontaDB()

        oi.title = Me.Text

        Dim strReferencia As String = lstData(0).Data

        strReferencia = strReferencia.Substring(4, 2) & "/" & strReferencia.Substring(0, 4)

        MskMesAno.Text = strReferencia



    End Sub

    Private Sub LvwEdicao_DoubleClick(sender As Object, e As EventArgs) Handles LvwEdicao.DoubleClick

        MsgBox(LvwEdicao.SelectedItems.ToString())

    End Sub

    Private Sub MskMesAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskMesAno.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            With oi
                .msg = "Termina a Operação?" & Chr(13) & Chr(13) & Chr(13)
                .msg += " - Se confirmar a página será fechada !"
                .style = vbYesNo
                .resposta = MsgBox(.msg, .style, .title)
                If .resposta = 6 Then Me.Close()
            End With

        End If

        If e.KeyChar = Convert.ToChar(13) Then

            LblMesAnoStatus.Text = ""
            LblColNome.Text = ""

            Dim strRefererencia As String = Trim(Replace(MskMesAno.Text, "/", ""))

            If strRefererencia = "" Then

                With oi

                    .msg = "Por favor, digite uma referência válida!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    MskMesAno.Focus()
                    Exit Sub

                End With

            Else
                Try

                    Dim detTest As Date = DateAdd("d", 1, "01/" & MskMesAno.Text)

                Catch ex As Exception
                    With oi

                        .msg = "referência Inválida!" & Chr(13) & Chr(13) & "Por favor, digite uma referência válida!"
                        .style = vbExclamation
                        MsgBox(.msg, .style, .title)
                        MskMesAno.Focus()
                        Exit Sub

                    End With

                End Try

                strRefererencia = strRefererencia.Substring(2) & strRefererencia.Substring(0, 2)

                If Not ApontaElementosSQL("diasuteiscab", "DUCabAnoMes", strRefererencia, False) Then

                    With oi

                        .Msg = "Descansos da referência " & MskMesAno.Text & " não foram gravados! "
                        .Msg += Chr(13) & Chr(13)
                        .Msg += "Peça ao responsável pelo registro para cadastrar "
                        .Msg += Chr(13) & Chr(13)
                        .Msg += "Menu: Cadastro.Folha de Pagamento.Referências.Descanso"
                        .Msg += Chr(13) & Chr(13)
                        .Msg += "Retorne ao sistema assim que autorizado"
                        .Title = Me.Text
                        .Style = vbExclamation
                        MsgBox(.Msg, .Style, .Title)

                        Exit Sub

                    End With

                End If


                Dim ref As List(Of ClassFolhaReferencia) = ClassFolhaReferenciaAcao.GetReferenciaDB(strRefererencia)

                If ref(0).encerramentoTeste = 0 Then
                    With oi

                        .msg = "Referência Não Autorizada!" & Chr(13) & Chr(13)
                        .msg += "Peça liberação da Referência ao Setor Responsável"
                        .style = vbExclamation
                        MsgBox(.msg, .style, .title)

                    End With

                    Exit Sub

                End If

                If ref(0).Encerramento <> 0 Then
                    With oi

                        .msg = "Referencia Encerrada !" & Chr(13) & Chr(13)
                        .msg += "Data de encerramento : " & dataLatina(ref(0).Encerramento) & Chr(13)
                        .msg += "Responsável : "
                        .style = vbExclamation
                        MsgBox(.msg, .style, .title)

                    End With

                    Exit Sub

                End If

                LblMesAnoStatus.Text = "P R O C E S S A M E N T O  - Aberto"
                MskColKey.Enabled = True
                MskColKey.Focus()
                MskMesAno.Enabled = False

            End If

        End If

    End Sub



    Private Sub BtnEdicao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnEdicao.KeyPress

        If e.KeyChar() = Convert.ToChar(27) Then

            MskColKey.Enabled = True
            MskColKey.Focus()
            BtnEdicao.Enabled = False

        End If
    End Sub
    Private Sub TxtEdicaoVariavel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdicaoVariavel.KeyPress

        ' BUSCAR VARIAVEL
        If e.KeyChar = Convert.ToChar(13) Then

            Dim strVariavel As String = TxtEdicaoVariavel.Text.PadLeft(4, "0")

            If Not FolVarCarregaEdicao(TxtEdicaoVariavel.Text) = strVariavel Then

                With oi
                    .msg = "Variável não cadastrada !"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    TxtEdicaoVariavel.Focus()
                    Exit Sub

                End With

            End If


        End If

    End Sub


    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        With oi
            .msg = "Termina o lançamentos de variáveis?"
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta = 6 Then Me.Close()

        End With


    End Sub

    Private Sub BtnEdicaoSai_Click(sender As Object, e As EventArgs) Handles BtnEdicaoSai.Click
        limpaGruEdicaoDigitacao()
        LvwEdicao.Items.Clear()
        MskColKey.Enabled = True
        BtnNovo.Enabled = False
        BtnEditar.Enabled = False
        BtnGravaEdicao.Enabled = False
        MskColKey.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GruOperacao.Enabled = True
        BtnNovo.Focus()
        limpaGruEdicaoDigitacao()

    End Sub

    Private Sub MskMesAno_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskMesAno.MaskInputRejected

    End Sub

    Private Sub MskColKey_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskColKey.MaskInputRejected

    End Sub
End Class