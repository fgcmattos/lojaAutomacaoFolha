Imports MySql.Data.MySqlClient
Public Class ClassCol_pesqAcao

    Public Shared Function getColShowDB(chave As Integer) As List(Of ClassCol_pesq)

        Dim DTReader As MySqlDataReader

        Dim Query As String = Col_query_show(chave)

        Dim CMD As New MySqlCommand(Query, Conn)

        Dim lista As New List(Of ClassCol_pesq)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassCol_pesq() With
                        {
                        .Id = DTReader.GetValue(0),
                        .Chave = DTReader.GetValue(1),
                        .CPF = DTReader.GetValue(2),
                        .Nome = DTReader.GetValue(3),
                        .Nascimento = DTReader.GetValue(4),
                        .RG = DTReader.GetValue(5),
                        .RGoe = DTReader.GetValue(6),
                        .RGuf = DTReader.GetValue(7),
                        .RGemissao = DTReader.GetValue(8),
                        .RGvalidade = DTReader.GetValue(9),
                        .CTPS = DTReader.GetValue(10),
                        .CTPSoe = DTReader.GetValue(11),
                        .CTPSuf = DTReader.GetValue(12),
                        .CTPSserie = DTReader.GetValue(13),
                        .CTPSemissao = DTReader.GetValue(14),
                        .CTPSvalidade = DTReader.GetValue(15),
                        .CNH = DTReader.GetValue(16),
                        .CNHoe = DTReader.GetValue(17),
                        .CNHuf = DTReader.GetValue(18),
                        .CNHemissao = DTReader.GetValue(19),
                        .CNHvalidade = DTReader.GetValue(20),
                        .CNH1habilitacao = DTReader.GetValue(21),
                        .PIS = DTReader.GetValue(22),
                        .PISoe = DTReader.GetValue(23),
                        .PISoeUF = DTReader.GetValue(24),
                        .PISemissao = DTReader.GetValue(25),
                        .PISvalidade = DTReader.GetValue(26),
                        .Reservista = DTReader.GetValue(27),
                        .ReservistaOE = DTReader.GetValue(28),
                        .ReservistaOEuf = DTReader.GetValue(29),
                        .ReservistaEmissao = DTReader.GetValue(30),
                        .ReservistaValidade = DTReader.GetValue(31),
                        .TituloNumero = DTReader.GetValue(32),
                        .TituloOE = DTReader.GetValue(33),
                        .TituloOEuf = DTReader.GetValue(34),
                        .TituloZona = DTReader.GetValue(35),
                        .TituloSecao = DTReader.GetValue(36),
                        .TituloEmissao = DTReader.GetValue(37),
                        .TituloValidade = DTReader.GetValue(38),
                        .Mae = DTReader.GetValue(39),
                        .MaeCPF = DTReader.GetValue(40),
                        .MaeNascimento = DTReader.GetValue(41),
                        .MaeFone = DTReader.GetValue(42),
                        .Pai = DTReader.GetValue(43),
                        .PaiCPF = DTReader.GetValue(44),
                        .PaiNascimento = DTReader.GetValue(45),
                        .PaiFone = DTReader.GetValue(46),
                        .EstadoCivil = DTReader.GetValue(47),
                        .UniaoEstavel = DTReader.GetValue(48),
                        .Sexo = DTReader.GetValue(49),
                        .EsposoNome = DTReader.GetValue(50),
                        .EsposoCPF = DTReader.GetValue(51),
                        .EsposoNascimento = DTReader.GetValue(52),
                        .EsposoFone = DTReader.GetValue(53),
                        .CompanheiroNome = DTReader.GetValue(54),
                        .CompanheiroCPF = DTReader.GetValue(55),
                        .CompanheiroNascimento = DTReader.GetValue(56),
                        .CompanheiroFone = DTReader.GetValue(57),
                        .Residencia = DTReader.GetValue(58),
                        .ResidenciaCidade = DTReader.GetValue(59),
                        .ResidenciaUF = DTReader.GetValue(60),
                        .ResidenciaCEP = DTReader.GetValue(61),
                        .Fone1 = DTReader.GetValue(62),
                        .Fone2 = DTReader.GetValue(63),
                        .Email = DTReader.GetValue(64),
                        .AutorizaEmail = DTReader.GetValue(65),
                        .Instrucao = DTReader.GetValue(66),
                        .Curso = DTReader.GetValue(67),
                        .ConselhoRegional = DTReader.GetValue(68),
                        .ConselhoRegionalNumero = DTReader.GetValue(69),
                        .ConselhoRegionalData = DTReader.GetValue(70),
                        .ConselhoRegionalOE = DTReader.GetValue(71),
                        .Banco = DTReader.GetValue(72),
                        .Agencia = DTReader.GetValue(73),
                        .ContaCorrente = DTReader.GetValue(74),
                        .ContaCorrenteDigito = DTReader.GetValue(75),
                        .Dependente1Parentesco = DTReader.GetValue(76),
                        .Dependente1Nome = DTReader.GetValue(77),
                        .Dependente1CPF = DTReader.GetValue(78),
                        .Dependente1Nascimento = DTReader.GetValue(79),
                        .Dependente2Parentesco = DTReader.GetValue(80),
                        .Dependente2Nome = DTReader.GetValue(81),
                        .Dependente2CPF = DTReader.GetValue(82),
                        .Dependente2Nascimento = DTReader.GetValue(83),
                        .Dependente3Parentesco = DTReader.GetValue(84),
                        .Dependente3Nome = DTReader.GetValue(85),
                        .Dependente3CPF = DTReader.GetValue(86),
                        .Dependente3Nascimento = DTReader.GetValue(87),
                        .Dependente4Parentesco = DTReader.GetValue(88),
                        .Dependente4Nome = DTReader.GetValue(89),
                        .Dependente4CPF = DTReader.GetValue(90),
                        .Dependente4Nascimento = DTReader.GetValue(91),
                        .Dependente5Parentesco = DTReader.GetValue(92),
                        .Dependente5Nome = DTReader.GetValue(93),
                        .Dependente5CPF = DTReader.GetValue(94),
                        .Dependente5Nascimento = DTReader.GetValue(95),
                        .Dependente6Parentesco = DTReader.GetValue(96),
                        .Dependente6Nome = DTReader.GetValue(97),
                        .Dependente6CPF = DTReader.GetValue(98),
                        .Dependente6Nascimento = DTReader.GetValue(99),
                        .Altura = DTReader.GetValue(100),
                        .Peso = DTReader.GetValue(101),
                        .Cabelo = DTReader.GetValue(102),
                        .Olhos = DTReader.GetValue(103),
                        .TipoDeSangues = DTReader.GetValue(104),
                        .Cor = DTReader.GetValue(105),
                        .Deficiente = DTReader.GetValue(106),
                        .DeficienteTipo = DTReader.GetValue(107),
                        .DeficienteOutros = DTReader.GetValue(108),
                        .ContatoNome1 = DTReader.GetValue(109),
                        .ContatoNome1Telefone = DTReader.GetValue(110),
                        .ContatoNome1Conhecimento = DTReader.GetValue(111),
                        .ContatoNome2 = DTReader.GetValue(112),
                        .ContatoNome2telefone = DTReader.GetValue(113),
                        .ContatoNome2Conhecimento = DTReader.GetValue(114),
                        .EmpresaNome1 = DTReader.GetValue(115),
                        .EmpresaNome1Contato = DTReader.GetValue(116),
                        .EmpresaNome1Telefone = DTReader.GetValue(117),
                        .EmpresaNome2 = DTReader.GetValue(118),
                        .EmpresaNome2Contato = DTReader.GetValue(119),
                        .EmpresaNome2Telefone = DTReader.GetValue(120),
                        .Cargo = DTReader.GetValue(121),
                        .NomeCracha = DTReader.GetValue(122),
                        .ASOadmissao = DTReader.GetValue(123),
                        .Admissao = DTReader.GetValue(124),
                        .AdmissaoReferencia = DTReader.GetValue(125),
                        .CadastroDataHora = DTReader.GetValue(126),
                        .UsuarioCadastroResponsavel = DTReader.GetValue(127),
                        .Status = DTReader.GetValue(128),
                        .PIX = DTReader.GetValue(129),
                        .SalarioAtual = DTReader.GetValue(130),
                        .HorasTrabalhadasSemana = DTReader.GetValue(131),
                        .DiasDescansoSemana = DTReader.GetValue(132),
                        .ResidenciaBairro = DTReader.GetValue(133),
                        .RescisaoData = DTReader.GetValue(134),
                        .ASOrescisao = DTReader.GetValue(135),
                        .DependentesIR = DTReader.GetValue(136),
                        .DependentesSF = DTReader.GetValue(137),
                        .CBO = DTReader.GetValue(138),
                        .Setor = DTReader.GetValue(139),
                        .Dependente1IR = DTReader.GetValue(140),
                        .Dependente1SF = DTReader.GetValue(141),
                        .Dependente2IR = DTReader.GetValue(142),
                        .Dependente2SF = DTReader.GetValue(143),
                        .Dependente3IR = DTReader.GetValue(144),
                        .Dependente3SF = DTReader.GetValue(145),
                        .Dependente4IR = DTReader.GetValue(146),
                        .Dependente4SF = DTReader.GetValue(147),
                        .Dependente5IR = DTReader.GetValue(148),
                        .Dependente5SF = DTReader.GetValue(149),
                        .Dependente6IR = DTReader.GetValue(150),
                        .Dependente6SF = DTReader.GetValue(151),
                        .Categoria = DTReader.GetValue(152),
                        .ContratoTipo = DTReader.GetValue(153),
                        .Empresa = DTReader.GetValue(154),
                        .PixIdentificacao = DTReader.GetValue(155),
                        .DepTotal = IIf(DTReader.GetValue(156) = "", 0, DTReader.GetValue(156))
                        }
                        )
                End While
            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

        Conn.Close()

        Return lista


    End Function




End Class
