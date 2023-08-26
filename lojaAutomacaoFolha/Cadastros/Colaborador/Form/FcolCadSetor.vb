Imports MySql.Data.MySqlClient
Public Class FcolCadSetor
    Dim oi As New MsgShow
    Private Sub FcolCadSetor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'oi.title = Me.Text
        'Dim Query As String
        'Dim IntQto As Integer = 0

        ReiniciaListView()

        'Query = "Select count(*) from folha_setor"

        'If gravaSQLretorno(Query) > 0 Then

        '    Query = "Select lpad(folha_setor_codigo,4,'0'),folha_setor_descricao"
        '    Query += ",(select count(*) from colaborador where colaboradorSetor = folha_setor.folha_setor_codigo and colaboradorStatus = 100)"
        '    Query += "from folha_setor order by folha_setor_codigo"

        '    Dim DTReader As MySqlDataReader
        '    Dim CMD As New MySqlCommand(Query, Conn)

        '    ListView1.Items.Clear()

        '    If OpenDB() Then

        '        DTReader = CMD.ExecuteReader

        '        While DTReader.Read()

        '            ListView1.Items.Add(DTReader.GetValue(0))
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetValue(1))
        '            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetValue(2))

        '        End While

        '        Conn.Close()

        '    End If
        'End If

    End Sub
    Private Sub ReiniciaListView()

        Dim Query As String
        Query = "Select count(*) from folha_setor"

        If gravaSQLretorno(Query) > 0 Then

            Query = "Select lpad(folha_setor_codigo,4,'0'),folha_setor_descricao"
            Query += ",(select count(*) from colaborador where colaboradorSetor = folha_setor.folha_setor_codigo and colaboradorStatus = 100)"
            Query += "from folha_setor order by folha_setor_codigo"

            Dim DTReader As MySqlDataReader
            Dim CMD As New MySqlCommand(Query, Conn)

            ListView1.Items.Clear()

            If OpenDB() Then

                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    ListView1.Items.Add(DTReader.GetValue(0))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetValue(1))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetValue(2))

                End While

                Conn.Close()

            End If

        End If

    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick

        'MsgBox(e.Column)
        Dim sortColumn As Integer = 0
        ' If current column is not the previously clicked column
        ' Add

        If e.Column <> sortColumn Then

            ' Set the sort column to the new column
            sortColumn = e.Column

            'Default to ascending sort order
            ListView1.Sorting = SortOrder.Ascending

        Else

            'Flip the sort order
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If

        'Set the ListviewItemSorter property to a new ListviewItemComparer object
        Me.ListView1.ListViewItemSorter = New ClassListViewItemComparer(e.Column, ListView1.Sorting)

        ' Call the sort method to manually sort
        ListView1.Sort()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnGrava_Click(sender As Object, e As EventArgs) Handles BtnGrava.Click
        Dim strCodigo As String = Trim(MskCodigo.Text)
        Dim strDescricao As String = Trim(Txtdescricao.Text)

        If strCodigo = "" Then
            With oi
                .msg = "Código inválido !"
                .msg += Chr(13)
                .msg += Chr(13)
                .msg = "Por favor, digite um código válido."
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                MskCodigo.Focus()
                Exit Sub

            End With
        End If

        If strDescricao = "" Then
            With oi
                .msg = "Descrição inválida !"
                .msg += Chr(13)
                .msg += Chr(13)
                .msg = "Por favor, digite uma descrição para o código."
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                Txtdescricao.Focus()
                Exit Sub

            End With
        End If

        For i = 0 To ListView1.Items.Count - 1
            If Convert.ToInt32(strCodigo) = ListView1.Items(i).Text Then
                With oi
                    .msg = "Código já Cadastrado !"
                    .msg += Chr(13)
                    .msg += Chr(13)
                    .msg = "Por favor, crie um código válido."
                    .style = vbCritical
                    MsgBox(.msg, .style, .title)
                    Exit Sub
                End With
            End If
        Next

        Dim Query As String = ""
        Query = "Insert into folha_setor "
        Query += "("
        Query += "folha_setor_codigo"
        Query += ",folha_setor_descricao"
        Query += ")"
        Query += " values "
        Query += "("
        Query += MskCodigo.Text
        Query += ",'" & Txtdescricao.Text & "'"
        Query += ")"
        gravaSQL(Query)

        reiniciaTela()

    End Sub
    Private Sub reiniciaTela()
        MskCodigo.Text = "____"
        Txtdescricao.Text = ""
        ReiniciaListView()
    End Sub

    Private Sub BtnTermina_Click(sender As Object, e As EventArgs) Handles BtnTermina.Click
        Me.Close()
    End Sub
End Class