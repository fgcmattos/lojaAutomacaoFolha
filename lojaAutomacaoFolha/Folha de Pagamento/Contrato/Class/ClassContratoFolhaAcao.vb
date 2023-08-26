Imports MySql.Data.MySqlClient
Public Class ClassContratoFolhaAcao

    Public Shared Function GetFolhaContratoDB(StrContrato As String) As List(Of ClassContratoFolha)

        Dim Query As String = ""

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassContratoFolha)

        Query += "select "
        Query += "id_FCC"
        Query += ",FCC_numero"
        Query += ",FCC_tipo"
        Query += ",FCC_tipoDescricao"
        Query += ",FCC_afastamentoDescricao"
        Query += ",FCC_remuneracaoMesAnterior"
        Query += ",FCC_admissao_data"
        Query += ",FCC_avisoPrevio_data"
        Query += ",FCC_afastamento_data"
        Query += ",FCC_afastamentoCodigo"
        Query += ",FCC_pensaoAlimenticiaTRCT"
        Query += ",FCC_pensaoAlimenticiaFGTS"
        Query += ",FCC_categoriaCodigo"
        Query += ",FCC_categoriaDescricao"
        Query += ",FCC_sindical_codigo"
        Query += ",FCC_CNPJentidadeSindical"
        Query += ",FCC_RazaoEntidadeSindical"
        Query += ",FCC_keyCol"
        Query += ",FCC_status"
        Query += ",FCC_nome"
        Query += ",FCC_cpf"
        Query += ",FCC_rg"
        Query += ",FCC_pis"
        Query += ",FCC_ctps_numero"
        Query += ",FCC_ctps_serie"
        Query += ",FCC_aso_admissao"
        Query += ",FCC_setor"
        Query += ",FCC_cargo"
        Query += ",FCC_cbo"
        Query += ",FCC_referencia"
        Query += ",FCC_salario"
        Query += ",FCC_registro_fisico"
        Query += ",FCC_registro_livro"
        Query += ",FCC_registro_pagina"
        Query += ",FCC_registro_ordem"
        Query += ",FCC_carga_horaria_semanal"
        Query += ",FCC_descanso_semanal"
        Query += ",FCC_jornada_dia_inicio"
        Query += ",FCC_jornada_descanso"
        Query += ",FCC_jornada_dia"
        Query += ",FCC_jornada_mes"
        Query += ",FCC_jornada_dia_fim"
        Query += ",FCC_criacao"
        Query += ",FCC_responsavel"
        Query += ",FCC_tipoDescricao"
        Query += " From folha_col_contrato"
        Query += " where "
        Query += "FCC_numero = '" & StrContrato & "'"

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassContratoFolha() With
                        {
                        .id_FCC = DTReader.GetValue(0),
                        .FCC_numero = DTReader.GetValue(1),
                        .FCC_tipo = DTReader.GetValue(2),
                        .FCC_tipoDescricao = DTReader.GetValue(3),
                        .FCC_afastamentoDescricao = DTReader.GetValue(4),
                        .FCC_remuneracaoMesAnterior = DTReader.GetValue(5),
                        .FCC_admissao_data = DTReader.GetValue(6),
                        .FCC_avisoPrevio_data = DTReader.GetValue(7),
                        .FCC_afastamento_data = DTReader.GetValue(8),
                        .FCC_afastamentoCodigo = DTReader.GetValue(9),
                        .FCC_pensaoAlimenticiaTRCT = DTReader.GetValue(10),
                        .FCC_pensaoAlimenticiaFGTS = DTReader.GetValue(11),
                        .FCC_categoriaCodigo = DTReader.GetValue(12),
                        .FCC_categoriaDescricao = DTReader.GetValue(13),
                        .FCC_sindical_codigo = DTReader.GetValue(14),
                        .FCC_CNPJentidadeSindical = DTReader.GetValue(15),
                        .FCC_RazaoEntidadeSindical = DTReader.GetValue(16),
                        .FCC_keyCol = DTReader.GetValue(17),
                        .FCC_status = DTReader.GetValue(18),
                        .FCC_nome = DTReader.GetValue(19),
                        .FCC_cpf = DTReader.GetValue(20),
                        .FCC_rg = DTReader.GetValue(21),
                        .FCC_pis = DTReader.GetValue(22),
                        .FCC_ctps_numero = DTReader.GetValue(23),
                        .FCC_ctps_serie = DTReader.GetValue(24),
                        .FCC_aso_admissao = DTReader.GetValue(25),
                        .FCC_setor = DTReader.GetValue(26),
                        .FCC_cargo = DTReader.GetValue(27),
                        .FCC_cbo = DTReader.GetValue(28),
                        .FCC_referencia = DTReader.GetValue(29),
                        .FCC_salario = DTReader.GetValue(30),
                        .FCC_registro_fisico = DTReader.GetValue(31),
                        .FCC_registro_livro = DTReader.GetValue(32),
                        .FCC_registro_pagina = DTReader.GetValue(33),
                        .FCC_registro_ordem = DTReader.GetValue(34),
                        .FCC_carga_horaria_semanal = DTReader.GetValue(35),
                        .FCC_descanso_semanal = DTReader.GetValue(36),
                        .FCC_jornada_dia_inicio = DTReader.GetValue(37),
                        .FCC_jornada_descanso = DTReader.GetValue(38),
                        .FCC_jornada_dia = DTReader.GetValue(39),
                        .FCC_jornada_mes = DTReader.GetValue(40),
                        .FCC_jornada_dia_fim = DTReader.GetValue(41),
                        .FCC_criacao = DTReader.GetValue(42),
                        .FCC_responsavel = DTReader.GetValue(43)
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

    Public Shared Sub PutFolhaContratoTL(CtFolha As Object)


        With FrmfolhaContratoManutencao

            .LblNome.Text = CtFolha.FCC_nome
            .LblChave.Text = CtFolha.FCC_keyCol
            .LblPIS.Text = CtFolha.FCC_pis
            .LblCTPSnumero.Text = CtFolha.FCC_ctps_numero
            .LblRG.Text = CtFolha.FCC_rg
            .LblCPF.Text = CtFolha.FCC_cpf
            .LblCTPSserie.Text = CtFolha.FCC_ctps_serie
            .LblAdmissao.Text = CtFolha.FCC_admissao_data
            .LblASOadmissao.Text = CtFolha.FCC_aso_admissao

            .CmbTipo.Text = CtFolha.FCC_tipoDescricao


        End With

    End Sub


End Class
