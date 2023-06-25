Public Class frmADMcad
    Dim oi As New MsgShow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oi.title = Me.Text
        If Not CPFdigito(LimpaNumero(MskCPF.Text)) Then
            With oi
                .msg = "CPFdigito inválido!"
                .msg = Chr(13)
                .msg = "Por favor entre com um CPF válido"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                MskCPF.Focus()
                Exit Sub
            End With

        End If
        If Trim(TxtNome.Text).Length < 5 Then
            With oi
                .msg = "Nome inválido!"
                .msg = Chr(13)
                .msg = "Por favor entre com um Nome com mais de 5 digitos"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                TxtNome.Focus()
                Exit Sub
            End With
        End If

        If Trim(TxtUsuarioNome.Text).Length < 5 Then
            With oi
                .msg = "Nome inválido!"
                .msg = Chr(13)
                .msg = "Por favor entre com um Nome de usuário entre 5 digitos e 15 digitos"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                TxtUsuarioNome.Focus()
                Exit Sub
            End With
        End If

        If Trim(TxtSenha.Text).Length < 8 Then
            With oi
                .msg = "Senha inválida!"
                .msg = Chr(13)
                .msg = "Por favor entre com uma Senha com mais de 7 digitos"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                TxtSenha.Focus()
                Exit Sub
            End With
        End If

        If Trim(TxtSenhaConfirma.Text) <> TxtSenha.Text Then

            With oi
                .msg = "Senhas Diferentes!"
                .msg = Chr(13)
                .msg = "Por favor entre com a mesma Senha nos dois campos"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                TxtSenhaConfirma.Focus()
                Exit Sub
            End With
        End If

        Dim query As String = ""

        query = "Insert into usuario_administrador "
        query += "("
        query += "UA_UsuarioNome"
        query += ",UA_CPF"
        query += ",UA_Nome"
        query += ",UA_Tipo"
        query += ")"
        query += " values "
        query += "("
        query += "'" & TxtUsuarioNome.Text & " '"
        query += ",'" & LimpaNumero(MskCPF.Text) & "'"
        query += ",'" & TxtNome.Text & " '"
        query += ",'A'"
        query += ");"
        query += "Insert into usuario "
        query += "("
        query += "usuarioChave"
        query += ",usuarioSenha"
        query += ",usuarioTipo"
        query += ",usuarioStatus"
        query += ",usuarioDescricao"
        query += ")"
        query += " values "
        query += "("
        query += "'" & TxtUsuarioNome.Text & " '"
        query += ",'" & TxtSenha.Text & "'"
        query += ",'A'"
        query += ",1"
        query += ",'Administrador cadastro inicial'"
        query += ");"

        gravaSQL(query)

        With oi
            .msg = "Administrador cadastrado Com sucesso !"
            .style = vbExclamation
            MsgBox(.msg, .style, .title)
        End With

        Me.Close()

    End Sub
End Class