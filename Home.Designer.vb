<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.hdCellPhone = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.lblPhoneCount = New System.Windows.Forms.Label()
        Me.lblDataPlan = New System.Windows.Forms.Label()
        Me.txtDataPlan = New System.Windows.Forms.NumericUpDown()
        Me.gbAdditionalItems = New System.Windows.Forms.GroupBox()
        Me.gbVoiceMinutes = New System.Windows.Forms.GroupBox()
        Me.rbVoiceNone = New System.Windows.Forms.RadioButton()
        Me.rbVoiceUnlimited = New System.Windows.Forms.RadioButton()
        Me.rbVoice750 = New System.Windows.Forms.RadioButton()
        Me.rbVoice300 = New System.Windows.Forms.RadioButton()
        Me.gbTextMessages = New System.Windows.Forms.GroupBox()
        Me.rbTxtNone = New System.Windows.Forms.RadioButton()
        Me.rbTxtUnlimited = New System.Windows.Forms.RadioButton()
        Me.rbTxt1000 = New System.Windows.Forms.RadioButton()
        Me.rbTxt400 = New System.Windows.Forms.RadioButton()
        Me.cbVoicemail = New System.Windows.Forms.CheckBox()
        Me.lblSubtotalPhones = New System.Windows.Forms.Label()
        Me.lblSubtotalOther = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.txtSubtotalPhones = New System.Windows.Forms.TextBox()
        Me.txtSubtotalOther = New System.Windows.Forms.TextBox()
        Me.txtTaxAmount = New System.Windows.Forms.TextBox()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        CType(Me.txtDataPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAdditionalItems.SuspendLayout()
        Me.gbVoiceMinutes.SuspendLayout()
        Me.gbTextMessages.SuspendLayout()
        Me.SuspendLayout()
        '
        'hdCellPhone
        '
        Me.hdCellPhone.AutoSize = True
        Me.hdCellPhone.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdCellPhone.Location = New System.Drawing.Point(177, 9)
        Me.hdCellPhone.Name = "hdCellPhone"
        Me.hdCellPhone.Size = New System.Drawing.Size(327, 39)
        Me.hdCellPhone.TabIndex = 0
        Me.hdCellPhone.Text = "Family Cell Phone Plan"
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(414, 80)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(60, 59)
        Me.btnPlus.TabIndex = 1
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(193, 80)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(60, 59)
        Me.btnMinus.TabIndex = 2
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'lblPhoneCount
        '
        Me.lblPhoneCount.AutoSize = True
        Me.lblPhoneCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneCount.Location = New System.Drawing.Point(283, 80)
        Me.lblPhoneCount.Name = "lblPhoneCount"
        Me.lblPhoneCount.Size = New System.Drawing.Size(102, 20)
        Me.lblPhoneCount.TabIndex = 3
        Me.lblPhoneCount.Text = "Phone Count"
        Me.lblPhoneCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataPlan
        '
        Me.lblDataPlan.AutoSize = True
        Me.lblDataPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataPlan.Location = New System.Drawing.Point(12, 171)
        Me.lblDataPlan.Name = "lblDataPlan"
        Me.lblDataPlan.Size = New System.Drawing.Size(270, 20)
        Me.lblDataPlan.TabIndex = 5
        Me.lblDataPlan.Text = "How many phones have a data plan?"
        '
        'txtDataPlan
        '
        Me.txtDataPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataPlan.Location = New System.Drawing.Point(288, 169)
        Me.txtDataPlan.Name = "txtDataPlan"
        Me.txtDataPlan.Size = New System.Drawing.Size(120, 26)
        Me.txtDataPlan.TabIndex = 7
        '
        'gbAdditionalItems
        '
        Me.gbAdditionalItems.Controls.Add(Me.gbVoiceMinutes)
        Me.gbAdditionalItems.Controls.Add(Me.gbTextMessages)
        Me.gbAdditionalItems.Controls.Add(Me.cbVoicemail)
        Me.gbAdditionalItems.Location = New System.Drawing.Point(12, 203)
        Me.gbAdditionalItems.Name = "gbAdditionalItems"
        Me.gbAdditionalItems.Size = New System.Drawing.Size(646, 198)
        Me.gbAdditionalItems.TabIndex = 8
        Me.gbAdditionalItems.TabStop = False
        Me.gbAdditionalItems.Text = "Additional"
        '
        'gbVoiceMinutes
        '
        Me.gbVoiceMinutes.Controls.Add(Me.rbVoiceNone)
        Me.gbVoiceMinutes.Controls.Add(Me.rbVoiceUnlimited)
        Me.gbVoiceMinutes.Controls.Add(Me.rbVoice750)
        Me.gbVoiceMinutes.Controls.Add(Me.rbVoice300)
        Me.gbVoiceMinutes.Location = New System.Drawing.Point(14, 114)
        Me.gbVoiceMinutes.Name = "gbVoiceMinutes"
        Me.gbVoiceMinutes.Size = New System.Drawing.Size(611, 58)
        Me.gbVoiceMinutes.TabIndex = 4
        Me.gbVoiceMinutes.TabStop = False
        Me.gbVoiceMinutes.Text = "Voice Minutes"
        '
        'rbVoiceNone
        '
        Me.rbVoiceNone.AutoSize = True
        Me.rbVoiceNone.Checked = True
        Me.rbVoiceNone.Location = New System.Drawing.Point(541, 24)
        Me.rbVoiceNone.Name = "rbVoiceNone"
        Me.rbVoiceNone.Size = New System.Drawing.Size(51, 17)
        Me.rbVoiceNone.TabIndex = 4
        Me.rbVoiceNone.TabStop = True
        Me.rbVoiceNone.Tag = "0"
        Me.rbVoiceNone.Text = "None"
        Me.rbVoiceNone.UseVisualStyleBackColor = True
        '
        'rbVoiceUnlimited
        '
        Me.rbVoiceUnlimited.AutoSize = True
        Me.rbVoiceUnlimited.Location = New System.Drawing.Point(369, 24)
        Me.rbVoiceUnlimited.Name = "rbVoiceUnlimited"
        Me.rbVoiceUnlimited.Size = New System.Drawing.Size(147, 17)
        Me.rbVoiceUnlimited.TabIndex = 3
        Me.rbVoiceUnlimited.TabStop = True
        Me.rbVoiceUnlimited.Tag = "34.95"
        Me.rbVoiceUnlimited.Text = "Unlimited ($34.95 /month)"
        Me.rbVoiceUnlimited.UseVisualStyleBackColor = True
        '
        'rbVoice750
        '
        Me.rbVoice750.AutoSize = True
        Me.rbVoice750.Location = New System.Drawing.Point(183, 24)
        Me.rbVoice750.Name = "rbVoice750"
        Me.rbVoice750.Size = New System.Drawing.Size(163, 17)
        Me.rbVoice750.TabIndex = 2
        Me.rbVoice750.TabStop = True
        Me.rbVoice750.Tag = "14.95"
        Me.rbVoice750.Text = "750 a month ($14.95 /month)"
        Me.rbVoice750.UseVisualStyleBackColor = True
        '
        'rbVoice300
        '
        Me.rbVoice300.AutoSize = True
        Me.rbVoice300.Location = New System.Drawing.Point(6, 24)
        Me.rbVoice300.Name = "rbVoice300"
        Me.rbVoice300.Size = New System.Drawing.Size(114, 17)
        Me.rbVoice300.TabIndex = 1
        Me.rbVoice300.TabStop = True
        Me.rbVoice300.Tag = "0"
        Me.rbVoice300.Text = "300 a month (Free)"
        Me.rbVoice300.UseVisualStyleBackColor = True
        '
        'gbTextMessages
        '
        Me.gbTextMessages.Controls.Add(Me.rbTxtNone)
        Me.gbTextMessages.Controls.Add(Me.rbTxtUnlimited)
        Me.gbTextMessages.Controls.Add(Me.rbTxt1000)
        Me.gbTextMessages.Controls.Add(Me.rbTxt400)
        Me.gbTextMessages.Location = New System.Drawing.Point(14, 50)
        Me.gbTextMessages.Name = "gbTextMessages"
        Me.gbTextMessages.Size = New System.Drawing.Size(611, 58)
        Me.gbTextMessages.TabIndex = 2
        Me.gbTextMessages.TabStop = False
        Me.gbTextMessages.Text = "Text Messages"
        '
        'rbTxtNone
        '
        Me.rbTxtNone.AutoSize = True
        Me.rbTxtNone.Checked = True
        Me.rbTxtNone.Location = New System.Drawing.Point(541, 24)
        Me.rbTxtNone.Name = "rbTxtNone"
        Me.rbTxtNone.Size = New System.Drawing.Size(51, 17)
        Me.rbTxtNone.TabIndex = 5
        Me.rbTxtNone.TabStop = True
        Me.rbTxtNone.Tag = "0"
        Me.rbTxtNone.Text = "None"
        Me.rbTxtNone.UseVisualStyleBackColor = True
        '
        'rbTxtUnlimited
        '
        Me.rbTxtUnlimited.AutoSize = True
        Me.rbTxtUnlimited.Location = New System.Drawing.Point(369, 24)
        Me.rbTxtUnlimited.Name = "rbTxtUnlimited"
        Me.rbTxtUnlimited.Size = New System.Drawing.Size(147, 17)
        Me.rbTxtUnlimited.TabIndex = 3
        Me.rbTxtUnlimited.Tag = "14.95"
        Me.rbTxtUnlimited.Text = "Unlimited ($14.95 /month)"
        Me.rbTxtUnlimited.UseVisualStyleBackColor = True
        '
        'rbTxt1000
        '
        Me.rbTxt1000.AutoSize = True
        Me.rbTxt1000.Location = New System.Drawing.Point(183, 24)
        Me.rbTxt1000.Name = "rbTxt1000"
        Me.rbTxt1000.Size = New System.Drawing.Size(163, 17)
        Me.rbTxt1000.TabIndex = 2
        Me.rbTxt1000.Tag = "8.95"
        Me.rbTxt1000.Text = "1000 a month ($8.95 /month)"
        Me.rbTxt1000.UseVisualStyleBackColor = True
        '
        'rbTxt400
        '
        Me.rbTxt400.AutoSize = True
        Me.rbTxt400.Location = New System.Drawing.Point(6, 24)
        Me.rbTxt400.Name = "rbTxt400"
        Me.rbTxt400.Size = New System.Drawing.Size(157, 17)
        Me.rbTxt400.TabIndex = 1
        Me.rbTxt400.Tag = "3.95"
        Me.rbTxt400.Text = "400 a month ($3.95 /month)"
        Me.rbTxt400.UseVisualStyleBackColor = True
        '
        'cbVoicemail
        '
        Me.cbVoicemail.AutoSize = True
        Me.cbVoicemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVoicemail.Location = New System.Drawing.Point(7, 20)
        Me.cbVoicemail.Name = "cbVoicemail"
        Me.cbVoicemail.Size = New System.Drawing.Size(207, 24)
        Me.cbVoicemail.TabIndex = 0
        Me.cbVoicemail.Text = "Voice Mail ($3.95 /month)"
        Me.cbVoicemail.UseVisualStyleBackColor = True
        '
        'lblSubtotalPhones
        '
        Me.lblSubtotalPhones.AutoSize = True
        Me.lblSubtotalPhones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalPhones.Location = New System.Drawing.Point(153, 433)
        Me.lblSubtotalPhones.Name = "lblSubtotalPhones"
        Me.lblSubtotalPhones.Size = New System.Drawing.Size(251, 20)
        Me.lblSubtotalPhones.TabIndex = 9
        Me.lblSubtotalPhones.Text = "Subtotal Cost for Phones Only"
        '
        'lblSubtotalOther
        '
        Me.lblSubtotalOther.AutoSize = True
        Me.lblSubtotalOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalOther.Location = New System.Drawing.Point(15, 475)
        Me.lblSubtotalOther.Name = "lblSubtotalOther"
        Me.lblSubtotalOther.Size = New System.Drawing.Size(391, 20)
        Me.lblSubtotalOther.TabIndex = 10
        Me.lblSubtotalOther.Text = "Subtotal Cost for Data Plans and Other Options"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.Location = New System.Drawing.Point(300, 516)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(104, 20)
        Me.lblTaxAmount.TabIndex = 11
        Me.lblTaxAmount.Text = "Tax Amount"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(289, 581)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(119, 24)
        Me.lblGrandTotal.TabIndex = 12
        Me.lblGrandTotal.Text = "Grand Total"
        '
        'txtSubtotalPhones
        '
        Me.txtSubtotalPhones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalPhones.Location = New System.Drawing.Point(426, 423)
        Me.txtSubtotalPhones.Name = "txtSubtotalPhones"
        Me.txtSubtotalPhones.ReadOnly = True
        Me.txtSubtotalPhones.Size = New System.Drawing.Size(176, 35)
        Me.txtSubtotalPhones.TabIndex = 13
        '
        'txtSubtotalOther
        '
        Me.txtSubtotalOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalOther.Location = New System.Drawing.Point(426, 465)
        Me.txtSubtotalOther.Name = "txtSubtotalOther"
        Me.txtSubtotalOther.ReadOnly = True
        Me.txtSubtotalOther.Size = New System.Drawing.Size(176, 35)
        Me.txtSubtotalOther.TabIndex = 14
        '
        'txtTaxAmount
        '
        Me.txtTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxAmount.Location = New System.Drawing.Point(426, 506)
        Me.txtTaxAmount.Name = "txtTaxAmount"
        Me.txtTaxAmount.ReadOnly = True
        Me.txtTaxAmount.Size = New System.Drawing.Size(176, 35)
        Me.txtTaxAmount.TabIndex = 15
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(426, 570)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(176, 40)
        Me.txtGrandTotal.TabIndex = 16
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 639)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.txtTaxAmount)
        Me.Controls.Add(Me.txtSubtotalOther)
        Me.Controls.Add(Me.txtSubtotalPhones)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.lblSubtotalOther)
        Me.Controls.Add(Me.lblSubtotalPhones)
        Me.Controls.Add(Me.gbAdditionalItems)
        Me.Controls.Add(Me.txtDataPlan)
        Me.Controls.Add(Me.lblDataPlan)
        Me.Controls.Add(Me.lblPhoneCount)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.hdCellPhone)
        Me.Name = "Home"
        Me.Text = "Cell Phone Plan"
        CType(Me.txtDataPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAdditionalItems.ResumeLayout(False)
        Me.gbAdditionalItems.PerformLayout()
        Me.gbVoiceMinutes.ResumeLayout(False)
        Me.gbVoiceMinutes.PerformLayout()
        Me.gbTextMessages.ResumeLayout(False)
        Me.gbTextMessages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hdCellPhone As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents lblPhoneCount As Label
    Friend WithEvents lblDataPlan As Label
    Friend WithEvents txtDataPlan As NumericUpDown
    Friend WithEvents gbAdditionalItems As GroupBox
    Friend WithEvents gbVoiceMinutes As GroupBox
    Friend WithEvents rbVoiceUnlimited As RadioButton
    Friend WithEvents rbVoice750 As RadioButton
    Friend WithEvents rbVoice300 As RadioButton
    Friend WithEvents gbTextMessages As GroupBox
    Friend WithEvents rbTxtUnlimited As RadioButton
    Friend WithEvents rbTxt1000 As RadioButton
    Friend WithEvents rbTxt400 As RadioButton
    Friend WithEvents cbVoicemail As CheckBox
    Friend WithEvents lblSubtotalPhones As Label
    Friend WithEvents lblSubtotalOther As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents txtSubtotalPhones As TextBox
    Friend WithEvents txtSubtotalOther As TextBox
    Friend WithEvents txtTaxAmount As TextBox
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents rbVoiceNone As RadioButton
    Friend WithEvents rbTxtNone As RadioButton
End Class
