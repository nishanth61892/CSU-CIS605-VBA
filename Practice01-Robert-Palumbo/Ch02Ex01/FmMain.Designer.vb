<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMain
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
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.dtpBirthdayDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthdayDate = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblProgramOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(140, 24)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(200, 23)
        Me.txtUserName.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(37, 30)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(83, 17)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "User &Name:"
        '
        'dtpBirthdayDate
        '
        Me.dtpBirthdayDate.Location = New System.Drawing.Point(140, 62)
        Me.dtpBirthdayDate.Name = "dtpBirthdayDate"
        Me.dtpBirthdayDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirthdayDate.TabIndex = 2
        '
        'lblBirthdayDate
        '
        Me.lblBirthdayDate.AutoSize = True
        Me.lblBirthdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdayDate.Location = New System.Drawing.Point(37, 64)
        Me.lblBirthdayDate.Name = "lblBirthdayDate"
        Me.lblBirthdayDate.Size = New System.Drawing.Size(60, 17)
        Me.lblBirthdayDate.TabIndex = 0
        Me.lblBirthdayDate.Text = "&Birthday"
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(48, 270)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(150, 269)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(255, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblProgramOutput
        '
        Me.lblProgramOutput.AutoSize = True
        Me.lblProgramOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProgramOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramOutput.Location = New System.Drawing.Point(40, 126)
        Me.lblProgramOutput.MinimumSize = New System.Drawing.Size(300, 100)
        Me.lblProgramOutput.Name = "lblProgramOutput"
        Me.lblProgramOutput.Size = New System.Drawing.Size(300, 100)
        Me.lblProgramOutput.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 319)
        Me.Controls.Add(Me.lblProgramOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblBirthdayDate)
        Me.Controls.Add(Me.dtpBirthdayDate)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserName)
        Me.Name = "frmMain"
        Me.Text = "Ch02Ex01"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents dtpBirthdayDate As DateTimePicker
    Friend WithEvents lblBirthdayDate As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblProgramOutput As Label
End Class
