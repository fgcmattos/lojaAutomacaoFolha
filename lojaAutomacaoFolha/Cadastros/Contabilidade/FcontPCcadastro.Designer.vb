<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FcontPCcadastro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1.1 ATIVO CIRCULANTE")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1 ATIVO", New System.Windows.Forms.TreeNode() {TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1 PASSIVO CIRCULANTE")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2 PASSIVO", New System.Windows.Forms.TreeNode() {TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3 RECEITAS")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4 DESPESAS")
        Me.BtoIncrementa = New System.Windows.Forms.Button()
        Me.GroupPC = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupPC.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtoIncrementa
        '
        Me.BtoIncrementa.Location = New System.Drawing.Point(2, 316)
        Me.BtoIncrementa.Name = "BtoIncrementa"
        Me.BtoIncrementa.Size = New System.Drawing.Size(95, 25)
        Me.BtoIncrementa.TabIndex = 2
        Me.BtoIncrementa.Text = "Incrementa"
        Me.BtoIncrementa.UseVisualStyleBackColor = True
        '
        'GroupPC
        '
        Me.GroupPC.Controls.Add(Me.TreeView1)
        Me.GroupPC.Location = New System.Drawing.Point(2, 2)
        Me.GroupPC.Name = "GroupPC"
        Me.GroupPC.Size = New System.Drawing.Size(1071, 308)
        Me.GroupPC.TabIndex = 3
        Me.GroupPC.TabStop = False
        Me.GroupPC.Text = "Plano de Contas"
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.Location = New System.Drawing.Point(10, 19)
        Me.TreeView1.Name = "TreeView1"
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "1.1 ATIVO CIRCULANTE"
        TreeNode8.Name = "Node0"
        TreeNode8.Text = "1 ATIVO"
        TreeNode9.Name = "Node1"
        TreeNode9.Text = "2.1 PASSIVO CIRCULANTE"
        TreeNode10.Name = "Node1"
        TreeNode10.Text = "2 PASSIVO"
        TreeNode11.Name = "Node2"
        TreeNode11.Text = "3 RECEITAS"
        TreeNode12.Name = "Node3"
        TreeNode12.Text = "4 DESPESAS"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode10, TreeNode11, TreeNode12})
        Me.TreeView1.Size = New System.Drawing.Size(1018, 280)
        Me.TreeView1.TabIndex = 1
        '
        'FcontPCcadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 538)
        Me.Controls.Add(Me.GroupPC)
        Me.Controls.Add(Me.BtoIncrementa)
        Me.IsMdiContainer = True
        Me.Name = "FcontPCcadastro"
        Me.Text = "CADASTRO DDO PLANO DE CONTAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtoIncrementa As Button
    Friend WithEvents GroupPC As GroupBox
    Friend WithEvents TreeView1 As TreeView
End Class
