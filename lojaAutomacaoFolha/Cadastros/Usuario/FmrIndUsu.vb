Imports MySql.Data.MySqlClient

Public Class FmrIndUsu
    Dim mtMenu(1000, 1) As String
    Dim linha As Integer = 0
    Dim oi As New MsgShow

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub FmrIndUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oi.Title = Me.Text

    End Sub

    Function MenuAbertura(chave As String) As Integer

        If OpenDB() Then
            Dim Query As String = "Select menuIdentificador,menu_On from `" & Reg.DB & "`.menu_usuario where menuusuario = '" & chave & "' order by menuNivel"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            linha = 0
            Try
                DTReader = CMD.ExecuteReader


                While DTReader.Read

                    'DTReader.GetString(0)
                    mtMenu(linha, 0) = DTReader.GetString(0)
                    mtMenu(linha, 1) = DTReader.GetString(1)
                    linha += 1

                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conn.Close()
            linha -= 1

        End If
        MenuAbertura = linha

    End Function

    Function Licenca(chave As String, tipo As String, pass As String) As Boolean

        Licenca = False

        If OpenDB() Then
            Dim Query As String

            Query = "Select "
            Query += "count(*) as qto"
            Query += ",usuarioChave"
            Query += ", usuarioTipo"
            Query += ", usuarioSenha"
            Query += ",("
            Query += "Case "
            Query += "when usuarioTipo = 'A' then (select UA_UsuarioNome from usuario_administrador where UA_chave = usuario.usuarioChave)"
            Query += "When usuarioTipo = 'F' Then (Select colaboradorNome from colaborador where chave = usuario.usuarioChave)"
            Query += "End) as usuNome "
            Query += ",usuarioNomeAcesso"
            Query += " FROM usuario "
            Query += " where "
            Query += "usuarioChave = '" & chave & "'"
            Query += " and "
            Query += "usuarioSenha = '" & pass & "'"
            Query += " and "
            Query += "usuarioTipo = '" & tipo & "';"


            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                Licenca = IIf(DTReader.GetString(0) = "0", False, True)

                If Licenca Then

                    usuClass.Usario_senha = pass
                    usuClass.Usuario_Nome = DTReader.GetString(4)
                    usuClass.Usuario_Nome_Acesso = DTReader.GetString(5)
                    'usuClass.Usuario_Nome = chave
                    If tipo = "A" Then
                        Reg.Administrador = True
                    Else
                        Reg.Administrador = False
                    End If

                End If


            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            Conn.Close()

        End If
    End Function

    Private Sub BtnVerifica_Click(sender As Object, e As EventArgs) Handles BtnVerifica.Click

        '// Verificando Usuario 
        '//Dim usu_responsavel, chv_responsavel As String

        If Trim(MskUsuario.Text).Length < 2 Then

            With oi
                .Style = vbCritical
                .Title = Me.Text
                .Msg = "Usuário impróprio"
                MsgBox(.Msg, .Style, .Title)
            End With

            MskUsuario.Enabled = True
            MskUsuario.Focus()

            Exit Sub

        Else

            usuClass.Usuario_Chave = MskUsuario.Text.Substring(1)
            usuClass.Usuario_Tipo = MskUsuario.Text.Substring(0, 1)

            If Not ApontaElementosSQL("usuario_tipo", "UT_codigo", usuClass.Usuario_Tipo, False) Then

                With oi
                    .Style = vbCritical
                    .Title = Me.Text
                    .Msg = "Tipo impróprio - 1º digito do Usuário "
                    MsgBox(.Msg, .Style, .Title)
                    Exit Sub
                End With

            End If
        End If

        If TxtSenha.Text = "" Then

            With oi
                .Style = vbCritical
                .Title = Me.Text
                .Msg = "Senha imprópia! (Minimo 8 digitos)"
                MsgBox(.Msg, .Style, .Title)
                TxtSenha.Focus()
                BtnVerifica.Enabled = False
                Exit Sub
            End With

        Else

            usuClass.Usario_senha = TxtSenha.Text

        End If

        If Not Licenca(usuClass.Usuario_Chave, usuClass.Usuario_Tipo, usuClass.Usario_senha) Then

            With oi
                .Style = vbYesNo
                .Msg = "Usuário ou Senha Inválido!"
                .Msg += Chr(13)
                .Msg += Chr(13)
                .Msg += "Deseja Redigitar"
                If MsgBox(.Msg, .Style, .Title) <> 6 Then Me.Close()

            End With

            MskUsuario.Enabled = True
            MskUsuario.Focus()
            Exit Sub

        End If
        '---------------------------------------------------


        If Reg.Administrador Then

            MenuTrava(True, Form1.MenuStrip1)

        Else

            MenuTrava(False, Form1.MenuStrip1)

            '//MenuAbertura(usu_responsavel)        
            MenuAbertura(usuClass.Usuario_Chave)                                '' Carrega matriz com permissões do Menu mtMenu
            For Each item As ToolStripMenuItem In Form1.MenuStrip1.Items
                For i = 0 To linha
                    If item.AccessibleName = mtMenu(i, 0) Then
                        If mtMenu(i, 1) = 1 Then
                            item.Enabled = True
                        Else
                            item.Enabled = False
                        End If
                        item.Visible = True
                        Exit For

                    End If
                Next
                For Each subitem As ToolStripMenuItem In item.DropDownItems
                    For i = 0 To linha
                        subitem.Visible = False
                        If subitem.AccessibleName = mtMenu(i, 0) Then

                            If mtMenu(i, 1) = 1 Then
                                subitem.Enabled = True
                            Else
                                subitem.Enabled = False
                            End If
                            subitem.Visible = True
                            Exit For

                        End If
                    Next
                    For Each subitem1 As ToolStripMenuItem In subitem.DropDownItems
                        For i = 0 To linha
                            If subitem1.AccessibleName = mtMenu(i, 0) Then
                                If mtMenu(i, 1) = 1 Then
                                    subitem1.Enabled = True
                                Else
                                    subitem1.Enabled = False
                                End If
                                subitem1.Visible = True
                                Exit For

                            End If
                        Next
                        For Each subitem2 As ToolStripMenuItem In subitem1.DropDownItems
                            For i = 0 To linha
                                If subitem2.AccessibleName = mtMenu(i, 0) Then

                                    If mtMenu(i, 1) = 1 Then
                                        subitem2.Enabled = True
                                    Else
                                        subitem2.Enabled = False
                                    End If
                                    subitem2.Visible = True
                                    Exit For

                                End If
                            Next
                            For Each subitem3 As ToolStripMenuItem In subitem2.DropDownItems
                                For i = 0 To linha
                                    If subitem3.AccessibleName = mtMenu(i, 0) Then

                                        If mtMenu(i, 1) = 1 Then
                                            subitem3.Enabled = True
                                        Else
                                            subitem3.Enabled = False
                                        End If
                                        subitem3.Visible = True
                                        Exit For

                                    End If
                                Next
                            Next
                        Next
                    Next
                Next
            Next

        End If

        StatusDeCapa()      ' Module1

        Me.Close()

        'Form1.Height = 84

    End Sub


    Private Sub TxtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSenha.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            e.KeyChar = ""
            MskUsuario.Focus()

        End If

        If e.KeyChar = Convert.ToChar(13) Then

            e.KeyChar = ""

            If Len(TxtSenha.Text) = 0 Then

                With oi
                    .Msg = "Senha não digitado!"
                    .Msg = Chr(13)
                    .Msg = Chr(13)
                    .Msg = "Por favor, digite uma senha válida!"
                    .Style = vbCritical
                    MsgBox(.Msg, .Style, .Title)
                End With

                TxtSenha.Focus()

                Exit Sub

            End If

            If Len(TxtSenha.Text) < 8 Then

                With oi
                    .Msg = "Senha com menos de 8 digitos numéricos!"
                    .Msg += Chr(13)
                    .Msg += Chr(13)
                    .Msg += "Por favor, digite uma senha válida!"
                    .Style = vbCritical
                    MsgBox(.Msg, .Style, .Title)
                End With

                TxtSenha.Focus()
                Exit Sub

            End If

            BtnVerifica.Enabled = True

            BtnVerifica.Focus()

            MskUsuario.Enabled = False
            TxtSenha.Enabled = False

        End If


    End Sub

    Private Sub BtnVerifica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnVerifica.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then

            With oi
                .Msg = "Deseja sair da autenticação?"
                .Msg += Chr(13)
                .Msg += Chr(13)
                .Msg += "Por favor, digite uma senha válida!"
                .Style = vbYesNo
                .Resposta = MsgBox(.Msg, .Style, .Title)
                If .Resposta = 6 Then
                    Me.Close()
                Else
                    BtnVerifica.Enabled = False

                    MskUsuario.Enabled = True

                    TxtSenha.Enabled = True

                    MskUsuario.Focus()

                    Exit Sub

                End If
            End With

        End If
    End Sub

    Private Sub TxtSenha_DoubleClick(sender As Object, e As EventArgs) Handles TxtSenha.DoubleClick


        '''If Not sistemaInicializado() Then ' Verifica a presenca de autorizacao

        '''    With oi
        '''        .msg = "Sistema Não autorizado!"
        '''        .style = vbCritical
        '''        MsgBox(.msg, .style, .title)
        '''        Exit Sub
        '''    End With

        '''End If

        '''Dim strNumero As String = ""

        '''strNumero = InputBox("Senha de ADM")

        '''If strNumero = "84" Then

        '''    For Each item As ToolStripMenuItem In Form1.MenuStrip1.Items

        '''        If item.Text = "Acesso" Then

        '''            item.Enabled = True
        '''            item.Visible = True
        '''            For Each subitem As ToolStripMenuItem In item.DropDownItems
        '''                If subitem.Text = "Cadastro" Then

        '''                    subitem.Enabled = True
        '''                    subitem.Visible = True
        '''                    Exit For

        '''                End If
        '''            Next
        '''            Exit For

        '''        End If

        '''    Next



        '''End If

    End Sub

    Private Sub MskUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskUsuario.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If Len(MskUsuario.Text) = 0 Then

                With oi
                    .Msg = "Usuário não digitado!"
                    .Msg += Chr(13)
                    .Msg += Chr(13)
                    .Msg += "Por favor, digite um usuário válido ou [ESC] para sair"
                    .Style = vbCritical
                    MsgBox(.Msg, .Style, .Title)
                End With
                MskUsuario.Focus()
                Exit Sub

            End If

            TxtSenha.Enabled = True

            TxtSenha.Focus()

        End If

        If e.KeyChar = Convert.ToChar(27) Then
            Me.Close()
        End If

        If Not (e.KeyChar >= "a" And e.KeyChar >= "Z") And MskUsuario.Text = "" Then
            e.KeyChar = ""
        Else
            e.KeyChar = UCase(e.KeyChar)
        End If
    End Sub



End Class