Imports MySql.Data.MySqlClient
Public Class frmDBselecao
    Dim oi As New MsgShow
    Private Sub frmDBselecao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Query As String = ""

        Query = "select "
        Query += "empCNPJ"
        Query += ",empFantasi"
        Query += ",empSociaGerente"
        Query += ",empTelefoneFixo1"
        Query += " from empresa order by empNome"

        Reg.DB = "resumo"

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                With LvDB

                    .Items.Clear()
                    Dim intElementos As Integer = 0
                    While DTReader.Read()
                        .Items.Add(CNPJcolocaMascara(DTReader(0)))
                        intElementos = .Items.Count - 1
                        .Items(intElementos).SubItems.Add(DTReader(1))
                        .Items(intElementos).SubItems.Add(IIf(IsDBNull(DTReader(2)), "", DTReader(2)))
                        .Items(intElementos).SubItems.Add(IIf(IsDBNull(DTReader(3)), "", DTReader(3)))
                    End While

                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conn.Close()
            Reg.DB = "comercio"
        End If

    End Sub

    Private Sub LvDB_DoubleClick(sender As Object, e As EventArgs) Handles LvDB.DoubleClick

        Dim Indice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = LvDB.SelectedIndices

        Indice = lv.Item(0) ' indice selecionado no listview

        Dim strCNPJ As String = ""

        With oi

            .msg = "Empresa : " & LvDB.Items(Indice).SubItems(1).Text
            .msg += Chr(13)
            .msg += "CNPJ   : " & LvDB.Items(Indice).SubItems(0).Text
            .msg += Chr(13)
            .msg += "Responsável : " & LvDB.Items(Indice).SubItems(2).Text
            .msg += Chr(13) & Chr(13)
            .msg += "Confirma  Base de Dados ?"
            .style = vbYesNo
            .title = Me.Text
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta = 6 Then

                strCNPJ = CNPJretiraMascara(LvDB.Items(Indice).Text)

                Reg.DB = strCNPJ
                StatusDeCapa()
                .msg = "OK ! Base trocada."
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
                Me.Close()

            End If
        End With
    End Sub
End Class