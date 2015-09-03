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
        lstInvItems = New System.Windows.Forms.ListBox()
        Me.tabInvMgmtSystem.SuspendLayout()
        Me.tabpInvList.SuspendLayout()
        Me.mnuMainAppl.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstInvItems
        '
        lstInvItems.FormattingEnabled = True
        lstInvItems.ImeMode = System.Windows.Forms.ImeMode.Off
        lstInvItems.Items.AddRange(New Object() {"Air Cleaners", "Air Filter", "Air Freshener", "Anti Freeze", "Batteries", "Brake Pads", "Car Polish", "Car Wax", "Floor Mats", "Foglightis", "Fuel Filter", "Headlights", "Mirrors", "Mufflers", "Oil", "Oil Filter", "Power Steering Fluid", "Radiators", "Spark Plugs", "Taillights", "Tires", "Touchup Paint", "Transmission Fluid", "Wiper Blades"})
        lstInvItems.Location = New System.Drawing.Point(81, 58)
        lstInvItems.Name = "lstInvItems"
        lstInvItems.Size = New System.Drawing.Size(309, 264)
        lstInvItems.Sorted = True
        lstInvItems.TabIndex = 0
        '
        'tabInvMgmtSystem
        '
        Me.tabInvMgmtSystem.Controls.Add(Me.tabpInvList)
        Me.tabInvMgmtSystem.Controls.Add(Me.tabpInvMgmt)
        Me.tabInvMgmtSystem.Location = New System.Drawing.Point(116, 98)
        Me.tabInvMgmtSystem.Name = "tabInvMgmtSystem"
        Me.tabInvMgmtSystem.SelectedIndex = 0
        Me.tabInvMgmtSystem.Size = New System.Drawing.Size(492, 373)
        Me.tabInvMgmtSystem.TabIndex = 0
        '
        'tabpInvList
        '
        Me.tabpInvList.Controls.Add(Me.lblInvList)
        Me.tabpInvList.Controls.Add(lstInvItems)
        Me.tabpInvList.Location = New System.Drawing.Point(4, 22)
        Me.tabpInvList.Name = "tabpInvList"
        Me.tabpInvList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpInvList.Size = New System.Drawing.Size(484, 347)
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
        Me.tabpInvMgmt.Location = New System.Drawing.Point(4, 22)
        Me.tabpInvMgmt.Name = "tabpInvMgmt"
        Me.tabpInvMgmt.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpInvMgmt.Size = New System.Drawing.Size(484, 347)
        Me.tabpInvMgmt.TabIndex = 1
        Me.tabpInvMgmt.Text = "Inventory Managment"
        Me.tabpInvMgmt.UseVisualStyleBackColor = True
        '
        'lblInvMgr
        '
        Me.lblInvMgr.AutoSize = True
        Me.lblInvMgr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvMgr.Location = New System.Drawing.Point(257, 48)
        Me.lblInvMgr.Name = "lblInvMgr"
        Me.lblInvMgr.Size = New System.Drawing.Size(210, 29)
        Me.lblInvMgr.TabIndex = 1
        Me.lblInvMgr.Text = "Inventory Manager"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(325, 502)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
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
        Me.mnuOptionFileLoad.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptionFileLoad.Text = "Load"
        '
        'mnuOptionFileSave
        '
        Me.mnuOptionFileSave.Name = "mnuOptionFileSave"
        Me.mnuOptionFileSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptionFileSave.Text = "Save"
        '
        'mnuOptionFileExit
        '
        Me.mnuOptionFileExit.Name = "mnuOptionFileExit"
        Me.mnuOptionFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuOptionFileExit.Size = New System.Drawing.Size(152, 22)
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
        Me.mnuOptionEditCut.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptionEditCut.Text = "Cut"
        '
        'mnuOptionEditCopy
        '
        Me.mnuOptionEditCopy.Name = "mnuOptionEditCopy"
        Me.mnuOptionEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuOptionEditCopy.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptionEditCopy.Text = "Copy"
        '
        'mnuOptionEditPaste
        '
        Me.mnuOptionEditPaste.Name = "mnuOptionEditPaste"
        Me.mnuOptionEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuOptionEditPaste.Size = New System.Drawing.Size(152, 22)
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
        Me.mnuOptionInvList.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptionInvList.Text = "List"
        '
        'mnuOptionInvAdd
        '
        Me.mnuOptionInvAdd.Name = "mnuOptionInvAdd"
        Me.mnuOptionInvAdd.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptionInvAdd.Text = "Add"
        '
        'mnuOptionInvRemove
        '
        Me.mnuOptionInvRemove.Name = "mnuOptionInvRemove"
        Me.mnuOptionInvRemove.Size = New System.Drawing.Size(152, 22)
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
        Me.mnuOptionHelpAbout.Size = New System.Drawing.Size(152, 22)
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
End Class
