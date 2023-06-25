Imports MySql.Data.MySqlClient
Public Class formUsuarioCad
    Dim oi As New MsgShow
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    ''''Private Sub mskUsuarioSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskUsuario.KeyPress
    ''''    Dim query As String
    ''''    Dim chave As String
    ''''    Dim DTReader As MySqlDataReader

    ''''    oi.title = Me.Text

    ''''    chave = Replace(mskUsuario.Text, "_", "")

    ''''    If e.KeyChar = Convert.ToChar(13) Then

    ''''        Dim ok As Boolean = False

    ''''        For Each tipo As String In CmbTipo.Items

    ''''            If tipo = CmbTipo.Text Then
    ''''                ok = True
    ''''                Exit For
    ''''            End If
    ''''        Next

    ''''        If Not ok Then

    ''''            MsgBox("Tipo Inválido", 0, Me.Text)
    ''''            CmbTipo.Focus()
    ''''            Exit Sub

    ''''        End If

    ''''        If CmbTipo.Text.Substring(0, 1) = "F" Then
    ''''            If chave = "" Then
    ''''                With oi
    ''''                    .msg = "Chave inválida!" & Chr(13) & "Por favor escolha uma das opções válida"
    ''''                    .style = vbCritical
    ''''                    MsgBox(.msg, .style, .title)
    ''''                End With
    ''''                Exit Sub
    ''''            Else


    ''''                If OpenDB() Then

    ''''                    query = "select"
    ''''                    query = query & " colaboradorNome"
    ''''                    query = query & ",	count(*) as qto"
    ''''                    query = query & ",	(select count(*) as qto from usuario where usuarioChave = " & chave & ") as existe"
    ''''                    query = query & ",colaboradorCPF"
    ''''                    query = query & " From colaborador Where chave =  " & chave

    ''''                    Dim CMD As New MySqlCommand(query, Conn)
    ''''                    Try
    ''''                        DTReader = CMD.ExecuteReader
    ''''                        DTReader.Read()
    ''''                        Dim STRcolaboradorCPF As String = ""
    ''''                        Dim arquivo As Boolean = True

    ''''                        If DTReader(2) > 0 Then
    ''''                            STRcolaboradorCPF = DTReader(3)

    ''''                        End If

    ''''                        If DTReader.GetString(1) = 0 Then
    ''''                            lblNome.Text = "Usuário não cadastrado!"
    ''''                            Conn.Close()
    ''''                            Button3.Enabled = False
    ''''                            Exit Sub
    ''''                        End If

    ''''                        Dim Caminho As String = "C:\"
    ''''                        Caminho += Trim(LimpaNumero(Form1.empCNPJ.Text.Substring(7)))
    ''''                        Caminho += "\folha\colaborador\"
    ''''                        Caminho += STRcolaboradorCPF
    ''''                        Caminho += "\Foto\Registro\Registro.jpeg"

    ''''                        If Not System.IO.File.Exists(Caminho) Then

    ''''                            arquivo = False

    ''''                        End If

    ''''                        If arquivo Then
    ''''                            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    ''''                            PictureBox1.Image = Image.FromFile(Caminho)
    ''''                            PictureBox1.Visible = True
    ''''                        Else
    ''''                            PictureBox1.Visible = False
    ''''                        End If

    ''''                        If DTReader.GetString(2) = 1 Then
    ''''                            lblNome.Text = "Usuário tem senha cadastrada!, utilize Manutenção de Senhas"
    ''''                            Conn.Close()
    ''''                            Button3.Enabled = False
    ''''                            Exit Sub
    ''''                        End If
    ''''                        lblNome.Text = DTReader.GetString(0)
    ''''                        Button3.Enabled = True
    ''''                    Catch ex As Exception
    ''''                        MsgBox("Problemas na pesquisa!")
    ''''                        lblNome.Text = ""
    ''''                        Conn.Close()
    ''''                        Exit Sub
    ''''                    End Try

    ''''                End If
    ''''                Conn.Close()
    ''''            End If
    ''''        End If
    ''''    End If

    ''''End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Query As String
        Dim Caminho As String = ""
        Dim ok As Boolean = False
        Dim arquivo As Boolean = True

        For Each tipo As String In CmbTipo.Items

            If tipo = CmbTipo.Text Then
                ok = True
                Exit For
            End If
        Next

        If Not ok Then
            MsgBox("Tipo Inválido", 0, Me.Text)
            CmbTipo.Focus()
            Exit Sub
        End If

        If mskUsuario.Text = "" Then
            MsgBox("Usuário inválido ", 0, Me.Text)
            mskUsuario.Focus()
            Exit Sub
        Else
            mskUsuario.Text = Val(mskUsuario.Text)
        End If

        Dim chave As String = mskUsuario.Text

        Query = "select"
        Query += " colaboradorNome"
        Query += ",colaboradorCPF"
        Query += ",count(*) as qto"
        Query += ",(select count(*) as qto from usuario where usuarioChave = " & chave & ") as existe"
        Query += " From colaborador Where chave =  " & chave

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(Query, Conn)
        Dim STRcolaboradorSenha As String = "0"      ' Se o usuario tem senha > 0
        Dim STRcolaboradorNome As String = ""

        If OpenDB() Then

            DTReader = CMD.ExecuteReader
            DTReader.Read()
            Dim STRcolaboradorExiste As String = DTReader(2)    ' Se o usuario existe > 0
            STRcolaboradorSenha = DTReader(3)                   ' Se o usuario tem senha > 0

            If STRcolaboradorExiste = "0" Then
                Conn.Close()
                PictureBox1.Visible = False
                LblUsuarioNome.Text = ""
                With oi
                    .title = Me.Text
                    .style = vbCritical
                    .msg = "Usuário não registrado "
                    .msg += Chr(13) & Chr(13)
                    .msg += "Certifique-se de que o número de usário esteja correto"
                    MsgBox(.msg, .style, .title)
                End With

                mskUsuario.Focus()
                Exit Sub
            End If

            STRcolaboradorNome = DTReader(0)                    ' Nome do usuario
            Dim STRcolaboradorCPF As String = DTReader(1)       ' CPF do usuario


            Conn.Close()


            LblUsuarioNome.Text = STRcolaboradorNome

            Caminho = "C:\"
            Caminho += Trim(LimpaNumero(Form1.empCNPJ.Text.Substring(7)))
            Caminho += "\folha\colaborador\"
            Caminho += STRcolaboradorCPF
            Caminho += "\Foto\Registro\Registro.jpeg"


        End If

        If Not System.IO.File.Exists(Caminho) Then

            arquivo = False
            PictureBox1.Visible = False
        End If

        If arquivo Then
            PictureBox1.Visible = True
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = Image.FromFile(Caminho)
        End If

        If STRcolaboradorSenha > "0" Then ' Verificação se o usuario ja possui senha
            With oi
                .title = Me.Text
                .style = vbCritical
                .msg = "Usuário : " & STRcolaboradorNome
                .msg += Chr(13) & Chr(13)
                .msg += "já possui Senha "
                .msg += Chr(13) & Chr(13)
                .msg += "Para alteração de senhas já cadastrada "
                .msg += Chr(13) & Chr(13)
                .msg += "Utilize a opção de Manutenção de senha"
                MsgBox(.msg, .style, .title)
            End With
            PictureBox1.Visible = False
            LblUsuarioNome.Text = ""
            mskUsuario.Focus()
            Exit Sub
        End If


        GroupBox3.Enabled = True
        GroupBox2.Enabled = False


    End Sub

    Private Sub formUsuarioCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboCarregar(Me.CmbTipo, "usuario_tipo", "concat(UT_codigo,' - ',UT_descricao)", "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(txtSenha1.Text) < 8 Then
            MsgBox("Senha com menos do que 8 digitos numéricos!")
            txtSenha1.Focus()
            Exit Sub
        End If
        If txtSenha1.Text <> txtSenha2.Text Then
            MsgBox("Senhas Diferentes!")
            txtSenha1.Focus()
            Exit Sub
        End If

        Dim Query As String
        Query = "Insert into usuario ("
        Query += "usuarioChave "
        Query += ",usuarioSenha "
        Query += ",usuarioRegistroData "
        Query += ",usuarioTipo "
        Query += ",usuarioStatus "
        Query += ") "
        Query += " value( "
        Query += "'" & mskUsuario.Text & "'"
        Query += ",'" & txtSenha1.Text & "'"
        Query += ", now() "
        Query += ", '" & CmbTipo.Text.Substring(0, 1) & "'"
        Query += ",1"
        Query += ")"

        If (gravaSQL(Query)) Then
            With oi
                .title = Me.Text
                .style = vbExclamation
                .msg = "Gravação Realizada com sucesso "

                MsgBox(.msg, .style, .title)
            End With


        End If
        LimpaSenhas()

        GroupBox3.Enabled = False
        GroupBox2.Enabled = True

        CmbTipo.Focus()

    End Sub

    Private Function LimpaSenhas()
        CmbTipo.Text = ""
        mskUsuario.Text = ""
        txtSenha1.Text = ""
        txtSenha2.Text = ""
        LblUsuarioNome.Text = ""
        PictureBox1.Visible = False
    End Function

End Class