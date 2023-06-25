<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCrstalTeste1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpEndCid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpEndBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpCNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpregadorAcaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnGeraDiretorios = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpregadorAcaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Emp, Me.EmpEnd, Me.EmpEndCid, Me.EmpEndBairro, Me.Cep, Me.UF, Me.EmpCNPJ})
        Me.DataGridView1.DataSource = Me.EmpregadorAcaoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(763, 114)
        Me.DataGridView1.TabIndex = 0
        '
        'Emp
        '
        Me.Emp.HeaderText = "Empresa"
        Me.Emp.Name = "Emp"
        '
        'EmpEnd
        '
        Me.EmpEnd.HeaderText = "Endereço"
        Me.EmpEnd.Name = "EmpEnd"
        '
        'EmpEndCid
        '
        Me.EmpEndCid.HeaderText = "Cidade"
        Me.EmpEndCid.Name = "EmpEndCid"
        '
        'EmpEndBairro
        '
        Me.EmpEndBairro.HeaderText = "Bairro"
        Me.EmpEndBairro.Name = "EmpEndBairro"
        '
        'Cep
        '
        Me.Cep.HeaderText = "Cep"
        Me.Cep.Name = "Cep"
        '
        'UF
        '
        Me.UF.HeaderText = "EmpEndUF"
        Me.UF.Name = "UF"
        '
        'EmpCNPJ
        '
        Me.EmpCNPJ.HeaderText = "CNPJ"
        Me.EmpCNPJ.Name = "EmpCNPJ"
        '
        'EmpregadorAcaoBindingSource
        '
        Me.EmpregadorAcaoBindingSource.DataSource = GetType(lojaAutomacaoFolha.EmpregadorAcao)
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Column1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(12, 199)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1279, 214)
        Me.ListBox1.TabIndex = 2
        '
        'BtnGeraDiretorios
        '
        Me.BtnGeraDiretorios.Location = New System.Drawing.Point(160, 511)
        Me.BtnGeraDiretorios.Name = "BtnGeraDiretorios"
        Me.BtnGeraDiretorios.Size = New System.Drawing.Size(118, 46)
        Me.BtnGeraDiretorios.TabIndex = 3
        Me.BtnGeraDiretorios.Text = "Gera Diretorios"
        Me.BtnGeraDiretorios.UseVisualStyleBackColor = True
        '
        'formCrstalTeste1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 559)
        Me.Controls.Add(Me.BtnGeraDiretorios)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formCrstalTeste1"
        Me.Text = "formCrstalTeste1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpregadorAcaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents Emp As DataGridViewTextBoxColumn
    Friend WithEvents EmpEnd As DataGridViewTextBoxColumn
    Friend WithEvents EmpEndCid As DataGridViewTextBoxColumn
    Friend WithEvents EmpEndBairro As DataGridViewTextBoxColumn
    Friend WithEvents Cep As DataGridViewTextBoxColumn
    Friend WithEvents UF As DataGridViewTextBoxColumn
    Friend WithEvents EmpCNPJ As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents EmpregadorAcaoBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnGeraDiretorios As Button
End Class
