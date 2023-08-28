Imports MySql.Data.MySqlClient
Public Class folhaPontoCaptura
    Public Shared Function GetPonto() As List(Of folCaptDiario)
        Dim lista As New List(Of folCaptDiario)
        Dim chave As Integer = Int(frmFolhaDiarioRelatorio.folhaDiarioColaborador.SelectedItem.ToString.Substring(0, 5))
        Dim d1 As String = dataAAAAMMDD(frmFolhaDiarioRelatorio.mskDataInicio.Text)
        Dim d2 As String = dataAAAAMMDD(frmFolhaDiarioRelatorio.mskDataFim.Text)
        Dim acTempo As String = bhSaldoHoras(chave, frmFolhaDiarioRelatorio.mskDataInicio.Text)

        If OpenDB() Then

            Dim Query As String = "call folhaPonto(" & chave & ",'" & d1 & "','" & d2 & "')"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    acTempo = hhmmSoma(acTempo, DTReader.GetString(8), 1, 1)
                    lista.Add(New folCaptDiario() With
                            {
                            .chave = DTReader.GetString(0),
                            .colaborador = DTReader.GetString(1),
                            .data = dataLatina(DTReader.GetString(1)),
                            .entrada = IIf(DTReader.GetString(15) <> "2", hhmmFormat(DTReader.GetString(2)), "DESCANSO"),
                            .entradaDescanso = hhmmFormat(DTReader.GetString(4)),
                            .saidaDescanso = hhmmFormat(DTReader.GetString(3)),
                            .saida = hhmmFormat(DTReader.GetString(5)),
                            .tempoApuradoDescanso = hhmmFormat(DTReader.GetString(7)),
                            .tempoApuradoTotal = hhmmFormat(DTReader.GetString(6)),
                            .tempoBH = hhmmFormat(DTReader.GetString(8)),
                            .tempoBHAcumulado = acTempo
                             })
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura!")
            End Try

            Conn.Close()

        End If

        Return lista
    End Function
End Class
