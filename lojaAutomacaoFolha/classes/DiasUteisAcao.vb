Imports MySql.Data.MySqlClient
Public Class DiasUteisAcao

    Public Shared Function GetDiasUteisCabSQL(AnoMes As String) As List(Of DiasUteisCab)

        Dim lista As New List(Of DiasUteisCab)

        Dim DTReader As MySqlDataReader

        Dim Query As String = ""

        Query += "select "
        Query += "idDUCab"
        Query += ",DUCabAnoMes"
        Query += ",DUCabNome"
        Query += ",DUCabDiasCorrido"
        Query += ",DUCabDiasUteis"
        Query += ",DUCabDiasDescanso"
        Query += ",DUCabDomingos"
        Query += ",DUCabFeriados"
        Query += ",DUCabNumSemanaInicial"
        Query += ",DUCabNumSemanaFinal"

        Query += " from diasuteiscab "
        Query += "Where "
        Query += "DUCabAnoMes = '" & AnoMes & "' "

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read

                    lista.Add(New DiasUteisCab() With
                {
                .idCab = DTReader(0),
                .DUCabAnoMes = DTReader(1),
                .DUCabNome = DTReader(2),
                .DUCabDiasCorrido = DTReader(3),
                .DUCabDiasUteis = DTReader(4),
                .DUCabDiasDescanso = DTReader(5),
                .DUCabDomingos = DTReader(6),
                .DUCabFeriados = DTReader(7),
                .DUCabNumSemanaInicial = DTReader(8),
                .DUCabNumSemanaFinal = DTReader(9)
                }
                )
                End While

            Catch ex As Exception

                MsgBox("Referência cdastrada ")

            End Try

            Conn.Close()
        End If


        Return lista

    End Function

    Public Shared Function GetDiasUteisCorpoSQL(idCab As Integer) As List(Of DiasUteisCorpo)

        Dim lista As New List(Of DiasUteisCorpo)

        Dim DTReader As MySqlDataReader

        Dim Query As String = ""

        Query += "select "
        Query += "idDUcab"
        Query += ",diasuteisCorpoDia"
        Query += ",diasuteisCorpoTipo"
        Query += ",diasuteisCorpoTitulo"
        Query += ",diasuteisCorpoSemana"
        Query += ",diasuteiscorpoHistorico"
        Query += ",iddiasuteisCorpo"


        Query += " from diasuteiscorpo "
        Query += "Where "
        Query += "idDUcab = " & idCab
        Query += " order by diasuteisCorpoDia "

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim strDiaDoMes As String = ""

        If OpenDB() Then

            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read
                    strDiaDoMes = DTReader.GetValue(1)
                    strDiaDoMes = strDiaDoMes.PadLeft(2, "0")
                    lista.Add(New DiasUteisCorpo() With
                {
                .idDUcab = DTReader.GetValue(0),
                .diasuteisCorpoDia = strDiaDoMes,
                .diasuteisCorpoTipo = DTReader.GetValue(2),
                .diasuteisCorpoTitulo = DTReader.GetValue(3),
                .diasuteisCorpoSemana = DTReader.GetValue(4),
                .diasuteisCorpoHistorico = DTReader.GetValue(5),
                .id_corpo = DTReader.GetValue(6)
                }
                )
                End While


            Catch ex As Exception

                MsgBox("Erro de leitura ")

            End Try

            Conn.Close()
        End If


        Return lista

    End Function

    Public Shared Function GetDiasUteisCorpoLvw(idCab As Integer) As List(Of DiasUteisCorpo)

        Dim lista As New List(Of DiasUteisCorpo)
        For i = 0 To FrmFolhaRefDescanso.LvwShow.Items.Count - 1
            lista.Add(New DiasUteisCorpo() With
                {
                .idDUcab = idCab,
                .diasuteisCorpoDia = FrmFolhaRefDescanso.LvwShow.Items(i).SubItems(0).Text,
                .diasuteisCorpoTipo = FrmFolhaRefDescanso.LvwShow.Items(i).SubItems(1).Text,
                .diasuteisCorpoTitulo = FrmFolhaRefDescanso.LvwShow.Items(i).SubItems(2).Text,
                .diasuteisCorpoSemana = FrmFolhaRefDescanso.LvwShow.Items(i).SubItems(3).Text,
                .diasuteisCorpoHistorico = FrmFolhaRefDescanso.LvwShow.Items(i).SubItems(4).Text
                }
                )
        Next

        Return lista

    End Function

End Class
