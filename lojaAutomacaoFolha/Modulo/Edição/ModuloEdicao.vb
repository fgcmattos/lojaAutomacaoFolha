Module ModuloEdicao

    Public Sub EditarCampoTextBox(ByVal textBox As TextBox)

        ' Salvar a posição atual do cursor
        Dim posicao As Integer = textBox.SelectionStart

        ' Definir o ponto de inserção no início do campo TextBox
        textBox.SelectionStart = 0

        ' Rolar o campo TextBox para a posição do cursor
        textBox.ScrollToCaret()

        ' Restaurar a posição original do cursor
        textBox.SelectionStart = posicao

    End Sub

End Module
