Imports MySql.Data.MySqlClient
Public Class fColCadAutz
    Private Sub fColCadAutz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnValida_Click(sender As Object, e As EventArgs) Handles btnValida.Click
        Dim sCPF As String
        Dim msg As String
        Dim style As String
        Dim title As String
        'Dim ctxt As String
        'Dim help As String
        Dim resposta As String
        '---------------------

        msg = "CPF Liberado para cadastro, Inicia Cadstro?"
        style = vbYesNo + vbQuestion + vbDefaultButton1
        title = "CPF - Checagem"

        sCPF = CPFretiraMascara(mskCPF.Text)

        If Len(sCPF) < 11 Then
            msg = "CPF digitado com menos de 11 digitos"
            style = vbExclamation
        Else
            If CPFdigito(sCPF) Then
                If OpenDB() Then

                    Dim Query As String = "select count(*) as qto from colaborador where colaboradorCPF = '" & sCPF & "'"
                    Dim CMD As New MySqlCommand(Query, Conn)
                    Dim DTReader As MySqlDataReader

                    Try
                        DTReader = CMD.ExecuteReader
                        DTReader.Read()

                        If DTReader.GetString(0) > 0 Then
                            msg = "CPF já cadastrado !"
                            style = vbCritical
                        Else
                            title = "CPF Liberado para cadastro"
                            msg = "Inicia Cadastro?"
                            style = vbYesNo + vbQuestion + vbDefaultButton1
                        End If


                    Catch ex As Exception
                        MsgBox("Problemas Na Gravação!")
                    End Try

                    Conn.Close()
                End If


            Else
                msg = "CPF invalido"
                style = vbCritical
            End If
        End If

        resposta = MsgBox(msg, style, title)

        If resposta = "6" Then

            fColCad.Show()
            fColCad.lblCPF.Text = CPFcolocaMascara(sCPF)
            Me.Close()

        Else
            mskCPF.Focus()
        End If


    End Sub

    Private Sub MskCPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskCPF.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then
            Dim sCPF As String
            Dim msg As String
            Dim style As String
            Dim title As String
            'Dim ctxt As String
            'Dim help As String
            Dim resposta As String
            '---------------------

            msg = "CPF Liberado para cadastro, Inicia Cadstro?"
            style = vbYesNo + vbQuestion + vbDefaultButton1
            title = "CPF - Checagem"

            sCPF = CPFretiraMascara(mskCPF.Text)

            If Len(sCPF) < 11 Then
                msg = "CPF digitado com menos de 11 digitos"
                style = vbExclamation
            Else
                If CPFdigito(sCPF) Then
                    If OpenDB() Then

                        Dim Query As String = "select count(*) as qto from colaborador where colaboradorCPF = '" & sCPF & "'"
                        Dim CMD As New MySqlCommand(Query, Conn)
                        Dim DTReader As MySqlDataReader

                        Try
                            DTReader = CMD.ExecuteReader
                            DTReader.Read()

                            If DTReader.GetString(0) > 0 Then
                                msg = "CPF já cadastrado !"
                                style = vbExclamation
                            Else
                                title = "CPF Liberado para cadastro"
                                msg = "Inicia Cadastro?"
                                style = vbYesNo + vbQuestion + vbDefaultButton1
                            End If


                        Catch ex As Exception
                            MsgBox("Problemas Na Gravação!")
                        End Try

                        Conn.Close()
                    End If


                Else
                    msg = "CPF invalido"
                    style = vbExclamation
                End If
            End If

            resposta = MsgBox(msg, style, title)
            If resposta = 6 Then
                fColCad.Show()
                fColCad.lblCPF.Text = CPFcolocaMascara(sCPF)
                Me.Close()
            Else
                mskCPF.Focus()
            End If


        End If
    End Sub

    Private Sub mskCPF_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCPF.MaskInputRejected

    End Sub
End Class