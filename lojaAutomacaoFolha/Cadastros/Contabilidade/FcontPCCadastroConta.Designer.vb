<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FcontPCCadastroConta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtoGrava = New System.Windows.Forms.Button()
        Me.BtoCancela = New System.Windows.Forms.Button()
        Me.Lorigem = New System.Windows.Forms.Label()
        Me.Lcodigo = New System.Windows.Forms.Label()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.CheckLanc = New System.Windows.Forms.CheckBox()
        Me.CheckBalancete = New System.Windows.Forms.CheckBox()
        Me.CheckBalanco = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conta Origem:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descrição:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Recebe lançamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Exibe no Balancete:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Exibe no Balanço:"
        '
        'BtoGrava
        '
        Me.BtoGrava.Location = New System.Drawing.Point(26, 231)
        Me.BtoGrava.Name = "BtoGrava"
        Me.BtoGrava.Size = New System.Drawing.Size(80, 21)
        Me.BtoGrava.TabIndex = 6
        Me.BtoGrava.Text = "Grava"
        Me.BtoGrava.UseVisualStyleBackColor = True
        '
        'BtoCancela
        '
        Me.BtoCancela.Location = New System.Drawing.Point(127, 231)
        Me.BtoCancela.Name = "BtoCancela"
        Me.BtoCancela.Size = New System.Drawing.Size(80, 21)
        Me.BtoCancela.TabIndex = 7
        Me.BtoCancela.Text = "Cancela"
        Me.BtoCancela.UseVisualStyleBackColor = True
        '
        'Lorigem
        '
        Me.Lorigem.AutoSize = True
        Me.Lorigem.BackColor = System.Drawing.Color.Red
        Me.Lorigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lorigem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lorigem.Location = New System.Drawing.Point(113, 26)
        Me.Lorigem.Name = "Lorigem"
        Me.Lorigem.Size = New System.Drawing.Size(55, 16)
        Me.Lorigem.TabIndex = 8
        Me.Lorigem.Text = "Label7"
        '
        'Lcodigo
        '
        Me.Lcodigo.AutoSize = True
        Me.Lcodigo.BackColor = System.Drawing.Color.Red
        Me.Lcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lcodigo.Location = New System.Drawing.Point(113, 53)
        Me.Lcodigo.Name = "Lcodigo"
        Me.Lcodigo.Size = New System.Drawing.Size(55, 16)
        Me.Lcodigo.TabIndex = 9
        Me.Lcodigo.Text = "Label7"
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(114, 81)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(467, 20)
        Me.TxtDescricao.TabIndex = 10
        '
        'CheckLanc
        '
        Me.CheckLanc.AutoSize = True
        Me.CheckLanc.Location = New System.Drawing.Point(171, 116)
        Me.CheckLanc.Name = "CheckLanc"
        Me.CheckLanc.Size = New System.Drawing.Size(81, 17)
        Me.CheckLanc.TabIndex = 11
        Me.CheckLanc.Text = "CheckBox1"
        Me.CheckLanc.UseVisualStyleBackColor = True
        '
        'CheckBalancete
        '
        Me.CheckBalancete.AutoSize = True
        Me.CheckBalancete.Location = New System.Drawing.Point(171, 141)
        Me.CheckBalancete.Name = "CheckBalancete"
        Me.CheckBalancete.Size = New System.Drawing.Size(81, 17)
        Me.CheckBalancete.TabIndex = 12
        Me.CheckBalancete.Text = "CheckBox2"
        Me.CheckBalancete.UseVisualStyleBackColor = True
        '
        'CheckBalanco
        '
        Me.CheckBalanco.AutoSize = True
        Me.CheckBalanco.Location = New System.Drawing.Point(171, 166)
        Me.CheckBalanco.Name = "CheckBalanco"
        Me.CheckBalanco.Size = New System.Drawing.Size(81, 17)
        Me.CheckBalanco.TabIndex = 13
        Me.CheckBalanco.Text = "CheckBox3"
        Me.CheckBalanco.UseVisualStyleBackColor = True
        '
        'FcontPCCadastroConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 263)
        Me.Controls.Add(Me.CheckBalanco)
        Me.Controls.Add(Me.CheckBalancete)
        Me.Controls.Add(Me.CheckLanc)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.Lcodigo)
        Me.Controls.Add(Me.Lorigem)
        Me.Controls.Add(Me.BtoCancela)
        Me.Controls.Add(Me.BtoGrava)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(1, 330)
        Me.Name = "FcontPCCadastroConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cadastramento de Conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtoGrava As Button
    Friend WithEvents BtoCancela As Button
    Friend WithEvents Lorigem As Label
    Friend WithEvents Lcodigo As Label
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents CheckLanc As CheckBox
    Friend WithEvents CheckBalancete As CheckBox
    Friend WithEvents CheckBalanco As CheckBox
End Class
