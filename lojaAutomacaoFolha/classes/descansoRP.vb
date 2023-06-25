Imports MySql.Data.MySqlClient
Public Class descansoRP

    Public Shared Function GetDescanso(anoMes As String) As List(Of descanso)
        Dim lista As New List(Of descanso)

        If OpenDB() Then

            Dim query As String = "select data,diaDaSemana,diaSemanaCodigo,SemanaDoAno ,(select count(*)-1 from descanso where data = t1.data) as qto from ( select * from descanso where chave = " & FmrDescanso.MskChave.Text & " and substring(data,1,6) = '" & anoMes & "' order by chave,data ) t1"

            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    lista.Add(New descanso() With
                {
                    .data = DTReader.GetString(0),
                    .DSnome = DTReader.GetString(1),
                    .DSnomeCodigo = DTReader.GetString(2),
                    .SemanaDoAno = DTReader.GetString(3),
                    .mesmaData = DTReader.GetString(4)
                }
                )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura!")
            End Try

            Conn.Close()
        End If


        Return lista
    End Function

End Class
