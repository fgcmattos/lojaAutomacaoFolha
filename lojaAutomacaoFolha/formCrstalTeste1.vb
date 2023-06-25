

Public Class formCrstalTeste1
    Dim oi As New MsgShow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim drt As List(Of ClassFolha_diretorio) = ClassFolha_diretorioAcao.GetFolhaDiretorio("03482098867")

        ListBox1.Items.Clear()

        For i = 0 To drt.Count - 1
            ListBox1.Items.Add(espacoEsquerda(drt(i).Codigo, 20, 1) & espacoEsquerda(drt(i).NomeVariavel, 20, 1) & drt(i).Caminho)
        Next
    End Sub

    Private Sub BtnGeraDiretorios_Click(sender As Object, e As EventArgs) Handles BtnGeraDiretorios.Click
        oi.title = Me.Text
        oi.style = vbExclamation
        Dim caminho As String = "C:\Users1"
        Dim drt As List(Of ClassFolha_diretorio) = ClassFolha_diretorioAcao.GetFolhaDiretorio("03482098867")
        With oi
            For i = 0 To drt.Count - 1
                .msg = "Diretorio " & drt(i).Caminho
                .msg += Chr(13)
                .msg += Chr(13)
                If System.IO.Directory.Exists(drt(i).Caminho) Then

                    .msg += "Diretorio Existe"

                    'MsgBox(.msg, .style, .title)

                Else

                    .msg += "Diretorio nao existe"
                    .style = vbYesNo
                    .resposta = MsgBox(.msg, .style, .title)

                    If .resposta = 6 Then

                        'Shell("MD", drt(i).Caminho)
                        My.Computer.FileSystem.CreateDirectory(drt(i).Caminho)
                    End If
                End If

            Next

        End With
    End Sub

    Private Sub formCrstalTeste1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class