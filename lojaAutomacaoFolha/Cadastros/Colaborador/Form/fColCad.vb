Imports MySql.Data.MySqlClient
Public Class fColCad
    Dim Oi As New MsgShow
    Private Sub fColCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            col_01_rgOEuf.Items.Add("  ")
            col_01_cnhOEuf.Items.Add(" ")
            col_01_CTPSOEuf.Items.Add(" ")
            col_01_reserOEuf.Items.Add("  ")
            col_01_PISoeUF.Items.Add(" ")
            col_01_teOEuf.Items.Add(" ")
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
            Catch ex As Exception
                MsgBox(ex)
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
                btnInicia.Enabled = True
                lblNascimento.Enabled = True
                lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                lblNascimento.ForeColor = System.Drawing.Color.Maroon
                lblNascimento.ForeColor = System.Drawing.Color.Black
                btnInicia.Focus()
                mskNascimento.Enabled = False
                LabelIniciar.Visible = True
                LabelNascimento.Visible = False
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

            LabelNome.Visible = True
            LabelNascimento.Visible = False

            lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
            lblNascimento.ForeColor = System.Drawing.Color.Black
            mskNascimento.Enabled = False
            txtNome.Focus()
        Else

            e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub

    Private Sub btnInicia_Click(sender As Object, e As EventArgs) Handles btnInicia.Click
        btnInicia.Enabled = False
        grpPrincipal.Enabled = True
        grpPessoal.Visible = True
        Me.Height = 550
        Me.Width = 1337
        grpPrincipal.Enabled = True
        LabelIniciar.Visible = False
        LabelRGnumero.Visible = True

        carregaGrauInstrucao()
        col_01_rg.Focus()

    End Sub

    Private Sub btnInicia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnInicia.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then

            btnInicia.Enabled = True
            lblNascimento.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
            lblNascimento.ForeColor = System.Drawing.Color.Maroon
            mskNascimento.Enabled = True
            mskNascimento.Focus()
            btnInicia.Enabled = False
            LabelIniciar.Visible = False
            LabelNascimento.Visible = True

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
            LabelNome.Visible = False
            LabelNascimento.Visible = True
            mskNascimento.Enabled = True
            mskNascimento.Focus()
            'Else

            'e.KeyChar = UCase(e.KeyChar)

        End If
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnInicia.Enabled = True
        grpPrincipal.Enabled = False
        Me.Height = 160
        Me.Width = 900
        LabelIniciar.Visible = True
        btnInicia.Focus()
    End Sub

    Private Sub btnInclui_Click(sender As Object, e As EventArgs)
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
        limpaDependente()
    End Sub
    Sub limpaDependente()
        cmbParentesco.Text = ""
        txtNomeDependente.Text = ""
        txtNomeDependente.Text = ""
        mskCPFdependente.Text = ""
        mskNascDependente.Text = ""
        CheckBoxIR.Checked = False
        CheckBoxSF.Checked = False
    End Sub
    Private Sub txtNomeDependente_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Sub CarregaGrauInstrucao()

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
                MsgBox(ex.ToString)
            End Try
        End If
        Conn.Close()

    End Sub

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

        Dim Ms As New MsgShow

        Ms.title = Me.Text

        With Ms

            If Me.col_03Sexo.Text = "" Then
                .msg = "Erro - Defina o SEXO"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                Exit Sub

            End If

            If Me.col_03EstadoCivil.Text = "" Then

                .msg = "Erro - Estado civil"
                .style = vbCritical
                MsgBox(.msg, .style, .title)

                Exit Sub

            End If


            If Me.cmbInstrucao.Text = "" Then

                .msg = "Erro - Grau de instrução"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                Exit Sub

            End If

        End With

        Try

            If ColaboradorInsert() Then

                fColCadAutz.Show()

                Me.Close()

            End If

        Catch ex As Exception

            With oi
                .msg = ex.Message
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
            End With
            Exit Sub

        End Try



    End Sub

    Private Sub BtnLimpaTelaFoco_Click(sender As Object, e As EventArgs) Handles BtnLimpaTelaFoco.Click
        Dim foco As Integer = 0

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
                pg0Limpar()
            Case 1
                pg1Limpar()
            Case 2
                pg2Limpar()
            Case 3
                pg3Limpar()
            Case 4
                pg4Limpar()
            Case 5
                pg5Limpar()
            Case 7
                pg7Limpar()
            Case 8
                pg8Limpar()
            Case 9
                pg9Limpar()
            Case 10
                pg10Limpar()
            Case 11
                pg11Limpar()
        End Select
    End Sub
    Sub pg0Limpar()

        col_01_rg.Text = ""
        col_01_rgOE.Text = ""
        col_01_rgOEuf.SelectedIndex = -1
        col_01_rgEmissao.Text = ""
        col_01_rgValidade.Text = ""
        CheckBox1.Checked = False
        col_01_cnh.Text = ""
        col_01_cnhOE.Text = ""
        col_01_cnhOEuf.SelectedIndex = -1
        col_01_cnhEmissao.Text = ""
        col_01_cnhValidade.Text = ""
        CheckBox2.Checked = False
        col_01_CTPS.Text = ""
        col_01_CTPSserie.Text = ""
        col_01_CTPSOE.Text = ""
        col_01_CTPSOEuf.SelectedIndex = -1
        col_01_CTPSemissao.Text = ""
        col_01_CTPSvalidade.Text = ""
        CheckBox3.Checked = False
        col_01_reser.Text = ""
        col_01_reserOE.Text = ""
        col_01_reserOEuf.SelectedIndex = -1
        col_01_reserEmissao.Text = ""
        col_01_reserValidade.Text = ""
        CheckBox4.Checked = False
        col_01_PIS.Text = ""
        col_01_PISoe.Text = ""
        col_01_PISoeUF.SelectedIndex = -1
        col_01_PISvalidade.Text = ""
        CheckBox5.Checked = False
        col_01_te.Text = ""
        col_01_teOE.Text = ""
        col_01_teOEuf.SelectedIndex = -1
        col_01_teEmissao.Text = ""
        col_01_teValidade.Text = ""
        col_01_teZona.Text = ""
        col_01_teSecao.Text = ""
        CheckBox6.Checked = False

    End Sub
    Sub pg1Limpar()

        col_02_Mae.Text = ""
        col_02_MaeNascimento.Text = ""
        col_02_MaeCPF.Text = ""
        col_02_MaeFone.Text = ""
        col_02_pai.Text = ""
        col_02_paiNascimento.Text = ""
        col_02_paiCPF.Text = ""
        col_02_paiFone.Text = ""

    End Sub
    Sub pg2Limpar()
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
    End Sub
    Sub pg3Limpar()

        col_04Fone1.Text = ""
        col_04Fone2.Text = ""
        col_04email.Text = ""
        col_04AutorizaComunicaEmail.Checked = False

    End Sub
    Sub pg4Limpar()
        col_05endereco.Text = ""
        col_05cidade.Text = ""
        cmbEndUF.SelectedIndex = -1
        col_05cep.Text = ""
    End Sub
    Sub pg5Limpar()
        cmbInstrucao.SelectedIndex = -1
        col_06Curso.Text = ""
        col_06ConselhoRegional.Text = ""
        col_06ConselhoRegionalNumero.Text = ""
        col_06ConselhoRegionalData.Text = ""
        col_06OE.Text = ""
    End Sub
    Sub pg7Limpar()
        col_08banco.Text = ""
        col_08agencia.Text = ""
        col_08agenciaDigito.Text = ""
        col_08conta.Text = ""
        col_08contaDigito.Text = ""
    End Sub
    Sub pg8Limpar()
        ListViewDependente.Items.Clear()
        cmbParentesco.SelectedIndex = -1
        txtNomeDependente.Text = ""
        mskCPFdependente.Text = ""
        mskNascDependente.Text = ""
    End Sub
    Sub pg9Limpar()
        col_10altura.Text = ""
        col_10peso.Text = ""
        col_10cabelo.Text = ""
        col_10olhos.Text = ""
        col_10tipoSangue.Text = ""
        col_10cor.Text = ""
        col_10deficiente.Checked = False
        col_10deficienteTipo.Text = ""
        col_10deficienteOutros.Text = ""
    End Sub
    Sub pg10Limpar()
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
    End Sub
    Sub pg11Limpar()
        col_12nomeCracha.Text = ""
        col_12Cargo.Text = ""
        col_12ASOadmissao.Text = ""
        col_12Admissao.Text = ""
    End Sub
    Sub LimpaTudo()
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
    End Sub
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
    Private Sub Label8_DoubleClick(sender As Object, e As EventArgs)
        cmbParentesco.SelectedIndex = -1
    End Sub

    Private Sub BtoIMC_Click(sender As Object, e As EventArgs) Handles BtoIMC.Click
        Dim peso As Decimal
        Dim altura As Decimal
        Dim resultado As Decimal
        Dim PesoEsperado As Decimal
        Dim ExcessoPeso As Decimal = 0

        If col_10peso.Text = "" Then
            MsgBox("Peso invalido!")
            col_10peso.Focus()
            Exit Sub
        Else
            peso = CDec(col_10peso.Text)
        End If

        If Trim(col_10altura.Text) = ":" Then
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

    Private Sub LblSetor_DoubleClick(sender As Object, e As EventArgs) Handles LblSetor.DoubleClick

        Dim atSetor As List(Of ClassFolha_Setor) = ClassFolha_SetorAcao.getFolhaSetorDB()

        With col_12Setor
            .Items.Clear()
            .Items.Add("")
            For i = 0 To atSetor.Count - 1
                .Items.Add(atSetor(i).ComboOpcao)
            Next
        End With

    End Sub

    Private Sub LblCargo_DoubleClick(sender As Object, e As EventArgs) Handles LblCargo.DoubleClick

        Dim strSetor As String = col_12Setor.Text

        If strSetor = "" Then

            With oi
                .msg = "Setor não selecionado!" & Chr(13) & Chr(13) & "Por favor Selecione um setor Válido."
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
                Exit Sub
            End With

        End If

        strSetor = Trim(strSetor.Substring(0, 2))
        Dim atCargo As List(Of ClassFolha_Cargo) = ClassFolha_cargoAcao.getFolhaCargoDB(strSetor)

        col_12Cargo.Items.Clear()
        col_12Cargo.Items.Add("")
        For i = 0 To atCargo.Count - 1
            col_12Cargo.Items.Add(atCargo(i).ComboOpcao)
        Next
        'Public Shared Function getFolhaCargoDB() As List(Of ClassFolha_Cargo)
    End Sub

    Private Sub btnInclui_Click_1(sender As Object, e As EventArgs) Handles btnInclui.Click
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

    Private Sub DependentesContabiliza()

        Dim inContIR As Integer = 0
        Dim inContSF As Integer = 0

        If ListViewDependente.Items.Count = 0 Then

            LblirQTO.Text = 0

            LblslQTO.Text = 0

            LbltotalQTO.Text = 0

            Exit Sub

        End If

        For i = 0 To ListViewDependente.Items.Count - 1

            If ListViewDependente.Items(i).SubItems(5).Text = "S" Then inContIR += 1

            If ListViewDependente.Items(i).SubItems(6).Text = "S" Then inContSF += 1

            LblirQTO.Text = inContIR

            LblslQTO.Text = inContSF

            LbltotalQTO.Text = ListViewDependente.Items.Count

        Next
    End Sub

    Private Sub ListViewDependente_DoubleClick(sender As Object, e As EventArgs) Handles ListViewDependente.DoubleClick

        ListViewDependente.SelectedItems(0).Remove()

        DependentesContabiliza()

    End Sub

    Private Function ColaboradorInsert() As Boolean

        Dim bolRetorno As Boolean = False
        '/ Leitura da Tela
        Dim cl As List(Of colaborador) = ColaboradorCapTela.GetColaborador()

        If cl Is Nothing Then
            'With oi
            '    .msg = "Tela em branco"
            '    .style = vbExclamation
            '    MsgBox(.msg, .style, .title)
            'End With

            Return (bolRetorno)

            Exit Function

        End If

        '/ Definindo o numero da chave deste colaborador
        Dim query As String = "select max(chave)+1 from colaborador"
        Dim intChave As Integer = gravaSQLretorno(query)

        query = "insert into colaborador ("
        query += " Chave"
        query += ",colaboradorCPF"
        query += ",colaboradorNome"
        query += ",colaboradorNascimento"
        query += ",colaboradorRG"
        query += ",colaboradorRGoe"
        query += ",colaboradorRGuf"
        query += ",colaboradorRGemissao"
        query += ",colaboradorRGvalidade"
        query += ",colaboradorCTPS"
        query += ",colaboradorCTPSoe"
        query += ",colaboradorCTPSuf"
        query += ",colaboradorCTPSerie"
        query += ",colaboradorCTPSemissao"
        query += ",colaboradorCTPSvalidade"
        query += ",colaboradorCNH"
        query += ",colaboradorCNHoe"
        query += ",colaboradorCNHuf"
        query += ",colaboradorCNHemissao"
        query += ",colaboradorCNHvalidade"
        query += ",colaboradorPIS"
        query += ",colaboradorPISoe"
        query += ",colaboradorPISoeUF"
        query += ",colaboradorPISemissao"
        query += ",colaboradorPISvalidade"
        query += ",colaboradorReservista"
        query += ",colaboradorReservistaOE"
        query += ",colaboradorReservistaOEuf"
        query += ",colaboradorReservistaEmissao"
        query += ",colaboradorReservistaValidade"
        query += ",colaboradorTituloNumero"
        query += ",colaboradorTituloOE"
        query += ",colaboradorTituloOEuf"
        query += ",colaboradorTituloZona"
        query += ",colaboradorTituloSecao"
        query += ",colaboradorTituloEmissao"
        query += ",colaboradorTituloValidade"
        query += ",colaboradorMae"
        query += ",colaboradorMaeCPF"
        query += ",colaboradorMaeFone"
        query += ",colaboradorMaeNascimento"
        query += ",colaboradorPai"
        query += ",colaboradorPaiCPF"
        query += ",colaboradorPaiFone"
        query += ",colaboradorPaiNascimento"
        query += ",colaboradorEstadoCivil"
        query += ",colaboradorUniaoEstavel"
        query += ",colaboradorSexo"
        query += ",colaboradorEsposolNome"
        query += ",colaboradorEsposoCPF"
        query += ",colaboradorEsposoNascimento"
        query += ",colaboradorEsposoFone"
        query += ",colaboradorCompanheiroNome"
        query += ",colaboradorCompanheiroCPF"
        query += ",colaboradorCompanheiroNascimento"
        query += ",colaboradorCompanheiroFone"
        query += ",colaboradorResidencia"
        query += ",colaboradorResidenciaBairro"
        query += ",colaboradorResidenciaCidade"
        query += ",colaboradorResidenciaUF"
        query += ",colaboradorResidenciaCEP"
        query += ",colaboradorFone1"
        query += ",colaboradorFone2"
        query += ",colaboradorEmail"
        query += ",colaboradorAutorizaEmail"
        query += ",colaboradorInstrucao"
        query += ",colaboradorCurso"
        query += ",colaboradorConselhoRegional"
        query += ",colaboradorConselhoRegionalNumero"
        query += ",colaboradorConselhoRegionalData"
        query += ",colaboradorConselhoRegionalOE"
        query += ",colaboradorBanco"
        query += ",colaboradorAgencia"
        query += ",colaboradorContaCorrente"
        query += ",colaboradorContaCorrenteDigito"
        query += ",colaboradorPIX"
        query += ",colaboradorPixIdentificacao"
        query += ",colaboradorDependente1Parentesco"
        query += ",colaboradorDependente1Nome"
        query += ",colaboradorDependente1CPF"
        query += ",colaboradorDependente1Nascimento"
        query += ",colaboradorDependente1IR"
        query += ",colaboradorDependente1SF"
        query += ",colaboradorDependente2Parentesco"
        query += ",colaboradorDependente2Nome"
        query += ",colaboradorDependente2CPF"
        query += ",colaboradorDependente2Nascimento"
        query += ",colaboradorDependente2IR"
        query += ",colaboradorDependente2SF"
        query += ",colaboradorDependente3Parentesco"
        query += ",colaboradorDependente3Nome"
        query += ",colaboradorDependente3CPF"
        query += ",colaboradorDependente3Nascimento"
        query += ",colaboradorDependente3IR"
        query += ",colaboradorDependente3SF"
        query += ",colaboradorDependente4Parentesco"
        query += ",colaboradorDependente4Nome"
        query += ",colaboradorDependente4CPF"
        query += ",colaboradorDependente4Nascimento"
        query += ",colaboradorDependente4IR"
        query += ",colaboradorDependente4SF"
        query += ",colaboradorDependente5Parentesco"
        query += ",colaboradorDependente5Nome"
        query += ",colaboradorDependente5CPF"
        query += ",colaboradorDependente5Nascimento"
        query += ",colaboradorDependente5IR"
        query += ",colaboradorDependente5SF"
        query += ",colaboradorDependente6Parentesco"
        query += ",colaboradorDependente6Nome"
        query += ",colaboradorDependente6CPF"
        query += ",colaboradorDependente6Nascimento"
        query += ",colaboradorDependente6IR"
        query += ",colaboradorDependente6SF"
        query += ",colaboradorDependentesIR"
        query += ",colaboradorDependentesSF"
        query += ",colaboradorDepTotal"
        query += ",colaboradorAltura"
        query += ",colaboradorPeso"
        query += ",colaboradorCabelo"
        query += ",colaboradorOlhos"
        query += ",colaboradorTipoDeSangues"
        query += ",colaboradorCor"
        query += ",colaboradorDeficiente"
        query += ",colaboradorDeficienteTipo"
        query += ",colaboradorDeficienteOutros"
        query += ",colaboradorContatoNome1"
        query += ",colaboradorContatoNome1Telefone"
        query += ",colaboradorContatoNome1Conhecimento"
        query += ",colaboradorContatoNome2"
        query += ",colaboradorContatoNome2telefone"
        query += ",colaboradorContatoNome2Conhecimento"
        query += ",colaboradorEmpresaNome1"
        query += ",colaboradorEmpresaNome1Contato"
        query += ",colaboradorEmpresaNome1Telefone"
        query += ",colaboradorEmpresaNome2"
        query += ",colaboradorEmpresaNome2Contato"
        query += ",colaboradorEmpresaNome2Telefone"
        query += ",colaboradorNomeCracha"
        query += ",colaboradorSetor"
        query += ",colaboradorCBO"
        query += ",colaboradorCargo"
        query += ",colaboradorASOadmissao"
        query += ",colaboradorAdmissao"
        query += ",colaboradorAdmissaoReferencia"
        query += ",colaboradorUsuarioCadastroResponsavel"
        query += ",colaboradorEmpresa"
        query += ",colaboradorStatus"
        query += ")"
        query += " values "
        query += "("
        query += intChave.ToString
        query += ",'" & cl(0).CPF & "'"
        query += ",'" & cl(0).Nome & "'"
        query += ",'" & cl(0).Nascimento & "'"
        query += ",'" & cl(0).rg & "'"
        query += ",'" & Trim(cl(0).rgOE) & "'"
        query += ",'" & cl(0).rgOEuf & "'"
        query += ",'" & cl(0).rgEmissao & "'"
        query += ",'" & cl(0).rgValidade & "'"
        query += ",'" & cl(0).CTPS & "'"
        query += ",'" & Trim(cl(0).CTPSOE) & "'"
        query += ",'" & cl(0).CTPSOEuf & "'"
        query += ",'" & cl(0).CTPSserie & "'"
        query += ",'" & cl(0).CTPSemissao & "'"
        query += ",'" & cl(0).CTPSvalidade & "'"
        query += ",'" & cl(0).cnh & "'"
        query += ",'" & Trim(cl(0).cnhOE) & "'"
        query += ",'" & cl(0).cnhOEuf & "'"
        query += ",'" & cl(0).cnhEmissao & "'"
        query += ",'" & cl(0).cnhValidade & "'"
        query += ",'" & cl(0).PIS & "'"
        query += ",'" & Trim(cl(0).PISoe) & "'"
        query += ",'" & cl(0).PISoeUF & "'"
        query += ",'" & cl(0).PISemissao & "'"
        query += ",'" & cl(0).PISvalidade & "'"
        query += ",'" & cl(0).reser & "'"
        query += ",'" & Trim(cl(0).reserOE) & "'"
        query += ",'" & cl(0).reserOEuf & "'"
        query += ",'" & cl(0).reserEmissao & "'"
        query += ",'" & cl(0).reserValidade & "'"
        query += ",'" & cl(0).te & "'"
        query += ",'" & Trim(cl(0).teOE) & "'"
        query += ",'" & cl(0).teOEuf & "'"
        query += ",'" & cl(0).teZona & "'"
        query += ",'" & cl(0).teSecao & "'"
        query += ",'" & cl(0).teEmissao & "'"
        query += ",'" & cl(0).teValidade & "'"
        query += ",'" & cl(0).Mae & "'"
        query += ",'" & cl(0).MaeCPF & "'"
        query += ",'" & cl(0).MaeFone & "'"
        query += ",'" & cl(0).MaeNascimento & "'"
        query += ",'" & cl(0).pai & "'"
        query += ",'" & cl(0).paiCPF & "'"
        query += ",'" & cl(0).paiFone & "'"
        query += ",'" & cl(0).paiNascimento & "'"
        query += ",'" & cl(0).EstadoCivil & "'"
        query += ",'" & cl(0).UniaoEstavel & "'"
        query += ",'" & cl(0).Sexo & "'"
        query += ",'" & cl(0).Esposa & "'"
        query += ",'" & cl(0).EsposaCPF & "'"
        query += ",'" & cl(0).EsposaNascimento & "'"
        query += ",'" & cl(0).EsposaFone & "'"
        query += ",'" & cl(0).Companheira & "'"
        query += ",'" & cl(0).CompanheiraCPF & "'"
        query += ",'" & cl(0).CompanheiraNascimento & "'"
        query += ",'" & cl(0).CompanheiraFone & "'"
        query += ",'" & cl(0).endereco & "'"
        query += ",'" & cl(0).bairro & "'"
        query += ",'" & cl(0).cidade & "'"
        query += ",'" & cl(0).EndUF & "'"
        query += ",'" & LimpaNumero(cl(0).cep) & "'"
        query += ",'" & cl(0).Fone1 & "'"
        query += ",'" & cl(0).Fone2 & "'"
        query += ",'" & cl(0).email & "'"
        query += ",'" & cl(0).AutorizaComunicaEmail & "'"
        query += ",'" & cl(0).Instrucao & "'"
        query += ",'" & cl(0).Curso & "'"
        query += ",'" & cl(0).ConselhoRegional & "'"
        query += ",'" & cl(0).ConselhoRegionalNumero & "'"
        query += ",'" & cl(0).ConselhoRegionalData & "'"
        query += ",'" & cl(0).ConselhoRegionalOE & "'"
        query += ",'" & cl(0).banco & "'"
        query += ",'" & cl(0).agencia & "'"
        query += ",'" & cl(0).conta & "'"
        query += ",'" & cl(0).contaDigito & "'"
        query += ",'" & cl(0).PIX & "'"
        query += ",'" & cl(0).PIXidentificacao & "'"
        query += ",'" & cl(0).p1 & "'"
        query += ",'" & cl(0).n1 & "'"
        query += ",'" & cl(0).cpf1 & "'"
        query += ",'" & cl(0).nas1 & "'"
        query += ",'" & cl(0).depIR1 & "'"
        query += ",'" & cl(0).depSF1 & "'"
        query += ",'" & cl(0).p2 & "'"
        query += ",'" & cl(0).n2 & "'"
        query += ",'" & cl(0).cpf2 & "'"
        query += ",'" & cl(0).nas2 & "'"
        query += ",'" & cl(0).depIR2 & "'"
        query += ",'" & cl(0).depSF2 & "'"
        query += ",'" & cl(0).p3 & "'"
        query += ",'" & cl(0).n3 & "'"
        query += ",'" & cl(0).cpf3 & "'"
        query += ",'" & cl(0).nas3 & "'"
        query += ",'" & cl(0).depIR3 & "'"
        query += ",'" & cl(0).depSF3 & "'"
        query += ",'" & cl(0).p4 & "'"
        query += ",'" & cl(0).n4 & "'"
        query += ",'" & cl(0).cpf4 & "'"
        query += ",'" & cl(0).nas4 & "'"
        query += ",'" & cl(0).depIR4 & "'"
        query += ",'" & cl(0).depSF4 & "'"
        query += ",'" & cl(0).p5 & "'"
        query += ",'" & cl(0).n5 & "'"
        query += ",'" & cl(0).cpf5 & "'"
        query += ",'" & cl(0).nas5 & "'"
        query += ",'" & cl(0).depIR5 & "'"
        query += ",'" & cl(0).depSF5 & "'"
        query += ",'" & cl(0).p6 & "'"
        query += ",'" & cl(0).n6 & "'"
        query += ",'" & cl(0).cpf6 & "'"
        query += ",'" & cl(0).nas6 & "'"
        query += ",'" & cl(0).depIR6 & "'"
        query += ",'" & cl(0).depSF6 & "'"
        query += "," & cl(0).DependentesIR
        query += "," & cl(0).DependentesSF
        query += "," & cl(0).DependentesTotais
        query += ",'" & cl(0).altura & "'"
        query += ",'" & cl(0).peso & "'"
        query += ",'" & cl(0).cabelo & "'"
        query += ",'" & cl(0).olhos & "'"
        query += ",'" & cl(0).tipoSangue & "'"
        query += ",'" & cl(0).cor & "'"
        query += ",'" & cl(0).deficiente & "'"
        query += ",'" & cl(0).deficienteTipo & "'"
        query += ",'" & cl(0).deficienteOutros & "'"
        query += ",'" & cl(0).nome1 & "'"
        query += ",'" & cl(0).Telefone1 & "'"
        query += ",'" & cl(0).conhecimento1 & "'"
        query += ",'" & cl(0).Nome2 & "'"
        query += ",'" & cl(0).Telefone2 & "'"
        query += ",'" & cl(0).Conhecimento2 & "'"
        query += ",'" & cl(0).Empresa1 & "'"
        query += ",'" & cl(0).Contato1 & "'"
        query += ",'" & cl(0).EmpresaTel1 & "'"
        query += ",'" & cl(0).Empresa2 & "'"
        query += ",'" & cl(0).Contato2 & "'"
        query += ",'" & cl(0).EmpresaTel2 & "'"
        query += ",'" & cl(0).Cracha & "'"
        query += ",'" & cl(0).Setor & "'"
        query += ",'" & cl(0).Cbo & "'"
        query += ",'" & cl(0).Cargo & "'"
        query += ",'" & cl(0).ASOadmissao & "'"
        query += ",'" & cl(0).Admissao & "'"
        query += ",'" & cl(0).AdmissaoRef & "'"
        query += ",'" & LimpaNumero(Form1.Form1chave.Text) & "'"
        query += ",'" & LimpaNumero(Form1.empCNPJ.Text) & "'"             ' CNPJ da empresa												
        query += "," & 0
        query += ")"

        Try

            If Not gravaSQL(query) Then Return (False) : Exit Function


            Dim strChave As String = intChave.ToString
            Dim intNumeroDiretorios = CriaDiretorios()
            With oi
                .msg = "Chave : " & strChave.PadLeft(4, "0")
                .msg += Chr(13)
                .msg += "Colaborador : " & cl(0).Nome
                .msg += Chr(13)
                .msg = "Diretórios Criados :" & intNumeroDiretorios
                .msg += Chr(13)
                .msg += "Registrado com sucesso!"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
                bolRetorno = True
            End With

        Catch ex As Exception
            Dim strChave As String = intChave.ToString
            With oi
                .msg = "Problemas Na Gravação !"
                .msg += Chr(13)
                .msg += ex.Message
                .msg += Chr(13)
                .msg += Chr(13)
                .msg += "Registro não Gravado!"
                .Style = vbCritical
                MsgBox(.msg, .style, .title)
            End With
        End Try

        Return (bolRetorno)

    End Function
    Private Function CriaDiretorios() As Integer

        Dim intContador As Integer = 0
        Dim drt As List(Of ClassFolha_diretorio) = ClassFolha_diretorioAcao.GetFolhaDiretorio(LimpaNumero(Me.lblCPF.Text))

        For i = 0 To drt.Count - 1

            If Not System.IO.Directory.Exists(drt(i).Caminho) Then

                My.Computer.FileSystem.CreateDirectory(drt(i).Caminho)

                intContador += 1

            End If


        Next

        Return (intContador)

    End Function

    Private Sub col_12Setor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles col_12Setor.SelectedIndexChanged

    End Sub
End Class