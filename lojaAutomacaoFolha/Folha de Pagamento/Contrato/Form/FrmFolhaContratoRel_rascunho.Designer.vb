<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaContratoRel_rascunho
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
        Me.ReportClientDocumentWrapper1 = New CrystalDecisions.ReportAppServer.ReportClientDocumentWrapper()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Rrecibo1 = New lojaAutomacaoFolha.Rrecibo()
        Me.folhaRescisao1 = New lojaAutomacaoFolha.folhaRescisao()
        Me.SuspendLayout()
        '
        'ReportClientDocumentWrapper1
        '
        Me.ReportClientDocumentWrapper1.DocumentUri = ""
        Me.ReportClientDocumentWrapper1.ReportAppServer = Nothing
        Me.ReportClientDocumentWrapper1.UriIsUserEditable = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 512)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'FrmFolhaContratoRel_rascunho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmFolhaContratoRel_rascunho"
        Me.Text = "FrmFolhaContratoRel_rascunho"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportClientDocumentWrapper1 As CrystalDecisions.ReportAppServer.ReportClientDocumentWrapper
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Rrecibo1 As Rrecibo
    Friend WithEvents folhaRescisao1 As folhaRescisao
End Class
