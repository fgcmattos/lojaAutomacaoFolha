Imports MySql.Data.MySqlClient
Public Class FrmFolhaContratoDeTrabalhoCadastramento
    Public oi As New MsgShow
    Private arrVariavel(20) As String
    Private arrIndex(20) As Integer
    Private strMascara As String = "___.___.___-__"
    Private inMascaraSemMascara As Integer = StrQTO(strMascara, "_") ' verificacao de quantos '_' existem na mascara

    Private Sub FrmFolhaContratoDeTrabalhoCadastramento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oi.title = Me.Text
        Dim intContador As Integer = 0

        Dim strLetra As String = ""

        oi.title = Me.Text

        For i = 0 To strMascara.Length - 1

            strLetra = strMascara.Substring(i, 1)

            arrVariavel(i) = strLetra

            If strLetra = "_" Then

                arrIndex(intContador) = i

                intContador += 1

            End If

        Next


    End Sub

    Private Sub CmbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipo.KeyPress

        With CmbTipo

            If e.KeyChar = Convert.ToChar(13) Then
                If .Text = "" Then
                    With oi
                        .msg = "Tipo inválido!"
                        .msg = Chr(13)
                        .msg = "Por favor escolha um dos tipos abaixo."
                        .style = vbExclamation + vbDefaultButton1
                        MsgBox(.msg, .style, .title)
                        Exit Sub
                    End With
                End If

                CamposEdicaoVai(CmbCategoria, CmbCategoriaCab, CmbTipo, CmbTipoCab)

                'CmbCategoria.Enabled = True
                '.Enabled = False
                'CmbCategoria.Focus()

            End If

        End With

    End Sub

    Private Sub CmbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCategoria.KeyPress

        With CmbCategoria
            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(CmbTipo, CmbTipoCab, CmbCategoria, CmbCategoriaCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "categoria inválida!"
                            .msg = Chr(13)
                            .msg = "Por favor escolha uma das categorias abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(CmbSetor, CmbSetorCab, CmbCategoria, CmbCategoriaCab)

            End Select

        End With

    End Sub

    Private Function CamposEdicaoVai(entra As Object, entraCab As Object, sai As Object, saiCab As Object)

        Dim corColor As Color = entraCab.BackColor
        entra.Enabled = True
        entraCab.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
        entraCab.ForeColor = System.Drawing.Color.Maroon
        entraCab.BackColor = System.Drawing.Color.Aquamarine

        saiCab.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
        saiCab.ForeColor = System.Drawing.Color.Black
        saiCab.BackColor = corColor                                                     'System.Drawing.Color.
        sai.Enabled = False
        entra.Focus()

    End Function

    Private Function CamposEdicaoVolta(entra As Object, entraCab As Object, sai As Object, saiCab As Object)

        Dim corColor As Color = entraCab.BackColor
        entra.Enabled = True
        entraCab.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
        entraCab.ForeColor = System.Drawing.Color.Maroon
        entraCab.BackColor = System.Drawing.Color.Aquamarine

        saiCab.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
        saiCab.ForeColor = System.Drawing.Color.Black
        saiCab.BackColor = corColor                     'System.Drawing.Color.
        sai.Enabled = False
        entra.Focus()

    End Function

    Private Sub MskNumeroDescansosNaSemana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskNumeroDescansosNaSemana.KeyPress

        With MskNumeroDescansosNaSemana
            If e.KeyChar = Convert.ToChar(27) Then

                CamposEdicaoVai(MskCargaHorariaSemanal, MskCargaHorariaSemanalCab, MskNumeroDescansosNaSemana, MskNumeroDescansosNaSemanaCab)

            End If

            If e.KeyChar = Convert.ToChar(13) Then

                If .Text = "" Then
                    With oi
                        .msg = "Número de descanso inválido!"
                        .msg = Chr(13)
                        .msg = "Por favor, entre com um Número de descansos válido."
                        .style = vbExclamation + vbDefaultButton1
                        MsgBox(.msg, .style, .title)
                        Exit Sub
                    End With
                End If

                CamposEdicaoVai(MskInicioDaJornada, MskInicioDaJornadaCab, MskNumeroDescansosNaSemana, MskNumeroDescansosNaSemanaCab)

                'MskCargaHorariaSemanal.Enabled = True
                '.Enabled = False
                'MskCargaHorariaSemanal.Focus()

            End If

        End With
    End Sub

    Private Sub MskCargaHorariaSemanal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskCargaHorariaSemanal.KeyPress

        With MskCargaHorariaSemanal

            If e.KeyChar = Convert.ToChar(27) Then

                CamposEdicaoVai(TxtSindicatoRazaoSocial, TxtSindicatoRazaoSocialCab, MskCargaHorariaSemanal, MskCargaHorariaSemanalCab)

            End If

            If e.KeyChar = Convert.ToChar(13) Then

                If Trim(Replace(.Text, ":", "")) = "" Or Len(.Text) < 5 Then
                    With oi
                        .msg = "Carga Horária Semanal inválida!"
                        .msg = Chr(13)
                        .msg = "Por favor, entre com uma carga horária válida 'horas:minutos'."
                        .style = vbExclamation + vbDefaultButton1
                        MsgBox(.msg, .style, .title)
                        Exit Sub
                    End With
                End If

                CamposEdicaoVai(MskNumeroDescansosNaSemana, MskNumeroDescansosNaSemanaCab, MskCargaHorariaSemanal, MskCargaHorariaSemanalCab)

                'MskCargaHorariaSemanal.Enabled = True
                '.Enabled = False
                'MskCargaHorariaSemanal.Focus()

            End If

        End With
    End Sub

    Private Sub MskDescansoNaJornada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskDescansoNaJornada.KeyPress

        With MskDescansoNaJornada

            If e.KeyChar = Convert.ToChar(27) Then

                CamposEdicaoVai(MskInicioDaJornada, MskInicioDaJornadaCab, MskDescansoNaJornada, MskDescansoNaJornadaCab)

            End If
            If e.KeyChar = Convert.ToChar(13) Then

                If Trim(Replace(.Text, ":", "")) = "" Or Len(.Text) < 5 Then
                    With oi
                        .msg = "Tempo de Descanso inválido!"
                        .msg = Chr(13)
                        .msg = "Por favor, entre com um tempo válido 'horas:minutos'."
                        .style = vbExclamation + vbDefaultButton1
                        MsgBox(.msg, .style, .title)
                        Exit Sub
                    End With
                End If

                ContratoCalculo()
                CamposEdicaoVai(BtnGrava, GruGravacao, MskDescansoNaJornada, MskDescansoNaJornadaCab)

                'MskCargaHorariaSemanal.Enabled = True
                '.Enabled = False
                'MskCargaHorariaSemanal.Focus()

            End If

        End With

    End Sub

    Private Sub MskInicioDaJornada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskInicioDaJornada.KeyPress

        With MskInicioDaJornada

            If e.KeyChar = Convert.ToChar(27) Then

                CamposEdicaoVai(MskNumeroDescansosNaSemana, MskNumeroDescansosNaSemanaCab, MskInicioDaJornada, MskInicioDaJornadaCab)

            End If


            If e.KeyChar = Convert.ToChar(13) Then

                If Trim(Replace(.Text, ":", "")) = "" Or Len(.Text) < 5 Then
                    With oi
                        .msg = "Inicio de Jornada inválido!"
                        .msg = Chr(13)
                        .msg = "Por favor, entre com um horário válido 'horas:minutos'."
                        .style = vbExclamation + vbDefaultButton1
                        MsgBox(.msg, .style, .title)
                        Exit Sub
                    End With
                End If

                CamposEdicaoVai(MskDescansoNaJornada, MskDescansoNaJornadaCab, MskInicioDaJornada, MskInicioDaJornadaCab)

                'MskCargaHorariaSemanal.Enabled = True
                '.Enabled = False
                'MskCargaHorariaSemanal.Focus()

            End If

        End With
    End Sub

    Private Function ContratoCalculo()

        Dim decCargaHorariaDiaria As Decimal
        Dim decCargaHorariaSemanal As Decimal
        Dim decCargaHorariaMensal As Decimal
        Dim decTempoInicio As Decimal
        Dim decTempoDescanso As Decimal
        Dim decTempoFimJornada As Decimal

        Dim decDiasTrabalhadosNaSemana As Decimal

        Dim strCargaHorariaDiaria_horas As String
        Dim strCargaHorariaDiaria_minutos As String
        Dim strJornadaSaida_horas As String
        Dim strJornadaSaida_minutos As String

        Dim strCargaHorariaMensal_horas As String
        Dim strCargaHorariaMensal_minutos As String

        decTempoInicio = Convert.ToDecimal(MskInicioDaJornada.Text.Substring(0, 2)) + ((Convert.ToDecimal(MskInicioDaJornada.Text.Substring(3)) / 100) / 0.6)

        decTempoDescanso = Convert.ToDecimal(MskDescansoNaJornada.Text.Substring(0, 2)) + ((Convert.ToDecimal(MskDescansoNaJornada.Text.Substring(3)) / 100) / 0.6)

        decDiasTrabalhadosNaSemana = 7 - Convert.ToDecimal(MskNumeroDescansosNaSemana.Text)
        decCargaHorariaSemanal = Convert.ToDecimal(MskCargaHorariaSemanal.Text.Substring(0, 2)) + (Convert.ToDecimal(MskCargaHorariaSemanal.Text.Substring(3))) / 60
        decCargaHorariaDiaria = decCargaHorariaSemanal / decDiasTrabalhadosNaSemana
        decCargaHorariaMensal = decCargaHorariaSemanal * 5

        decTempoFimJornada = decTempoInicio + decCargaHorariaDiaria + decTempoDescanso

        If decTempoFimJornada >= 24 Then decTempoFimJornada = decTempoFimJornada - 24

        strCargaHorariaDiaria_horas = Convert.ToString(Int(decCargaHorariaDiaria))
        strCargaHorariaDiaria_horas = strCargaHorariaDiaria_horas.PadLeft(2, "0")

        strCargaHorariaDiaria_minutos = Convert.ToString(Int(Int((decCargaHorariaDiaria - Int(decCargaHorariaDiaria) + 0.005) * 60))).PadLeft(2, "0")

        strCargaHorariaMensal_horas = Convert.ToString(Int(decCargaHorariaMensal))
        strCargaHorariaMensal_horas = strCargaHorariaMensal_horas.PadLeft(2, "0")

        strCargaHorariaMensal_minutos = Convert.ToString(Int(Int((decCargaHorariaMensal - Int(decCargaHorariaMensal) + 0.005) * 60))).PadLeft(2, "0")

        strJornadaSaida_horas = Convert.ToString(Int(decTempoFimJornada))
        strJornadaSaida_horas = strJornadaSaida_horas.PadLeft(2, "0")

        strJornadaSaida_minutos = Convert.ToString(Int(Int((decTempoFimJornada - Int(decTempoFimJornada) + 0.005) * 60))).PadLeft(2, "0")


        LblCargaHorariaDiaria.Text = strCargaHorariaDiaria_horas & ":" & strCargaHorariaDiaria_minutos
        LblCargaHorariaMensal.Text = strCargaHorariaMensal_horas & ":" & strCargaHorariaMensal_minutos
        LblFimDaJornada.Text = strJornadaSaida_horas & ":" & strJornadaSaida_minutos

    End Function

    Private Sub CmbSetor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSetor.KeyPress

        With CmbSetor


            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(CmbCategoria, CmbCategoriaCab, CmbSetor, CmbSetorCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Setor inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor, escolha um dos setores abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(CmbCargo, CmbCargoCab, CmbSetor, CmbSetorCab)

                    Dim strSetor = Trim(CmbSetor.Text.Substring(0, 2))

                    ComboCarregar(Me.CmbCargo, "folha_cargo", "concat(folha_cargo_codigo,' - ',folha_cargo_descricao)", " where folha_cargo_setor = " & strSetor)

            End Select

        End With
    End Sub

    Private Sub CmbCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCargo.KeyPress

        With CmbCargo

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(CmbSetor, CmbSetorCab, CmbCargo, CmbCargoCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Setor inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor, escolha um dos setores abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(CmbCBO, CmbCBOcab, CmbCargo, CmbCargoCab)

                    Dim strSetor = Trim(CmbSetor.Text.Substring(0, 2))

                    ComboCarregar(Me.CmbCBO, "folha_cbo", "concat(folha_cbo_codigo,' - ',folha_cbo_descricao)", " where folha_cbo_setor = " & strSetor)

            End Select

        End With
    End Sub

    Private Sub CmbCBO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCBO.KeyPress

        With CmbCBO

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(CmbCargo, CmbCargoCab, CmbCBO, CmbCBOcab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "C.B.O. inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor escolha um C.B.O. abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(MskReferencia, MskReferenciaCab, CmbCBO, CmbCBOcab)

            End Select

        End With
    End Sub

    Private Sub MskReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskReferencia.KeyPress

        With MskReferencia

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(CmbCBO, CmbCBOcab, MskReferencia, MskReferenciaCab)

                Case Convert.ToChar(13)

                    Dim strReferencia As String = .Text
                    Dim dtData As Date

                    Try

                        dtData = DateAdd("d", 1, "01/" & strReferencia)

                    Catch ex As Exception

                        With oi
                            .msg = "Referência inválida!"
                            .msg = Chr(13)
                            .msg = "Por favor, entre com uma referência válida."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With

                    End Try

                    If .Text = "" Then
                        With oi
                            .msg = "Referência inválida!"
                            .msg = Chr(13)
                            .msg = "Por favor, entre com uma referência válida."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    Dim strFiltro As String = " where folha_salario_base_Setor = " & CmbSetor.Text.Substring(0, 2)
                    strFiltro += " and "
                    strFiltro += " folha_salario_base_Cargo = " & CmbCargo.Text.Substring(0, 2)

                    ComboCarregar(Me.CmbSalario, "folha_salario_base", "format(folha_salario_utilizado,2,'de_DE')", strFiltro)

                    CamposEdicaoVai(CmbSalario, CmbSalarioCab, MskReferencia, MskReferenciaCab)

            End Select

        End With

    End Sub

    Private Sub CmbSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSalario.KeyPress

        With CmbSalario

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(MskReferencia, MskReferenciaCab, CmbSalario, CmbSalarioCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Salário inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor, escolha um dos sálários abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(CmbRegistroFisico, CmbRegistroFisicoCab, CmbSalario, CmbSalarioCab)

            End Select

        End With
    End Sub

    Private Sub CmbRegistroFisico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbRegistroFisico.KeyPress

        With CmbRegistroFisico

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(CmbSalario, CmbSalarioCab, CmbRegistroFisico, CmbRegistroFisicoCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Salário inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor, escolha um dos sálários abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(TxtLivro, TxtLivroCab, CmbRegistroFisico, CmbRegistroFisicoCab)

            End Select

        End With

    End Sub

    Private Sub TxtLivro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLivro.KeyPress

        With TxtLivro

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(CmbRegistroFisico, CmbRegistroFisicoCab, TxtLivro, TxtLivroCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Livro inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor, escolha um dos livros abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(TxtPagina, TxtPaginaCab, TxtLivro, TxtLivroCab)

            End Select

        End With
    End Sub

    Private Sub TxtPagina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPagina.KeyPress

        With TxtPagina

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(TxtLivro, TxtLivroCab, TxtPagina, TxtPaginaCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Página inválida!"
                            .msg = Chr(13)
                            .msg = "Por favor, entre com um número de página."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(TxtRegistroNumero, TxtRegistroNumeroCab, TxtPagina, TxtPaginaCab)

            End Select

        End With
    End Sub

    Private Sub MskCNPJsindicato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskCNPJsindicato.KeyPress

        With MskCNPJsindicato

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(TxtSindicatoCodigo, TxtSindicatoCodigoCab, MskCNPJsindicato, MskCNPJsindicatoCab)

                Case Convert.ToChar(13)
                    If .Text.Length < 18 Then
                        With oi
                            .msg = "CNPJ inválidO!"
                            .msg = Chr(13)
                            .msg = "Por favor, entre com um CNPJ completo (14 números)."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    If Not CNPJtesteAcao.CNPJchek(.Text) Then

                        With oi
                            .msg = "CNPJ inválidO!"
                            .msg = Chr(13)
                            .msg = "Por favor, entre com um CNPJ válido."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With

                    End If

                    If .Text = "" Then

                    End If

                    CamposEdicaoVai(TxtSindicatoRazaoSocial, TxtSindicatoRazaoSocialCab, MskCNPJsindicato, MskCNPJsindicatoCab)

            End Select

        End With
    End Sub

    Private Sub TxtRegistroNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRegistroNumero.KeyPress

        With TxtRegistroNumero

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(TxtPagina, TxtPaginaCab, TxtRegistroNumero, TxtRegistroNumeroCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Número de registro inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor, entre com um número de registro valido."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(TxtSindicatoCodigo, TxtSindicatoCodigoCab, TxtRegistroNumero, TxtRegistroNumeroCab)

            End Select

        End With
    End Sub

    Private Sub TxtSindicatoRazaoSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSindicatoRazaoSocial.KeyPress

        With TxtSindicatoRazaoSocial

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(MskCNPJsindicato, MskCNPJsindicatoCab, TxtSindicatoRazaoSocial, TxtSindicatoRazaoSocialCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Livro inválido!"
                            .msg = Chr(13)
                            .msg = "Por favor, escolha um dos livros abaixo."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(MskCargaHorariaSemanal, MskCargaHorariaSemanalCab, TxtSindicatoRazaoSocial, TxtSindicatoRazaoSocialCab)

            End Select

        End With
    End Sub

    Private Sub TxtSindicatoCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSindicatoCodigo.KeyPress

        With TxtSindicatoCodigo

            Select Case e.KeyChar

                Case Convert.ToChar(27)

                    CamposEdicaoVai(TxtRegistroNumero, TxtRegistroNumeroCab, TxtSindicatoCodigo, TxtSindicatoCodigoCab)

                Case Convert.ToChar(13)

                    If .Text = "" Then
                        With oi
                            .msg = "Página inválida!"
                            .msg = Chr(13)
                            .msg = "Por favor, entre com um número de página."
                            .style = vbExclamation + vbDefaultButton1
                            MsgBox(.msg, .style, .title)
                            Exit Sub
                        End With
                    End If

                    CamposEdicaoVai(MskCNPJsindicato, MskCNPJsindicatoCab, TxtSindicatoCodigo, TxtSindicatoCodigoCab)

            End Select

        End With
    End Sub

    Private Sub BtnGrava_Click(sender As Object, e As EventArgs) Handles BtnGrava.Click

        With oi
            .msg = "Confirma a gravação?"
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta <> 6 Then
                Exit Sub
            End If
        End With

        GravaTela()
        FrmFolhaContratoDeTrabalhoAutorizados.Show()
        Me.Close()

    End Sub

    Private Function GravaTela()

        Dim strReferencia As String = Replace(MskReferencia.Text, "/", "")

        strReferencia = strReferencia.Substring(2) & strReferencia.Substring(0, 2)

        Dim query As String = ""
        query += "Insert into folha_col_contrato "
        query += "("
        query += "FCC_tipo"                     ' Int(11) 
        query += ",FCC_tipoDescricao"           ' varchar(100) 
        query += ",FCC_admissao_data"           ' varchar(8)  
        query += ",FCC_categoriaCodigo"         ' varchar(10) 
        query += ",FCC_categoriaDescricao"      ' varchar(40) 
        query += ",FCC_sindical_codigo"         ' varchar(20) 
        query += ",FCC_CNPJentidadeSindical"    ' varchar(25) 
        query += ",FCC_RazaoEntidadeSindical"   ' varchar(100) 
        query += ",FCC_keyCol"                  ' Int(11) 
        query += ",FCC_status"                  ' Int(11)
        query += ",FCC_nome"                    ' varchar(50)
        query += ",FCC_cpf"                     ' varchar(11)
        query += ",FCC_rg"                      ' varchar(20)
        query += ",FCC_pis"                     ' varchar(20)
        query += ",FCC_ctps_numero"             ' varchar(10)
        query += ",FCC_ctps_serie"              ' varchar(10)
        query += ",FCC_aso_admissao"            ' varchar(8)
        query += ",FCC_setor"                   ' varchar(20)
        query += ",FCC_cargo"                   ' varchar(30)
        query += ",FCC_cbo"                     ' varchar(60)
        query += ",FCC_referencia"              ' varchar(6)
        query += ",FCC_salario"                 ' decimal(15,2)
        query += ",FCC_registro_fisico"         ' varchar(20)
        query += ",FCC_registro_livro"          ' varchar(15)
        query += ",FCC_registro_pagina"         ' varchar(10)
        query += ",FCC_registro_ordem"          ' int(11)
        query += ",FCC_carga_horaria_semanal"   ' time
        query += ",FCC_descanso_semanal"        ' int(11)
        query += ",FCC_jornada_dia_inicio"      ' time
        query += ",FCC_jornada_descanso"        ' time
        query += ",FCC_jornada_dia"             ' time
        query += ",FCC_jornada_mes"             ' time
        query += ",FCC_jornada_dia_fim"         ' time
        query += ")"
        query += " values "
        query += "("
        query += Trim(CmbTipo.Text.Substring(0, 2))
        query += ",'" & CmbTipo.Text.Substring(4) & "'"
        query += ",'" & dataAAAAMMDD(LblAdmissao.Text) & "'"
        query += ",'" & CmbCategoria.Text.Substring(0, 2) & "'"
        query += ",'" & CmbCategoria.Text.Substring(5) & "'"
        query += ",'" & TxtSindicatoCodigo.Text & "'"
        query += ",'" & CNPJretiraMascara(MskCNPJsindicato.Text) & "'"
        query += ",'" & TxtSindicatoRazaoSocial.Text & "'"
        query += "," & LblChave.Text
        query += ",0"
        query += ",'" & LblNome.Text & "'"
        query += ",'" & CPFretiraMascara(LblCPF.Text) & "'"
        query += ",'" & LblRG.Text & "'"
        query += ",'" & LblPIS.Text & "'"
        query += ",'" & LblCTPSnumero.Text & "'"
        query += ",'" & LblCTPSserie.Text & "'"
        query += ",'" & dataAAAAMMDD(LblASOadmissao.Text) & "'"
        query += ",'" & CmbSetor.Text & "'"
        query += ",'" & CmbCargo.Text & "'"
        query += ",'" & CmbCBO.Text & "'"
        query += ",'" & strReferencia & "'"
        query += "," & MoneyUSA(CmbSalario.Text)
        query += ",'" & CmbRegistroFisico.Text & "'"
        query += ",'" & TxtLivro.Text & "'"
        query += ",'" & TxtPagina.Text & "'"
        query += "," & TxtRegistroNumero.Text
        query += ",'" & MskCargaHorariaSemanal.Text & "'"
        query += "," & MskNumeroDescansosNaSemana.Text
        query += ",'" & MskInicioDaJornada.Text & "'"
        query += ",'" & MskDescansoNaJornada.Text & "'"
        query += ",'" & LblCargaHorariaDiaria.Text & "'"
        query += ",'" & LblCargaHorariaMensal.Text & "'"
        query += ",'" & LblFimDaJornada.Text & "'"
        query += ")"

        gravaSQL(query)

        'LblNome
        'LblCPF
        'LblRG
        'LblPIS
        'LblCTPSnumero
        'LblCTPSserie

        'LblASOadmissao


        'CmbSetor
        'CmbCargo
        'CmbCBO
        'MskReferencia
        'CmbSalario
        'CmbRegistroFisico
        'TxtLivro
        'TxtPagina
        'TxtRegistroNumero



        'MskCargaHorariaSemanal
        'MskNumeroDescansosNaSemana
        'MskInicioDaJornada
        'MskDescansoNaJornada
        'LblCargaHorariaDiaria
        'LblCargaHorariaMensal
        'LblFimDaJornada

    End Function

    Private Function indentificacaoLimpa()

        LblChave.Text = ""
        LblNome.Text = ""
        LblCPF.Text = ""
        LblRG.Text = ""
        LblPIS.Text = ""
        LblCTPSnumero.Text = ""
        LblCTPSserie.Text = ""
        LblAdmissao.Text = "__/__/____"
        LblASOadmissao.Text = "__/__/____"
    End Function

    Private Function ChecarVariaveisNecessarias() As String

        Dim StrFrase As String = ""

        If Me.LblPIS.Text = "" Then strFrase = "PIS " & Chr(13)
        If Me.LblCTPSnumero.Text = "" Then strFrase += "CTPS Número " & Chr(13)
        If Me.LblCTPSserie.Text = "" Then strFrase += "CTPS Série " & Chr(13)
        If Me.LblASOadmissao.Text = "" Then strFrase += "ASO data de admissão " & Chr(13)
        If Me.LblAdmissao.Text = "" Then strFrase += "Data de admissão " & Chr(13)

        Return (strFrase)

    End Function

    Private Sub GruIdentificacao_Enter(sender As Object, e As EventArgs) Handles GruIdentificacao.Enter

    End Sub

    Private Sub BtnIniciaCadastro_Click(sender As Object, e As EventArgs) Handles BtnIniciaCadastro.Click

        Dim strFrase As String = ChecarVariaveisNecessarias()

        Dim emp As List(Of empregador) = EmpregadorAcao.GetEmpregadorRescisao()

        TxtSindicatoCodigo.Text = emp(0).SindicalCodigo
        MskCNPJsindicato.Text = emp(0).SindicalCNPJ
        TxtSindicatoRazaoSocial.Text = emp(0).SindicalRazaoSocial

        If strFrase <> "" Then

            With oi
                .msg = "Campos Sem preenchimento no cadastro do Colaborador"
                .msg += Chr(13) & Chr(13)
                .msg += strFrase
                .msg += Chr(13)
                .msg += "Por favor, regularize o cadastro do colaborador"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                FrmFolhaContratoDeTrabalhoAutorizados.Show()
                Me.Close()
            End With
        End If

        GroupBox1.Visible = True

        ComboCarregar(Me.CmbTipo, "folha_col_contrato_tipo", "concat(FCT_codigo,' - ' , FCT_descricao)", "")

        ComboCarregar(Me.CmbCategoria, "folha_col_contrato_categoria", "concat(Fcc_Codigo,' - ' , Fcc_descricao)", "")

        ComboCarregar(Me.CmbSetor, "folha_setor", "concat(folha_setor_codigo,' - ',folha_setor_descricao)", "")

        ComboCarregar(Me.CmbCargo, "folha_cargo", "concat(folha_cargo_codigo,' - ',folha_cargo_descricao)", "")

        ComboCarregar(Me.CmbCBO, "folha_cbo", "concat(folha_cbo_codigo,' - ',folha_cbo_descricao)", "")


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        With oi
            .msg = "Confirma a cancelamento?"
            .msg += Chr(13) & Chr(13)
            .msg += " Todas as informações colhidas serão perdidas"
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta = 6 Then
                FrmFolhaContratoDeTrabalhoAutorizados.Show()
                Me.Close()
            End If
        End With

    End Sub

    Private Sub MskReferencia_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskReferencia.MaskInputRejected

    End Sub

    Private Sub TxtRegistroNumero_TextChanged(sender As Object, e As EventArgs) Handles TxtRegistroNumero.TextChanged

    End Sub

    Private Sub CmbSetor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSetor.SelectedIndexChanged

    End Sub

    Private Sub CmbCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCargo.SelectedIndexChanged

    End Sub
End Class