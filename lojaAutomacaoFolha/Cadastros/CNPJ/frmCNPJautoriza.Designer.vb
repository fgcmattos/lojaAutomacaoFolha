<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCNPJautoriza
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnValida = New System.Windows.Forms.Button()
        Me.MskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(604, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "O CNPJ será testado para ver se é válido ou se já está cadastrado na Base de Dado" &
    "s"
        '
        'BtnValida
        '
        Me.BtnValida.Location = New System.Drawing.Point(19, 68)
        Me.BtnValida.Name = "BtnValida"
        Me.BtnValida.Size = New System.Drawing.Size(580, 27)
        Me.BtnValida.TabIndex = 6
        Me.BtnValida.Text = "V A L I D A R"
        Me.BtnValida.UseVisualStyleBackColor = True
        '
        'MskCNPJ
        '
        Me.MskCNPJ.Location = New System.Drawing.Point(66, 34)
        Me.MskCNPJ.Mask = "00.000.000/0000-00"
        Me.MskCNPJ.Name = "MskCNPJ"
        Me.MskCNPJ.Size = New System.Drawing.Size(109, 20)
        Me.MskCNPJ.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CNPJ"
        '
        'BtnCancela
        '
        Me.BtnCancela.Location = New System.Drawing.Point(19, 101)
        Me.BtnCancela.Name = "BtnCancela"
        Me.BtnCancela.Size = New System.Drawing.Size(580, 27)
        Me.BtnCancela.TabIndex = 8
        Me.BtnCancela.Text = "C A N C E L A R"
        Me.BtnCancela.UseVisualStyleBackColor = True
        '
        'FrmCNPJautoriza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancela)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnValida)
        Me.Controls.Add(Me.MskCNPJ)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCNPJautoriza"
        Me.Text = "frmCNPJautoriza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnValida As Button
    Friend WithEvents MskCNPJ As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancela As Button
End Class
