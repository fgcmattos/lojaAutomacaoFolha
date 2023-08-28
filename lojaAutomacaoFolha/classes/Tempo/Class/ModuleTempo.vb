Imports MySql.Data.MySqlClient

Module ModuleTempo
    Function Time_To_String(IsTimes As TimeSpan) As String

        Dim isRetorno As String

        Dim timeString As String = IsTimes.ToString

        Dim parts() As String = timeString.Split(":"c)

        Dim isDays As Integer = Convert.ToDecimal(parts(0).Replace(".", ","))

        Dim isDays_decimal As Integer = (Convert.ToDecimal(parts(0).Replace(".", ",")) - isDays) * 100

        Dim isHours As Integer

        'If parts.Length = 3 Then
        If isDays_decimal > 0 Then

            isHours = (Convert.ToInt32(isDays) * 24) + isDays_decimal


            isRetorno = isHours.ToString & ":" & parts(2).ToString

        Else

            isHours = isDays

            isRetorno = isHours.ToString.PadLeft(2, "0"c) & ":" & parts(1).ToString

        End If

        Return (isRetorno)

    End Function

    Function CalculoDaIdade(ano As String, mes As String, dia As String, anoNow As String, mesNow As String, diaNow As String) As String

        Dim voltaAno, voltaMes, voltaDia As Integer
        Dim mesAnterior As String
        Dim Lanos, Lmes, Ldias, Frase As String

        'Lanos = "ano"
        'lmes = ""
        'ldias = ""
        Frase = ""

        voltaAno = CInt(anoNow)
        voltaMes = CInt(mesNow)
        voltaDia = CInt(diaNow)

        If mesNow < mes Or (mesNow = mes And diaNow < dia) Then
            voltaAno = voltaAno - 1
            voltaMes = voltaMes + 12
        End If

        If CInt(diaNow) < dia Then
            mesAnterior = CStr(IIf(CInt(mesNow) = 1, 12, CInt(mesNow) - 1))
            mesAnterior = IIf(Len(mesAnterior) < 2, "0" & mesAnterior, mesAnterior)
            voltaMes = voltaMes - 1
            If CInt(mesAnterior) = 2 Then
                voltaDia = voltaDia + AnoBisexto(ano)
            ElseIf InStrRev("01/03/05/07/08/10/12", mesAnterior, -1) <> 0 Then
                voltaDia = voltaDia + 31
            Else
                voltaDia = voltaDia + 30
            End If

        End If

        ano = voltaAno - CInt(ano)
        mes = voltaMes - CInt(mes)
        dia = voltaDia - CInt(dia)
        If ano > 1 Then Lanos = " anos " Else Lanos = " ano "
        If mes > 1 Then Lmes = " meses " Else Lmes = " mes "
        If dia > 1 Then ldias = " dias " Else ldias = " dia "

        If ano > 0 Then
            frase = ano & lanos
        End If
        If mes > 0 Then
            frase = frase & mes & lmes
        End If
        If dia > 0 Then
            frase = frase & dia & ldias
        End If

        CalculoDaIdade = frase

    End Function

    Function Idade(idata As String) As String
        Dim ano, mes, dia, anoNow, mesNow, diaNow As String
        Dim dataNow As String

        dataNow = Mid(Now, 1, 10)
        anoNow = Mid(dataNow, 7, 4)
        mesNow = Mid(dataNow, 4, 2)
        diaNow = Mid(dataNow, 1, 2)

        idata = Trim(Replace(idata, "/", ""))

        If Len(idata) < 8 Or idata = "" Then
            Idade = "200 - Data inválida "
        Else
            ano = Mid(idata, 5, 4)
            mes = Mid(idata, 3, 2)
            dia = Mid(idata, 1, 2)
            If ano > anoNow Then
                Idade = "201"
            ElseIf mes > 12 Then
                Idade = "202 - Mês inválido"
            ElseIf dia > 31 Then
                Idade = "203 - Dia inválido"
            ElseIf dia = 31 And InStrRev("02/04/06/09/11", mes, -1) <> 0 Then
                Idade = "204 - Dia inválido"
            ElseIf dia >= 30 And mes = "02" Then
                Idade = "205 - Dia inválido"
            ElseIf dia > anoBisexto(CInt(ano)) And mes = "02" Then
                Idade = "206 Dias de Fevereiro inválido"
            Else
                Idade = CalculoDaIdade(ano, mes, dia, anoNow, mesNow, diaNow)
            End If

        End If

    End Function

    Public Function DataVerifica(pass As Boolean, present As Boolean, future As Boolean, dataVerificada As String, dataNow As String) As Boolean
        Dim ano, mes, dia, anoNow, mesNow, diaNow As String
        DataVerifica = True
        anoNow = dataNow.Substring(0, 4)
        mesNow = dataNow.Substring(4, 2)
        diaNow = dataNow.Substring(6, 2)

        'dataVerificada = Trim(Replace(dataVerificada, "/", ""))

        If Len(dataVerificada) < 8 Or dataVerificada = "" Then
            DataVerifica = False ' idade = "200 - Data inválida "
        Else
            ano = dataVerificada.Substring(0, 4)
            mes = dataVerificada.Substring(4, 2)
            dia = dataVerificada.Substring(6, 2)
            ''If ano > anoNow Then
            ''    DataVerifica = False  ' idade = "201"
            If mes > 12 Then
                DataVerifica = False  ' idade = "202 - Mês inválido"
            ElseIf dia > 31 Then
                DataVerifica = False  ' idade = "203 - Dia inválido"
            ElseIf dia = 31 And InStrRev("02/04/06/09/11", mes, -1) <> 0 Then
                DataVerifica = False  ' idade = "204 - Dia inválido"
            ElseIf dia >= 30 And mes = "02" Then
                DataVerifica = False  ' idade = "205 - Dia inválido"
            ElseIf dia > anoBisexto(CInt(ano)) And mes = "02" Then
                DataVerifica = False  ' idade = "206 Dias de Fevereiro inválido"
            Else
                ' data valida
                If dataNow < dataVerificada And future Then
                    DataVerifica = True
                ElseIf dataNow = dataVerificada And present Then
                    DataVerifica = True
                ElseIf dataNow > dataVerificada And pass Then
                    DataVerifica = True
                Else
                    DataVerifica = False
                End If
            End If

        End If

    End Function

    Function AnoBisexto(ano As Integer) As Integer
        AnoBisexto = 29
        If ano Mod 4 = 0 Then
        ElseIf ano Mod 100 <> 0 Then
            AnoBisexto = 28
        End If
    End Function
    Function DataAAAAMMDD(dataTroca As String) As String
        dataTroca = Replace(dataTroca, "/", "")
        dataTroca = Trim(dataTroca)
        If dataTroca <> "" Then

            dataTroca = Replace(dataTroca, "/", "")
            DataAAAAMMDD = Mid(dataTroca, 5, 4) & Mid(dataTroca, 3, 2) & Mid(dataTroca, 1, 2)
        Else
            DataAAAAMMDD = ""
        End If


    End Function
    Function DiasDeTrabalho(data1 As String, data2 As String) As Integer
        Dim mes2, mes1 As String
        Dim ultimoDia As Integer = 30
        Dim dia As Integer = 0
        mes1 = data1.Substring(4, 2)
        mes2 = data2.Substring(4, 2)
        If mes1 = mes2 Then
            dia = Integer.Parse(data2.Substring(6, 2))
            If InStr("01030507081012", mes2) <> 0 Then
                ultimoDia = 31
            ElseIf mes2 = "02" Then
                ultimoDia = 28
            End If
            DiasDeTrabalho = ultimoDia - dia + 1
        Else
            DiasDeTrabalho = 30
        End If


    End Function
    Function TurnoFim(turnoInicio, turnoDuracao) As String
        Dim iHoraInicio, iMinutoInicio, iDuracaoHora, iDuracaoMinuto As Integer
        Dim sHora, sMinuto As String

        iHoraInicio = Int(Mid(turnoInicio, 1, 2))
        iMinutoInicio = Int(Mid(turnoInicio, 4, 2))
        iDuracaoHora = Int(Mid(turnoDuracao, 1, 2))
        iDuracaoMinuto = Int(Mid(turnoDuracao, 4, 2))
        sHora = Trim(Str((iHoraInicio + iDuracaoHora)))
        If (iMinutoInicio + iDuracaoMinuto) >= 60 Then

            sHora = Trim(Str((iHoraInicio + iDuracaoHora + 1)))
            sMinuto = Trim(Str((iMinutoInicio + iDuracaoMinuto) - 60))
        Else
            sHora = Trim(Str((iHoraInicio + iDuracaoHora)))
            sMinuto = Trim(Str((iMinutoInicio + iDuracaoMinuto)))
            If Len(sHora) < 2 Then
                sHora = "0" & sHora
            End If
            If Len(sMinuto) < 2 Then
                sMinuto = "0" & sMinuto
            End If
        End If
        If Len(sHora) < 2 Then
            sHora = "0" & sHora
        End If
        If Len(sMinuto) < 2 Then
            sMinuto = "0" & sMinuto
        End If
        TurnoFim = sHora & ":" & sMinuto
    End Function

    Function HhmmDif(h1 As String, h2 As String) As String

        'Dim h1Hora, h1Minuto, h2Hora, h2Minuto As Integer
        Dim hora, minuto, saldoHoraChegou, saldoMinutoChegou, saldoTempoChegou As Integer
        Dim trabalhadoHora, trabalhadoMinuto, trabalhado As Integer
        Dim resultadoMinutos As Integer = 0
        'Dim k As String
        Dim sinal As Integer
        Dim sinalretorno As Integer = 1

        sinal = IIf(h2.Substring(0, 1) = "+", 1, -1)
        If sinal < 0 Then
            sinalretorno = -1
        End If

        'If h2 < h1 Then

        '    k = h1
        '    h1 = h2
        '    h2 = k

        'End If

        saldoHoraChegou = Int(h2.Substring(2, 2))
        saldoMinutoChegou = Int(h2.Substring(5, 2))
        saldoTempoChegou = (saldoHoraChegou * 60) + saldoMinutoChegou

        trabalhadoHora = Int(h1.Substring(0, 2))
        trabalhadoMinuto = Int(h1.Substring(3, 2))
        trabalhado = (trabalhadoHora * 60) + trabalhadoMinuto

        If sinal = 1 Then

            resultadoMinutos = saldoTempoChegou - trabalhado

        Else

            resultadoMinutos = saldoTempoChegou + trabalhado

        End If

        If resultadoMinutos < 0 Then

            resultadoMinutos = -resultadoMinutos

            sinalretorno = -1

        End If
        hora = Int(resultadoMinutos / 60)
        minuto = resultadoMinutos - (hora * 60)

        'h1Hora = h1.Substring(0, 2)
        'h1Minuto = h1.Substring(3, 2)

        'h2Hora = h2.Substring(0, 2)
        'h2Minuto = h2.Substring(3, 2)



        'If h2Minuto < h1Minuto Then

        '    h2Hora = h2Hora - 1
        '    h2Minuto = h2Minuto + 60

        'End If

        'hora = (h2Hora - h1Hora)
        'minuto = (h2Minuto - h1Minuto)

        HhmmDif = CStr(hora).PadLeft(2, "0") & ":" & CStr(minuto).PadLeft(2, "0")

        If sinalretorno < 0 Then
            HhmmDif = "- " & HhmmDif
        Else
            HhmmDif = "+ " & HhmmDif
        End If


    End Function
    Function HhmmSoma(h1 As String, h2 As String, s1 As Integer, s2 As Integer) As String

        's1 = 1 se h1 For positivo se negativo s1 = -1
        's2 = 1 se h2 For positivo se negativo s2 = -1

        ' h1 __:__
        ' h2 __:__
        ' s1 = 1 ou -1
        ' s2 = 1 ou -1
        If h1.Substring(0, 1) = "-" Then
            s1 = -1
            h1 = h1.Substring(1)
        Else
            s1 = 1
        End If

        If h2.Substring(0, 1) = "-" Then
            s2 = -1
            h2 = h2.Substring(1)
        Else
            s2 = 1
        End If

        Dim p1, p2, k1, k2, hora, minuto As Integer
        Dim horaIncremento, minutoNovo As Integer
        Dim sHora, sMinuto, sinal As String
        Dim k As Integer

        sHora = ""
        sMinuto = ""
        sinal = ""

        p1 = Int(h1.Substring(0, 2)) '* s1
        p2 = Int(h1.Substring(3, 2)) ' * s1
        k1 = Int(h2.Substring(0, 2)) '* s2
        k2 = Int(h2.Substring(3)) '* s2
        If s1 * s2 < 0 Then
            If p1 < k1 Then
                If s2 < 0 Then
                    sinal = "-"
                End If
                k = p1
                p1 = k1
                k1 = k
                k = p2
                p2 = k2
                k2 = k
            ElseIf p2 < k2 And p1 = k1 Then
                If s2 < 0 Then
                    sinal = "-"
                End If
                k = p1
                p1 = k1
                k1 = k
                k = p2
                p2 = k2
                k2 = k
            Else
                If s1 < 0 Then
                    sinal = "-"
                End If
            End If
            If p1 > k1 Then
                If p2 < k2 Then
                    p1 -= 1
                    p2 += 60
                End If
            End If
            hora = p1 - k1
            minuto = p2 - k2
        Else
            If s1 < 0 Then
                sinal = "-"
            End If
            hora = p1 + k1
            minuto = p2 + k2
        End If
        If minuto >= 60 Then
            horaIncremento = (minuto / 60)
            minutoNovo = minuto - (horaIncremento * 60)
            minuto = minutoNovo
        End If
        hora += horaIncremento
        If hora < 0 Or minuto < 0 Then

            hora = Math.Abs(hora)
            minuto = Math.Abs(minuto)

        End If

        sHora = hora.ToString
        sMinuto = minuto.ToString

        HhmmSoma = sinal & sHora.PadLeft(2, "0") & ":" & sMinuto.PadLeft(2, "0")

    End Function
    Function HhmmFormat(h1 As String) As String
        Dim p1, p2 As String
        Dim sinal As String = ""
        If h1.Substring(0, 1) = "-" Then
            sinal = "-"
            h1 = h1.Substring(1)
        End If
        p1 = Replace(Left(h1, 2), ":", "")
        p2 = Replace(Right(h1, 2), ":", "")
        HhmmFormat = sinal & p1.PadLeft(2, "0") & ":" & p2.PadLeft(2, "0")

    End Function
    Function DataLatina(DataTroca As String) As String

        DataTroca = Trim(Replace(DataTroca, "/", ""))
        If DataTroca = "" Then
            DataLatina = ""
        Else
            DataLatina = DataTroca.Substring(6, 2) & "/" & DataTroca.Substring(4, 2) & "/" & DataTroca.Substring(0, 4)
        End If

    End Function

    Function BhSaldoHoras(chave As String, tempo As String) As String

        Dim data As String = DataAAAAMMDD(tempo)
        Dim DataAnterior As String = ""
        Dim Saldo As String = ""
        Dim DiaAnterior As Integer = 0
        Dim DAnterior As String
        Dim DiasAnterioresSaldo As String = ""
        Dim DataInicio As String = ""
        Dim anoMesAnterior As String
        Dim ano, mes As Integer
        Dim sAno As String = ""
        Dim sMes As String = ""
        Dim acTempo As String = "00:00"
        Dim anoMesAnteriorSaldo As String = "00:00"

        ano = Int(data.Substring(0, 4))
        mes = Int(data.Substring(4, 2))

        If mes = 1 Then
            ano -= 1
            mes = 12
        Else
            mes -= 1
        End If

        If mes < 10 Then
            sMes = "0" & mes
        Else
            sMes = Str(mes)
        End If

        sAno = Convert.ToString(ano)
        anoMesAnterior = sAno & sMes

        '' Busca do saldo em "HH:MM" do mes anterior
        If OpenDB() Then

            Dim Query As String = "select count(*) as qto,tempo  from bhSaldo where anoMes = '" & anoMesAnterior & "' and chave = " & chave
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                If DTReader.GetString(0) = 1 Then
                    anoMesAnteriorSaldo = DTReader.GetString(1)
                End If

            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            Conn.Close()
        End If

        '============================================


        DiaAnterior = Int(data.Substring(6, 2))

        If DiaAnterior = "1" Then
            DiasAnterioresSaldo = "00.00"
        Else
            DiaAnterior -= 1
            If DiaAnterior < 10 Then
                DAnterior = data.Substring(0, 6) & "0" & DiaAnterior
            Else
                DAnterior = data.Substring(0, 6) & DiaAnterior
            End If

            DataInicio = data.Substring(0, 6) & "01"


            If OpenDB() Then

                Dim Query As String = "Call folhaPonto(" & chave & ",'" & DataInicio & "','" & DAnterior & "')"
                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader
                Try
                    DTReader = CMD.ExecuteReader
                    While DTReader.Read
                        'DTReader.Read()
                        acTempo = HhmmSoma(acTempo, DTReader.GetString(8), 1, 1)


                    End While

                Catch ex As Exception
                    MsgBox("Problemas Na Leitura!")
                End Try

                Conn.Close()
            End If
        End If

        BhSaldoHoras = HhmmSoma(acTempo, anoMesAnteriorSaldo, 1, 1)

    End Function

    Function dataSoma(data As String, dia As Integer) As String
        Dim dataCalculada As String = ""
        Dim dataPesquisa As String = ""
        dataPesquisa = DataAAAAMMDD(data)
        dataPesquisa = dataPesquisa.Substring(0, 4) & "/" & dataPesquisa.Substring(4, 2) & "/" & dataPesquisa.Substring(6, 2)
        If OpenDB() Then

            Dim Query As String = "select date_add('" & dataPesquisa & "', interval " & dia & " day )"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                dataCalculada = DTReader.GetString(0)

            Catch ex As Exception

                MsgBox("Problemas Na Leitura!")
            End Try

            Conn.Close()

            dataCalculada = dataCalculada.Substring(8, 2) & "/" & dataCalculada.Substring(5, 2) & "/" & dataCalculada.Substring(0, 4)
        End If
        dataSoma = dataCalculada
    End Function
    Public Function Func_Ultimo_Dia_Mes(paramDataX As Date) As Date

        Func_Ultimo_Dia_Mes = DateAdd("m", 1, DateSerial(Year(paramDataX), Month(paramDataX), 1))
        Func_Ultimo_Dia_Mes = DateAdd("d", -1, Func_Ultimo_Dia_Mes)

    End Function
    Public Function DomingosDoIntervalo(a1 As Integer, m1 As Integer, d1 As Integer, a2 As Integer, m2 As Integer, d2 As Integer, lvw As Object) As Integer
        Dim date1 As New DateTime(a1, m1, d1)
        Dim date2 As New DateTime(a2, m2, d2)

        Dim day = DayOfWeek.Sunday 'Domingo
        Dim count = 0

        Dim i As DateTime = date1.[Date]
        Dim strDiaDoMes As String = ""

        While i <= date2.[Date]
            strDiaDoMes = i.Day.ToString
            strDiaDoMes = strDiaDoMes.PadLeft(2, "0")
            If i.DayOfWeek = day Then
                count += 1
                lvw.Items.Add(strDiaDoMes)
                lvw.Items(lvw.items.count - 1).subitems.Add("Domingo")
                lvw.Items(lvw.items.count - 1).subitems.Add("Descanso Semanal")
                lvw.Items(lvw.items.count - 1).subitems.Add(DatePart("ww", i))
                lvw.Items(lvw.items.count - 1).subitems.Add("")
                lvw.Items(lvw.items.count - 1).subitems.Add("(S)")

                i = i.AddDays(6.0)

            End If
            i = i.AddDays(1.0)

        End While
        Return count

    End Function

    Public Function Referenciacheck(referencia As String) As Boolean

        Dim booRetorno As Boolean = True
        Dim datData As Date
        Dim strReferencia As String = ""
        strReferencia = Replace(referencia, "/", "")
        If strReferencia = "" Then
            booRetorno = False
        Else
            Try

                datData = DateAdd("d", 1, "01/" & referencia)

            Catch ex As Exception

                booRetorno = False

            End Try

        End If

        Return booRetorno

    End Function

    Function MesNome(mes As Integer) As String

        MesNome = ""

        Select Case mes

            Case 1
                MesNome = "Janeiro"
            Case 2
                MesNome = "Fevereiro"
            Case 3
                MesNome = "Março"
            Case 4
                MesNome = "Abril"
            Case 5
                MesNome = "Maio"
            Case 6
                MesNome = "Junho"
            Case 7
                MesNome = "Julho"
            Case 8
                MesNome = "Agosto"
            Case 9
                MesNome = "Setembro"
            Case 10
                MesNome = "Outubro"
            Case 11
                MesNome = "Novembro"
            Case 12
                MesNome = "Dezembro"

        End Select

        Return MesNome

    End Function

    Public Function SemanaDiaNome(diaNumero As Integer) As String
        Select Case diaNumero
            Case 1
                SemanaDiaNome = "Domingo"
            Case 2
                SemanaDiaNome = "Segunda"
            Case 3
                SemanaDiaNome = "Terça"
            Case 4
                SemanaDiaNome = "Quarta"
            Case 5
                SemanaDiaNome = "Quinta"
            Case 6
                SemanaDiaNome = "Sexta"
            Case 7
                SemanaDiaNome = "Sábado"
            Case Else
                SemanaDiaNome = ""
        End Select

        Return SemanaDiaNome

    End Function

    Public Function TempoEntreDatas(data1 As Date, data2 As Date) As String

        Dim retIntervalo As String = ""
        Dim inAno As Integer = 0
        Dim inMes As Integer = 0
        Dim inDia As Integer = 0
        Dim dtDataParaCalculoDeMeses As Date
        Dim dtDataParaCalculoDeDias As Date
        Dim dtDataParaCalculoDeAnos As Date = data1

        inAno = DateDiff("yyyy", dtDataParaCalculoDeAnos, data2)
        dtDataParaCalculoDeMeses = DateAdd("yyyy", inAno, dtDataParaCalculoDeAnos)

        inMes = DateDiff("m", dtDataParaCalculoDeMeses, data2)

        dtDataParaCalculoDeDias = DateAdd("m", inMes, dtDataParaCalculoDeMeses)

        inDia = Math.Abs(DateDiff("d", dtDataParaCalculoDeDias, data2))

        'MsgBox("Anos:" & inAno & Chr(13) & "Mes(es) : " & inMes & Chr(13) & "Dia(S) : " & inDia)

        If inAno > 0 Then

            If inAno < 2 Then

                retIntervalo += inAno & " Ano "

            Else

                retIntervalo += inAno & " Anos "

            End If

        End If

        If inMes > 0 Then

            If inMes < 2 Then

                retIntervalo += inMes & " Mês "

            Else

                retIntervalo += inMes & " Meses "

            End If

        End If

        If inDia > 0 Then

            If inDia < 2 Then

                retIntervalo += inDia & "Dia "

            Else

                retIntervalo += inDia & "Dias "

            End If

        End If

        If retIntervalo = "" Then

            retIntervalo = "0 Ano  0 Mês  0 Dia"

        End If

        Return retIntervalo

    End Function

    Public Function HoraMinuto_horas(tempo As String) As Decimal
        Dim intPonto As Integer = InStr(tempo, ":")
        Dim strTempo As String = tempo
        Dim intHora As Integer = Val(strTempo.Substring(0, (intPonto - 1)))
        Dim intMinuto As Integer = Val(strTempo.Substring(intPonto))
        Dim decTempo = intHora + (intMinuto / 60)

        Return decTempo
    End Function
    Public Function AchaMes(mes As String)
        Dim strReferencia As String = mes

        Select Case strReferencia
            Case "janeiro"
                strReferencia = "01"
            Case "fevereiro"
                strReferencia = "02"
            Case "março"
                strReferencia = "03"
            Case "abril"
                strReferencia = "04"
            Case "maio"
                strReferencia = "05"
            Case "junho"
                strReferencia = "06"
            Case "julho"
                strReferencia = "07"
            Case "agôsto"
                strReferencia = "08"
            Case "setembro"
                strReferencia = "09"
            Case "outubro"
                strReferencia = "10"
            Case "novembro"
                strReferencia = "11"
            Case "dezembro"
                strReferencia = "12"

        End Select

        Return strReferencia

    End Function

    Public Function DataRetiraMascara(dataLatina As String) As String

        DataRetiraMascara = Trim(Replace(dataLatina, "/", ""))

    End Function

End Module
