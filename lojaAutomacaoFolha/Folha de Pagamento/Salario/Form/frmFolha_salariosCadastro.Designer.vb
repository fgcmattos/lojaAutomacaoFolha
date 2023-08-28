<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFolha_salariosCadastro
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
        Me.GruShow = New System.Windows.Forms.GroupBox()
        Me.BtnTermina = New System.Windows.Forms.Button()
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GruEntradaSalarios = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MskDataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDiponibiliza = New System.Windows.Forms.Button()
        Me.TxtSutilizado = New System.Windows.Forms.TextBox()
        Me.TxtSmaximo = New System.Windows.Forms.TextBox()
        Me.TxtSMedio = New System.Windows.Forms.TextBox()
        Me.TxtSB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GruShow.SuspendLayout()
        Me.GruEntradaSalarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'GruShow
        '
        Me.GruShow.Controls.Add(Me.BtnTermina)
        Me.GruShow.Controls.Add(Me.BtnGravar)
        Me.GruShow.Controls.Add(Me.ListView1)
        Me.GruShow.Location = New System.Drawing.Point(12, 12)
        Me.GruShow.Name = "GruShow"
        Me.GruShow.Size = New System.Drawing.Size(969, 286)
        Me.GruShow.TabIndex = 0
        Me.GruShow.TabStop = False
        Me.GruShow.Text = "Exibição"
        '
        'BtnTermina
        '
        Me.BtnTermina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTermina.Location = New System.Drawing.Point(732, 252)
        Me.BtnTermina.Name = "BtnTermina"
        Me.BtnTermina.Size = New System.Drawing.Size(231, 22)
        Me.BtnTermina.TabIndex = 2
        Me.BtnTermina.Text = "Termina"
        Me.BtnTermina.UseVisualStyleBackColor = True
        '
        'BtnGravar
        '
        Me.BtnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGravar.Location = New System.Drawing.Point(732, 227)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(231, 22)
        Me.BtnGravar.TabIndex = 1
        Me.BtnGravar.Text = "Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(957, 202)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Setor"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cargo"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descrição"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sal. Base"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sal.Média"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Sal.Máximo"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Utilizado"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Inicio"
        Me.ColumnHeader9.Width = 100
        '
        'GruEntradaSalarios
        '
        Me.GruEntradaSalarios.Controls.Add(Me.Button1)
        Me.GruEntradaSalarios.Controls.Add(Me.MskDataInicio)
        Me.GruEntradaSalarios.Controls.Add(Me.Label1)
        Me.GruEntradaSalarios.Controls.Add(Me.BtnDiponibiliza)
        Me.GruEntradaSalarios.Controls.Add(Me.TxtSutilizado)
        Me.GruEntradaSalarios.Controls.Add(Me.TxtSmaximo)
        Me.GruEntradaSalarios.Controls.Add(Me.TxtSMedio)
        Me.GruEntradaSalarios.Controls.Add(Me.TxtSB)
        Me.GruEntradaSalarios.Controls.Add(Me.Label5)
        Me.GruEntradaSalarios.Controls.Add(Me.Label4)
        Me.GruEntradaSalarios.Controls.Add(Me.Label3)
        Me.GruEntradaSalarios.Controls.Add(Me.Label2)
        Me.GruEntradaSalarios.Controls.Add(Me.LblTitulo)
        Me.GruEntradaSalarios.Enabled = False
        Me.GruEntradaSalarios.Location = New System.Drawing.Point(12, 304)
        Me.GruEntradaSalarios.Name = "GruEntradaSalarios"
        Me.GruEntradaSalarios.Size = New System.Drawing.Size(969, 221)
        Me.GruEntradaSalarios.TabIndex = 1
        Me.GruEntradaSalarios.TabStop = False
        Me.GruEntradaSalarios.Text = "Entrada dos Salários"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(272, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 26)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MskDataInicio
        '
        Me.MskDataInicio.Location = New System.Drawing.Point(137, 154)
        Me.MskDataInicio.Mask = "00/00/0000"
        Me.MskDataInicio.Name = "MskDataInicio"
        Me.MskDataInicio.Size = New System.Drawing.Size(117, 20)
        Me.MskDataInicio.TabIndex = 9
        Me.MskDataInicio.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Data Inicio"
        '
        'BtnDiponibiliza
        '
        Me.BtnDiponibiliza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDiponibiliza.Location = New System.Drawing.Point(19, 192)
        Me.BtnDiponibiliza.Name = "BtnDiponibiliza"
        Me.BtnDiponibiliza.Size = New System.Drawing.Size(235, 26)
        Me.BtnDiponibiliza.TabIndex = 10
        Me.BtnDiponibiliza.Text = "Disponibilizar para Gravação"
        Me.BtnDiponibiliza.UseVisualStyleBackColor = True
        '
        'TxtSutilizado
        '
        Me.TxtSutilizado.Location = New System.Drawing.Point(137, 128)
        Me.TxtSutilizado.MaxLength = 20
        Me.TxtSutilizado.Name = "TxtSutilizado"
        Me.TxtSutilizado.Size = New System.Drawing.Size(117, 20)
        Me.TxtSutilizado.TabIndex = 8
        Me.TxtSutilizado.Text = "0,00"
        Me.TxtSutilizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSmaximo
        '
        Me.TxtSmaximo.Location = New System.Drawing.Point(137, 103)
        Me.TxtSmaximo.MaxLength = 20
        Me.TxtSmaximo.Name = "TxtSmaximo"
        Me.TxtSmaximo.Size = New System.Drawing.Size(117, 20)
        Me.TxtSmaximo.TabIndex = 7
        Me.TxtSmaximo.Text = "0,00"
        Me.TxtSmaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSMedio
        '
        Me.TxtSMedio.Location = New System.Drawing.Point(137, 79)
        Me.TxtSMedio.MaxLength = 20
        Me.TxtSMedio.Name = "TxtSMedio"
        Me.TxtSMedio.Size = New System.Drawing.Size(117, 20)
        Me.TxtSMedio.TabIndex = 6
        Me.TxtSMedio.Text = "0,00"
        Me.TxtSMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSB
        '
        Me.TxtSB.Location = New System.Drawing.Point(137, 54)
        Me.TxtSB.MaxLength = 20
        Me.TxtSB.Name = "TxtSB"
        Me.TxtSB.Size = New System.Drawing.Size(117, 20)
        Me.TxtSB.TabIndex = 5
        Me.TxtSB.Text = "0,00"
        Me.TxtSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Salário Utilizado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Salário Máximo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salário Médio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salário Base"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(15, 16)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(197, 24)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Registro para cadastro"
        '
        'frmFolha_salariosCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(993, 532)
        Me.Controls.Add(Me.GruEntradaSalarios)
        Me.Controls.Add(Me.GruShow)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "frmFolha_salariosCadastro"
        Me.Text = "FOLHA - Cadastramento de sálarios"
        Me.GruShow.ResumeLayout(False)
        Me.GruEntradaSalarios.ResumeLayout(False)
        Me.GruEntradaSalarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GruShow As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents GruEntradaSalarios As GroupBox
    Friend WithEvents TxtSutilizado As TextBox
    Friend WithEvents TxtSmaximo As TextBox
    Friend WithEvents TxtSMedio As TextBox
    Friend WithEvents TxtSB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents BtnGravar As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents BtnDiponibiliza As Button
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents MskDataInicio As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnTermina As Button
End Class
