Imports MySql.Data.MySqlClient

Public Class ClassColaborador_HoleriteAcao


    Public Shared Function getColaboradoresAptosDB() As List(Of ClassColaborador_Holerite)

        Dim Query As String = ""

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassColaborador_Holerite)

        Dim strAponta As String = ""

        Query += "select"
        Query += " chave"
        Query += ",colaboradornome"
        Query += ",colaboradorSalarioatual"
        Query += ",colaboradorStatus"
        Query += ",colaboradorDependentesIR"
        Query += ",colaboradorHorasTrabalhadasSemana"
        Query += ",colaboradorDiasDescansoSemana"
        Query += ",colaboradorAdmissao"
        Query += ",colaboradorAdmissaoReferencia"
        Query += ",colaboradorCBO"
        Query += ",colaboradorFuncao"
        Query += ",colaboradorSetor"
        Query += ",colaboradorDependenteSF"
        Query += " From colaborador "
        Query += " Where "
        Query += " colaboradorstatus = 100 "

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassColaborador_Holerite() With
                    {
                    .keyCol = DTReader.GetValue(0),
                    .Nome = DTReader.GetValue(1),
                    .SalarioAtual = DTReader.GetValue(2),
                    .Status = DTReader.GetValue(3),
                    .DependentesIR = DTReader.GetValue(4),
                    .colaboradorHorasTrabalhadasSemana = DTReader.GetValue(5),
                    .colaboradorDiasDescansoSemanaas = DTReader.GetValue(6),
                    .colaboradorAdmissao = DTReader.GetValue(7),
                    .colaboradorAdmissaoReferencia = DTReader.GetValue(8),
                    .colaboradorCBO = DTReader.GetValue(9),
                    .colaboradorFuncao = DTReader.GetValue(10),
                    .colaboradorSetor = DTReader.GetValue(11),
                    .colaboradorDependenteSF = DTReader.GetValue(12)
                    }
                    )
                End While
            Catch ex As Exception

                MsgBox("Problemas ApontaAcoes!")

            End Try

        End If

        Conn.Close()

        Return lista

    End Function

End Class
