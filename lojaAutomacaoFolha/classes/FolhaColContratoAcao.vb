Imports MySql.Data.MySqlClient
Public Class FolhaColContratoAcao


    Public Shared Function GetEmpregadorFolhaColContrato(strKeyCol As String) As List(Of FolhaColContrato)

        Dim lista As New List(Of FolhaColContrato)



        Dim Query As String = "select "

        Query += "FCC_Tipo"                         '0
        Query += ",FCC_tipoDescricao"               '1
        Query += ",FCC_afastamentoDescricao"        '2
        Query += ",FCC_remuneracaoMesAnterior"      '3
        Query += ",FCC_admissao_data"               '4
        Query += ",FCC_avisoPrevio_data"            '5
        Query += ",FCC_afastamento_data"            '6
        Query += ",FCC_afastamentoCodigo"           '7
        Query += ",FCC_afastamentoDescricao"        '8
        Query += ",FCC_pensaoAlimenticiaTRCT"       '9
        Query += ",FCC_pensaoAlimenticiaFGTS"       '10
        Query += ",FCC_categoriaCodigo"             '11
        Query += ",FCC_categoriaDescricao"          '12
        Query += ",FCC_sindical_codigo"             '13
        Query += ",FCC_CNPJentidadeSindical"        '14
        Query += ",FCC_RazaoEntidadeSindical"       '15


        Query += " from folha_col_contrato"
        Query += " where FCC_keyCol =" & strKeyCol

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                lista.Add(New FolhaColContrato() With
                    {
                    .ContratoTipo = DTReader.GetValue(0) & ". " & DTReader.GetValue(1),
                    .AfastamentoCausa = DTReader.GetValue(2),
                    .RemuneracaoMesAnterior = DTReader.GetValue(3),
                    .AdmissaoData = DTReader.GetValue(4),
                    .AvisoPrevioData = DTReader.GetValue(5),
                    .AfastamentoData = DTReader.GetValue(6),
                    .AfastamentoCodigo = DTReader.GetValue(7),
                    .PensaoAlimenticiaTRCT = DTReader.GetValue(9),
                    .PensaoAlimenticiaFGTS = DTReader.GetValue(10),
                    .Categoria = DTReader.GetValue(11) & "-" & DTReader.GetValue(12),
                    .SindicalCodigo = DTReader.GetValue(13),
                    .CNPJEntidadeSindical = DTReader.GetValue(14) & "," & DTReader.GetValue(15)
                    }
                    )

            Catch ex As Exception
                Dim oi As New MsgShow
                With oi
                    .msg = "Colaborador sem Contrato gravado no Sistema!"
                    .msg = Chr(13) & Chr(13)
                    .msg = "Realize a gravação do contrato e retorne a esta rotina"
                    .title = "Destrato de contrato de trabalho"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Function
                End With


            End Try

            Conn.Close()
        End If

        Return lista
    End Function

    Public Shared Function GetEmpregadorFolhaColContratoRescisaoAviso(strKeyCol As String) As List(Of FolhaColContrato)

        Dim lista As New List(Of FolhaColContrato)

        Dim Query As String = ""


        Query += "Select "
        Query += "col.chave"                        '0
        Query += ",col.colaboradorNome"             '1
        Query += ",col.colaboradorAdmissao"         '2
        Query += ",col.colaboradorCategoria"        '3
        Query += ",fcat.Fcc_descricao"              '4
        Query += ",fcc.FCC_Tipo"                    '5
        Query += ",fcc.FCC_tipoDescricao"           '6
        Query += ",emp.empSindicalCodigo"           '7
        Query += ",emp.empSindicalCNPJ"             '8
        Query += ",emp.empSindicalRazaoSocial"      '9
        Query += ",col.colaboradorCPF"              '10
        Query += ",col.colaboradorSalarioAtual"     '11
        Query += ",col.colaboradorFuncao"           '12
        Query += " from "
        Query += "colaborador                   col"
        Query += ",folha_col_contrato           fcc"
        Query += ",folha_col_contrato_categoria fcat"
        Query += ",empresa                      emp"

        Query += " where "
        Query += "col.colaboradorContratoTipo = fcc.FCC_tipo"
        Query += " And "
        Query += "col.colaboradorCategoria = fcat.fcc_codigo"
        Query += " And "
        Query += "col.colaboradorEmpresa = emp.empCNPJ"
        Query += " And "
        Query += "col.chave = " & strKeyCol


        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                lista.Add(New FolhaColContrato() With
                    {
                    .Colaborador = DTReader.GetValue(1),
                    .AdmissaoData = DTReader.GetValue(2),
                    .ColaboradorCPF = DTReader.GetValue(10),
                    .ContratoTipo = DTReader.GetValue(5),
                    .ContratoTipoDescricao = DTReader.GetValue(6),
                    .AfastamentoCausa = DTReader.GetValue(2),
                    .RemuneracaoMesAnterior = DTReader.GetValue(3),
                    .Categoria = DTReader.GetValue(3),
                    .Categoriadescricao = DTReader.GetValue(4),
                    .SindicalCodigo = DTReader.GetValue(7),
                    .CNPJEntidadeSindical = CNPJcolocaMascara(DTReader.GetValue(8)) & "," & DTReader.GetValue(9),
                    .RemuneracaoAtual = DTReader.GetValue(11),
                    .ColaboradorCargo = DTReader.GetValue(12)
                    }
                    )

            Catch ex As Exception
                Dim oi As New MsgShow
                With oi
                    .msg = "Colaborador sem Contrato gravado no Sistema!"
                    .msg = Chr(13) & Chr(13)
                    .msg = "Realize a gravação do contrato e retorne a esta rotina"
                    .title = "Destrato de contrato de trabalho"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Function
                End With

            End Try

            Conn.Close()
        End If

        Return lista
    End Function



End Class
