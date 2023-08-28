Imports MySql.Data.MySqlClient
Public Class turnoRP

    Public Shared Function GetTurno() As List(Of turno)
        Dim lista As New List(Of turno)

        If OpenDB() Then

            'Dim query As String = "call pontoCorrecoes(" & chave & ",'" & data1 & "','" & data2 & "')"
            Dim query As String = "select *, (select count(*)  from turno_colaborador where turno.idturno=turno_colaboradorTurno and isnull(turno_colaboradorDataSaida)) as qto from turno"
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    lista.Add(New turno() With
                {
                    .idTurno = DTReader.GetString(0),
                    .nome = DTReader.GetString(1),
                    .diasTrabSemanal = DTReader.GetString(2), ' 
                    .tempoSemanal = DTReader.GetString(3),              ' 
                    .turnoDuracao = DTReader.GetString(4),              ' 
                    .inicio = DTReader.GetString(5),                    ' 
                    .descanso = DTReader.GetString(6),                  '
                    .toleranciaEntrada = DTReader.GetString(7),         ' 
                    .turnoFim = DTReader.GetString(8),
                    .atrasoEntrada = DTReader.GetString(9),
                    .descansoContabilizado = DTReader.GetString(10),
                    .funcionariosNoTurno = DTReader.GetString(11)
                }
                )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura das correções!")
            End Try

            Conn.Close()
        End If


        Return lista
    End Function
End Class
