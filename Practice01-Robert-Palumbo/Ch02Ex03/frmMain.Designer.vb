<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim lstInvItems As System.Windows.Forms.ListBox
        Me.tabInvMgmtSystem = New System.Windows.Forms.TabControl()
        Me.tabpInvList = New System.Windows.Forms.TabPage()
        Me.lblInvList = New System.Windows.Forms.Label()
        Me.tabpInvMgmt = New System.Windows.Forms.TabPage()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grpInvMgmtAdd = New System.Windows.Forms.GroupBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.updQty = New System.Windows.Forms.NumericUpDown()
        Me.lblItemList = New System.Windows.Forms.Label()
        Me.cboInvItem = New System.Windows.Forms.ComboBox()
        Me.lblInvMgr = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuOptionFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionFileLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionInvList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionInvAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionInvRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainAppl = New System.Windows.Forms.MenuStrip()
        Me.btnAdd = New System.Windows.Forms.Button()
        lstInvItems = New System.Windows.Forms.ListBox()
        Me.tabInvMgmtSystem.SuspendLayout()
        Me.tabpInvList.SuspendLayout()
        Me.tabpInvMgmt.SuspendLayout()
        Me.grpInvMgmtAdd.SuspendLayout()
        CType(Me.updQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMainAppl.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstInvItems
        '
        lstInvItems.FormattingEnabled = True
        lstInvItems.ImeMode = System.Windows.Forms.ImeMode.Off
        lstInvItems.ItemHeight = 16
        lstInvItems.Items.AddRange(New Object() {"Air Cleaners", "Air Filters", "Air Fresheners", "Anti Freeze", "Batteries", "Brake Pads", "Car Polish", "Car Wax", "Floor Mats", "Fogl-ights", "Fuel Filters", "Head-lights", "Mirrors", "Mufflers", "Oil", "Oil Filters", "Power Steering Fluid", "Radiators", "Spark Plugs", "Tail-lights", "Tires", "Touchup Paint", "Transmission Fluid", "Wiper Blades"})
        lstInvItems.Location = New System.Drawing.Point(81, 58)
        lstInvItems.Name = "lstInvItems"
        lstInvItems.Size = New System.Drawing.Size(309, 260)
        lstInvItems.Sorted = True
        lstInvItems.TabIndex = 0
        '
        'tabInvMgmtSystem
        '
        Me.tabInvMgmtSystem.Controls.Add(Me.tabpInvList)
        Me.tabInvMgmtSystem.Controls.Add(Me.tabpInvMgmt)
        Me.tabInvMgmtSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabInvMgmtSystem.Location = New System.Drawing.Point(97, 98)
        Me.tabInvMgmtSystem.Name = "tabInvMgmtSystem"
        Me.tabInvMgmtSystem.SelectedIndex = 0
        Me.tabInvMgmtSystem.Size = New System.Drawing.Size(530, 373)
        Me.tabInvMgmtSystem.TabIndex = 0
        '
        'tabpInvList
        '
        Me.tabpInvList.Controls.Add(Me.lblInvList)
        Me.tabpInvList.Controls.Add(lstInvItems)
        Me.tabpInvList.Location = New System.Drawing.Point(4, 25)
        Me.tabpInvList.Name = "tabpInvList"
        Me.tabpInvList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpInvList.Size = New System.Drawing.Size(522, 344)
        Me.tabpInvList.TabIndex = 0
        Me.tabpInvList.Text = "Inventory List"
        Me.tabpInvList.UseVisualStyleBackColor = True
        '
        'lblInvList
        '
        Me.lblInvList.AutoSize = True
        Me.lblInvList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvList.Location = New System.Drawing.Point(77, 23)
        Me.lblInvList.Name = "lblInvList"
        Me.lblInvList.Size = New System.Drawing.Size(134, 20)
        Me.lblInvList.TabIndex = 1
        Me.lblInvList.Text = "Items in Inventory"
        '
        'tabpInvMgmt
        '
        Me.tabpInvMgmt.Controls.Add(Me.btnRemove)
        Me.tabpInvMgmt.Controls.Add(Me.grpInvMgmtAdd)
        Me.tabpInvMgmt.Controls.Add(Me.lblItemList)
        Me.tabpInvMgmt.Controls.Add(Me.cboInvItem)
        Me.tabpInvMgmt.Location = New System.Drawing.Point(4, 25)
        Me.tabpInvMgmt.Name = "tabpInvMgmt"
        Me.tabpInvMgmt.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpInvMgmt.Size = New System.Drawing.Size(522, 344)
        Me.tabpInvMgmt.TabIndex = 1
        Me.tabpInvMgmt.Text = "Inventory Managment"
        Me.tabpInvMgmt.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(364, 139)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 32)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'grpInvMgmtAdd
        '
        Me.grpInvMgmtAdd.Controls.Add(Me.btnAdd)
        Me.grpInvMgmtAdd.Controls.Add(Me.lblQty)
        Me.grpInvMgmtAdd.Controls.Add(Me.updQty)
        Me.grpInvMgmtAdd.Location = New System.Drawing.Point(50, 118)
        Me.grpInvMgmtAdd.Name = "grpInvMgmtAdd"
        Me.grpInvMgmtAdd.Size = New System.Drawing.Size(276, 150)
        Me.grpInvMgmtAdd.TabIndex = 2
        Me.grpInvMgmtAdd.TabStop = False
        Me.grpInvMgmtAdd.Text = "Add"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(56, 48)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(34, 17)
        Me.lblQty.TabIndex = 7
        Me.lblQty.Text = "&Qty:"
        '
        'updQty
        '
        Me.updQty.Location = New System.Drawing.Point(96, 46)
        Me.updQty.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updQty.Name = "updQty"
        Me.updQty.Size = New System.Drawing.Size(120, 23)
        Me.updQty.TabIndex = 6
        '
        'lblItemList
        '
        Me.lblItemList.AutoSize = True
        Me.lblItemList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemList.Location = New System.Drawing.Point(47, 57)
        Me.lblItemList.Name = "lblItemList"
        Me.lblItemList.Size = New System.Drawing.Size(38, 17)
        Me.lblItemList.TabIndex = 1
        Me.lblItemList.Text = "Item:"
        '
        'cboInvItem
        '
        Me.cboInvItem.FormattingEnabled = True
        Me.cboInvItem.Location = New System.Drawing.Point(95, 54)
        Me.cboInvItem.Name = "cboInvItem"
        Me.cboInvItem.Size = New System.Drawing.Size(231, 24)
        Me.cboInvItem.TabIndex = 0
        '
        'lblInvMgr
        '
        Me.lblInvMgr.AutoSize = True
        Me.lblInvMgr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvMgr.Location = New System.Drawing.Point(257, 48)
        Me.lblInvMgr.Name = "lblInvMgr"
        Me.lblInvMgr.Size = New System.Drawing.Size(227, 29)
        Me.lblInvMgr.TabIndex = 1
        Me.lblInvMgr.Text = "Inventory Manager"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(325, 508)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mnuOptionFile
        '
        Me.mnuOptionFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionFileLoad, Me.mnuOptionFileSave, Me.mnuOptionFileExit})
        Me.mnuOptionFile.Name = "mnuOptionFile"
        Me.mnuOptionFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuOptionFile.Text = "&File"
        '
        'mnuOptionFileLoad
        '
        Me.mnuOptionFileLoad.Name = "mnuOptionFileLoad"
        Me.mnuOptionFileLoad.Size = New System.Drawing.Size(132, 22)
        Me.mnuOptionFileLoad.Text = "Load"
        '
        'mnuOptionFileSave
        '
        Me.mnuOptionFileSave.Name = "mnuOptionFileSave"
        Me.mnuOptionFileSave.Size = New System.Drawing.Size(132, 22)
        Me.mnuOptionFileSave.Text = "Save"
        '
        'mnuOptionFileExit
        '
        Me.mnuOptionFileExit.Name = "mnuOptionFileExit"
        Me.mnuOptionFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuOptionFileExit.Size = New System.Drawing.Size(132, 22)
        Me.mnuOptionFileExit.Text = "Exit"
        '
        'mnuOptionEdit
        '
        Me.mnuOptionEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionEditCut, Me.mnuOptionEditCopy, Me.mnuOptionEditPaste})
        Me.mnuOptionEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOptionEdit.Name = "mnuOptionEdit"
        Me.mnuOptionEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuOptionEdit.Text = "&Edit"
        '
        'mnuOptionEditCut
        '
        Me.mnuOptionEditCut.Name = "mnuOptionEditCut"
        Me.mnuOptionEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuOptionEditCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuOptionEditCut.Text = "Cut"
        '
        'mnuOptionEditCopy
        '
        Me.mnuOptionEditCopy.Name = "mnuOptionEditCopy"
        Me.mnuOptionEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuOptionEditCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuOptionEditCopy.Text = "Copy"
        '
        'mnuOptionEditPaste
        '
        Me.mnuOptionEditPaste.Name = "mnuOptionEditPaste"
        Me.mnuOptionEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuOptionEditPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuOptionEditPaste.Text = "Paste"
        '
        'mnuOptionInv
        '
        Me.mnuOptionInv.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionInvList, Me.mnuOptionInvAdd, Me.mnuOptionInvRemove})
        Me.mnuOptionInv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOptionInv.Name = "mnuOptionInv"
        Me.mnuOptionInv.Size = New System.Drawing.Size(69, 20)
        Me.mnuOptionInv.Text = "&Inventory"
        '
        'mnuOptionInvList
        '
        Me.mnuOptionInvList.Name = "mnuOptionInvList"
        Me.mnuOptionInvList.Size = New System.Drawing.Size(117, 22)
        Me.mnuOptionInvList.Text = "List"
        '
        'mnuOptionInvAdd
        '
        Me.mnuOptionInvAdd.Name = "mnuOptionInvAdd"
        Me.mnuOptionInvAdd.Size = New System.Drawing.Size(117, 22)
        Me.mnuOptionInvAdd.Text = "Add"
        '
        'mnuOptionInvRemove
        '
        Me.mnuOptionInvRemove.Name = "mnuOptionInvRemove"
        Me.mnuOptionInvRemove.Size = New System.Drawing.Size(117, 22)
        Me.mnuOptionInvRemove.Text = "Remove"
        '
        'mnuOptionHelp
        '
        Me.mnuOptionHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionHelpAbout})
        Me.mnuOptionHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOptionHelp.Name = "mnuOptionHelp"
        Me.mnuOptionHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuOptionHelp.Text = "&Help"
        '
        'mnuOptionHelpAbout
        '
        Me.mnuOptionHelpAbout.Name = "mnuOptionHelpAbout"
        Me.mnuOptionHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuOptionHelpAbout.Text = "About"
        '
        'mnuMainAppl
        '
        Me.mnuMainAppl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionFile, Me.mnuOptionEdit, Me.mnuOptionInv, Me.mnuOptionHelp})
        Me.mnuMainAppl.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainAppl.Name = "mnuMainAppl"
        Me.mnuMainAppl.ShowItemToolTips = True
        Me.mnuMainAppl.Size = New System.Drawing.Size(725, 24)
        Me.mnuMainAppl.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(96, 98)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 565)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInvMgr)
        Me.Controls.Add(Me.tabInvMgmtSystem)
        Me.Controls.Add(Me.mnuMainAppl)
        Me.Name = "FrmMain"
        Me.Text = "Ch02Ex03"
        Me.tabInvMgmtSystem.ResumeLayout(False)
        Me.tabpInvList.ResumeLayout(False)
        Me.tabpInvList.PerformLayout()
        Me.tabpInvMgmt.ResumeLayout(False)
        Me.tabpInvMgmt.PerformLayout()
        Me.grpInvMgmtAdd.ResumeLayout(False)
        Me.grpInvMgmtAdd.PerformLayout()
        CType(Me.updQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMainAppl.ResumeLayout(False)
        Me.mnuMainAppl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabInvMgmtSystem As TabControl
    Friend WithEvents tabpInvList As TabPage
    Friend WithEvents tabpInvMgmt As TabPage
    Friend WithEvents lblInvMgr As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInvList As Label
    Friend WithEvents mnuOptionFile As ToolStripMenuItem
    Friend WithEvents mnuOptionFileLoad As ToolStripMenuItem
    Friend WithEvents mnuOptionFileSave As ToolStripMenuItem
    Friend WithEvents mnuOptionFileExit As ToolStripMenuItem
    Friend WithEvents mnuOptionEdit As ToolStripMenuItem
    Friend WithEvents mnuOptionEditCut As ToolStripMenuItem
    Friend WithEvents mnuOptionEditCopy As ToolStripMenuItem
    Friend WithEvents mnuOptionEditPaste As ToolStripMenuItem
    Friend WithEvents mnuOptionInv As ToolStripMenuItem
    Friend WithEvents mnuOptionInvList As ToolStripMenuItem
    Friend WithEvents mnuOptionInvAdd As ToolStripMenuItem
    Friend WithEvents mnuOptionInvRemove As ToolStripMenuItem
    Friend WithEvents mnuOptionHelp As ToolStripMenuItem
    Friend WithEvents mnuOptionHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuMainAppl As MenuStrip
    Friend WithEvents lblItemList As Label
    Friend WithEvents cboInvItem As ComboBox
    Friend WithEvents grpInvMgmtAdd As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblQty As Label
    Friend WithEvents updQty As NumericUpDown
    Friend WithEvents btnAdd As Button
End Class
