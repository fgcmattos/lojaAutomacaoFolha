Module ModuleDocumentosControleDeDigitos
    Function CPFdigito(nCPF As String) As Boolean

        If nCPF.Length < 9 Then CPFdigito = False : Exit Function
        Dim matCPF(11) As Integer
        Dim k, resultado1, resultado2 As Integer
        Dim digito As String

        CPFdigito = False

        k = 0
        resultado1 = 0
        resultado2 = 0


        For i = 1 To 9

            matCPF(i) = Mid(nCPF, i, 1)
            k = k + matCPF(i) * (11 - i)

        Next

        resultado1 = Int((k / 11))
        resultado1 = k - (resultado1 * 11)
        If resultado1 < 2 Then

            resultado1 = 0

        Else

            resultado1 = 11 - resultado1

        End If

        matCPF(10) = resultado1
        resultado2 = 0

        k = 0
        For i = 1 To 10

            k = k + matCPF(i) * (12 - i)

        Next

        resultado2 = Int((k / 11))

        resultado2 = k - (resultado2 * 11)

        If resultado2 < 2 Then

            resultado2 = 0

        Else

            resultado2 = 11 - resultado2

        End If

        digito = Trim(Str(resultado1)) + Trim(Str(resultado2))

        If digito = Mid(nCPF, 10, 2) Then

            CPFdigito = True

        End If


    End Function
    Function FormaString(tipo As Integer, palavra As String) As String

        Select Case tipo
            Case 1      ' CPF
                FormaString = palavra.Substring(0, 3) & "." & palavra.Substring(3, 3) & "." & palavra.Substring(6, 3) & "-" & palavra.Substring(9)
            Case 3      ' CNPJ
                FormaString = palavra.Substring(0, 2) & "." & palavra.Substring(2, 3) & "." & palavra.Substring(5, 3) & "/" & palavra.Substring(8, 4) & "-" & palavra.Substring(12)
            Case Else
                FormaString = palavra
        End Select


    End Function
    Public Function CPFretiraMascara(NUMERO As String) As String

        NUMERO = Replace(NUMERO, "_", "")
        NUMERO = Replace(NUMERO, ".", "")
        NUMERO = Replace(NUMERO, "/", "")
        NUMERO = Replace(NUMERO, "-", "")
        NUMERO = Replace(NUMERO, ",", "")
        NUMERO = Replace(NUMERO, " ", "")
        CPFretiraMascara = NUMERO

    End Function
    Public Function CPFcolocaMascara(CPF As String) As String
        If CPF = "" Then
            CPFcolocaMascara = ""
        Else
            CPFcolocaMascara = CPF.Substring(0, 3) & "." & CPF.Substring(3, 3) & "." & CPF.Substring(6, 3) & "-" & CPF.Substring(9, 2)
        End If
    End Function
    Public Function CNPJcolocaMascara(Cnpj As String) As String
        If Cnpj = "" Then
            CNPJcolocaMascara = ""
        Else
            CNPJcolocaMascara = Cnpj.Substring(0, 2) & "." & Cnpj.Substring(2, 3) & "." & Cnpj.Substring(5, 3) & "/" & Cnpj.Substring(8, 4) & "-" & Cnpj.Substring(12, 2)
        End If
    End Function
    Public Function CNPJretiraMascara(Cnpj As String) As String

        Dim strCNPJ As String = Cnpj
        strCNPJ = Trim(Replace(Replace(Replace(Replace(strCNPJ, ".", ""), "-", ""), "/", ""), ",", ""))
        Return strCNPJ

    End Function
    Public Function PIScolocaMascara(pis As String) As String

        Dim strPIS As String = pis

        strPIS = strPIS.Substring(0, 3) & "." & strPIS.Substring(3, 5) & "." & strPIS.Substring(8, 2) & "-" & strPIS.Substring(10)

        Return strPIS

    End Function
    Public Function PIS_digito_verificador(Identificador As String) As Boolean
        Dim booChek As Boolean = True
        Dim strIdentificador As String = Replace(Replace(Replace(Identificador, ".", ""), "-", ""), "_", "")
        If strIdentificador = "" Then Return False : Exit Function
        If strIdentificador.Length <> 11 Then booChek = False : Return booChek : Exit Function

        Dim strigitoRecebido As String = strIdentificador.Substring(10, 1)
        Dim strigitoCalculado As String = ""


        Dim arrPis(11) As Decimal
        Dim vetPeso() As Decimal = {3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
        Dim decSoma As Decimal = 0
        Dim Decresto As Decimal = 0


        For i = 0 To strIdentificador.Length - 2

            Decimal.TryParse((strIdentificador.Substring(i, 1)) * vetPeso(i), arrPis(i))
            decSoma += arrPis(i)

        Next

        Decresto = 11 - (decSoma Mod 11)

        Select Case Decresto
            Case 10, 11
                strigitoCalculado = "0"
            Case Else
                strigitoCalculado = Decresto.ToString
        End Select

        If strigitoCalculado <> strigitoRecebido Then booChek = False

        Return booChek

    End Function
End Module
