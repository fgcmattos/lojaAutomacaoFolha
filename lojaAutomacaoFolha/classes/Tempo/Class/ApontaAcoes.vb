Imports MySql.Data.MySqlClient
Public Class ApontaAcoes

    Public Shared Function GetApontaDB() As List(Of Aponta)

        Dim Query As String = "Select DATE_FORMAT(now(), '%Y%m%d%H%i%s')"

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of Aponta)

        Dim strAponta As String = ""

        Dim strTempo As String = ""

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then


            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()
                strAponta = DTReader(0)

                strTempo = strAponta.Substring(8)

                strTempo = strTempo.Substring(0, 2) & ":" & strTempo.Substring(2, 2) & ":" & strTempo.Substring(4, 2)

                lista.Add(New Aponta() With
                {
                .Data = strAponta.Substring(0, 8),                      ' AAAAMMDD
                .Tempo = strTempo,                                      ' HH:MM:SS
                .MesDia = strAponta.Substring(6, 2),
                .MesNumero = strAponta.Substring(4, 2),
                .MesNome = mesNome(Int(.MesNumero)),
                .Ano = strAponta.Substring(0, 4),
                .AnoPontoMes = .Ano & "." & .MesNumero,
                .Completo = strAponta
                }
                )

            Catch ex As Exception

                MsgBox("Problemas ApontaAcoes!")

            End Try

        End If

        Conn.Close()

        Return lista

    End Function
End Class
