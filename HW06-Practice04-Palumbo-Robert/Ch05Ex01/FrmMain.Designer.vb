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
        Me.lstSnowshoeRentPriceGrpPurch = New System.Windows.Forms.ListBox()
        Me.lstSnowshoeNameGrpPurch = New System.Windows.Forms.ListBox()
        Me.lstSnowshoePurchPriceGrpPurch = New System.Windows.Forms.ListBox()
        Me.grpTransLogFrmMain = New System.Windows.Forms.GroupBox()
        Me.txtTransLogFrmMain = New System.Windows.Forms.TextBox()
        Me.btnExitFrmMain = New System.Windows.Forms.Button()
        Me.nudNumPairsGrpPurch = New System.Windows.Forms.NumericUpDown()
        Me.chkRentalGrpPurch = New System.Windows.Forms.CheckBox()
        Me.nudRentalDaysGrpPurch = New System.Windows.Forms.NumericUpDown()
        Me.chkMemberGrpPurch = New System.Windows.Forms.CheckBox()
        Me.btnDispStoreInfo = New System.Windows.Forms.Button()
        Me.btnClearGrpPurch = New System.Windows.Forms.Button()
        Me.btnProcessTestData = New System.Windows.Forms.Button()
        Me.btnConfirmGrpPurch = New System.Windows.Forms.Button()
        Me.grpSnowShoeInfo = New System.Windows.Forms.GroupBox()
        Me.grpTransInfo = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransCntTotalGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtExtPriceTotalTransInfo = New System.Windows.Forms.TextBox()
        Me.txtMemDiscntCurrGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtMemDiscntTotalGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtPreTaxCurrGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtPreTaxTotalGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtTaxCurrGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtTaxTotalGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtTotalCostCurrGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtTotalCostTotalGrpTransInfo = New System.Windows.Forms.TextBox()
        Me.txtExtPriceCurrTransInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpPurch = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpTransLogFrmMain.SuspendLayout()
        CType(Me.nudNumPairsGrpPurch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRentalDaysGrpPurch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSnowShoeInfo.SuspendLayout()
        Me.grpTransInfo.SuspendLayout()
        Me.grpPurch.SuspendLayout()
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
        'lstSnowshoeRentPriceGrpPurch
        '
        Me.lstSnowshoeRentPriceGrpPurch.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoeRentPriceGrpPurch.Enabled = False
        Me.lstSnowshoeRentPriceGrpPurch.FormatString = "C2"
        Me.lstSnowshoeRentPriceGrpPurch.FormattingEnabled = True
        Me.lstSnowshoeRentPriceGrpPurch.Items.AddRange(New Object() {"15.00", "12.00", "10.00"})
        Me.lstSnowshoeRentPriceGrpPurch.Location = New System.Drawing.Point(354, 48)
        Me.lstSnowshoeRentPriceGrpPurch.Name = "lstSnowshoeRentPriceGrpPurch"
        Me.lstSnowshoeRentPriceGrpPurch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSnowshoeRentPriceGrpPurch.Size = New System.Drawing.Size(62, 95)
        Me.lstSnowshoeRentPriceGrpPurch.TabIndex = 5
        Me.lstSnowshoeRentPriceGrpPurch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstSnowshoeRentPriceGrpPurch, "Snowshoe rental price")
        '
        'lstSnowshoeNameGrpPurch
        '
        Me.lstSnowshoeNameGrpPurch.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoeNameGrpPurch.FormattingEnabled = True
        Me.lstSnowshoeNameGrpPurch.Items.AddRange(New Object() {"MSR Lightning Ascent", "Tubbs Mountaineer 30", "Atlas 1023 Elektra  (W)"})
        Me.lstSnowshoeNameGrpPurch.Location = New System.Drawing.Point(40, 49)
        Me.lstSnowshoeNameGrpPurch.Name = "lstSnowshoeNameGrpPurch"
        Me.lstSnowshoeNameGrpPurch.Size = New System.Drawing.Size(181, 95)
        Me.lstSnowshoeNameGrpPurch.TabIndex = 3
        Me.lstSnowshoeNameGrpPurch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstSnowshoeNameGrpPurch, "Select a snowshoe from the list")
        '
        'lstSnowshoePurchPriceGrpPurch
        '
        Me.lstSnowshoePurchPriceGrpPurch.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoePurchPriceGrpPurch.Enabled = False
        Me.lstSnowshoePurchPriceGrpPurch.FormatString = "C2"
        Me.lstSnowshoePurchPriceGrpPurch.FormattingEnabled = True
        Me.lstSnowshoePurchPriceGrpPurch.Items.AddRange(New Object() {"299.95", "259.95", "199.95"})
        Me.lstSnowshoePurchPriceGrpPurch.Location = New System.Drawing.Point(240, 48)
        Me.lstSnowshoePurchPriceGrpPurch.Name = "lstSnowshoePurchPriceGrpPurch"
        Me.lstSnowshoePurchPriceGrpPurch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSnowshoePurchPriceGrpPurch.Size = New System.Drawing.Size(90, 95)
        Me.lstSnowshoePurchPriceGrpPurch.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lstSnowshoePurchPriceGrpPurch, "Snowshoe purchase price")
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
        'nudNumPairsGrpPurch
        '
        Me.nudNumPairsGrpPurch.Location = New System.Drawing.Point(131, 163)
        Me.nudNumPairsGrpPurch.Name = "nudNumPairsGrpPurch"
        Me.nudNumPairsGrpPurch.ReadOnly = True
        Me.nudNumPairsGrpPurch.Size = New System.Drawing.Size(45, 20)
        Me.nudNumPairsGrpPurch.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.nudNumPairsGrpPurch, "Number of pair to purchase or rent")
        '
        'chkRentalGrpPurch
        '
        Me.chkRentalGrpPurch.AutoSize = True
        Me.chkRentalGrpPurch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkRentalGrpPurch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro
        Me.chkRentalGrpPurch.Location = New System.Drawing.Point(43, 194)
        Me.chkRentalGrpPurch.Name = "chkRentalGrpPurch"
        Me.chkRentalGrpPurch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRentalGrpPurch.Size = New System.Drawing.Size(55, 17)
        Me.chkRentalGrpPurch.TabIndex = 10
        Me.chkRentalGrpPurch.Text = "?Rent"
        Me.chkRentalGrpPurch.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.chkRentalGrpPurch, "Check if this is a rental transaction")
        Me.chkRentalGrpPurch.UseVisualStyleBackColor = True
        '
        'nudRentalDaysGrpPurch
        '
        Me.nudRentalDaysGrpPurch.Location = New System.Drawing.Point(182, 193)
        Me.nudRentalDaysGrpPurch.Name = "nudRentalDaysGrpPurch"
        Me.nudRentalDaysGrpPurch.ReadOnly = True
        Me.nudRentalDaysGrpPurch.Size = New System.Drawing.Size(43, 20)
        Me.nudRentalDaysGrpPurch.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.nudRentalDaysGrpPurch, "Enter number of days to rent")
        '
        'chkMemberGrpPurch
        '
        Me.chkMemberGrpPurch.AutoSize = True
        Me.chkMemberGrpPurch.Location = New System.Drawing.Point(197, 162)
        Me.chkMemberGrpPurch.Name = "chkMemberGrpPurch"
        Me.chkMemberGrpPurch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkMemberGrpPurch.Size = New System.Drawing.Size(133, 17)
        Me.chkMemberGrpPurch.TabIndex = 13
        Me.chkMemberGrpPurch.Text = "?MarketPlace Member"
        Me.ToolTip1.SetToolTip(Me.chkMemberGrpPurch, "Check if customer is a MarketPlace member")
        Me.chkMemberGrpPurch.UseVisualStyleBackColor = True
        '
        'btnDispStoreInfo
        '
        Me.btnDispStoreInfo.Location = New System.Drawing.Point(625, 324)
        Me.btnDispStoreInfo.Name = "btnDispStoreInfo"
        Me.btnDispStoreInfo.Size = New System.Drawing.Size(128, 23)
        Me.btnDispStoreInfo.TabIndex = 31
        Me.btnDispStoreInfo.Text = "Display &Store Info"
        Me.ToolTip1.SetToolTip(Me.btnDispStoreInfo, "Click to display current store information")
        Me.btnDispStoreInfo.UseVisualStyleBackColor = True
        '
        'btnClearGrpPurch
        '
        Me.btnClearGrpPurch.Location = New System.Drawing.Point(240, 235)
        Me.btnClearGrpPurch.Name = "btnClearGrpPurch"
        Me.btnClearGrpPurch.Size = New System.Drawing.Size(128, 23)
        Me.btnClearGrpPurch.TabIndex = 33
        Me.btnClearGrpPurch.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClearGrpPurch, "Click to clear input selections")
        Me.btnClearGrpPurch.UseVisualStyleBackColor = True
        '
        'btnProcessTestData
        '
        Me.btnProcessTestData.AutoSize = True
        Me.btnProcessTestData.Location = New System.Drawing.Point(183, 324)
        Me.btnProcessTestData.Name = "btnProcessTestData"
        Me.btnProcessTestData.Size = New System.Drawing.Size(128, 23)
        Me.btnProcessTestData.TabIndex = 34
        Me.btnProcessTestData.Text = "&ProcessTestData"
        Me.ToolTip1.SetToolTip(Me.btnProcessTestData, "Click to load test data into system")
        Me.btnProcessTestData.UseVisualStyleBackColor = True
        '
        'btnConfirmGrpPurch
        '
        Me.btnConfirmGrpPurch.Location = New System.Drawing.Point(93, 235)
        Me.btnConfirmGrpPurch.Name = "btnConfirmGrpPurch"
        Me.btnConfirmGrpPurch.Size = New System.Drawing.Size(128, 23)
        Me.btnConfirmGrpPurch.TabIndex = 34
        Me.btnConfirmGrpPurch.Text = "&Confirm"
        Me.ToolTip1.SetToolTip(Me.btnConfirmGrpPurch, "Click to confirm transaction")
        Me.btnConfirmGrpPurch.UseVisualStyleBackColor = True
        '
        'grpSnowShoeInfo
        '
        Me.grpSnowShoeInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSnowShoeInfo.Controls.Add(Me.btnProcessTestData)
        Me.grpSnowShoeInfo.Controls.Add(Me.grpTransInfo)
        Me.grpSnowShoeInfo.Controls.Add(Me.grpPurch)
        Me.grpSnowShoeInfo.Controls.Add(Me.btnDispStoreInfo)
        Me.grpSnowShoeInfo.Location = New System.Drawing.Point(39, 79)
        Me.grpSnowShoeInfo.Name = "grpSnowShoeInfo"
        Me.grpSnowShoeInfo.Size = New System.Drawing.Size(917, 372)
        Me.grpSnowShoeInfo.TabIndex = 3
        Me.grpSnowShoeInfo.TabStop = False
        Me.grpSnowShoeInfo.Text = "Snowshoe Info"
        '
        'grpTransInfo
        '
        Me.grpTransInfo.Controls.Add(Me.Label14)
        Me.grpTransInfo.Controls.Add(Me.Label8)
        Me.grpTransInfo.Controls.Add(Me.txtTransCntTotalGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtExtPriceTotalTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtMemDiscntCurrGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtMemDiscntTotalGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtPreTaxCurrGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtPreTaxTotalGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtTaxCurrGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtTaxTotalGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtTotalCostCurrGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtTotalCostTotalGrpTransInfo)
        Me.grpTransInfo.Controls.Add(Me.txtExtPriceCurrTransInfo)
        Me.grpTransInfo.Controls.Add(Me.Label7)
        Me.grpTransInfo.Controls.Add(Me.Label6)
        Me.grpTransInfo.Controls.Add(Me.Label5)
        Me.grpTransInfo.Controls.Add(Me.Label4)
        Me.grpTransInfo.Controls.Add(Me.Label3)
        Me.grpTransInfo.Controls.Add(Me.Label2)
        Me.grpTransInfo.Location = New System.Drawing.Point(510, 31)
        Me.grpTransInfo.Name = "grpTransInfo"
        Me.grpTransInfo.Size = New System.Drawing.Size(380, 271)
        Me.grpTransInfo.TabIndex = 32
        Me.grpTransInfo.TabStop = False
        Me.grpTransInfo.Text = "Transaction Info"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(292, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Current"
        '
        'txtTransCntTotalGrpTransInfo
        '
        Me.txtTransCntTotalGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTransCntTotalGrpTransInfo.Location = New System.Drawing.Point(169, 210)
        Me.txtTransCntTotalGrpTransInfo.Name = "txtTransCntTotalGrpTransInfo"
        Me.txtTransCntTotalGrpTransInfo.ReadOnly = True
        Me.txtTransCntTotalGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTransCntTotalGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTransCntTotalGrpTransInfo.TabIndex = 48
        '
        'txtExtPriceTotalTransInfo
        '
        Me.txtExtPriceTotalTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtExtPriceTotalTransInfo.Location = New System.Drawing.Point(249, 53)
        Me.txtExtPriceTotalTransInfo.Name = "txtExtPriceTotalTransInfo"
        Me.txtExtPriceTotalTransInfo.ReadOnly = True
        Me.txtExtPriceTotalTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExtPriceTotalTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtExtPriceTotalTransInfo.TabIndex = 47
        '
        'txtMemDiscntCurrGrpTransInfo
        '
        Me.txtMemDiscntCurrGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMemDiscntCurrGrpTransInfo.Location = New System.Drawing.Point(169, 78)
        Me.txtMemDiscntCurrGrpTransInfo.Name = "txtMemDiscntCurrGrpTransInfo"
        Me.txtMemDiscntCurrGrpTransInfo.ReadOnly = True
        Me.txtMemDiscntCurrGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMemDiscntCurrGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtMemDiscntCurrGrpTransInfo.TabIndex = 46
        '
        'txtMemDiscntTotalGrpTransInfo
        '
        Me.txtMemDiscntTotalGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMemDiscntTotalGrpTransInfo.Location = New System.Drawing.Point(249, 78)
        Me.txtMemDiscntTotalGrpTransInfo.Name = "txtMemDiscntTotalGrpTransInfo"
        Me.txtMemDiscntTotalGrpTransInfo.ReadOnly = True
        Me.txtMemDiscntTotalGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMemDiscntTotalGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtMemDiscntTotalGrpTransInfo.TabIndex = 45
        '
        'txtPreTaxCurrGrpTransInfo
        '
        Me.txtPreTaxCurrGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPreTaxCurrGrpTransInfo.Location = New System.Drawing.Point(169, 104)
        Me.txtPreTaxCurrGrpTransInfo.Name = "txtPreTaxCurrGrpTransInfo"
        Me.txtPreTaxCurrGrpTransInfo.ReadOnly = True
        Me.txtPreTaxCurrGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPreTaxCurrGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtPreTaxCurrGrpTransInfo.TabIndex = 44
        '
        'txtPreTaxTotalGrpTransInfo
        '
        Me.txtPreTaxTotalGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPreTaxTotalGrpTransInfo.Location = New System.Drawing.Point(249, 104)
        Me.txtPreTaxTotalGrpTransInfo.Name = "txtPreTaxTotalGrpTransInfo"
        Me.txtPreTaxTotalGrpTransInfo.ReadOnly = True
        Me.txtPreTaxTotalGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPreTaxTotalGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtPreTaxTotalGrpTransInfo.TabIndex = 43
        '
        'txtTaxCurrGrpTransInfo
        '
        Me.txtTaxCurrGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTaxCurrGrpTransInfo.Location = New System.Drawing.Point(169, 130)
        Me.txtTaxCurrGrpTransInfo.Name = "txtTaxCurrGrpTransInfo"
        Me.txtTaxCurrGrpTransInfo.ReadOnly = True
        Me.txtTaxCurrGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxCurrGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTaxCurrGrpTransInfo.TabIndex = 42
        '
        'txtTaxTotalGrpTransInfo
        '
        Me.txtTaxTotalGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTaxTotalGrpTransInfo.Location = New System.Drawing.Point(249, 130)
        Me.txtTaxTotalGrpTransInfo.Name = "txtTaxTotalGrpTransInfo"
        Me.txtTaxTotalGrpTransInfo.ReadOnly = True
        Me.txtTaxTotalGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxTotalGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTaxTotalGrpTransInfo.TabIndex = 41
        '
        'txtTotalCostCurrGrpTransInfo
        '
        Me.txtTotalCostCurrGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalCostCurrGrpTransInfo.Location = New System.Drawing.Point(169, 156)
        Me.txtTotalCostCurrGrpTransInfo.Name = "txtTotalCostCurrGrpTransInfo"
        Me.txtTotalCostCurrGrpTransInfo.ReadOnly = True
        Me.txtTotalCostCurrGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalCostCurrGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTotalCostCurrGrpTransInfo.TabIndex = 40
        '
        'txtTotalCostTotalGrpTransInfo
        '
        Me.txtTotalCostTotalGrpTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalCostTotalGrpTransInfo.Location = New System.Drawing.Point(249, 156)
        Me.txtTotalCostTotalGrpTransInfo.Name = "txtTotalCostTotalGrpTransInfo"
        Me.txtTotalCostTotalGrpTransInfo.ReadOnly = True
        Me.txtTotalCostTotalGrpTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalCostTotalGrpTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTotalCostTotalGrpTransInfo.TabIndex = 39
        '
        'txtExtPriceCurrTransInfo
        '
        Me.txtExtPriceCurrTransInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtExtPriceCurrTransInfo.Location = New System.Drawing.Point(169, 53)
        Me.txtExtPriceCurrTransInfo.Name = "txtExtPriceCurrTransInfo"
        Me.txtExtPriceCurrTransInfo.ReadOnly = True
        Me.txtExtPriceCurrTransInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExtPriceCurrTransInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtExtPriceCurrTransInfo.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Store Transaction Cnt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Total Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Pre-Tax Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Member Discount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Extended Price"
        '
        'grpPurch
        '
        Me.grpPurch.Controls.Add(Me.btnConfirmGrpPurch)
        Me.grpPurch.Controls.Add(Me.lstSnowshoeNameGrpPurch)
        Me.grpPurch.Controls.Add(Me.btnClearGrpPurch)
        Me.grpPurch.Controls.Add(Me.lstSnowshoePurchPriceGrpPurch)
        Me.grpPurch.Controls.Add(Me.lstSnowshoeRentPriceGrpPurch)
        Me.grpPurch.Controls.Add(Me.Label12)
        Me.grpPurch.Controls.Add(Me.nudNumPairsGrpPurch)
        Me.grpPurch.Controls.Add(Me.chkMemberGrpPurch)
        Me.grpPurch.Controls.Add(Me.chkRentalGrpPurch)
        Me.grpPurch.Controls.Add(Me.nudRentalDaysGrpPurch)
        Me.grpPurch.Controls.Add(Me.Label13)
        Me.grpPurch.Controls.Add(Me.Label9)
        Me.grpPurch.Controls.Add(Me.Label11)
        Me.grpPurch.Controls.Add(Me.Label10)
        Me.grpPurch.Location = New System.Drawing.Point(25, 31)
        Me.grpPurch.Name = "grpPurch"
        Me.grpPurch.Size = New System.Drawing.Size(449, 271)
        Me.grpPurch.TabIndex = 31
        Me.grpPurch.TabStop = False
        Me.grpPurch.Text = "Purchase Info"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Number of Pairs:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(111, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Rental Days"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Snowshoe Brand"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(251, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Purchase Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(351, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Rental Price"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1009, 702)
        Me.Controls.Add(Me.btnExitFrmMain)
        Me.Controls.Add(Me.grpTransLogFrmMain)
        Me.Controls.Add(Me.grpSnowShoeInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.Text = "Ch05Ex01 - Snowshoe MarketPlace"
        Me.ToolTip1.SetToolTip(Me, "Stock Market Portfolio Management")
        Me.grpTransLogFrmMain.ResumeLayout(False)
        Me.grpTransLogFrmMain.PerformLayout()
        CType(Me.nudNumPairsGrpPurch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRentalDaysGrpPurch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSnowShoeInfo.ResumeLayout(False)
        Me.grpSnowShoeInfo.PerformLayout()
        Me.grpTransInfo.ResumeLayout(False)
        Me.grpTransInfo.PerformLayout()
        Me.grpPurch.ResumeLayout(False)
        Me.grpPurch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpSnowShoeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstSnowshoeRentPriceGrpPurch As System.Windows.Forms.ListBox
    Friend WithEvents lstSnowshoeNameGrpPurch As System.Windows.Forms.ListBox
    Friend WithEvents lstSnowshoePurchPriceGrpPurch As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpTransLogFrmMain As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransLogFrmMain As System.Windows.Forms.TextBox
    Friend WithEvents btnExitFrmMain As System.Windows.Forms.Button
    Friend WithEvents chkRentalGrpPurch As System.Windows.Forms.CheckBox
    Friend WithEvents nudNumPairsGrpPurch As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkMemberGrpPurch As System.Windows.Forms.CheckBox
    Friend WithEvents nudRentalDaysGrpPurch As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpPurch As System.Windows.Forms.GroupBox
    Friend WithEvents btnProcessTestData As System.Windows.Forms.Button
    Friend WithEvents grpTransInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransCntTotalGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtExtPriceTotalTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtMemDiscntCurrGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtMemDiscntTotalGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtPreTaxCurrGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtPreTaxTotalGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxCurrGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxTotalGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCostCurrGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCostTotalGrpTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtExtPriceCurrTransInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmGrpPurch As System.Windows.Forms.Button
    Friend WithEvents btnClearGrpPurch As System.Windows.Forms.Button
    Friend WithEvents btnDispStoreInfo As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
