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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstSnowshoeRentPrice = New System.Windows.Forms.ListBox()
        Me.lstSnowshoeName = New System.Windows.Forms.ListBox()
        Me.lstSnowshoePurchPrice = New System.Windows.Forms.ListBox()
        Me.grpTransLogFrmMain = New System.Windows.Forms.GroupBox()
        Me.txtTransLogFrmMain = New System.Windows.Forms.TextBox()
        Me.btnExitFrmMain = New System.Windows.Forms.Button()
        Me.btnRunTestData = New System.Windows.Forms.Button()
        Me.nudNumPairs = New System.Windows.Forms.NumericUpDown()
        Me.chkRental = New System.Windows.Forms.CheckBox()
        Me.btnDispStoreInfo = New System.Windows.Forms.Button()
        Me.nudRentalDays = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.grpSnowShoeInfo = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpTransLogFrmMain.SuspendLayout()
        CType(Me.nudNumPairs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRentalDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSnowShoeInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(346, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Snowshoe MarketPlace"
        '
        'lstSnowshoeRentPrice
        '
        Me.lstSnowshoeRentPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoeRentPrice.Enabled = False
        Me.lstSnowshoeRentPrice.FormatString = "C2"
        Me.lstSnowshoeRentPrice.FormattingEnabled = True
        Me.lstSnowshoeRentPrice.Location = New System.Drawing.Point(308, 58)
        Me.lstSnowshoeRentPrice.Name = "lstSnowshoeRentPrice"
        Me.lstSnowshoeRentPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSnowshoeRentPrice.Size = New System.Drawing.Size(62, 95)
        Me.lstSnowshoeRentPrice.TabIndex = 5
        Me.lstSnowshoeRentPrice.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstSnowshoeRentPrice, "Snowshoe rental price")
        '
        'lstSnowshoeName
        '
        Me.lstSnowshoeName.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoeName.Enabled = False
        Me.lstSnowshoeName.FormattingEnabled = True
        Me.lstSnowshoeName.Location = New System.Drawing.Point(25, 58)
        Me.lstSnowshoeName.Name = "lstSnowshoeName"
        Me.lstSnowshoeName.Size = New System.Drawing.Size(181, 95)
        Me.lstSnowshoeName.TabIndex = 3
        Me.lstSnowshoeName.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstSnowshoeName, "Select a snowshoe from the list")
        '
        'lstSnowshoePurchPrice
        '
        Me.lstSnowshoePurchPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoePurchPrice.Enabled = False
        Me.lstSnowshoePurchPrice.FormatString = "C2"
        Me.lstSnowshoePurchPrice.FormattingEnabled = True
        Me.lstSnowshoePurchPrice.Location = New System.Drawing.Point(212, 58)
        Me.lstSnowshoePurchPrice.Name = "lstSnowshoePurchPrice"
        Me.lstSnowshoePurchPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSnowshoePurchPrice.Size = New System.Drawing.Size(90, 95)
        Me.lstSnowshoePurchPrice.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lstSnowshoePurchPrice, "Snowshoe purchase price")
        '
        'grpTransLogFrmMain
        '
        Me.grpTransLogFrmMain.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpTransLogFrmMain.Controls.Add(Me.txtTransLogFrmMain)
        Me.grpTransLogFrmMain.Location = New System.Drawing.Point(39, 471)
        Me.grpTransLogFrmMain.Name = "grpTransLogFrmMain"
        Me.grpTransLogFrmMain.Size = New System.Drawing.Size(917, 187)
        Me.grpTransLogFrmMain.TabIndex = 5
        Me.grpTransLogFrmMain.TabStop = False
        Me.grpTransLogFrmMain.Text = "Transaction Log"
        Me.ToolTip1.SetToolTip(Me.grpTransLogFrmMain, "System transaction log")
        '
        'txtTransLogFrmMain
        '
        Me.txtTransLogFrmMain.Location = New System.Drawing.Point(26, 19)
        Me.txtTransLogFrmMain.Multiline = True
        Me.txtTransLogFrmMain.Name = "txtTransLogFrmMain"
        Me.txtTransLogFrmMain.ReadOnly = True
        Me.txtTransLogFrmMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTransLogFrmMain.Size = New System.Drawing.Size(864, 148)
        Me.txtTransLogFrmMain.TabIndex = 0
        Me.txtTransLogFrmMain.TabStop = False
        '
        'btnExitFrmMain
        '
        Me.btnExitFrmMain.Location = New System.Drawing.Point(462, 667)
        Me.btnExitFrmMain.Name = "btnExitFrmMain"
        Me.btnExitFrmMain.Size = New System.Drawing.Size(75, 23)
        Me.btnExitFrmMain.TabIndex = 6
        Me.btnExitFrmMain.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExitFrmMain, "Click to close and exit the system")
        Me.btnExitFrmMain.UseVisualStyleBackColor = True
        '
        'btnRunTestData
        '
        Me.btnRunTestData.Location = New System.Drawing.Point(865, 20)
        Me.btnRunTestData.Name = "btnRunTestData"
        Me.btnRunTestData.Size = New System.Drawing.Size(111, 23)
        Me.btnRunTestData.TabIndex = 7
        Me.btnRunTestData.Text = "&Run Test-Data"
        Me.ToolTip1.SetToolTip(Me.btnRunTestData, "Click to run test data simulation")
        Me.btnRunTestData.UseVisualStyleBackColor = True
        '
        'nudNumPairs
        '
        Me.nudNumPairs.Location = New System.Drawing.Point(113, 174)
        Me.nudNumPairs.Name = "nudNumPairs"
        Me.nudNumPairs.Size = New System.Drawing.Size(68, 20)
        Me.nudNumPairs.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.nudNumPairs, "Number of pair to purchase or rent")
        '
        'chkRental
        '
        Me.chkRental.AutoSize = True
        Me.chkRental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkRental.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro
        Me.chkRental.Location = New System.Drawing.Point(212, 175)
        Me.chkRental.Name = "chkRental"
        Me.chkRental.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRental.Size = New System.Drawing.Size(55, 17)
        Me.chkRental.TabIndex = 10
        Me.chkRental.Text = "?Rent"
        Me.chkRental.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.chkRental, "Check if this is a rental transaction")
        Me.chkRental.UseVisualStyleBackColor = True
        '
        'btnDispStoreInfo
        '
        Me.btnDispStoreInfo.Location = New System.Drawing.Point(335, 226)
        Me.btnDispStoreInfo.Name = "btnDispStoreInfo"
        Me.btnDispStoreInfo.Size = New System.Drawing.Size(128, 23)
        Me.btnDispStoreInfo.TabIndex = 8
        Me.btnDispStoreInfo.Text = "Display &Store Info"
        Me.ToolTip1.SetToolTip(Me.btnDispStoreInfo, "Click to display current store information")
        Me.btnDispStoreInfo.UseVisualStyleBackColor = True
        '
        'nudRentalDays
        '
        Me.nudRentalDays.Location = New System.Drawing.Point(352, 172)
        Me.nudRentalDays.Name = "nudRentalDays"
        Me.nudRentalDays.Size = New System.Drawing.Size(68, 20)
        Me.nudRentalDays.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.nudRentalDays, "Enter number of days to rent")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(25, 204)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "?MarketPlace Member"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Check if customer is a MarketPlace member")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grpSnowShoeInfo
        '
        Me.grpSnowShoeInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSnowShoeInfo.Controls.Add(Me.CheckBox1)
        Me.grpSnowShoeInfo.Controls.Add(Me.nudRentalDays)
        Me.grpSnowShoeInfo.Controls.Add(Me.Label13)
        Me.grpSnowShoeInfo.Controls.Add(Me.chkRental)
        Me.grpSnowShoeInfo.Controls.Add(Me.nudNumPairs)
        Me.grpSnowShoeInfo.Controls.Add(Me.btnDispStoreInfo)
        Me.grpSnowShoeInfo.Controls.Add(Me.Label12)
        Me.grpSnowShoeInfo.Controls.Add(Me.Label11)
        Me.grpSnowShoeInfo.Controls.Add(Me.Label10)
        Me.grpSnowShoeInfo.Controls.Add(Me.Label9)
        Me.grpSnowShoeInfo.Controls.Add(Me.lstSnowshoeRentPrice)
        Me.grpSnowShoeInfo.Controls.Add(Me.lstSnowshoeName)
        Me.grpSnowShoeInfo.Controls.Add(Me.lstSnowshoePurchPrice)
        Me.grpSnowShoeInfo.Location = New System.Drawing.Point(65, 79)
        Me.grpSnowShoeInfo.Name = "grpSnowShoeInfo"
        Me.grpSnowShoeInfo.Size = New System.Drawing.Size(823, 372)
        Me.grpSnowShoeInfo.TabIndex = 3
        Me.grpSnowShoeInfo.TabStop = False
        Me.grpSnowShoeInfo.Text = "Snowshoe Info"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(281, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Rental Days"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Number of Pairs:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(223, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Purchase Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(308, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Rental Price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Snowshoe Brand"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1009, 702)
        Me.Controls.Add(Me.btnRunTestData)
        Me.Controls.Add(Me.btnExitFrmMain)
        Me.Controls.Add(Me.grpTransLogFrmMain)
        Me.Controls.Add(Me.grpSnowShoeInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.Text = "Ch04Ex01 - Snowshoe MarketPlace"
        Me.ToolTip1.SetToolTip(Me, "Stock Market Portfolio Management")
        Me.grpTransLogFrmMain.ResumeLayout(False)
        Me.grpTransLogFrmMain.PerformLayout()
        CType(Me.nudNumPairs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRentalDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSnowShoeInfo.ResumeLayout(False)
        Me.grpSnowShoeInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpSnowShoeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstSnowshoeRentPrice As System.Windows.Forms.ListBox
    Friend WithEvents lstSnowshoeName As System.Windows.Forms.ListBox
    Friend WithEvents lstSnowshoePurchPrice As System.Windows.Forms.ListBox
    Friend WithEvents btnDispStoreInfo As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpTransLogFrmMain As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransLogFrmMain As System.Windows.Forms.TextBox
    Friend WithEvents btnExitFrmMain As System.Windows.Forms.Button
    Friend WithEvents btnRunTestData As System.Windows.Forms.Button
    Friend WithEvents chkRental As System.Windows.Forms.CheckBox
    Friend WithEvents nudNumPairs As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents nudRentalDays As System.Windows.Forms.NumericUpDown

End Class
