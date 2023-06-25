Public Class DiasUteisCab

    Public Property idCab As Integer
    Public Property DUCabAnoMes As String               ' Ref AAAAMM
    Public Property DUCabNome As String                 ' Nome do mes
    Public Property DUCabDiasCorrido As Integer        ' Dias total do mes
    Public Property DUCabDiasUteis As Integer           ' Dias Uteis do Mes = diasCorrido - DiasDescanso
    Public Property DUCabDiasDescanso As Integer        ' Descansos = Domingos + feriados
    Public Property DUCabDomingos As String             ' Domingos da referencia
    Public Property DUCabFeriados As String             ' Feriados da referencia
    Public Property DUCabNumSemanaInicial As Integer    ' Numero da semana inicial no ano
    Public Property DUCabNumSemanaFinal As Integer      ' Numero da semana final no ano

End Class
