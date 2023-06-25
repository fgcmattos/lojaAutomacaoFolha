Public Class FolhaHolerite

    Public Property Key As Integer
    Public Property ColNome As String
    Public Property Referencia_mes_ano As String
    Public Property Referencia_mes_ano_tela As String
    Public Property ColIRdependentes As Integer
    Public Property colSFdependentes As Integer
    Public Property colCBO As String
    Public Property colCargo As String
    Public Property colSetor As String
    Public Property colHoleriteLocal As String
    Public Property SB As Decimal                           ' Salario contratado
    Public Property SBinss As Decimal
    Public Property SBfgts As Decimal
    Public Property SBir As Decimal
    Public Property INSSdesconto As Decimal
    Public Property FGTSdesconto As Decimal
    Public Property IRdesconto As Decimal
    Public Property IRFaixa As Integer
    Public Property DescontoForaDasBases As Decimal
    Public Property DescontoTotal As Decimal
    Public Property FGTSvalor As Decimal
    Public Property INSSvalor As Decimal
    Public Property INSSpercentualTotal As Decimal = 0.2      ' colocar o valor numa tabela com manutencao
    Public Property INSSpatronalValor As Decimal
    Public Property INSSvalorTotal As Decimal
    Public Property DSR_salario_variavel_base As Decimal
    Public Property DSR_salario_variavel_valor As Decimal
    Public Property pagamentoGeradoNaCompetencia As Decimal   ' INSS patronal + FGTS da referencia
    Public Property totalReferencia As Decimal        ' pagamentoGeradoNaCompetencia + Salario base custo(SBfgts)
    Public Property CustoTotalColaboradorNaReferencia As Decimal

    Public Property Emp_razaoSocial As String
    Public Property Emp_CNPJ As String
    Public Property Emp_enderecoCompleto As String


    Public Property IRvalor As Decimal
    Public Property AdmissaoData As String
    Public Property AdmissaoReferencia As String
    Public Property DiasTrabalhadosNareferencia As Decimal
    Public Property SBEfetivo As Decimal                  ' sera definido pela ponderacao entre diasDomes e Dias trabalhados(DTmes)
    Public Property DTmes As Decimal
    Public Property Tliquido As Decimal
    Public Property Tcredito As Decimal
    Public Property Tdebito As Decimal

    Public Property HorasTrabalhadasDia As Decimal
    Public Property HorasTrabalhadasSemana As Decimal

    Public Property hora_propporcional_ref_valor As Decimal ' Estes dois campos refletem a poporcionalidade
    Public Property dia_propporcional_ref_valor As Decimal  ' do Salario Base em meses com diferentes cargas de trabalho efetivo

    Public Property diasDeDescansoSemanal As Integer
    Public Property horasTrabalhadasMes As Decimal
    Public Property valorHoraTrabalhada As Decimal
    Public Property valorDiaTabalhado As Decimal

    Public Property FeriasRef As Decimal
    Public Property TercoFeriasRef As Decimal
    Public Property DecimoTerceiroRef As Decimal
    Public Property provisionadoRef As Decimal

    Public Property V0 As String
    Public Property V0nome As String
    Public Property V0qto As Decimal
    Public Property V0valor As Decimal

    Public Property V1 As String
    Public Property V1nome As String
    Public Property V1qto As Decimal
    Public Property V1valor As Decimal

    Public Property V2 As String
    Public Property V2nome As String
    Public Property V2qto As Decimal
    Public Property V2valor As Decimal

    Public Property V3 As String
    Public Property V3nome As String
    Public Property V3qto As Decimal
    Public Property V3valor As Decimal

    Public Property V4 As String
    Public Property V4nome As String
    Public Property V4qto As Decimal
    Public Property V4valor As Decimal

    Public Property V5 As String
    Public Property V5nome As String
    Public Property V5qto As Decimal
    Public Property V5valor As Decimal

    Public Property V6 As String
    Public Property V6nome As String
    Public Property V6qto As Decimal
    Public Property V6valor As Decimal

    Public Property V7 As String
    Public Property V7nome As String
    Public Property V7qto As Decimal
    Public Property V7valor As Decimal

    ' Parametros Para Calculo tabelas MySql diasUteisCab e diasUteisCorpo
    Public Property PPC_dias_corridos_do_mes As Integer
    Public Property PPC_domingos_do_mes As Integer
    Public Property PPC_feriados_do_mes As Integer
    Public Property PPC_descansos_totais_do_mes As Integer
    Public Property PPC_semana_inicial_do_mes As Integer
    Public Property PPC_semana_final_do_mes As Integer
    Public Property PPC_dias_uteis_ref As Integer

    Public Property PPC_evento01_dia As Integer
    Public Property PPC_evento01_tipo As Integer
    Public Property PPC_evento01_titulo As Integer
    Public Property PPC_evento01_semana As Integer

    Public Property PPC_evento02_dia As Integer
    Public Property PPC_evento02_tipo As Integer
    Public Property PPC_evento02_titulo As Integer
    Public Property PPC_evento02_semana As Integer

    Public Property PPC_evento03_dia As Integer
    Public Property PPC_evento03_tipo As Integer
    Public Property PPC_evento03_titulo As Integer
    Public Property PPC_evento03_semana As Integer

    Public Property PPC_evento04_dia As Integer
    Public Property PPC_evento04_tipo As Integer
    Public Property PPC_evento04_titulo As Integer
    Public Property PPC_evento04_semana As Integer

    Public Property PPC_evento05_dia As Integer
    Public Property PPC_evento05_tipo As Integer
    Public Property PPC_evento05_titulo As Integer
    Public Property PPC_evento05_semana As Integer

    Public Property PPC_evento06_dia As Integer
    Public Property PPC_evento06_tipo As Integer
    Public Property PPC_evento06_titulo As Integer
    Public Property PPC_evento06_semana As Integer

    Public Property PPC_evento07_dia As Integer
    Public Property PPC_evento07_tipo As Integer
    Public Property PPC_evento07_titulo As Integer
    Public Property PPC_evento07_semana As Integer

    Public Property PPC_evento08_dia As Integer
    Public Property PPC_evento08_tipo As Integer
    Public Property PPC_evento08_titulo As Integer
    Public Property PPC_evento08_semana As Integer

    Public Property PPC_evento09_dia As Integer
    Public Property PPC_evento09_tipo As Integer
    Public Property PPC_evento09_titulo As Integer
    Public Property PPC_evento09_semana As Integer

    Public Property PPC_evento10_dia As Integer
    Public Property PPC_evento10_tipo As Integer
    Public Property PPC_evento10_titulo As Integer
    Public Property PPC_evento10_semana As Integer

    Public Property PPC_evento11_dia As Integer
    Public Property PPC_evento11_tipo As Integer
    Public Property PPC_evento11_titulo As Integer
    Public Property PPC_evento11_semana As Integer

    Public Property PPC_evento12_dia As Integer
    Public Property PPC_evento12_tipo As Integer
    Public Property PPC_evento12_titulo As Integer
    Public Property PPC_evento12_semana As Integer




End Class
