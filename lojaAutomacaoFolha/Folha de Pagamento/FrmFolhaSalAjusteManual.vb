Imports MySql.Data.MySqlClient
Public Class FrmFolhaSalAjusteManual
    Dim oi As New MsgShow
    Private Function colBuscaRemuneracao(KeyCol As Integer) As Boolean

        Dim strRetorno As Boolean = False

        Dim query As String = ""

        query += "Select "
        query += "FR.idFR"
        query += ",FR.FR_tipo "
        query += ",FR.FR_fato "
        query += ",FR.FR_cargo "
        query += ",FR_evolucao_rendimento * 100 "
        query += ",FR.FR_valor "
        query += ",FR.FR_data_entrada "
        query += ",if(isnull(FR.FR_data_saida),'',FR.FR_data_saida)"
        query += ",if(isnull(FR.FR_historico_saida),'',FR.FR_historico_saida)"
        query += ",if(isnull(FR.FR_cargo_tempo),'',FR.FR_cargo_tempo)"
        query += ",col.colaboradorSalarioAtual "
        query += ",col.colaboradorNome "
        query += ",col.colaboradorCPF "
        query += ",FR.idFR "
        query += ",col.colaboradorRG  "

        query += " From colaborador col, folha_rendimentos  FR "
        query += " Where "
        query += " col.chave = " + KeyCol.ToString
        query += " And colaboradorStatus = '100' "
        query += " And FR.FR_KeyCol = col.chave "
        query += " order by  FR.FR_data_entrada desc "




        LblUltimaMovimentacao.Text = ""
        If OpenDB() Then
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader
                With LswRemEvol
                    .Items.Clear()
                    Dim strRegistro As String = ""
                    While DTReader.Read()

                        strRegistro = DTReader.GetValue(0)
                        strRegistro = strRegistro.PadLeft(4, "0")
                        .Items.Add(strRegistro)
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(1))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(2))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(3))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(4))
                        .Items(.Items.Count - 1).SubItems.Add(MoneyLatino(DTReader.GetValue(5)))
                        .Items(.Items.Count - 1).SubItems.Add(dataLatina(DTReader.GetValue(6)))
                        .Items(.Items.Count - 1).SubItems.Add(IIf(DTReader.GetValue(7) = "", "", (dataLatina(DTReader.GetValue(7)))))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(8))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(9))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(10))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(11))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(12))

                        LblPesqColNome.Text = DTReader.GetValue(11)
                        LblSalarioAtualValor.Text = MoneyLatino(DTReader.GetValue(10))
                        lblCPF.Text = DTReader.GetValue(12)
                        If LblUltimaMovimentacao.Text = "" Then
                            LblUltimaMovimentacao.Text = dataLatina(DTReader.GetValue(6))
                            LblUltimaMovimentacaoReg.Text = DTReader.GetValue(13)
                            LblRG.Text = DTReader.GetValue(14)
                        End If
                        strRetorno = True
                    End While
                End With



            Catch ex As Exception
                MsgBox("Problemas Na Pesquisa !")
            End Try

            Conn.Close()

        End If


        Return strRetorno

    End Function

    Private Sub MskColPesq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskColPesq.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            Dim strKeyCol As String = Trim(MskColPesq.Text)

            grupoPesquisaEdicao()
            grupoEddicaoDeRendimentosLimpar()

            '''''Imagem default
            Dim rotaFora As String = "C:\" & Form1.EmpCNPJ.Text & "\folha\imagens\naoAutorizado.jpg"

            If System.IO.File.Exists(rotaFora) Then

                Me.PictureBox1.Image = Image.FromFile(rotaFora)

            End If
            '''''''' fim da imagem Default


            If strKeyCol = "" Then

                With oi

                    .msg = "Por favor, digite um número válido de colaborador."
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub

                End With

            End If

            Dim inkeyCol As Integer = Int(strKeyCol)

            If Not apontaElementosSQL("colaborador", "chave", inkeyCol, True) Then
                ''''''''''''''''''''''Conteudo para pesquisa - tabela - campo da pesquisa - Se e numerico ou string
                With oi

                    .msg = "Colaborador Nao encontrado nos registros"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub

                End With

            End If

            If Not colBuscaRemuneracao(inkeyCol) Then

                'Dim rota As String = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & lblCPF.Text & "\Foto\Cracha\Cracha.jpg"

                LblCPFtela.Text = CPFcolocaMascara(lblCPF.Text)

                'If System.IO.File.Exists(rota) Then

                '    Me.PictureBox1.Image = Image.FromFile(rota)
                'Else
                '    Me.PictureBox1.Image = Image.FromFile(rota)
                'End If

                With oi

                    .msg = "Colaborador sem registro de salário!" & Chr(13) & "Inicia cadastramento ?"
                    .style = vbYesNo
                    .resposta = MsgBox(.msg, .style, .title)

                    If .resposta = 6 Then

                        BtnAbreEdicao.Enabled = True

                        MsgBox("inicia cadastramento")

                    End If

                    Exit Sub

                End With

            End If



            Dim caminho As String = ""
            Dim boArquivo As Boolean = True

            Dim inX, inY As Integer
            inX = 358 - (LblPesqColNome.Size.Width / 2)
            inY = 205

            Me.LblPesqColNome.Location = New System.Drawing.Point(inX, inY)

            caminho = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & lblCPF.Text & "\Foto\Cracha\Cracha.jpg"

            LblCPFtela.Text = CPFcolocaMascara(lblCPF.Text)

            If Not System.IO.File.Exists(caminho) Then

                boArquivo = False

            End If

            If boArquivo Then

                Me.PictureBox1.Image = Image.FromFile(caminho)

            End If

            BtnAbreEdicao.Enabled = True

        End If

    End Sub
    Private Function grupoPesquisaEdicao()

        BtnAbreEdicao.Enabled = False
        LblUltimaMovimentacao.Text = ""
        LblUltimaMovimentacaoReg.Text = ""
        LblPesqColNome.Text = ""
        LblSalarioAtualValor.Text = ""
        LblRG.Text = ""
    End Function

    Private Sub BtnAbreEdicao_Click(sender As Object, e As EventArgs) Handles BtnAbreEdicao.Click
        GroupBox2.Enabled = True
        GruEdicao.Enabled = True
        GruColPesq.Enabled = False
        LblEdicaoSalAtualValor.Text = LblSalarioAtualValor.Text
        MskEdicaoNovoSalario.Enabled = True
        MskEdicaoNovoSalario.Focus()


    End Sub

    Private Sub MskEdicaoNovoSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskEdicaoNovoSalario.KeyPress
        With MskEdicaoNovoSalario

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
                If MskEdicaoNovoSalario.Text = "0,00" Then

                    With oi

                        .msg = "Valor inválido!" & Chr(13) & Chr(13) & "Por favor, refaça com um valor válido"
                        .style = vbExclamation
                        MsgBox(.msg, .style, .title)

                        Exit Sub

                    End With

                End If
                ' determinando a porcentagem de acrescimo
                Dim deSalAntigo As Decimal = Convert.ToDecimal(LblEdicaoSalAtualValor.Text)

                Dim deSalNovo As Decimal = Convert.ToDecimal(MskEdicaoNovoSalario.Text)

                Dim dePorcentagem As Decimal = Int((((deSalNovo / deSalAntigo) - 1) * 100) * 100) / 100

                TxtEdicaoVariacao.Text = Convert.ToString(dePorcentagem)

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

    Private Sub CheckedListBox1_Click(sender As Object, e As EventArgs) Handles CheckedListBox1.Click
        If Not CheckedListBox1.GetItemChecked(0) Then

            'MsgBox("PRESSIONADO")
            GruVriacao.Enabled = True
            TxtEdicaoVariacao.Focus()

        Else
            'MsgBox("DESLIGADO")
            GruVriacao.Enabled = False
            MskEdicaoNovoSalario.Focus()
        End If
    End Sub

    Private Sub CheckedListBox1_GotFocus(sender As Object, e As EventArgs) Handles CheckedListBox1.GotFocus

        If Not CheckedListBox1.GetItemChecked(0) Then

            'MsgBox("PRESSIONADO")
            GruVriacao.Enabled = True
            'TxtEdicaoVariacao.Focus()

        Else
            'MsgBox("DESLIGADO")
            GruVriacao.Enabled = False
            'MskEdicaoNovoSalario.Focus()
        End If

    End Sub

    Private Sub MskEdicaoNovoSalario_GotFocus(sender As Object, e As EventArgs) Handles MskEdicaoNovoSalario.GotFocus

        SendKeys.Send("{END}")

    End Sub

    Private Sub TxtEdicaoVariacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdicaoVariacao.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            ' determinando o valor do Novo salario pela  porcentagem de acrescimo
            Dim deSalAntigo As Decimal = Convert.ToDecimal(LblEdicaoSalAtualValor.Text)

            Dim dePorcentagem As Decimal = Convert.ToDecimal(Replace(TxtEdicaoVariacao.Text, ".", ","))

            Dim deSalarioNovo As Decimal = Int(((deSalAntigo * (1 + (dePorcentagem / 100))) * 100)) / 100

            MskEdicaoNovoSalario.Text = MoneyLatino(deSalarioNovo)

        End If


    End Sub

    Private Sub BtnEdicaoCancela_Click(sender As Object, e As EventArgs) Handles BtnEdicaoCancela.Click

        GruColPesq.Enabled = True
        MskColPesq.Focus()
        GroupBox2.Enabled = False

    End Sub

    Private Sub MskEdicaoData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskEdicaoData.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            Dim dtData As Date                                          'criado apenas para teste de data
            Dim strData_teste As String = Trim(Replace(MskEdicaoData.Text, "/", ""))
            If Len(strData_teste) < 8 Then

                With oi
                    .msg = "Data digitada não foi reconhecida como válida ! " & Chr(13) & Chr(13) & " Por Favor, corrija."
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub
                End With

            End If


            Try

                dtData = Convert.ToDateTime(MskEdicaoData.Text)

            Catch ex As Exception

                With oi
                    .msg = "Data digitada não foi reconhecida como válida ! " & Chr(13) & Chr(13) & " Por Favor, corrija."
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                End With

                Exit Sub
            End Try
            Dim strData As String = dataAAAAMMDD(MskEdicaoData.Text)

            Dim momento As List(Of Aponta) = ApontaAcoes.GetApontaDB

            Dim strDataHoje As String = momento(0).Data



            If strDataHoje > strData Then

                If strDataHoje.Substring(0, 6) <> strData.Substring(0, 6) Then

                    'DateDiff("m", dtDataParaCalculoDeAnos, data2)


                    With oi

                        .msg = "Data digitada antes da referência ." & Chr(13) & Chr(13) & "Por favor,Entre com uma data válida."
                        .style = vbExclamation
                        MsgBox(.msg, .style, .title)
                        Exit Sub

                    End With

                End If

            End If

            End If

    End Sub
    Private Function grupoEddicaoDeRendimentosLimpar()

        'CheckedListBox1.GetItemChecked(0).ge = False
        TxtEdicaoVariacao.Text = ""
        MskEdicaoNovoSalario.Text = ""
        CmbEdicaoFato.Text = ""
        CmbEdicaoCargo.Text = ""
        TxtEdicaoHistorico.Text = ""

    End Function
    Private Sub FrmFolhaSalAjusteManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        variaveisAuxiliaresInvisiveis()
        oi.title = Me.Text
        Dim ref As List(Of Aponta) = ApontaAcoes.GetApontaDB

        LblReferencia.Text = ref(0).Data.Substring(4, 2) & "/" & ref(0).Data.Substring(0, 4)

    End Sub
    Private Function VariaveisAuxiliaresInvisiveis()

        LblUltimaMovimentacao.Visible = False
        LblUltimaMovimentacaoReg.Visible = False
        lblCPF.Visible = False

    End Function


    Private Sub CmbEdicaoFato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdicaoFato.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If CmbEdicaoFato.Text = "" Then
                With oi
                    .msg = "Campo digitado não foi reconhecido como válido ! " & Chr(13) & Chr(13) & " Por Favor, escolha uma das opções válidas."
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub
                End With

            End If

        End If
    End Sub
    Private Sub CmbEdicaoCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdicaoCargo.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If CmbEdicaoCargo.Text = "" Then

                With oi
                    .msg = "Campo digitado não foi reconhecido como válido ! " & Chr(13) & Chr(13) & " Por Favor, escolha uma das opções válidas."
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub
                End With

            End If

        End If
    End Sub

    Private Sub BtnEdicaoGrava_Click(sender As Object, e As EventArgs) Handles BtnEdicaoGrava.Click

        Dim strVariacao As String = TxtEdicaoVariacao.Text

        strVariacao = Replace(Convert.ToString(Convert.ToDecimal(Trim(Replace(strVariacao, ".", ","))) / 100), ",", ".")


        'Preparando variaveis para a gravacao
        Dim strSalAtualValor As String = LblEdicaoSalAtualValor.Text
        Dim strNovoSalario As String = MskEdicaoNovoSalario.Text
        Dim strDataAtivacao As String = MskEdicaoData.Text
        Dim strFato As String = CmbEdicaoFato.Text
        Dim strTipo As String = "1"
        Dim strCargo As String = CmbEdicaoCargo.Text
        Dim strHistorico As String = TxtEdicaoHistorico.Text
        Dim booFirst As Boolean = True

        Dim strTempoCargo As String = 0

        If LswRemEvol.Items.Count = 0 Then

            strTempoCargo = "0"

        Else

            booFirst = False
            strTempoCargo = TempoEntreDatas(Convert.ToDateTime(LblUltimaMovimentacao.Text), Convert.ToDateTime(strDataAtivacao))

        End If


        With oi
            .msg = "Campos que serão alterados " & Chr(13) & Chr(13) & Chr(13)
            .msg = "Salário Atual---- : " & strSalAtualValor & Chr(13)
            .msg += "Salário Novo---- : " & strNovoSalario & Chr(13)
            .msg += "Data da Ativação : " & strDataAtivacao & Chr(13)
            .msg += "Fato------------ : " & strFato & Chr(13)
            .msg += "Cargo----------- : " & strCargo & Chr(13)
            .msg += "Histórico------- : " & strHistorico
            .style = vbYesNo

            .resposta = MsgBox(.msg, .style, .title)

            If .resposta = 6 Then

                strNovoSalario = MoneyUSA(strNovoSalario)
                strDataAtivacao = dataAAAAMMDD(strDataAtivacao)

                Dim strKeyCol As String = MskColPesq.Text

                Dim query As String = ""
                'inseri registro de novo salario
                query += "insert into folha_rendimentos "
                query += "("
                query += "FR_keyCol"                  '= MskColPesq.Text
                query += ",FR_valor "
                query += ",FR_data_entrada"
                query += ",FR_usuario_responsavel"
                query += ",FR_historico_saida"        'tamanho 100
                query += ",FR_fato"                   'tamanho 45
                query += ",FR_tipo"                   'varchar(20) 
                query += ",FR_cargo"                  'varchar(30) 
                query += ",FR_cargo_tempo"            'varchar(20) 
                query += ",FR_evolucao_rendimento"    '10
                query += ")"
                query += " values "
                query += "("
                query += strKeyCol
                query += "," & strNovoSalario
                query += ",'" & strDataAtivacao & "'"
                query += "," & Form1.Form1Chave.Text                 'Usuario
                query += ",'" & strHistorico & "'"
                query += ",'" & strFato & "'"
                query += "," & strTipo
                query += ",'" & strCargo & "'"
                query += ",'" & strTempoCargo & "'"
                query += "," & strVariacao
                query += ");"
                gravaSQL(query)
                query = ""


                'atualiza registro antigo de salario
                If booFirst Then
                    query += "update folha_rendimentos set "
                    query += "FR_historico_saida = '" & strDataAtivacao & "'"
                    query += " where idFR = " & LblUltimaMovimentacaoReg.Text
                    query += ";"

                    gravaSQL(query)
                    query = ""

                End If

                'atualiza tabela colaborador
                query += "update colaborador set "
                query += "colaboradorSalarioAtual = '" & strNovoSalario & "'"
                query += " where chave = " & MskColPesq.Text
                query += ";"

                gravaSQL(query)

            Else
                MsgBox("Desistiu")
            End If

        End With


    End Sub

    Private Sub MskColPesq_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskColPesq.MaskInputRejected

    End Sub
End Class