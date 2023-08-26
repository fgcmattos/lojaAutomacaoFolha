Imports MySql.Data.MySqlClient
Public Class FcolCadCargo
    Dim oi As New MsgShow
    Private Sub FcolCadCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oi.Title = Me.Text

        ComboCarregar(Me.CmbSetor, "folha_setor", "concat(folha_setor_codigo,' - ' , folha_setor_descricao)", "")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CarregaListView()

    End Sub

    Private Sub BtnGrava_Click(sender As Object, e As EventArgs) Handles BtnGrava.Click

        Dim strCodigo As String = Trim(MskCodigo.Text)
        Dim strDescricao As String = Trim(TxtDescricao.Text)

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
                TxtDescricao.Focus()
                Exit Sub

            End With
        End If

        For i = 0 To ListView1.Items.Count - 1
            If Convert.ToInt32(strCodigo) = ListView1.Items(i).SubItems(0).Text Then
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
        Query = "Insert into folha_cargo "
        Query += "("
        Query += "folha_cargo_codigo"
        Query += ",folha_cargo_descricao"
        Query += ",folha_cargo_setor"
        Query += ")"
        Query += " values "
        Query += "("
        Query += MskCodigo.Text
        Query += ",'" & TxtDescricao.Text & "'"
        Query += "," & CmbSetor.Text.Substring(0, 2)
        Query += ")"
        gravaSQL(Query)

        'reiniciaTela()
        TxtDescricao.Text = ""
        MskCodigo.Text = "___"
        CarregaListView()

        'CmbSetor.Items.Clear()
        'CmbSetor.Focus()

    End Sub

    Private Sub CarregaListView()

        ListView1.Items.Clear()
        Dim query As String = ""
        query = "Select folha_cargo_Codigo,folha_cargo_descricao From folha_cargo"
        query += " where folha_cargo_setor = " & CmbSetor.Text.Substring(0, 2)
        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    ListView1.Items.Add(DTReader.GetValue(0))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetValue(1))

                End While

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            Conn.Close()

        End If

    End Sub

End Class