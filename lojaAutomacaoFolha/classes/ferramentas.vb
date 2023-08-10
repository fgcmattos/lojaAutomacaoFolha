Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Sockets
Imports System.Text

Module Module1

    Private Oi As New MsgShow
    Function CPFdigito(nCPF As String) As Boolean

        If nCPF.Length < 9 Then CPFdigito = False : Exit Function
        Dim matCPF(11) As Integer
        Dim k, resultado1, resultado2 As Integer
        Dim digito As String

        CPFdigito = False

        k = 0
        resultado1 = 0
        resultado2 = 0


        For i = 1 To 9

            matCPF(i) = Mid(nCPF, i, 1)
            k = k + matCPF(i) * (11 - i)

        Next

        resultado1 = Int((k / 11))
        resultado1 = k - (resultado1 * 11)
        If resultado1 < 2 Then

            resultado1 = 0

        Else

            resultado1 = 11 - resultado1

        End If

        matCPF(10) = resultado1
        resultado2 = 0

        k = 0
        For i = 1 To 10

            k = k + matCPF(i) * (12 - i)

        Next

        resultado2 = Int((k / 11))

        resultado2 = k - (resultado2 * 11)

        If resultado2 < 2 Then

            resultado2 = 0

        Else

            resultado2 = 11 - resultado2

        End If

        digito = Trim(Str(resultado1)) + Trim(Str(resultado2))

        If digito = Mid(nCPF, 10, 2) Then

            CPFdigito = True

        End If


    End Function
    Function form2Limpa() As Boolean
        form2Limpa = False    ' Argumento fantasma

        'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorCPF.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorNome.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorNascimento.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorIdade.Text() = ""

        'If fmrColaboradorManutencao.CheckBoxLimpaFiliacao.Checked Then fmrColaboradorManutencao.colaboradorMae.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaFiliacao.Checked Then fmrColaboradorManutencao.colaboradorPai.Text() = ""

        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRG.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRGuf.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRGemissor.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRGemissao.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPS.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSuf.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSemissor.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSemissao.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSserie.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNH.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHSuf.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHemissor.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHemissao.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorPIS.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorTitulo.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorTituloZona.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorTituloSecao.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorASO.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHvalidade.Text() = ""

        'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorEstadoCivil.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorSexo.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorNomeCracha.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorCompanheiroCPF.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorCompanheiroNome.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorCompanheiroNascimento.Text() = ""

        'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorResidencia.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorResidenciaUF.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorResidenciaCEP.Text() = ""

        'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorCelular1.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorCelular2.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorFixo.Text() = ""
        'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorEmail.Text() = ""

        'fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked = False
        'fmrColaboradorManutencao.CheckBoxLimpaFiliacao.Checked = False
        'fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked = False
        'fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked = False
        'fmrColaboradorManutencao.CheckBoxLimpaEndereco.Checked = False
        'fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked = False

        form2Limpa = True ' Returno fantasma
    End Function
    Function calculoDaIdade(ano As String, mes As String, dia As String, anoNow As String, mesNow As String, diaNow As String) As String
        Dim voltaAno, voltaMes, voltaDia As Integer
        Dim mesAnterior As String
        Dim lanos, lmes, ldias, frase As String
        lanos = "ano"
        lmes = ""
        ldias = ""
        frase = ""
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
                voltaDia = voltaDia + anoBisexto(ano)
            ElseIf InStrRev("01/03/05/07/08/10/12", mesAnterior, -1) <> 0 Then
                voltaDia = voltaDia + 31
            Else
                voltaDia = voltaDia + 30
            End If

        End If

        ano = voltaAno - CInt(ano)
        mes = voltaMes - CInt(mes)
        dia = voltaDia - CInt(dia)

        If ano > 1 Then lanos = " anos " Else lanos = " ano "
        If mes > 1 Then lmes = " meses " Else lmes = " mes "
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
        calculoDaIdade = frase
    End Function

    Function idade(idata As String) As String
        Dim ano, mes, dia, anoNow, mesNow, diaNow As String
        Dim dataNow As String

        dataNow = Mid(Now, 1, 10)
        anoNow = Mid(dataNow, 7, 4)
        mesNow = Mid(dataNow, 4, 2)
        diaNow = Mid(dataNow, 1, 2)

        idata = Trim(Replace(idata, "/", ""))

        If Len(idata) < 8 Or idata = "" Then
            idade = "200 - Data inválida "
        Else
            ano = Mid(idata, 5, 4)
            mes = Mid(idata, 3, 2)
            dia = Mid(idata, 1, 2)
            If ano > anoNow Then
                idade = "201"
            ElseIf mes > 12 Then
                idade = "202 - Mês inválido"
            ElseIf dia > 31 Then
                idade = "203 - Dia inválido"
            ElseIf dia = 31 And InStrRev("02/04/06/09/11", mes, -1) <> 0 Then
                idade = "204 - Dia inválido"
            ElseIf dia >= 30 And mes = "02" Then
                idade = "205 - Dia inválido"
            ElseIf dia > anoBisexto(CInt(ano)) And mes = "02" Then
                idade = "206 Dias de Fevereiro inválido"
            Else
                idade = calculoDaIdade(ano, mes, dia, anoNow, mesNow, diaNow)
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
    Function anoBisexto(ano As Integer) As Integer
        anoBisexto = 29
        If ano Mod 4 = 0 Then
        ElseIf ano Mod 100 <> 0 Then
            anoBisexto = 28
        End If
    End Function
    Function dataAAAAMMDD(dataTroca As String) As String
        dataTroca = Replace(dataTroca, "/", "")
        dataTroca = Trim(dataTroca)
        If dataTroca <> "" Then

            dataTroca = Replace(dataTroca, "/", "")
            dataAAAAMMDD = Mid(dataTroca, 5, 4) & Mid(dataTroca, 3, 2) & Mid(dataTroca, 1, 2)
        Else
            dataAAAAMMDD = ""
        End If


    End Function
    Function diasDeTrabalho(data1 As String, data2 As String) As Integer
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
            diasDeTrabalho = ultimoDia - dia + 1
        Else
            diasDeTrabalho = 30
        End If


    End Function
    Function turnoFim(turnoInicio, turnoDuracao) As String
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
        turnoFim = sHora & ":" & sMinuto
    End Function
    Function espacoEsquerda(conjunto As String, tamanho As Integer, lado As Integer) As String

        Dim StrConjunto As String
        StrConjunto = IIf(IsNothing(conjunto), "", conjunto)
        If StrConjunto.Length = 0 Then
            espacoEsquerda = Space(tamanho)
            Return espacoEsquerda
            Exit Function
        End If

        Dim comprimento As Integer

        comprimento = tamanho - conjunto.Length

        If comprimento > 0 And lado = 2 Then
            espacoEsquerda = Space(comprimento) & conjunto

        ElseIf comprimento > 0 And lado = 1 Then
            espacoEsquerda = conjunto & Space(comprimento)
        ElseIf comprimento > 0 And lado = 3 Then
            espacoEsquerda = Space(comprimento / 2) & conjunto & Space(comprimento / 2)
        Else
            espacoEsquerda = conjunto
        End If

        Return espacoEsquerda
    End Function
    Function hhmmDif(h1 As String, h2 As String) As String

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

        hhmmDif = CStr(hora).PadLeft(2, "0") & ":" & CStr(minuto).PadLeft(2, "0")

        If sinalretorno < 0 Then
            hhmmDif = "- " & hhmmDif
        Else
            hhmmDif = "+ " & hhmmDif
        End If


    End Function
    Function hhmmSoma(h1 As String, h2 As String, s1 As Integer, s2 As Integer) As String

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

        hhmmSoma = sinal & sHora.PadLeft(2, "0") & ":" & sMinuto.PadLeft(2, "0")
    End Function
    Function hhmmFormat(h1 As String) As String
        Dim p1, p2 As String
        Dim sinal As String = ""
        If h1.Substring(0, 1) = "-" Then
            sinal = "-"
            h1 = h1.Substring(1)
        End If
        p1 = Replace(Left(h1, 2), ":", "")
        p2 = Replace(Right(h1, 2), ":", "")
        hhmmFormat = sinal & p1.PadLeft(2, "0") & ":" & p2.PadLeft(2, "0")

    End Function
    Function dataLatina(dataTroca As String) As String
        dataTroca = Trim(Replace(dataTroca, "/", ""))
        If dataTroca = "" Then
            dataLatina = ""
        Else
            dataLatina = dataTroca.Substring(6, 2) & "/" & dataTroca.Substring(4, 2) & "/" & dataTroca.Substring(0, 4)
        End If

    End Function
    Function formaString(tipo As Integer, palavra As String) As String
        If tipo = 1 Then ' CPF
            formaString = palavra.Substring(0, 3) & "." & palavra.Substring(3, 3) & "." & palavra.Substring(6, 3) & "-" & palavra.Substring(9)
        End If
        If tipo = 3 Then ' CPF
            formaString = palavra.Substring(0, 2) & "." & palavra.Substring(2, 3) & "." & palavra.Substring(5, 3) & "/" & palavra.Substring(8, 4) & "-" & palavra.Substring(12)
        End If
    End Function
    Function bhSaldoHoras(chave As String, tempo As String) As String

        Dim data As String = dataAAAAMMDD(tempo)
        Dim dataAnterior As String = ""
        Dim saldo As String = ""
        Dim diaAnterior As Integer = 0
        Dim dAnterior As String
        Dim diasAnterioresSaldo As String = ""
        Dim dataInicio As String = ""
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


        diaAnterior = Int(data.Substring(6, 2))

        If diaAnterior = "1" Then
            diasAnterioresSaldo = "00.00"
        Else
            diaAnterior -= 1
            If diaAnterior < 10 Then
                dAnterior = data.Substring(0, 6) & "0" & diaAnterior
            Else
                dAnterior = data.Substring(0, 6) & diaAnterior
            End If

            dataInicio = data.Substring(0, 6) & "01"


            If OpenDB() Then

                Dim Query As String = "Call folhaPonto(" & chave & ",'" & dataInicio & "','" & dAnterior & "')"
                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader
                Try
                    DTReader = CMD.ExecuteReader
                    While DTReader.Read
                        'DTReader.Read()
                        acTempo = hhmmSoma(acTempo, DTReader.GetString(8), 1, 1)


                    End While

                Catch ex As Exception
                    MsgBox("Problemas Na Leitura!")
                End Try

                Conn.Close()
            End If
        End If

        bhSaldoHoras = hhmmSoma(acTempo, anoMesAnteriorSaldo, 1, 1)

    End Function
    Function dataSoma(data As String, dia As Integer) As String
        Dim dataCalculada, dataPesquisa As String
        dataPesquisa = dataAAAAMMDD(data)
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

    Public Function CPFretiraMascara(NUMERO As String) As String

        NUMERO = Replace(NUMERO, "_", "")
        NUMERO = Replace(NUMERO, ".", "")
        NUMERO = Replace(NUMERO, "/", "")
        NUMERO = Replace(NUMERO, "-", "")
        NUMERO = Replace(NUMERO, ",", "")
        NUMERO = Replace(NUMERO, " ", "")
        CPFretiraMascara = NUMERO

    End Function
    Public Function CPFcolocaMascara(CPF As String) As String
        If CPF = "" Then
            CPFcolocaMascara = ""
        Else
            CPFcolocaMascara = CPF.Substring(0, 3) & "." & CPF.Substring(3, 3) & "." & CPF.Substring(6, 3) & "-" & CPF.Substring(9, 2)
        End If
    End Function
    Public Function CNPJcolocaMascara(Cnpj As String) As String
        If Cnpj = "" Then
            CNPJcolocaMascara = ""
        Else
            CNPJcolocaMascara = Cnpj.Substring(0, 2) & "." & Cnpj.Substring(2, 3) & "." & Cnpj.Substring(5, 3) & "/" & Cnpj.Substring(8, 4) & "-" & Cnpj.Substring(12, 2)
        End If
    End Function
    Public Function CNPJretiraMascara(Cnpj As String) As String

        Dim strCNPJ As String = Cnpj
        strCNPJ = Trim(Replace(Replace(Replace(Replace(strCNPJ, ".", ""), "-", ""), "/", ""), ",", ""))
        Return strCNPJ

    End Function
    Public Function dataRetiraMascara(dataLatina As String) As String

        dataRetiraMascara = Trim(Replace(dataLatina, "/", ""))

    End Function


    Public Function PIScolocaMascara(pis As String) As String

        Dim strPIS As String = pis

        strPIS = strPIS.Substring(0, 3) & "." & strPIS.Substring(3, 5) & "." & strPIS.Substring(8, 2) & "-" & strPIS.Substring(10)

        Return strPIS

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

            Return booRetorno

        End If
    End Function
    Public Function PIS_digito_verificador(Identificador As String) As Boolean
        Dim booChek As Boolean = True
        Dim strIdentificador As String = Replace(Replace(Replace(Identificador, ".", ""), "-", ""), "_", "")
        If strIdentificador = "" Then Return False : Exit Function
        If strIdentificador.Length <> 11 Then booChek = False : Return booChek : Exit Function

        Dim strigitoRecebido As String = strIdentificador.Substring(10, 1)
        Dim strigitoCalculado As String = ""


        Dim arrPis(11) As Decimal
        Dim vetPeso() As Decimal = {3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
        Dim decSoma As Decimal = 0
        Dim Decresto As Decimal = 0


        For i = 0 To strIdentificador.Length - 2

            Decimal.TryParse((strIdentificador.Substring(i, 1)) * vetPeso(i), arrPis(i))
            decSoma += arrPis(i)

        Next

        Decresto = 11 - (decSoma Mod 11)

        Select Case Decresto
            Case 10, 11
                strigitoCalculado = "0"
            Case Else
                strigitoCalculado = Decresto.ToString
        End Select

        If strigitoCalculado <> strigitoRecebido Then booChek = False

        Return booChek

    End Function
    Public Function ReciboHistoricoCheck(hist As String, variavelLenght As Integer) As Boolean

        ReciboHistoricoCheck = True

        Dim strDigito As String = ""
        Dim intContJanela As Integer = 0
        Dim arrVariavel(100, 1) As String
        Dim inArrVariavel As Integer = 0
        Dim inChekLength As Integer = 0
        Dim strTeste As String = ""
        Dim strErr As String = ""
        Dim intString As Integer = 0


        intString = contaString("#", hist)

        If intString Mod 2 <> 0 Then

            MsgBox("Número de # não pode ser Impar!" & Chr(13) & "Número de # = " & intString)

            ReciboHistoricoCheck = False

            Exit Function

        End If

        For i = 0 To Len(hist) - 1

            strDigito = hist.Substring(i, 1)

            If strDigito = "#" Then

                intContJanela += 1

                inChekLength = 0

                For j = (i + 1) To ((i + 1) + variavelLenght)

                    strDigito = hist.Substring(j, 1)

                    If strDigito <> "#" Then

                        arrVariavel(inArrVariavel, 0) += strDigito

                        inChekLength += 1

                        If inChekLength > variavelLenght Then

                            '''strResultado = "Variavel formada entre # tem mais do que " & variavelLenght & " digitos. Verifique o seu histórico"

                            ReciboHistoricoCheck = False

                            Exit Function

                        End If

                    Else

                        inArrVariavel += 1

                        intContJanela += 1

                        i = j

                        Exit For

                    End If

                Next



            End If
        Next

        'MsgBox("# " & intContJanela & " Variaveis = " & inArrVariavel)


        If OpenDB() Then
            Dim query = " Select * from recibovariaveis "
            Dim DTReader As MySqlDataReader
            Dim CMD As New MySqlCommand(query, Conn)
            Try
                DTReader = CMD.ExecuteReader


                While DTReader.Read()

                    strTeste = DTReader.GetString(1)

                    For k = 0 To inArrVariavel
                        If arrVariavel(k, 0) = strTeste Then
                            arrVariavel(k, 1) = strTeste
                            'Exit For esistem mais de uma variavel igual no historico
                        End If
                    Next

                End While


            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
                Exit Function
            End Try
            Conn.Close()
        End If
        For k = 0 To inArrVariavel

            If arrVariavel(k, 0) <> arrVariavel(k, 1) Then

                strErr += "Variável " & arrVariavel(k, 0) & " Não Existe !" & Chr(13) & Chr(13)

            End If

        Next

        If strErr <> "" Then

            MsgBox(Chr(13) & Chr(13) & strErr, vbCritical, "Erro na definição de variáveis !")

            ReciboHistoricoCheck = False

        End If
    End Function
    Public Function contaString(str As String, frase As String) As Integer

        contaString = 0

        Dim strLetra As String

        For i = 0 To Len(frase) - 1

            strLetra = frase.Substring(i, 1)

            If strLetra = str Then contaString += 1

        Next

    End Function
    Public Function numeroLatino(Numero As Decimal, tamanho As Integer, inibeSinal As Boolean)


        Dim strvolta As String = ""
        Dim strDecimal As String

        Dim strFrase As String
        Dim strfraseLen As Integer
        Dim strSinal As String
        'If InStr(Numero.ToString, ",") = 0 Then strDecimal = ".00"

        If inibeSinal Then strSinal = "" Else strSinal = "(+)"

        If Numero < 0 Then

            Numero = Numero * (-1)

            If Not inibeSinal Then strSinal = "(-)"

        End If
        Dim numeroSemDecimal As Decimal = Int(Numero)

        strDecimal = IIf((Numero - numeroSemDecimal).ToString.Substring(1) = "", ",00", (Numero - numeroSemDecimal).ToString.Substring(1))
        If Len(strDecimal) <= 2 Then strDecimal += "0"

        strFrase = Trim(numeroSemDecimal.ToString)
        strfraseLen = strFrase.Length

        Select Case strfraseLen

            Case 4 To 6
                strvolta = strFrase.Substring(0, strfraseLen - 3) + "." + strFrase.Substring(strfraseLen - 3)
            Case 7 To 8
                strvolta = strFrase.Substring(0, strfraseLen - 6) + "." + strFrase.Substring(strfraseLen - 3) + "." + strFrase.Substring(strfraseLen - 3)
            Case 11
            Case Else
                strvolta = strFrase

        End Select



        strvolta = strvolta + strDecimal + strSinal





        If tamanho > Len(strvolta) Then

            numeroLatino = Space(tamanho - Len(strvolta)) + strvolta

        Else

            numeroLatino = strvolta

        End If

    End Function

    Public Function retMascara(intSemMascara As Integer, strSemMascara As String) As String

        ' Numero maximo 9.999.999.999,99"

        Dim strRetorno As String = ""

        If intSemMascara < 4 Then

            strRetorno = strSemMascara.Substring(0, 1) + "," + strSemMascara.Substring(1)

        ElseIf intSemMascara >= 4 And intSemMascara < 6 Then

            strRetorno = strSemMascara.Substring(0, intSemMascara - 2) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

        ElseIf intSemMascara >= 6 And intSemMascara < 9 Then

            strRetorno = strSemMascara.Substring(0, intSemMascara - 5) + "." + strSemMascara.Substring(intSemMascara - 5, 3) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

        ElseIf intSemMascara >= 9 And intSemMascara < 12 Then

            strRetorno = strSemMascara.Substring(0, intSemMascara - 8) + "." + strSemMascara.Substring(intSemMascara - 8, 3) + "." + strSemMascara.Substring(intSemMascara - 5, 3) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

        ElseIf intSemMascara >= 12 And intSemMascara < 15 Then

            strRetorno = strSemMascara.Substring(0, intSemMascara - 11) + "." + strSemMascara.Substring(intSemMascara - 11, 3) + "." + strSemMascara.Substring(intSemMascara - 8, 3) + "." + strSemMascara.Substring(intSemMascara - 5, 3) + "," + strSemMascara.Substring(intSemMascara - 2, 2)

        End If

        Return strRetorno

    End Function
    Public Function gravaSQL(query As String) As Boolean

        Dim CMD As New MySqlCommand(query, Conn)
        Dim STRretorna As Boolean = True
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

            Catch ex As Exception
                MsgBox(ex.Message)
                STRretorna = False
            End Try

            Conn.Close()

        End If

        Return (STRretorna)

    End Function
    Public Function gravaSQLretorno(query As String) As String

        Dim strRetorno As String = ""

        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        Try
            If OpenDB() Then

                DTReader = CMD.ExecuteReader
                DTReader.Read()
                strRetorno = DTReader.GetValue(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Conn.Close()

        Return (strRetorno)

    End Function
    Public Function folhaFechada(referencia As String) As Boolean
        Dim booRetorno As Boolean = False
        Dim query As String
        query = "Select count(*) from folha_close_cab where fcCol_ref = '" & referencia & "'"
        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                If DTReader.GetValue(0) > 0 Then booRetorno = True
            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            Conn.Close()

            Return (booRetorno)

        End If

    End Function

    Function MesNome(mes As Integer) As String

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
    Public Function ApontaSQL(query As String) As Integer

        ApontaSQL = 0

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(query, Conn)


        If OpenDB() Then

            DTReader = CMD.ExecuteReader
            DTReader.Read()
            ApontaSQL = DTReader(0)

            Conn.Close()

        End If

        Return ApontaSQL

    End Function

    Public Function SQLvetor(query As String) As Object
        'tentativa de passar o vetor do Mysql para o visualn - nao deu certo
        ''Dim DTReader As MySqlDataReader
        ''Dim CMD As New MySqlCommand(query, Conn)
        ''Dim MySqlVetor As Object

        ''If OpenDB() Then

        ''    DTReader = CMD.ExecuteReader
        ''    DTReader.Read()
        ''    MySqlVetor = DTReader.
        ''    Return(MySqlVetor)
        ''    Conn.Close()

        ''End If



    End Function
    Public Function telefoneRetiraMascara(strTelefoneRecebido As String)

        Dim strTelefone As String = strTelefoneRecebido
        strTelefone = Trim(Replace(Replace(Replace(strTelefone, "(", ""), ")", ""), "-", ""))

        If strTelefone = "" Then

            Return strTelefone

        Else

            Return strTelefoneRecebido

        End If

    End Function
    Public Function ApontaElementosSQL(arq As String, camp As String, cond As String, NumStr As Boolean) As Boolean

        ' NumStr parametriza a pesquisa se campo é string ou numerico
        ' numerico true
        ' string false

        Dim query As String

        query = "select count(*) from "
        query += arq
        query += " where "
        query += camp
        If NumStr Then
            query += " = " & cond
        Else
            query += " = '" & cond & "'"
        End If


        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()
                If DTReader.GetValue(0) > 0 Then

                    ApontaElementosSQL = True

                Else

                    ApontaElementosSQL = False

                End If


            Catch ex As Exception

                MsgBox("Problemas Na Pesquisa!")

            End Try

            Conn.Close()

        End If

        Return ApontaElementosSQL

    End Function
    Public Function semanaDiaNome(diaNumero As Integer) As String
        Select Case diaNumero
            Case 1
                semanaDiaNome = "Domingo"
            Case 2
                semanaDiaNome = "Segunda"
            Case 3
                semanaDiaNome = "Terça"
            Case 4
                semanaDiaNome = "Quarta"
            Case 5
                semanaDiaNome = "Quinta"
            Case 6
                semanaDiaNome = "Sexta"
            Case 7
                semanaDiaNome = "Sábado"
            Case Else
                semanaDiaNome = ""
        End Select

        Return semanaDiaNome

    End Function
    Public Function MoneyLatino(money As String) As String
        ' Rotina recebe numero com decimal indicada por .
        ' Numeros ate 999 trilhoes

        If InStr(money, ",") <> 0 Then
            money = Replace(money, ",", ".")
        End If

        Dim strLetra As String = ""

        Dim inDecimal As Integer

        If InStr(money, ".") = 0 Then money += ",00"        ' isso e certo

        inDecimal = money.Length - (InStr(money, ".")) + 1


        money = Replace(money, ".", ",")


        Select Case inDecimal
            Case 1
                money += "00"
            Case 2
                money += "0"

        End Select



        Dim inStrLenght As Integer = money.Length

        Dim strRetorno As String = ""

        Dim strDecimal As String = Microsoft.VisualBasic.Right(money, 3)

        Dim strTruncado As String = money.Substring(0, (money.Length - 3))

        Dim strCento As String = Microsoft.VisualBasic.Right(strTruncado, 3)

        Dim strMilhar As String = ""

        Dim strMilhao As String = ""

        Dim strBilhao As String = ""

        If inStrLenght > 6 Then

            strTruncado = money.Substring(0, (strTruncado.Length - 3))

            strMilhar = Microsoft.VisualBasic.Right(strTruncado, 3)

        End If

        If inStrLenght > 9 Then

            strTruncado = money.Substring(0, (strTruncado.Length - 3))

            strMilhao = Microsoft.VisualBasic.Right(strTruncado, 3)

        End If

        If inStrLenght > 12 Then

            strTruncado = money.Substring(0, (strTruncado.Length - 3))

            strBilhao = Microsoft.VisualBasic.Right(strTruncado, 3)

        End If




        'Dim strMilhao As String = Microsoft.VisualBasic.Right(Strteste, 3)

        strRetorno = strDecimal

        If strCento <> "" Then strRetorno = strCento & strRetorno

        If strMilhar <> "" Then strRetorno = strMilhar & "." & strRetorno

        If strMilhao <> "" Then strRetorno = strMilhao & "." & strRetorno

        If strBilhao <> "" Then strRetorno = strBilhao & "." & strRetorno

        Return strRetorno

    End Function
    Public Function MoneyUSA(money As String) As String

        Dim strMoney As String
        strMoney = Replace(money, ".", "")
        strMoney = Replace(strMoney, ",", ".")
        Return strMoney

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

    Public Function ColaboradorSelectAll()


        Dim Query As String = ""

        Query = "idcolaborador"
        Query += ",chave"
        Query += ",if(isnull(colaboradorCPF),"",colaboradorCPF)"
        Query += ",if(isnull(colaboradorNome),"",colaboradorNome)"
        Query += ",if(isnull(colaboradorNascimento),"",colaboradorNascimento)"
        Query += ",if(isnull(colaboradorRG),"",colaboradorRG)"
        Query += ",if(isnull(colaboradorRGoe),"",colaboradorRGoe)"
        Query += ",if(isnull(colaboradorRGuf),"",colaboradorRGuf)"
        Query += ",if(isnull(colaboradorRGemissao),"",colaboradorRGemissao)"
        Query += ",if(isnull(colaboradorRGvalidade),"",colaboradorRGvalidade)"
        Query += ",if(isnull(colaboradorCTPS),"",colaboradorCTPS)"
        Query += ",if(isnull(colaboradorCTPSoe),"",colaboradorCTPSoe)"
        Query += ",if(isnull(colaboradorCTPSuf),"",colaboradorCTPSuf)"
        Query += ",if(isnull(colaboradorCTPSerie),"",colaboradorCTPSerie)"
        Query += ",if(isnull(colaboradorCTPSemissao),"",colaboradorCTPSemissao)"
        Query += ",if(isnull(colaboradorCTPSvalidade),"",colaboradorCTPSvalidade)"
        Query += ",if(isnull(colaboradorCNH),"",colaboradorCNH)"
        Query += ",if(isnull(colaboradorCNHoe),"",colaboradorCNHoe)"
        Query += ",if(isnull(colaboradorCNHuf),"",colaboradorCNHuf)"
        Query += ",if(isnull(colaboradorCNHemissao),"",colaboradorCNHemissao)"
        Query += ",if(isnull(colaboradorCNHvalidade),"",colaboradorCNHvalidade)"
        Query += ",if(isnull(colaboradorCNH1habilitacao),"",colaboradorCNH1habilitacao)"
        Query += ",if(isnull(colaboradorPIS),"",colaboradorPIS)"
        Query += ",if(isnull(colaboradorPISoe),"",colaboradorPISoe)"
        Query += ",if(isnull(colaboradorPISoeUF),"",colaboradorPISoeUF)"
        Query += ",if(isnull(colaboradorPISemissao),"",colaboradorPISemissao)"
        Query += ",if(isnull(colaboradorPISvalidade),"",colaboradorPISvalidade)"
        Query += ",if(isnull(colaboradorReservista),"",colaboradorReservista)"
        Query += ",if(isnull(colaboradorReservistaOE),"",colaboradorReservistaOE)"
        Query += ",if(isnull(colaboradorReservistaOEuf),"",colaboradorReservistaOEuf)"
        Query += ",if(isnull(colaboradorReservistaEmissao),"",colaboradorReservistaEmissao)"
        Query += ",if(isnull(colaboradorReservistaValidade),"",colaboradorReservistaValidade)"
        Query += ",if(isnull(colaboradorTituloNumero),"",colaboradorTituloNumero)"
        Query += ",if(isnull(colaboradorTituloOE),"",colaboradorTituloOE)"
        Query += ",if(isnull(colaboradorTituloOEuf),"",colaboradorTituloOEuf)"
        Query += ",if(isnull(colaboradorTituloZona),"",colaboradorTituloZona)"
        Query += ",if(isnull(colaboradorTituloSecao),"",colaboradorTituloSecao)"
        Query += ",if(isnull(colaboradorTituloEmissao),"",colaboradorTituloEmissao)"
        Query += ",if(isnull(colaboradorTituloValidade),"",colaboradorTituloValidade)"
        Query += ",if(isnull(colaboradorMae),"",colaboradorMae)"
        Query += ",if(isnull(colaboradorMaeCPF),"",colaboradorMaeCPF)"
        Query += ",if(isnull(colaboradorMaeNascimento),"",colaboradorMaeNascimento)"
        Query += ",if(isnull(colaboradorMaeFone),"",colaboradorMaeFone)"
        Query += ",if(isnull(colaboradorPai),"",colaboradorPai)"
        Query += ",if(isnull(colaboradorPaiCPF),"",colaboradorPaiCPF)"
        Query += ",if(isnull(colaboradorPaiNascimento),"",colaboradorPaiNascimento)"
        Query += ",if(isnull(colaboradorPaiFone),"",colaboradorPaiFone)"
        Query += ",if(isnull(colaboradorEstadoCivil),"",colaboradorEstadoCivil)"
        Query += ",if(isnull(colaboradorUniaoEstavel),"",colaboradorUniaoEstavel)"
        Query += ",if(isnull(colaboradorSexo),"",colaboradorSexo)"
        Query += ",if(isnull(colaboradorEsposolNome),"",colaboradorEsposolNome)"
        Query += ",if(isnull(colaboradorEsposoCPF),"",colaboradorEsposoCPF)"
        Query += ",if(isnull(colaboradorEsposoNascimento),"",colaboradorEsposoNascimento)"
        Query += ",if(isnull(colaboradorEsposoFone),"",colaboradorEsposoFone)"
        Query += ",if(isnull(colaboradorCompanheiroNome),"",colaboradorCompanheiroNome)"
        Query += ",if(isnull(colaboradorCompanheiroCPF),"",colaboradorCompanheiroCPF)"
        Query += ",if(isnull(colaboradorCompanheiroNascimento),"",colaboradorCompanheiroNascimento)"
        Query += ",if(isnull(colaboradorCompanheiroFone),"",colaboradorCompanheiroFone)"
        Query += ",if(isnull(colaboradorResidencia),"",colaboradorResidencia)"
        Query += ",if(isnull(colaboradorResidenciaCidade),"",colaboradorResidenciaCidade)"
        Query += ",if(isnull(colaboradorResidenciaUF),"",colaboradorResidenciaUF)"
        Query += ",if(isnull(colaboradorResidenciaCEP),"",colaboradorResidenciaCEP)"
        Query += ",if(isnull(colaboradorFone1),"",colaboradorFone1)"
        Query += ",if(isnull(colaboradorFone2),"",colaboradorFone2)"
        Query += ",if(isnull(colaboradorEmail),"",colaboradorEmail)"
        Query += ",if(isnull(colaboradorAutorizaEmail),"",colaboradorAutorizaEmail)"
        Query += ",if(isnull(colaboradorInstrucao),"",colaboradorInstrucao)"
        Query += ",if(isnull(colaboradorCurso),"",colaboradorCurso)"
        Query += ",if(isnull(colaboradorConselhoRegional),"",colaboradorConselhoRegional)"
        Query += ",if(isnull(colaboradorConselhoRegionalNumero),"",colaboradorConselhoRegionalNumero)"
        Query += ",if(isnull(colaboradorConselhoRegionalData),"",colaboradorConselhoRegionalData)"
        Query += ",if(isnull(colaboradorConselhoRegionalOE),"",colaboradorConselhoRegionalOE)"
        Query += ",if(isnull(colaboradorBanco),"",colaboradorBanco)"
        Query += ",if(isnull(colaboradorAgencia),"",colaboradorAgencia)"
        Query += ",if(isnull(colaboradorContaCorrente),"",colaboradorContaCorrente)"
        Query += ",if(isnull(colaboradorContaCorrenteDigito),"",colaboradorContaCorrenteDigito)"
        Query += ",if(isnull(colaboradorDependente1Parentesco),"",colaboradorDependente1Parentesco)"
        Query += ",if(isnull(colaboradorDependente1Nome),"",colaboradorDependente1Nome)"
        Query += ",if(isnull(colaboradorDependente1CPF),"",colaboradorDependente1CPF)"
        Query += ",if(isnull(colaboradorDependente1Nascimento),"",colaboradorDependente1Nascimento)"
        Query += ",if(isnull(colaboradorDependente2Parentesco),"",colaboradorDependente2Parentesco)"
        Query += ",if(isnull(colaboradorDependente2Nome),"",colaboradorDependente2Nome)"
        Query += ",if(isnull(colaboradorDependente2CPF),"",colaboradorDependente2CPF)"
        Query += ",if(isnull(colaboradorDependente2Nascimento),"",colaboradorDependente2Nascimento)"
        Query += ",if(isnull(colaboradorDependente3Parentesco),"",colaboradorDependente3Parentesco)"
        Query += ",if(isnull(colaboradorDependente3Nome),"",colaboradorDependente3Nome)"
        Query += ",if(isnull(colaboradorDependente3CPF),"",colaboradorDependente3CPF)"
        Query += ",if(isnull(colaboradorDependente3Nascimento),"",colaboradorDependente3Nascimento)"
        Query += ",if(isnull(colaboradorDependente4Parentesco),"",colaboradorDependente4Parentesco)"
        Query += ",if(isnull(colaboradorDependente4Nome),"",colaboradorDependente4Nome)"
        Query += ",if(isnull(colaboradorDependente4CPF),"",colaboradorDependente4CPF)"
        Query += ",if(isnull(colaboradorDependente4Nascimento),"",colaboradorDependente4Nascimento)"
        Query += ",if(isnull(colaboradorDependente5Parentesco),"",colaboradorDependente5Parentesco)"
        Query += ",if(isnull(colaboradorDependente5Nome),"",colaboradorDependente5Nome)"
        Query += ",if(isnull(colaboradorDependente5CPF),"",colaboradorDependente5CPF)"
        Query += ",if(isnull(colaboradorDependente5Nascimento),"",colaboradorDependente5Nascimento)"
        Query += ",if(isnull(colaboradorDependente6Parentesco),"",colaboradorDependente6Parentesco)"
        Query += ",if(isnull(colaboradorDependente6Nome),"",colaboradorDependente6Nome)"
        Query += ",if(isnull(colaboradorDependente6CPF),"",colaboradorDependente6CPF)"
        Query += ",if(isnull(colaboradorDependente6Nascimento),"",colaboradorDependente6Nascimento)"
        Query += ",if(isnull(colaboradorAltura),"",colaboradorAltura)"
        Query += ",if(isnull(colaboradorPeso),"",colaboradorPeso)"
        Query += ",if(isnull(colaboradorCabelo),"",colaboradorCabelo)"
        Query += ",if(isnull(colaboradorOlhos),"",colaboradorOlhos)"
        Query += ",if(isnull(colaboradorTipoDeSangues),"",colaboradorTipoDeSangues)"
        Query += ",if(isnull(colaboradorCor),"",colaboradorCor)"
        Query += ",if(isnull(colaboradorDeficiente),"",colaboradorDeficiente)"
        Query += ",if(isnull(colaboradorDeficienteTipo),"",colaboradorDeficienteTipo)"
        Query += ",if(isnull(colaboradorDeficienteOutros),"",colaboradorDeficienteOutros)"
        Query += ",if(isnull(colaboradorContatoNome1),"",colaboradorContatoNome1)"
        Query += ",if(isnull(colaboradorContatoNome1Telefone),"",colaboradorContatoNome1Telefone)"
        Query += ",if(isnull(colaboradorContatoNome1Conhecimento),"",colaboradorContatoNome1Conhecimento)"
        Query += ",if(isnull(colaboradorContatoNome2),"",colaboradorContatoNome2)"
        Query += ",if(isnull(colaboradorContatoNome2telefone),"",colaboradorContatoNome2telefone)"
        Query += ",if(isnull(colaboradorContatoNome2Conhecimento),"",colaboradorContatoNome2Conhecimento)"
        Query += ",if(isnull(colaboradorEmpresaNome1),"",colaboradorEmpresaNome1)"
        Query += ",if(isnull(colaboradorEmpresaNome1Contato),"",colaboradorEmpresaNome1Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome1Telefone),"",colaboradorEmpresaNome1Telefone)"
        Query += ",if(isnull(colaboradorEmpresaNome2),"",colaboradorEmpresaNome2)"
        Query += ",if(isnull(colaboradorEmpresaNome2Contato),"",colaboradorEmpresaNome2Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome2Telefone),"",colaboradorEmpresaNome2Telefone)"
        Query += ",if(isnull(colaboradorFuncao),"",colaboradorFuncao)"
        Query += ",if(isnull(colaboradorNomeCracha),"",colaboradorNomeCracha)"
        Query += ",if(isnull(colaboradorASOadmissao),"",colaboradorASOadmissao)"
        Query += ",if(isnull(colaboradorAdmissao),"",colaboradorAdmissao)"
        Query += ",if(isnull(colaboradorAdmissaoReferencia),"",colaboradorAdmissaoReferencia)"
        Query += ",if(isnull(colaboradorCadastroDataHora),"",colaboradorCadastroDataHora)"
        Query += ",if(isnull(colaboradorUsuarioCadastroResponsavel),"",colaboradorUsuarioCadastroResponsavel)"
        Query += ",if(isnull(colaboradorStatus),"",colaboradorStatus)"
        Query += ",if(isnull(colaboradorPIX),"",colaboradorPIX)"
        Query += ",if(isnull(colaboradorSalarioAtual),"",colaboradorSalarioAtual)"
        Query += ",if(isnull(colaboradorDependentesIR),"",colaboradorDependentesIR)"
        Query += ",if(isnull(colaboradorHorasTrabalhadasSemana),"",colaboradorHorasTrabalhadasSemana)"
        Query += ",if(isnull(colaboradorDiasDescansoSemana),"",colaboradorDiasDescansoSemana)"
        Query += ",if(isnull(colaboradorResidenciaBairro),"",colaboradorResidenciaBairro)"
        Query += ",if(isnull(colaboradorRescisaoData),"",colaboradorRescisaoData)"
        Query += ",if(isnull(colaboradorASOrescisao),"",colaboradorASOrescisao)"
        Query += ",if(isnull(colaboradorDependenteIR),"",colaboradorDependenteIR)"
        Query += ",if(isnull(colaboradorDependenteSF),"",colaboradorDependenteSF)"
        Query += ",if(isnull(colaboradorCBO),"",colaboradorCBO)"
        Query += ",if(isnull(colaboradorSetor),"",colaboradorSetor)"
        Query += ",if(isnull(colaboradorDependente1IR),"",colaboradorDependente1IR)"
        Query += ",if(isnull(colaboradorDependente1SF),"",colaboradorDependente1SF)"
        Query += ",if(isnull(colaboradorDependente2IR),"",colaboradorDependente2IR)"
        Query += ",if(isnull(colaboradorDependente2SF),"",colaboradorDependente2SF)"
        Query += ",if(isnull(colaboradorDependente3IR),"",colaboradorDependente3IR)"
        Query += ",if(isnull(colaboradorDependente3SL),"",colaboradorDependente3SL)"
        Query += ",if(isnull(colaboradorDependente4IR),"",colaboradorDependente4IR)"
        Query += ",if(isnull(colaboradorDependente4SF),"",colaboradorDependente4SF)"
        Query += ",if(isnull(colaboradorDependente5IR),"",colaboradorDependente5IR)"
        Query += ",if(isnull(colaboradorDependente5SF),"",colaboradorDependente5SF)"
        Query += ",if(isnull(colaboradorDependente6IR),"",colaboradorDependente6IR)"
        Query += ",if(isnull(colaboradorDependente6SF),"",colaboradorDependente6SF)"

        Return Query

    End Function
    Public Function StrQTO(strString As String, strChar As String) As Integer

        ' Contar o numero de caracter dentro de uma string

        Dim intContador As Integer = 0

        For i = 0 To strString.Length - 1

            If strString.Substring(i, 1) = strChar Then intContador += 1

        Next

        Return intContador

    End Function

    Public Function ComboCarregar(Combo As Object, strTabela As String, frase As String, condicao As String)

        Combo.items.clear()
        Dim Query As String = ""
        Query += " select "
        Query += frase                              ' "concat(e_Social_tab1_codigo,' - ' , e_Social_tab1_descricao)"
        Query += " from " & strTabela

        If condicao <> "" Then Query += " " & condicao

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    Combo.items.add(DTReader.GetValue(0))

                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conn.Close()

        End If

    End Function
    Public Function HoraMinuto_horas(tempo As String) As Decimal
        Dim intPonto As Integer = InStr(tempo, ":")
        Dim strTempo As String = tempo
        Dim intHora As Integer = Val(strTempo.Substring(0, (intPonto - 1)))
        Dim intMinuto As Integer = Val(strTempo.Substring(intPonto))
        Dim decTempo = intHora + (intMinuto / 60)

        Return decTempo
    End Function
    Public Function achaMes(mes As String)
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

    ' Funcoes do holerite
    Public Function ColaboradorCarrega(hol As Object, chave As Integer, referencia As String, ref_mes_ano As String)

        Dim intKeyCol As Integer = chave

        Dim strReferencia As String = referencia

        Dim Query As String

        Query = "select chave,colaboradornome,colaboradorSalarioatual,colaboradorStatus"
        Query += ",colaboradorDependentesIR,colaboradorHorasTrabalhadasSemana,colaboradorDiasDescansoSemana"
        Query += ",colaboradorAdmissao,colaboradorAdmissaoReferencia "
        Query += "From colaborador "
        Query += "Where "
        Query += "colaboradorstatus = 100 "                     ' Colaboradores aptos a receber o salario
        Query += "and chave = " & intKeyCol

        If OpenDB() Then


            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                With hol
                    .Key = Int(DTReader.GetString(0))
                    .ColNome = DTReader.GetString(1)
                    .Referencia_mes_ano = strReferencia                'AAAAMM
                    .Referencia_mes_ano_tela = ref_mes_ano      'MM/AAAA
                    .SB = DTReader.GetString(2)
                    .ColIRdependentes = DTReader.GetString(4)
                    .HorasTrabalhadasSemana = DTReader.GetString(5)
                    .diasDeDescansoSemanal = DTReader.GetString(6)
                    .AdmissaoData = DTReader.GetString(7)
                    .AdmissaoReferencia = DTReader.GetString(8)
                    .INSSpercentualTotal = 0.2
                End With
            Catch ex As Exception
                MsgBox("Problemas na pesquisa!")
            End Try

            Conn.Close()
        End If

    End Function
    Public Function ParametrosDaReferenciaCarrega(referencia As String, hol As Object) ' Parametros para calculo da Referencia AAAAMM

        Dim strReferencia As String = referencia

        Dim Query As String

        Query = "select  "
        Query += "DUCabDiasDescanso "
        Query += ",DUCabDiasCorrido "
        Query += ",DUCabDomingos "
        Query += ",DUCabFeriados "
        Query += ",DUCabNumSemanaInicial "
        Query += ",DUCabNumSemanaFinal "
        Query += ",DUCabDiasUteis "
        Query += "From diasuteiscab  "
        Query += "Where "
        Query += "DUCabAnoMes = '" & strReferencia & "'"

        If OpenDB() Then


            Dim CMD1 As New MySqlCommand(Query, Conn)
            Dim DTReader1 As MySqlDataReader

            Try
                DTReader1 = CMD1.ExecuteReader
                DTReader1.Read()
                With hol
                    .PPC_descansos_totais_do_mes = DTReader1(0)
                    .PPC_dias_corridos_do_mes = DTReader1(1)
                    .PPC_domingos_do_mes = DTReader1(2)
                    .PPC_feriados_do_mes = DTReader1(3)
                    .PPC_semana_inicial_do_mes = DTReader1(4)
                    .PPC_semana_final_do_mes = DTReader1(5)
                    .PPC_dias_uteis_ref = DTReader1(6)
                    'hol.hora_propporcional_ref_valor = ((hol.SB / .PPC_dias_uteis_ref) / hol.HorasTrabalhadasDia)

                End With
            Catch ex As Exception
                MsgBox("Problemas na função ParametrosDaReferenciaCarrega! PPC ")
            End Try

            Conn.Close()
        End If
    End Function
    Public Function ParametrosBasicosCalculo(strReferencia As String, hol As Object)

        ' Calculo do Salario Base Befetivo   SBefetivo
        If strReferencia = hol.AdmissaoReferencia Then

            ' DTmes DIas Trabalhados No Mes
            hol.DTmes = (hol.PPC_dias_corridos_do_mes - Int(hol.AdmissaoData.Substring(6, 2))) + 1

            hol.SBEfetivo = Int(((hol.SB * hol.DTmes) / hol.PPC_dias_corridos_do_mes) * 100) / 100

        Else

            hol.DTmes = hol.PPC_dias_corridos_do_mes
            hol.SBEfetivo = hol.SB

        End If


        With hol

            .HorasTrabalhadasDia = Int(((.HorasTrabalhadasSemana) / (7 - .diasDeDescansoSemanal)) * 100) / 100
            .horasTrabalhadasMes = (.HorasTrabalhadasSemana * 5)

            .hora_propporcional_ref_valor = ((.SB / .PPC_dias_uteis_ref) / .HorasTrabalhadasDia) ' Hora para calculo de hora extra

            .valorDiaTabalhado = Int((.SBEfetivo / .PPC_dias_corridos_do_mes) * 100) / 100
            .valorHoraTrabalhada = Math.Round((.SBEfetivo / .horasTrabalhadasMes), 2)

        End With

    End Function
    Public Function IncrementoVariaveisAutomaticas(Vaut As Object, VR As Object, hol As Object)
        ' 1 - Preparando o objeto 
        ' incremento das variaveis AUTOMATICAS


        For i = 0 To Vaut.Count - 1

            addVR(hol, Vaut(i).Variavel, Vaut(i).Descricao, Vaut(i).Unidade, Vaut(i).Base_INSS, Vaut(i).Base_fgts, Vaut(i).Base_ir, VR, Vaut(i).TipoFinanceiro, Vaut(i).Valor, Vaut(i).Qto, Vaut(i).Calculo, Vaut(i).Calculo_parametro)

        Next


    End Function
    Public Function HoleriteTelaCorpo(vr As Object, Formulario As Object)

        Dim strUnidade As String = ""
        Dim strQTO As String = ""
        Dim strValor As String = ""
        Dim strDescricao As String = ""

        ' 
        For i = 0 To vr.Count - 1

            If vr(i).Valor <> 0 Then

                strUnidade = vr(i).Unidade
                strQTO = vr(i).Qto
                If strUnidade = "R$" Then

                    strQTO = "       -"

                    strUnidade = Space(10)

                Else

                    strQTO = espacoEsquerda(vr(i).Qto.ToString, 8, 2)

                    strUnidade = espacoEsquerda(vr(i).Unidade, 10, 1)

                End If



                strValor = numeroLatino(vr(i).Valor, 13, False)

                strDescricao = espacoEsquerda(vr(i).Descricao, 27, 1)

                If strQTO = "0,00" Then strQTO = ""

                With Formulario

                    .Items.Add(vr(i).Variavel + " - " + strDescricao + strQTO + " " + strUnidade + strValor) ' espacoEsquerda(numeroLatino(VR(i).Valor, 13, False), 9, 2))

                End With
            End If

        Next
    End Function

    Public Function addVR(hol As Object, variavel As String, descricao As String, unidade As String, b_INSS As Boolean, b_fgts As Boolean, b_IR As Boolean, vr As Object, t_financeiro As String, VALOR As Decimal, QTO As Decimal, Calculo As Integer, CalculoParametro As Decimal)
        vr.Add(New FolHolLanc() With
     {
            .referencia = hol.Referencia_mes_ano,
            .Col_key = hol.Key,
            .Variavel = variavel,
            .Descricao = descricao,
            .Qto = QTO,
            .Unidade = unidade,
            .Base_INSS = b_INSS,
            .Base_fgts = b_fgts,
            .Base_ir = b_IR,
            .Valor = VALOR,
            .TipoFinanceiro = t_financeiro,
            .Calculo = Calculo,
            .Calculo_parametro = CalculoParametro
     }
     )
    End Function

    Public Function LimpaNumero(numero As String) As String
        '/ Retira numeros que receberam apenas mascara
        '/ Caso exita digitos numerico o string nao sera alterado

        Dim strNumero As String = numero
        Dim strNumeroRetorno As String = ""
        Dim strLetra As String = ""
        Dim intLenghtNumero As Integer = numero.Length

        For i = 0 To intLenghtNumero - 1

            strLetra = strNumero.Substring(i, 1)
            If strLetra >= "0" And strLetra <= "9" Then
                strNumeroRetorno += strLetra
            End If

        Next

        '''If strNumeroRetorno = "" Then

        '''    strNumeroRetorno = strNumero

        '''End If

        Return (strNumeroRetorno)

    End Function

    Public Function Col_query_show(chave As Integer) As String

        '/ tem como funcao substituir a procedure sp_colaboradorShow

        Dim rcb_chave As Integer = chave

        Dim Query As String
        Query = " select "
        Query += "idcolaborador"
        Query += ",lpad(" & chave & ",4,'0')"
        Query += ",if(isnull(colaboradorCPF),'',colaboradorCPF)"
        Query += ",if(isnull(colaboradorNome),'',colaboradorNome),"
        Query += "if(isnull(colaboradorNascimento),'',colaboradorNascimento)"
        Query += ",if(isnull(colaboradorRG),'',colaboradorRG)"
        Query += ",if(isnull(colaboradorRGoe),'',colaboradorRGoe)"
        Query += ",if(isnull(colaboradorRGuf),'',colaboradorRGuf)"
        Query += ",if(isnull(colaboradorRGemissao),'',colaboradorRGemissao)"
        Query += ",if(isnull(colaboradorRGvalidade),'',colaboradorRGvalidade)"
        Query += ",if(isnull(colaboradorCTPS),'',colaboradorCTPS)"
        Query += ",if(isnull(colaboradorCTPSoe),'',colaboradorCTPSoe)"
        Query += ",if(isnull(colaboradorCTPSuf),'',colaboradorCTPSuf)"
        Query += ",if(isnull(colaboradorCTPSerie),'',colaboradorCTPSerie)"
        Query += ",if(isnull(colaboradorCTPSemissao),'',colaboradorCTPSemissao)"
        Query += ",if(isnull(colaboradorCTPSvalidade),'',colaboradorCTPSvalidade)"
        Query += ",if(isnull(colaboradorCNH),'',colaboradorCNH)"
        Query += ",if(isnull(colaboradorCNHoe),'',colaboradorCNHoe)"
        Query += ",if(isnull(colaboradorCNHuf),'',colaboradorCNHuf)"
        Query += ",if(isnull(colaboradorCNHemissao),'',colaboradorCNHemissao)"
        Query += ",if(isnull(colaboradorCNHvalidade),'',colaboradorCNHvalidade)"
        Query += ",if(isnull(colaboradorCNH1habilitacao),'',colaboradorCNH1habilitacao)"
        Query += ",if(isnull(colaboradorPIS),'',colaboradorPIS)"
        Query += ",if(isnull(colaboradorPISoe),'',colaboradorPISoe)"
        Query += ",if(isnull(colaboradorPISoeUF),'',colaboradorPISoeUF)"
        Query += ",if(isnull(colaboradorPISemissao),'',colaboradorPISemissao)"
        Query += ",if(isnull(colaboradorPISvalidade),'',colaboradorPISvalidade)"
        Query += ",if(isnull(colaboradorReservista),'',colaboradorReservista)"
        Query += ",if(isnull(colaboradorReservistaOE),'',colaboradorReservistaOE)"
        Query += ",if(isnull(colaboradorReservistaOEuf),'',colaboradorReservistaOEuf)"
        Query += ",if(isnull(colaboradorReservistaEmissao),'',colaboradorReservistaEmissao)"
        Query += ",if(isnull(colaboradorReservistaValidade),'',colaboradorReservistaValidade)"
        Query += ",if(isnull(colaboradorTituloNumero),'',colaboradorTituloNumero)"
        Query += ",if(isnull(colaboradorTituloOE),'',colaboradorTituloOE)"
        Query += ",if(isnull(colaboradorTituloOEuf),'',colaboradorTituloOEuf)"
        Query += ",if(isnull(colaboradorTituloZona),'',colaboradorTituloZona)"
        Query += ",if(isnull(colaboradorTituloSecao),'',colaboradorTituloSecao)"
        Query += ",if(isnull(colaboradorTituloEmissao),'',colaboradorTituloEmissao)"
        Query += ",if(isnull(colaboradorTituloValidade),'',colaboradorTituloValidade)"
        Query += ",if(isnull(colaboradorMae),'',colaboradorMae)"
        Query += " ,if(isnull(colaboradorMaeCPF),'',colaboradorMaeCPF)"
        Query += ",if(isnull(colaboradorMaeNascimento),'',colaboradorMaeNascimento)"
        Query += ",if(isnull(colaboradorMaeFone),'',colaboradorMaeFone)"
        Query += ",if(isnull(colaboradorPai),'',colaboradorPai)"
        Query += ",if(isnull(colaboradorPaiCPF),'',colaboradorPaiCPF)"
        Query += ",if(isnull(colaboradorPaiNascimento),'',colaboradorPaiNascimento)"
        Query += ",if(isnull(colaboradorPaiFone),'',colaboradorPaiFone)"
        Query += ",if(isnull(colaboradorEstadoCivil),'',colaboradorEstadoCivil)"
        Query += ",if(isnull(colaboradorUniaoEstavel),'',colaboradorUniaoEstavel)"
        Query += ",if(isnull(colaboradorSexo),'',colaboradorSexo)"
        Query += ",if(isnull(colaboradorEsposolNome),'',colaboradorEsposolNome)"
        Query += ",if(isnull(colaboradorEsposoCPF),'',colaboradorEsposoCPF)"
        Query += ",if(isnull(colaboradorEsposoNascimento),'',colaboradorEsposoNascimento)"
        Query += ",if(isnull(colaboradorEsposoFone),'',colaboradorEsposoFone)"
        Query += ",if(isnull(colaboradorCompanheiroNome),'',colaboradorCompanheiroNome)"
        Query += ",if(isnull(colaboradorCompanheiroCPF),'',colaboradorCompanheiroCPF)"
        Query += ",if(isnull(colaboradorCompanheiroNascimento),'',colaboradorCompanheiroNascimento)"
        Query += ",if(isnull(colaboradorCompanheiroFone),'',colaboradorCompanheiroFone)"
        Query += ",if(isnull(colaboradorResidencia),'',colaboradorResidencia)"
        Query += ",if(isnull(colaboradorResidenciaCidade),'',colaboradorResidenciaCidade)"
        Query += ",if(isnull(colaboradorResidenciaUF),'',colaboradorResidenciaUF)"
        Query += ",if(isnull(colaboradorResidenciaCEP),'',colaboradorResidenciaCEP)"
        Query += ",if(isnull(colaboradorFone1),'',colaboradorFone1)"
        Query += ",if(isnull(colaboradorFone2),'',colaboradorFone2)"
        Query += ",if(isnull(colaboradorEmail),'',colaboradorEmail)"
        Query += ",if(isnull(colaboradorAutorizaEmail),'',colaboradorAutorizaEmail)"
        Query += ",if(isnull(colaboradorInstrucao),'',colaboradorInstrucao)"
        Query += ",if(isnull(colaboradorCurso),'',colaboradorCurso)"
        Query += ",if(isnull(colaboradorConselhoRegional),'',colaboradorConselhoRegional)"
        Query += ",if(isnull(colaboradorConselhoRegionalNumero),'',colaboradorConselhoRegionalNumero)"
        Query += ",if(isnull(colaboradorConselhoRegionalData),'',colaboradorConselhoRegionalData)"
        Query += ",if(isnull(colaboradorConselhoRegionalOE),'',colaboradorConselhoRegionalOE)"
        Query += ",if(isnull(colaboradorBanco),'',colaboradorBanco)"
        Query += ",if(isnull(colaboradorAgencia),'',colaboradorAgencia)"
        Query += ",if(isnull(colaboradorContaCorrente),'',colaboradorContaCorrente)"
        Query += ",if(isnull(colaboradorContaCorrenteDigito),'',colaboradorContaCorrenteDigito)"
        Query += ",if(isnull(colaboradorDependente1Parentesco),'',colaboradorDependente1Parentesco)"
        Query += ",if(isnull(colaboradorDependente1Nome),'',colaboradorDependente1Nome)"
        Query += ",if(isnull(colaboradorDependente1CPF),'',colaboradorDependente1CPF)"
        Query += ",if(isnull(colaboradorDependente1Nascimento),'',colaboradorDependente1Nascimento)"
        Query += ",if(isnull(colaboradorDependente2Parentesco),'',colaboradorDependente2Parentesco)"
        Query += ",if(isnull(colaboradorDependente2Nome),'',colaboradorDependente2Nome)"
        Query += ",if(isnull(colaboradorDependente2CPF),'',colaboradorDependente2CPF)"
        Query += ",if(isnull(colaboradorDependente2Nascimento),'',colaboradorDependente2Nascimento)"
        Query += ",if(isnull(colaboradorDependente3Parentesco),'',colaboradorDependente3Parentesco)"
        Query += ",if(isnull(colaboradorDependente3Nome),'',colaboradorDependente3Nome)"
        Query += ",if(isnull(colaboradorDependente3CPF),'',colaboradorDependente3CPF)"
        Query += ",if(isnull(colaboradorDependente3Nascimento),'',colaboradorDependente3Nascimento)"
        Query += ",if(isnull(colaboradorDependente4Parentesco),'',colaboradorDependente4Parentesco)"
        Query += ",if(isnull(colaboradorDependente4Nome),'',colaboradorDependente4Nome)"
        Query += ",if(isnull(colaboradorDependente4CPF),'',colaboradorDependente4CPF)"
        Query += ",if(isnull(colaboradorDependente4Nascimento),'',colaboradorDependente4Nascimento)"
        Query += ",if(isnull(colaboradorDependente5Parentesco),'',colaboradorDependente5Parentesco)"
        Query += ",if(isnull(colaboradorDependente5Nome),'',colaboradorDependente5Nome)"
        Query += ",if(isnull(colaboradorDependente5CPF),'',colaboradorDependente5CPF)"
        Query += ",if(isnull(colaboradorDependente5Nascimento),'',colaboradorDependente5Nascimento)"
        Query += ",if(isnull(colaboradorDependente6Parentesco),'',colaboradorDependente6Parentesco)"
        Query += ",if(isnull(colaboradorDependente6Nome),'',colaboradorDependente6Nome)"
        Query += ",if(isnull(colaboradorDependente6CPF),'',colaboradorDependente6CPF)"
        Query += ",if(isnull(colaboradorDependente6Nascimento),'',colaboradorDependente6Nascimento)"
        Query += ",if(isnull(colaboradorAltura),'',colaboradorAltura)"
        Query += ",if(isnull(colaboradorPeso),'',colaboradorPeso)"
        Query += ",if(isnull(colaboradorCabelo),'',colaboradorCabelo)"
        Query += ",if(isnull(colaboradorOlhos),'',colaboradorOlhos)"
        Query += ",if(isnull(colaboradorTipoDeSangues),'',colaboradorTipoDeSangues)"
        Query += ",if(isnull(colaboradorCor),'',colaboradorCor)"
        Query += ",if(isnull(colaboradorDeficiente),'',colaboradorDeficiente)"
        Query += ",if(isnull(colaboradorDeficienteTipo),'',colaboradorDeficienteTipo)"
        Query += ",if(isnull(colaboradorDeficienteOutros),'',colaboradorDeficienteOutros)"
        Query += ",if(isnull(colaboradorContatoNome1),'',colaboradorContatoNome1)"
        Query += ",if(isnull(colaboradorContatoNome1Telefone),'',colaboradorContatoNome1Telefone)"
        Query += ",if(isnull(colaboradorContatoNome1Conhecimento),'',colaboradorContatoNome1Conhecimento)"
        Query += ",if(isnull(colaboradorContatoNome2),'',colaboradorContatoNome2)"
        Query += ",if(isnull(colaboradorContatoNome2telefone),'',colaboradorContatoNome2telefone)"
        Query += ",if(isnull(colaboradorContatoNome2Conhecimento),'',colaboradorContatoNome2Conhecimento)"
        Query += ",if(isnull(colaboradorEmpresaNome1),'',colaboradorEmpresaNome1)"
        Query += ",if(isnull(colaboradorEmpresaNome1Contato),'',colaboradorEmpresaNome1Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome1Telefone),'',colaboradorEmpresaNome1Telefone)"
        Query += ",if(isnull(colaboradorEmpresaNome2),'',colaboradorEmpresaNome2)"
        Query += ",if(isnull(colaboradorEmpresaNome2Contato),'',colaboradorEmpresaNome2Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome2Telefone),'',colaboradorEmpresaNome2Telefone)"
        Query += ",if(isnull(colaboradorCargo),'',colaboradorCargo)"
        Query += ",if(isnull(colaboradorNomeCracha),'',colaboradorNomeCracha)"
        Query += ",if(isnull(colaboradorASOadmissao),'',colaboradorASOadmissao)"
        Query += ",if(isnull(colaboradorAdmissao),'',colaboradorAdmissao)"
        Query += ",if(isnull(colaboradorAdmissaoReferencia),'',colaboradorAdmissaoReferencia)"
        Query += ",if(isnull(colaboradorCadastroDataHora),'',DATE_FORMAT(colaboradorCadastroDataHora, '%d/%m/%Y %H:%i'))"
        Query += ",if(isnull(colaboradorUsuarioCadastroResponsavel),'',colaboradorUsuarioCadastroResponsavel)"
        Query += ",if(isnull(colaboradorStatus),'',colaboradorStatus)"
        Query += ",if(isnull(colaboradorPIX),'',colaboradorPIX)"
        Query += ",if(isnull(colaboradorSalarioAtual),'',colaboradorSalarioAtual)"
        Query += ",if(isnull(colaboradorHorasTrabalhadasSemana),'',colaboradorHorasTrabalhadasSemana)"
        Query += ",if(isnull(colaboradorDiasDescansoSemana),'',colaboradorDiasDescansoSemana)"
        Query += ",if(isnull(colaboradorResidenciaBairro),'',colaboradorResidenciaBairro)"
        Query += ",if(isnull(colaboradorRescisaoData),'',colaboradorRescisaoData)"
        Query += ",if(isnull(colaboradorASOrescisao),'',colaboradorASOrescisao)"
        Query += ",if(isnull(colaboradorDependentesIR),'',colaboradorDependentesIR)"
        Query += ",if(isnull(colaboradorDependentesSF),'',colaboradorDependentesSF)"
        Query += ",if(isnull(colaboradorCBO),'',colaboradorCBO)"
        Query += ",if(isnull(colaboradorSetor),'',colaboradorSetor)"
        Query += ",if(isnull(colaboradorDependente1IR),'',colaboradorDependente1IR)"
        Query += ",if(isnull(colaboradorDependente1SF),'',colaboradorDependente1SF)"
        Query += ",if(isnull(colaboradorDependente2IR),'',colaboradorDependente2IR)"
        Query += ",if(isnull(colaboradorDependente2SF),'',colaboradorDependente2SF)"
        Query += ",if(isnull(colaboradorDependente3IR),'',colaboradorDependente3IR)"
        Query += ",if(isnull(colaboradorDependente3SF),'',colaboradorDependente3SF)"
        Query += ",if(isnull(colaboradorDependente4IR),'',colaboradorDependente4IR)"
        Query += ",if(isnull(colaboradorDependente4SF),'',colaboradorDependente4SF)"
        Query += ",if(isnull(colaboradorDependente5IR),'',colaboradorDependente5IR)"
        Query += ",if(isnull(colaboradorDependente5SF),'',colaboradorDependente5SF)"
        Query += ",if(isnull(colaboradorDependente6IR),'',colaboradorDependente6IR)"
        Query += ",if(isnull(colaboradorDependente6SF),'',colaboradorDependente6SF)"
        Query += ",if(isnull(colaboradorCategoria),'',colaboradorCategoria)"
        Query += ",if(isnull(colaboradorContratoTipo),'',colaboradorContratoTipo)"
        Query += ",if(isnull(colaboradorEmpresa),'',colaboradorEmpresa)"
        Query += ",if(isnull(colaboradorPixIdentificacao),'',colaboradorPixIdentificacao)"
        Query += ",if(isnull(colaboradorDepTotal),'',colaboradorDepTotal)"
        Query += " from "
        Query += " colaborador "
        Query += " where "
        Query += " chave = " & rcb_chave

        Return Query
    End Function

    Public Function StatusDeCapa()

        Form1.form1Status.BackColor = Color.White
        Form1.form1Status.Text = "Status: On-Line // "
        Form1.Form1chave.BackColor = Color.White
        Form1.Form1chave.Text = "Chave : " & usuClass.Usuario_Chave.ToString.PadLeft(4, "0") & " // "
        Form1.Form1usuarioNome.BackColor = Color.White
        Form1.Form1usuarioNome.Text = "Usuário : " & usuClass.Usuario_Nome_Acesso & "//"

        Form1.BackgroundImage = Image.FromFile("C:\Users\paulo\Desktop\paulo\desenvolvimentoSoftwareFolha\icones\loginAutorizado.jpeg")

        Dim Query As String = "Select empCNPJ from empresa"

        gravaSQLretorno(Query)

        Form1.empCNPJ.BackColor = Color.White
        Form1.empCNPJ.Text = "CNPJ : " & CNPJcolocaMascara(gravaSQLretorno(Query)) & " // "


        Form1.Form1terminal.BackColor = Color.White
        Form1.Form1terminal.Text = "Terminal : Desconhecido // "

        Dim ap As List(Of Aponta) = ApontaAcoes.GetApontaDB()
        Form1.Form1Inicio.BackColor = Color.White
        Form1.Form1Inicio.Text = dataLatina(ap(0).Data) & " - " & ap(0).Tempo & " // "
        Form1.Timer1.Start()
        'Form1.form1DataHora = current

    End Function

    Public Function SistemaInicializado() As Boolean

        Dim fluxoTexto As IO.StreamReader
        Dim StrArquivo As String = ""
        StrArquivo = "c:\Spial\ID\empresa.txt"
        If IO.File.Exists(StrArquivo) Then

            fluxoTexto = New IO.StreamReader(StrArquivo)

            Reg.DB = Trim(fluxoTexto.ReadLine)

            Reg.DBorigem = Trim(fluxoTexto.ReadLine())

            Form1.Text = "F O L H A - ADM -  DB " & Reg.DBorigem

            Return (True)

        Else

            Return (False)

        End If

    End Function

End Module