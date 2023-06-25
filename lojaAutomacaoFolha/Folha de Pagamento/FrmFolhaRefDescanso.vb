Imports MySql.Data.MySqlClient
Public Class FrmFolhaRefDescanso
    Public oi As New MsgShow
    Private Sub FrmFolRefDescanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.title = "Dencanso da Referência"
    End Sub


    Private Sub MskMesAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskMesAno.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            Me.Close()

        End If

        If e.KeyChar = Convert.ToChar(13) Then
            BtnReinicializa.Visible = False
            BtnAbreEdicao.Enabled = False
            GruParamentrosReferencia.Visible = False

            Dim inAno As Integer = 0
            Dim inMes As Integer = 0

            If Trim(Replace(MskMesAno.Text, "/", "")) = "" Or Len(Trim(MskMesAno.Text)) < 7 Then
                With oi
                    .msg = "Campo Ano / Mes Inválido!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub
                End With
            End If

            inMes = Int(MskMesAno.Text.Substring(0, 2))

            If inMes = 0 Or inMes > 12 Then

                With oi
                    .msg = "Mes Inválido!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub
                End With

            End If

            inAno = Int(MskMesAno.Text.Substring(3, 4))

            If inAno < 1900 Then
                With oi
                    .msg = "Ano fora de registro!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub
                End With

            End If

            LblReferenciaDescricao.Text = mesNome(inMes) & "/" & inAno

            Dim strReferencia As String = MskMesAno.Text.Substring(3) & MskMesAno.Text.Substring(0, 2)

            Dim query As String = "select count(*) from diasuteiscab where DUCabAnoMes = '" & strReferencia & "'"

            If apontaSQL(query) = 0 Then
                LvwShow.Items.Clear()
                With oi
                    .msg = "Referência não casdatrada! quer cadastrar?"
                    .style = vbYesNo
                    .resposta = MsgBox(.msg, .style, .title)
                    If .resposta <> 6 Then
                        Exit Sub
                    End If

                    LblAviso.Visible = True
                    LblAviso.Text = "Referência não cadastrada! realize o gravação."
                    preencheLvwEdicao()
                    GravaSemEdicao(True)
                    BtnGravar.Focus()

                End With
            Else
                BtnReinicializa.Visible = True
                BtnAbreEdicao.Enabled = True
                Dim refCab As List(Of DiasUteisCab) = DiasUteisAcao.GetDiasUteisCabSQL(strReferencia)
                Dim refCorpo As List(Of DiasUteisCorpo) = DiasUteisAcao.GetDiasUteisCorpoSQL(refCab(0).idCab)

                LblkeyCab.Text = refCab(0).idCab
                GruParamentrosReferencia.Visible = True
                With refCab(0)

                    LblDiasCorridos.Text = .DUCabDiasCorrido
                    LblDiasUteis.Text = .DUCabDiasUteis
                    LblDiasDescanso.Text = .DUCabDiasDescanso
                    LblDomingos.Text = .DUCabDomingos
                    Lblferiados.Text = .DUCabFeriados
                    LblSemanaInicial.Text = .DUCabNumSemanaInicial
                    LblSemanaFinal.Text = .DUCabNumSemanaFinal

                End With

                With LvwShow

                    .Items.Clear()
                    Dim strDiaDoMes As String = ""

                    .Sorting = SortOrder.None

                    For i = 0 To refCorpo.Count - 1

                        strDiaDoMes = refCorpo(i).diasuteisCorpoDia
                        strDiaDoMes = strDiaDoMes.PadLeft(2, "0")

                        .Items.Add(strDiaDoMes)
                        .Items(.Items.Count - 1).SubItems.Add(refCorpo(i).diasuteisCorpoTipo)
                        .Items(.Items.Count - 1).SubItems.Add(refCorpo(i).diasuteisCorpoTitulo)
                        .Items(.Items.Count - 1).SubItems.Add(refCorpo(i).diasuteisCorpoSemana)
                        .Items(.Items.Count - 1).SubItems.Add(refCorpo(i).diasuteisCorpoHistorico)
                        .Items(.Items.Count - 1).SubItems.Add("(R)")
                        .Items(.Items.Count - 1).SubItems.Add(refCorpo(i).id_corpo)

                    Next
                    .Sorting = SortOrder.Ascending
                End With

            End If





        End If
    End Sub


    Private Function preencheLvwEdicao()

        Dim dtDataPrimeira As Date = "01/" + MskMesAno.Text
        Dim dtDataUltima As Date = Func_Ultimo_Dia_Mes(dtDataPrimeira)
        Dim DomingosNoMes As Integer = 0

        Dim a1 As Integer = dtDataPrimeira.Year
        Dim m1 As Integer = dtDataPrimeira.Month
        Dim d1 As Integer = dtDataPrimeira.Day

        Dim a2 As Integer = dtDataUltima.Year
        Dim m2 As Integer = dtDataUltima.Month
        Dim d2 As Integer = dtDataUltima.Day

        LvwShow.Items.Clear()

        DomingosNoMes = DomingosDoIntervalo(a1, m1, d1, a2, m2, d2, Me.LvwShow)

    End Function


    Private Sub MskEdicaoDia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskEdicaoDia.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            'MskEdicaoDia.Enabled = False

            LvwShow.Focus()


        End If

        If e.KeyChar = Convert.ToChar(13) Then

            'lvwShowEdicaoLimpa()

            Dim dtData As Date

            With MskEdicaoDia
                If Trim(.Text) = "" Then
                    Exit Sub
                End If
                Dim inDia As Integer = Int(MskEdicaoDia.Text)

                If inDia < 1 Or inDia > Func_Ultimo_Dia_Mes("01/" + MskMesAno.Text).Day Then

                    oi.msg = "Data inválida!"
                    oi.style = vbExclamation
                    MsgBox(oi.msg, oi.style, oi.title)
                    Exit Sub

                End If

                CmbTitulo.Enabled = True
                CmbTitulo.Focus()
                MskEdicaoDia.Enabled = False

                MskEdicaoDia.Text = MskEdicaoDia.Text.PadLeft(2, "0")
                dtData = MskEdicaoDia.Text & "/" & MskMesAno.Text
                LbDiaSemanal.Text = semanaDiaNome(Weekday(dtData))
                LblEdicaoSemana.Text = DatePart(DateInterval.WeekOfYear, dtData)

            End With
        End If
    End Sub

    Private Sub BtnEdita_Click(sender As Object, e As EventArgs) Handles BtnEdita.Click

        Dim strDiaDoMes As String = ""

        LvwShow.Sorting = SortOrder.None

        If Not LblEdicaoTipo.Visible Then

            With LvwShow
                strDiaDoMes = MskEdicaoDia.Text
                strDiaDoMes = strDiaDoMes.PadLeft(2, "0")
                .Items.Add(strDiaDoMes)
                .Items(.Items.Count - 1).SubItems.Add(LbDiaSemanal.Text)
                .Items(.Items.Count - 1).SubItems.Add(CmbTitulo.Text)
                .Items(.Items.Count - 1).SubItems.Add(LblEdicaoSemana.Text)
                .Items(.Items.Count - 1).SubItems.Add(TxtEdicaoHistorico.Text)
                .Items(.Items.Count - 1).SubItems.Add("(D)")


            End With

        Else
            Dim Indice As Integer
            Dim lv As ListView.SelectedIndexCollection
            lv = LvwShow.SelectedIndices
            Indice = lv.Item(0) ' indice selecionado no listview
            strDiaDoMes = MskEdicaoDia.Text
            strDiaDoMes = strDiaDoMes.PadLeft(2, "0")

            With LvwShow
                .Items(Indice).SubItems(0).Text = strDiaDoMes
                .Items(Indice).SubItems(1).Text = LbDiaSemanal.Text
                .Items(Indice).SubItems(2).Text = CmbTitulo.Text
                .Items(Indice).SubItems(3).Text = LblEdicaoSemana.Text
                .Items(Indice).SubItems(4).Text = TxtEdicaoHistorico.Text
                .Items(Indice).SubItems(5).Text = IIf(.Items(Indice).SubItems(5).Text = "(D)", "(D)", "(A)")

            End With

        End If
        LvwShow.Sorting = SortOrder.Ascending
        MskEdicaoDia.Enabled = True
        lvwShowEdicaoLimpa()
        LvwShow.Focus()
        BtnEdita.Visible = False

    End Sub
    Private Function lvwShowEdicaoLimpa()

        MskEdicaoDia.Text = ""
        LbDiaSemanal.Text = ""
        CmbTitulo.Text = ""
        LblEdicaoSemana.Text = ""
        TxtEdicaoHistorico.Text = ""
        LblEdicaoTipo.Visible = False

    End Function

    Private Sub LvwShow_DoubleClick(sender As Object, e As EventArgs) Handles LvwShow.DoubleClick
        Dim Indice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = LvwShow.SelectedIndices

        Indice = lv.Item(0) ' indice selecionado no listview

        MskEdicaoDia.Text = LvwShow.Items(Indice).Text
        LbDiaSemanal.Text = LvwShow.Items(Indice).SubItems(1).Text
        CmbTitulo.Text = LvwShow.Items(Indice).SubItems(2).Text
        LblEdicaoSemana.Text = LvwShow.Items(Indice).SubItems(3).Text
        TxtEdicaoHistorico.Text = LvwShow.Items(Indice).SubItems(4).Text
        LblEdicaoTipo.Visible = True
        LblEdicaoTipo.Text = "E D I Ç Ã O"
        BtnRetira.Visible = True

        MskEdicaoDia.Enabled = True
        MskEdicaoDia.Focus()


    End Sub

    Private Sub BtnRetira_Click(sender As Object, e As EventArgs) Handles BtnRetira.Click

        Dim Indice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = LvwShow.SelectedIndices

        Indice = lv.Item(0) ' indice selecionado no listview

        If LvwShow.Items(Indice).SubItems(5).Text = "(D)" Then

            LvwShow.Items(Indice).Remove()

        Else

            LvwShow.Items(Indice).SubItems(5).Text = "(-)"

        End If


        lvwShowEdicaoLimpa()

        LblEdicaoTipo.Visible = False

        BtnRetira.Visible = False

        MskEdicaoDia.Enabled = True

        MskEdicaoDia.Text = ""
        CmbTitulo.Text = ""
        CmbTitulo.Enabled = False
        TxtEdicaoHistorico.Text = ""
        TxtEdicaoHistorico.Enabled = False

        LblEdicaoSemana.Text = ""
        LbDiaSemanal.Text = ""

    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click

        Dim inAltera As Integer = 0
        Dim inDigitado As Integer = 0
        Dim inApagar As Integer = 0
        Dim inRegistrado As Integer = 0
        Dim inSistema As Integer = 0
        Dim inDescansos As Integer = 0
        Dim inDiasUteis As Integer = 0
        Dim inDiasCorridosMes As Integer = Func_Ultimo_Dia_Mes("01/" & MskMesAno.Text).Day
        Dim inDomingos As Integer = 0
        Dim inFeriados As Integer = 0

        Dim inProvocaSQL As Integer = 0

        '++++++++++++++++++++++
        'Verifica se existe alteracoes no corpo do descanso
        For i = 0 To LvwShow.Items.Count - 1
            Select Case LvwShow.Items(i).SubItems(5).Text

                Case = "(R)"                ' registrados
                    inRegistrado += 1
                Case = "(S)"                ' lancado pelo sistema
                    inSistema += 1
                    inProvocaSQL += 1
                Case = "(D)"                ' digitado
                    inDigitado += 1
                    inProvocaSQL += 1
                Case = "(A)"                ' alterado
                    inAltera += 1
                    inProvocaSQL += 1
                Case = "(-)"                ' apagar
                    inApagar += 1
                    inProvocaSQL += 1

            End Select

            Select Case LvwShow.Items(i).SubItems(1).Text

                Case = "Domingo"

                    inDomingos += 1

            End Select

            If LvwShow.Items(i).SubItems(5).Text <> "(-)" Then inDescansos += 1

        Next
        inFeriados = inDescansos - inDomingos

        If inProvocaSQL = 0 Then
            With oi

                .msg = "Não foram realizadas alterações!"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)

            End With

            Exit Sub
        Else
            With oi

                .msg = "Incremento de registros" & Chr(13) & "sistema(S) = " & inSistema & Chr(13) & "Digitação(D) = " & inDigitado & Chr(13) & "Alteração(A) = " & inAltera & Chr(13) & "Retirados da base(-) =" & inApagar
                .msg += Chr(13) & "Continua?"
                .style = vbYesNo
                .resposta = MsgBox(.msg, .style, .title)
                If .resposta <> 6 Then
                    Exit Sub
                End If


            End With
        End If
        '++++++++++++++++++++++

        Dim inmes As Integer = Int(MskMesAno.Text.Substring(0, 2))
        Dim strReferencia As String = MskMesAno.Text.Substring(3) & MskMesAno.Text.Substring(0, 2)

        inDiasUteis = inDiasCorridosMes - inDescansos

        Dim query As String = ""


        If LblAviso.Visible Then

            ' Necessario Gravar o cabecario gravar


            query += " insert into  diasuteiscab "
            query += "("
            query += "DUCabAnoMes"
            query += ",DUCabNome"
            query += ",DUCabDiasCorrido"
            query += ",DUCabDiasUteis"
            query += ",DUCabDiasDescanso"
            query += ",DUCabDomingos"
            query += ",DUCabFeriados"
            query += ",DUCabNumSemanaInicial"
            query += ",DUCabNumSemanaFinal"
            query += ",DUcab_abertura"
            query += ")"
            query += " values "
            query += "("
            query += "'" & strReferencia & "'"
            query += ",'" & mesNome(inmes) & "'"
            query += "," & inDiasCorridosMes
            query += "," & inDiasUteis
            query += "," & inDescansos
            query += "," & inDomingos
            query += "," & inFeriados
            query += "," & LvwShow.Items(0).SubItems(3).Text
            query += "," & LvwShow.Items(LvwShow.Items.Count - 1).SubItems(3).Text
            query += "," & "UTC_DATE()+0"
            query += ")"

        Else


            query += " update  diasuteiscab set "
            query += " DUCabDiasCorrido      = " & inDiasCorridosMes
            query += ",DUCabDiasUteis        = " & inDiasUteis
            query += ",DUCabDiasDescanso     = " & inDescansos
            query += ",DUCabDomingos         = " & inDomingos
            query += ",DUCabFeriados         = " & inFeriados
            query += ",DUCabNumSemanaInicial = " & LvwShow.Items(0).SubItems(3).Text
            query += ",DUCabNumSemanaFinal   = " & LvwShow.Items(LvwShow.Items.Count - 1).SubItems(3).Text
            query += " Where  DUCabAnoMes = '" & strReferencia & "'"

        End If

        gravaSQL(query)

        Dim refCab As List(Of DiasUteisCab) = DiasUteisAcao.GetDiasUteisCabSQL(strReferencia)
        LblkeyCab.Text = refCab(0).idCab


        'LvwShow.Sorting = SortOrder.Ascending


        With refCab(0)

            .DUCabAnoMes = strReferencia
            .DUCabNome = mesNome(inmes)
            .DUCabDiasCorrido = Func_Ultimo_Dia_Mes("01/" & MskMesAno.Text).Day
            .DUCabDomingos = 0
            .DUCabFeriados = 0

            For i = 0 To (LvwShow.Items.Count - 1)

                Select Case LvwShow.Items(i).SubItems(1).Text

                    Case = "Domingo"
                        .DUCabDomingos += 1
                    Case Else
                        .DUCabFeriados += 1
                End Select

            Next

            .DUCabDiasDescanso = (.DUCabDomingos + .DUCabFeriados)
            .DUCabDiasUteis = .DUCabDiasCorrido - .DUCabDiasDescanso
            .DUCabNumSemanaInicial = LvwShow.Items(0).SubItems(3).Text
            .DUCabNumSemanaFinal = LvwShow.Items(LvwShow.Items.Count - 1).SubItems(3).Text


            '''If LblAviso.Visible Then
            '''    Dim refCorpo As List(Of DiasUteisCorpo) = DiasUteisAcao.GetDiasUteisCorpoLvw(refCab(0).idCab)
            '''Else
            '''    Dim refCorpo As List(Of DiasUteisCorpo) = DiasUteisAcao.GetDiasUteisCorpoSQL(refCab(0).idCab)
            '''End If

            Dim desc As Object
            desc = abc(desc, refCab(0).idCab)

            Dim strStatus As String


            For i = 0 To LvwShow.Items.Count - 1

                query = ""
                strStatus = LvwShow.Items(i).SubItems(5).Text

                Select Case strStatus

                    Case "(S)", "(L)", "(D)"


                        ' Incrementar referencia

                        query += "Insert into diasuteiscorpo "
                        query += "("
                        query += " idDUcab "
                        query += ",diasuteisCorpoDia"
                        query += ",diasuteisCorpoTipo"
                        query += ",diasuteisCorpoTitulo"
                        query += ",diasuteisCorpoSemana"
                        query += ",diasuteiscorpoHistorico"
                        query += ") "
                        query += " values "
                        query += "("
                        query += LblkeyCab.Text
                        query += "," & LvwShow.Items(i).SubItems(0).Text
                        query += ",'" & LvwShow.Items(i).SubItems(1).Text & "'"
                        query += ",'" & LvwShow.Items(i).SubItems(2).Text & "'"
                        query += "," & LvwShow.Items(i).SubItems(3).Text
                        query += ",'" & LvwShow.Items(i).SubItems(4).Text & "'"
                        query += ") "

                    Case "(A)"


                        query += "update diasuteiscorpo set"
                        query += " diasuteisCorpoDia =" & LvwShow.Items(i).SubItems(0).Text
                        query += ",diasuteisCorpoTipo = '" & LvwShow.Items(i).SubItems(1).Text & "'"
                        query += ",diasuteisCorpoTitulo ='" & LvwShow.Items(i).SubItems(2).Text & "'"
                        query += ",diasuteisCorpoSemana =" & LvwShow.Items(i).SubItems(3).Text
                        query += ",diasuteiscorpoHistorico = '" & LvwShow.Items(i).SubItems(4).Text & "'"
                        query += " Where "
                        query += " iddiasuteisCorpo = " & LvwShow.Items(i).SubItems(6).Text

                    Case "(-)"


                        query += "delete from diasuteiscorpo "
                        query += " Where iddiasuteisCorpo = " & LvwShow.Items(i).SubItems(6).Text

                    Case "(R)"

                        Continue For

                End Select

                gravaSQL(query)


            Next

        End With

        lvwShowEdicaoLimpa()
        GruParamentrosReferencia.Visible = vbFalse
        LvwShow.Items.Clear()
        MskMesAno.Text = ""

        LblAviso.Visible = False
        LblkeyCab.Text = ""
        LblReferenciaDescricao.Text = ""
        GravaSemEdicao(False)
        MskMesAno.Focus()

    End Sub

    Private Function abc(r As Object, inNumero As Integer) As Object
        If LblAviso.Visible Then
            Dim refCorpo As List(Of DiasUteisCorpo) = DiasUteisAcao.GetDiasUteisCorpoLvw(inNumero)
            Return refCorpo
        Else
            Dim refCorpo As List(Of DiasUteisCorpo) = DiasUteisAcao.GetDiasUteisCorpoSQL(inNumero)
            Return refCorpo
        End If


    End Function

    Private Sub BtnReinicializa_Click(sender As Object, e As EventArgs) Handles BtnReinicializa.Click

        Dim strReferencia As String = MskMesAno.Text.Substring(3) & MskMesAno.Text.Substring(0, 2)

        Dim RegistroCab As Integer = 0

        If Trim(LblkeyCab.Text) <> "" Then

            RegistroCab = Int(LblkeyCab.Text)

        Else

            MsgBox("Registro nao identificado")

            Exit Sub

        End If

        With oi

            .msg = "Referência será reinicializada, concorda?"
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)

            If .resposta = 6 Then

                MsgBox("apagar")
                If Not descansoCorpoApaga(RegistroCab) Then

                    MsgBox("Erro na remoção do registro cabeçário da Tabela descanso ")

                    Exit Sub

                End If


                If Not descansoCabApaga(strReferencia) Then

                    MsgBox("Erro na remoção do registro do corpo do cabeçário da Tabela descanso ")

                    Exit Sub

                End If

            End If

        End With

    End Sub
    Private Function descansoCorpoApaga(registroCab As Integer) As Boolean
        Dim query As String = ""
        query = "delete from diasuteiscorpo where idDUcab = " & registroCab
        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        descansoCorpoApaga = False
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                descansoCorpoApaga = True
            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            Conn.Close()

            Return descansoCorpoApaga

        End If
    End Function

    Private Function descansoCabApaga(referencia As String) As Boolean

        Dim query As String = ""
        query = "delete from diasuteiscab where DUCabAnoMes = '" & referencia & "'"
        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        descansoCabApaga = False
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                descansoCabApaga = True

            Catch ex As Exception

                MsgBox("Problemas Na Gravação!")

            End Try

            Conn.Close()

            Return descansoCabApaga

        End If
    End Function

    Private Sub MskMesAno_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskMesAno.MaskInputRejected

    End Sub

    Private Sub BtnAbreEdicao_Click(sender As Object, e As EventArgs) Handles BtnAbreEdicao.Click

        AbreEdicao(True)

    End Sub

    Private Sub BtnSaiDaEdicao_Click(sender As Object, e As EventArgs) Handles BtnSaiDaEdicao.Click

        AbreEdicao(False)

        MskMesAno.Focus()

        MskEdicaoDia.Enabled = True

    End Sub

    Private Function GravaSemEdicao(boFlag As Boolean)

        GruEdicaoGeral.Enabled = boFlag
        GruEdicao.Enabled = Not boFlag
        LvwShow.Enabled = Not boFlag
        BtnGravar.Enabled = boFlag

    End Function

    Private Function AbreEdicao(boFlag As Boolean)

        GruEdicaoGeral.Enabled = boFlag
        GruEdicao.Enabled = boFlag
        LvwShow.Enabled = boFlag
        BtnGravar.Enabled = boFlag

    End Function
    Private Sub CmbTitulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTitulo.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            MskEdicaoDia.Enabled = True
            MskEdicaoDia.Focus()
            CmbTitulo.Enabled = False

        End If

        If e.KeyChar = Convert.ToChar(13) Then
            If String.IsNullOrEmpty(CmbTitulo.SelectedText) Then
                With oi

                    .msg = "Por favor,Selecione uma informação."
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub

                End With
                Exit Sub

            End If

            TxtEdicaoHistorico.Enabled = True
                TxtEdicaoHistorico.Focus()
                CmbTitulo.Enabled = False

            End If

    End Sub

    Private Sub TxtEdicaoHistorico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdicaoHistorico.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            CmbTitulo.Enabled = True
            CmbTitulo.Focus()
            TxtEdicaoHistorico.Enabled = False

        End If

        If e.KeyChar = Convert.ToChar(13) Then

            If String.IsNullOrEmpty(TxtEdicaoHistorico.Text) Then
                With oi

                    .msg = "Por favor,Digite o Histórico do descanso."
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)
                    Exit Sub

                End With
                Exit Sub

            End If
            BtnEdita.Visible = True
            BtnEdita.Focus()
            TxtEdicaoHistorico.Enabled = False


        End If

    End Sub

    Private Sub BtnEdita_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnEdita.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            TxtEdicaoHistorico.Enabled = True
            TxtEdicaoHistorico.Focus()

        End If

    End Sub

    Private Sub GruEdicaoGeral_Enter(sender As Object, e As EventArgs) Handles GruEdicaoGeral.Enter

    End Sub
End Class