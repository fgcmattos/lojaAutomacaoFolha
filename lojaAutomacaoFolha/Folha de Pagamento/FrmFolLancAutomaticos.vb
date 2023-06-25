Imports MySql.Data.MySqlClient
Public Class FrmFolLancAutomaticos

    Public oi As New MsgShow

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs)

        Dim chave As String = ""
        Dim nome As String = ""
        Dim query As String = ""


        chave = Trim(TxtPesqChave.Text)
        nome = Trim(TxtPesqNome.Text)

        If chave = "" And nome = "" Then
            query = "select chave,colaboradorNome from colaborador order by colaboradorNome"
        ElseIf chave = "" And nome <> "" Then
            query = "Select chave,colaboradornome from colaborador where colaboradorNome like '" & "%" & nome & "%'" & " order by colaboradorNome"
        ElseIf chave <> "" And nome = "" Then
            query = "select chave,colaboradornome from colaborador where chave = " & chave
        End If

        If OpenDB() Then

            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    listBoxPesquisa.Items.Add(DTReader(0).ToString + " " + DTReader(1))

                End While

            Catch ex As Exception
                Conn.Close()
                oi.Msg = "Erro, leitura do Arquivo colaborador. (frmFolLancAutomaticos)"
                oi.Style = vbCritical

                Exit Sub
            End Try

            Conn.Close()
        End If

    End Sub

    Private Sub BtnPesquisa_Click_1(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        Dim chave As String = ""
        Dim nome As String = ""
        Dim situacao As String = ""
        Dim query As String = ""



        chave = Trim(TxtPesqChave.Text)
        nome = Trim(TxtPesqNome.Text)
        situacao = Trim(CmbSituacao.Text)



        If situacao.Length < 3 And situacao <> "" Then MsgBox("Código de situação errado!") : Exit Sub

        If situacao <> "" Then situacao = Trim(CmbSituacao.Text).Substring(0, 3)

        If situacao = "" Then
            If chave = "" And nome = "" Then
                query = "select chave,colaboradorNome,colaboradorStatus from colaborador order by colaboradorNome"
            ElseIf chave = "" And nome <> "" Then
                query = "Select chave,colaboradornome,colaboradorStatus from colaborador where colaboradorNome like '" & "%" & nome & "%'" & " order by colaboradorNome"
            ElseIf chave <> "" And nome = "" Then
                query = "select chave,colaboradornome,colaboradorStatus from colaborador where chave = " & chave
            End If
        Else

            If chave = "" And nome = "" Then
                query = "select chave,colaboradorNome,colaboradorStatus from colaborador where colaboradorStatus = '" & situacao & "' order by colaboradorNome"
            ElseIf chave = "" And nome <> "" Then
                query = "Select chave,colaboradornome,colaboradorStatus from colaborador where colaboradorNome like '" & "%" & nome & "%'" & " order by colaboradorNome"
            ElseIf chave <> "" And nome = "" Then
                query = "select chave,colaboradornome,colaboradorStatus from colaborador where chave = " & chave
            End If

        End If

        listBoxPesquisa.Items.Clear()

        If OpenDB() Then

            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    listBoxPesquisa.Items.Add(espacoEsquerda(DTReader(0).ToString, 5, 2) + " - " + espacoEsquerda(DTReader(1), 50, 1) + " - " + espacoEsquerda(DTReader(2), 30, 1))

                End While

            Catch ex As Exception
                Conn.Close()
                MsgBox("Problemas com a leitura do Arquivo")
                Exit Sub
            End Try

            Conn.Close()
        End If
    End Sub

    Private Sub frmFolLancAutomaticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        oi.Title = "Cadastro de Lançamentos Automaticos"

        Dim query As String = "SELECT status_cod,status_descricao FROM colaborador_status order by status_cod"
        If OpenDB() Then

            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    CmbSituacao.Items.Add(espacoEsquerda(DTReader(0).ToString, 5, 1) + " - " & DTReader(1))

                End While

            Catch ex As Exception
                Conn.Close()

                With oi

                    .Msg = "Erro. (frmFolLancAutomaticos_Load) "
                    .Style = vbCritical
                    MsgBox(oi.Msg, oi.Style, oi.Title)

                End With

                Exit Sub
            End Try

            Conn.Close()
        End If
    End Sub

    Private Sub BtmCancela_Click(sender As Object, e As EventArgs) Handles BtmCancela.Click
        GrpVariaveisPesquisa.Visible = False
        GrpVariavelExibicao.Visible = False
        GrpVariaveisModelo.Visible = False
        GrpExibicaoPesquisa.Visible = True
        GrpPainelPesquisa.Visible = True
        ListViewVariaveisModelo.Items.Clear()
        listBoxPesquisa.Focus()
    End Sub

    Private Sub listBoxPesquisa_DoubleClick(sender As Object, e As EventArgs) Handles listBoxPesquisa.DoubleClick

        Dim strLinhaPesquisa As String = listBoxPesquisa.SelectedItem()
        Dim strCodigoCol As String = Trim(strLinhaPesquisa.Substring(0, 5))
        LblColKey.Text = strCodigoCol
        GrpVariaveisPesquisa.Visible = True
        GrpVariavelExibicao.Visible = True
        GrpVariaveisModelo.Visible = True
        GrpExibicaoPesquisa.Visible = False
        GrpPainelPesquisa.Visible = False
        LabelColaborador.Text = strLinhaPesquisa.Substring(0, 59)



        TxtPesqVariavel.Focus()

        Dim Query As String
        Query = "SELECT FV_codigo, FV_nome,FV_UNIDADE,FV_baseINSS,FV_baseFGTS,FV_baseIR,FV_tipo_financeiro,FV_QTO,FV_Valor "
        Query += "FROM folha_variaveis_colaborador_auto where FV_Key_col = " + strCodigoCol + " order by FV_codigo ;"
        ListViewLancamentoVariaveis.Items.Clear()

        If OpenDB() Then

            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    With ListViewLancamentoVariaveis

                        .Items.Add(DTReader(0))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(1))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(2))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(3))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(4))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(5))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(6))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(7))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(8))
                        .Items(.Items.Count - 1).SubItems.Add("(L)")          ' STATUS DA VARIAVEL PARA O COLABORADOR

                    End With

                End While

            Catch ex As Exception
                Conn.Close()

                With oi

                    .Msg = "Erro. (frmFolLancAutomaticos_Load)- listBoxPesquisa_DoubleClick "
                    .Style = vbCritical
                    MsgBox(.Msg, .Style, .Title)

                End With

                Exit Sub
            End Try

            Conn.Close()
        End If
    End Sub

    Private Sub BtmPesqPesquisa_Click(sender As Object, e As EventArgs) Handles BtmPesqPesquisa.Click
        GrpVariavelExibicao.Visible = True
        'GrpVariavelExibicao.Location = New System.Drawing.Point(421, 1)

        Dim strLinhaPesquisa As String = listBoxPesquisa.SelectedItem()
        Dim strCodigoCol As String = Trim(strLinhaPesquisa.Substring(0, 5))
        GrpVariaveisPesquisa.Visible = True
        GrpVariavelExibicao.Visible = True
        GrpExibicaoPesquisa.Visible = False
        GrpPainelPesquisa.Visible = False
        LabelColaborador.Text = strLinhaPesquisa.Substring(0, 59)

        Dim intVariaveisJaLancadas As Integer = ListViewLancamentoVariaveis.Items.Count
        Dim strVariaveisJaLancadas As String = ""

        For i = 0 To intVariaveisJaLancadas - 1
            With ListViewLancamentoVariaveis

                If i = (intVariaveisJaLancadas - 1) Then

                    strVariaveisJaLancadas += "'" & .Items(i).Text & "'"

                Else

                    strVariaveisJaLancadas += "'" & .Items(i).Text & "'" & ","

                End If


            End With

        Next

        If strVariaveisJaLancadas <> "" Then
            strVariaveisJaLancadas = "FV_codigo not in(" & strVariaveisJaLancadas & ")"
        End If
        TxtPesqVariavel.Focus()

        Dim Query As String
        Query = "SELECT "
        Query += "FV_codigo"
        Query += ",FV_nome"
        Query += ",FV_UNIDADE"
        Query += ",FV_baseINSS"
        Query += ",FV_baseFGTS"
        Query += ",FV_baseIR"
        Query += ",FV_tipo_financeiro "
        Query += ",FV_QTO "
        Query += ",FV_valor "
        Query += "FROM folha_variaveis_modelo "

        Dim strPesquisaVariavel = TxtPesqVariavel.Text
        Dim strPesquisaDescricao = Trim(TxtPesqDescricao.Text)
        Dim strPesquisaGrupo = CmbPesqGrupo.Text

        If strPesquisaVariavel = "" Then
            If strPesquisaDescricao <> "" And strPesquisaGrupo = "" Then
                Query += " Where FV_nome like '%" & strPesquisaDescricao & "%' and "
            Else
                If strVariaveisJaLancadas <> "" Then
                    Query += " where "
                End If
            End If
        Else
            Query += " Where FV_codigo = '" & strPesquisaVariavel & "' and "
        End If

        Query += strVariaveisJaLancadas

        ListViewVariaveisModelo.Items.Clear()

        If OpenDB() Then

            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    With ListViewVariaveisModelo

                        .Items.Add(DTReader(0))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(1))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(2))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(3))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(4))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(5))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(6))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(7))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader(8))


                    End With

                End While

            Catch ex As Exception
                Conn.Close()


                With oi

                    .Msg = "Erro. (frmFolLancAutomaticos_Load) - BtmPesqPesquisa_Click "
                    .Style = vbCritical
                    MsgBox(oi.Msg, oi.Style, oi.Title)

                End With

                Exit Sub

            End Try

            Conn.Close()
        End If

    End Sub

    Private Sub ListViewVariaveisModelo_DoubleClick(sender As Object, e As EventArgs) Handles ListViewVariaveisModelo.DoubleClick

        Dim Indice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = ListViewVariaveisModelo.SelectedIndices

        Indice = lv.Item(0) ' indice selecionado no listview

        With ListViewLancamentoVariaveis

            .Items.Add(ListViewVariaveisModelo.Items(Indice).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(1).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(2).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(3).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(4).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(5).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(6).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(7).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewVariaveisModelo.Items(Indice).SubItems(8).Text)
            .Items(.Items.Count - 1).SubItems.Add("(D)")

        End With

        ListViewLancamentoVariaveis.Sorting = SortOrder.Ascending
        ListViewLancamentoVariaveis.Sorting = SortOrder.None
        ListViewVariaveisModelo.Items.RemoveAt(Indice)

        'ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).nome))


    End Sub

    Private Sub ListViewLancamentoVariaveis_DoubleClick(sender As Object, e As EventArgs) Handles ListViewLancamentoVariaveis.DoubleClick

        oi.Msg = "Confirma a retirada da variável?"
        oi.Style = vbYesNo
        If MsgBox(oi.Msg, oi.Style, oi.Title) <> 6 Then Exit Sub

        Dim Indice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = ListViewLancamentoVariaveis.SelectedIndices

        Indice = lv.Item(0) ' indice selecionado no listview

        With ListViewVariaveisModelo

            .Items.Add(ListViewLancamentoVariaveis.Items(Indice).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(1).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(2).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(3).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(4).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(5).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(6).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(7).Text)
            .Items(.Items.Count - 1).SubItems.Add(ListViewLancamentoVariaveis.Items(Indice).SubItems(8).Text)

        End With

        ListViewVariaveisModelo.Sorting = SortOrder.Ascending ' nao esta funcionando certo
        ListViewVariaveisModelo.Sorting = SortOrder.None

        'ListViewLancamentoVariaveis.Items.RemoveAt(Indice)

        If ListViewLancamentoVariaveis.Items(Indice).SubItems(9).Text = "(L)" Then

            ListViewLancamentoVariaveis.Items(Indice).SubItems(9).Text = "(-)"

        End If



    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim intIndice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = ListViewLancamentoVariaveis.SelectedIndices
        intIndice = lv.Item(0)

        With ListViewLancamentoVariaveis

            Label15.Text = .Items(intIndice).Text
            TxtEdiNome.Text = .Items(intIndice).SubItems(1).Text
            CmbEdiUnidade.Text = .Items(intIndice).SubItems(2).Text
            CmbEdiBaseINSS.Text = .Items(intIndice).SubItems(3).Text
            CmbEdiBaseFGTS.Text = .Items(intIndice).SubItems(4).Text
            CmbEdiBaseIR.Text = .Items(intIndice).SubItems(5).Text
            CmbEdiTipo.Text = .Items(intIndice).SubItems(6).Text
            MskEdiQTO.Text = .Items(intIndice).SubItems(7).Text
            MskEdiValor.Text = .Items(intIndice).SubItems(8).Text

        End With

        GruEdicao.Visible = True
        LblEdicaoIndice.Text = intIndice
        GrpVariaveisModelo.Visible = False
        LblDescricao.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
        LblDescricao.ForeColor = System.Drawing.Color.Maroon
        TxtEdiNome.Enabled = True
        TxtEdiNome.Focus()
    End Sub

    Private Sub BtnCancela_Click(sender As Object, e As EventArgs) Handles BtnCancela.Click
        GruEdicao.Visible = False
        GrpVariaveisModelo.Visible = True
    End Sub


    Private Sub TxtEdiNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdiNome.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then

            GruEdicao.Visible = False

            GrpVariaveisModelo.Visible = True

        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If TxtEdiNome.Text = "" Then
                oi.Msg = "Descrição de varivável inválida!"
                oi.Style = vbCritical
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub

            End If

            TxtEdiNome.Enabled = False
            LblDescricao.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblDescricao.ForeColor = System.Drawing.Color.Black

            LblUnidade.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblUnidade.ForeColor = System.Drawing.Color.Maroon
            LblDescricaoAponta.Visible = False
            LblUnidadeAponta.Visible = True
            CmbEdiUnidade.Enabled = True
            CmbEdiUnidade.Focus()

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub

    Private Sub CmbEdiUnidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdiUnidade.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            CmbEdiUnidade.Enabled = False
            LblUnidadeAponta.Visible = False
            LblUnidade.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblUnidade.ForeColor = System.Drawing.Color.Black

            LblDescricao.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblDescricao.ForeColor = System.Drawing.Color.Maroon
            LblDescricaoAponta.Visible = True
            TxtEdiNome.Enabled = True
            TxtEdiNome.Focus()


        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If CmbEdiUnidade.Text = "" Then
                oi.Msg = "Unidade de varivável inválida!"
                oi.Style = vbCritical
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub

            End If

            CmbEdiUnidade.Enabled = False
            LblUnidade.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblUnidade.ForeColor = System.Drawing.Color.Black

            LblBaseINSS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblBaseINSS.ForeColor = System.Drawing.Color.Maroon
            LblUnidadeAponta.Visible = False
            LblBaseINSSaponta.Visible = True
            CmbEdiBaseINSS.Enabled = True
            CmbEdiBaseINSS.Focus()

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub

    Private Sub CmbEdiBaseINSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdiBaseINSS.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            CmbEdiBaseINSS.Enabled = False
            LblBaseINSSaponta.Visible = False
            LblBaseINSS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblBaseINSS.ForeColor = System.Drawing.Color.Black

            LblUnidade.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblUnidade.ForeColor = System.Drawing.Color.Maroon
            LblUnidadeAponta.Visible = True
            CmbEdiUnidade.Enabled = True
            CmbEdiUnidade.Focus()


        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If CmbEdiBaseINSS.Text = "" Then
                oi.Msg = "Base de INSS inválida!"
                oi.Style = vbCritical
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub

            End If

            CmbEdiBaseINSS.Enabled = False
            LblBaseINSSaponta.Visible = False
            LblBaseINSS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblBaseINSS.ForeColor = System.Drawing.Color.Black

            LblBaseFGTS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblBaseFGTS.ForeColor = System.Drawing.Color.Maroon
            LblBaseFGTSaponta.Visible = True
            CmbEdiBaseFGTS.Enabled = True
            CmbEdiBaseFGTS.Focus()

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub

    Private Sub CmbEdiBaseFGTS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdiBaseFGTS.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            CmbEdiBaseFGTS.Enabled = False
            LblBaseIRaponta.Visible = False
            LblBaseFGTS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblBaseFGTS.ForeColor = System.Drawing.Color.Black

            LblBaseINSS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblBaseINSS.ForeColor = System.Drawing.Color.Maroon
            LblBaseINSSaponta.Visible = True
            CmbEdiBaseINSS.Enabled = True
            CmbEdiBaseINSS.Focus()


        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If CmbEdiBaseFGTS.Text = "" Then
                oi.Msg = "Base de FGTS inválida!"
                oi.Style = vbCritical
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub

            End If

            CmbEdiBaseFGTS.Enabled = False
            LblBaseFGTSaponta.Visible = False
            LblBaseFGTS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblBaseFGTS.ForeColor = System.Drawing.Color.Black

            LblBaseIR.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblBaseIR.ForeColor = System.Drawing.Color.Maroon
            LblBaseIRaponta.Visible = True
            CmbEdiBaseIR.Enabled = True
            CmbEdiBaseIR.Focus()

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub

    Private Sub CmbEdiBaseIR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdiBaseIR.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            CmbEdiBaseIR.Enabled = False
            LblBaseIRaponta.Visible = False
            LblBaseIR.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblBaseIR.ForeColor = System.Drawing.Color.Black

            LblBaseFGTS.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblBaseFGTS.ForeColor = System.Drawing.Color.Maroon
            LblBaseFGTSaponta.Visible = True
            CmbEdiBaseFGTS.Enabled = True
            CmbEdiBaseFGTS.Focus()


        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If CmbEdiBaseIR.Text = "" Then
                oi.Msg = "Base de FGTS inválida!"
                oi.Style = vbCritical
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub

            End If

            CmbEdiBaseIR.Enabled = False
            LblBaseIRaponta.Visible = False
            LblBaseIR.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblBaseIR.ForeColor = System.Drawing.Color.Black

            LblTipo.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblTipo.ForeColor = System.Drawing.Color.Maroon
            LblTipoAponta.Visible = True
            CmbEdiTipo.Enabled = True
            CmbEdiTipo.Focus()

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub

    Private Sub CmbEdiTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdiTipo.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            CmbEdiTipo.Enabled = False
            LblTipoAponta.Visible = False
            LblTipo.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblTipo.ForeColor = System.Drawing.Color.Black

            LblBaseIR.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblBaseIR.ForeColor = System.Drawing.Color.Maroon
            LblBaseIRaponta.Visible = True
            CmbEdiBaseIR.Enabled = True
            CmbEdiBaseIR.Focus()


        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If CmbEdiTipo.Text = "" Then
                oi.Msg = "Base de FGTS inválida!"
                oi.Style = vbCritical
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub

            End If

            CmbEdiTipo.Enabled = False
            LblTipoAponta.Visible = False
            LblTipo.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblTipo.ForeColor = System.Drawing.Color.Black

            LblQTO.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblQTO.ForeColor = System.Drawing.Color.Maroon
            LblQTOaponta.Visible = True
            MskEdiQTO.Enabled = True
            MskEdiQTO.Focus()

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub

    Private Sub MskEdiQTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskEdiQTO.KeyPress

        With MskEdiQTO


            If .Text = "" Then

                .Text = "0,00"

            End If

            If e.KeyChar = Convert.ToChar(27) Then

                MskEdiQTO.Enabled = False
                LblQTOaponta.Visible = False
                LblQTO.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                LblQTO.ForeColor = System.Drawing.Color.Black

                LblTipo.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                LblTipo.ForeColor = System.Drawing.Color.Maroon
                LblTipoAponta.Visible = True
                CmbEdiTipo.Enabled = True
                CmbEdiTipo.Focus()


            End If

            If e.KeyChar = Convert.ToChar(13) Then

                'MsgBox("Enter pressionado")


                MskEdiQTO.Enabled = False
                LblQTOaponta.Visible = False
                LblQTO.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                LblQTO.ForeColor = System.Drawing.Color.Black

                LblValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                LblValor.ForeColor = System.Drawing.Color.Maroon
                LblValoraponta.Visible = True
                MskEdiValor.Enabled = True
                MskEdiValor.Focus()

            Else

                e.KeyChar = UCase(e.KeyChar)

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


    Private Sub MskEdiValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskEdiValor.KeyPress

        Dim strMascarado As String = ""

        If MskEdiValor.Text = "" Then

            MskEdiValor.Text = "0,00"

        End If



        If e.KeyChar = Convert.ToChar(27) Then

            MskEdiValor.Enabled = False
            LblValoraponta.Visible = False
            LblValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblValor.ForeColor = System.Drawing.Color.Black

            LblQTO.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblQTO.ForeColor = System.Drawing.Color.Maroon
            LblQTOaponta.Visible = True
            MskEdiQTO.Enabled = True
            MskEdiQTO.Focus()



        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If MskEdiValor.Text = "" Then

                oi.Msg = "Base de FGTS inválida!"
                oi.Style = vbCritical
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub

            End If

            MskEdiValor.Enabled = False
            LblValoraponta.Visible = False
            LblValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            LblValor.ForeColor = System.Drawing.Color.Black

            BtnEdiGrava.BackColor = Color.Blue
            GruEdiGrava.Enabled = True
            BtnEdiGrava.Focus()

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
        If Asc(e.KeyChar) = 8 Then

            e.KeyChar = ""

            If MskEdiValor.Text = "0,00" Then Exit Sub
            If MskEdiValor.Text.Substring(0, 3) = "0,0" And MskEdiValor.Text.Length = 4 Then MskEdiValor.Text = "0,00" : SendKeys.Send("{END}") : Exit Sub
            If MskEdiValor.Text.Substring(0, 2) = "0," And MskEdiValor.Text.Length = 4 Then MskEdiValor.Text = "0,0" + MskEdiValor.Text.Substring(MskEdiValor.Text.Length - 2, 1) : SendKeys.Send("{END}") : Exit Sub
            If MskEdiValor.Text.Length = 4 Then MskEdiValor.Text = "0," + MskEdiValor.Text.Substring(0, 1) + MskEdiValor.Text.Substring(2, 1) : SendKeys.Send("{END}") : Exit Sub

            MskEdiValor.Text = MskEdiValor.Text.Substring(0, MskEdiValor.Text.Length - 1)
            Dim strSemMascara As String = Trim(Replace(Replace(MskEdiValor.Text, ",", ""), ".", ""))
            Dim intSemMascara As Integer = strSemMascara.Length


            MskEdiValor.Text = retMascara(intSemMascara, strSemMascara)
            SendKeys.Send("{END}")
            Exit Sub

        End If

        If e.KeyChar >= "0" And e.KeyChar <= "9" Then

            Dim strComMascara As String = Trim(MskEdiValor.Text)
            Dim strSemMascara As String = Trim(Replace(Replace(MskEdiValor.Text, ",", ""), ".", ""))
            Dim intSemMascara As Integer = strSemMascara.Length
            Dim strRetorno As String = ""
            'strMascarado = Trim(StrDup(18 - (strMascarado.Length - 1), " ") + strMascarado.Substring(2) + e.KeyChar)
            'strSemMascara += e.KeyChar


            If intSemMascara < 4 And strSemMascara.Substring(0, 1) = "0" Then

                strSemMascara += e.KeyChar
                strSemMascara = strSemMascara.Substring(1)

            Else

                strSemMascara += e.KeyChar
                intSemMascara += 1

            End If



            If intSemMascara < 4 Then

                strRetorno = strSemMascara.Substring(0, 1) + "," + strSemMascara.Substring(1)

            ElseIf intSemMascara >= 4 And intSemMascara < 6 Then

                strRetorno = strSemMascara.Substring(0, intSemMascara - 2) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

            ElseIf intSemMascara >= 6 And intSemMascara < 9 Then

                strRetorno = strSemMascara.Substring(0, intSemMascara - 5) + "." + strSemMascara.Substring(intSemMascara - 5, 3) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

            ElseIf intSemMascara >= 9 And intSemMascara < 12 Then

                strRetorno = strSemMascara.Substring(0, intSemMascara - 8) + "." + strSemMascara.Substring(intSemMascara - 8, 3) + "." + strSemMascara.Substring(intSemMascara - 5, 3) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

            ElseIf intSemMascara >= 12 And intSemMascara < 15 Then

                strRetorno = strSemMascara.Substring(0, intSemMascara - 11) + "." + strSemMascara.Substring(intSemMascara - 11, 3) + "." + strSemMascara.Substring(intSemMascara - 8, 3) + "." + strSemMascara.Substring(intSemMascara - 5, 3) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

            End If

            If intSemMascara < 14 Then

                MskEdiValor.Text = strRetorno

                SendKeys.Send("{END}")

            End If

            e.KeyChar = ""

        Else

            e.KeyChar = ""

            MskEdiValor.Focus()


            'My.Computer.Keyboard.SendKeys("", True)


        End If
    End Sub

    Private Sub BtnEdiGrava_Click(sender As Object, e As EventArgs) Handles BtnEdiGrava.Click

        Dim intIndice As Integer = Int(LblEdicaoIndice.Text)

        If Not lvwLancEdicao(intIndice) Then

            With oi

                .Msg = "Não foram realidas alterações!"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)

            End With

        Else

            If ListViewLancamentoVariaveis.Items(intIndice).SubItems(9).Text = "(A)" Or ListViewLancamentoVariaveis.Items(intIndice).SubItems(9).Text = "(L)" Then

                ListViewLancamentoVariaveis.Items(intIndice).SubItems(9).Text = "(A)"

            End If

        End If


        BtnEdiGrava.BackColor = Color.Gray
        GruEdiGrava.Enabled = False
        GrpVariaveisModelo.Visible = True
        GruEdiGrava.Enabled = False
        GruEdicao.Visible = False

    End Sub

    Private Function lvwLancEdicao(intIndice As Integer) As Boolean

        Dim booAlteracao As Boolean = False

        With ListViewLancamentoVariaveis

            .Items(intIndice).Text = Label15.Text

            If .Items(intIndice).SubItems(1).Text <> TxtEdiNome.Text Then

                .Items(intIndice).SubItems(1).Text = TxtEdiNome.Text

                booAlteracao = True

            End If

            If .Items(intIndice).SubItems(2).Text <> CmbEdiUnidade.Text Then

                .Items(intIndice).SubItems(2).Text = CmbEdiUnidade.Text

                booAlteracao = True

            End If

            If .Items(intIndice).SubItems(3).Text <> CmbEdiBaseINSS.Text Then

                .Items(intIndice).SubItems(3).Text = CmbEdiBaseINSS.Text

                booAlteracao = True

            End If

            If .Items(intIndice).SubItems(4).Text <> CmbEdiBaseFGTS.Text Then

                .Items(intIndice).SubItems(4).Text = CmbEdiBaseFGTS.Text

                booAlteracao = True

            End If

            If .Items(intIndice).SubItems(5).Text <> CmbEdiBaseIR.Text Then

                .Items(intIndice).SubItems(5).Text = CmbEdiBaseIR.Text

                booAlteracao = True

            End If

            If .Items(intIndice).SubItems(6).Text <> CmbEdiTipo.Text Then

                .Items(intIndice).SubItems(6).Text = CmbEdiTipo.Text

                booAlteracao = True

            End If

            If .Items(intIndice).SubItems(7).Text <> MskEdiQTO.Text Then

                .Items(intIndice).SubItems(7).Text = MskEdiQTO.Text

                booAlteracao = True

            End If

            If .Items(intIndice).SubItems(8).Text <> MskEdiValor.Text Then

                .Items(intIndice).SubItems(8).Text = MskEdiValor.Text

                booAlteracao = True

            End If

        End With

        Return booAlteracao

    End Function

    Private Sub BtnEdiGrava_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnEdiGrava.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then
            MskEdiValor.Enabled = True
            LblValoraponta.Visible = True
            LblValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            LblValor.ForeColor = System.Drawing.Color.Maroon

            BtnEdiGrava.BackColor = Color.Gray
            GruEdiGrava.Enabled = False
            MskEdiValor.Focus()
        End If

    End Sub

    Private Sub MskEdiValor_GotFocus(sender As Object, e As EventArgs) Handles MskEdiValor.GotFocus
        SendKeys.Send("{END}")
    End Sub

    Private Sub BtnGravaLancamento_Click(sender As Object, e As EventArgs) Handles BtnGravaLancamento.Click


        Dim query As String = ""
        Dim cmdQuery As String = ""
        Dim inIcrementa As Integer
        Dim inAltera As Integer

        Dim indice As Integer = 0
        Dim strQTO As String
        Dim strValor As String



        For indice = 0 To (ListViewLancamentoVariaveis.Items.Count - 1)

            If ListViewLancamentoVariaveis.Items(indice).SubItems(9).Text <> "(L)" Then


                '(A) - Altera
                '(D) - IncrementaDim CMD As New MySqlCommand(query, Conn)
                '(-) - Apaga

                strQTO = Replace(Replace(ListViewLancamentoVariaveis.Items(indice).SubItems(7).Text, ".", ""), ",", ".")
                strValor = Replace(Replace(ListViewLancamentoVariaveis.Items(indice).SubItems(8).Text, ".", ""), ",", ".")

                Select Case ListViewLancamentoVariaveis.Items(indice).SubItems(9).Text

                    Case "(A)"

                        query = "Update folha_variaveis_colaborador_auto set "
                        query += "FV_codigo ='" + ListViewLancamentoVariaveis.Items(indice).Text + "'"                  'variavel
                        query += ",FV_nome ='" + ListViewLancamentoVariaveis.Items(indice).SubItems(1).Text + "'"       'descricao
                        query += ",FV_baseINSS='" + ListViewLancamentoVariaveis.Items(indice).SubItems(3).Text + "'"    'baseINSS
                        query += ",FV_baseFGTS='" '" + ListViewLancamentoVariaveis.Items(indice).SubItems(4).Text + "'"  'baseFGTS
                        query += ",FV_baseIR='" + ListViewLancamentoVariaveis.Items(indice).SubItems(5).Text + "'"      'baseIR
                        query += ",FV_UNIDADE ='" + ListViewLancamentoVariaveis.Items(indice).SubItems(2).Text + "'"    'unidade
                        query += ",FV_tipo_financeiro = '" + ListViewLancamentoVariaveis.Items(indice).SubItems(6).Text + "'" 'tipo
                        query += ",FV_key_col = " + LblColKey.Text                                                            'colKey
                        query += ",FV_QTO = " + strQTO
                        query += ",FV_valor=" + strValor
                        query += " where FV_key_col = " & LblColKey.Text
                        query += " and FV_codigo = '" & ListViewLancamentoVariaveis.Items(indice).Text + "';"


                    Case "(D)"

                        query = "Insert into folha_variaveis_colaborador_auto "
                        query += "("
                        query += "FV_codigo"
                        query += ",FV_nome"
                        query += ",FV_baseINSS"
                        query += ",FV_baseFGTS"
                        query += ",FV_baseIR"
                        query += ",FV_UNIDADE"
                        query += ",FV_tipo_financeiro"
                        query += ",FV_key_col"
                        query += ",FV_QTO"
                        query += ",FV_valor"
                        query += ")"
                        query += " values "
                        query += "("
                        query += "'" + ListViewLancamentoVariaveis.Items(indice).Text + "'"                     'variavel
                        query += ",'" + ListViewLancamentoVariaveis.Items(indice).SubItems(1).Text + "'"        'descricao
                        query += ",'" + ListViewLancamentoVariaveis.Items(indice).SubItems(3).Text + "'"        'baseINSS
                        query += ",'" + ListViewLancamentoVariaveis.Items(indice).SubItems(4).Text + "'"        'baseFGTS
                        query += ",'" + ListViewLancamentoVariaveis.Items(indice).SubItems(5).Text + "'"        'baseIR
                        query += ",'" + ListViewLancamentoVariaveis.Items(indice).SubItems(2).Text + "'"        'unidade
                        query += ",'" + ListViewLancamentoVariaveis.Items(indice).SubItems(6).Text + "'"        'tipo
                        query += "," + LblColKey.Text                                                           'colKey
                        query += "," + strQTO                                                                   'QTO
                        query += "," + strValor                                                                 'valor
                        query += ");"

                    Case "(-)"

                        query = "Delete from folha_variaveis_colaborador_auto "
                        query += " where FV_key_col = " & LblColKey.Text
                        query += " and FV_codigo = '" & ListViewLancamentoVariaveis.Items(indice).Text + "';"

                End Select
                cmdQuery += query
            End If
        Next

        Dim CMD As New MySqlCommand(cmdQuery, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()

            Catch ex As Exception
                'Conn.Close()


                With oi

                    .Msg = "Erro. (frmFolLancAutomaticos_Load) - BtmPesqPesquisa_Click "
                    .Style = vbCritical
                    MsgBox(oi.Msg, oi.Style, oi.Title)
                    Conn.Close()
                End With
            End Try
            Conn.Close()

        End If
        oi.Msg = "Registros Alterados: " & inAltera & Chr(13) & "Registros Novos: " & inIcrementa
        oi.Style = vbExclamation
        MsgBox(oi.Msg, oi.Style, oi.Title)
    End Sub



    Private Sub MskEdiQTO_GotFocus(sender As Object, e As EventArgs) Handles MskEdiQTO.GotFocus
        SendKeys.Send("{END}")
    End Sub

    Private Sub MskEdiValor_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskEdiValor.MaskInputRejected

    End Sub

    Private Sub ListViewVariaveisModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewVariaveisModelo.SelectedIndexChanged

    End Sub

    Private Sub listBoxPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxPesquisa.SelectedIndexChanged

    End Sub

    Private Sub listBoxPesquisa_MouseClick(sender As Object, e As MouseEventArgs) Handles listBoxPesquisa.MouseClick

    End Sub
End Class