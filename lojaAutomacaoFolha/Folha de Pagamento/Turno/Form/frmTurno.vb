Imports MySql.Data.MySqlClient
Public Class frmTurno
    Public arryManutencao(100) As String
    Private Sub frmTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListViewTurno.View = View.Details
        ListViewTurno.GridLines = True

        carregaGrid()

    End Sub


    Sub TurnoInicia()

        TurnoNome.Text = ""
        TurnoTempoSemanal.Text = ""
        turnoDuracao.Text = ""
        turnoInicio.Text = ""
        TurnoTempoDescanso.Text = ""
        turnoInicioTolerancia.Text = ""
        turnoFim.Text = ""
        mskToleranciaEntrada.Text = ""
        grpControle.Text = "C A D A S T R O"
        TurnoNome.Focus()

    End Sub

    Sub LimpaCampos()

        TurnoNome.Text = ""
        TurnoTempoSemanal.Text = ""
        DiasTrabalhadosNaDemana.Text = ""
        turnoDuracao.Text = ""
        turnoInicio.Text = ""
        TurnoTempoDescanso.Text = ""
        turnoInicioTolerancia.Text = ""
        turnoFim.Text = ""
        mskToleranciaEntrada.Text = ""
        grpControle.Text = "C A D A S T R A M E N T O"
        lblTipo.Text = "0"
        lblOrdem.Text = "0"
        lblColaboradoresNumero.Text = ""
        grpTurnos.Enabled = True
    End Sub

    Sub CarregaGrid()

        ListViewTurno.Items.Clear()

        Dim ponto As List(Of turno) = turnoRP.GetTurno()

        For i = 0 To ponto.Count() - 1

            ListViewTurno.Items.Add(ponto(i).idTurno)
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).nome))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).tempoSemanal))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).diasTrabSemanal))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).turnoDuracao))

            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).inicio))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).turnoFim))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).descanso))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).toleranciaEntrada))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).atrasoEntrada))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).descansoContabilizado))
            ListViewTurno.Items(ListViewTurno.Items.Count - 1).SubItems.Add((ponto(i).funcionariosNoTurno))

        Next
    End Sub

    Private Sub TurnoTempo_Click(sender As Object, e As EventArgs) Handles turnoTempo.Click

        'Dim resultado As Decimal
        Dim horas, minutos As Integer
        Dim sHoras, sMinutos As String
        Dim minutoTotalTurno As Integer
        Dim minutoTurno As Integer
        Dim horaTurno As Integer
        Dim DiasTrabSemana As Integer = Int(DiasTrabalhadosNaDemana.Text)


        If TurnoTempoSemanal.Text = "" Then
            MsgBox("horas semanais Inválido !")
            TurnoTempoSemanal.Focus()
            Exit Sub
        End If
        minutoTotalTurno = Convert.ToInt16(TurnoTempoSemanal.Text) * 60

        minutoTurno = Int(minutoTotalTurno / DiasTrabSemana)
        horaTurno = Int(minutoTurno / 60)
        minutoTurno = minutoTurno - (horaTurno * 60)
        horas = horaTurno
        minutos = minutoTurno
        sHoras = Trim(horas)
        If Len(sHoras) < 2 Then
            sHoras = "0" & sHoras
        End If

        'minutos = minutoTotalTurno - (horas * 60)
        sMinutos = Trim(Str(minutos))
        If Len(sMinutos) < 2 Then
            sMinutos = "0" & sMinutos
        End If

        turnoDuracao.Text = sHoras & ":" & sMinutos
    End Sub


    Private Sub btnFimTurno_Click(sender As Object, e As EventArgs) Handles btnFimTurno.Click
        Dim iHoraInicio, iMinutoInicio, iDuracaoHora, iDuracaoMinuto As Integer
        Dim dHora, dMinuto, hora, minuto As Integer
        Dim sHora, sMinuto As String

        If turnoInicio.Text = "  :" Then
            MsgBox("inicio do turno inválido !")
            turnoInicio.Focus()
            Exit Sub
        End If

        iHoraInicio = Int(Mid(turnoInicio.Text, 1, 2))
        iMinutoInicio = Int(Mid(turnoInicio.Text, 4))

        iDuracaoHora = Int(Mid(turnoDuracao.Text, 1, 2))
        iDuracaoMinuto = Int(Mid(turnoDuracao.Text, 4))

        If Not chkDescanso.Checked Then
            dHora = Int(Mid(TurnoTempoDescanso.Text, 1, 2))
            dMinuto = Int(Mid(TurnoTempoDescanso.Text, 4))
        Else
            dHora = 0
            dMinuto = 0
        End If

        sHora = Trim(Str((iHoraInicio + iDuracaoHora)))

        If (iMinutoInicio + iDuracaoMinuto) >= 60 Then

            hora = iHoraInicio + iDuracaoHora + 1
            minuto = iMinutoInicio + iDuracaoMinuto

        Else

            hora = iHoraInicio + iDuracaoHora
            minuto = iMinutoInicio + iDuracaoMinuto


        End If

        If (minuto + dMinuto) >= 60 Then

            sHora = Trim(Str((hora + 1)))
            sMinuto = Trim(Str((minuto + dMinuto) - 60))

        Else

            sHora = Trim(Str((hora + dHora)))
            sMinuto = Trim(Str((minuto + dMinuto)))

        End If



        If Len(sHora) < 2 Then
            sHora = "0" & sHora
        End If
        If Len(sMinuto) < 2 Then
            sMinuto = "0" & sMinuto
        End If

        turnoFim.Text = sHora & ":" & sMinuto
    End Sub

    Private Sub lblColaboradoresNumero_Click(sender As Object, e As EventArgs) Handles lblColaboradoresNumero.Click
        grpColaboradorDoTurno.Visible = True
        ListBox1.Items.Clear()
        GroupControlePrincipal.Enabled = False


        If OpenDB() Then
            Dim Query As String

            Dim DTReader As MySqlDataReader

            Query = "select concat(lpad(t1.chave, 4, '0'), ' - 0 - ', t1.colaboradorNome) as colaborador"
            Query = Query & " from colaborador t1, turno_colaborador t2"
            Query = Query & " where  t1.chave = t2.turno_colaboradorColaborador"
            Query = Query & " And"
            Query = Query & " t2.turno_colaboradorTurno = "
            Query = Query & lblOrdem.Text
            Query = Query & " and isnull(turno_colaboradorDataSaida)"
            Dim CMD As New MySqlCommand(Query, Conn)
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    ListBox1.Items.Add(DTReader.GetString(0))

                End While
                grpControle.Enabled = False
            Catch ex As Exception
                MsgBox("Problemas Name Gravação!")
            End Try
            Conn.Close()


            If OpenDB() Then
                Query = "Select concat(lpad(t1.chave, 4, '0'), ' - 1 - ', colaboradorNome) as colaborador "
                Query = Query & "from colaborador t1 where t1.chave not in (select turno_colaboradorColaborador from turno_colaborador where isNull(turno_colaboradorDataSaida) "
                Query = Query & "And isnull(turno_colaboradorcolRegistroVolta) "
                Query = Query & "Or t1.chave Not in (select turno_colaboradorColaborador from turno_colaborador))"


                Dim CMD1 As New MySqlCommand(Query, Conn)


                Try
                    DTReader = CMD1.ExecuteReader
                    While DTReader.Read

                        ListBox2.Items.Add(DTReader.GetString(0))

                    End While
                    grpControle.Enabled = False
                Catch ex As Exception
                    MsgBox("Problemas NameOf Gravação!")
                End Try

                Conn.Close()
            End If
        End If

    End Sub

    Private Sub lblVai_Click(sender As Object, e As EventArgs) Handles lblVai.Click
        'Dim sTroca As String
        'sTroca = ListBox1.SelectedItem
        'If OpenDB() Then
        '    Dim Query As String = "call turnoTroca(" & sTroca.Substring(1.4) & ",0)"
        '    Dim CMD As New MySqlCommand(Query, Conn)
        '    Dim DTReader As MySqlDataReader
        '    Try
        '        DTReader = CMD.ExecuteReader
        '    Catch ex As Exception
        '        MsgBox("Problemas Na Gravação!")
        '        Exit Sub
        '    End Try

        '    Conn.Close()
        'End If
        For i = 0 To ListBox1.Items.Count
            If ListBox1.SelectedIndex() = i Then
                ListBox2.Items.Add(ListBox1.SelectedItem)
                ListBox1.Items.RemoveAt(i)
            End If
        Next

    End Sub

    Private Sub lblVolta_Click(sender As Object, e As EventArgs) Handles lblVolta.Click

        For i = 0 To ListBox2.Items.Count
            If ListBox2.SelectedIndex() = i Then
                ListBox1.Items.Add(ListBox2.SelectedItem)
                ListBox2.Items.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub ListViewTurno_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewTurno.MouseDoubleClick

        Dim bGrava As Boolean = False

        If OpenDB() Then
            Dim Query As String = "Select *, (Select count(*) from turno_colaborador where turno.idturno=turno_colaboradorTurno  And isnull(turno_colaboradorDataSaida)) from turno where idturno = " & ListViewTurno.SelectedItems(0).Text
            ''"Select *, (Select count(*) from turno_colaborador where turno.idturno=turno_colaboradorTurno) from turno"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            turnoInicia()
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    'MsgBox(DTReader.GetString(0))
                    arryManutencao(1) = DTReader.GetString(1)
                    arryManutencao(2) = DTReader.GetString(2)
                    arryManutencao(3) = DTReader.GetString(3)
                    arryManutencao(4) = DTReader.GetString(4)
                    arryManutencao(5) = DTReader.GetString(5)
                    arryManutencao(6) = DTReader.GetString(6)
                    arryManutencao(7) = DTReader.GetString(7)
                    arryManutencao(8) = DTReader.GetString(8)
                    arryManutencao(9) = DTReader.GetString(10)


                    TurnoNome.Text = DTReader.GetString(1)
                    DiasTrabalhadosNaDemana.Text = DTReader.GetString(2)
                    TurnoTempoSemanal.Text = DTReader.GetString(3)

                    turnoDuracao.Text = DTReader.GetString(4)
                    turnoInicio.Text = DTReader.GetString(5)
                    TurnoTempoDescanso.Text = DTReader.GetString(6)
                    turnoInicioTolerancia.Text = DTReader.GetString(7)
                    turnoFim.Text = DTReader.GetString(8)
                    mskToleranciaEntrada.Text = DTReader.GetString(9)
                    grpControle.Text = "M A N U T E N Ç Ã O"
                    lblTipo.Text = "1"
                    lblOrdem.Text = DTReader.GetString(0)
                    lblColaboradoresNumero.Text = DTReader.GetString(11)
                    chkDescanso.Checked = DTReader.GetString(10)
                    TurnoNome.Focus()



                End While

                grpTurnos.Enabled = False
            Catch ex As Exception
                MsgBox("Problemas  Gravação!")
            End Try

            Conn.Close()
            grpTurnos.Text = grpTurnos.Text & " Travado em " & Now()
        End If

    End Sub

    Function gravacaoDBnecessidade(ar()) As Boolean
        Dim bGrava As Boolean
        If TurnoNome.Text = ar(1) Then bGrava = True
        If TurnoTempoSemanal.Text = ar(2) Then bGrava = True
        If turnoDuracao.Text = ar(3) Then bGrava = True
        If turnoInicio.Text = ar(4) Then bGrava = True
        If TurnoTempoDescanso.Text = ar(5) Then bGrava = True
        If turnoInicioTolerancia.Text = ar(6) Then bGrava = True
        If turnoFim.Text = ar(7) Then bGrava = True
        If mskToleranciaEntrada.Text = ar(8) Then bGrava = True
        gravacaoDBnecessidade = bGrava
    End Function

    Private Sub btnTerminaColaboradorTurno_Click(sender As Object, e As EventArgs) Handles btnTerminaColaboradorTurno.Click
        grpControle.Enabled = True
        grpControle.Focus()
        grpColaboradorDoTurno.Visible = False
        GroupControlePrincipal.Enabled = True
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()


    End Sub

    Private Sub turnoGrava_Click(sender As Object, e As EventArgs) Handles turnoGrava.Click
        Dim strAcao As String

        'verificacao se algum campo foi alterado
        'If Not gravacaoDBnecessidade(Array) Then
        '    MsgBox("Campos Não foram alterados!")
        '    Exit Sub
        'End If

        strAcao = "call turnoManutencao ("
        strAcao = strAcao & lblOrdem.Text & ","
        strAcao = strAcao & "'" & TurnoNome.Text & "'"
        strAcao = strAcao & ",'" & TurnoTempoSemanal.Text & "'"
        strAcao = strAcao & ",'" & DiasTrabalhadosNaDemana.Text & "'"
        strAcao = strAcao & ",'" & turnoDuracao.Text & "'"
        strAcao = strAcao & ",'" & turnoInicio.Text & "'"
        strAcao = strAcao & ",'" & TurnoTempoDescanso.Text & "'"
        strAcao = strAcao & ",'" & turnoInicioTolerancia.Text & "'"
        strAcao = strAcao & ",'" & turnoFim.Text & "'"
        strAcao = strAcao & ",'" & mskToleranciaEntrada.Text & "'"
        strAcao = strAcao & "," & lblTipo.Text
        strAcao += "," & IIf(chkDescanso.Checked, 1, 0) & ")"

        If OpenDB() Then


            Dim Query As String = strAcao
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    MsgBox(DTReader.GetString(0))

                End While
                turnoInicia()

            Catch ex As Exception
                MsgBox("Problemas NameOf Gravação!")
            End Try

            Conn.Close()
            grpTurnos.Enabled = True
            carregaGrid()

        End If
    End Sub

    Private Sub turnoLimpa_Click(sender As Object, e As EventArgs) Handles turnoLimpa.Click
        limpaCampos()
    End Sub

    Private Sub btnTurnoCaracteristicas_Click(sender As Object, e As EventArgs) Handles btnTurnoCaracteristicas.Click
        grpTurnos.Enabled = True
        limpaCampos()
        grpTurnos.Text = "Turnos - C A R A C T E R I S T I C A S"

    End Sub

    Private Sub btnGravaColaboradorTurno_Click(sender As Object, e As EventArgs) Handles btnGravaColaboradorTurno.Click
        Dim msg As String
        Dim style As String
        Dim title As String
        Dim ctxt As String
        Dim help As String
        Dim resposta As String
        '---------------------
        Dim Query As String
        Dim DTReader As MySqlDataReader
        msg = "Confirma Gravação?"
        style = vbYesNo + vbQuestion + vbDefaultButton1
        title = "Caracteristicas do turno"
        help = "folha.hlp"
        ctxt = 1000

        resposta = MsgBox(msg, style, title)
        'MsgBox(resposta)
        If resposta = 6 Then

            For Each item As String In ListBox1.Items
                If Not OpenDB() Then
                    Conn.Open()
                End If
                'MsgBox(item.Substring(7, 1))
                If item.Substring(7, 1) = "1" Then ' incrementar no turno
                    Query = "call turnoTroca(" & item.Substring(1, 4) & "," & lblOrdem.Text & ",0)"
                    Dim CMD As New MySqlCommand(Query, Conn)

                    Try
                        DTReader = CMD.ExecuteReader
                        'While DTReader.Read

                        '    MsgBox(DTReader.GetString(0))

                        'End While
                    Catch ex As Exception
                        MsgBox("Problemas comGravação!")
                    End Try

                End If
                Conn.Close()

            Next



            For Each item As String In ListBox2.Items
                'MsgBox(item.Substring(7, 1))
                If Not OpenDB() Then
                    Conn.Open()
                End If
                If item.Substring(7, 1) = "0" Then ' retirar do turno
                    Query = "call turnoTroca(" & item.Substring(1, 4) & "," & lblOrdem.Text & ",1)"
                    Dim CMD As New MySqlCommand(Query, Conn)

                    Try
                        DTReader = CMD.ExecuteReader
                        While DTReader.Read

                            MsgBox(DTReader.GetString(0))

                        End While

                    Catch ex As Exception
                        MsgBox("Problemas comGravação!")
                    End Try

                End If
                Conn.Close()
            Next
            msg = "Gravação realizada"
            style = vbNormal
            title = "Caracteristicas do turno"
            lblColaboradoresNumero.Text = ListBox1.Items.Count
        Else
            msg = "Gravação Cancelada"
            style = vbExclamation
            title = "Caracteristicas do turno"

        End If
        resposta = MsgBox(msg, style, title)
        grpControle.Enabled = True
        grpControle.Focus()
        grpColaboradorDoTurno.Visible = False
        GroupControlePrincipal.Enabled = True
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Sub

    Private Sub turnoTermina_Click(sender As Object, e As EventArgs) Handles turnoTermina.Click
        Me.Close()
    End Sub

    Private Sub ListViewTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewTurno.SelectedIndexChanged

    End Sub

    Private Sub ListViewTurno_DoubleClick(sender As Object, e As EventArgs) Handles ListViewTurno.DoubleClick

    End Sub

    Private Sub ListViewTurno_Click(sender As Object, e As EventArgs) Handles ListViewTurno.Click

    End Sub
End Class