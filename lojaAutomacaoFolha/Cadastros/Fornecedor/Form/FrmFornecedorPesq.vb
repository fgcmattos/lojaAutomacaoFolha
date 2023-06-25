Imports MySql.Data.MySqlClient

Public Class FrmFornecedorPesq
    Dim oi As New MsgShow
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click


        Dim chaveLocal As String = IIf(CNPJretiraMascara(MskCNPJ.Text) = "", "0", CNPJretiraMascara(MskCNPJ.Text))
        Dim nomeLocal As String = Trim(TxtRazao.Text)


        'query = "Call colaboradorPesq(" & chaveLocal & ",'" & nomeLocal & "')"

        Dim query As String = "select forIdentificacao forIdentificacao,forRazaoSocial,forRazaoFantasia from fornecedor "

        ListBox1.Items.Clear()


        Dim queryWhere As String = ""

        If chaveLocal <> "0" Then

            queryWhere = " where forIdentificacao = '" & chaveLocal & "'"

        Else

            If nomeLocal <> "" Then queryWhere = " where forRazaoSocial Like '%" & nomeLocal & "%'"

        End If



        If queryWhere <> "" Then query += queryWhere

        query += " Order by forRazaoSocial"

        If OpenDB() Then
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    ListBox1.Items.Add(CNPJcolocaMascara(DTReader.GetString(0)) & " | " & DTReader.GetString(1))

                End While

            Catch ex As Exception

                MsgBox("Nada foi encontrado!")
            End Try
            Conn.Close()

            If ListBox1.Items.Count() = 0 Then
                With oi

                    .Msg = "Nada Foi encontrado na pesquisa! "
                    .Style = vbExclamation
                    MsgBox(.Msg, .Style, .Title)

                End With
            End If

        End If

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        Dim StrCNPJ As String = CNPJretiraMascara(Mid(ListBox1.SelectedItem, 1, 18))

        FrmFornecedorMostra.Show()

        ClassFornecedorAcao.FornecedorGravaDBobjeto(StrCNPJ)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class