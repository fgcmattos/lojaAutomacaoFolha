Public Class CNPJtesteAcao

    Public Shared Function CNPJchek(CNPJ As String) As Boolean

        ' Procedimento do CNPJ com máscara __.___.___/____-__

        Dim resultado As Decimal
        Dim Cj As New CNPJteste

        With Cj
            .e1 = Int(CNPJ.Substring(0, 1))
            .e2 = Int(CNPJ.Substring(1, 1))
            .e3 = Int(CNPJ.Substring(3, 1))
            .e4 = Int(CNPJ.Substring(4, 1))
            .e5 = Int(CNPJ.Substring(5, 1))
            .e6 = Int(CNPJ.Substring(7, 1))
            .e7 = Int(CNPJ.Substring(8, 1))
            .e8 = Int(CNPJ.Substring(9, 1))
            .e9 = Int(CNPJ.Substring(11, 1))
            .e10 = Int(CNPJ.Substring(12, 1))
            .e11 = Int(CNPJ.Substring(13, 1))
            .e12 = Int(CNPJ.Substring(14, 1))

            resultado = (.e1 * .t1 + .e2 * .t2 + .e3 * .t3 + .e4 * .t4)
            resultado += (.e5 * .t5 + .e6 * .t6 + .e7 * .t7 + .e8 * .t8)
            resultado += (.e9 * .t9 + .e10 * .t10 + .e11 * .t11 + .e12 * .t12)
            resultado = resultado Mod 11

            If Int(resultado) < 2 Then .e13 = 0 Else .e13 = 11 - Int(resultado)

            resultado = (.e1 * .t0 + .e2 * .t1 + .e3 * .t2 + .e4 * .t3)
            resultado += (.e5 * .t4 + .e6 * .t5 + .e7 * .t6 + .e8 * .t7)
            resultado += (.e9 * .t8 + .e10 * .t9 + .e11 * .t10 + .e12 * .t11 + .e13 * .t12)

            resultado = resultado Mod 11

            If Int(resultado) < 2 Then .e14 = 0 Else .e14 = 11 - Int(resultado)

            'MsgBox(.e13.ToString + .e14.ToString)

            If .e13.ToString + .e14.ToString = CNPJ.Substring(16, 2) Then
                CNPJchek = True
            Else
                CNPJchek = False
            End If
        End With

    End Function

End Class
