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

    Public Class ItemWithTextBox
        ' Classe personalizada para armazenar um ListViewItem e um TextBox associados
        Public Property Item As ListViewItem
        Public Property TextBox As TextBox

        Public Sub New(item As ListViewItem, textBox As TextBox)
            Me.Item = item
            Me.TextBox = textBox
        End Sub
    End Class

    Public Class Class_Listview_Lista
        Public Property Coluna As String
        Public Property Linha As String

    End Class


End Module
