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
        Me.lstSnowshoeRentPriceGrpTransDetail = New System.Windows.Forms.ListBox()
        Me.lstSnowshoeNameGrpTransDetail = New System.Windows.Forms.ListBox()
        Me.lstSnowshoePurchPriceGrpTransDetail = New System.Windows.Forms.ListBox()
        Me.grpTransLogFrmMain = New System.Windows.Forms.GroupBox()
        Me.txtTransLogFrmMain = New System.Windows.Forms.TextBox()
        Me.btnExitFrmMain = New System.Windows.Forms.Button()
        Me.nudPairsCntGrpTransDetail = New System.Windows.Forms.NumericUpDown()
        Me.chkIsRentalGrpTransDetail = New System.Windows.Forms.CheckBox()
        Me.nudRentalDaysGrpTransDetail = New System.Windows.Forms.NumericUpDown()
        Me.chkIsMemberGrpTransDetail = New System.Windows.Forms.CheckBox()
        Me.btnDispStoreInfo = New System.Windows.Forms.Button()
        Me.btnClearGrpTransDetail = New System.Windows.Forms.Button()
        Me.btnProcessTestData = New System.Windows.Forms.Button()
        Me.btnConfirmGrpTransDetail = New System.Windows.Forms.Button()
        Me.grpSnowShoeInfo = New System.Windows.Forms.GroupBox()
        Me.grpSummaryInfo = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransCntTotalGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtExtPriceTotalGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtMemDiscntCurrGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtMemDiscntTotalGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtPreTaxCurrGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtPreTaxTotalGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtTaxCurrGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtTaxTotalGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtTotalCostCurrGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtTotalCostTotalGrpSummaryInfo = New System.Windows.Forms.TextBox()
        Me.txtExtPriceCurrTransSummaryInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpTransDetail = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpTransLogFrmMain.SuspendLayout()
        CType(Me.nudPairsCntGrpTransDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRentalDaysGrpTransDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSnowShoeInfo.SuspendLayout()
        Me.grpSummaryInfo.SuspendLayout()
        Me.grpTransDetail.SuspendLayout()
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
        'lstSnowshoeRentPriceGrpTransDetail
        '
        Me.lstSnowshoeRentPriceGrpTransDetail.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoeRentPriceGrpTransDetail.Enabled = False
        Me.lstSnowshoeRentPriceGrpTransDetail.FormatString = "C2"
        Me.lstSnowshoeRentPriceGrpTransDetail.FormattingEnabled = True
        Me.lstSnowshoeRentPriceGrpTransDetail.Items.AddRange(New Object() {"15.00", "12.00", "10.00"})
        Me.lstSnowshoeRentPriceGrpTransDetail.Location = New System.Drawing.Point(354, 48)
        Me.lstSnowshoeRentPriceGrpTransDetail.Name = "lstSnowshoeRentPriceGrpTransDetail"
        Me.lstSnowshoeRentPriceGrpTransDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSnowshoeRentPriceGrpTransDetail.Size = New System.Drawing.Size(62, 95)
        Me.lstSnowshoeRentPriceGrpTransDetail.TabIndex = 5
        Me.lstSnowshoeRentPriceGrpTransDetail.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstSnowshoeRentPriceGrpTransDetail, "Snowshoe rental price")
        '
        'lstSnowshoeNameGrpTransDetail
        '
        Me.lstSnowshoeNameGrpTransDetail.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoeNameGrpTransDetail.FormattingEnabled = True
        Me.lstSnowshoeNameGrpTransDetail.Items.AddRange(New Object() {"MSR Lightning Ascent", "Tubbs Mountaineer 30", "Atlas 1023 Elektra  (W)"})
        Me.lstSnowshoeNameGrpTransDetail.Location = New System.Drawing.Point(40, 49)
        Me.lstSnowshoeNameGrpTransDetail.Name = "lstSnowshoeNameGrpTransDetail"
        Me.lstSnowshoeNameGrpTransDetail.Size = New System.Drawing.Size(181, 95)
        Me.lstSnowshoeNameGrpTransDetail.TabIndex = 3
        Me.lstSnowshoeNameGrpTransDetail.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstSnowshoeNameGrpTransDetail, "Select a snowshoe from the list")
        '
        'lstSnowshoePurchPriceGrpTransDetail
        '
        Me.lstSnowshoePurchPriceGrpTransDetail.BackColor = System.Drawing.SystemColors.Control
        Me.lstSnowshoePurchPriceGrpTransDetail.Enabled = False
        Me.lstSnowshoePurchPriceGrpTransDetail.FormatString = "C2"
        Me.lstSnowshoePurchPriceGrpTransDetail.FormattingEnabled = True
        Me.lstSnowshoePurchPriceGrpTransDetail.Items.AddRange(New Object() {"299.95", "259.95", "199.95"})
        Me.lstSnowshoePurchPriceGrpTransDetail.Location = New System.Drawing.Point(240, 48)
        Me.lstSnowshoePurchPriceGrpTransDetail.Name = "lstSnowshoePurchPriceGrpTransDetail"
        Me.lstSnowshoePurchPriceGrpTransDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSnowshoePurchPriceGrpTransDetail.Size = New System.Drawing.Size(90, 95)
        Me.lstSnowshoePurchPriceGrpTransDetail.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lstSnowshoePurchPriceGrpTransDetail, "Snowshoe purchase price")
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
        'nudPairsCntGrpTransDetail
        '
        Me.nudPairsCntGrpTransDetail.Location = New System.Drawing.Point(131, 163)
        Me.nudPairsCntGrpTransDetail.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPairsCntGrpTransDetail.Name = "nudPairsCntGrpTransDetail"
        Me.nudPairsCntGrpTransDetail.ReadOnly = True
        Me.nudPairsCntGrpTransDetail.Size = New System.Drawing.Size(45, 20)
        Me.nudPairsCntGrpTransDetail.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.nudPairsCntGrpTransDetail, "Number of pair to purchase or rent")
        Me.nudPairsCntGrpTransDetail.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkIsRentalGrpTransDetail
        '
        Me.chkIsRentalGrpTransDetail.AutoSize = True
        Me.chkIsRentalGrpTransDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkIsRentalGrpTransDetail.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro
        Me.chkIsRentalGrpTransDetail.Location = New System.Drawing.Point(43, 194)
        Me.chkIsRentalGrpTransDetail.Name = "chkIsRentalGrpTransDetail"
        Me.chkIsRentalGrpTransDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsRentalGrpTransDetail.Size = New System.Drawing.Size(55, 17)
        Me.chkIsRentalGrpTransDetail.TabIndex = 10
        Me.chkIsRentalGrpTransDetail.Text = "?Rent"
        Me.chkIsRentalGrpTransDetail.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.chkIsRentalGrpTransDetail, "Check if this is a rental transaction")
        Me.chkIsRentalGrpTransDetail.UseVisualStyleBackColor = True
        '
        'nudRentalDaysGrpTransDetail
        '
        Me.nudRentalDaysGrpTransDetail.Location = New System.Drawing.Point(182, 193)
        Me.nudRentalDaysGrpTransDetail.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRentalDaysGrpTransDetail.Name = "nudRentalDaysGrpTransDetail"
        Me.nudRentalDaysGrpTransDetail.ReadOnly = True
        Me.nudRentalDaysGrpTransDetail.Size = New System.Drawing.Size(43, 20)
        Me.nudRentalDaysGrpTransDetail.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.nudRentalDaysGrpTransDetail, "Enter number of days to rent")
        Me.nudRentalDaysGrpTransDetail.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkIsMemberGrpTransDetail
        '
        Me.chkIsMemberGrpTransDetail.AutoSize = True
        Me.chkIsMemberGrpTransDetail.Location = New System.Drawing.Point(197, 164)
        Me.chkIsMemberGrpTransDetail.Name = "chkIsMemberGrpTransDetail"
        Me.chkIsMemberGrpTransDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsMemberGrpTransDetail.Size = New System.Drawing.Size(133, 17)
        Me.chkIsMemberGrpTransDetail.TabIndex = 13
        Me.chkIsMemberGrpTransDetail.Text = "?MarketPlace Member"
        Me.ToolTip1.SetToolTip(Me.chkIsMemberGrpTransDetail, "Check if customer is a MarketPlace member")
        Me.chkIsMemberGrpTransDetail.UseVisualStyleBackColor = True
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
        'btnClearGrpTransDetail
        '
        Me.btnClearGrpTransDetail.Location = New System.Drawing.Point(240, 235)
        Me.btnClearGrpTransDetail.Name = "btnClearGrpTransDetail"
        Me.btnClearGrpTransDetail.Size = New System.Drawing.Size(128, 23)
        Me.btnClearGrpTransDetail.TabIndex = 33
        Me.btnClearGrpTransDetail.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClearGrpTransDetail, "Click to clear input selections")
        Me.btnClearGrpTransDetail.UseVisualStyleBackColor = True
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
        'btnConfirmGrpTransDetail
        '
        Me.btnConfirmGrpTransDetail.Location = New System.Drawing.Point(93, 235)
        Me.btnConfirmGrpTransDetail.Name = "btnConfirmGrpTransDetail"
        Me.btnConfirmGrpTransDetail.Size = New System.Drawing.Size(128, 23)
        Me.btnConfirmGrpTransDetail.TabIndex = 34
        Me.btnConfirmGrpTransDetail.Text = "&Confirm"
        Me.ToolTip1.SetToolTip(Me.btnConfirmGrpTransDetail, "Click to confirm transaction")
        Me.btnConfirmGrpTransDetail.UseVisualStyleBackColor = True
        '
        'grpSnowShoeInfo
        '
        Me.grpSnowShoeInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSnowShoeInfo.Controls.Add(Me.btnProcessTestData)
        Me.grpSnowShoeInfo.Controls.Add(Me.grpSummaryInfo)
        Me.grpSnowShoeInfo.Controls.Add(Me.grpTransDetail)
        Me.grpSnowShoeInfo.Controls.Add(Me.btnDispStoreInfo)
        Me.grpSnowShoeInfo.Location = New System.Drawing.Point(39, 79)
        Me.grpSnowShoeInfo.Name = "grpSnowShoeInfo"
        Me.grpSnowShoeInfo.Size = New System.Drawing.Size(917, 372)
        Me.grpSnowShoeInfo.TabIndex = 3
        Me.grpSnowShoeInfo.TabStop = False
        Me.grpSnowShoeInfo.Text = "Snowshoe Info"
        '
        'grpSummaryInfo
        '
        Me.grpSummaryInfo.Controls.Add(Me.Label14)
        Me.grpSummaryInfo.Controls.Add(Me.Label8)
        Me.grpSummaryInfo.Controls.Add(Me.txtTransCntTotalGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtExtPriceTotalGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtMemDiscntCurrGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtMemDiscntTotalGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtPreTaxCurrGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtPreTaxTotalGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtTaxCurrGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtTaxTotalGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtTotalCostCurrGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtTotalCostTotalGrpSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.txtExtPriceCurrTransSummaryInfo)
        Me.grpSummaryInfo.Controls.Add(Me.Label7)
        Me.grpSummaryInfo.Controls.Add(Me.Label6)
        Me.grpSummaryInfo.Controls.Add(Me.Label5)
        Me.grpSummaryInfo.Controls.Add(Me.Label4)
        Me.grpSummaryInfo.Controls.Add(Me.Label3)
        Me.grpSummaryInfo.Controls.Add(Me.Label2)
        Me.grpSummaryInfo.Location = New System.Drawing.Point(510, 31)
        Me.grpSummaryInfo.Name = "grpSummaryInfo"
        Me.grpSummaryInfo.Size = New System.Drawing.Size(380, 271)
        Me.grpSummaryInfo.TabIndex = 32
        Me.grpSummaryInfo.TabStop = False
        Me.grpSummaryInfo.Text = "Summary Info"
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
        'txtTransCntTotalGrpSummaryInfo
        '
        Me.txtTransCntTotalGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTransCntTotalGrpSummaryInfo.Location = New System.Drawing.Point(169, 210)
        Me.txtTransCntTotalGrpSummaryInfo.Name = "txtTransCntTotalGrpSummaryInfo"
        Me.txtTransCntTotalGrpSummaryInfo.ReadOnly = True
        Me.txtTransCntTotalGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTransCntTotalGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTransCntTotalGrpSummaryInfo.TabIndex = 48
        '
        'txtExtPriceTotalGrpSummaryInfo
        '
        Me.txtExtPriceTotalGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtExtPriceTotalGrpSummaryInfo.Location = New System.Drawing.Point(249, 53)
        Me.txtExtPriceTotalGrpSummaryInfo.Name = "txtExtPriceTotalGrpSummaryInfo"
        Me.txtExtPriceTotalGrpSummaryInfo.ReadOnly = True
        Me.txtExtPriceTotalGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExtPriceTotalGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtExtPriceTotalGrpSummaryInfo.TabIndex = 47
        '
        'txtMemDiscntCurrGrpSummaryInfo
        '
        Me.txtMemDiscntCurrGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMemDiscntCurrGrpSummaryInfo.Location = New System.Drawing.Point(169, 78)
        Me.txtMemDiscntCurrGrpSummaryInfo.Name = "txtMemDiscntCurrGrpSummaryInfo"
        Me.txtMemDiscntCurrGrpSummaryInfo.ReadOnly = True
        Me.txtMemDiscntCurrGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMemDiscntCurrGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtMemDiscntCurrGrpSummaryInfo.TabIndex = 46
        '
        'txtMemDiscntTotalGrpSummaryInfo
        '
        Me.txtMemDiscntTotalGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMemDiscntTotalGrpSummaryInfo.Location = New System.Drawing.Point(249, 78)
        Me.txtMemDiscntTotalGrpSummaryInfo.Name = "txtMemDiscntTotalGrpSummaryInfo"
        Me.txtMemDiscntTotalGrpSummaryInfo.ReadOnly = True
        Me.txtMemDiscntTotalGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMemDiscntTotalGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtMemDiscntTotalGrpSummaryInfo.TabIndex = 45
        '
        'txtPreTaxCurrGrpSummaryInfo
        '
        Me.txtPreTaxCurrGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPreTaxCurrGrpSummaryInfo.Location = New System.Drawing.Point(169, 104)
        Me.txtPreTaxCurrGrpSummaryInfo.Name = "txtPreTaxCurrGrpSummaryInfo"
        Me.txtPreTaxCurrGrpSummaryInfo.ReadOnly = True
        Me.txtPreTaxCurrGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPreTaxCurrGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtPreTaxCurrGrpSummaryInfo.TabIndex = 44
        '
        'txtPreTaxTotalGrpSummaryInfo
        '
        Me.txtPreTaxTotalGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPreTaxTotalGrpSummaryInfo.Location = New System.Drawing.Point(249, 104)
        Me.txtPreTaxTotalGrpSummaryInfo.Name = "txtPreTaxTotalGrpSummaryInfo"
        Me.txtPreTaxTotalGrpSummaryInfo.ReadOnly = True
        Me.txtPreTaxTotalGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPreTaxTotalGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtPreTaxTotalGrpSummaryInfo.TabIndex = 43
        '
        'txtTaxCurrGrpSummaryInfo
        '
        Me.txtTaxCurrGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTaxCurrGrpSummaryInfo.Location = New System.Drawing.Point(169, 130)
        Me.txtTaxCurrGrpSummaryInfo.Name = "txtTaxCurrGrpSummaryInfo"
        Me.txtTaxCurrGrpSummaryInfo.ReadOnly = True
        Me.txtTaxCurrGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxCurrGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTaxCurrGrpSummaryInfo.TabIndex = 42
        '
        'txtTaxTotalGrpSummaryInfo
        '
        Me.txtTaxTotalGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTaxTotalGrpSummaryInfo.Location = New System.Drawing.Point(249, 130)
        Me.txtTaxTotalGrpSummaryInfo.Name = "txtTaxTotalGrpSummaryInfo"
        Me.txtTaxTotalGrpSummaryInfo.ReadOnly = True
        Me.txtTaxTotalGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxTotalGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTaxTotalGrpSummaryInfo.TabIndex = 41
        '
        'txtTotalCostCurrGrpSummaryInfo
        '
        Me.txtTotalCostCurrGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalCostCurrGrpSummaryInfo.Location = New System.Drawing.Point(169, 156)
        Me.txtTotalCostCurrGrpSummaryInfo.Name = "txtTotalCostCurrGrpSummaryInfo"
        Me.txtTotalCostCurrGrpSummaryInfo.ReadOnly = True
        Me.txtTotalCostCurrGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalCostCurrGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTotalCostCurrGrpSummaryInfo.TabIndex = 40
        '
        'txtTotalCostTotalGrpSummaryInfo
        '
        Me.txtTotalCostTotalGrpSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalCostTotalGrpSummaryInfo.Location = New System.Drawing.Point(249, 156)
        Me.txtTotalCostTotalGrpSummaryInfo.Name = "txtTotalCostTotalGrpSummaryInfo"
        Me.txtTotalCostTotalGrpSummaryInfo.ReadOnly = True
        Me.txtTotalCostTotalGrpSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalCostTotalGrpSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtTotalCostTotalGrpSummaryInfo.TabIndex = 39
        '
        'txtExtPriceCurrTransSummaryInfo
        '
        Me.txtExtPriceCurrTransSummaryInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtExtPriceCurrTransSummaryInfo.Location = New System.Drawing.Point(169, 53)
        Me.txtExtPriceCurrTransSummaryInfo.Name = "txtExtPriceCurrTransSummaryInfo"
        Me.txtExtPriceCurrTransSummaryInfo.ReadOnly = True
        Me.txtExtPriceCurrTransSummaryInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExtPriceCurrTransSummaryInfo.Size = New System.Drawing.Size(74, 20)
        Me.txtExtPriceCurrTransSummaryInfo.TabIndex = 38
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
        'grpTransDetail
        '
        Me.grpTransDetail.Controls.Add(Me.btnConfirmGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.lstSnowshoeNameGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.btnClearGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.lstSnowshoePurchPriceGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.lstSnowshoeRentPriceGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.Label12)
        Me.grpTransDetail.Controls.Add(Me.nudPairsCntGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.chkIsMemberGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.chkIsRentalGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.nudRentalDaysGrpTransDetail)
        Me.grpTransDetail.Controls.Add(Me.Label13)
        Me.grpTransDetail.Controls.Add(Me.Label9)
        Me.grpTransDetail.Controls.Add(Me.Label11)
        Me.grpTransDetail.Controls.Add(Me.Label10)
        Me.grpTransDetail.Location = New System.Drawing.Point(25, 31)
        Me.grpTransDetail.Name = "grpTransDetail"
        Me.grpTransDetail.Size = New System.Drawing.Size(449, 271)
        Me.grpTransDetail.TabIndex = 31
        Me.grpTransDetail.TabStop = False
        Me.grpTransDetail.Text = "Transaction Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 165)
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
        CType(Me.nudPairsCntGrpTransDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRentalDaysGrpTransDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSnowShoeInfo.ResumeLayout(False)
        Me.grpSnowShoeInfo.PerformLayout()
        Me.grpSummaryInfo.ResumeLayout(False)
        Me.grpSummaryInfo.PerformLayout()
        Me.grpTransDetail.ResumeLayout(False)
        Me.grpTransDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpSnowShoeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstSnowshoeRentPriceGrpTransDetail As System.Windows.Forms.ListBox
    Friend WithEvents lstSnowshoeNameGrpTransDetail As System.Windows.Forms.ListBox
    Friend WithEvents lstSnowshoePurchPriceGrpTransDetail As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpTransLogFrmMain As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransLogFrmMain As System.Windows.Forms.TextBox
    Friend WithEvents btnExitFrmMain As System.Windows.Forms.Button
    Friend WithEvents chkIsRentalGrpTransDetail As System.Windows.Forms.CheckBox
    Friend WithEvents nudPairsCntGrpTransDetail As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkIsMemberGrpTransDetail As System.Windows.Forms.CheckBox
    Friend WithEvents nudRentalDaysGrpTransDetail As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpTransDetail As System.Windows.Forms.GroupBox
    Friend WithEvents btnProcessTestData As System.Windows.Forms.Button
    Friend WithEvents grpSummaryInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransCntTotalGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtExtPriceTotalGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtMemDiscntCurrGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtMemDiscntTotalGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtPreTaxCurrGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtPreTaxTotalGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxCurrGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxTotalGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCostCurrGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCostTotalGrpSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtExtPriceCurrTransSummaryInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmGrpTransDetail As System.Windows.Forms.Button
    Friend WithEvents btnClearGrpTransDetail As System.Windows.Forms.Button
    Friend WithEvents btnDispStoreInfo As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
