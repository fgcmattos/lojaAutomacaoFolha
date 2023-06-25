Imports MySql.Data.MySqlClient
Public Class ColaboradorAcoes

    Public Shared Function GetColaboradorDB(chave As String) 'As List(Of colaborador)

        '/ Prenchimento do formulario FcolShow 
        '  Pesquisa de Colaborador

        FcolShow.Show()
        Dim strContrato As String = ""
        Dim strStatus As String = "Inativo"
        Dim query As String = ""

        query = "select "
        query += "FCC_registro_ordem"
        query += ",FCC_status "
        query += "From folha_col_contrato "
        query += "where FCC_keyCol = " & chave & " And FCC_status = 1"

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(query, Conn)

        Try
            If OpenDB() Then

                DTReader = CMD.ExecuteReader
                DTReader.Read()
                strContrato = DTReader.GetValue(0)
                Select Case DTReader.GetValue(1)
                    Case 1
                        strStatus = "Ativo"
                        ''Case 0
                        ''    strStatus = "InAtivo"
                End Select

            End If

        Catch ex As Exception

            strContrato = "Sem Contrato Ativo"

        End Try

        Conn.Close()

        Dim Tb_col As List(Of ClassCol_pesq) = ClassCol_pesqAcao.getColShowDB(chave)

        Dim Caminho As String = ""

        Dim arquivo As Boolean = True

        Try

            Caminho = "C:\" & Trim(LimpaNumero(Form1.empCNPJ.Text.Substring(7))) & "\folha\colaborador\" & Tb_col(0).CPF & "\Foto\Registro\Registro.jpeg"

            'If Not System.IO.File.Exists(Application.StartupPath & Caminho) Then
            If Not System.IO.File.Exists(Caminho) Then

                arquivo = False

            End If

            If arquivo Then

                FcolShow.PictureBox1.Image = Image.FromFile(Caminho)

            End If

            With Tb_col(0)

                FcolShow.lblChave.Text = .Chave
                FcolShow.lblContrato.Text = strContrato.PadLeft(4, "0")
                FcolShow.lblContratoStatus.Text = strStatus
                FcolShow.lblCPF.Text = CPFcolocaMascara(.CPF)
                FcolShow.txtNome.Text = Tb_col(0).Nome
                FcolShow.mskNascimento.Text = dataLatina(.Nascimento)
                FcolShow.lblIdadeCritica.Text = Module1.idade(FcolShow.mskNascimento.Text)
                FcolShow.LblcadastroData.Text = .CadastroDataHora
                FcolShow.LblcadastroTempo.Text = Module1.idade(FcolShow.LblcadastroData.Text.Substring(0, 10))
                FcolShow.LblCadastroAlteracoes.Text = "0"         ' pesquisa a ser criada
                FcolShow.LblCadastroAutoriza.Text = .UsuarioCadastroResponsavel.PadLeft(4, "0")
                FcolShow.col_01_rg.Text = .RG
                FcolShow.col_01_rgOE.Text = .RGoe
                FcolShow.col_01_rgOEuf.Text = .RGuf
                FcolShow.col_01_rgEmissao.Text = dataLatina(.RGemissao)
                FcolShow.col_01_rgValidade.Text = dataLatina(.RGvalidade)
                FcolShow.col_01_CTPS.Text = .CTPS
                FcolShow.col_01_CTPSOE.Text = .CTPSoe
                FcolShow.col_01_CTPSserie.Text = .CTPSserie
                FcolShow.col_01_CTPSOEuf.Text = .CTPSuf
                FcolShow.col_01_CTPSemissao.Text = dataLatina(.CTPSemissao)
                FcolShow.col_01_CTPSvalidade.Text = dataLatina(.CTPSvalidade)
                FcolShow.col_01_cnh.Text = .CNH
                FcolShow.col_01_cnhOE.Text = .CNHoe
                FcolShow.col_01_cnhOEuf.Text = .CNHuf
                FcolShow.col_01_cnhEmissao.Text = dataLatina(.CNHemissao)
                FcolShow.col_01_cnhValidade.Text = dataLatina(.CNHvalidade)
                FcolShow.col_01_PIS.Text = .PIS
                FcolShow.col_01_PISoe.Text = .PISoe
                FcolShow.col_01_PISoeUF.Text = .PISoeUF
                FcolShow.col_01_PISemissao.Text = dataLatina(.PISemissao)
                FcolShow.col_01_PISvalidade.Text = dataLatina(.PISvalidade)
                FcolShow.col_01_reser.Text = .Reservista
                FcolShow.col_01_reserOE.Text = .ReservistaOE
                FcolShow.col_01_reserOEuf.Text = .ReservistaOEuf
                FcolShow.col_01_reserEmissao.Text = dataLatina(.ReservistaEmissao)
                FcolShow.col_01_reserValidade.Text = dataLatina(.ReservistaValidade)
                FcolShow.col_01_te.Text = .TituloNumero
                FcolShow.col_01_teOE.Text = .TituloOE
                FcolShow.col_01_teOEuf.Text = .TituloOEuf
                FcolShow.col_01_teZona.Text = .TituloZona
                FcolShow.col_01_teSecao.Text = .TituloSecao
                FcolShow.col_01_teEmissao.Text = dataLatina(.TituloEmissao)
                FcolShow.col_01_teValidade.Text = dataLatina(.TituloValidade)
                FcolShow.col_02_Mae.Text = .Mae
                FcolShow.col_02_MaeCPF.Text = CPFcolocaMascara(.MaeCPF)
                FcolShow.col_02_MaeNascimento.Text = dataLatina(.MaeNascimento)
                FcolShow.col_02_MaeFone.Text = .MaeFone
                FcolShow.col_02_pai.Text = .Pai
                FcolShow.col_02_paiCPF.Text = CPFcolocaMascara(.PaiCPF)
                FcolShow.col_02_paiNascimento.Text = dataLatina(.PaiNascimento)
                FcolShow.col_02_paiFone.Text = .PaiFone
                FcolShow.col_03Sexo.Text = .Sexo
                FcolShow.col_03EstadoCivil.Text = .EstadoCivil
                FcolShow.col_03EstadoCivilDescricao.Text = gravaSQLretorno("Select ecDescricao from estadoCivil where ecCodigo = " & .EstadoCivil)
                FcolShow.col_03UniaoEstavel.Checked = IIf(.UniaoEstavel = "1", True, False)
                FcolShow.col_03Esposa.Text = .EsposoNome
                FcolShow.col_03EsposaCPF.Text = CPFcolocaMascara(.EsposoCPF)
                FcolShow.col_03EsposaNascimento.Text = dataLatina(.EsposoNascimento)
                FcolShow.col_03EsposaFone.Text = .EsposoFone
                FcolShow.col_03Companheira.Text = .CompanheiroNome
                FcolShow.col_03CompanheiraCPF.Text = CPFcolocaMascara(.CompanheiroCPF)
                FcolShow.col_03CompanheiraNascimento.Text = dataLatina(.CompanheiroNascimento)
                'FcolShow.col_03EstadoCivilDescricao.Text = .EstadoCivil
                FcolShow.col_03CompanheiraFone.Text = .CompanheiroFone
                FcolShow.col_05endereco.Text = .Residencia
                FcolShow.col_05cidade.Text = .ResidenciaCidade
                FcolShow.col_05bairro.Text = .ResidenciaBairro
                FcolShow.cmbEndUF.Text = .ResidenciaUF
                FcolShow.col_05cep.Text = .ResidenciaCEP
                FcolShow.col_04Fone1.Text = .Fone1
                FcolShow.col_04Fone2.Text = .Fone2
                FcolShow.col_04Email.Text = .Email
                FcolShow.col_04AutorizaComunicaEmail.Checked = IIf(.AutorizaEmail = "0", False, True)


                For Each item As String In FColMant.cmbInstrucao.Items

                    If item = .Instrucao.Substring(1, 1) Then

                        FColMant.cmbInstrucao.Text = item

                        Exit For

                    End If
                Next
                FcolShow.col_06GrauInstrucao.Text = .Instrucao.ToString.PadLeft(2, "0") & " - " & gravaSQLretorno("Select Descricao from instrucaograu where instrucao_codigo = " & .Instrucao.ToString)
                FcolShow.col_06Curso.Text = .Curso
                FcolShow.col_06ConselhoRegional.Text = .ConselhoRegional
                FcolShow.col_06ConselhoRegionalNumero.Text = .ConselhoRegionalNumero
                FcolShow.col_06ConselhoRegionalData.Text = dataLatina(.ConselhoRegionalData)
                FcolShow.col_06OE.Text = .ConselhoRegionalOE

                FcolShow.col_08banco.Text = .Banco
                FcolShow.col_08agencia.Text = .Agencia
                FcolShow.col_08conta.Text = .ContaCorrente
                FcolShow.col_08contaDigito.Text = .ContaCorrenteDigito
                FcolShow.col_08PIX_numero.Text = .PIX
                FcolShow.col_08pix_identificacao.Text = .PixIdentificacao

                If .Dependente1Parentesco <> "" Then
                    FcolShow.ListViewDependente.Items.Add(.Dependente1Parentesco)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente1Nome)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente1CPF))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente1Nascimento))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente1Nascimento)))
                End If
                If .Dependente2Parentesco <> "" Then
                    FcolShow.ListViewDependente.Items.Add(.Dependente2Parentesco)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente2Nome)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente2CPF))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente2Nascimento))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente2Nascimento)))
                End If

                If .Dependente3Parentesco <> "" Then
                    FcolShow.ListViewDependente.Items.Add(.Dependente3Parentesco)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente3Nome)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente3CPF))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente3Nascimento))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente3Nascimento)))
                End If

                If .Dependente4Parentesco <> "" Then
                    FcolShow.ListViewDependente.Items.Add(.Dependente4Parentesco)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente4Nome)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente4CPF))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente4Nascimento))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente4Nascimento)))
                End If

                If .Dependente5Parentesco <> "" Then
                    FcolShow.ListViewDependente.Items.Add(.Dependente5Parentesco)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente5Nome)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente5CPF))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente5Nascimento))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente5Nascimento)))
                End If

                If .Dependente6Parentesco <> "" Then
                    FcolShow.ListViewDependente.Items.Add(.Dependente6Parentesco)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente6Nome)
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente6CPF))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente6Nascimento))
                    FcolShow.ListViewDependente.Items(FcolShow.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente6Nascimento)))
                End If

                FcolShow.col_10altura.Text = IIf(LimpaNumero(.Altura) = "", "", .Altura)
                FcolShow.col_10peso.Text = .Peso
                FcolShow.col_10cabelo.Text = .Cabelo
                FcolShow.col_10olhos.Text = .Olhos
                FcolShow.col_10tipoSangue.Text = .TipoDeSangues
                FcolShow.col_10cor.Text = .Cor
                FcolShow.col_10deficiente.Checked = .Deficiente
                FcolShow.col_10deficienteTipo.Text = .DeficienteTipo
                FcolShow.col_10deficienteOutros.Text = .DeficienteOutros
                FcolShow.col_11nome1.Text = .ContatoNome1
                FcolShow.col_11Telefone1.Text = .ContatoNome1Telefone
                FcolShow.col_11conhecimento1.Text = .ContatoNome1Conhecimento
                FcolShow.col_11Nome2.Text = .ContatoNome2
                FcolShow.col_11Telefone2.Text = .ContatoNome2telefone
                FcolShow.col_11Conhecimento2.Text = .ContatoNome2Conhecimento
                FcolShow.col_11Empresa1.Text = .EmpresaNome1
                FcolShow.col_11Contato1.Text = .EmpresaNome1Contato
                FcolShow.col_11EmpresaTel1.Text = .EmpresaNome1Telefone
                FcolShow.col_11Empresa2.Text = .EmpresaNome2
                FcolShow.col_11Contato2.Text = .EmpresaNome2Contato
                FcolShow.col_11EmpresaTel2.Text = .EmpresaNome2Telefone
                FcolShow.col_12cargo.Text = .Cargo
                FcolShow.col_12nomeCracha.Text = .NomeCracha
                FcolShow.col_12ASOadmissao.Text = dataLatina(.ASOadmissao)
                FcolShow.col_12Admissao.Text = dataLatina(.Admissao)
            End With


        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
        'End If

        Conn.Close()
    End Function

    Public Shared Function GetColManutencao(chave As String)

        '/Preenchimento do formulario fColMant
        ' Alteracao de Campos do colaborador

        Dim Tb_col As List(Of ClassCol_pesq) = ClassCol_pesqAcao.getColShowDB(chave)

        FColMant.Show()


        Dim Caminho As String

        Dim arquivo As Boolean = True


        Try


            With Tb_col(0)

                Caminho = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & .CPF & "\Foto\Registro\Registro.jpeg"


                'If Not System.IO.File.Exists(Application.StartupPath & Caminho) Then
                If Not System.IO.File.Exists(Caminho) Then

                    arquivo = False

                End If

                If arquivo Then
                        FColMant.PictureBox1.Image = Image.FromFile(Caminho)
                    End If
                FColMant.LblIdentificador.Text = .Id
                FColMant.LblChave.Text = .Chave
                'FColMant.lblSerie.Text = DTReader.GetString(1)

                FColMant.lblCPF.Text = CPFcolocaMascara(.CPF)
                FColMant.txtNome.Text = .Nome
                FColMant.mskNascimento.Text = dataLatina(.Nascimento)
                FColMant.lblIdadeCritica.Text = Module1.idade(.Nascimento)

                FColMant.col_01_rg.Text = .RG
                FColMant.col_01_rgOE.Text = .RGoe
                FColMant.col_01_rgOEuf.Text = .RGuf
                FColMant.col_01_rgEmissao.Text = dataLatina(.RGemissao)
                FColMant.col_01_rgValidade.Text = dataLatina(.RGvalidade)
                FColMant.col_01_CTPS.Text = .CTPS
                FColMant.col_01_CTPSOE.Text = .CTPSoe
                FColMant.col_01_CTPSserie.Text = .CTPSserie
                FColMant.col_01_CTPSOEuf.Text = .CTPSuf
                FColMant.col_01_CTPSemissao.Text = dataLatina(.CTPSemissao)
                FColMant.col_01_CTPSvalidade.Text = dataLatina(.CTPSvalidade)
                FColMant.col_01_cnh.Text = .CNH
                FColMant.col_01_cnhOE.Text = .CNHoe
                FColMant.col_01_cnhOEuf.Text = .CNHuf
                FColMant.col_01_cnhEmissao.Text = dataLatina(.CNHemissao)
                FColMant.col_01_cnhValidade.Text = dataLatina(.CNHvalidade)
                FColMant.col_01_PIS.Text = IIf(.PIS = "", "___._____.__-_", .PIS)
                FColMant.col_01_PISoe.Text = .PISoe
                FColMant.col_01_PISoeUF.Text = .PISoeUF
                FColMant.col_01_PISemissao.Text = dataLatina(.PISemissao)
                FColMant.col_01_PISvalidade.Text = dataLatina(.PISvalidade)
                FColMant.col_01_reser.Text = .Reservista
                FColMant.col_01_reserOE.Text = .ReservistaOE
                FColMant.col_01_reserOEuf.Text = .ReservistaOEuf
                FColMant.col_01_reserEmissao.Text = dataLatina(.ReservistaEmissao)
                FColMant.col_01_reserValidade.Text = dataLatina(.ReservistaValidade)
                FColMant.col_01_te.Text = .TituloNumero
                FColMant.col_01_teOE.Text = .TituloOE
                FColMant.col_01_teOEuf.Text = .TituloOEuf
                FColMant.col_01_teZona.Text = .TituloZona
                FColMant.col_01_teSecao.Text = .TituloSecao
                FColMant.col_01_teEmissao.Text = dataLatina(.TituloEmissao)
                FColMant.col_01_teValidade.Text = dataLatina(.TituloValidade)

                FColMant.col_02_Mae.Text = .Mae
                FColMant.col_02_MaeCPF.Text = .MaeCPF
                FColMant.col_02_MaeNascimento.Text = .MaeNascimento
                FColMant.col_02_MaeFone.Text = .MaeFone
                FColMant.col_02_pai.Text = .Pai
                FColMant.col_02_paiCPF.Text = .PaiCPF
                FColMant.col_02_paiNascimento.Text = .PaiNascimento
                FColMant.col_02_paiFone.Text = .PaiFone

                ' P E S S O A L
                FColMant.col_03Sexo.Text = .Sexo
                FColMant.col_03EstadoCivil.SelectedIndex = Convert.ToInt32(.EstadoCivil) - 1
                'FColMant.col_03EstadoCivilDescricao.SelectedIndex = Convert.ToInt32(DTReader.GetString(128)) - 1
                FColMant.col_03UniaoEstavel.Checked = IIf(.UniaoEstavel = "1", True, False)
                FColMant.col_03Esposa.Text = .EsposoNome
                FColMant.col_03EsposaCPF.Text = .EsposoCPF
                FColMant.col_03EsposaNascimento.Text = dataLatina(.EsposoNascimento)
                FColMant.col_03EsposaFone.Text = .EsposoFone
                FColMant.col_03Companheira.Text = .CompanheiroNome
                FColMant.col_03CompanheiraCPF.Text = .CompanheiroCPF
                FColMant.col_03CompanheiraNascimento.Text = dataLatina(.CompanheiroNascimento)
                FColMant.col_03CompanheiraFone.Text = .CompanheiroFone

                ' C O N T A T O
                FColMant.col_05endereco.Text = .Residencia
                FColMant.col_05cidade.Text = .ResidenciaCidade
                FColMant.cmbEndUF.SelectedItem = .ResidenciaUF
                FColMant.col_05bairro.Text = .ResidenciaBairro
                FColMant.col_05cep.Text = .ResidenciaCEP
                FColMant.col_04Fone1.Text = .Fone1
                FColMant.col_04Fone2.Text = .Fone2
                FColMant.col_04email.Text = .Email
                FColMant.col_04AutorizaComunicaEmail.Checked = IIf(.AutorizaEmail = "0", False, True)

                For Each item As String In FColMant.cmbInstrucao.Items

                    If item.Substring(0, 2) = .Instrucao Then

                        FColMant.cmbInstrucao.Text = item

                        Exit For

                    End If
                Next

                ' I N S T R U C A O
                FColMant.col_06Curso.Text = .Curso
                FColMant.col_06ConselhoRegional.Text = .ConselhoRegional
                FColMant.col_06ConselhoRegionalNumero.Text = .ConselhoRegionalNumero
                FColMant.col_06ConselhoRegionalData.Text = dataLatina(.ConselhoRegionalData)
                FColMant.col_06OE.Text = .ConselhoRegionalOE

                ' F I N A N C E I R O
                FColMant.col_08banco.Text = .Banco
                FColMant.col_08agencia.Text = .Agencia
                FColMant.col_08conta.Text = .ContaCorrente
                FColMant.col_08contaDigito.Text = .ContaCorrenteDigito
                FColMant.col_08pix_numero.Text = .PIX
                FColMant.col_08pix_identificacao.Text = .PixIdentificacao

                ' D E P E N D E N T E S - I R    E    S A L A R I O  F A M I L I A  - SL
                If .Dependente1Parentesco <> "" Then
                    FColMant.ListViewDependente.Items.Add(.Dependente1Parentesco)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente1Nome)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente1CPF))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente1Nascimento))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente1Nascimento)))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente1IR)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente1SF)


                End If
                If .Dependente2Parentesco <> "" Then
                    FColMant.ListViewDependente.Items.Add(.Dependente2Parentesco)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente2Nome)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente2CPF))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente2Nascimento))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente2Nascimento)))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente2IR)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente2SF)

                End If
                If .Dependente3Parentesco <> "" Then
                    FColMant.ListViewDependente.Items.Add(.Dependente3Parentesco)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente3Nome)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente3CPF))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente3Nascimento))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente3Nascimento)))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente3IR)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente3SF)

                End If
                If .Dependente4Parentesco <> "" Then
                    FColMant.ListViewDependente.Items.Add(.Dependente4Parentesco)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente4Nome)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente4CPF))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente4Nascimento))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente4Nascimento)))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente4IR)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente4SF)

                End If
                If .Dependente5Parentesco <> "" Then
                    FColMant.ListViewDependente.Items.Add(.Dependente5Parentesco)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente5Nome)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente5CPF))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente5Nascimento))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente5Nascimento)))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente5IR)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente5SF)

                End If
                If .Dependente6Parentesco <> "" Then
                    FColMant.ListViewDependente.Items.Add(.Dependente6Parentesco)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente6Nome)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(CPFcolocaMascara(.Dependente6CPF))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(dataLatina(.Dependente6Nascimento))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(idade(dataLatina(.Dependente6Nascimento)))
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente6IR)
                    FColMant.ListViewDependente.Items(FColMant.ListViewDependente.Items.Count - 1).SubItems.Add(.Dependente6SF)

                End If

                FColMant.col_10altura.Text = .Altura
                FColMant.col_10peso.Text = .Peso
                FColMant.col_10cabelo.Text = .Cabelo
                FColMant.col_10olhos.Text = .Olhos
                FColMant.col_10tipoSangue.Text = .TipoDeSangues
                FColMant.col_10cor.Text = .Cor
                FColMant.col_10deficiente.Checked = .Deficiente
                FColMant.col_10deficienteTipo.Text = .DeficienteTipo
                FColMant.col_10deficienteOutros.Text = .DeficienteOutros
                FColMant.col_11nome1.Text = .ContatoNome1
                FColMant.col_11Telefone1.Text = .ContatoNome1Telefone
                FColMant.col_11conhecimento1.Text = .ContatoNome1Conhecimento
                FColMant.col_11Nome2.Text = .ContatoNome2
                FColMant.col_11Telefone2.Text = .ContatoNome2telefone
                FColMant.col_11Conhecimento2.Text = .ContatoNome2Conhecimento

                FColMant.col_11Empresa1.Text = .EmpresaNome1
                FColMant.col_11Contato1.Text = .EmpresaNome1Contato
                FColMant.col_11EmpresaTel1.Text = .EmpresaNome1Telefone
                FColMant.col_11Empresa2.Text = .EmpresaNome2
                FColMant.col_11Contato2.Text = .EmpresaNome2Contato
                FColMant.col_11EmpresaTel2.Text = .EmpresaNome2Telefone
                FColMant.col_12funcao.Text = .Cargo
                FColMant.col_12nomeCracha.Text = .NomeCracha
                FColMant.col_12ASOadmissao.Text = dataLatina(.ASOadmissao)
                FColMant.col_12Admissao.Text = dataLatina(.Admissao)

                FColMant.col_12CBO.Text = .CBO
                FColMant.col_12Setor.Text = .Setor
                FColMant.col_12ASOrescisao.Text = dataLatina(.ASOrescisao)
                FColMant.col_12rescisao.Text = IIf(.RescisaoData <> "", dataLatina(.RescisaoData), "")

                'FColMant.lblSerieCadastradoQuem.Text = DTReader.GetString(126)
                'FColMant.lblSerieCadastradoQuando.Text = DTReader.GetString(125)

            End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


    End Function

    Public Shared Function GetColSQL(chave As String) As List(Of colaborador)

        Dim lista As New List(Of colaborador)

        Dim DTReader As MySqlDataReader

        Dim Query As String = "Call sp_colaboradorShow(" & chave & ")"

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read
                    lista.Add(New colaborador() With
                {
                .CPF = CPFcolocaMascara(DTReader.GetString(2)),
                .Nome = DTReader.GetString(3),
                .Nascimento = dataLatina(DTReader.GetString(4)),
                .rg = DTReader.GetString(5),
                .rgOE = DTReader.GetString(6),
                .rgOEuf = DTReader.GetString(7),
                .rgEmissao = dataLatina(DTReader.GetString(8)),
                .rgValidade = dataLatina(DTReader.GetString(9)),
                .CTPS = DTReader.GetString(10),
                .CTPSOE = DTReader.GetString(11),
                .CTPSserie = DTReader.GetString(13),
                .CTPSOEuf = DTReader.GetString(12),
                .CTPSemissao = dataLatina(DTReader.GetString(14)),
                .CTPSvalidade = dataLatina(DTReader.GetString(15)),
                .cnh = DTReader.GetString(16),
                .cnhOE = DTReader.GetString(17),
                .cnhOEuf = DTReader.GetString(18),
                .cnhEmissao = dataLatina(DTReader.GetString(19)),
                .cnhValidade = dataLatina(DTReader.GetString(20)),
                .PIS = DTReader.GetString(22),
                .PISoe = DTReader.GetString(23),
                .PISoeUF = DTReader.GetString(24),
                .PISemissao = dataLatina(DTReader.GetString(25)),
                .PISvalidade = dataLatina(DTReader.GetString(26)),
                .reser = DTReader.GetString(27),
                .reserOE = DTReader.GetString(28),
                .reserOEuf = DTReader.GetString(29),
                .reserEmissao = dataLatina(DTReader.GetString(30)),
                .reserValidade = dataLatina(DTReader.GetString(31)),
                .te = DTReader.GetString(32),
                .teOE = DTReader.GetString(33),
                .teOEuf = DTReader.GetString(34),
                .teZona = DTReader.GetString(35),
                .teSecao = DTReader.GetString(36),
                .teEmissao = dataLatina(DTReader.GetString(37)),
                .teValidade = dataLatina(DTReader.GetString(38)),
                .Mae = DTReader.GetString(39),
                .MaeCPF = CPFcolocaMascara(DTReader.GetString(40)),
                .MaeNascimento = dataLatina(DTReader.GetString(41)),
                .MaeFone = DTReader.GetString(42),
                .pai = DTReader.GetString(43),
                .paiCPF = CPFcolocaMascara(DTReader.GetString(44)),
                .paiNascimento = dataLatina(DTReader.GetString(45)),
                .paiFone = DTReader.GetString(46),
                .Sexo = DTReader.GetString(49),
                .EstadoCivil = Convert.ToInt32(DTReader.GetString(47)),
                .UniaoEstavel = IIf(DTReader.GetString(48) = "1", True, False),
                .Esposa = DTReader.GetString(50),
                .EsposaCPF = DTReader.GetString(51),
                .EsposaNascimento = dataLatina(DTReader.GetString(52)),
                .EsposaFone = DTReader.GetString(53),
                .Companheira = DTReader.GetString(54),
                .CompanheiraCPF = DTReader.GetString(55),
                .CompanheiraNascimento = dataLatina(DTReader.GetString(56)),
                .CompanheiraFone = DTReader.GetString(57),
                .endereco = DTReader.GetString(58),
                .cidade = DTReader.GetString(59),
                .EndUF = DTReader.GetString(60),
                .cep = DTReader.GetString(61),
                .Fone1 = DTReader.GetString(62),
                .Fone2 = DTReader.GetString(63),
                .email = DTReader.GetString(64),
                .AutorizaComunicaEmail = IIf(DTReader.GetString(65) = "0", False, True),
                .Instrucao = DTReader.GetString(66),
                .Curso = DTReader.GetString(67),
                .ConselhoRegional = DTReader.GetString(68),
                .ConselhoRegionalNumero = DTReader.GetString(69),
                .ConselhoRegionalData = dataLatina(DTReader.GetString(70)),
                .ConselhoRegionalOE = DTReader.GetString(71),
                .banco = DTReader.GetString(72),
                .agencia = DTReader.GetString(73),
                .conta = DTReader.GetString(74),
                .contaDigito = DTReader.GetString(75),
                .PIX = DTReader.GetString(129),
                    .p1 = (DTReader.GetString(76)),
                    .n1 = (DTReader.GetString(77)),
                    .cpf1 = (CPFcolocaMascara(DTReader.GetString(78))),
                    .nas1 = (dataLatina(DTReader.GetString(79))),
                    .depIR1 = DTReader.GetString(141),
                    .depSF1 = DTReader.GetString(142),
                    .p2 = (DTReader.GetString(80)),
                    .n2 = (DTReader.GetString(81)),
                    .cpf2 = (CPFcolocaMascara(DTReader.GetString(82))),
                    .nas2 = (dataLatina(DTReader.GetString(83))),
                    .p3 = (DTReader.GetString(84)),
                    .n3 = (DTReader.GetString(85)),
                    .cpf3 = (CPFcolocaMascara(DTReader.GetString(86))),
                    .nas3 = (dataLatina(DTReader.GetString(87))),
                    .p4 = (DTReader.GetString(88)),
                    .n4 = (DTReader.GetString(89)),
                    .cpf4 = (CPFcolocaMascara(DTReader.GetString(90))),
                    .nas4 = (dataLatina(DTReader.GetString(91))),
                    .p5 = (DTReader.GetString(92)),
                    .n5 = (DTReader.GetString(93)),
                    .cpf5 = (CPFcolocaMascara(DTReader.GetString(94))),
                    .nas5 = (dataLatina(DTReader.GetString(95))),
                    .p6 = (DTReader.GetString(96)),
                    .n6 = (DTReader.GetString(97)),
                    .cpf6 = (CPFcolocaMascara(DTReader.GetString(98))),
                    .nas6 = (dataLatina(DTReader.GetString(99))),
                .altura = DTReader.GetString(100),
                .peso = DTReader.GetString(101),
                .cabelo = DTReader.GetString(102),
                .olhos = DTReader.GetString(103),
                .tipoSangue = DTReader.GetString(104),
                .cor = DTReader.GetString(105),
                .deficiente = DTReader.GetString(106),
                .deficienteTipo = DTReader.GetString(107),
                .deficienteOutros = DTReader.GetString(108),
                .nome1 = DTReader.GetString(109),
                .Telefone1 = DTReader.GetString(110),
                .conhecimento1 = DTReader.GetString(111),
                .Nome2 = DTReader.GetString(112),
                .Telefone2 = DTReader.GetString(113),
                .Conhecimento2 = DTReader.GetString(114),
                .Empresa1 = DTReader.GetString(115),
                .Contato1 = DTReader.GetString(116),
                .EmpresaTel1 = DTReader.GetString(117),
                .Empresa2 = DTReader.GetString(118),
                .Contato2 = DTReader.GetString(119),
                .EmpresaTel2 = DTReader.GetString(120),
                .Cargo = DTReader.GetString(121),
                .Cracha = DTReader.GetString(122),
                .ASOadmissao = dataLatina(DTReader.GetString(123)),
                .Admissao = dataLatina(DTReader.GetString(124)),
                .AdmissaoRef = DTReader.GetString(125),
                .DependentesIR = DTReader.GetString(137),
                .DependentesSF = DTReader.GetString(138),
                .Cbo = DTReader.GetString(139),
                .Setor = DTReader.GetString(140),
                .ASOrescisao = dataLatina(DTReader.GetString(136)),
                .rescisao = dataLatina(DTReader.GetString(135)),
                .bairro = DTReader.GetString(134)
                }
                )
                End While
            Catch ex As Exception
                MsgBox("Problemas na base de dados!",, "Classe ColaboradorAcoes GetColSQL")
            End Try
            Conn.Close()
        End If


        Return lista
    End Function

    Public Shared Function GetColContratoSQL(Chave As Integer) As List(Of colaborador)

        Dim strChave As String = Chave

        Dim lista As New List(Of colaborador)

        Dim DTReader As MySqlDataReader

        Dim Query As String = ""

        Query = "Select "
        Query += "chave"
        Query += ",colaboradorNome"
        Query += ",colaboradorCPF"
        Query += ",colaboradorRG"
        Query += ",colaboradorPIS"
        Query += ",colaboradorCTPS"
        Query += ",colaboradorCTPSerie"
        Query += ",colaboradorAdmissao"
        Query += ",colaboradorASOadmissao"
        Query += " from colaborador "
        Query += " where "
        Query += " chave = " & strChave


        Try
            Dim CMD As New MySqlCommand(Query, Conn)

            If OpenDB() Then

                DTReader = CMD.ExecuteReader

                While DTReader.Read
                    lista.Add(New colaborador() With
            {
            .Chave = DTReader.GetString(0),
            .Nome = DTReader.GetString(1),
            .CPF = CPFcolocaMascara(DTReader.GetString(2)),
            .rg = DTReader.GetString(3),
            .PIS = DTReader.GetString(4),
            .CTPS = DTReader.GetString(5),
            .CTPSserie = DTReader.GetString(6),
            .Admissao = dataLatina(DTReader.GetString(7)),
            .ASOadmissao = dataLatina(DTReader.GetString(8))
            }
            )
                End While
            End If
        Catch ex As Exception

        End Try

        Conn.Close()


        Return lista

    End Function

End Class
