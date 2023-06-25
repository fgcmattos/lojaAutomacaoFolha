Imports MySql.Data.MySqlClient
Public Class frmCadastroAcesso
    Dim arrayPermutacao(1, 10000)
    Dim arrayPM(10000) As Integer
    Dim jArray As Integer = 0
    Dim oi As New MsgShow
    Private Sub frmCadastroAcesso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.title = Me.Text
    End Sub

    Private Sub btoPesquisaUsuario_Click(sender As Object, e As EventArgs) Handles btoPesquisaUsuario.Click


        If Not MontaMenu() Then mskUsuarioID.Focus()

    End Sub

    Private Function MontaMenu() As Boolean

        MontaMenu = True

        LimpaBox()

        If Trim(mskUsuarioID.Text) = "" Then
            With oi
                .title = Me.Text
                .style = vbCritical
                .msg = "Usuário inválido!" & Chr(13) & "Por favor digite um código válido de Usuário"
                MsgBox(.msg, .style, .title)
            End With
            MontaMenu = False

            Exit Function
        End If

        ' carrega as informacoes de menu 
        ' do usario

        If Not UsuarioPesquisa() Then MontaMenu = False : Exit Function


        'preencher Menus 

        menupreenche()

    End Function

    Private Function UsuarioPesquisa() As Boolean

        UsuarioPesquisa = True

        lblNome.Text = ""

        jArray = 0

        If OpenDB() Then



            '''Dim Query As String = "call sp_menu_usuario(" & mskUsuarioID.Text & ")"

            Dim Query As String = ""
            Query = "select count(*) from usuario where usuariochave =" & mskUsuarioID.Text

            If gravaSQLretorno(Query) = 0 Then

                With oi

                    .msg = "Usuário não cadastrado!"
                    .style = vbCritical
                    MsgBox(.msg, .style, .title)
                    UsuarioPesquisa = False
                    Exit Function
                End With

            End If



            Query = "Select "
            Query += "2"
            Query += ",  colaboradorNome"
            Query += ",	menuIdentificador"
            Query += ",	menudescricao"
            Query += ",	menunivel"
            Query += ",	menu_on from menu_usuario , colaborador"
            Query += " where "
            Query += " menuUsuario = " & mskUsuarioID.Text
            Query += " And chave = menuUsuario"
            Query += " order by menuIdentificador;"


            Dim fato, afasta, ii, nivel As Integer

            afasta = 0
            nivel = 0

            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try

                If OpenDB() Then

                    DTReader = CMD.ExecuteReader

                    ListBox1.Items.Clear()

                    While DTReader.Read

                        fato = DTReader.GetString(0)

                        If fato = 0 Then

                            MsgBox(DTReader.GetString(0)) ' usuario nao cadastrado
                            Conn.Close()
                            MsgBox("Problemas na execução da Query - UsuarioPesquisa()")
                            UsuarioPesquisa = False
                            Exit Function
                        End If

                        If jArray = 0 Then

                            lblNome.Text = DTReader.GetString(1)

                        End If

                        If fato = 2 Then

                            nivel = Int(DTReader.GetString(4))

                            Select Case nivel
                                Case 1
                                    afasta = 15
                                Case 2
                                    afasta = 20
                                Case 3
                                    afasta = 25
                                Case 4
                                    afasta = 30
                                Case 5
                                    afasta = 35
                                Case 6
                                    afasta = 40
                            End Select

                            ListBox1.Items.Add(espacoEsquerda(DTReader.GetString(2), afasta, 1) & DTReader.GetString(3))

                            ii = 0
                            For Each item As String In ListBox1.Items()
                                ii += 1
                                arrayPM(ii) = ii
                                arrayPermutacao(0, arrayPM(ii)) = item.Substring(0, 15)
                                arrayPermutacao(1, arrayPM(ii)) = item
                            Next
                            jArray = ListBox1.Items.Count()

                        End If
                    End While
                    GroupBox2.Enabled = True
                End If
            Catch ex As Exception
                UsuarioPesquisa = False
                MsgBox(ex.Message)
            End Try

            Conn.Close()
        End If
    End Function

    Function menupreenche() As Boolean
        Dim elementos As Integer
        Dim eleCount As Integer = 0
        Dim nivel1, nivel2, nivel3, nivel4, nivel5, nivel6 As Integer
        nivel1 = 0
        nivel2 = 0
        nivel3 = 0
        nivel4 = 0
        nivel5 = 0
        nivel6 = 0

        elementos = Form1.MenuStrip1.Items.Count()

        For Each item As ToolStripMenuItem In Form1.MenuStrip1.Items
            eleCount = eleCount + 1
            nivel1 = nivel1 + 1
            ListBox2.Items.Add(espacoEsquerda(nivel1.ToString.PadLeft(2, "0"), 15, 1) & item.Text)
            nivel2 = 0
            For Each subitem As ToolStripMenuItem In item.DropDownItems
                eleCount = eleCount + 1
                nivel2 = nivel2 + 1
                ListBox2.Items.Add(espacoEsquerda(nivel1.ToString.PadLeft(2, "0") & "." & nivel2.ToString.PadLeft(2, "0"), 20, 1) & subitem.Text)
                nivel3 = 0
                For Each subitem1 As ToolStripMenuItem In subitem.DropDownItems
                    eleCount = eleCount + 1
                    nivel3 = nivel3 + 1
                    ListBox2.Items.Add(espacoEsquerda(nivel1.ToString.PadLeft(2, "0") & "." & nivel2.ToString.PadLeft(2, "0") & "." & nivel3, 25, 1) & subitem1.Text)
                    nivel4 = 0
                    For Each subitem2 As ToolStripMenuItem In subitem1.DropDownItems
                        eleCount = eleCount + 1
                        nivel4 = nivel4 + 1
                        ListBox2.Items.Add(espacoEsquerda(nivel1.ToString.PadLeft(2, "0") & "." & nivel2.ToString.PadLeft(2, "0") & "." & nivel3 & "." & nivel4, 30, 1) & subitem2.Text)
                        nivel5 = 0
                        For Each subitem3 As ToolStripMenuItem In subitem2.DropDownItems
                            eleCount = eleCount + 1
                            nivel5 = nivel5 + 1
                            ListBox2.Items.Add(espacoEsquerda(nivel1.ToString.PadLeft(2, "0") & "." & nivel2.ToString.PadLeft(2, "0") & "." & nivel3 & "." & nivel4 & "." & nivel5, 35, 1) & subitem3.Text)
                            nivel6 = 0
                            For Each subitem4 As ToolStripMenuItem In subitem3.DropDownItems
                                eleCount = eleCount + 1
                                nivel6 = nivel6 + 1
                                ListBox2.Items.Add(espacoEsquerda(nivel1.ToString.PadLeft(2, "0") & "." & nivel2.ToString.PadLeft(2, "0") & "." & nivel3 & "." & nivel4 & "." & nivel5 & "." & nivel6, 40, 1) & subitem4.Text)

                            Next
                        Next
                    Next
                Next
            Next
        Next

        menupreenche = True
    End Function

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        Dim strAuxiliar As String
        Dim auxPer As Integer
        jArray += 1
        arrayPM(jArray) = jArray
        strAuxiliar = ListBox2.SelectedItem
        arrayPermutacao(1, jArray) = strAuxiliar
        arrayPermutacao(0, jArray) = strAuxiliar.Substring(0, 15)

        For j = 1 To jArray - 1
            For i = j + 1 To jArray
                If arrayPermutacao(0, arrayPM(i)) = arrayPermutacao(0, arrayPM(j)) Then
                    MsgBox("Item já Movido!")
                    jArray -= 1
                    Exit Sub
                End If
                If arrayPermutacao(0, arrayPM(i)) < arrayPermutacao(0, arrayPM(j)) Then
                    auxPer = arrayPM(i)
                    arrayPM(i) = arrayPM(j)
                    arrayPM(j) = auxPer
                End If

            Next
        Next
        ListBox1.Items.Clear()
        For i = 1 To jArray
            ListBox1.Items.Add(arrayPermutacao(1, arrayPM(i)))
        Next


    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim indice As Integer = (ListBox1.SelectedIndex + 1)
        Dim i As Integer


        jArray -= 1
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        i = 0
        For Each item As String In ListBox1.Items()
            i += 1
            arrayPM(i) = i
            arrayPermutacao(0, arrayPM(i)) = item.Substring(0, 10)
            arrayPermutacao(1, arrayPM(i)) = item
        Next
    End Sub



    Private Sub btoCancela_Click(sender As Object, e As EventArgs) Handles btoCancela.Click
        Dim msg As String
        Dim style As String
        Dim title As String
        Dim ctxt As String
        Dim help As String
        Dim resposta As String
        '---------------------

        msg = "Confirma Cancelamento?"
        style = vbYesNo + vbQuestion + vbDefaultButton1
        title = "Menu Acesso"
        help = "folha.hlp"
        ctxt = 1000

        resposta = MsgBox(msg, style, title)

        If resposta = "6" Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            lblNome.Text = ""
            mskUsuarioID.Text = ""
            mskUsuarioID.Focus()
            Exit Sub

        End If

    End Sub

    Private Sub btoGrava_Click(sender As Object, e As EventArgs) Handles btoGrava.Click
        Dim query, query1, descricao, ativo As String
        Dim nivel, vez As Integer
        Dim identificador As String

        query = ""

        vez = 0

        ativo = "1"

        'query1 = "call sp_menuManutencao(" & mskUsuarioID.Text
        query1 = "Insert into menu_usuario ("
        query1 += "menuUsuario"
        query1 += ",menuIdentificador"
        query1 += ",menuNivel"
        query1 += ",menuDescricao"
        query1 += ",menu_On) values (" & mskUsuarioID.Text & ","




        For Each item As String In ListBox1.Items()

            descricao = Trim(item.Substring(15))

            nivel = Len(Replace(Trim(item.Substring(0, 15)), ".", ""))

            identificador = Trim(item.Substring(0, 15))

            'query = query1 & ",'" & identificador & "'," & nivel & ",'" & descricao & "','" & ativo & "'," & vez 

            query += query1 & "'" & identificador & "'," & nivel & ",'" & descricao & "','" & ativo & "');"

            vez += 1

            'MsgBox(nivel & "   " & item)
        Next

        query = "delete from menu_usuario where menuUsuario = " & mskUsuarioID.Text & ";" & query

        If OpenDB() Then

            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                MsgBox("Alterações Gravadas com sucesso!")



            Catch ex As Exception
                MsgBox("Problemas na Gravação!")
            End Try


        End If
        Conn.Close()

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        mskUsuarioID.Text = ""
        lblNome.Text = ""
    End Sub

    Private Sub btoGrava_MouseEnter(sender As Object, e As EventArgs) Handles btoGrava.MouseEnter

        Dim mouse As Icon

        mouse = My.Resources.pesqDB

        Me.Cursor = New Cursor(mouse.Handle)

    End Sub

    Private Sub btoGrava_MouseLeave(sender As Object, e As EventArgs) Handles btoGrava.MouseLeave

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub mskUsuarioID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskUsuarioID.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then


            Me.Close()

            e.KeyChar = ""

            Exit Sub

        End If

        If e.KeyChar = Convert.ToChar(13) Then

            If Not MontaMenu() Then mskUsuarioID.Focus()

            e.KeyChar = ""

        End If

    End Sub

    Private Function LimpaBox()

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Function

End Class