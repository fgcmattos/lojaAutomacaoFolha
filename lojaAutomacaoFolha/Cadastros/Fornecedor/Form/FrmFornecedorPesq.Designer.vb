<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFornecedorPesq
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
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.TxtFantasia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.TxtRazao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Red
        Me.lblTipo.Location = New System.Drawing.Point(37, 45)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(83, 25)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "lblTipo"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(28, 254)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(741, 277)
        Me.ListBox1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MskCNPJ)
        Me.GroupBox1.Controls.Add(Me.TxtFantasia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox1.Controls.Add(Me.TxtRazao)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(28, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 146)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P A I N E L  D E  P E S Q U I S A"
        '
        'MskCNPJ
        '
        Me.MskCNPJ.Location = New System.Drawing.Point(118, 38)
        Me.MskCNPJ.Mask = "00.000.000/0000-00"
        Me.MskCNPJ.Name = "MskCNPJ"
        Me.MskCNPJ.Size = New System.Drawing.Size(155, 21)
        Me.MskCNPJ.TabIndex = 1
        '
        'TxtFantasia
        '
        Me.TxtFantasia.Location = New System.Drawing.Point(118, 106)
        Me.TxtFantasia.MaxLength = 50
        Me.TxtFantasia.Name = "TxtFantasia"
        Me.TxtFantasia.Size = New System.Drawing.Size(511, 21)
        Me.TxtFantasia.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fantasia:"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPesquisa.Location = New System.Drawing.Point(635, 65)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(88, 61)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'TxtRazao
        '
        Me.TxtRazao.Location = New System.Drawing.Point(118, 69)
        Me.TxtRazao.MaxLength = 50
        Me.TxtRazao.Name = "TxtRazao"
        Me.TxtRazao.Size = New System.Drawing.Size(511, 21)
        Me.TxtRazao.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Razão:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CNPJ:"
        '
        'FrmFornecedorPesq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 539)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFornecedorPesq"
        Me.Text = "F O R N E C E D O R   - PESQUISA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTipo As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents TxtRazao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFantasia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MskCNPJ As MaskedTextBox
End Class
