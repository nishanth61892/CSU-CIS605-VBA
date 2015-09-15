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
        Me.mnuMainApplMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuOptFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptFileImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptFileExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptView = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblThemeParkMgmtSys = New System.Windows.Forms.Label()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tabCustTbcMain = New System.Windows.Forms.TabPage()
        Me.grpCustInfoTcbMain = New System.Windows.Forms.GroupBox()
        Me.lblCustIdGrpCustInfoTcbMain = New System.Windows.Forms.Label()
        Me.tabFeatTbcMain = New System.Windows.Forms.TabPage()
        Me.txtCustIdGrpCustInfoTcbMain = New System.Windows.Forms.TextBox()
        Me.lblCustNameGrpCustInfoTcbMain = New System.Windows.Forms.Label()
        Me.txtCustNameGrpCustInfoTcbMain = New System.Windows.Forms.TextBox()
        Me.mnuMainApplMenu.SuspendLayout()
        Me.tbcMain.SuspendLayout()
        Me.tabCustTbcMain.SuspendLayout()
        Me.grpCustInfoTcbMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMainApplMenu
        '
        Me.mnuMainApplMenu.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.mnuMainApplMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMainApplMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptFile, Me.mnuOptEdit, Me.mnuOptView, Me.mnuOptHelp})
        Me.mnuMainApplMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainApplMenu.Name = "mnuMainApplMenu"
        Me.mnuMainApplMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuMainApplMenu.Size = New System.Drawing.Size(1275, 25)
        Me.mnuMainApplMenu.TabIndex = 0
        Me.mnuMainApplMenu.Text = "MenuStrip1"
        '
        'mnuOptFile
        '
        Me.mnuOptFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptFileSave, Me.mnuOptFileImport, Me.mnuOptFileExport, Me.ExitToolStripMenuItem})
        Me.mnuOptFile.Name = "mnuOptFile"
        Me.mnuOptFile.Size = New System.Drawing.Size(40, 21)
        Me.mnuOptFile.Text = "&File"
        Me.mnuOptFile.ToolTipText = "Save Session"
        '
        'mnuOptFileSave
        '
        Me.mnuOptFileSave.Name = "mnuOptFileSave"
        Me.mnuOptFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuOptFileSave.Size = New System.Drawing.Size(149, 22)
        Me.mnuOptFileSave.Text = "Save"
        Me.mnuOptFileSave.ToolTipText = "Save Session"
        '
        'mnuOptFileImport
        '
        Me.mnuOptFileImport.Name = "mnuOptFileImport"
        Me.mnuOptFileImport.Size = New System.Drawing.Size(149, 22)
        Me.mnuOptFileImport.Text = "Import"
        Me.mnuOptFileImport.ToolTipText = "Import Data"
        '
        'mnuOptFileExport
        '
        Me.mnuOptFileExport.Name = "mnuOptFileExport"
        Me.mnuOptFileExport.Size = New System.Drawing.Size(149, 22)
        Me.mnuOptFileExport.Text = "Export"
        Me.mnuOptFileExport.ToolTipText = "Export Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'mnuOptEdit
        '
        Me.mnuOptEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptEditCut, Me.mnuOptEditCopy, Me.mnuOptEditPaste})
        Me.mnuOptEdit.Name = "mnuOptEdit"
        Me.mnuOptEdit.Size = New System.Drawing.Size(43, 21)
        Me.mnuOptEdit.Text = "&Edit"
        '
        'mnuOptEditCut
        '
        Me.mnuOptEditCut.Name = "mnuOptEditCut"
        Me.mnuOptEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuOptEditCut.Size = New System.Drawing.Size(155, 22)
        Me.mnuOptEditCut.Text = "Cut"
        '
        'mnuOptEditCopy
        '
        Me.mnuOptEditCopy.Name = "mnuOptEditCopy"
        Me.mnuOptEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuOptEditCopy.Size = New System.Drawing.Size(155, 22)
        Me.mnuOptEditCopy.Text = "Copy"
        '
        'mnuOptEditPaste
        '
        Me.mnuOptEditPaste.Name = "mnuOptEditPaste"
        Me.mnuOptEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuOptEditPaste.Size = New System.Drawing.Size(155, 22)
        Me.mnuOptEditPaste.Text = "Paste"
        '
        'mnuOptView
        '
        Me.mnuOptView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryToolStripMenuItem, Me.TransactionLogToolStripMenuItem})
        Me.mnuOptView.Name = "mnuOptView"
        Me.mnuOptView.Size = New System.Drawing.Size(48, 21)
        Me.mnuOptView.Text = "&View"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'TransactionLogToolStripMenuItem
        '
        Me.TransactionLogToolStripMenuItem.Name = "TransactionLogToolStripMenuItem"
        Me.TransactionLogToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.TransactionLogToolStripMenuItem.Text = "Transaction Log"
        '
        'mnuOptHelp
        '
        Me.mnuOptHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptHelpAbout})
        Me.mnuOptHelp.Name = "mnuOptHelp"
        Me.mnuOptHelp.Size = New System.Drawing.Size(48, 21)
        Me.mnuOptHelp.Text = "&Help"
        '
        'mnuOptHelpAbout
        '
        Me.mnuOptHelpAbout.AutoToolTip = True
        Me.mnuOptHelpAbout.Name = "mnuOptHelpAbout"
        Me.mnuOptHelpAbout.Size = New System.Drawing.Size(279, 22)
        Me.mnuOptHelpAbout.Text = "About Theme Park Mgmt System"
        '
        'lblThemeParkMgmtSys
        '
        Me.lblThemeParkMgmtSys.AutoSize = True
        Me.lblThemeParkMgmtSys.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThemeParkMgmtSys.ForeColor = System.Drawing.Color.Maroon
        Me.lblThemeParkMgmtSys.Location = New System.Drawing.Point(283, 71)
        Me.lblThemeParkMgmtSys.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThemeParkMgmtSys.Name = "lblThemeParkMgmtSys"
        Me.lblThemeParkMgmtSys.Size = New System.Drawing.Size(521, 38)
        Me.lblThemeParkMgmtSys.TabIndex = 1
        Me.lblThemeParkMgmtSys.Text = "Theme Park Management System"
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabCustTbcMain)
        Me.tbcMain.Controls.Add(Me.tabFeatTbcMain)
        Me.tbcMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcMain.Location = New System.Drawing.Point(48, 125)
        Me.tbcMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1112, 533)
        Me.tbcMain.TabIndex = 2
        '
        'tabCustTbcMain
        '
        Me.tabCustTbcMain.BackColor = System.Drawing.Color.Transparent
        Me.tabCustTbcMain.Controls.Add(Me.grpCustInfoTcbMain)
        Me.tabCustTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabCustTbcMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCustTbcMain.Name = "tabCustTbcMain"
        Me.tabCustTbcMain.Padding = New System.Windows.Forms.Padding(4)
        Me.tabCustTbcMain.Size = New System.Drawing.Size(1104, 504)
        Me.tabCustTbcMain.TabIndex = 0
        Me.tabCustTbcMain.Text = "Customer"
        '
        'grpCustInfoTcbMain
        '
        Me.grpCustInfoTcbMain.Controls.Add(Me.txtCustNameGrpCustInfoTcbMain)
        Me.grpCustInfoTcbMain.Controls.Add(Me.lblCustNameGrpCustInfoTcbMain)
        Me.grpCustInfoTcbMain.Controls.Add(Me.txtCustIdGrpCustInfoTcbMain)
        Me.grpCustInfoTcbMain.Controls.Add(Me.lblCustIdGrpCustInfoTcbMain)
        Me.grpCustInfoTcbMain.Location = New System.Drawing.Point(69, 61)
        Me.grpCustInfoTcbMain.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCustInfoTcbMain.Name = "grpCustInfoTcbMain"
        Me.grpCustInfoTcbMain.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCustInfoTcbMain.Size = New System.Drawing.Size(422, 258)
        Me.grpCustInfoTcbMain.TabIndex = 0
        Me.grpCustInfoTcbMain.TabStop = False
        Me.grpCustInfoTcbMain.Text = "Customer Info"
        '
        'lblCustIdGrpCustInfoTcbMain
        '
        Me.lblCustIdGrpCustInfoTcbMain.AutoSize = True
        Me.lblCustIdGrpCustInfoTcbMain.Location = New System.Drawing.Point(39, 63)
        Me.lblCustIdGrpCustInfoTcbMain.Name = "lblCustIdGrpCustInfoTcbMain"
        Me.lblCustIdGrpCustInfoTcbMain.Size = New System.Drawing.Size(84, 16)
        Me.lblCustIdGrpCustInfoTcbMain.TabIndex = 0
        Me.lblCustIdGrpCustInfoTcbMain.Text = "Customer ID:"
        '
        'tabFeatTbcMain
        '
        Me.tabFeatTbcMain.BackColor = System.Drawing.Color.Gainsboro
        Me.tabFeatTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabFeatTbcMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFeatTbcMain.Name = "tabFeatTbcMain"
        Me.tabFeatTbcMain.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFeatTbcMain.Size = New System.Drawing.Size(1104, 504)
        Me.tabFeatTbcMain.TabIndex = 1
        Me.tabFeatTbcMain.Text = "Features"
        '
        'txtCustIdGrpCustInfoTcbMain
        '
        Me.txtCustIdGrpCustInfoTcbMain.Location = New System.Drawing.Point(129, 60)
        Me.txtCustIdGrpCustInfoTcbMain.Name = "txtCustIdGrpCustInfoTcbMain"
        Me.txtCustIdGrpCustInfoTcbMain.Size = New System.Drawing.Size(183, 22)
        Me.txtCustIdGrpCustInfoTcbMain.TabIndex = 1
        '
        'lblCustNameGrpCustInfoTcbMain
        '
        Me.lblCustNameGrpCustInfoTcbMain.AutoSize = True
        Me.lblCustNameGrpCustInfoTcbMain.Location = New System.Drawing.Point(15, 100)
        Me.lblCustNameGrpCustInfoTcbMain.Name = "lblCustNameGrpCustInfoTcbMain"
        Me.lblCustNameGrpCustInfoTcbMain.Size = New System.Drawing.Size(108, 16)
        Me.lblCustNameGrpCustInfoTcbMain.TabIndex = 2
        Me.lblCustNameGrpCustInfoTcbMain.Text = "Customer Name:"
        '
        'txtCustNameGrpCustInfoTcbMain
        '
        Me.txtCustNameGrpCustInfoTcbMain.Location = New System.Drawing.Point(129, 95)
        Me.txtCustNameGrpCustInfoTcbMain.Name = "txtCustNameGrpCustInfoTcbMain"
        Me.txtCustNameGrpCustInfoTcbMain.Size = New System.Drawing.Size(249, 22)
        Me.txtCustNameGrpCustInfoTcbMain.TabIndex = 3
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1275, 736)
        Me.Controls.Add(Me.tbcMain)
        Me.Controls.Add(Me.lblThemeParkMgmtSys)
        Me.Controls.Add(Me.mnuMainApplMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuMainApplMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.Text = "Theme Park Management System"
        Me.mnuMainApplMenu.ResumeLayout(False)
        Me.mnuMainApplMenu.PerformLayout()
        Me.tbcMain.ResumeLayout(False)
        Me.tabCustTbcMain.ResumeLayout(False)
        Me.grpCustInfoTcbMain.ResumeLayout(False)
        Me.grpCustInfoTcbMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainApplMenu As MenuStrip
    Friend WithEvents mnuOptFile As ToolStripMenuItem
    Friend WithEvents mnuOptFileSave As ToolStripMenuItem
    Friend WithEvents mnuOptFileImport As ToolStripMenuItem
    Friend WithEvents mnuOptFileExport As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuOptEdit As ToolStripMenuItem
    Friend WithEvents mnuOptEditCut As ToolStripMenuItem
    Friend WithEvents mnuOptEditCopy As ToolStripMenuItem
    Friend WithEvents mnuOptEditPaste As ToolStripMenuItem
    Friend WithEvents mnuOptView As ToolStripMenuItem
    Friend WithEvents mnuOptHelp As ToolStripMenuItem
    Friend WithEvents mnuOptHelpAbout As ToolStripMenuItem
    Friend WithEvents lblThemeParkMgmtSys As Label
    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tabCustTbcMain As TabPage
    Friend WithEvents tabFeatTbcMain As TabPage
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpCustInfoTcbMain As GroupBox
    Friend WithEvents lblCustIdGrpCustInfoTcbMain As Label
    Friend WithEvents txtCustNameGrpCustInfoTcbMain As TextBox
    Friend WithEvents lblCustNameGrpCustInfoTcbMain As Label
    Friend WithEvents txtCustIdGrpCustInfoTcbMain As TextBox
End Class
