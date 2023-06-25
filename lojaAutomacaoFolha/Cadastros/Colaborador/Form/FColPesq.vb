Imports MySql.Data.MySqlClient
Public Class FColPesq
    Public oi As New MsgShow

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        If lblTipo.Text = "P E S Q U I S A  - F I C H A   C A D A S T R A L" Then

            ColaboradorAcoes.GetColaboradorDB(Mid(ListBox1.SelectedItem, 1, 5))

        Else

            FColMant.LblChave.Text = Mid(ListBox1.SelectedItem, 1, 5)
            ColaboradorAcoes.GetColManutencao(FColMant.LblChave.Text)
            If FColMant.col_10deficiente.Checked Then FColMant.grpDeficiencia.Enabled = True

        End If

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click


        Dim chaveLocal As String = IIf(ChavePesq.Text = "", "0", ChavePesq.Text)
        Dim nomeLocal As String = Trim(NomePesq.Text)


        'query = "Call colaboradorPesq(" & chaveLocal & ",'" & nomeLocal & "')"

        Dim query As String = "select lpad(chave,5,'0'),colaboradorNome from colaborador "

        ListBox1.Items.Clear()


        Dim queryWhere As String = ""

        If chaveLocal <> "0" Then

            queryWhere = " where chave = " & chaveLocal

        Else

            If nomeLocal <> "" Then queryWhere = " where colaboradorNome Like '%" & nomeLocal & "%'"

        End If



        If queryWhere <> "" Then query += queryWhere

        query += " Order by colaboradorNome"

        If OpenDB() Then
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    ListBox1.Items.Add(DTReader.GetString(0) & " " & DTReader.GetString(1))

                End While

            Catch ex As Exception

                MsgBox("Nada foi encontrado!")
            End Try
            Conn.Close()

            If ListBox1.Items.Count() = 0 Then
                With oi

                    .msg = "Nada Foi encontrado na pesquisa! "
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)

                End With
            End If

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class