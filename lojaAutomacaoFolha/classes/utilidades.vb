Module utilidades
    'Função auxiliar de Extenso()
    'Retorna extensos de 1 a 999
    '
    Function Extcem(Pcem As Integer) As String

        Dim VLAval(3) As Integer
        Dim VLAcent(9) As String
        Dim VLAvint(9) As String
        Dim VLAdez(9) As String
        Dim VLAunit(9) As String
        Dim VLTtext As String = ""

        VLAcent(1) = "Cento"
        VLAcent(2) = "Duzentos"
        VLAcent(3) = "Trezentos"
        VLAcent(4) = "Quatrocentos"
        VLAcent(5) = "Quinhentos"
        VLAcent(6) = "Seiscentos"
        VLAcent(7) = "Setecentos"
        VLAcent(8) = "Oitocentos"
        VLAcent(9) = "Novecentos"

        VLAvint(1) = "Onze"
        VLAvint(2) = "Doze"
        VLAvint(3) = "Treze"
        VLAvint(4) = "Quatorze"
        VLAvint(5) = "Quinze"
        VLAvint(6) = "Dezesseis"
        VLAvint(7) = "Dezessete"
        VLAvint(8) = "Dezoito"
        VLAvint(9) = "Dezenove"

        VLAdez(1) = "Dez"
        VLAdez(2) = "Vinte"
        VLAdez(3) = "Trinta"
        VLAdez(4) = "Quarenta"
        VLAdez(5) = "Cinqüenta"
        VLAdez(6) = "Sessenta"
        VLAdez(7) = "Setenta"
        VLAdez(8) = "Oitenta"
        VLAdez(9) = "Noventa"

        VLAunit(1) = "Um"
        VLAunit(2) = "Dois"
        VLAunit(3) = "Três"
        VLAunit(4) = "Quatro"
        VLAunit(5) = "Cinco"
        VLAunit(6) = "Seis"
        VLAunit(7) = "Sete"
        VLAunit(8) = "Oito"
        VLAunit(9) = "Nove"

        VLAval(1) = Val(Mid(Format(Pcem, "000"), 1, 1))
        VLAval(2) = Val(Mid(Format(Pcem, "000"), 2, 1))
        VLAval(3) = Val(Mid(Format(Pcem, "000"), 3, 1))
        'Retorna extenso analisando digitos da centena,
        'Dezena e unidade VLAval(1,2 e 3)
        If Pcem > 0 Then
            If Pcem = 100 Then
                VLTtext = "Cem"
            Else
                If VLAval(1) > 0 Then
                    VLTtext = VLAcent(VLAval(1)) & IIf(VLAval(2) + VLAval(3) > 0, " e ", " ")
                End If
                If VLAval(2) = 1 And VLAval(3) > 0 Then
                    VLTtext = VLTtext & " " & VLAvint(VLAval(3))
                Else
                    If VLAval(2) > 0 Then
                        VLTtext = VLTtext & " " & VLAdez(VLAval(2)) & IIf(VLAval(3) > 0, " e ", " ")
                    End If
                    VLTtext = VLTtext & IIf(VLAval(3) > 0, " " & VLAunit(VLAval(3)), " ")
                End If
            End If
        End If
        Extcem = VLTtext & " "
    End Function

    ' Função que recebe como parametro um valor e retorna
    ' uma string contendo o extenso do mesmo
    '
    Function Extenso(PValor As Decimal) As String
        Dim VLAcifra(6, 2) As String
        Dim VLTstr As String
        Dim VLTem_e As String
        Dim VLTextenso As String = ""
        Dim VLTsubs As String
        Dim VLIx As Integer
        Dim VLIcentavos As Integer
        Dim VLIpos As Integer
        Dim VLIsearch As Integer
        Dim VLIint As Long
        Dim VLTexpressao As String

        VLAcifra(1, 1) = "Trilhão"
        VLAcifra(1, 2) = "Trilhões"
        VLAcifra(2, 1) = "Bilhão"
        VLAcifra(2, 2) = "Bilhões"
        VLAcifra(3, 1) = "Milhão"
        VLAcifra(3, 2) = "Milhões"
        VLAcifra(4, 1) = "Mil"
        VLAcifra(4, 2) = "Mil"
        VLAcifra(5, 1) = " "
        VLAcifra(5, 2) = " "
        VLAcifra(6, 1) = "Centavo"
        VLAcifra(6, 2) = "Centavos"

        VLTstr = Format$(PValor, "000000000000000.00")
        VLIint = Val(Left(VLTstr, 15)) 'Retorna Valor sem os centavos
        VLIcentavos = Int(Right(VLTstr, 2))

        If Val(PValor) > 0 Then
            'Extenso de centavos se > 0
            If VLIcentavos > 0 Then
                VLTextenso = Extcem(VLIcentavos) + VLAcifra(6, IIf(VLIcentavos = 1, 1, 2))
            End If
            'Para valores > 0 verifica se é acima de milhão
            If VLIint > 0 Then
                VLTextenso = IIf(VLIint = 1, " Real", IIf(Mid(VLTstr, 10, 6) = "000000", " de Reais ", " Reais ")) & IIf(VLIcentavos > 0, " e ", "") & VLTextenso
            End If
            'Retorna extensos analisando de três em três casas de Trilhões até Unidades
            For VLIx = 5 To 1 Step -1
                VLTsubs = Mid(VLTstr, (VLIx * 3 - 2), 3)
                If Val(VLTsubs) > 0 Then
                    If VLIint = Int(Mid(VLTstr, VLIx * 3 - 2, 17 - (VLIx * 3 - 2))) Then
                        VLTem_e = ""
                    Else
                        If Mid(VLTsubs, 2, 2) <> "00" Then
                            VLTem_e = Chr(8) & ", "
                        Else
                            VLTem_e = "e "
                        End If
                    End If
                    VLTextenso = VLTem_e & Extcem(Val(VLTsubs)) & VLAcifra(VLIx, IIf(Val(VLTsubs) = 1, 1, 2)) & " " & VLTextenso
                End If
            Next
        End If
        'Retira espaços excedentes e Backspaces
        VLIpos = 1
        VLIsearch = InStr(1, VLTextenso, "  ")
        Do While VLIsearch <> 0
            VLTexpressao = Mid(VLTextenso, 1, VLIsearch) & Mid(VLTextenso, VLIsearch + 2)
            VLIpos = VLIsearch
            VLTextenso = VLTexpressao
            VLIsearch = InStr(VLIpos, VLTextenso, "  ", 1)
        Loop
        VLIpos = 1
        VLIsearch = InStr(1, VLTextenso, Chr(8))
        Do While VLIsearch <> 0
            VLTexpressao = Mid(VLTextenso, 1, VLIsearch - 2) & Mid(VLTextenso, VLIsearch + 1)
            VLIpos = VLIsearch
            VLTextenso = VLTexpressao
            VLIsearch = InStr(VLIpos, VLTextenso, Chr(8), 1)
        Loop


        Extenso = Trim(VLTextenso)
    End Function

    Sub menuGeraOrdem(objMenu As Object)

        'Esta função cria uma estrutura de identificação
        'Nos menu definidos na interpretação do código
        'no objeto MenuStrip1 escrevendo no AccessibleName do objeto 

        Dim n1, n2, n3, n4, n5, n6, n7, n8 As Integer
        n1 = 1

        For Each item As ToolStripMenuItem In objMenu.Items
            item.AccessibleName = n1.ToString.PadLeft(2, "0")
            n1 += 1
            n2 = 1
            For Each subitem As ToolStripMenuItem In item.DropDownItems
                subitem.AccessibleName = item.AccessibleName & "." & n2.ToString.PadLeft(2, "0")
                n2 += 1
                n3 = 1
                For Each subitem1 As ToolStripMenuItem In subitem.DropDownItems
                    subitem1.AccessibleName = subitem.AccessibleName & "." & n3
                    n3 += 1
                    n4 = 1
                    For Each subitem2 As ToolStripMenuItem In subitem1.DropDownItems
                        subitem2.AccessibleName = subitem1.AccessibleName & "." & n4
                        n4 += 1
                        n5 = 1
                        For Each subitem3 As ToolStripMenuItem In subitem2.DropDownItems
                            subitem3.AccessibleName = subitem2.AccessibleName & "." & n5
                            n5 += 1
                            n6 = 1
                            For Each subitem4 As ToolStripMenuItem In subitem3.DropDownItems
                                subitem4.AccessibleName = subitem3.AccessibleName & "." & n6
                                n6 += 1
                                n7 = 1
                                For Each subitem5 As ToolStripMenuItem In subitem4.DropDownItems
                                    subitem5.AccessibleName = subitem4.AccessibleName & "." & n7
                                    n7 += 1
                                    n8 = 1
                                    For Each subitem6 As ToolStripMenuItem In subitem5.DropDownItems
                                        subitem6.AccessibleName = subitem5.AccessibleName & "." & n8
                                        n8 += 1

                                    Next
                                Next
                            Next
                        Next

                    Next

                Next

            Next
        Next
    End Sub

    Sub MenuTrava(trava As Boolean, ObjMenu As Object)

        For Each item As ToolStripMenuItem In Form1.MenuStrip1.Items

            If item.AccessibleName <> "01" Then
                item.Enabled = trava
                item.Visible = trava
            End If

            For Each subitem As ToolStripMenuItem In item.DropDownItems
                If subitem.AccessibleName.Substring(0, 2) <> "01" Then
                    subitem.Enabled = trava
                    subitem.Visible = trava
                ElseIf subitem.AccessibleName = "01.01" Then
                    subitem.Enabled = True
                    subitem.Visible = True
                ElseIf subitem.AccessibleName = "01.02" Then
                    subitem.Visible = False
                    subitem.Enabled = False
                ElseIf subitem.AccessibleName = "01.03" Then
                    subitem.Visible = True
                    subitem.Enabled = True
                End If
                For Each subitem1 As ToolStripMenuItem In subitem.DropDownItems

                    subitem1.Enabled = trava
                    subitem1.Visible = trava
                    For Each subitem2 As ToolStripMenuItem In subitem1.DropDownItems

                        subitem2.Enabled = trava
                        subitem2.Visible = trava
                        For Each subitem3 As ToolStripMenuItem In subitem2.DropDownItems

                            subitem3.Enabled = trava
                            subitem3.Visible = trava
                            For Each subitem4 As ToolStripMenuItem In subitem3.DropDownItems

                                subitem4.Enabled = trava
                                subitem4.Visible = trava
                                For Each subitem5 As ToolStripMenuItem In subitem4.DropDownItems

                                    subitem5.Enabled = trava
                                    subitem5.Visible = trava
                                    For Each subitem6 As ToolStripMenuItem In subitem5.DropDownItems

                                        subitem6.Enabled = trava
                                        subitem6.Visible = trava
                                        For Each subitem7 As ToolStripMenuItem In subitem6.DropDownItems

                                            subitem7.Enabled = trava
                                            subitem7.Visible = trava
                                            For Each subitem8 As ToolStripMenuItem In subitem7.DropDownItems

                                                subitem8.Enabled = trava
                                                subitem8.Visible = trava
                                            Next
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next

        Next

    End Sub


End Module
