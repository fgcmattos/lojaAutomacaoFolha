Imports MySql.Data.MySqlClient

Module ModuleHolerite

    Public Sub ColaboradorCarrega(hol As Object, chave As Integer, referencia As String, ref_mes_ano As String)

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

    End Sub

    Public Sub ParametrosDaReferenciaCarrega(referencia As String, hol As Object) ' Parametros para calculo da Referencia AAAAMM

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
    End Sub

    Public Sub ParametrosBasicosCalculo(strReferencia As String, hol As Object)

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

    End Sub

    Public Sub HoleriteTelaCorpo(vr As Object, Formulario As Object)

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

                    strQTO = EspacoEsquerda(vr(i).Qto.ToString, 8, 2)

                    strUnidade = EspacoEsquerda(vr(i).Unidade, 10, 1)

                End If



                strValor = NumeroLatino(vr(i).Valor, 13, False)

                strDescricao = EspacoEsquerda(vr(i).Descricao, 27, 1)

                If strQTO = "0,00" Then strQTO = ""

                With Formulario

                    .Items.Add(vr(i).Variavel + " - " + strDescricao + strQTO + " " + strUnidade + strValor) ' espacoEsquerda(numeroLatino(VR(i).Valor, 13, False), 9, 2))

                End With
            End If

        Next

    End Sub

End Module
