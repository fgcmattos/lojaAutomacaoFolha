Imports MySql.Data.MySqlClient
Public Class FolHolLancAcao

    Public Shared Function GetVariaveisSQL(col_key As Integer, referencia As String) As List(Of FolHolLanc)

        Dim lista As New List(Of FolHolLanc)

        Dim DTReader As MySqlDataReader

        Dim Query As String
        Query = "SELECT "
        Query += "Fl_referencia"
        Query += ",FL_KEY_col"
        Query += ",FL_VARIAVEL"
        Query += ",FL_DESCRICAO"
        Query += ",FL_QTO"
        Query += ",FL_UNIDADE"
        Query += ",FL_base_INSS"
        Query += ",FL_base_FGTS"
        Query += ",FL_base_IR "
        Query += ",FL_tipo_financeiro "
        Query += ",FL_valor "
        Query += ",if(isNULL(FL_valor_base),0,FL_valor_base)"
        Query += ",FL_data_ocorrencia"
        Query += ",FL_historico"
        Query += ",FL_calculo"
        Query += ",FL_calculo_parametro"
        Query += " FROM Folha_lancamento "
        Query += " Where "
        Query += "Fl_key_col = " + col_key.ToString
        Query += " and Fl_referencia = '" + referencia + "'"
        Query += " and Fl_folha_tipo = 1"

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read



                    lista.Add(New FolHolLanc() With
                {
                .referencia = DTReader.GetString(0),
                .Col_key = DTReader.GetString(1),
                .Variavel = DTReader.GetString(2),
                .Descricao = DTReader.GetString(3),
                .Qto = DTReader.GetString(4),
                .Unidade = DTReader.GetString(5),
                .Base_INSS = IIf(DTReader.GetString(6) = "S", True, False),
                .Base_fgts = IIf(DTReader.GetString(7) = "S", True, False),
                .Base_ir = IIf(DTReader.GetString(8) = "S", True, False),
                .TipoFinanceiro = DTReader.GetString(9),
                .Valor = DTReader.GetString(10),
                .ValorBase = DTReader.GetString(11),
                .DataOcorrencia = IIf(DTReader.GetString(12) = Nothing, "", DTReader.GetString(12)),
                .Historico = DTReader.GetString(13),
                .Calculo = DTReader.GetString(14),
                .Calculo_parametro = DTReader.GetString(15)
               }
                )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura da Base de Dados! FolHolLancAcao.GetINSStabelaSQL()")
            End Try

            Conn.Close()

        End If

        Return lista
    End Function
    Public Shared Function GetViaveisAutomaticas(key_col As String) As List(Of FolHolLanc)
        Dim lista As New List(Of FolHolLanc)

        Dim DTReader As MySqlDataReader

        Dim Query As String
        Query = "SELECT "
        Query += " FV_codigo"
        Query += ",FV_nome"
        Query += ",FV_UNIDADE"
        Query += ",FV_baseINSS"
        Query += ",FV_baseFGTS"
        Query += ",FV_baseIR "
        Query += ",FV_tipo_financeiro "
        Query += ",FV_valor "
        Query += ",FV_QTO"
        Query += ",FV_calculo"
        Query += ",FV_calculo_parametro"

        Query += " FROM folha_variaveis_colaborador_auto "
        Query += " where FV_key_col = " + key_col


        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read



                    lista.Add(New FolHolLanc() With
                {
                .Variavel = DTReader.GetString(0),
                .Descricao = DTReader.GetString(1),
                .Unidade = DTReader.GetString(2),
                .Base_INSS = IIf(DTReader.GetString(3) = "S", True, False),
                .Base_fgts = IIf(DTReader.GetString(4) = "S", True, False),
                .Base_ir = IIf(DTReader.GetString(5) = "S", True, False),
                .TipoFinanceiro = DTReader.GetString(6),
                .Valor = DTReader.GetString(7),
                .Qto = DTReader.GetString(8),
                .Calculo = DTReader.GetString(9),
                .Calculo_parametro = DTReader.GetString(10)
               }
                )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura da Base de Dados! FolHolLancAcao.GetViaveisAutomsticas()")
            End Try

            Conn.Close()

        End If

        Return lista
    End Function
End Class
