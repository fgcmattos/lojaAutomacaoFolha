<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrIndUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrIndUsu))
        Me.BtnVerifica = New System.Windows.Forms.Button()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.MskUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnVerifica
        '
        Me.BtnVerifica.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnVerifica.BackgroundImage = CType(resources.GetObject("BtnVerifica.BackgroundImage"), System.Drawing.Image)
        Me.BtnVerifica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnVerifica.Enabled = False
        Me.BtnVerifica.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnVerifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerifica.Location = New System.Drawing.Point(41, 279)
        Me.BtnVerifica.Name = "BtnVerifica"
        Me.BtnVerifica.Size = New System.Drawing.Size(152, 27)
        Me.BtnVerifica.TabIndex = 2
        Me.BtnVerifica.UseVisualStyleBackColor = True
        '
        'TxtSenha
        '
        Me.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSenha.Location = New System.Drawing.Point(98, 237)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(95, 13)
        Me.TxtSenha.TabIndex = 2
        '
        'MskUsuario
        '
        Me.MskUsuario.Location = New System.Drawing.Point(98, 173)
        Me.MskUsuario.MaxLength = 15
        Me.MskUsuario.Name = "MskUsuario"
        Me.MskUsuario.Size = New System.Drawing.Size(95, 20)
        Me.MskUsuario.TabIndex = 1
        '
        'FmrIndUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(221, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.MskUsuario)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.BtnVerifica)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FmrIndUsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "U S U Á R I O -  I D E N T I F I C A Ç Ã O"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVerifica As Button
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents MskUsuario As TextBox
End Class
