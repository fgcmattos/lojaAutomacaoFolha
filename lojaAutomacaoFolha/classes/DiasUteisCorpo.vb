Public Class DiasUteisCorpo

    Public Property id_corpo As Integer                ' identificacao unica do corpo
    Public Property idDUcab As Integer                  ' relacionador com DiasUteisCab
    Public Property diasuteisCorpoDia As Integer        ' dia do mes do descanso
    Public Property diasuteisCorpoTipo As String        ' tipo de descanso (Domingo/Feriado)
    Public Property diasuteisCorpoTitulo As String      ' Decretado por que orgao publico
    Public Property diasuteisCorpoSemana As Integer     ' Numero da semana no ano
    Public Property diasuteisCorpoHistorico As String   ' Explanacao sobre o descanso
End Class
