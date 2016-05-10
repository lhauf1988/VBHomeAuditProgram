<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtCostPerHour = New System.Windows.Forms.TextBox()
        Me.txtPowerNeeded = New System.Windows.Forms.TextBox()
        Me.txtHoursUsed = New System.Windows.Forms.TextBox()
        Me.cmbApplianceType = New System.Windows.Forms.ComboBox()
        Me.lblCostPerHour = New System.Windows.Forms.Label()
        Me.lblPowerNeeded = New System.Windows.Forms.Label()
        Me.lblHoursUsed = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAverageCost = New System.Windows.Forms.Label()
        Me.lblAveragePowerNeeded = New System.Windows.Forms.Label()
        Me.lblMonthlyTotal = New System.Windows.Forms.Label()
        Me.lblyearlyTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyAmount = New System.Windows.Forms.Label()
        Me.lblYearlyAmount = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCostPerHour
        '
        Me.txtCostPerHour.Location = New System.Drawing.Point(201, 73)
        Me.txtCostPerHour.MaxLength = 4
        Me.txtCostPerHour.Name = "txtCostPerHour"
        Me.txtCostPerHour.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPerHour.TabIndex = 4
        '
        'txtPowerNeeded
        '
        Me.txtPowerNeeded.Location = New System.Drawing.Point(201, 109)
        Me.txtPowerNeeded.MaxLength = 5
        Me.txtPowerNeeded.Name = "txtPowerNeeded"
        Me.txtPowerNeeded.Size = New System.Drawing.Size(100, 20)
        Me.txtPowerNeeded.TabIndex = 7
        '
        'txtHoursUsed
        '
        Me.txtHoursUsed.Location = New System.Drawing.Point(201, 145)
        Me.txtHoursUsed.MaxLength = 2
        Me.txtHoursUsed.Name = "txtHoursUsed"
        Me.txtHoursUsed.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursUsed.TabIndex = 9
        '
        'cmbApplianceType
        '
        Me.cmbApplianceType.AutoCompleteCustomSource.AddRange(New String() {"Refrigerator", "TV", "Heater", "Fan", "Dryer", "Oven"})
        Me.cmbApplianceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbApplianceType.FormattingEnabled = True
        Me.cmbApplianceType.Items.AddRange(New Object() {"Refrigerator", "TV", "Heater", "Fan", "Dryer", "Oven"})
        Me.cmbApplianceType.Location = New System.Drawing.Point(201, 37)
        Me.cmbApplianceType.Name = "cmbApplianceType"
        Me.cmbApplianceType.Size = New System.Drawing.Size(100, 21)
        Me.cmbApplianceType.TabIndex = 1
        '
        'lblCostPerHour
        '
        Me.lblCostPerHour.AutoSize = True
        Me.lblCostPerHour.Location = New System.Drawing.Point(59, 73)
        Me.lblCostPerHour.Name = "lblCostPerHour"
        Me.lblCostPerHour.Size = New System.Drawing.Size(113, 13)
        Me.lblCostPerHour.TabIndex = 3
        Me.lblCostPerHour.Text = "Cost Per Kilowatt Hour"
        '
        'lblPowerNeeded
        '
        Me.lblPowerNeeded.AutoSize = True
        Me.lblPowerNeeded.Location = New System.Drawing.Point(38, 109)
        Me.lblPowerNeeded.Name = "lblPowerNeeded"
        Me.lblPowerNeeded.Size = New System.Drawing.Size(134, 13)
        Me.lblPowerNeeded.TabIndex = 6
        Me.lblPowerNeeded.Text = "Power Needed in Kilowatts"
        '
        'lblHoursUsed
        '
        Me.lblHoursUsed.AutoSize = True
        Me.lblHoursUsed.Location = New System.Drawing.Point(68, 145)
        Me.lblHoursUsed.Name = "lblHoursUsed"
        Me.lblHoursUsed.Size = New System.Drawing.Size(104, 13)
        Me.lblHoursUsed.TabIndex = 8
        Me.lblHoursUsed.Text = "Hours Used Per Day"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(51, 259)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "&Calculate "
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(133, 259)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "&Reset "
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(215, 258)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(42, 195)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(98, 13)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = " Your Daily Cost is: "
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(166, 195)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(37, 13)
        Me.lblTotalAmount.TabIndex = 13
        Me.lblTotalAmount.Text = "$ 0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Your Appliance"
        '
        'lblAverageCost
        '
        Me.lblAverageCost.AutoSize = True
        Me.lblAverageCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCost.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAverageCost.Location = New System.Drawing.Point(147, 61)
        Me.lblAverageCost.Name = "lblAverageCost"
        Me.lblAverageCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAverageCost.Size = New System.Drawing.Size(25, 12)
        Me.lblAverageCost.TabIndex = 2
        Me.lblAverageCost.Text = "Cost"
        Me.lblAverageCost.Visible = False
        '
        'lblAveragePowerNeeded
        '
        Me.lblAveragePowerNeeded.AutoSize = True
        Me.lblAveragePowerNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveragePowerNeeded.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAveragePowerNeeded.Location = New System.Drawing.Point(131, 97)
        Me.lblAveragePowerNeeded.Name = "lblAveragePowerNeeded"
        Me.lblAveragePowerNeeded.Size = New System.Drawing.Size(64, 12)
        Me.lblAveragePowerNeeded.TabIndex = 5
        Me.lblAveragePowerNeeded.Text = "Power needed"
        Me.lblAveragePowerNeeded.Visible = False
        '
        'lblMonthlyTotal
        '
        Me.lblMonthlyTotal.AutoSize = True
        Me.lblMonthlyTotal.Location = New System.Drawing.Point(45, 212)
        Me.lblMonthlyTotal.Name = "lblMonthlyTotal"
        Me.lblMonthlyTotal.Size = New System.Drawing.Size(106, 13)
        Me.lblMonthlyTotal.TabIndex = 14
        Me.lblMonthlyTotal.Text = "Your Monthly Cost is:"
        Me.lblMonthlyTotal.Visible = False
        '
        'lblyearlyTotal
        '
        Me.lblyearlyTotal.AutoSize = True
        Me.lblyearlyTotal.Location = New System.Drawing.Point(45, 229)
        Me.lblyearlyTotal.Name = "lblyearlyTotal"
        Me.lblyearlyTotal.Size = New System.Drawing.Size(98, 13)
        Me.lblyearlyTotal.TabIndex = 16
        Me.lblyearlyTotal.Text = "Your Yearly Cost is:"
        Me.lblyearlyTotal.Visible = False
        '
        'lblMonthlyAmount
        '
        Me.lblMonthlyAmount.AutoSize = True
        Me.lblMonthlyAmount.Location = New System.Drawing.Point(166, 212)
        Me.lblMonthlyAmount.Name = "lblMonthlyAmount"
        Me.lblMonthlyAmount.Size = New System.Drawing.Size(37, 13)
        Me.lblMonthlyAmount.TabIndex = 15
        Me.lblMonthlyAmount.Text = "$ 0.00"
        Me.lblMonthlyAmount.Visible = False
        '
        'lblYearlyAmount
        '
        Me.lblYearlyAmount.AutoSize = True
        Me.lblYearlyAmount.Location = New System.Drawing.Point(166, 229)
        Me.lblYearlyAmount.Name = "lblYearlyAmount"
        Me.lblYearlyAmount.Size = New System.Drawing.Size(37, 13)
        Me.lblYearlyAmount.TabIndex = 17
        Me.lblYearlyAmount.Text = "$ 0.00"
        Me.lblYearlyAmount.Visible = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(48, 179)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(84, 13)
        Me.lblType.TabIndex = 10
        Me.lblType.Text = "Appliance Type:"
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(169, 178)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(0, 13)
        Me.lblAppliance.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 295)
        Me.Controls.Add(Me.lblAppliance)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblYearlyAmount)
        Me.Controls.Add(Me.lblMonthlyAmount)
        Me.Controls.Add(Me.lblyearlyTotal)
        Me.Controls.Add(Me.lblMonthlyTotal)
        Me.Controls.Add(Me.lblAveragePowerNeeded)
        Me.Controls.Add(Me.lblAverageCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblHoursUsed)
        Me.Controls.Add(Me.lblPowerNeeded)
        Me.Controls.Add(Me.lblCostPerHour)
        Me.Controls.Add(Me.cmbApplianceType)
        Me.Controls.Add(Me.txtHoursUsed)
        Me.Controls.Add(Me.txtPowerNeeded)
        Me.Controls.Add(Me.txtCostPerHour)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Utility Cost Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCostPerHour As System.Windows.Forms.TextBox
    Friend WithEvents txtPowerNeeded As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursUsed As System.Windows.Forms.TextBox
    Friend WithEvents cmbApplianceType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCostPerHour As System.Windows.Forms.Label
    Friend WithEvents lblPowerNeeded As System.Windows.Forms.Label
    Friend WithEvents lblHoursUsed As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAverageCost As System.Windows.Forms.Label
    Friend WithEvents lblAveragePowerNeeded As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyTotal As System.Windows.Forms.Label
    Friend WithEvents lblyearlyTotal As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyAmount As System.Windows.Forms.Label
    Friend WithEvents lblYearlyAmount As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblAppliance As System.Windows.Forms.Label

End Class
