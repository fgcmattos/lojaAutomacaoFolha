Imports MySql.Data.MySqlClient
Public Class ClassFolha_holerite_close_corpAcao


    Public Shared Function GetHoleriteCorpDB(ref As String) As List(Of ClassFolha_holerite_close_corp)

        Dim strRef As Integer = ref

        Dim Query As String = ""

        Query += "Select "
        Query += " idFcloseCorpo"
        Query += ",lpad(FcloseCorpo_keyCol,6,'0')"
        Query += ",FcloseCorpo_referencia"
        Query += ",FcloseCorpo_rubrica"
        Query += ",FcloseCorpo_descricao"
        Query += ",FcloseCorpo_QTO"
        Query += ",FcloseCorpo_UN"
        Query += ",FcloseCorpo_usuario"
        Query += ",FcloseCorpo_data_gravacao"
        Query += ",FcloseCorpo_base_INSS"
        Query += ",FcloseCorpo_base_FGTS"
        Query += ",FcloseCorpo_base_IR"
        Query += ",FcloseCorpo_tipo_financeiro"
        Query += ",FcloseCorpo_valor"
        Query += ",FcloseCorpo_valor_base"
        Query += ",FcloseCorpo_data_ocorrencia"
        Query += ",FcloseCorpo_historico"
        Query += ",FcloseCorpo_debito_holerite"
        Query += ",FcloseCorpo_credito_holerite"
        Query += ",ID_folha_close_cab"
        Query += " from folha_close_corpo"
        Query += " where FcloseCorpo_referencia = '" & strRef & "'"
        Query += " order by  FcloseCorpo_keyCol,ID_folha_close_cab "

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassFolha_holerite_close_corp)

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then


            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassFolha_holerite_close_corp() With
                        {
                            .Class_idFcloseCorpo = DTReader.GetValue(0),
                            .Class_keyCol = DTReader.GetValue(1),
                            .Class_referencia = DTReader.GetValue(2),
                            .Class_rubrica = DTReader.GetValue(3),
                            .Class_descricao = DTReader.GetValue(4),
                            .Class_QTO = DTReader.GetValue(5),
                            .Class_UN = DTReader.GetValue(6),
                            .Class_usuario = DTReader.GetValue(7),
                            .Class_data_gravacao = DTReader.GetValue(8),
                            .Class_base_INSS = DTReader.GetValue(9),
                            .Class_base_FGTS = DTReader.GetValue(10),
                            .Class_base_IR = DTReader.GetValue(11),
                            .Class_tipo_financeiro = DTReader.GetValue(12),
                            .Class_valor = DTReader.GetValue(13),
                            .Class_valor_base = DTReader.GetValue(14),
                            .Class_data_ocorrencia = DTReader.GetValue(15),
                            .Class_historico = DTReader.GetValue(16),
                            .Class_debito_holerite = DTReader.GetValue(17),
                            .Class_credito_holerite = DTReader.GetValue(18),
                            .Class_ID_folha_close_cab = DTReader.GetValue(19)
                        }
                        )
                End While

            Catch ex As Exception

                MsgBox("Problemas com ClassFolha_holerite_close_corp!")

            End Try

        End If

        Conn.Close()

        Return lista

    End Function


End Class
