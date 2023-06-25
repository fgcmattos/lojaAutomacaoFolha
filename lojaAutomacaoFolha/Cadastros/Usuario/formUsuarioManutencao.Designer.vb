<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUsuarioManutencao
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
        Me.TxtSenhaNovaConferencia = New System.Windows.Forms.TextBox()
        Me.TxtSenhaNova = New System.Windows.Forms.TextBox()
        Me.TxtSenhaAtual = New System.Windows.Forms.TextBox()
        Me.BtnGrava = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblUsuário = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSenhaNovaConferencia)
        Me.GroupBox1.Controls.Add(Me.TxtSenhaNova)
        Me.GroupBox1.Controls.Add(Me.TxtSenhaAtual)
        Me.GroupBox1.Controls.Add(Me.BtnGrava)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manutenção de Senhas"
        '
        'TxtSenhaNovaConferencia
        '
        Me.TxtSenhaNovaConferencia.Location = New System.Drawing.Point(139, 110)
        Me.TxtSenhaNovaConferencia.MaxLength = 8
        Me.TxtSenhaNovaConferencia.Name = "TxtSenhaNovaConferencia"
        Me.TxtSenhaNovaConferencia.Size = New System.Drawing.Size(145, 20)
        Me.TxtSenhaNovaConferencia.TabIndex = 3
        '
        'TxtSenhaNova
        '
        Me.TxtSenhaNova.Location = New System.Drawing.Point(139, 69)
        Me.TxtSenhaNova.MaxLength = 8
        Me.TxtSenhaNova.Name = "TxtSenhaNova"
        Me.TxtSenhaNova.Size = New System.Drawing.Size(145, 20)
        Me.TxtSenhaNova.TabIndex = 2
        '
        'TxtSenhaAtual
        '
        Me.TxtSenhaAtual.Location = New System.Drawing.Point(139, 34)
        Me.TxtSenhaAtual.MaxLength = 8
        Me.TxtSenhaAtual.Name = "TxtSenhaAtual"
        Me.TxtSenhaAtual.Size = New System.Drawing.Size(146, 20)
        Me.TxtSenhaAtual.TabIndex = 1
        '
        'BtnGrava
        '
        Me.BtnGrava.Location = New System.Drawing.Point(22, 160)
        Me.BtnGrava.Name = "BtnGrava"
        Me.BtnGrava.Size = New System.Drawing.Size(289, 22)
        Me.BtnGrava.TabIndex = 4
        Me.BtnGrava.Text = "Gravar"
        Me.BtnGrava.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirme a Senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nova Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Senha Atual:"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(12, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(322, 22)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LblUsuário
        '
        Me.LblUsuário.AutoSize = True
        Me.LblUsuário.BackColor = System.Drawing.Color.DarkRed
        Me.LblUsuário.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuário.Location = New System.Drawing.Point(12, 9)
        Me.LblUsuário.Name = "LblUsuário"
        Me.LblUsuário.Size = New System.Drawing.Size(134, 16)
        Me.LblUsuário.TabIndex = 5
        Me.LblUsuário.Text = "Confirme a Senha:"
        '
        'formUsuarioManutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(346, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblUsuário)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "formUsuarioManutencao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuário - Manutenção de Senha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSenhaNovaConferencia As TextBox
    Friend WithEvents TxtSenhaNova As TextBox
    Friend WithEvents TxtSenhaAtual As TextBox
    Friend WithEvents BtnGrava As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LblUsuário As Label
End Class
