Public Class FcontPCcadastro
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

        '''If e.Action = Windows.Forms.MouseButtons.Right Then
        '''    MessageBox.Show("Oi! sou o botão direito")
        '''End If

        'FcontPCCadastroConta.show


    End Sub

    Private Sub TreeView1_DoubleClick(sender As Object, e As EventArgs)
        '''Dim Incluir As New FcontPCCadastroConta

        '''Me.TreeView1.Enabled = False

        '''Incluir.MdiParent = Me 'Permite que o Form Filho seja aberto dentro do Form MDI

        '''Incluir.Show() 'Chama o Form Incluir, lembrar de declarar o form

        ''''Incluir.Lorigem.Text = TreeView1.

        MsgBox(TreeView1.SelectedNode.Text)


    End Sub

    Private Sub BtoIncrementa_Click(sender As Object, e As EventArgs) Handles BtoIncrementa.Click

        Dim nPonteiro As Integer = TreeView1.Nodes.Count

        MsgBox(TreeView1.SelectedNode.Text)

        GroupPC.Enabled = True

        Dim Incluir As New FcontPCCadastroConta

        Incluir.MdiParent = Me 'Permite que o Form Filho seja aberto dentro do Form MDI

        Incluir.Show() 'Chama o Form Incluir, lembrar de declarar o form

        Incluir.Lorigem.Text = TreeView1.SelectedNode.Text

    End Sub


End Class