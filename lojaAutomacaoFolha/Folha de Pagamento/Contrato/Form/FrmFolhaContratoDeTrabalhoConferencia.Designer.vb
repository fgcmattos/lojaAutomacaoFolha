<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaContratoDeTrabalhoConferencia
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
        Me.ButIniciar = New System.Windows.Forms.Button()
        Me.Butnancela = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButIniciar)
        Me.GroupBox1.Controls.Add(Me.Butnancela)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 278)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contratos autorizados para conferência"
        '
        'ButIniciar
        '
        Me.ButIniciar.Location = New System.Drawing.Point(644, 231)
        Me.ButIniciar.Name = "ButIniciar"
        Me.ButIniciar.Size = New System.Drawing.Size(79, 26)
        Me.ButIniciar.TabIndex = 2
        Me.ButIniciar.Text = "Iniciar"
        Me.ButIniciar.UseVisualStyleBackColor = True
        '
        'Butnancela
        '
        Me.Butnancela.Location = New System.Drawing.Point(559, 231)
        Me.Butnancela.Name = "Butnancela"
        Me.Butnancela.Size = New System.Drawing.Size(79, 26)
        Me.Butnancela.TabIndex = 1
        Me.Butnancela.Text = "Cancela"
        Me.Butnancela.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(17, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(706, 199)
        Me.ListBox1.TabIndex = 0
        '
        'FrmFolhaContratoDeTrabalhoConferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 300)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFolhaContratoDeTrabalhoConferencia"
        Me.Text = "Folha de Pagamento - Contratos para C O N F E R Ê N C I A"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButIniciar As Button
    Friend WithEvents Butnancela As Button
    Friend WithEvents ListBox1 As ListBox
End Class
