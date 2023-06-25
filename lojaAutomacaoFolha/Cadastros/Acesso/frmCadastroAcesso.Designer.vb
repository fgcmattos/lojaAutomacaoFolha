<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAcesso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btoPesquisaUsuario = New System.Windows.Forms.Button()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.mskUsuarioID = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btoGrava = New System.Windows.Forms.Button()
        Me.btoCancela = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btoPesquisaUsuario)
        Me.GroupBox1.Controls.Add(Me.lblNome)
        Me.GroupBox1.Controls.Add(Me.mskUsuarioID)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P E S Q U I S A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Chave"
        '
        'btoPesquisaUsuario
        '
        Me.btoPesquisaUsuario.Location = New System.Drawing.Point(21, 60)
        Me.btoPesquisaUsuario.Name = "btoPesquisaUsuario"
        Me.btoPesquisaUsuario.Size = New System.Drawing.Size(152, 26)
        Me.btoPesquisaUsuario.TabIndex = 2
        Me.btoPesquisaUsuario.Text = "Pesquisa Usuário"
        Me.btoPesquisaUsuario.UseVisualStyleBackColor = True
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(165, 40)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(0, 13)
        Me.lblNome.TabIndex = 1
        '
        'mskUsuarioID
        '
        Me.mskUsuarioID.Location = New System.Drawing.Point(21, 34)
        Me.mskUsuarioID.Mask = "00000"
        Me.mskUsuarioID.Name = "mskUsuarioID"
        Me.mskUsuarioID.Size = New System.Drawing.Size(99, 20)
        Me.mskUsuarioID.TabIndex = 0
        Me.mskUsuarioID.ValidatingType = GetType(Integer)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btoGrava)
        Me.GroupBox2.Controls.Add(Me.btoCancela)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(42, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 414)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manutenção de Acesso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(375, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MENU COMPLETO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A U T O R I Z A D O"
        '
        'btoGrava
        '
        Me.btoGrava.Location = New System.Drawing.Point(20, 387)
        Me.btoGrava.Name = "btoGrava"
        Me.btoGrava.Size = New System.Drawing.Size(633, 25)
        Me.btoGrava.TabIndex = 3
        Me.btoGrava.Text = "G R A V A R"
        Me.btoGrava.UseVisualStyleBackColor = True
        '
        'btoCancela
        '
        Me.btoCancela.Location = New System.Drawing.Point(20, 356)
        Me.btoCancela.Name = "btoCancela"
        Me.btoCancela.Size = New System.Drawing.Size(633, 24)
        Me.btoCancela.TabIndex = 2
        Me.btoCancela.Text = "C A N C E L A R"
        Me.btoCancela.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.ForeColor = System.Drawing.Color.Red
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(369, 67)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(286, 277)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.ForeColor = System.Drawing.Color.Green
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(308, 277)
        Me.ListBox1.TabIndex = 0
        '
        'frmCadastroAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 538)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCadastroAcesso"
        Me.Text = "frmCadastroAcesso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btoPesquisaUsuario As Button
    Friend WithEvents lblNome As Label
    Friend WithEvents mskUsuarioID As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btoCancela As Button
    Friend WithEvents btoGrava As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
