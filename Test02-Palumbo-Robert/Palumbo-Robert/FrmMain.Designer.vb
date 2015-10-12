<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.txtTransLogFrmMain = New System.Windows.Forms.TextBox()
        Me.btnPrcTestDataFrmMain = New System.Windows.Forms.Button()
        Me.lblTransLogFrmMain = New System.Windows.Forms.Label()
        Me.btnExitFrmMain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTransLogFrmMain
        '
        Me.txtTransLogFrmMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransLogFrmMain.Location = New System.Drawing.Point(16, 62)
        Me.txtTransLogFrmMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTransLogFrmMain.Multiline = True
        Me.txtTransLogFrmMain.Name = "txtTransLogFrmMain"
        Me.txtTransLogFrmMain.ReadOnly = True
        Me.txtTransLogFrmMain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTransLogFrmMain.Size = New System.Drawing.Size(1155, 441)
        Me.txtTransLogFrmMain.TabIndex = 0
        '
        'btnPrcTestDataFrmMain
        '
        Me.btnPrcTestDataFrmMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrcTestDataFrmMain.Location = New System.Drawing.Point(322, 535)
        Me.btnPrcTestDataFrmMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrcTestDataFrmMain.Name = "btnPrcTestDataFrmMain"
        Me.btnPrcTestDataFrmMain.Size = New System.Drawing.Size(160, 28)
        Me.btnPrcTestDataFrmMain.TabIndex = 1
        Me.btnPrcTestDataFrmMain.Text = "Process Test Data"
        Me.btnPrcTestDataFrmMain.UseVisualStyleBackColor = True
        '
        'lblTransLogFrmMain
        '
        Me.lblTransLogFrmMain.AutoSize = True
        Me.lblTransLogFrmMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransLogFrmMain.Location = New System.Drawing.Point(13, 29)
        Me.lblTransLogFrmMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransLogFrmMain.Name = "lblTransLogFrmMain"
        Me.lblTransLogFrmMain.Size = New System.Drawing.Size(149, 16)
        Me.lblTransLogFrmMain.TabIndex = 3
        Me.lblTransLogFrmMain.Text = "Test02 Transaction Log"
        '
        'btnExitFrmMain
        '
        Me.btnExitFrmMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitFrmMain.Location = New System.Drawing.Point(543, 535)
        Me.btnExitFrmMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExitFrmMain.Name = "btnExitFrmMain"
        Me.btnExitFrmMain.Size = New System.Drawing.Size(160, 28)
        Me.btnExitFrmMain.TabIndex = 4
        Me.btnExitFrmMain.Text = "Exit"
        Me.btnExitFrmMain.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1178, 587)
        Me.Controls.Add(Me.btnExitFrmMain)
        Me.Controls.Add(Me.lblTransLogFrmMain)
        Me.Controls.Add(Me.btnPrcTestDataFrmMain)
        Me.Controls.Add(Me.txtTransLogFrmMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTransLogFrmMain As System.Windows.Forms.TextBox
    Friend WithEvents btnPrcTestDataFrmMain As System.Windows.Forms.Button
    Friend WithEvents lblTransLogFrmMain As System.Windows.Forms.Label
    Friend WithEvents btnExitFrmMain As System.Windows.Forms.Button

End Class
