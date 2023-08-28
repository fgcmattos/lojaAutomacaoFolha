Public Class pontoCorrecaoRP
    Public Shared Function GetPontoCorrecao() As List(Of pontoCorrecao)

        Dim lista As New List(Of pontoCorrecao)
        Dim strPath As String
        Dim array(100, 5) As String
        Dim i, j As Integer

        strPath = "c:\folha\trans\ponto\correcoes\ajusteCorrecoes.txt"

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(strPath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()

            i = 0
            j = 0

            While Not MyReader.EndOfData

                Try

                    currentRow = MyReader.ReadFields()
                    For Each currentField In currentRow
                        Array(i, j) = currentField
                        j += 1

                    Next
                    j = 0
                    'MsgBox(currentField)
                    i += 1
                Catch

                End Try
            End While
        End Using


        For k = 0 To i - 1

            lista.Add(New pontoCorrecao() With
              {
                .seqCaptura = array(k, 0),
                .dataHoraMinuto = array(k, 1),
                .OBS = array(k, 2)
               })

        Next


        Return lista
    End Function
End Class
