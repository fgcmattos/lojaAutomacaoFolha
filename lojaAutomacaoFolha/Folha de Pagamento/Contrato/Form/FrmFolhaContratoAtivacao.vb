Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class FrmFolhaContratoAtivacao

    Dim oi As New MsgShow

    Private Sub MskChavePesq_Validated(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MskChave_Pesq.Validating
        Dim input As String = MskChave_Pesq.Text

        If input.Length = 0 Then Exit Sub

        If input.Length < 2 Then
            ' Se o valor digitado for menor que 2 caracteres, está incorreto
            e.Cancel = True
            MessageBox.Show("A entrada deve ter dois caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MskChave_Pesq.Focus()

        ElseIf Not Char.IsLetter(input(0)) Or Not Char.IsDigit(input(1)) Then
            ' Se o primeiro caractere não for uma letra ou o segundo caractere não for um dígito, está incorreto
            e.Cancel = True
            MessageBox.Show("A entrada deve começar com uma letra seguida de 3 dígitos numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MskChave_Pesq.Focus()
            Exit Sub

        End If

        MskChave_Pesq.Text = MskChave_Pesq.Text.Substring(0, 1) & MskChave_Pesq.Text.Replace(" ", "").Substring(1).PadLeft(4, "0"c)

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        listviewCarega()

        'Dim StrChave As String = MskChavePesq.Text.Replace(" ", "")
        'Dim StrNome As String = TxtNome.Text.Replace(" ", "")
        'Dim strCPF As String = CPFretiraMascara(MskCPF_Pesq.Text).Replace(" ", "")

        'GroupBox2.Text = "Colaboradores com Inatividade Para Contrato de Trabalho"
        'ListView1.Items.Clear()

        'Dim Query As String

        'Query = "SELECT "
        'Query += "colaborador.chave"
        'Query += ",colaboradorNome"
        'Query += ",colaboradorcpf"
        'Query += ",if(colaboradorContratoAtivo,'ATIVO','INATIVO') as colaboradorContratoAtivo"
        'Query += ",IF("
        'Query += "(SELECT COUNT(*) FROM folha_col_contrato WHERE colaborador.chave = FCC_keyCol GROUP BY FCC_keyCol) IS NULL,0,"
        'Query += "(SELECT COUNT(*) FROM folha_col_contrato WHERE colaborador.chave = FCC_keyCol GROUP BY FCC_keyCol)) AS QTO_contratos"
        'Query += ",IFNULL("
        'Query += "DATE_FORMAT("
        'Query += "("
        'Query += "SELECT t1.FCC_afastamento_data"
        'Query += " FROM folha_col_contrato t1"
        'Query += " WHERE t1.FCC_afastamento_data = ("
        'Query += "SELECT MAX(t2.FCC_afastamento_data)"
        'Query += " FROM folha_col_contrato t2"
        'Query += " WHERE t1.FCC_keyCol = t2.FCC_keyCol"
        'Query += ")"
        'Query += ")"
        'Query += ",'%d/%m/%Y')"
        'Query += ",'__/__/____'"
        'Query += ") AS ultimo_afastamento_data"
        'Query += ",ifnull(colaboradorOBS,'')"
        'Query += " FROM colaborador"
        'Query += " Where "
        'Query += " not colaboradorContratoAtivo;"


        'Dim CMD As New MySqlCommand(Query, Conn)
        'Dim DTReader As MySqlDataReader
        'If OpenDB() Then
        '    Try
        '        DTReader = CMD.ExecuteReader

        '        While DTReader.Read()

        '            ListView1.Items.Add(DTReader(0))                                                                ' Chave
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(1))                            ' Colaborador
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(DTReader(2)))          ' CPF
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(3))                            ' Status
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(4))                            ' QTO de contratos
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(5))                            ' Última data de contração
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(6))                            ' OBS

        '        End While

        '        GroupBox2.Text = "Colaboradores com Inatividade Para Contrato de Trabalho [" & ListView1.Items.Count & "]"

        '    Catch ex As Exception

        '        MsgBox(ex.Message)

        '    End Try

        '    Conn.Close()

        'End If

    End Sub

    Private Sub BtnLiberacao_Click(sender As Object, e As EventArgs) Handles BtnLiberacao.Click

        Dim list As New List(Of String)()
        oi.Msg = ""

        For Each item As ListViewItem In ListView1.Items
            If item.Checked Then
                Dim textoItem As String = item.SubItems(1).Text
                'Console.WriteLine($"Item selecionado: {textoItem}")
                oi.Msg += $"Item selecionado: {textoItem}" & Chr(13)
                list.Add(item.Text)
            End If

        Next item

        If oi.Msg = "" Then
            oi.Msg = " Nenhum elemento foi selecionado" & Chr(13)
            oi.Msg += "Continua a seleção"
            oi.Style = vbYesNo + vbDefaultButton1
            If MsgBox(oi.Msg, oi.Style, oi.Title) <> 6 Then

                Me.Close()
                Exit Sub

            Else

                Exit Sub

            End If

        End If

        oi.Style = vbYesNo + vbDefaultButton1
        If MsgBox(oi.Msg, oi.Style, oi.Title) = 6 Then

            'MsgBox("Vai para as cabeças")

            Dim Query As String
            Query = "Update colaborador "
            Query += "set colaboradorContratoAtivo = True"
            Query += " Where "
            Query += "Chave in "
            Query += "("

            For i As Integer = 0 To list.Count - 1

                Query += list(i)

                If i < list.Count - 1 Then

                    Query += ","

                End If

            Next

            Query += ")"

            If Not gravaSQL(Query) Then

                oi.Msg = "Alterações não foram efetivadas" + Chr(13)
                oi.Msg += "Caso o problema persista contate o resposável"
                oi.Style = vbExclamation
                MsgBox(oi.Msg, oi.Style, oi.Title)
                Exit Sub
            Else

                listviewCarega()

            End If

        Else

            'MsgBox("Desiste")

        End If
    End Sub

    Private Sub FrmFolhaContratoAtivacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.Title = Me.Text
    End Sub

    Private Function listviewCarega()
        ' Função preparada para colaborador tipo F - Funcionário
        ' Outros tipos não devem ser pesquisados 


        Dim StrChave As String = MskChave_Pesq.Text.Replace(" ", "")
        If StrChave.Length > 0 Then
            StrChave = MskChave_Pesq.Text.Replace(" ", "").Substring(1)
            Dim StrChaveTipo As String = MskChave_Pesq.Text.Replace(" ", "").Substring(0, 1)
        End If
        Dim StrNome As String = TxtNome_Pesq.Text.Replace(" ", "")
        Dim strCPF As String = CPFretiraMascara(MskCPF_Pesq.Text).Replace(" ", "")

        Dim IsFiltro As String = ""

        ListView1.Items.Clear()

        ' Definindo o filtro de pesquisa
        If StrChave <> "" Then
            IsFiltro = "Chave = " & StrChave
        ElseIf strCPF <> "" Then
            IsFiltro = "colaboradorcpf = '" & strCPF & "'"
        ElseIf StrNome <> "" Then
            IsFiltro = "colaboradorNome like " & "'%" & StrNome & "%'"
        End If
        If IsFiltro <> "" Then
            IsFiltro = " not colaboradorContratoAtivo and " & IsFiltro & ";"
        Else
            IsFiltro = " not colaboradorContratoAtivo;"
        End If

        GroupBox2.Text = "Colaboradores com Inatividade Para Contrato de Trabalho"
        ListView1.Items.Clear()

        Dim Query As String

        Query = "SELECT "
        Query += "colaborador.chave"
        Query += ",colaboradorNome"
        Query += ",colaboradorcpf"
        Query += ",if(colaboradorContratoAtivo,'ATIVO','INATIVO') as colaboradorContratoAtivo"
        Query += ",IF("
        Query += "(SELECT COUNT(*) FROM folha_col_contrato WHERE colaborador.chave = FCC_keyCol GROUP BY FCC_keyCol) IS NULL,0,"
        Query += "(SELECT COUNT(*) FROM folha_col_contrato WHERE colaborador.chave = FCC_keyCol GROUP BY FCC_keyCol)) AS QTO_contratos"
        Query += ",IFNULL("
        Query += "DATE_FORMAT("
        Query += "("
        Query += "SELECT t1.FCC_afastamento_data"
        Query += " FROM folha_col_contrato t1"
        Query += " WHERE t1.FCC_afastamento_data = ("
        Query += "SELECT MAX(t2.FCC_afastamento_data)"
        Query += " FROM folha_col_contrato t2"
        Query += " WHERE t1.FCC_keyCol = t2.FCC_keyCol"
        Query += ")"
        Query += ")"
        Query += ",'%d/%m/%Y')"
        Query += ",'__/__/____'"
        Query += ") AS ultimo_afastamento_data"
        Query += ",ifnull(colaboradorOBS,'')"
        Query += " FROM colaborador"
        Query += " Where "
        Query += IsFiltro


        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    ListView1.Items.Add(DTReader(0))                                                                ' Chave
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(1))                            ' Colaborador
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(DTReader(2)))          ' CPF
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(3))                            ' Status
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(4))                            ' QTO de contratos
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(5))                            ' Última data de contração
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(6))                            ' OBS

                End While

                GroupBox2.Text = "Colaboradores com Inatividade Para Contrato de Trabalho [" & ListView1.Items.Count & "]"

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            Conn.Close()
            If ListView1.Items.Count() = 0 Then
                With oi
                    .Msg = "Nenhum colaborador corresponde ao filtro selecionado." & Chr(13) & Chr(13)
                    .Msg += "Por favor refaça a Pesquisa."
                    .Style = vbCritical
                    MsgBox(.Msg, .Style, .Title)

                End With
            End If
        End If
    End Function


End Class