Module ModuloCalculoFolha

    Public Function INSScalculo(Base_INSS As Decimal, IsTipoCalculo As String) As Decimal

        '/ Tipode Calculo 
        '/    1 - INSSativo cáculo de produção tabela ativa
        '/    2 - INSSREF = 'yyyyMM' Tabela em conferência ou teste de cáculo

        '/      Rotina para o Caculo do INSS
        '/ Ojectos necessário
        '/ 1 - ClassINSStabela                      - Estrutura da Tabela
        '/ 2 - ClassINSStabelaAcao.GetINSS_DB()     - Captura na Base de Dados
        '/ 3 - FrmFolhaINSS_TabelaCadastro          - Formulário responsável pelo cadatramento de uma nova tabela
        '/ 4 - FrmFolhaINSS_TabelaAlteracaoo        - Formulário responsável pelas correções de erros de digitação
        '/ 5 - FrmFolhaINSS_TabelaConferencia       - Formulário responsável pelo Status de conferido para a tabela introduzida 
        '/ 6 - FrmFolhaINSS_TabelaLiberado          - Formulário responsável pela utilização em produção da tabela conferida

        '/      O arredondamento utilizado no cáculo é de 2 casas decimais aplicado no resultado obtido. 


        Dim INSSretorno As Decimal

        INSScalculo = 0.00

        Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_DB(IsTipoCalculo)


        Select Case INSStabela(0).Class_INSSnumeroDeFaixas

            Case 4

                If Base_INSS > INSStabela(0).Class_INSSfaixa4 Then
                    INSSretorno = INSStabela(0).Class_INSSfaixa4Acumulado
                ElseIf Base_INSS > INSStabela(0).Class_INSSfaixa3 Then
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa3) * (INSStabela(0).Class_INSSfaixa4Porcentagem / 100) + INSStabela(0).Class_INSSfaixa3Acumulado)
                ElseIf Base_INSS > INSStabela(0).Class_INSSfaixa2 Then
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa2) * (INSStabela(0).Class_INSSfaixa3Porcentagem / 100) + INSStabela(0).Class_INSSfaixa2Acumulado)
                ElseIf Base_INSS > INSStabela(0).Class_INSSfaixa1 Then
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa1) * (INSStabela(0).Class_INSSfaixa2Porcentagem / 100) + INSStabela(0).Class_INSSfaixa1Acumulado)
                Else
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa1) * (INSStabela(0).Class_INSSfaixa1Porcentagem / 100) + INSStabela(0).Class_INSSfaixa1Acumulado)
                End If

            Case 3

                If Base_INSS > INSStabela(0).Class_INSSfaixa3 Then
                    INSSretorno = (INSStabela(0).Class_INSSfaixa3Acumulado)
                ElseIf Base_INSS > INSStabela(0).Class_INSSfaixa2 Then
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa2) * (INSStabela(0).Class_INSSfaixa3Porcentagem / 100) + INSStabela(0).Class_INSSfaixa2Acumulado)
                ElseIf Base_INSS > INSStabela(0).Class_INSSfaixa1 Then
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa1) * (INSStabela(0).Class_INSSfaixa2Porcentagem / 100) + INSStabela(0).Class_INSSfaixa1Acumulado)
                End If

            Case 2

                If Base_INSS > INSStabela(0).Class_INSSfaixa2 Then
                    INSSretorno = (INSStabela(0).Class_INSSfaixa2Acumulado)
                ElseIf Base_INSS > INSStabela(0).Class_INSSfaixa1 Then
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa1) * (INSStabela(0).Class_INSSfaixa2Porcentagem / 100) + INSStabela(0).Class_INSSfaixa1Acumulado)
                Else
                    INSSretorno = ((Base_INSS - INSStabela(0).Class_INSSfaixa1) * (INSStabela(0).Class_INSSfaixa1Porcentagem / 100) + INSStabela(0).Class_INSSfaixa1Acumulado)
                End If

            Case 1

                If Base_INSS > INSStabela(0).Class_INSSfaixa1 Then
                    INSSretorno = (INSStabela(0).Class_INSSfaixa1Acumulado)
                End If

        End Select

        Return (Math.Round(INSSretorno, 2))

    End Function

    Public Function IRcalculo(Base_IR As Decimal, IsTipoCalculo As String) As Decimal

        '/ Tipode Calculo 
        '/    1 - IRativo cáculo de produção tabela ativa
        '/    2 - IR_REF = 'yyyyMM' Tabela em conferência ou teste de cáculo

        '/      Rotina para o Caculo do IR
        '/ Ojectos necessário
        '/ 1 - ClassIRtabela                      - Estrutura da Tabela
        '/ 2 - ClassIRtabelaAcao.GetINSS_DB()     - Captura na Base de Dados
        '/ 3 - FrmFolhaIR_TabelaCadastro          - Formulário responsável pelo cadatramento de uma nova tabela
        '/ 4 - FrmFolhaIR_TabelaAlteracaoo        - Formulário responsável pelas correções de erros de digitação
        '/ 5 - FrmFolhaIR_TabelaConferencia       - Formulário responsável pelo Status de conferido para a tabela introduzida 
        '/ 6 - FrmFolhaIR_TabelaLiberado          - Formulário responsável pela utilização em produção da tabela conferida

        '/      O arredondamento utilizado no cáculo é de 2 casas decimais aplicado no resultado obtido. 

        Dim IRretorno As Decimal = 0.00

        Dim IRtabela As List(Of ClassIRtabela) = ClassIRtabelaAcao.GetIR_DB(IsTipoCalculo)

        Select Case IRtabela(0).Class_IRnumeroDeFaixas

            Case 5

                If Base_IR >= IRtabela(0).Class_IRfaixa5 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa5) * (IRtabela(0).Class_IRfaixa5Porcentagem / 100) + IRtabela(0).Class_IRfaixa5Acumulado)
                ElseIf Base_IR >= IRtabela(0).Class_IRfaixa4 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa4) * (IRtabela(0).Class_IRfaixa5Porcentagem / 100) + IRtabela(0).Class_IRfaixa4Acumulado)
                ElseIf Base_IR >= IRtabela(0).Class_IRfaixa3 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa3) * (IRtabela(0).Class_IRfaixa4Porcentagem / 100) + IRtabela(0).Class_IRfaixa3Acumulado)
                ElseIf Base_IR >= IRtabela(0).Class_IRfaixa2 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa2) * (IRtabela(0).Class_IRfaixa3Porcentagem / 100) + IRtabela(0).Class_IRfaixa2Acumulado)
                ElseIf Base_IR >= IRtabela(0).Class_IRfaixa1 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa1) * (IRtabela(0).Class_IRfaixa2Porcentagem / 100) + IRtabela(0).Class_IRfaixa1Acumulado)
                Else
                    IRretorno = 0
                End If

            Case 4

                If Base_IR > IRtabela(0).Class_IRfaixa4 Then
                    IRretorno = IRtabela(0).Class_IRfaixa4Acumulado
                ElseIf Base_IR > IRtabela(0).Class_IRfaixa3 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa3) * (IRtabela(0).Class_IRfaixa3Porcentagem / 100) + IRtabela(0).Class_IRfaixa3Acumulado)
                ElseIf Base_IR > IRtabela(0).Class_IRfaixa2 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa2) * (IRtabela(0).Class_IRfaixa2Porcentagem / 100) + IRtabela(0).Class_IRfaixa2Acumulado)
                ElseIf Base_IR > IRtabela(0).Class_IRfaixa1 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa1) * (IRtabela(0).Class_IRfaixa1Porcentagem / 100) + IRtabela(0).Class_IRfaixa1Acumulado)
                End If

            Case 3

                If Base_IR > IRtabela(0).Class_IRfaixa3 Then
                    IRretorno = (IRtabela(0).Class_IRfaixa3Acumulado)
                ElseIf Base_IR > IRtabela(0).Class_IRfaixa2 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa2) * (IRtabela(0).Class_IRfaixa2Porcentagem / 100) + IRtabela(0).Class_IRfaixa2Acumulado)
                ElseIf Base_IR > IRtabela(0).Class_IRfaixa1 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa1) * (IRtabela(0).Class_IRfaixa1Porcentagem / 100) + IRtabela(0).Class_IRfaixa1Acumulado)
                End If

            Case 2

                If Base_IR > IRtabela(0).Class_IRfaixa2 Then
                    IRretorno = (IRtabela(0).Class_IRfaixa2Acumulado)
                ElseIf Base_IR > IRtabela(0).Class_IRfaixa1 Then
                    IRretorno = ((Base_IR - IRtabela(0).Class_IRfaixa1) * (IRtabela(0).Class_IRfaixa1Porcentagem / 100) + IRtabela(0).Class_IRfaixa1Acumulado)
                End If

            Case 1

                If Base_IR > IRtabela(0).Class_IRfaixa1 Then
                    IRretorno = (IRtabela(0).Class_IRfaixa1Acumulado)
                End If

        End Select

        Return (Math.Round(IRretorno, 2))

    End Function

End Module
