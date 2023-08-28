Module ModuleFormatacao

    Function EspacoEsquerda(conjunto As String, tamanho As Integer, lado As Integer) As String

        Dim StrConjunto As String
        StrConjunto = IIf(IsNothing(conjunto), "", conjunto)

        If StrConjunto.Length = 0 Then
            EspacoEsquerda = Space(tamanho)
            Return EspacoEsquerda
            Exit Function
        End If

        Dim comprimento As Integer

        comprimento = tamanho - conjunto.Length

        If comprimento > 0 And lado = 2 Then
            EspacoEsquerda = Space(comprimento) & conjunto

        ElseIf comprimento > 0 And lado = 1 Then
            EspacoEsquerda = conjunto & Space(comprimento)
        ElseIf comprimento > 0 And lado = 3 Then
            EspacoEsquerda = Space(comprimento / 2) & conjunto & Space(comprimento / 2)
        Else
            EspacoEsquerda = conjunto
        End If

        Return EspacoEsquerda
    End Function

    Public Function NumeroLatino(Numero As Decimal, tamanho As Integer, inibeSinal As Boolean)


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

            NumeroLatino = Space(tamanho - Len(strvolta)) + strvolta

        Else

            NumeroLatino = strvolta

        End If

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

        'If strNumeroRetorno = "" Then

        '    strNumeroRetorno = strNumero

        'End If

        Return (strNumeroRetorno)

    End Function

    Public Function RetMascara(intSemMascara As Integer, strSemMascara As String) As String

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

End Module
