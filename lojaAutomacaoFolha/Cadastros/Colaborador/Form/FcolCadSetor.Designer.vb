<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FcolCadSetor
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
        Me.Txtdescricao = New System.Windows.Forms.TextBox()
        Me.MskCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.BtnGrava = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnTermina = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Controls.Add(Me.BtnTermina)
        Me.GroupBox1.Controls.Add(Me.Txtdescricao)
        Me.GroupBox1.Controls.Add(Me.MskCodigo)
        Me.GroupBox1.Controls.Add(Me.BtnGrava)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro de Setor"
        '
        'Txtdescricao
        '
        Me.Txtdescricao.Location = New System.Drawing.Point(74, 61)
        Me.Txtdescricao.MaxLength = 45
        Me.Txtdescricao.Name = "Txtdescricao"
        Me.Txtdescricao.Size = New System.Drawing.Size(346, 20)
        Me.Txtdescricao.TabIndex = 4
        '
        'MskCodigo
        '
        Me.MskCodigo.Location = New System.Drawing.Point(73, 29)
        Me.MskCodigo.Mask = "0000"
        Me.MskCodigo.Name = "MskCodigo"
        Me.MskCodigo.Size = New System.Drawing.Size(64, 20)
        Me.MskCodigo.TabIndex = 3
        '
        'BtnGrava
        '
        Me.BtnGrava.Location = New System.Drawing.Point(13, 101)
        Me.BtnGrava.Name = "BtnGrava"
        Me.BtnGrava.Size = New System.Drawing.Size(76, 20)
        Me.BtnGrava.TabIndex = 2
        Me.BtnGrava.Text = "Grava"
        Me.BtnGrava.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(533, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 194)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setores Existentes"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(420, 175)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ativos"
        '
        'BtnTermina
        '
        Me.BtnTermina.Location = New System.Drawing.Point(13, 127)
        Me.BtnTermina.Name = "BtnTermina"
        Me.BtnTermina.Size = New System.Drawing.Size(76, 20)
        Me.BtnTermina.TabIndex = 5
        Me.BtnTermina.Text = "Termina"
        Me.BtnTermina.UseVisualStyleBackColor = True
        '
        'FcolCadSetor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 215)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FcolCadSetor"
        Me.Text = "FOLHA - Cadastramento de Setores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txtdescricao As TextBox
    Friend WithEvents MskCodigo As MaskedTextBox
    Friend WithEvents BtnGrava As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BtnTermina As Button
End Class
