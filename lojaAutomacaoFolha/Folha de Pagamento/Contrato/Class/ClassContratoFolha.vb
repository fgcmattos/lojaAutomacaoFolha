Public Class ClassContratoFolha

    Public Property Id_FCC As Integer                           '	int AI PK 
    Public Property FCC_numero As String                        '	varchar(7) PK 
    Public Property FCC_tipo As Integer                         '	int 
    Public Property FCC_tipoDescricao As String                 '	varchar(100) 
    Public Property FCC_afastamentoDescricao As String          '	varchar(40) 
    Public Property FCC_remuneracaoMesAnterior As Decimal       '	decimal(15,2) 
    Public Property FCC_admissao_data As String                 '	varchar(8) 
    Public Property FCC_avisoPrevio_data As String              '	varchar(8) 
    Public Property FCC_afastamento_data As String              '	varchar(8) 
    Public Property FCC_afastamentoCodigo As String             '	varchar(8) 
    Public Property FCC_pensaoAlimenticiaTRCT As String         '	decimal(15,2) 
    Public Property FCC_pensaoAlimenticiaFGTS As Decimal        '	decimal(15,2) 
    Public Property FCC_categoriaCodigo As String               '	varchar(10) 
    Public Property FCC_categoriaDescricao As String            '	varchar(40) 
    Public Property FCC_sindical_codigo As String               '	varchar(20) 
    Public Property FCC_CNPJentidadeSindical As String          '	varchar(25) 
    Public Property FCC_RazaoEntidadeSindical As String         '	varchar(100) 
    Public Property FCC_keyCol As Integer                       '	int 
    Public Property FCC_status As Integer                       '	int 
    Public Property FCC_nome As String                          '	varchar(50) 
    Public Property FCC_cpf As String                           '	varchar(11) 
    Public Property FCC_rg As String                            '	varchar(20) 
    Public Property FCC_pis As String                           '	varchar(20) 
    Public Property FCC_ctps_numero As String                   '	varchar(10) 
    Public Property FCC_ctps_serie As String                    '	varchar(10) 
    Public Property FCC_aso_admissao As String                  '	varchar(8) 
    Public Property FCC_setor As String                         '	varchar(20) 
    Public Property FCC_cargo As String                         '	varchar(30) 
    Public Property FCC_cbo As String                           '	varchar(60) 
    Public Property FCC_referencia As String                    '	varchar(6) 
    Public Property FCC_salario As Decimal                      '	decimal(15,2) 
    Public Property FCC_registro_fisico As String               '	varchar(20) 
    Public Property FCC_registro_livro As String                '	varchar(15) 
    Public Property FCC_registro_pagina As String               '	varchar(10) 
    Public Property FCC_registro_ordem As Integer               '	int 
    Public Property FCC_carga_horaria_semanal As TimeSpan       '   Time
    Public Property FCC_descanso_semanal As Integer             '	int 
    Public Property FCC_jornada_dia_inicio As TimeSpan          '	Time
    Public Property FCC_jornada_descanso As TimeSpan            '   Time
    Public Property FCC_jornada_dia As TimeSpan                 '   Time
    Public Property FCC_jornada_mes As TimeSpan                 '   Time
    Public Property FCC_jornada_dia_fim As TimeSpan             '	Time
    Public Property FCC_criacao As DateTime                     '	dateTime
    Public Property FCC_responsavel As Integer                  '	int

End Class
