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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lnkBizURL = New System.Windows.Forms.LinkLabel()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.grbBizType = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.grbBizCharacteristics = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cbTaxExempt = New System.Windows.Forms.CheckBox()
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(40, 27)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 21)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&Co-op"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'grbBizType
        '
        Me.grbBizType.Controls.Add(Me.RadioButton3)
        Me.grbBizType.Controls.Add(Me.RadioButton2)
        Me.grbBizType.Controls.Add(Me.RadioButton1)
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
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(40, 95)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(100, 21)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Co&rporation"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(40, 61)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "&Proprietorship"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'grbBizCharacteristics
        '
        Me.grbBizCharacteristics.Controls.Add(Me.CheckBox2)
        Me.grbBizCharacteristics.Controls.Add(Me.cbTaxExempt)
        Me.grbBizCharacteristics.Location = New System.Drawing.Point(299, 170)
        Me.grbBizCharacteristics.Margin = New System.Windows.Forms.Padding(4)
        Me.grbBizCharacteristics.Name = "grbBizCharacteristics"
        Me.grbBizCharacteristics.Padding = New System.Windows.Forms.Padding(4)
        Me.grbBizCharacteristics.Size = New System.Drawing.Size(207, 137)
        Me.grbBizCharacteristics.TabIndex = 8
        Me.grbBizCharacteristics.TabStop = False
        Me.grbBizCharacteristics.Text = "Business Characteristics"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(35, 64)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(105, 21)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "&International"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cbTaxExempt
        '
        Me.cbTaxExempt.AutoSize = True
        Me.cbTaxExempt.Location = New System.Drawing.Point(35, 30)
        Me.cbTaxExempt.Name = "cbTaxExempt"
        Me.cbTaxExempt.Size = New System.Drawing.Size(100, 21)
        Me.cbTaxExempt.TabIndex = 9
        Me.cbTaxExempt.Text = "&Tax Exempt"
        Me.cbTaxExempt.UseVisualStyleBackColor = True
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
        Me.btnAccept.Location = New System.Drawing.Point(190, 551)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 36)
        Me.btnAccept.TabIndex = 12
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(299, 551)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
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
        'frmMain
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
        Me.Name = "frmMain"
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents grbBizType As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents grbBizCharacteristics As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents cbTaxExempt As CheckBox
    Friend WithEvents picBizLogo As PictureBox
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblLogo As Label
End Class
