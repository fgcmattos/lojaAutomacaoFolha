Public Class formUsuarioManutencao
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub formUsuarioManutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblUsuário.Text = usuClass.Usuario_Nome

    End Sub

    Private Sub BtnGrava_Click(sender As Object, e As EventArgs) Handles BtnGrava.Click

        If TxtSenhaAtual.Text <> usuClass.Usario_senha Then

            MsgBox("Senha atual não confere", vbCritical, Me.Text)

            TxtSenhaAtual.Focus()

            Exit Sub

        End If

        If Len(Trim(TxtSenhaNova.Text)) < 8 Then

            MsgBox("Nova Senha tem menos do que 8 digitos", vbCritical, Me.Text)

            TxtSenhaNova.Focus()

            Exit Sub

        End If

        If TxtSenhaNova.Text <> TxtSenhaNovaConferencia.Text Then

            MsgBox("Nova Senha diferente da confirmação", vbCritical, Me.Text)

            TxtSenhaNova.Focus()

            Exit Sub

        End If

        If MsgBox("Confirma a alteração da Senha ", vbYesNo, Me.Text) = 6 Then


            Dim Query As String

            Query = "Update usuario set "
            Query += "usuarioSenha = " & TxtSenhaNova.Text
            Query += " where "
            Query += "usuarioChave = '" & usuClass.Usuario_Chave & "'"
            Query += " and "
            Query += "usuarioTipo = '" & usuClass.Usuario_Tipo & "'"

            If gravaSQL(Query) Then

                usuClass.Usario_senha = TxtSenhaNova.Text
                MsgBox("Senha alterada com sucesso", vbExclamation, Me.Text)

            Else
                MsgBox("Senha não Alterada", vbExclamation, Me.Text)
            End If

        Else

            MsgBox("Cancelada a alteração da Senha", vbExclamation, Me.Text)

        End If

    End Sub
End Class