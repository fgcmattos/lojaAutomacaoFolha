<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCartaoInclusao
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MskFatura = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btotermina = New System.Windows.Forms.Button()
        Me.BtoLimpa = New System.Windows.Forms.Button()
        Me.BtoGrava = New System.Windows.Forms.Button()
        Me.MskSeguranca = New System.Windows.Forms.MaskedTextBox()
        Me.MskValidade = New System.Windows.Forms.MaskedTextBox()
        Me.MskNumero = New System.Windows.Forms.MaskedTextBox()
        Me.CmbBandeira = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtResponsavel = New System.Windows.Forms.TextBox()
        Me.TxtNomeImpresso = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNomeImpresso)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtResponsavel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MskFatura)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Btotermina)
        Me.GroupBox1.Controls.Add(Me.BtoLimpa)
        Me.GroupBox1.Controls.Add(Me.BtoGrava)
        Me.GroupBox1.Controls.Add(Me.MskSeguranca)
        Me.GroupBox1.Controls.Add(Me.MskValidade)
        Me.GroupBox1.Controls.Add(Me.MskNumero)
        Me.GroupBox1.Controls.Add(Me.CmbBandeira)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 335)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cartão de Crédito"
        '
        'MskFatura
        '
        Me.MskFatura.Location = New System.Drawing.Point(128, 241)
        Me.MskFatura.Mask = "00"
        Me.MskFatura.Name = "MskFatura"
        Me.MskFatura.Size = New System.Drawing.Size(45, 20)
        Me.MskFatura.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fatura"
        '
        'Btotermina
        '
        Me.Btotermina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btotermina.Location = New System.Drawing.Point(29, 303)
        Me.Btotermina.Name = "Btotermina"
        Me.Btotermina.Size = New System.Drawing.Size(88, 26)
        Me.Btotermina.TabIndex = 14
        Me.Btotermina.Text = "Terminar"
        Me.Btotermina.UseVisualStyleBackColor = True
        '
        'BtoLimpa
        '
        Me.BtoLimpa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtoLimpa.Location = New System.Drawing.Point(294, 303)
        Me.BtoLimpa.Name = "BtoLimpa"
        Me.BtoLimpa.Size = New System.Drawing.Size(88, 26)
        Me.BtoLimpa.TabIndex = 13
        Me.BtoLimpa.Text = "Limpar"
        Me.BtoLimpa.UseVisualStyleBackColor = True
        '
        'BtoGrava
        '
        Me.BtoGrava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtoGrava.Location = New System.Drawing.Point(294, 271)
        Me.BtoGrava.Name = "BtoGrava"
        Me.BtoGrava.Size = New System.Drawing.Size(88, 26)
        Me.BtoGrava.TabIndex = 8
        Me.BtoGrava.Text = "Gravar"
        Me.BtoGrava.UseVisualStyleBackColor = True
        '
        'MskSeguranca
        '
        Me.MskSeguranca.Location = New System.Drawing.Point(128, 204)
        Me.MskSeguranca.Mask = "000"
        Me.MskSeguranca.Name = "MskSeguranca"
        Me.MskSeguranca.Size = New System.Drawing.Size(45, 20)
        Me.MskSeguranca.TabIndex = 6
        '
        'MskValidade
        '
        Me.MskValidade.Location = New System.Drawing.Point(128, 169)
        Me.MskValidade.Mask = "00/00"
        Me.MskValidade.Name = "MskValidade"
        Me.MskValidade.Size = New System.Drawing.Size(45, 20)
        Me.MskValidade.TabIndex = 5
        '
        'MskNumero
        '
        Me.MskNumero.Location = New System.Drawing.Point(128, 62)
        Me.MskNumero.Mask = "0000-0000-0000-0000"
        Me.MskNumero.Name = "MskNumero"
        Me.MskNumero.Size = New System.Drawing.Size(132, 20)
        Me.MskNumero.TabIndex = 2
        '
        'CmbBandeira
        '
        Me.CmbBandeira.FormattingEnabled = True
        Me.CmbBandeira.Items.AddRange(New Object() {"VISA", "MASTERCAD", "ELO"})
        Me.CmbBandeira.Location = New System.Drawing.Point(128, 27)
        Me.CmbBandeira.Name = "CmbBandeira"
        Me.CmbBandeira.Size = New System.Drawing.Size(118, 21)
        Me.CmbBandeira.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Segurança"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Validade MM/AA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bandeira"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Responsável"
        '
        'TxtResponsavel
        '
        Me.TxtResponsavel.Location = New System.Drawing.Point(128, 99)
        Me.TxtResponsavel.MaxLength = 30
        Me.TxtResponsavel.Name = "TxtResponsavel"
        Me.TxtResponsavel.Size = New System.Drawing.Size(241, 20)
        Me.TxtResponsavel.TabIndex = 3
        '
        'TxtNomeImpresso
        '
        Me.TxtNomeImpresso.Location = New System.Drawing.Point(128, 132)
        Me.TxtNomeImpresso.MaxLength = 30
        Me.TxtNomeImpresso.Name = "TxtNomeImpresso"
        Me.TxtNomeImpresso.Size = New System.Drawing.Size(241, 20)
        Me.TxtNomeImpresso.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nome Impresso"
        '
        'FrmCartaoInclusao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(513, 355)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCartaoInclusao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartão de Crédito - I N C L U S Ã O"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MskNumero As MaskedTextBox
    Friend WithEvents CmbBandeira As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btotermina As Button
    Friend WithEvents BtoLimpa As Button
    Friend WithEvents BtoGrava As Button
    Friend WithEvents MskSeguranca As MaskedTextBox
    Friend WithEvents MskValidade As MaskedTextBox
    Friend WithEvents MskFatura As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtResponsavel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNomeImpresso As TextBox
    Friend WithEvents Label7 As Label
End Class
