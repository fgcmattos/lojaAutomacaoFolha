Module ModuleServidor
    Public Function SistemaInicializado() As Boolean

        Dim fluxoTexto As IO.StreamReader
        Dim StrArquivo As String = ""
        StrArquivo = "c:\Spial\ID\empresa.txt"
        If IO.File.Exists(StrArquivo) Then

            fluxoTexto = New IO.StreamReader(StrArquivo)

            Reg.DB = Trim(fluxoTexto.ReadLine)

            Reg.DBorigem = Trim(fluxoTexto.ReadLine())

            Form1.Text = "F O L H A - ADM -  DB " & Reg.DBorigem

            Return (True)

        Else

            Return (False)

        End If

    End Function

End Module
