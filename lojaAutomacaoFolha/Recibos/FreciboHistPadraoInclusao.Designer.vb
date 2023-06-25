<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FreciboHistPadraoInclusao
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("F A V O R E C I D O", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("E M I S S O R", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("C A R A C T E R I S T I C A S", System.Windows.Forms.HorizontalAlignment.Left)
        Me.GrpMesa = New System.Windows.Forms.GroupBox()
        Me.TextReferencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCancelaEdicao = New System.Windows.Forms.Button()
        Me.LblResponsavel = New System.Windows.Forms.Label()
        Me.TxFuncao = New System.Windows.Forms.TextBox()
        Me.TxNome = New System.Windows.Forms.TextBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGravaHistorico = New System.Windows.Forms.Button()
        Me.RtHistorico = New System.Windows.Forms.RichTextBox()
        Me.LvParametros = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrpMesa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpMesa
        '
        Me.GrpMesa.Controls.Add(Me.TextReferencia)
        Me.GrpMesa.Controls.Add(Me.Label5)
        Me.GrpMesa.Controls.Add(Me.BtnCancelaEdicao)
        Me.GrpMesa.Controls.Add(Me.LblResponsavel)
        Me.GrpMesa.Controls.Add(Me.TxFuncao)
        Me.GrpMesa.Controls.Add(Me.TxNome)
        Me.GrpMesa.Controls.Add(Me.LblCodigo)
        Me.GrpMesa.Controls.Add(Me.Label4)
        Me.GrpMesa.Controls.Add(Me.Label3)
        Me.GrpMesa.Controls.Add(Me.Label2)
        Me.GrpMesa.Controls.Add(Me.Label1)
        Me.GrpMesa.Controls.Add(Me.BtnGravaHistorico)
        Me.GrpMesa.Controls.Add(Me.RtHistorico)
        Me.GrpMesa.Location = New System.Drawing.Point(3, 12)
        Me.GrpMesa.Name = "GrpMesa"
        Me.GrpMesa.Size = New System.Drawing.Size(761, 324)
        Me.GrpMesa.TabIndex = 2
        Me.GrpMesa.TabStop = False
        Me.GrpMesa.Text = "Cadastramento"
        '
        'TextReferencia
        '
        Me.TextReferencia.Location = New System.Drawing.Point(84, 77)
        Me.TextReferencia.Name = "TextReferencia"
        Me.TextReferencia.Size = New System.Drawing.Size(663, 20)
        Me.TextReferencia.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Referencia"
        '
        'BtnCancelaEdicao
        '
        Me.BtnCancelaEdicao.Location = New System.Drawing.Point(552, 272)
        Me.BtnCancelaEdicao.Name = "BtnCancelaEdicao"
        Me.BtnCancelaEdicao.Size = New System.Drawing.Size(92, 29)
        Me.BtnCancelaEdicao.TabIndex = 10
        Me.BtnCancelaEdicao.Text = "Cancela Edição"
        Me.BtnCancelaEdicao.UseVisualStyleBackColor = True
        '
        'LblResponsavel
        '
        Me.LblResponsavel.AutoSize = True
        Me.LblResponsavel.Location = New System.Drawing.Point(295, 27)
        Me.LblResponsavel.Name = "LblResponsavel"
        Me.LblResponsavel.Size = New System.Drawing.Size(13, 13)
        Me.LblResponsavel.TabIndex = 9
        Me.LblResponsavel.Text = "1"
        '
        'TxFuncao
        '
        Me.TxFuncao.Location = New System.Drawing.Point(84, 103)
        Me.TxFuncao.Name = "TxFuncao"
        Me.TxFuncao.Size = New System.Drawing.Size(663, 20)
        Me.TxFuncao.TabIndex = 8
        '
        'TxNome
        '
        Me.TxNome.Location = New System.Drawing.Point(83, 51)
        Me.TxNome.Name = "TxNome"
        Me.TxNome.Size = New System.Drawing.Size(124, 20)
        Me.TxNome.TabIndex = 7
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(81, 27)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(13, 13)
        Me.LblCodigo.TabIndex = 6
        Me.LblCodigo.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Responsável"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Função"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo"
        '
        'BtnGravaHistorico
        '
        Me.BtnGravaHistorico.Location = New System.Drawing.Point(650, 272)
        Me.BtnGravaHistorico.Name = "BtnGravaHistorico"
        Me.BtnGravaHistorico.Size = New System.Drawing.Size(92, 29)
        Me.BtnGravaHistorico.TabIndex = 1
        Me.BtnGravaHistorico.Text = "Gravar Histórico"
        Me.BtnGravaHistorico.UseVisualStyleBackColor = True
        '
        'RtHistorico
        '
        Me.RtHistorico.Location = New System.Drawing.Point(6, 138)
        Me.RtHistorico.Name = "RtHistorico"
        Me.RtHistorico.Size = New System.Drawing.Size(741, 128)
        Me.RtHistorico.TabIndex = 0
        Me.RtHistorico.Text = ""
        '
        'LvParametros
        '
        Me.LvParametros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LvParametros.FullRowSelect = True
        Me.LvParametros.GridLines = True
        ListViewGroup1.Header = "F A V O R E C I D O"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "E M I S S O R"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "C A R A C T E R I S T I C A S"
        ListViewGroup3.Name = "ListViewGroup3"
        Me.LvParametros.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.LvParametros.HideSelection = False
        Me.LvParametros.Location = New System.Drawing.Point(770, 21)
        Me.LvParametros.MultiSelect = False
        Me.LvParametros.Name = "LvParametros"
        Me.LvParametros.Size = New System.Drawing.Size(511, 576)
        Me.LvParametros.TabIndex = 3
        Me.LvParametros.UseCompatibleStateImageBehavior = False
        Me.LvParametros.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Código"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Descrição"
        Me.ColumnHeader7.Width = 441
        '
        'FreciboHistPadraoInclusao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 588)
        Me.Controls.Add(Me.LvParametros)
        Me.Controls.Add(Me.GrpMesa)
        Me.Name = "FreciboHistPadraoInclusao"
        Me.Text = "FreciboHistPadraoInclusao"
        Me.GrpMesa.ResumeLayout(False)
        Me.GrpMesa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpMesa As GroupBox
    Friend WithEvents BtnCancelaEdicao As Button
    Friend WithEvents LblResponsavel As Label
    Friend WithEvents TxFuncao As TextBox
    Friend WithEvents TxNome As TextBox
    Friend WithEvents LblCodigo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGravaHistorico As Button
    Friend WithEvents RtHistorico As RichTextBox
    Friend WithEvents TextReferencia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LvParametros As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
