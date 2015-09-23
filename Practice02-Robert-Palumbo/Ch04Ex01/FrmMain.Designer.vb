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
        Me.components = New System.ComponentModel.Container()
        Me.btnExitFrmMain = New System.Windows.Forms.Button()
        Me.tipMainApplFrmMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDistGrpDistFrmMain = New System.Windows.Forms.TextBox()
        Me.btnDriveGrpDistFrmMain = New System.Windows.Forms.Button()
        Me.txtTimeGrpSpeedTimeFrmMain = New System.Windows.Forms.TextBox()
        Me.txtSpeedGrpSpeedTimeFrmMain = New System.Windows.Forms.TextBox()
        Me.txtTrxLogFrmMain = New System.Windows.Forms.TextBox()
        Me.btnDriveGrSpeedTimeFrmMain = New System.Windows.Forms.Button()
        Me.lblAutoDriveSimFrmMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpDistFrmMain = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpOdometerFrmMain = New System.Windows.Forms.GroupBox()
        Me.txtOdometerGrpOdometerFrmMain = New System.Windows.Forms.TextBox()
        Me.grpDistFrmMain.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpOdometerFrmMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExitFrmMain
        '
        Me.btnExitFrmMain.Location = New System.Drawing.Point(300, 509)
        Me.btnExitFrmMain.Name = "btnExitFrmMain"
        Me.btnExitFrmMain.Size = New System.Drawing.Size(75, 23)
        Me.btnExitFrmMain.TabIndex = 0
        Me.btnExitFrmMain.Text = "Exit"
        Me.btnExitFrmMain.UseVisualStyleBackColor = True
        '
        'txtDistGrpDistFrmMain
        '
        Me.txtDistGrpDistFrmMain.Location = New System.Drawing.Point(97, 33)
        Me.txtDistGrpDistFrmMain.Name = "txtDistGrpDistFrmMain"
        Me.txtDistGrpDistFrmMain.Size = New System.Drawing.Size(116, 20)
        Me.txtDistGrpDistFrmMain.TabIndex = 2
        Me.txtDistGrpDistFrmMain.Text = "0"
        Me.tipMainApplFrmMain.SetToolTip(Me.txtDistGrpDistFrmMain, "Enter miles to drive (ex: 150)")
        '
        'btnDriveGrpDistFrmMain
        '
        Me.btnDriveGrpDistFrmMain.Location = New System.Drawing.Point(87, 83)
        Me.btnDriveGrpDistFrmMain.Name = "btnDriveGrpDistFrmMain"
        Me.btnDriveGrpDistFrmMain.Size = New System.Drawing.Size(75, 26)
        Me.btnDriveGrpDistFrmMain.TabIndex = 3
        Me.btnDriveGrpDistFrmMain.Text = "Drive"
        Me.tipMainApplFrmMain.SetToolTip(Me.btnDriveGrpDistFrmMain, "Click to drive the specified distance")
        Me.btnDriveGrpDistFrmMain.UseVisualStyleBackColor = True
        '
        'txtTimeGrpSpeedTimeFrmMain
        '
        Me.txtTimeGrpSpeedTimeFrmMain.Location = New System.Drawing.Point(118, 55)
        Me.txtTimeGrpSpeedTimeFrmMain.Name = "txtTimeGrpSpeedTimeFrmMain"
        Me.txtTimeGrpSpeedTimeFrmMain.Size = New System.Drawing.Size(116, 20)
        Me.txtTimeGrpSpeedTimeFrmMain.TabIndex = 5
        Me.txtTimeGrpSpeedTimeFrmMain.Text = "0.0"
        Me.tipMainApplFrmMain.SetToolTip(Me.txtTimeGrpSpeedTimeFrmMain, "Enter drive time in hours (ex: 1.5)")
        '
        'txtSpeedGrpSpeedTimeFrmMain
        '
        Me.txtSpeedGrpSpeedTimeFrmMain.Location = New System.Drawing.Point(118, 29)
        Me.txtSpeedGrpSpeedTimeFrmMain.Name = "txtSpeedGrpSpeedTimeFrmMain"
        Me.txtSpeedGrpSpeedTimeFrmMain.Size = New System.Drawing.Size(116, 20)
        Me.txtSpeedGrpSpeedTimeFrmMain.TabIndex = 7
        Me.txtSpeedGrpSpeedTimeFrmMain.Text = "0"
        Me.tipMainApplFrmMain.SetToolTip(Me.txtSpeedGrpSpeedTimeFrmMain, "Enter speed in mph (ex: 60)")
        '
        'txtTrxLogFrmMain
        '
        Me.txtTrxLogFrmMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTrxLogFrmMain.ForeColor = System.Drawing.Color.Black
        Me.txtTrxLogFrmMain.Location = New System.Drawing.Point(85, 373)
        Me.txtTrxLogFrmMain.Multiline = True
        Me.txtTrxLogFrmMain.Name = "txtTrxLogFrmMain"
        Me.txtTrxLogFrmMain.ReadOnly = True
        Me.txtTrxLogFrmMain.Size = New System.Drawing.Size(514, 119)
        Me.txtTrxLogFrmMain.TabIndex = 9
        Me.tipMainApplFrmMain.SetToolTip(Me.txtTrxLogFrmMain, "Drive simulator transaction log")
        '
        'btnDriveGrSpeedTimeFrmMain
        '
        Me.btnDriveGrSpeedTimeFrmMain.Location = New System.Drawing.Point(102, 86)
        Me.btnDriveGrSpeedTimeFrmMain.Name = "btnDriveGrSpeedTimeFrmMain"
        Me.btnDriveGrSpeedTimeFrmMain.Size = New System.Drawing.Size(75, 23)
        Me.btnDriveGrSpeedTimeFrmMain.TabIndex = 11
        Me.btnDriveGrSpeedTimeFrmMain.Text = "Drive"
        Me.tipMainApplFrmMain.SetToolTip(Me.btnDriveGrSpeedTimeFrmMain, "Click to drive, distance will be calculated")
        Me.btnDriveGrSpeedTimeFrmMain.UseVisualStyleBackColor = True
        '
        'lblAutoDriveSimFrmMain
        '
        Me.lblAutoDriveSimFrmMain.AutoSize = True
        Me.lblAutoDriveSimFrmMain.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoDriveSimFrmMain.Location = New System.Drawing.Point(112, 38)
        Me.lblAutoDriveSimFrmMain.Name = "lblAutoDriveSimFrmMain"
        Me.lblAutoDriveSimFrmMain.Size = New System.Drawing.Size(450, 36)
        Me.lblAutoDriveSimFrmMain.TabIndex = 1
        Me.lblAutoDriveSimFrmMain.Text = "Automobile Driving Simulator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Miles to Drive"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time (hrs)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Speed (mph)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Simulator Log"
        '
        'grpDistFrmMain
        '
        Me.grpDistFrmMain.Controls.Add(Me.Label1)
        Me.grpDistFrmMain.Controls.Add(Me.txtDistGrpDistFrmMain)
        Me.grpDistFrmMain.Controls.Add(Me.btnDriveGrpDistFrmMain)
        Me.grpDistFrmMain.Location = New System.Drawing.Point(58, 101)
        Me.grpDistFrmMain.Name = "grpDistFrmMain"
        Me.grpDistFrmMain.Size = New System.Drawing.Size(237, 127)
        Me.grpDistFrmMain.TabIndex = 13
        Me.grpDistFrmMain.TabStop = False
        Me.grpDistFrmMain.Text = "Distance"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSpeedGrpSpeedTimeFrmMain)
        Me.GroupBox2.Controls.Add(Me.txtTimeGrpSpeedTimeFrmMain)
        Me.GroupBox2.Controls.Add(Me.btnDriveGrSpeedTimeFrmMain)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(355, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 127)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Speed/Time"
        '
        'grpOdometerFrmMain
        '
        Me.grpOdometerFrmMain.Controls.Add(Me.txtOdometerGrpOdometerFrmMain)
        Me.grpOdometerFrmMain.Location = New System.Drawing.Point(237, 247)
        Me.grpOdometerFrmMain.Name = "grpOdometerFrmMain"
        Me.grpOdometerFrmMain.Size = New System.Drawing.Size(200, 61)
        Me.grpOdometerFrmMain.TabIndex = 15
        Me.grpOdometerFrmMain.TabStop = False
        Me.grpOdometerFrmMain.Text = "Odometer"
        '
        'txtOdometerGrpOdometerFrmMain
        '
        Me.txtOdometerGrpOdometerFrmMain.AcceptsTab = True
        Me.txtOdometerGrpOdometerFrmMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOdometerGrpOdometerFrmMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOdometerGrpOdometerFrmMain.ForeColor = System.Drawing.SystemColors.Window
        Me.txtOdometerGrpOdometerFrmMain.Location = New System.Drawing.Point(50, 30)
        Me.txtOdometerGrpOdometerFrmMain.Name = "txtOdometerGrpOdometerFrmMain"
        Me.txtOdometerGrpOdometerFrmMain.ReadOnly = True
        Me.txtOdometerGrpOdometerFrmMain.Size = New System.Drawing.Size(100, 22)
        Me.txtOdometerGrpOdometerFrmMain.TabIndex = 0
        Me.txtOdometerGrpOdometerFrmMain.Text = "0"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 554)
        Me.Controls.Add(Me.grpOdometerFrmMain)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpDistFrmMain)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTrxLogFrmMain)
        Me.Controls.Add(Me.lblAutoDriveSimFrmMain)
        Me.Controls.Add(Me.btnExitFrmMain)
        Me.Name = "FrmMain"
        Me.Text = "Ch04Ex01"
        Me.grpDistFrmMain.ResumeLayout(False)
        Me.grpDistFrmMain.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOdometerFrmMain.ResumeLayout(False)
        Me.grpOdometerFrmMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExitFrmMain As Button
    Friend WithEvents tipMainApplFrmMain As ToolTip
    Friend WithEvents lblAutoDriveSimFrmMain As Label
    Friend WithEvents txtDistGrpDistFrmMain As TextBox
    Friend WithEvents btnDriveGrpDistFrmMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTimeGrpSpeedTimeFrmMain As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSpeedGrpSpeedTimeFrmMain As TextBox
    Friend WithEvents txtTrxLogFrmMain As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDriveGrSpeedTimeFrmMain As Button
    Friend WithEvents grpDistFrmMain As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grpOdometerFrmMain As GroupBox
    Friend WithEvents txtOdometerGrpOdometerFrmMain As TextBox
End Class
