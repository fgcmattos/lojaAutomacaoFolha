Imports MySql.Data.MySqlClient
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.InteropServices
Public Class FColMant
    Public oi As New MsgShow
    Private strImagens(100) As String
    Private intContador As Integer = 0

    Private arrVariavel(20) As String
    Private arrIndex(20) As Integer
    Private strMascara As String = "___._____.__-_"
    Private inMascaraSemMascara As Integer = StrQTO(strMascara, "_") ' verificacao de quantos '_' existem na mascara

    Private Sub FColMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim intContador As Integer = 0
        Dim strFrase As String = ""
        Dim strLetra As String = ""
        Dim strTest As String = "12345678901"
        oi.title = Me.Text


        For i = 0 To strMascara.Length - 1

            strLetra = strMascara.Substring(i, 1)

            arrVariavel(i) = strLetra

            If strLetra = "_" Then

                arrIndex(intContador) = i

                intContador += 1

            End If

        Next

        intContador -= 1





        If OpenDB() Then

            Dim Query As String = "select * from uf order by UFsigla "
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            cmbEndUF.Items.Clear()
            col_01_rgOEuf.Items.Clear()
            col_01_cnhOEuf.Items.Clear()
            col_01_CTPSOEuf.Items.Clear()
            col_01_reserOEuf.Items.Clear()
            col_01_PISoeUF.Items.Clear()
            col_01_teOEuf.Items.Clear()

            col_01_rgOEuf.Items.Add("")
            col_01_cnhOEuf.Items.Add("")
            col_01_CTPSOEuf.Items.Add("")
            col_01_reserOEuf.Items.Add("")
            col_01_PISoeUF.Items.Add("")
            col_01_teOEuf.Items.Add("")

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    cmbEndUF.Items.Add(DTReader.GetString(1))
                    col_01_rgOEuf.Items.Add(DTReader.GetString(1))
                    col_01_cnhOEuf.Items.Add(DTReader.GetString(1))
                    col_01_CTPSOEuf.Items.Add(DTReader.GetString(1))
                    col_01_reserOEuf.Items.Add(DTReader.GetString(1))
                    col_01_PISoeUF.Items.Add(DTReader.GetString(1))
                    col_01_teOEuf.Items.Add(DTReader.GetString(1))
                End While

                DependentesContabiliza()         ' calculo ddos dependentes IR e Salario familia

            Catch ex As Exception
                MsgBox("Problemas Na Pesquisa")
            End Try
        End If
        Conn.Close()

        If OpenDB() Then

            Dim Query As String = "select * from estadocivil order by ecCodigo "
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            col_03EstadoCivil.Items.Clear()

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    col_03EstadoCivil.Items.Add(DTReader.GetString(2) & " - " & DTReader.GetString(1))

                End While
            Catch ex As Exception
                MsgBox("Problemas Na Pesquisa DB(EstadoCivil")
            End Try
        End If
        Conn.Close()

        carregaGrauInstrucao()

        '''Dim cor As List(Of captObs) = captObsRP.GetcaptObs()



    End Sub


    Private Sub mskNascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskNascimento.KeyPress
        Dim ret As String
        Dim retMotivos As String

        If e.KeyChar = Convert.ToChar(13) Then
            ret = idade(mskNascimento.Text)
            retMotivos = ret.Substring(0, 3)
            lblIdadeCritica.Text = ret
            If Val(retMotivos) < 200 And Val(retMotivos) >= 18 Then
                lblIdadeCritica.Text = ret
                'btnInicia.Enabled = True
                lblNascimento.Enabled = True
                lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                lblNascimento.ForeColor = System.Drawing.Color.Maroon
                lblNascimento.ForeColor = System.Drawing.Color.Black
                txtNome.Focus()
                mskNascimento.Enabled = False
                lblRecusa.Text = ""
            ElseIf Val(retMotivos) < Val(18) Then

                lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                lblNascimento.ForeColor = System.Drawing.Color.Red
                lblIdadeCritica.Text = ret
                lblRecusa.Text = "Colaborador Menor de idade ! "
            Else
                lblIdadeCritica.Text = ret
            End If

        End If


        If e.KeyChar = Convert.ToChar(27) Then

            txtNome.Enabled = True
            lblNome.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            lblNome.ForeColor = System.Drawing.Color.Maroon

            lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            lblNascimento.ForeColor = System.Drawing.Color.Black
            mskNascimento.Enabled = False
            txtNome.Focus()
        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub



    Private Sub btnInicia_KeyPress(sender As Object, e As KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(27) Then

            'btnInicia.Enabled = True
            lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            lblNascimento.ForeColor = System.Drawing.Color.Maroon
            mskNascimento.Enabled = True
            mskNascimento.Focus()
            'btnInicia.Enabled = False

        Else

            e.KeyChar = UCase(e.KeyChar)

        End If

    End Sub
    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then
            Me.Close()
        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'MsgBox("Enter pressionado")
            If txtNome.Text = "" Then
                MsgBox("Nome inválido!", vbCritical, "Cadastro De Colaboradores")
                Exit Sub



            End If
            txtNome.Enabled = False
            lblNome.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            lblNome.ForeColor = System.Drawing.Color.Black

            lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            lblNascimento.ForeColor = System.Drawing.Color.Maroon
            mskNascimento.Enabled = True
            mskNascimento.Focus()
        Else

            'e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub btnInclui_Click(sender As Object, e As EventArgs) Handles btnInclui.Click
        Dim ret, cpf As String
        ret = idade(mskNascDependente.Text)
        cpf = Replace(mskCPFdependente.Text, ".", "")
        cpf = Replace(mskCPFdependente.Text, ",", "")
        cpf = Replace(cpf, "-", "")
        cpf = Trim(cpf)

        If cmbParentesco.Text = "" Then
            MsgBox("Parentesco inválido!", vbCritical, "Cadastro de Colaborador")
            Exit Sub
        ElseIf txtNomeDependente.Text = "" Then
            MsgBox("Nome inválido!", vbCritical, "Cadastro de Colaborador")
            Exit Sub
        ElseIf cpf = "" Or cpf.Length < 11 Then
            MsgBox("CPF inválido!", vbCritical, "Cadastro de Colaborador")
            Exit Sub
        ElseIf Not CPFdigito(cpf) Then
            MsgBox("CPF inválido!", vbCritical, "Cadastro de Colaborador")
            Exit Sub
        ElseIf Val(ret.Substring(0, 3)) >= 200 Then
            MsgBox("data inválida!", vbCritical, "Cadastro de Colaborador")
            lblIdadeCritica.Text = ret
            Exit Sub
        End If
        ListViewDependente.Items.Add(cmbParentesco.Text)
        ListViewDependente.Items(ListViewDependente.Items.Count - 1).SubItems.Add(txtNomeDependente.Text)
        ListViewDependente.Items(ListViewDependente.Items.Count - 1).SubItems.Add(mskCPFdependente.Text)
        ListViewDependente.Items(ListViewDependente.Items.Count - 1).SubItems.Add(mskNascDependente.Text)
        ListViewDependente.Items(ListViewDependente.Items.Count - 1).SubItems.Add(ret)
        ListViewDependente.Items(ListViewDependente.Items.Count - 1).SubItems.Add(IIf(CheckBoxIR.Checked, "S", "N"))
        ListViewDependente.Items(ListViewDependente.Items.Count - 1).SubItems.Add(IIf(CheckBoxSF.Checked, "S", "N"))
        DependentesContabiliza()
        limpaDependente()
    End Sub
    Private Function DependentesContabiliza()

        Dim inContIR As Integer = 0
        Dim inContSF As Integer = 0

        If ListViewDependente.Items.Count = 0 Then

            LblirQTO.Text = 0

            LblslQTO.Text = 0

            LbltotalQTO.Text = 0

            Exit Function

        End If

        For i = 0 To ListViewDependente.Items.Count - 1

            If ListViewDependente.Items(i).SubItems(5).Text = "S" Then inContIR += 1

            If ListViewDependente.Items(i).SubItems(6).Text = "S" Then inContSF += 1

            LblirQTO.Text = inContIR

            LblslQTO.Text = inContSF

            LbltotalQTO.Text = ListViewDependente.Items.Count

        Next
    End Function
    Function LimpaDependente()

        cmbParentesco.Text = ""
        txtNomeDependente.Text = ""
        txtNomeDependente.Text = ""
        mskCPFdependente.Text = ""
        mskNascDependente.Text = ""
        CheckBoxIR.Checked = False
        CheckBoxSF.Checked = False

    End Function
    Private Sub ListViewDependente_DoubleClick(sender As Object, e As EventArgs) Handles ListViewDependente.DoubleClick

        ListViewDependente.SelectedItems(0).Remove()

        DependentesContabiliza()

    End Sub


    Function CarregaGrauInstrucao()
        If OpenDB() Then

            Dim Query As String = "select concat(lpad(id,2,'0'),' - ',descricao) as descricao from instrucaograu "
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            cmbInstrucao.Items.Clear()

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    cmbInstrucao.Items.Add(DTReader.GetString(0))

                End While
            Catch ex As Exception
                MsgBox("Problemas Na Pesquisa")
            End Try
        End If
        Conn.Close()
    End Function

    Private Sub chkDeficiencia_Click(sender As Object, e As EventArgs) Handles col_10deficiente.Click
        If col_10deficiente.Checked Then
            grpDeficiencia.Enabled = True
        Else
            grpDeficiencia.Enabled = False
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles col_03UniaoEstavel.CheckedChanged
        If GroupBox11.Enabled Then
            GroupBox11.Enabled = False
        Else
            GroupBox11.Enabled = True
        End If
    End Sub
    Private Sub BtnGrava_Click(sender As Object, e As EventArgs) Handles BtnGrava.Click

        Dim MN As New MenuColaborador

        ListView1.Groups.Add(0, MN.grupo0) ' Identificação
        ListView1.Groups.Add(1, MN.grupo1) ' Documentação
        ListView1.Groups.Add(2, MN.grupo2) ' Filiação
        ListView1.Groups.Add(3, MN.grupo3) ' Informações Pessoal

        ListView1.Groups.Add(4, MN.grupo4) ' Contato
        ListView1.Groups.Add(5, MN.grupo5) ' Endereços
        ListView1.Groups.Add(6, MN.grupo6) ' Escolaridade
        ListView1.Groups.Add(7, MN.grupo7) ' Imagens
        ListView1.Groups.Add(8, MN.grupo8) ' Financeiro
        ListView1.Groups.Add(9, MN.grupo9) ' Dependentes


        ListView1.Groups.Add(10, MN.grupo10) ' Complemento"
        ListView1.Groups.Add(11, MN.grupo11) ' Referências"
        ListView1.Groups.Add(12, MN.grupo12) ' ID-Interno"
        ListView1.Groups.Add(13, MN.grupo13) ' Observações"

        preencheAlteracoesColaboradores()

    End Sub
    Private Function ColaboradorAlteracoes(opcao As Boolean) As Boolean

        ColaboradorAlteracoes = False   ' Default (parametro padrao)

        If opcao Then
            GrpAlteracoes.Visible = True
            Dim msg As String
            Dim style As String
            Dim title As String
            Dim ctxt As String
            Dim help As String
            Dim resposta As String
            '---------------------
            Dim intElemento As Integer = 0

            For Each item In ListView1.Items

                If item.checked Then

                    ListView1.Items.RemoveAt(intElemento)

                Else

                    intElemento += 1

                End If

            Next

            If intElemento > 0 Then

                msg = "Confirma Gravação?"
                style = vbYesNo + vbQuestion + vbDefaultButton1
                title = "Manutenção de Colaborador"
                ctxt = 1000

                resposta = MsgBox(msg, style, title)
                If resposta <> 6 Then Exit Function

                'Dim usuario As String = "Paulo"

                Dim query As String = ""
                Dim query_log_conteudo As String = ""

                Dim query_log_cab As String = ""
                query_log_cab = "insert into log_alteracoes"
                query_log_cab += "("
                query_log_cab += "Log_tabela_Id"
                query_log_cab += ",Log_tabela"
                query_log_cab += ",Log_campo"
                query_log_cab += ",Log_conteudo_original"
                query_log_cab += ",Log_conteudo_alterado"
                query_log_cab += ",Log_sistema_utilizado"
                query_log_cab += ",Log_usuario_responsavel_key"
                query_log_cab += ",Log_usuario_responsavel_tipo"
                query_log_cab += ",Log_usuario_autorizador_key"
                query_log_cab += ",Log_usuario_autorizador_tipo"
                query_log_cab += ",Log_usuario_responsavel_nome_acesso"
                query_log_cab += ",Log_sistema_caminho_acesso"
                query_log_cab += ")"
                query_log_cab += " values "


                Dim VG As String = ""

                With ListView1
                    For Each Item In .Items
                        If Not (Item.Checked) Then

                            query += VG + Item.SubItems(4).Text + " = "
                            query += "'" + Trim(Item.SubItems(3).Text) + "'"

                            query_log_conteudo += "("
                            query_log_conteudo += LblIdentificador.Text                                 'Log_tabela_Id"
                            query_log_conteudo += ",'colaborador'"                                      'Log_tabela"
                            query_log_conteudo += ",'" & Item.SubItems(4).Text & "'"                    'Log_campo"
                            query_log_conteudo += ",'" & Trim(Item.SubItems(1).Text) & "'"              'Log_conteudo_original"
                            query_log_conteudo += ",'" & Trim(Item.SubItems(3).Text) & "'"              'Log_conteudo_alterado"
                            query_log_conteudo += ",'" & "FcolMant" & "'"                               'Log_sistema_utilizado"
                            query_log_conteudo += "," & usuClass.Usuario_Chave                          'Log_usuario_responsavel_key"
                            query_log_conteudo += ",'" & usuClass.Usuario_Tipo & "'"                    'Log_usuario_responsavel_tipo"
                            query_log_conteudo += ",''"                                                 'Log_usuario_autorizador_key"
                            query_log_conteudo += ",''"                                                 'Log_usuario_autorizador_tipo"
                            query_log_conteudo += ",'" & usuClass.Usuario_Nome_Acesso & "'"             'Log_usuario_responsavel_nome_acesso"
                            query_log_conteudo += ",'" & StatusStrip1.Items(0).Text.Substring(13) & "'" 'Log_sistema_caminho_acesso
                            query_log_conteudo += "),"

                            VG = ","
                        End If
                    Next
                    query += VG + "colaboradorDependentesIR = " + ListViewDependente.Items.Count().ToString
                End With

                query_log_conteudo = query_log_conteudo.Substring(0, Len(query_log_conteudo) - 1) & ";"

                query = "Update colaborador Set " + query + " where chave = " + LblChave.Text + ";"

                query += query_log_cab + query_log_conteudo

                query += " Select 'Base de Dados - Alterações Realizadas com sucesso !' as fseRetorno;"

                If OpenDB() Then

                    Dim DTReader As MySqlDataReader


                    Dim CMD As New MySqlCommand(query, Conn)

                    Try
                        DTReader = CMD.ExecuteReader
                        DTReader.Read()
                        Dim msgRetorno As String = DTReader.GetString(0)

                        msg = msgRetorno
                        style = vbExclamation + vbDefaultButton1
                        title = "Manutenção de Colaborador"
                        ctxt = 1000
                        MsgBox(msg, style, title)

                        LimpaTudo()

                        Me.Close()

                    Catch ex As Exception

                        With oi
                            .msg = "Problema na Gravação?"
                            .msg += Chr(13)
                            .msg = ex.Message
                            style = vbExclamation
                            title = "Manutenção de Colaborador"
                            ctxt = 1000
                            MsgBox(.msg, .style, .title)
                        End With

                    End Try


                End If
            Else
                msg = "Não foram realizadas alterações?"
                style = vbCritical + vbDefaultButton1
                title = "Manutenção de Colaborador"
                ctxt = 1000
                MsgBox(msg, style, title)
            End If

            Conn.Close()

        End If

    End Function
    Private Sub BtnLimpaTelaFoco_Click(sender As Object, e As EventArgs) Handles BtnLimpaTelaFoco.Click
        Dim Foco As Integer = 0

        Dim msg As String
        Dim style As String
        Dim title As String
        Dim ctxt As String
        Dim help As String
        Dim resposta As String
        '---------------------

        msg = "Conteúdo da Tela será apagado, Concorda"
        style = vbYesNo + vbQuestion + vbDefaultButton1
        title = "Cadastro de Colaborador"
        help = "folha.hlp"
        ctxt = 1000

        resposta = MsgBox(msg, style, title)
        'MsgBox(resposta)
        If resposta <> 6 Then
            Exit Sub
        End If

        foco = grnContato.SelectedIndex

        Select Case foco
            Case 0
                pg0Limpar()                     ' Documentacao
            Case 1
                pg1Limpar()                     ' filiacao
            Case 2
                pg2Limpar()                     ' pessoal
            Case 3
                pg3Limpar()                     ' contato
            Case 4
                pg4Limpar()                     ' endereco
            Case 5
                pg5Limpar()                     ' escolaridade
            Case 7
                pg7Limpar()                     ' financeiro
            Case 8
                pg8Limpar()                     ' dependentes
            Case 9
                pg9Limpar()                     ' Caracteristicas
            Case 10
                pg10Limpar()                    ' referencias
            Case 11
                pg11Limpar()                    ' referencias internas
        End Select
    End Sub
    Function pg0Limpar()

        col_01_rg.Text = ""
        col_01_rgOE.Text = ""
        col_01_rgOEuf.SelectedIndex = -1
        col_01_rgEmissao.Text = ""
        col_01_rgValidade.Text = ""
        col_01_cnh.Text = ""
        col_01_cnhOE.Text = ""
        col_01_cnhOEuf.SelectedIndex = -1
        col_01_cnhEmissao.Text = ""
        col_01_cnhValidade.Text = ""

        col_01_CTPS.Text = ""
        col_01_CTPSserie.Text = ""
        col_01_CTPSOE.Text = ""
        col_01_CTPSOEuf.SelectedIndex = -1
        col_01_CTPSemissao.Text = ""
        col_01_CTPSvalidade.Text = ""

        col_01_reser.Text = ""
        col_01_reserOE.Text = ""
        col_01_reserOEuf.SelectedIndex = -1
        col_01_reserEmissao.Text = ""
        col_01_reserValidade.Text = ""

        col_01_PIS.Text = ""
        col_01_PISoe.Text = ""
        col_01_PISoeUF.SelectedIndex = -1
        col_01_PISvalidade.Text = ""

        col_01_te.Text = ""
        col_01_teOE.Text = ""
        col_01_teOEuf.SelectedIndex = -1
        col_01_teEmissao.Text = ""
        col_01_teValidade.Text = ""
        col_01_teZona.Text = ""
        col_01_teSecao.Text = ""


    End Function
    Function pg1Limpar()

        col_02_Mae.Text = ""
        col_02_MaeNascimento.Text = ""
        col_02_MaeCPF.Text = ""
        col_02_MaeFone.Text = ""
        col_02_pai.Text = ""
        col_02_paiNascimento.Text = ""
        col_02_paiCPF.Text = ""
        col_02_paiFone.Text = ""

    End Function
    Function pg2Limpar()
        col_03Sexo.SelectedIndex = -1
        col_03EstadoCivil.SelectedIndex = -1
        col_03UniaoEstavel.Checked = False
        col_03Esposa.Text = ""
        col_03EsposaCPF.Text = ""
        col_03EsposaFone.Text = ""
        col_03EsposaNascimento.Text = ""
        col_03Companheira.Text = ""
        col_03CompanheiraCPF.Text = ""
        col_03CompanheiraFone.Text = ""
        col_03CompanheiraNascimento.Text = ""
    End Function
    Function pg3Limpar()

        col_04Fone1.Text = ""
        col_04Fone2.Text = ""
        col_04email.Text = ""
        col_04AutorizaComunicaEmail.Checked = False

    End Function
    Function pg4Limpar()
        col_05endereco.Text = ""
        col_05cidade.Text = ""
        cmbEndUF.SelectedIndex = -1
        col_05cep.Text = ""
    End Function
    Function pg5Limpar()
        cmbInstrucao.SelectedIndex = -1
        col_06Curso.Text = ""
        col_06ConselhoRegional.Text = ""
        col_06ConselhoRegionalNumero.Text = ""
        col_06ConselhoRegionalData.Text = ""
        col_06OE.Text = ""
    End Function
    Function pg7Limpar()
        col_08banco.Text = ""
        col_08agencia.Text = ""
        col_08agenciaDigito.Text = ""
        col_08conta.Text = ""
        col_08contaDigito.Text = ""
    End Function
    Function pg8Limpar()

        ListViewDependente.Items.Clear()
        cmbParentesco.SelectedIndex = -1
        txtNomeDependente.Text = ""
        mskCPFdependente.Text = ""
        mskNascDependente.Text = ""
        DependentesContabiliza()

    End Function
    Function pg9Limpar()
        col_10altura.Text = ""
        col_10peso.Text = ""
        col_10cabelo.Text = ""
        col_10olhos.Text = ""
        col_10tipoSangue.Text = ""
        col_10cor.Text = ""
        col_10deficiente.Checked = False
        col_10deficienteTipo.Text = ""
        col_10deficienteOutros.Text = ""
    End Function
    Function pg10Limpar()
        col_11nome1.Text = ""
        col_11Telefone1.Text = ""
        col_11conhecimento1.SelectedIndex = -1
        col_11Nome2.Text = ""
        col_11Telefone2.Text = ""
        col_11Conhecimento2.SelectedIndex = -1
        col_11Empresa1.Text = ""
        col_11Contato1.Text = ""
        col_11EmpresaTel1.Text = ""
        col_11Empresa2.Text = ""
        col_11Contato2.Text = ""
        col_11EmpresaTel2.Text = ""
    End Function

    Function pg11Limpar()
        col_12nomeCracha.Text = ""
        col_12funcao.Text = ""
        col_12ASOadmissao.Text = ""
        col_12Admissao.Text = ""
    End Function

    Function LimpaTudo()
        pg0Limpar()
        pg1Limpar()
        pg2Limpar()
        pg3Limpar()
        pg4Limpar()
        pg5Limpar()
        pg7Limpar()
        pg8Limpar()
        pg9Limpar()
        pg10Limpar()
        pg11Limpar()
        ListView1.Items.Clear()
        ListView1.Visible = False
    End Function

    Private Sub BtnLimpardetalhamento_Click(sender As Object, e As EventArgs) Handles BtnLimpardetalhamento.Click

        LimpaTudo()

    End Sub

    Private Sub col_01_rgOE_DoubleClick(sender As Object, e As EventArgs) Handles col_01_rgOE.DoubleClick

        col_01_rgOEuf.SelectedIndex = -1

    End Sub

    Private Sub col_01_cnhOE_DoubleClick(sender As Object, e As EventArgs) Handles col_01_cnhOE.DoubleClick

        col_01_cnhOEuf.SelectedIndex = -1

    End Sub

    Private Sub col_01_CTPSOE_DoubleClick(sender As Object, e As EventArgs) Handles col_01_CTPSOE.DoubleClick
        col_01_CTPSOEuf.SelectedIndex = -1
    End Sub

    Private Sub col_01_reserOE_DoubleClick(sender As Object, e As EventArgs) Handles col_01_reserOE.DoubleClick
        col_01_reserOEuf.SelectedIndex = -1
    End Sub

    Private Sub col_01_PISoe_DoubleClick(sender As Object, e As EventArgs) Handles col_01_PISoe.DoubleClick
        col_01_PISoeUF.SelectedIndex = -1
    End Sub

    Private Sub col_01_teOE_DoubleClick(sender As Object, e As EventArgs) Handles col_01_teOE.DoubleClick
        col_01_teOEuf.SelectedIndex = -1
    End Sub

    Private Sub Label8_DoubleClick(sender As Object, e As EventArgs) Handles Label8.DoubleClick
        cmbParentesco.SelectedIndex = -1
    End Sub

    Private Sub BtnMostraPis_Click(sender As Object, e As EventArgs) Handles BtnMostraPis.Click

        Dim Caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\PIS"


        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  '' CTPS show

        Dim Caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\CTPS"
        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)


    End Sub

    Private Sub BtnTitulo_Click(sender As Object, e As EventArgs) Handles BtnTitulo.Click

        Dim Caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\titulo"
        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Private Sub BtnMostraRG_Click(sender As Object, e As EventArgs) Handles BtnMostraRG.Click

        Dim Caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\rg"


        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Private Sub BtnMostraCNH_Click(sender As Object, e As EventArgs) Handles BtnMostraCNH.Click

        Dim Caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\cnh"

        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Sub CarregaImagens(ByVal pasta As String)
        strImagens = Directory.GetFiles(pasta, "*.jpeg")
    End Sub

    Private Function colIlustra(caminho As String)

        CarregaImagens(caminho)

        If strImagens.Length = 0 Then

            MsgBox("Tipo de documento não digitalizado !")

            Exit Function

        End If

        FcolDocSel.Show()

        For i = 0 To strImagens.Length - 1
            Select Case i

                Case 0
                    FcolDocSel.PictureT0.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT00.Text = strImagens(i)
                Case 1
                    FcolDocSel.PictureT1.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT01.Text = strImagens(i)
                Case 2
                    FcolDocSel.PictureT2.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT02.Text = strImagens(i)
                Case 3
                    FcolDocSel.PictureT3.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT03.Text = strImagens(i)
                Case 4
                    FcolDocSel.PictureT4.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT04.Text = strImagens(i)
                Case 5
                    FcolDocSel.PictureT5.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT05.Text = strImagens(i)
                Case 6
                    FcolDocSel.PictureT6.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT06.Text = strImagens(i)
                Case 7
                    FcolDocSel.PictureT7.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT07.Text = strImagens(i)
                Case 8
                    FcolDocSel.PictureT8.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT08.Text = strImagens(i)
                Case 9
                    FcolDocSel.PictureT9.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT09.Text = strImagens(i)
                Case 10
                    FcolDocSel.PictureT10.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT10.Text = strImagens(i)
                Case 11
                    FcolDocSel.PictureT11.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT11.Text = strImagens(i)
                Case 12
                    FcolDocSel.PictureT12.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT12.Text = strImagens(i)
                Case 13
                    FcolDocSel.PictureT13.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT13.Text = strImagens(i)
                Case 14
                    FcolDocSel.PictureT14.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT14.Text = strImagens(i)
            End Select


        Next
    End Function
    Private Function VerificaPreenchimentoCamposNecessariosFColMant() As Boolean

        Dim MS As New MsgShow
        MS.title = "Cadastro de Colaborador"
        MS.style = vbCritical


        If col_01_rg.Text = "" Or
            col_01_rgOE.Text = "" Or
            col_01_rgOEuf.Text = "" Or
            Trim(Replace(col_01_rgEmissao.Text, "/", "")) = "" Or
            Trim(Replace(col_01_rgValidade.Text, "/", "")) = "" Then
            With MS
                .msg = "Todos os campos referentes ao RG devem ser preenchidos!"
                MsgBox(.msg, .style, .title)
            End With
            Return (False)
            Exit Function
        End If


        ' FIM DA VERIFICACAO DO RG ----------------------------------------------

        ' VERIFICACAO DA CNH
        Dim contadorCamposPreenchidos As Integer = 0

        Dim cnhEmissao As String = Trim(Replace(col_01_cnhEmissao.Text, "/", ""))
        Dim cnhValidade As String = Trim(Replace(col_01_cnhValidade.Text, "/", ""))

        If col_01_cnh.Text <> "" Then contadorCamposPreenchidos = contadorCamposPreenchidos + 1
        If col_01_cnhOE.Text <> "" Then contadorCamposPreenchidos = contadorCamposPreenchidos + 1
        If col_01_cnhOEuf.Text <> "" Then contadorCamposPreenchidos = contadorCamposPreenchidos + 1
        If cnhEmissao <> "" Then contadorCamposPreenchidos = contadorCamposPreenchidos + 1
        If cnhValidade <> "" Then contadorCamposPreenchidos = contadorCamposPreenchidos + 1

        If contadorCamposPreenchidos > 0 And contadorCamposPreenchidos < 5 Then
            With MS
                MS.msg = "CNH com campos não preenchidos!"
                MsgBox(MS.msg, MS.style, MS.title)
            End With
            Return (False)
            Exit Function
        Else
            cnhEmissao = dataAAAAMMDD(cnhEmissao)
            cnhValidade = dataAAAAMMDD(cnhValidade)

            If cnhEmissao > cnhValidade Then
                With MS
                    .msg = "CNH validade maior do que a emissão!"
                    MsgBox(.msg, .style, .title)
                End With

                Return (False)
                Exit Function
            End If

            Dim query As String = "select UTC_DATE() - 1;"  ' sem explicacao data de hoje AAAAMMDD


            If OpenDB() Then

                Dim DTReader As MySqlDataReader


                Dim CMD As New MySqlCommand(query, Conn)
                Dim dataAgora As String
                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()
                    dataAgora = DTReader.GetString(0)

                Catch ex As Exception
                    With MS
                        .msg = "Problema de leitura da data no servidor?"
                        MsgBox(.msg, .style, .title)
                        Return (False)
                        Exit Function
                    End With

                End Try
                Conn.Close()
                If dataAgora > cnhValidade And cnhValidade <> "" Then
                    With MS
                        .msg = "Documento fora da válidade, Aceita entrada?"
                        .title = "Manutenção de Colaborador"
                        .style = vbYesNo + vbCritical + vbDefaultButton2

                        .resposta = MsgBox(.msg, .style, .title)
                        If .resposta <> 6 Then
                            Return (False)
                            Exit Function
                        End If

                    End With
                End If

            End If
            ' FIM DA VERIFICACAO DA CNH ----------------------------------------------
            If Not PIS_digito_verificador(col_01_PIS.Text) Then
                With oi
                    .msg = "Número do PIS inválido , Aceita entrada?"
                    .title = "Manutenção de Colaborador"
                    .style = vbYesNo + vbCritical + vbDefaultButton2
                    .resposta = MsgBox(.msg, .style, .title)
                    If .resposta <> 6 Then
                        Return (False)
                        Exit Function
                    End If
                End With

            End If
            Return (True)
        End If
    End Function

    Private Function preencheAlteracoesColaboradores()

        If Not VerificaPreenchimentoCamposNecessariosFColMant() Then

            Exit Function

        End If

        '''Dim comoEra As List(Of colaborador) = ColaboradorAcoes.GetColSQL(LblChave.Text) ' DB

        Dim comoEra As List(Of ClassCol_pesq) = ClassCol_pesqAcao.getColShowDB(LblChave.Text)

        Dim comoEsta As List(Of colaborador) = ColaboradorCapTela.GetColaboradorMant()  ' TELA

        'Linhas do ListView1
        '1 - Como esta o conteúdo gravado no campo da tabela, com máscara se existir
        '2 - Como está o conteúdo alterado na tela, com máscara se existir,
        '3 - O conteúdo de tela, sem máscara, pronto para ser gravado no campo da tabela
        '4 - Nome do campo da tabela que será gravado
        '5 - Grupo do menu a que este campo pertence


        ListView1.Items.Clear()

        ' Ordem de gravacao
        If CPFretiraMascara(comoEra(0).CPF) <> comoEsta(0).CPF Then
            ListView1.Items.Add("CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).CPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(0)

        End If

        If comoEra(0).Nome <> comoEsta(0).Nome Then
            ListView1.Items.Add("Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorNome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(0)
        End If
        If comoEra(0).Nascimento <> comoEsta(0).Nascimento Then
            ListView1.Items.Add("Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Nascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).Nascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Nascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorNascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(0)
        End If
        If comoEra(0).rg <> comoEsta(0).rg Then
            ListView1.Items.Add("RG")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).rg)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rg)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rg)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorRG")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).rgOE <> comoEsta(0).rgOE Then
            ListView1.Items.Add("Expedidor")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).rgOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rgOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rgOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorRGoe")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).RGuf <> comoEsta(0).rgOEuf Then
            ListView1.Items.Add("RG UF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).RGuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rgOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rgOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorRGuf")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).RGemissao <> comoEsta(0).rgEmissao Then
            ListView1.Items.Add("RG Emissao")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).RGemissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).rgEmissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rgEmissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorRGemissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).RGvalidade <> comoEsta(0).rgValidade Then
            ListView1.Items.Add("RG Validade")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).RGvalidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).rgValidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rgValidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorRGvalidade")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).cnh <> comoEsta(0).cnh Then
            ListView1.Items.Add("CNH n.")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).cnh)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnh)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnh)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCNH")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).cnhOE <> comoEsta(0).cnhOE Then
            ListView1.Items.Add("CNH Orgão Expedidor")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).cnhOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnhOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnhOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCNHoe")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CNHuf <> comoEsta(0).cnhOEuf Then
            ListView1.Items.Add("CNH UF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CNHuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnhOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnhOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCNHuf")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CNHemissao <> Trim(comoEsta(0).cnhEmissao) Then
            ListView1.Items.Add("CNH Emissão")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).CNHemissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).cnhEmissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnhEmissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCNHemissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CNHvalidade <> Trim(comoEsta(0).cnhValidade) Then
            ListView1.Items.Add("CNH Validade")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).CNHvalidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).cnhValidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cnhValidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCNHvalidade")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CTPS <> comoEsta(0).CTPS Then
            ListView1.Items.Add("CTPS")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CTPS)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPS)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPS)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCTPS")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CTPSserie <> comoEsta(0).CTPSserie Then
            ListView1.Items.Add("CTPS Série")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CTPSserie)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPSserie)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPSserie)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCTPSerie")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CTPSOE <> comoEsta(0).CTPSOE Then
            ListView1.Items.Add("CTPS Expedidor")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CTPSOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPSOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPSOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCTPSoe")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CTPSuf <> comoEsta(0).CTPSOEuf Then
            ListView1.Items.Add("CTPS UF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CTPSuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPSOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CTPSOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCTPSuf")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CTPSvalidade <> Trim(comoEsta(0).CTPSvalidade) Then
            ListView1.Items.Add("CTPS Validade")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CTPSvalidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).CTPSvalidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).CTPSvalidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCTPSvalidade")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).CTPSemissao <> Trim(comoEsta(0).CTPSemissao) Then
            ListView1.Items.Add("CTPS Emissão")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CTPSemissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).CTPSemissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).CTPSemissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCTPSemissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).Reservista <> comoEsta(0).reser Then
            ListView1.Items.Add("Reservista n.")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Reservista)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).reser)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).reser)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorReservista")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).ReservistaOE <> comoEsta(0).reserOE Then
            ListView1.Items.Add("Reservista Expedidor")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ReservistaOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).reserOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).reserOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorReservistaOE")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).ReservistaOEuf <> comoEsta(0).reserOEuf Then
            ListView1.Items.Add("Reservista UF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ReservistaOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).reserOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).reserOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorReservistaOEuf")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).ReservistaEmissao <> Trim(comoEsta(0).reserEmissao) Then
            ListView1.Items.Add("Reservista Emissão")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ReservistaEmissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).reserEmissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).reserEmissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorReservistaEmissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).ReservistaValidade <> Trim(comoEsta(0).reserValidade) Then
            ListView1.Items.Add("Reservista Validade")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ReservistaValidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).reserValidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).reserValidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorReservistaValidade")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).PIS <> comoEsta(0).PIS Then
            ListView1.Items.Add("PIS")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).PIS)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PIS)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PIS)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPIS")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).PISoe <> comoEsta(0).PISoe Then
            ListView1.Items.Add("PIS Expedidor")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).PISoe)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PISoe)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PISoe)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPISoe")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).PISoeUF <> comoEsta(0).PISoeUF Then
            ListView1.Items.Add("PIS UF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).PISoeUF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PISoeUF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PISoeUF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPISoeUF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).PISemissao <> Trim(comoEsta(0).PISemissao) Then
            ListView1.Items.Add("PIS Emissão")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).PISemissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).PISemissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).PISemissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPISemissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).PISvalidade <> Trim(comoEsta(0).PISvalidade) Then
            ListView1.Items.Add("PIS Validade")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).PISvalidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).PISvalidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).PISvalidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPISvalidade")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).TituloNumero <> comoEsta(0).te Then
            ListView1.Items.Add("Titulo Eleitor n.")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TituloNumero)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).te)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).te)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTituloNumero")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).TituloOE <> comoEsta(0).teOE Then
            ListView1.Items.Add("Titulo Orgão Emissor")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TituloOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTituloOE")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).TituloOEuf <> comoEsta(0).teOEuf Then
            ListView1.Items.Add("Titulo UF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TituloOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teOEuf)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTituloOEuf")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).TituloEmissao <> Trim(comoEsta(0).teEmissao) Then
            ListView1.Items.Add("Titulo Emissão")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TituloEmissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).teEmissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).teEmissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTituloEmissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).TituloValidade <> Trim(comoEsta(0).teValidade) Then
            ListView1.Items.Add("Titulo Validade")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TituloValidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).teValidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(comoEsta(0).teValidade))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTituloValidade")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).TituloZona <> comoEsta(0).teZona Then
            ListView1.Items.Add("Titulo Zona")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TituloZona)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teZona)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teZona)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTituloZona")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).TituloSecao <> comoEsta(0).teSecao Then
            ListView1.Items.Add("titulo Seção")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TituloSecao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teSecao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).teSecao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTituloSecao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(1)
        End If
        If comoEra(0).Mae <> comoEsta(0).Mae Then
            ListView1.Items.Add("Mãe Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Mae)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Mae)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Mae)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorMae")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If
        If dataAAAAMMDD(comoEra(0).MaeNascimento) <> comoEsta(0).MaeNascimento Then
            ListView1.Items.Add("Mãe Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).MaeNascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).MaeNascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).MaeNascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorMaeNascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If
        If CPFretiraMascara(comoEra(0).MaeCPF) <> comoEsta(0).MaeCPF Then
            ListView1.Items.Add("Mãe CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).MaeCPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).MaeCPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).MaeCPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorMaeCPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If
        If comoEra(0).MaeFone <> comoEsta(0).MaeFone Then
            ListView1.Items.Add("Mãe Fone")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).MaeFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).MaeFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).MaeFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorMaeFone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If
        If comoEra(0).pai <> comoEsta(0).pai Then
            ListView1.Items.Add("Pai Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).pai)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).pai)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).pai)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPai")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If
        If dataAAAAMMDD(comoEra(0).paiNascimento) <> comoEsta(0).paiNascimento Then
            ListView1.Items.Add("Pai Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).paiNascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).paiNascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).paiNascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPaiNascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If
        If CPFretiraMascara(comoEra(0).paiCPF) <> comoEsta(0).paiCPF Then
            ListView1.Items.Add("Pai CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).paiCPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).paiCPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).paiCPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPaiCPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If
        If comoEra(0).paiFone <> comoEsta(0).paiFone Then
            ListView1.Items.Add("Pai Fone")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).paiFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).paiFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).paiFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPaiFone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(2)
        End If

        If comoEra(0).Sexo <> comoEsta(0).Sexo Then
            ListView1.Items.Add("Sexo")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Sexo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Sexo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Sexo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorSexo")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).EstadoCivil <> comoEsta(0).EstadoCivil Then
            ListView1.Items.Add("Estado Civil")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EstadoCivil)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EstadoCivil)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EstadoCivil)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEstadoCivil")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If IIf(comoEra(0).UniaoEstavel, "1", "0") <> comoEsta(0).UniaoEstavel Then
            ListView1.Items.Add("União Estável")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).UniaoEstavel)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).UniaoEstavel)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).UniaoEstavel)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorUniaoEstavel")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
            If comoEsta(0).UniaoEstavel = 0 Then

                ListView1.Items.Add("União Estável Companheiro(a) Nome")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CompanheiroNome)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheiroNome")
                ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)

                ListView1.Items.Add("União Estável Companheiro(a) CPF")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).CompanheiroCPF))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheiroCPF")
                ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)

                ListView1.Items.Add("União Estável Companheiro(a) Fone")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CompanheiroFone)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheiroFone")
                ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)

                ListView1.Items.Add("União Estável Companheiro(a) Nascimento")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).CompanheiroNascimento))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheiroNascimento")
                ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)



            End If


        End If
        If comoEra(0).EsposoNome <> comoEsta(0).Esposa Then
            ListView1.Items.Add("Esposa Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EsposoNome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Esposa)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Esposa)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEsposolNome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).EsposoCPF <> comoEsta(0).EsposaCPF Then
            ListView1.Items.Add("Esposa CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).EsposoCPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).EsposaCPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EsposaCPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEsposoCPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).EsposoFone <> comoEsta(0).EsposaFone Then
            ListView1.Items.Add("Esposa Fone")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EsposoFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EsposaFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EsposaFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEsposoFone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).EsposoNascimento <> comoEsta(0).EsposaNascimento Then
            ListView1.Items.Add("Esposa Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).EsposoNascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).EsposaNascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EsposaNascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEsposoNascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).CompanheiroNome <> comoEsta(0).Companheira Then
            ListView1.Items.Add("Companheira Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CompanheiroNome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Companheira)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Companheira)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheiroNome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).CompanheiroCPF <> comoEsta(0).CompanheiraCPF Then
            ListView1.Items.Add("Companheira CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).CompanheiroCPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).CompanheiraCPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CompanheiraCPF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheirocpf")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).CompanheiroFone <> comoEsta(0).CompanheiraFone Then
            ListView1.Items.Add("Companheira Fone")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).CompanheiroFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CompanheiraFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CompanheiraFone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheiroFone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If
        If comoEra(0).CompanheiroNascimento <> comoEsta(0).CompanheiraNascimento Then
            ListView1.Items.Add("Companheira Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).CompanheiroNascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).CompanheiraNascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).CompanheiraNascimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCompanheiroNascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(3)
        End If

        If comoEra(0).Fone1 <> comoEsta(0).Fone1 Then
            ListView1.Items.Add("Fone")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Fone1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Fone1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Fone1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorFone1")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(4)
        End If
        If comoEra(0).Fone2 <> comoEsta(0).Fone2 Then
            ListView1.Items.Add("Fone 2")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Fone2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Fone2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Fone2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorFone2")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(4)
        End If
        If comoEra(0).email <> comoEsta(0).email Then
            ListView1.Items.Add("e-mail")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).email)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).email)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).email)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEmail")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(4)
        End If
        If comoEra(0).AutorizaEmail <> comoEsta(0).AutorizaComunicaEmail Then
            ListView1.Items.Add("Autoriza Comunicação Email")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).AutorizaEmail)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).AutorizaComunicaEmail)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).AutorizaComunicaEmail)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorAutorizaEmail")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(4)
        End If

        If comoEra(0).Residencia <> comoEsta(0).endereco Then
            ListView1.Items.Add("Endereço")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Residencia)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).endereco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).endereco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorResidencia")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(5)
        End If
        If comoEra(0).ResidenciaCidade <> comoEsta(0).cidade Then
            ListView1.Items.Add("Cidade")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ResidenciaCidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cidade)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorResidenciaCidade")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(5)
        End If
        If comoEra(0).ResidenciaUF <> comoEsta(0).EndUF Then
            ListView1.Items.Add("UF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ResidenciaUF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EndUF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EndUF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorResidenciaUF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(5)
        End If
        If comoEra(0).ResidenciaCEP <> comoEsta(0).cep Then
            ListView1.Items.Add("Cep")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ResidenciaCEP)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cep)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cep)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorResidenciaCEP")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(5)
        End If

        If comoEra(0).Instrucao <> comoEsta(0).Instrucao Then
            ListView1.Items.Add("Instrução")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Instrucao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Instrucao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Instrucao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorInstrucao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(6)
        End If
        If comoEra(0).Curso <> comoEsta(0).Curso Then
            ListView1.Items.Add("Curso")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Curso)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Curso)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Curso)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCurso")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(6)
        End If
        If comoEra(0).ConselhoRegional <> comoEsta(0).ConselhoRegional Then
            ListView1.Items.Add("Conselho Regional")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ConselhoRegional)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ConselhoRegional)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ConselhoRegional)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorConselhoRegional")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(6)
        End If
        If comoEra(0).ConselhoRegionalNumero <> comoEsta(0).ConselhoRegionalNumero Then
            ListView1.Items.Add("Conselho Regional Numero")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ConselhoRegionalNumero)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ConselhoRegionalNumero)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ConselhoRegionalNumero)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorConselhoRegionalNumero")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(6)
        End If
        If comoEra(0).ConselhoRegionalData <> comoEsta(0).ConselhoRegionalData Then
            ListView1.Items.Add("Conselho Regional Data")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ConselhoRegionalData)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).ConselhoRegionalData))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ConselhoRegionalData)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorConselhoRegionalData")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(6)
        End If
        If comoEra(0).ConselhoRegionalOE <> comoEsta(0).ConselhoRegionalOE Then
            ListView1.Items.Add("Conselho Regional OE")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ConselhoRegionalOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ConselhoRegionalOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ConselhoRegionalOE)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorConselhoRegionalOE")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(6)
        End If

        If comoEra(0).banco <> comoEsta(0).banco Then
            ListView1.Items.Add("Banco")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).banco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).banco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).banco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorBanco")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(8)
        End If
        If comoEra(0).agencia <> comoEsta(0).agencia Then
            ListView1.Items.Add("Agência")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).agencia)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).agencia)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).agencia)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorAgencia")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(8)
        End If

        '''If comoEra(0).agenciaDigito <> comoEsta(0).agenciaDigito Then
        '''    ListView1.Items.Add("Agência Digito")
        '''    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).agenciaDigito)
        '''    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).agenciaDigito)
        '''    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).agenciaDigito)
        '''    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
        '''End If

        If comoEra(0).ContaCorrente <> comoEsta(0).conta Then
            ListView1.Items.Add("Conta Bancária")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContaCorrente)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).conta)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).conta)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContaCorrente")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(8)
        End If
        If comoEra(0).ContaCorrenteDigito <> comoEsta(0).contaDigito Then
            ListView1.Items.Add("Conta Bancária Digito")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContaCorrenteDigito)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).contaDigito)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).contaDigito)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContaCorrenteDigito")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(8)
        End If
        If comoEra(0).PIX <> comoEsta(0).PIX Then
            ListView1.Items.Add("PIX")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).PIX)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PIX)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PIX)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPIX")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(8)
        End If

        If comoEra(0).PixIdentificacao <> comoEsta(0).PIXidentificacao Then
            ListView1.Items.Add("PIX")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).PixIdentificacao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PIXidentificacao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).PIXidentificacao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPixIdentificacao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(8)
        End If

        If comoEra(0).Dependente1Parentesco <> comoEsta(0).p1 Then
            ListView1.Items.Add("Dependente 1 Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente1Parentesco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente1Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente1Nome <> comoEsta(0).n1 Then
            ListView1.Items.Add("Dependente 1 Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente1Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente1Nome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente1CPF <> comoEsta(0).cpf1 Then
            ListView1.Items.Add("Dependente 1 CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).Dependente1CPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).cpf1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cpf1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente1CPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente1Nascimento <> comoEsta(0).nas1 Then
            ListView1.Items.Add("Dependente 1 Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).Dependente1Nascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).nas1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nas1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente1Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente1IR <> comoEsta(0).depIR1 Then
            ListView1.Items.Add("Dependente 1 IR ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente1IR)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente1IR")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If

        If comoEra(0).Dependente1SF <> comoEsta(0).depSF1 Then
            ListView1.Items.Add("Dependente 1 Sal.Familia ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente1SF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente1SF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If

        If comoEra(0).Dependente2Parentesco <> comoEsta(0).p2 Then
            ListView1.Items.Add("Dependente 2 Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente2Parentesco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente2Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente2Nome <> comoEsta(0).n2 Then
            ListView1.Items.Add("Dependente 2 Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente2Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente2Nome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If CPFretiraMascara(comoEra(0).Dependente2CPF) <> comoEsta(0).cpf2 Then
            ListView1.Items.Add("Dependente 2 CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).Dependente2CPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).cpf2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cpf2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente2CPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente2Nascimento <> comoEsta(0).nas2 Then
            ListView1.Items.Add("Dependente 2 Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).Dependente2Nascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).nas2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nas2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente2Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente2IR <> comoEsta(0).depIR2 Then
            ListView1.Items.Add("Dependente 2 IR ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente2IR)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente2IR")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If

        If comoEra(0).Dependente2SF <> comoEsta(0).depSF2 Then
            ListView1.Items.Add("Dependente 2 Sal.Familia ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente2SF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente2SF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If

        If comoEra(0).Dependente3Parentesco <> comoEsta(0).p3 Then
            ListView1.Items.Add("Dependente 3 Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente3Parentesco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente3Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente3Nome <> comoEsta(0).n3 Then
            ListView1.Items.Add("Dependente 3 Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente3Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente3Nome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If CPFretiraMascara(comoEra(0).Dependente3CPF) <> comoEsta(0).cpf3 Then
            ListView1.Items.Add("Dependente 3 CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).Dependente3CPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).cpf3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cpf3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente3CPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente3Nascimento <> comoEsta(0).nas3 Then
            ListView1.Items.Add("Dependente 3 Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).Dependente3Nascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).nas3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nas3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente3Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente3IR <> comoEsta(0).depIR3 Then
            ListView1.Items.Add("Dependente 3 IR ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente3IR)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente3IR")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente3SF <> comoEsta(0).depSF3 Then
            ListView1.Items.Add("Dependente 3 Sal.Familia ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente3SF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF3)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente3SF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If

        If comoEra(0).Dependente4Parentesco <> comoEsta(0).p4 Then
            ListView1.Items.Add("Dependente 4 Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente4Parentesco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente4Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente4Nome <> comoEsta(0).n4 Then
            ListView1.Items.Add("Dependente 4 Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente4Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente4Nome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If CPFretiraMascara(comoEra(0).Dependente4CPF) <> comoEsta(0).cpf4 Then
            ListView1.Items.Add("Dependente 4 CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).Dependente4CPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).cpf4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cpf4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente4CPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente4Nascimento <> comoEsta(0).nas4 Then
            ListView1.Items.Add("Dependente 4 Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).Dependente4Nascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).nas4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nas4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente4Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente4IR <> comoEsta(0).depIR4 Then
            ListView1.Items.Add("Dependente 4 IR ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente4IR)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente4IR")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente4SF <> comoEsta(0).depSF4 Then
            ListView1.Items.Add("Dependente 3 Sal.Familia ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente4SF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF4)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente4SF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If

        If comoEra(0).Dependente5Parentesco <> comoEsta(0).p5 Then
            ListView1.Items.Add("Dependente 5 Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente5Parentesco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente5Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente5Nome <> comoEsta(0).n5 Then
            ListView1.Items.Add("Dependente 5 Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente5Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente5Nome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If CPFretiraMascara(comoEra(0).Dependente5CPF) <> comoEsta(0).cpf5 Then
            ListView1.Items.Add("Dependente 5 CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).Dependente5CPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).cpf5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cpf5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente5CPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente5Nascimento <> comoEsta(0).nas5 Then
            ListView1.Items.Add("Dependente 5 Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).Dependente5Nascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).nas5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nas5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente5Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente5IR <> comoEsta(0).depIR5 Then
            ListView1.Items.Add("Dependente 5 IR ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente5IR)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente5IR")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente5SF <> comoEsta(0).depSF5 Then
            ListView1.Items.Add("Dependente 5 Sal.Familia ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente5SF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF5)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente5SF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If

        If comoEra(0).Dependente6Parentesco <> comoEsta(0).p6 Then
            ListView1.Items.Add("Dependente 6 Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente6Parentesco)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).p6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente6Parentesco")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente6Nome <> comoEsta(0).n6 Then
            ListView1.Items.Add("Dependente 6 Nome")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente6Nome)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).n6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente6Nome")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If CPFretiraMascara(comoEra(0).Dependente6CPF) <> comoEsta(0).cpf6 Then
            ListView1.Items.Add("Dependente 6 CPF")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEra(0).Dependente6CPF))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CPFcolocaMascara(comoEsta(0).cpf6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cpf6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente6CPF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente6Nascimento <> comoEsta(0).nas6 Then
            ListView1.Items.Add("Dependente 6 Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).Dependente6Nascimento))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).nas6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nas6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente6Nascimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente6IR <> comoEsta(0).depIR6 Then
            ListView1.Items.Add("Dependente 6 IR ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente6IR)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depIR6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente6IR")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If
        If comoEra(0).Dependente6SF <> comoEsta(0).depSF6 Then
            ListView1.Items.Add("Dependente 6 Sal.Familia ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Dependente6SF)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).depSF6)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDependente6SF")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(9)
        End If


        '''''''''''''''''''''''''''''''''
        If comoEra(0).altura <> comoEsta(0).altura Then
            ListView1.Items.Add("Altura")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).altura)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).altura)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).altura)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorAltura")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If
        If comoEra(0).peso <> comoEsta(0).peso Then
            ListView1.Items.Add("Peso")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).peso)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).peso)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).peso)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorPeso")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If
        If comoEra(0).cabelo <> comoEsta(0).cabelo Then
            ListView1.Items.Add("Cor do Cabelo")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).cabelo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cabelo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cabelo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCabelo")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If
        If comoEra(0).olhos <> comoEsta(0).olhos Then
            ListView1.Items.Add("Cor dos Olhos")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).olhos)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).olhos)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).olhos)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorOlhos")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If
        If comoEra(0).TipoDeSangues <> comoEsta(0).tipoSangue Then
            ListView1.Items.Add("Tipo de Sangue")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).TipoDeSangues)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).tipoSangue)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).tipoSangue)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorTipoDeSangues")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If
        If comoEra(0).cor <> comoEsta(0).cor Then
            ListView1.Items.Add("Cor da Pele")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).cor)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cor)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).cor)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCor")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If
        If comoEra(0).deficiente <> comoEsta(0).deficiente Then
            ListView1.Items.Add("Deficiente")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).deficiente)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).deficiente)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).deficiente)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDeficiente")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)

            If comoEsta(0).deficiente = "0" Then

                ListView1.Items.Add("Deficiênte Tipo")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).DeficienteTipo)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDeficienteTipo")
                ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)


                ListView1.Items.Add("Deficiênte Outros")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).DeficienteOutros)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDeficienteOutros")
                ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)

            End If

        End If
        If comoEra(0).deficienteTipo <> comoEsta(0).deficienteTipo Then
            ListView1.Items.Add("Deficiênte Tipo")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).deficienteTipo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).deficienteTipo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).deficienteTipo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDeficienteTipo")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If
        If comoEra(0).deficienteOutros <> comoEsta(0).deficienteOutros Then
            ListView1.Items.Add("Deficiênte Outros")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).deficienteOutros)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).deficienteOutros)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).deficienteOutros)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorDeficienteOutros")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(10)
        End If


        If comoEra(0).ContatoNome1 <> comoEsta(0).nome1 Then
            ListView1.Items.Add("referência Nome 1")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContatoNome1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nome1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).nome1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContatoNome1")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).ContatoNome1Telefone <> comoEsta(0).Telefone1 Then
            ListView1.Items.Add("Referência 1 Tel")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContatoNome1Telefone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Telefone1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Telefone1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContatoNome1Telefone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).ContatoNome1Conhecimento <> comoEsta(0).conhecimento1 Then
            ListView1.Items.Add("Grau de Conhecimento 1")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContatoNome1Conhecimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).conhecimento1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).conhecimento1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContatoNome1Conhecimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).ContatoNome2 <> comoEsta(0).Nome2 Then
            ListView1.Items.Add("Referência Nome 2")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContatoNome2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Nome2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Nome2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContatoNome2")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).ContatoNome2telefone <> LimpaNumero(comoEsta(0).Telefone2) Then
            ListView1.Items.Add("Referencia 2 Tel")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContatoNome2telefone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Telefone2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Telefone2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContatoNome2telefone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).ContatoNome2Conhecimento <> comoEsta(0).Conhecimento2 Then
            ListView1.Items.Add("Grau de Conhecimento 2")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ContatoNome2Conhecimento)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Conhecimento2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Conhecimento2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorContatoNome2Conhecimento")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).EmpresaNome1 <> comoEsta(0).Empresa1 Then
            ListView1.Items.Add("Empresa 1")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EmpresaNome1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Empresa1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Empresa1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEmpresaNome1")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).EmpresaNome1Contato <> comoEsta(0).Contato1 Then
            ListView1.Items.Add("Contato 1")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EmpresaNome1Contato)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Contato1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Contato1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEmpresaNome1Contato")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).EmpresaNome1Telefone <> comoEsta(0).EmpresaTel1 Then
            ListView1.Items.Add("Tel Contato 1")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EmpresaNome1Telefone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EmpresaTel1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EmpresaTel1)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEmpresaNome1Telefone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).EmpresaNome2 <> comoEsta(0).Empresa2 Then
            ListView1.Items.Add("Empres 2")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EmpresaNome2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Empresa2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Empresa2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEmpresaNome2")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).EmpresaNome2Contato <> comoEsta(0).Contato2 Then
            ListView1.Items.Add("Contato 2")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EmpresaNome2Contato)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Contato2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Contato2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEmpresaNome2Contato")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If
        If comoEra(0).EmpresaNome2Telefone <> comoEsta(0).EmpresaTel2 Then
            ListView1.Items.Add("Tel Contato 2")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).EmpresaNome2Telefone)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EmpresaTel2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).EmpresaTel2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorEmpresaNome2Telefone")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(11)
        End If

        If comoEra(0).NomeCracha <> comoEsta(0).Cracha Then
            ListView1.Items.Add("Nome no Cracha")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).NomeCracha)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Cracha)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Cracha)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorNomeCracha")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).Cargo <> comoEsta(0).Cargo Then
            ListView1.Items.Add("Cargo")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Cargo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Cargo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Cargo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCargo")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).ASOadmissao <> comoEsta(0).ASOadmissao Then
            ListView1.Items.Add("ASO Admissão")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ASOadmissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).ASOadmissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ASOadmissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorASOadmissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).Admissao <> comoEsta(0).Admissao Then
            ListView1.Items.Add("Admissão")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Admissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).Admissao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Admissao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorAdmissao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If

        Dim strReferencia As String = Replace(comoEsta(0).AdmissaoRef, "/", "")
        strReferencia = strReferencia.Substring(2) & strReferencia.Substring(0, 2)
        If comoEra(0).AdmissaoReferencia > strReferencia Then

            ListView1.Items.Add("Admissão Ref")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).AdmissaoReferencia)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).AdmissaoRef)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(strReferencia)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorAdmissaoReferencia")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).Cbo <> comoEsta(0).Cbo Then
            ListView1.Items.Add("C.B.O. ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Cbo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Cbo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Cbo)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorCBO")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).Setor <> comoEsta(0).Setor Then
            ListView1.Items.Add("Setor")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).Setor)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Setor)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).Setor)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorSetor")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).ASOrescisao <> comoEsta(0).ASOrescisao Then
            ListView1.Items.Add("A.S.O. rescisão ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).ASOrescisao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).ASOrescisao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).ASOrescisao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorASOrescisao")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).RescisaoData <> comoEsta(0).rescisao Then
            ListView1.Items.Add("Rescisao ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEra(0).RescisaoData))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(comoEsta(0).rescisao))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).rescisao)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorRescisaoData")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(12)
        End If
        If comoEra(0).ResidenciaBairro <> comoEsta(0).bairro Then
            ListView1.Items.Add("Bairro ")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEra(0).ResidenciaBairro)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).bairro)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(comoEsta(0).bairro)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("colaboradorResidenciaBairro")
            ListView1.Items(ListView1.Items.Count - 1).Group = ListView1.Groups(5)
        End If
        ' Fim da Ordem de Gravacao

        Dim itemsAlterados As Integer = 0
        itemsAlterados = ListView1.Items.Count

        If itemsAlterados = 0 Then
            Dim Mn As New MsgShow
            With Mn
                .msg = "Não foram feitas alterações no cadastro para o Colaborador"
                .style = vbExclamation
                .title = "Colaborador Manutenção"
                MsgBox(.msg, .style, .title)
            End With
        Else

            GrpAlteracoes.Location = New Point(97, 140)

            GrpAlteracoes.Visible = True

        End If

    End Function

    Private Sub BtoCancela_Click(sender As Object, e As EventArgs) Handles BtoCancela.Click
        colaboradorAlteracoes(False)
        GrpAlteracoes.Visible = False
    End Sub

    Private Sub BtoGrava_Click(sender As Object, e As EventArgs) Handles BtoGrava.Click

        colaboradorAlteracoes(True)

    End Sub

    Private Sub BtoIMC_Click(sender As Object, e As EventArgs) Handles BtoIMC.Click
        Dim peso As Decimal
        Dim altura As Decimal
        Dim resultado As Decimal
        Dim PesoEsperado As Decimal
        Dim excessoPeso As Decimal = 0

        If col_10peso.Text = "" Then
            MsgBox("Peso invalido!")
            col_10peso.Focus()
            Exit Sub
        Else
            peso = CDec(col_10peso.Text)
        End If

        If Trim(col_10altura.Text) = "" Then
            MsgBox("Altura invalida!")
            col_10altura.Focus()
            Exit Sub
        Else
            altura = CDec(Replace(col_10altura.Text, ":", ","))
        End If

        resultado = Int((peso / (altura * altura)) * 100) / 100
        LabelIMCcalculado.Text = "IMC = " + CStr(resultado)

        If resultado > 24.9 Then

            PesoEsperado = 24.9 * (altura * altura)

            excessoPeso = peso - PesoEsperado
            labelexcessoPeso.Visible = True
            labelexcessoPeso.Text = "Excesso: " + CStr(Int(excessoPeso * 100) / 100) + "K"
        Else
            labelexcessoPeso.Visible = False

        End If


    End Sub


    Private Sub col_01_PIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles col_01_PIS.KeyPress

        With col_01_PIS
            If e.KeyChar = Convert.ToChar(27) Then



            End If

            If e.KeyChar = Convert.ToChar(13) Then

                'MsgBox("Enter pressionado")
                If .Text = "" Then

                    oi.msg = "Base de FGTS inválida!"
                    oi.style = vbCritical
                    MsgBox(oi.msg, oi.style, oi.title)
                    Exit Sub

                End If



            Else

                e.KeyChar = UCase(e.KeyChar)

            End If
            If Asc(e.KeyChar) = 8 Then     ' Backspace

                e.KeyChar = ""

                'MostraMatriz()

                For j = (inMascaraSemMascara - 1) To 1 Step -1

                    arrVariavel(arrIndex(j)) = arrVariavel(arrIndex(j - 1))

                Next

                arrVariavel(0) = "_"

                '.Text = strMascara

                .Text = ""

                For i = 0 To strMascara.Length - 1
                    .Text += arrVariavel(i)
                Next

                'MostraMatriz()

                SendKeys.Send("{END}")
                Exit Sub

            End If

            If e.KeyChar >= "0" And e.KeyChar <= "9" Then

                Dim strLetra As String = e.KeyChar

                e.KeyChar = ""

                'MostraMatriz()

                If StrQTO(.Text, "_") = 0 Then       ' Verifica se a mascara esta totalmente carregada

                    Exit Sub

                End If





                For j = 0 To strMascara.Length - 1

                    arrVariavel(arrIndex(j)) = arrVariavel(arrIndex(j + 1))

                Next

                arrVariavel(arrIndex(inMascaraSemMascara - 1)) = strLetra

                .Text = ""

                For i = 0 To strMascara.Length - 1
                    .Text += arrVariavel(i)
                Next
                intContador += 1

                SendKeys.Send("{END}")
                'MostraMatriz()


            Else

                e.KeyChar = ""

                'MskEdiValor.Focus()


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With

    End Sub

    Private Function MostraMatriz()
        With oi
            .msg = strMascara
            .msg += Chr(13)
            .msg += Chr(13)
            .msg += "arrVariavel(0) = " & arrVariavel(0) & " arrIndex(0) = " & arrIndex(0)
            .msg += Chr(13)
            .msg += "arrVariavel(1) = " & arrVariavel(1) & " arrIndex(1) = " & arrIndex(1)
            .msg += Chr(13)
            .msg += "arrVariavel(2) = " & arrVariavel(2) & " arrIndex(2) = " & arrIndex(2)
            .msg += Chr(13)
            .msg += "arrVariavel(3) = " & arrVariavel(3) & " arrIndex(3) = " & arrIndex(3)
            .msg += Chr(13)
            .msg += "arrVariavel(4) = " & arrVariavel(4) & " arrIndex(4) = " & arrIndex(4)
            .msg += Chr(13)
            .msg += "arrVariavel(5) = " & arrVariavel(5) & " arrIndex(5) = " & arrIndex(5)
            .msg += Chr(13)
            .msg += "arrVariavel(6) = " & arrVariavel(6) & " arrIndex(6) = " & arrIndex(6)
            .msg += Chr(13)
            .msg += "arrVariavel(7) = " & arrVariavel(7) & " arrIndex(7) = " & arrIndex(7)
            .msg += Chr(13)
            .msg += "arrVariavel(8) = " & arrVariavel(8) & " arrIndex(8) = " & arrIndex(8)
            .msg += Chr(13)
            .msg += "arrVariavel(9) = " & arrVariavel(9) & " arrIndex(9) = " & arrIndex(9)
            .msg += Chr(13)
            .msg += "arrVariavel(10) = " & arrVariavel(10) & " arrIndex(10) = " & arrIndex(10)
            .msg += Chr(13)
            .msg += "arrVariavel(11) = " & arrVariavel(11) & " arrIndex(11) = " & arrIndex(11)
            .msg += Chr(13)
            .msg += "arrVariavel(12) = " & arrVariavel(12) & " arrIndex(12) = " & arrIndex(12)
            .msg += Chr(13)
            .msg += "arrVariavel(13) = " & arrVariavel(13) & " arrIndex(13) = " & arrIndex(13)
            .msg += Chr(13)
            '.msg += "arrVariavel(14) = " & arrVariavel(14)
            '.msg += Chr(13)
            '.msg += "arrVariavel(15) = " & arrVariavel(15)
            '.msg += Chr(13)
            '.msg += "arrVariavel(16) = " & arrVariavel(16)

            .style = vbYesNo
            MsgBox(.msg, .style, .title)
        End With
    End Function

    Private Sub col_01_PIS_GotFocus(sender As Object, e As EventArgs) Handles col_01_PIS.GotFocus



        With col_01_PIS

            Dim strAuxiliarMascara As String = Replace(Replace(.Text, ".", ""), "-", "")

            .Text = PIScolocaMascara(strAuxiliarMascara)

            Dim strAuxiliar As String = .Text

            For i = 0 To col_01_PIS.TextLength - 1

                arrVariavel(i) = strAuxiliar.Substring(i, 1)

            Next
        End With

        SendKeys.Send("{END}")

    End Sub

    Private Sub BtnDetalhamentoCabAltera_Click(sender As Object, e As EventArgs) Handles BtnDetalhamentoCabAltera.Click

        If GruIdentificacao.Enabled Then

            GruIdentificacao.Enabled = False

        Else

            If grpCaracteristicas.Enabled Then

                With oi

                    .msg = "Edição de Características do Colobarador está aberta "
                    .msg += "e será fechada, sem perda dos conteúdos!"
                    .msg += Chr(13) & Chr(13)
                    .msg += "Abre a Edição de Identificação?"
                    .style = vbYesNo
                    .resposta = MsgBox(.msg, .style, .title)

                    If .resposta = 6 Then

                        grpCaracteristicas.Enabled = False

                        GruIdentificacao.Enabled = True

                    End If

                End With
            Else

                GruIdentificacao.Enabled = True

            End If

        End If

    End Sub

    Private Sub BtnDetalhamentoCorpoAltera_Click(sender As Object, e As EventArgs) Handles BtnDetalhamentoCorpoAltera.Click

        DependentesContabiliza()

        If grpCaracteristicas.Enabled Then

            grpCaracteristicas.Enabled = False

        Else

            If GruIdentificacao.Enabled Then

                With oi

                    .msg = "Edição de Identificação do colaborador está aberta "
                    .msg += "e será fechada, sem perda dos conteúdos!"
                    .msg += Chr(13) & Chr(13)
                    .msg += "Abre a Edição de Características?"
                    .style = vbYesNo
                    .resposta = MsgBox(.msg, .style, .title)
                    If .resposta = 6 Then

                        grpCaracteristicas.Enabled = True

                        GruIdentificacao.Enabled = False



                    End If

                End With
            Else

                grpCaracteristicas.Enabled = True

            End If

        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class

