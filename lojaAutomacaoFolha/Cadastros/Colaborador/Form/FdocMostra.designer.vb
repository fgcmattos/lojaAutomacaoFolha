<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FdocMostra
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnImprime = New System.Windows.Forms.Button()
        Me.LblArquivo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(948, 504)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnImprime
        '
        Me.BtnImprime.Location = New System.Drawing.Point(8, 523)
        Me.BtnImprime.Name = "BtnImprime"
        Me.BtnImprime.Size = New System.Drawing.Size(193, 30)
        Me.BtnImprime.TabIndex = 1
        Me.BtnImprime.Text = "i m p r i m i r"
        Me.BtnImprime.UseVisualStyleBackColor = True
        '
        'LblArquivo
        '
        Me.LblArquivo.AutoSize = True
        Me.LblArquivo.Location = New System.Drawing.Point(234, 529)
        Me.LblArquivo.Name = "LblArquivo"
        Me.LblArquivo.Size = New System.Drawing.Size(39, 13)
        Me.LblArquivo.TabIndex = 2
        Me.LblArquivo.Text = "Label1"
        '
        'FdocMostra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 558)
        Me.Controls.Add(Me.LblArquivo)
        Me.Controls.Add(Me.BtnImprime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FdocMostra"
        Me.Text = "Documento Show"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnImprime As Button
    Friend WithEvents LblArquivo As Label
End Class
