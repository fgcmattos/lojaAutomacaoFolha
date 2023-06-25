Imports MySql.Data.MySqlClient
Public Class frmFolhaDiarioRelatorio
    Dim qto As Integer = 0
    Private Sub frmFolhaDiarioRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        folhaDiarioData.Text = Now
        If OpenDB() Then

            Dim Query As String = "select concat(lpad(chave,4,'0'),' - ' ,lpad(colaboradorNome,50,' '),lpad(colaboradorCPF,15,' '),lpad(colaboradorRG,15,' ')) from colaborador order by colaboradorNome"
            'Dim query As String = "call folPontoCol()"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read
                    qto += 1
                    If qto = 1 Then
                        folhaDiarioColaborador.Items.Add("0000 - S e l e c i o n e   u m   C o l a b o r a d o r !")
                    End If
                    folhaDiarioColaborador.Items.Add(DTReader.GetString(0))

                End While

                folhaDiarioColaborador.SelectedIndex() = 0
            Catch ex As Exception
                MsgBox("Problemas Na leitura do SQL!")
            End Try

            Conn.Close()

        End If
    End Sub

    Private Sub btnTermina_Click(sender As Object, e As EventArgs) Handles btnTermina.Click
        Me.Close()
    End Sub


    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        If folhaDiarioColaborador.Text = "" Then

            MsgBox("Selecione um colaborador!")
            Exit Sub

        End If

        Dim sVariavel As String
        Dim i As Integer = 1


        If OpenDB() Then
            Dim Query As String
            Query = "call folhaPontoIndividual(" & Mid(folhaDiarioColaborador.Text, 1, 4) & ",'" & dataAAAAMMDD(folhaDiarioData.Text) & "')"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            Dim firstOpenData, movimentoGet, strSequencia As String
            'Dim intSequencia, bHoras As Integer
            Dim bHoras As Integer
            Dim iAchou As Boolean = False
            Dim horasTrabalhadas As Integer
            Dim MinutosTrabalhados As Integer
            Dim tempoTrabalhado As String
            Dim minutosTotal As Integer
            'Dim turnoCheio As String
            Dim turnoSaldo As String = ""
            Dim leitura As Boolean = True
            Dim achou As Boolean = False

            ListBox1.Items.Clear()
            Try
                DTReader = CMD.ExecuteReader
                firstOpenData = ""
                movimentoGet = ""

                While DTReader.Read
                    achou = True
                    If leitura Then
                        turnoSaldo = "+ " & DTReader.GetString(8)
                        leitura = False
                    End If
                    iAchou = True
                    movimentoGet = DTReader.GetString(1).PadLeft(2, "0")
                    movimentoGet = movimentoGet & ":" & DTReader.GetString(2).PadLeft(2, "0")

                    horasTrabalhadas = Int(Int(DTReader.GetString(5)) / 60)
                    MinutosTrabalhados = Int(DTReader.GetString(5)) - (horasTrabalhadas * 60)
                    tempoTrabalhado = horasTrabalhadas.ToString.PadLeft(2, "0") & ":" & MinutosTrabalhados.ToString.PadLeft(2, "0")

                    bHoras = DTReader.GetString(5)

                    If i > 0 Then
                        sVariavel = "E N T R A D A <=====     "
                        If firstOpenData = "" Then
                            firstOpenData = movimentoGet
                        End If
                    Else
                        sVariavel = "S A I D A               =====>"
                    End If
                    strSequencia = DTReader.GetString(7).PadLeft(10, "0")
                    turnoSaldo = hhmmDif(tempoTrabalhado, turnoSaldo)
                    i = -i
                    ListBox1.Items.Add(sVariavel & " -      " & strSequencia & "           -           " & movimentoGet & "                    " & tempoTrabalhado & "                       " & turnoSaldo) ' & "             " & bHoras)
                    ListBox1.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------")
                    minutosTotal = minutosTotal + Val(bHoras)
                End While
                If Not achou Then
                    MsgBox("Sem movimento na data!")
                    Conn.Close()
                    Exit Sub
                End If
                If i < 0 Then
                    ListBox1.Items.Add("---------C O L A B O R A D O R   E M   P R O D U Ç Ã O-----------")
                    ListBox1.Items.Add("")
                    ' turnoFim(horario de entrada , duracao do turno)
                    ListBox1.Items.Add("---------F I M  D O  T U R N O----->" & " " & turnoFim(firstOpenData, "06:17"))
                End If
                If Not iAchou Then
                    ListBox1.Items.Add("---------S E M  L A Ç A M E N T O-----------")
                End If
            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            Conn.Close()
            Dim obs, saldoBH As String
            horasTrabalhadas = Int(minutosTotal / 60)
            MinutosTrabalhados = Int(minutosTotal - (horasTrabalhadas * 60))
            tempoTrabalhado = horasTrabalhadas.ToString.PadLeft(2, "0") & ":" & MinutosTrabalhados.ToString.PadLeft(2, "0")
            If turnoSaldo.Substring(0, 1) = "+" Then
                obs = " N E G A T I V O "
            Else
                obs = " P O S I T I V O "
            End If
            saldoBH = turnoSaldo.Substring(1)
            ListBox1.Items.Add("=====================================================================================================================================================")
            ListBox1.Items.Add("           T   O   T   A   I   S                                                                                   " & tempoTrabalhado)
            ListBox1.Items.Add("=====================================================================================================================================================")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("      Descanso HH:mm ")
            ListBox1.Items.Add("      Bolsa de horas a transferir HH:mm " & saldoBH & "   " & obs)

        End If

    End Sub

    Private Sub btnImprime_Click(sender As Object, e As EventArgs) Handles btnImprime.Click

        FormRel.txtRel.Text = "2"
        FormRel.Show()

    End Sub

    Private Sub btnImprimePeriodo_Click(sender As Object, e As EventArgs) Handles btnImprimePeriodo.Click
        ' Verifica premissas pas pesquisa
        'MsgBox(frmFolhaDiarioRelatorio.folhaDiarioColaborador.SelectedItem.ToString)

        If folhaDiarioColaborador.SelectedItem.ToString.Substring(0, 4) = "0000" Then
            MsgBox("Determine um Colaborador para ser relatado!")
            folhaDiarioColaborador.Focus()
            Exit Sub
        End If
        '=============================================/========================

        Dim chave As Integer = Int(folhaDiarioColaborador.SelectedItem.ToString.Substring(0, 4))

        FrelfolPonto.Show()

    End Sub

    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click

        Dim chave As Integer = folhaDiarioColaborador.SelectedItem.ToString.Substring(0, 4)

        If chave = "0000" Then
            MsgBox("Um colaborador deve ser seliconado!")
            Exit Sub

        End If

        If OpenDB() Then

            Dim query As String = "folPontoPresenca(" & chave & ")"
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader

                DTReader.Read()

                LblTurno.Text = (DTReader.GetString(0))

                LblNome.Text = (DTReader.GetString(1))

                LblCPF.Text = formaString(1, (DTReader.GetString(2)))

                LblRG.Text = (DTReader.GetString(3))

                lblTurnoDuracao.Text = (DTReader.GetString(4))

                LblDescanso.Text = (DTReader.GetString(5))

                lblturnoInico.Text = (DTReader.GetString(6))

                lblTurnoFim.Text = (DTReader.GetString(7))

                lblChave.Text = (DTReader.GetString(8))

                lblCargo.Text = (DTReader.GetString(9))

                'folhaDiarioColaborador.SelectedIndex() = 0

            Catch ex As Exception

                MsgBox("Problemas Na leitura do SQL!")

            End Try

            Conn.Close()

        End If

    End Sub

End Class