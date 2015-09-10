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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lnkBizURL = New System.Windows.Forms.LinkLabel()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.radCoop = New System.Windows.Forms.RadioButton()
        Me.grbBizType = New System.Windows.Forms.GroupBox()
        Me.radCorp = New System.Windows.Forms.RadioButton()
        Me.radProprietorship = New System.Windows.Forms.RadioButton()
        Me.grbBizCharacteristics = New System.Windows.Forms.GroupBox()
        Me.chkIntl = New System.Windows.Forms.CheckBox()
        Me.chkTaxExempt = New System.Windows.Forms.CheckBox()
        Me.picBizLogo = New System.Windows.Forms.PictureBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.grbBizType.SuspendLayout()
        Me.grbBizCharacteristics.SuspendLayout()
        CType(Me.picBizLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkBizURL
        '
        Me.lnkBizURL.AutoSize = True
        Me.lnkBizURL.Font = New System.Drawing.Font("Rockwell Condensed", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBizURL.Location = New System.Drawing.Point(43, 34)
        Me.lnkBizURL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkBizURL.Name = "lnkBizURL"
        Me.lnkBizURL.Size = New System.Drawing.Size(241, 50)
        Me.lnkBizURL.TabIndex = 1
        Me.lnkBizURL.TabStop = True
        Me.lnkBizURL.Text = "MyBusiness.com"
        '
        'txtOwnerName
        '
        Me.txtOwnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerName.Location = New System.Drawing.Point(190, 108)
        Me.txtOwnerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(318, 23)
        Me.txtOwnerName.TabIndex = 2
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerName.Location = New System.Drawing.Point(86, 111)
        Me.lblOwnerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(94, 17)
        Me.lblOwnerName.TabIndex = 2
        Me.lblOwnerName.Text = "&Owner Name:"
        '
        'radCoop
        '
        Me.radCoop.AutoSize = True
        Me.radCoop.Location = New System.Drawing.Point(40, 27)
        Me.radCoop.Margin = New System.Windows.Forms.Padding(4)
        Me.radCoop.Name = "radCoop"
        Me.radCoop.Size = New System.Drawing.Size(64, 21)
        Me.radCoop.TabIndex = 5
        Me.radCoop.Text = "&Co-op"
        Me.radCoop.UseVisualStyleBackColor = True
        '
        'grbBizType
        '
        Me.grbBizType.Controls.Add(Me.radCorp)
        Me.grbBizType.Controls.Add(Me.radProprietorship)
        Me.grbBizType.Controls.Add(Me.radCoop)
        Me.grbBizType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBizType.Location = New System.Drawing.Point(49, 170)
        Me.grbBizType.Margin = New System.Windows.Forms.Padding(4)
        Me.grbBizType.Name = "grbBizType"
        Me.grbBizType.Padding = New System.Windows.Forms.Padding(4)
        Me.grbBizType.Size = New System.Drawing.Size(216, 137)
        Me.grbBizType.TabIndex = 4
        Me.grbBizType.TabStop = False
        Me.grbBizType.Text = "Type of Business"
        '
        'radCorp
        '
        Me.radCorp.AutoSize = True
        Me.radCorp.Location = New System.Drawing.Point(40, 95)
        Me.radCorp.Margin = New System.Windows.Forms.Padding(4)
        Me.radCorp.Name = "radCorp"
        Me.radCorp.Size = New System.Drawing.Size(100, 21)
        Me.radCorp.TabIndex = 7
        Me.radCorp.Text = "Co&rporation"
        Me.radCorp.UseVisualStyleBackColor = True
        '
        'radProprietorship
        '
        Me.radProprietorship.AutoSize = True
        Me.radProprietorship.Checked = True
        Me.radProprietorship.Location = New System.Drawing.Point(40, 61)
        Me.radProprietorship.Margin = New System.Windows.Forms.Padding(4)
        Me.radProprietorship.Name = "radProprietorship"
        Me.radProprietorship.Size = New System.Drawing.Size(115, 21)
        Me.radProprietorship.TabIndex = 6
        Me.radProprietorship.TabStop = True
        Me.radProprietorship.Text = "&Proprietorship"
        Me.radProprietorship.UseVisualStyleBackColor = True
        '
        'grbBizCharacteristics
        '
        Me.grbBizCharacteristics.Controls.Add(Me.chkIntl)
        Me.grbBizCharacteristics.Controls.Add(Me.chkTaxExempt)
        Me.grbBizCharacteristics.Location = New System.Drawing.Point(299, 170)
        Me.grbBizCharacteristics.Margin = New System.Windows.Forms.Padding(4)
        Me.grbBizCharacteristics.Name = "grbBizCharacteristics"
        Me.grbBizCharacteristics.Padding = New System.Windows.Forms.Padding(4)
        Me.grbBizCharacteristics.Size = New System.Drawing.Size(207, 137)
        Me.grbBizCharacteristics.TabIndex = 8
        Me.grbBizCharacteristics.TabStop = False
        Me.grbBizCharacteristics.Text = "Business Characteristics"
        '
        'chkIntl
        '
        Me.chkIntl.AutoSize = True
        Me.chkIntl.Checked = True
        Me.chkIntl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIntl.Location = New System.Drawing.Point(35, 64)
        Me.chkIntl.Name = "chkIntl"
        Me.chkIntl.Size = New System.Drawing.Size(105, 21)
        Me.chkIntl.TabIndex = 10
        Me.chkIntl.Text = "&International"
        Me.chkIntl.UseVisualStyleBackColor = True
        '
        'chkTaxExempt
        '
        Me.chkTaxExempt.AutoSize = True
        Me.chkTaxExempt.Location = New System.Drawing.Point(35, 30)
        Me.chkTaxExempt.Name = "chkTaxExempt"
        Me.chkTaxExempt.Size = New System.Drawing.Size(100, 21)
        Me.chkTaxExempt.TabIndex = 9
        Me.chkTaxExempt.Text = "&Tax Exempt"
        Me.chkTaxExempt.UseVisualStyleBackColor = True
        '
        'picBizLogo
        '
        Me.picBizLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBizLogo.Image = CType(resources.GetObject("picBizLogo.Image"), System.Drawing.Image)
        Me.picBizLogo.Location = New System.Drawing.Point(156, 355)
        Me.picBizLogo.Name = "picBizLogo"
        Me.picBizLogo.Size = New System.Drawing.Size(262, 168)
        Me.picBizLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBizLogo.TabIndex = 6
        Me.picBizLogo.TabStop = False
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(190, 561)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 26)
        Me.btnAccept.TabIndex = 12
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(299, 561)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 26)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(264, 324)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(40, 17)
        Me.lblLogo.TabIndex = 11
        Me.lblLogo.Text = "Logo"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 611)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.picBizLogo)
        Me.Controls.Add(Me.grbBizCharacteristics)
        Me.Controls.Add(Me.grbBizType)
        Me.Controls.Add(Me.lblOwnerName)
        Me.Controls.Add(Me.txtOwnerName)
        Me.Controls.Add(Me.lnkBizURL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.Text = "Ch02Ex02"
        Me.grbBizType.ResumeLayout(False)
        Me.grbBizType.PerformLayout()
        Me.grbBizCharacteristics.ResumeLayout(False)
        Me.grbBizCharacteristics.PerformLayout()
        CType(Me.picBizLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lnkBizURL As LinkLabel
    Friend WithEvents txtOwnerName As TextBox
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents radCoop As RadioButton
    Friend WithEvents grbBizType As GroupBox
    Friend WithEvents radCorp As RadioButton
    Friend WithEvents radProprietorship As RadioButton
    Friend WithEvents grbBizCharacteristics As GroupBox
    Friend WithEvents chkIntl As CheckBox
    Friend WithEvents chkTaxExempt As CheckBox
    Friend WithEvents picBizLogo As PictureBox
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblLogo As Label
End Class
