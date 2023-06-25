Imports MySql.Data.MySqlClient
Public Class FmrDescanso

    Dim arrayDiaSemana(7) As String
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        PesquisaDescanso()

    End Sub

    Private Sub btnMostra_Click(sender As Object, e As EventArgs) Handles btnMostra.Click


        mostraDescanso()

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim sDia As String = ListView1.SelectedItems(0).Text
        Dim sData As String = CmbAno.Text & CmbMes.Text
        Dim j As Integer = 0
        Dim elementos As Integer = 0
        Dim arrayBolha(100) As String
        Dim Linhaincremental, k As String
        Dim indiceSelecionado As Integer

        Dim intDiasMesAnterior As Integer = 0

        'sDia = sDia.Substring(0, 2)

        'MsgBox(ListView1.SelectedItems(0).Text)

        If ListView1.SelectedItems(0).ForeColor = System.Drawing.Color.Gray Then Exit Sub

        For Each item As Object In ListView1.Items

            If item.ForeColor = System.Drawing.Color.Gray Then
                intDiasMesAnterior += 1
            Else
                Exit For
            End If

        Next

        Dim intVerificaSemanaNoAno As Integer = 0

        indiceSelecionado = Val(ListView1.SelectedItems(0).Text) + intDiasMesAnterior
        intVerificaSemanaNoAno = Int((indiceSelecionado / 7) + 0.9)

        Dim intSemanaAno As Integer = 0

        Select Case intVerificaSemanaNoAno

            Case <= 1

                intSemanaAno = LblSemana1.Text

            Case <= 2

                intSemanaAno = LblSemana2.Text

            Case <= 3

                intSemanaAno = LblSemana3.Text

            Case <= 4

                intSemanaAno = LblSemana4.Text

            Case <= 5

                intSemanaAno = LblSemana5.Text

        End Select

        sData += IIf(Int(ListView1.SelectedItems(0).Text) < 10, "0" & ListView1.SelectedItems(0).Text, ListView1.SelectedItems(0).Text)

        If ListView1.SelectedItems(0).BackColor() = System.Drawing.Color.Yellow Then

            '    Desmarcar para gravação

            ListView1.SelectedItems(0).BackColor() = System.Drawing.Color.White
            ListView1.SelectedItems(0).ForeColor() = System.Drawing.Color.Black
            For Each ITEM As Object In ListBox1.Items
                If ITEM.Substring(0, 10) = dataLatina(sData) Then

                    ListBox1.Items.RemoveAt(j)
                    Exit For

                End If
                j += 1
            Next

        ElseIf ListView1.SelectedItems(0).BackColor() = System.Drawing.Color.White Then

            ' Marcar para a Gravação

            ListView1.SelectedItems(0).BackColor() = System.Drawing.Color.Yellow
            Dim qto As Integer = 0
            '''''''''''''''''''''''''''
            If OpenDB() Then

                Dim Query As String = "select count(*) as qto from descanso where data ='" & sData & "'"
                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader

                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()
                    qto = DTReader.GetString(0)
                Catch ex As Exception
                    MsgBox("Problemas Na Gravação!")
                End Try

                Conn.Close()
            End If
            '''''''''''''''''''''''''''


            Linhaincremental = dataLatina(sData) & " - " & arrayDiaSemana(Weekday(dataLatina(sData))) & " - " & espacoEsquerda(intSemanaAno, 3, 1) & qto

            j = 0
            For Each item As String In ListBox1.Items
                arrayBolha(j) = item
                j += 1
            Next
            elementos = j
            arrayBolha(j) = Linhaincremental
            For i = 0 To elementos - 1
                For j = i To elementos
                    If arrayBolha(i) > arrayBolha(j) Then
                        k = arrayBolha(i)
                        arrayBolha(i) = arrayBolha(j)
                        arrayBolha(j) = k
                    End If
                Next
            Next
            ListBox1.Items.Clear()
            For i = 0 To elementos
                ListBox1.Items.Add(arrayBolha(i))
            Next

        ElseIf ListView1.SelectedItems(0).BackColor() = System.Drawing.Color.Green Then

            For Each dt As String In ListBox3.Items
                If Val(dt.Substring(0, 2)) = Val(sDia) Then

                    ListBox2.Items.Add(dt.ToString)

                    Exit For

                End If

            Next
            'Linhaincremental = dataLatina(sData) & " -  " & arrayDiaSemana(Weekday(dataLatina(sData)))
            j = 0
            For Each item As String In ListBox2.Items
                arrayBolha(j) = item
                j += 1
            Next
            elementos = j - 1

            For i = 0 To elementos - 1
                For j = i To elementos
                    If arrayBolha(i) > arrayBolha(j) Then
                        k = arrayBolha(i)
                        arrayBolha(i) = arrayBolha(j)
                        arrayBolha(j) = k
                    End If
                Next
            Next
            ListBox2.Items.Clear()
            For i = 0 To elementos
                ListBox2.Items.Add(arrayBolha(i))
            Next

            ListView1.SelectedItems(0).BackColor() = System.Drawing.Color.Red

        End If

    End Sub

    Private Sub BtnGrava_Click(sender As Object, e As EventArgs) Handles BtnGrava.Click

        If ListBox1.Items.Count() = 0 And ListBox2.Items.Count() = 0 Then
            MsgBox("Não existem campos para atualização!")
            Exit Sub
        End If
        For Each item As String In ListBox1.Items
            If OpenDB() Then
                Dim strChave As String = MskChave.Text
                Dim strDataDescanso As String = dataAAAAMMDD(item.Substring(0, 10))
                Dim strDiaSemananome As String = item.Substring(13, 3)
                Dim strSemanaNoAno As String = item.Substring(18, 3)
                Dim strDiaDaSemanaCodigo As Integer = Weekday(item.Substring(0, 10))
                Dim Query As String = "call descanso_manutencao(" & strChave & ",'" & strDataDescanso & "','" & strDiaSemananome & "'," & strDiaDaSemanaCodigo & "," & strSemanaNoAno & ",0)"
                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader

                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()

                Catch ex As Exception
                    MsgBox("Problemas Na Leitura!")
                End Try

                Conn.Close()
            End If
        Next

        For Each item As String In ListBox2.Items
            If OpenDB() Then
                Dim strChave As String = MskChave.Text
                Dim strData As String = dataAAAAMMDD(item.Substring(0, 10))
                Dim Query As String = "call descanso_manutencao(" & MskChave.Text & ",'" & strData & "','   ',0,0,2)"

                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader

                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()

                Catch ex As Exception
                    MsgBox("Problemas Na Gravação!")
                End Try

                Conn.Close()
            End If
        Next
        MsgBox("Gravação realizada com sucesso!")

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListView1.Items.Clear()
        LblSemana1.Text = ""
        LblSemana2.Text = ""
        LblSemana3.Text = ""
        LblSemana4.Text = ""
        LblSemana5.Text = ""

        mostraDescanso()

    End Sub

    Private Sub BtnCancela_Click(sender As Object, e As EventArgs) Handles BtnCancela.Click
        If ListView1.Items.Count() > 0 Then
            Dim msg As String
            Dim style As String
            Dim title As String
            Dim ctxt As String
            Dim help As String
            Dim resposta As String
            '---------------------
            Dim Query As String
            Dim DTReader As MySqlDataReader
            msg = "Confirma Cancelamento? - Todas as operações serão abandonadas"
            style = vbYesNo + vbQuestion + vbDefaultButton1
            title = "C O N T R O L E   D E   D E S C A N S O"
            help = "folha.hlp"
            ctxt = 1000

            resposta = MsgBox(msg, style, title)

            If resposta <> 6 Then
                Exit Sub
            End If

        End If
        descansoLimpar()
    End Sub

    Function descansoLimpar()
        ListView1.Items.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        LblTurno.Text = ""
        LblJornada.Text = ""
        LblInicio.Text = ""
        LblTermino.Text = ""
        LblW1.Text = ""
        LblW2.Text = ""
        LblW3.Text = ""
        LblW4.Text = ""
        LblW5.Text = ""
        LblW6.Text = ""
        LblW7.Text = ""

        CmbMes.Text = ""
        CmbAno.Text = ""

        GrpSelecao.Enabled = False
        GrpPesquisa.Enabled = True

        MskChave.Focus()

    End Function

    Private Function PesquisaDescanso()

        If OpenDB() Then
            Dim Query = "Select  count(*) as qto
                        ,   t1.colaboradorNome
                        ,	t3.idturno
                        ,   t3.turnoDuracao as jornada
                        ,	t3.turnoinicio  as inicio
                        ,	t3.turnoFim		as termino  
                                From 
                                    colaborador         t1
                                ,   turno_colaborador   t2
                                ,   turno               t3
                        Where
                                            t1.chave = t2.turno_colaboradorColaborador
                                        And t2.turno_colaboradorTurno = t3.idturno
                                        And isnull(t2.turno_colaboradorDataSaida)
                                        And chave = " & MskChave.Text

            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                If DTReader.GetString(0) = 0 Then
                    MsgBox("Colaborador Não Encontrado!")
                    Conn.Close()
                    Exit Function
                End If
                LblColaborador.Text = DTReader.GetString(1)
                LblTurno.Text = DTReader.GetString(2)
                LblJornada.Text = DTReader.GetString(3)
                LblInicio.Text = DTReader.GetString(4)
                LblTermino.Text = DTReader.GetString(5)

                GrpSelecao.Enabled = True
                GrpPesquisa.Enabled = False
            Catch ex As Exception
                MsgBox("Problemas Na Leitura!")
            End Try

            Conn.Close()
        End If
        Dim cmbMeses As New ComboBox
        cmbMeses.Show()
    End Function

    Private Function mostraDescanso()
        Dim perm(7) As Integer
        Dim UltimoDiaMes As Integer = Int(
                                            Convert.ToString(
                                              Func_Ultimo_Dia_Mes("01" & "/" & CmbMes.Text & "/" & CmbAno.Text)).Substring(0, 2)
                                          )
        Dim UltimoDiaSemanaDoMes As Integer = Weekday(UltimoDiaMes.ToString & "/" & CmbMes.Text & "/" & CmbAno.Text)

        Dim UltimoDiaMesAnterior As Integer = Int(
                                 Convert.ToString(Func_Ultimo_Dia_Mes(DateAdd("m", -1, "01/" & CmbMes.Text & "/" & CmbAno.Text))).Substring(0, 2)
                                                  )

        Dim sDiaSemana As String = Weekday("01" & "/" & CmbMes.Text & "/" & CmbAno.Text)
        Dim diaSemana As Integer = Convert.ToInt16(sDiaSemana)
        Dim diaMes As Integer = 0
        Dim listCalendario As New ListView

        Dim mostraDiasMesAnterior As Integer = UltimoDiaMesAnterior - (diaSemana - 2)
        Dim semanaNumero As Integer = DatePart("ww", "01/" & CmbMes.Text & "/" & CmbAno.Text)
        Dim anoMes As String = CmbAno.Text & CmbMes.Text
        Dim inter As List(Of descanso) = descansoRP.GetDescanso(anoMes)

        ListView1.Items.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        LblSemana1.Text = semanaNumero
        LblSemana2.Text = semanaNumero + 1
        LblSemana3.Text = semanaNumero + 2
        LblSemana4.Text = semanaNumero + 3
        LblSemana5.Text = semanaNumero + 4

        'inter(0).diasMesAnterior = (UltimoDiaMesAnterior - mostraDiasMesAnterior) + 1

        For i = mostraDiasMesAnterior To UltimoDiaMesAnterior

            ListView1.Items().Add(i)
            ListView1.Items(ListView1.Items.Count - 1).ForeColor() = System.Drawing.Color.Gray

        Next

        For i = 1 To Int(UltimoDiaMes)

            ListView1.Items().Add(i)

        Next

        For i = 1 To 7 - UltimoDiaSemanaDoMes

            ListView1.Items().Add(i)
            ListView1.Items(ListView1.Items.Count - 1).ForeColor() = System.Drawing.Color.Gray
        Next



        '''Dim j As Integer

        '''j = 1
        arrayDiaSemana(1) = "Dom"
        arrayDiaSemana(2) = "Seg"
        arrayDiaSemana(3) = "Ter"
        arrayDiaSemana(4) = "Qua"
        arrayDiaSemana(5) = "Qui"
        arrayDiaSemana(6) = "Sex"
        arrayDiaSemana(7) = "Sab"

        '''For i = diaSemana To 7

        '''    perm(j) = i
        '''    j += 1

        '''Next

        '''For i = 1 To (diaSemana - 1)

        '''    perm(j) = i
        '''    j += 1

        '''Next

        '''LblW1.Text = arrayDiaSemana(perm(1))
        '''LblW2.Text = arrayDiaSemana(perm(2))
        '''LblW3.Text = arrayDiaSemana(perm(3))
        '''LblW4.Text = arrayDiaSemana(perm(4))
        '''LblW5.Text = arrayDiaSemana(perm(5))
        '''LblW6.Text = arrayDiaSemana(perm(6))
        '''LblW7.Text = arrayDiaSemana(perm(7))

        LblW1.Text = "Dom"
        LblW2.Text = "Seg"
        LblW3.Text = "Ter"
        LblW4.Text = "Qua"
        LblW5.Text = "Qui"
        LblW6.Text = "Sex"
        LblW7.Text = "Sab"

        'Dim inter As List(Of descanso) = descansoRP.GetDescanso(anoMes)

        For i = 0 To inter.Count() - 1
            diaMes = (Int((inter(i).data.Substring(6, 2))) - 1) + ((diaSemana - 1))
            ListBox3.Items.Add(dataLatina(inter(i).data) & " - " & inter(i).DSnome & " - " & inter(i).mesmaData)
            ListView1.Items(diaMes).BackColor() = System.Drawing.Color.Green
            ListView1.Items(diaMes).ForeColor() = System.Drawing.Color.White
            If Int(inter(i).mesmaData) > 0 Then
                If OpenDB() Then

                    Dim query As String = "select t1.chave,t1.colaboradorNomeCracha from colaborador t1, descanso t2 where t1.chave = t2.chave and t2.data = '" & inter(i).data & "' and t1.chave not in (" & MskChave.Text & ")"
                    Dim CMD As New MySqlCommand(query, Conn)
                    Dim DTReader As MySqlDataReader
                    Try
                        DTReader = CMD.ExecuteReader
                        While DTReader.Read
                            'diaMes = Int((DTReader.GetString(2).Substring(6, 2))) - 1
                            ListBox3.Items.Add("   " & DTReader.GetString(0) & " - " & DTReader.GetString(1))
                        End While

                    Catch ex As Exception
                        MsgBox("Problemas Na Leitura!")
                    End Try

                    Conn.Close()
                End If
            End If
        Next
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class