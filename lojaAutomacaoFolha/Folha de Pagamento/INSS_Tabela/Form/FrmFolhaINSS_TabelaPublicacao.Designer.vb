<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaINSS_TabelaPublicacao
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
        Me.LblPublicacao = New System.Windows.Forms.Label()
        Me.LblConferidoPor = New System.Windows.Forms.Label()
        Me.LblDigitadoPor = New System.Windows.Forms.Label()
        Me.LblRef = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnAutoriza = New System.Windows.Forms.Button()
        Me.TxtPassWord = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblAutorizadorChave = New System.Windows.Forms.Label()
        Me.LblUsuarioAutorizador = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblPublicacao)
        Me.GroupBox1.Controls.Add(Me.LblConferidoPor)
        Me.GroupBox1.Controls.Add(Me.LblDigitadoPor)
        Me.GroupBox1.Controls.Add(Me.LblRef)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabela INSS - Publicação"
        '
        'LblPublicacao
        '
        Me.LblPublicacao.AutoSize = True
        Me.LblPublicacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublicacao.Location = New System.Drawing.Point(18, 209)
        Me.LblPublicacao.Name = "LblPublicacao"
        Me.LblPublicacao.Size = New System.Drawing.Size(455, 25)
        Me.LblPublicacao.TabIndex = 4
        Me.LblPublicacao.Text = "Data para a Publicação: ___/___/_______"
        '
        'LblConferidoPor
        '
        Me.LblConferidoPor.AutoSize = True
        Me.LblConferidoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConferidoPor.Location = New System.Drawing.Point(18, 156)
        Me.LblConferidoPor.Name = "LblConferidoPor"
        Me.LblConferidoPor.Size = New System.Drawing.Size(792, 25)
        Me.LblConferidoPor.TabIndex = 3
        Me.LblConferidoPor.Text = "Conferido por:  ___ - _______________________________  _ __/__/____"
        '
        'LblDigitadoPor
        '
        Me.LblDigitadoPor.AutoSize = True
        Me.LblDigitadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDigitadoPor.Location = New System.Drawing.Point(18, 95)
        Me.LblDigitadoPor.Name = "LblDigitadoPor"
        Me.LblDigitadoPor.Size = New System.Drawing.Size(789, 25)
        Me.LblDigitadoPor.TabIndex = 2
        Me.LblDigitadoPor.Text = "Digitado por:  ____ - _________________________________ __/__/____"
        '
        'LblRef
        '
        Me.LblRef.AutoSize = True
        Me.LblRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRef.Location = New System.Drawing.Point(18, 46)
        Me.LblRef.Name = "LblRef"
        Me.LblRef.Size = New System.Drawing.Size(71, 25)
        Me.LblRef.TabIndex = 1
        Me.LblRef.Text = "REF: "
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Highlight
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(46, 34)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(751, 233)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Faixa"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Valor da Faixa"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "% da Faixa"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Imposto da Faixa"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Imposto Acumulado da Faixa"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 280
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(846, 288)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabela Aguardando Publicação"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblUsuarioAutorizador)
        Me.GroupBox3.Controls.Add(Me.LblAutorizadorChave)
        Me.GroupBox3.Controls.Add(Me.BtnAutoriza)
        Me.GroupBox3.Controls.Add(Me.TxtPassWord)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 559)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(846, 137)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "AUTORIZAÇÃO"
        '
        'BtnAutoriza
        '
        Me.BtnAutoriza.Location = New System.Drawing.Point(632, 92)
        Me.BtnAutoriza.Name = "BtnAutoriza"
        Me.BtnAutoriza.Size = New System.Drawing.Size(165, 39)
        Me.BtnAutoriza.TabIndex = 6
        Me.BtnAutoriza.Text = "Autorizar"
        Me.BtnAutoriza.UseVisualStyleBackColor = True
        '
        'TxtPassWord
        '
        Me.TxtPassWord.Location = New System.Drawing.Point(244, 92)
        Me.TxtPassWord.MaxLength = 8
        Me.TxtPassWord.Name = "TxtPassWord"
        Me.TxtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassWord.Size = New System.Drawing.Size(132, 26)
        Me.TxtPassWord.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Senha do Autorizador : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Autorizado por (Chave) : "
        '
        'LblAutorizadorChave
        '
        Me.LblAutorizadorChave.AutoSize = True
        Me.LblAutorizadorChave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAutorizadorChave.Location = New System.Drawing.Point(240, 55)
        Me.LblAutorizadorChave.Name = "LblAutorizadorChave"
        Me.LblAutorizadorChave.Size = New System.Drawing.Size(59, 20)
        Me.LblAutorizadorChave.TabIndex = 7
        Me.LblAutorizadorChave.Text = "Chave"
        '
        'LblUsuarioAutorizador
        '
        Me.LblUsuarioAutorizador.AutoSize = True
        Me.LblUsuarioAutorizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuarioAutorizador.Location = New System.Drawing.Point(363, 55)
        Me.LblUsuarioAutorizador.Name = "LblUsuarioAutorizador"
        Me.LblUsuarioAutorizador.Size = New System.Drawing.Size(71, 20)
        Me.LblUsuarioAutorizador.TabIndex = 8
        Me.LblUsuarioAutorizador.Text = "Usuario"
        '
        'FrmFolhaINSS_TabelaPublicacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 706)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFolhaINSS_TabelaPublicacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FOLHA - Tabela INSS   -  P U B L I C A Ç Ã O"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblConferidoPor As Label
    Friend WithEvents LblDigitadoPor As Label
    Friend WithEvents LblRef As Label
    Friend WithEvents LblPublicacao As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPassWord As TextBox
    Friend WithEvents BtnAutoriza As Button
    Friend WithEvents LblUsuarioAutorizador As Label
    Friend WithEvents LblAutorizadorChave As Label
End Class
