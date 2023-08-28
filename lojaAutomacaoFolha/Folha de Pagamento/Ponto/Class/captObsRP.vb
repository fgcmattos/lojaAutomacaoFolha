Imports MySql.Data.MySqlClient
Public Class captObsRP

    Public Shared Function GetcaptObs() As List(Of captObs)
        Dim lista As New List(Of captObs)
        Dim chave As Integer = frmFolhaDiarioRelatorio.lblChave.Text
        Dim data1 As String = dataAAAAMMDD(frmFolhaDiarioRelatorio.mskDataInicio.Text)
        Dim data2 As String = dataAAAAMMDD(frmFolhaDiarioRelatorio.mskDataFim.Text)

        If OpenDB() Then

            Dim query As String = "call pontoCorrecoes(" & chave & ",'" & data1 & "','" & data2 & "')"
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    lista.Add(New captObs() With
                {
                    .DataDaCorrecao = DTReader.GetString(0),            ' Data Para correcao
                    .HorarioAcorrigir = DTReader.GetString(1),          ' Horario a corrigir
                    .HorarioCorrigido = DTReader.GetString(2),          ' Horario corrigido
                    .DataDaCorrecaoDoHorario = DTReader.GetString(3),   ' Data da correcao
                    .NSR = DTReader.GetString(4),                       ' NSR
                    .OBS = DTReader.GetString(5),                       ' OBS
                    .Responsavel = "Silvana"
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

