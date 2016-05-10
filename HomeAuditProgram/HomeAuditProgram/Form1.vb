'Lucas Hauf 
'POS 408
'11/10/2015
'A program to calculate the cost of running an appliance 

Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal 'the folloing variables are used to convert the text information of
        Dim decUsed As Decimal 'of the page to numbers 
        Dim decNeeded As Decimal
        Dim decTotal As Decimal

        If Me.cmbApplianceType.Text = "" Then 'this checks to see if information has been choosen in the combo box
            MessageBox.Show("Please select an appliance")
            Me.cmbApplianceType.Focus() 'puts the cursor on the combo box
            Exit Sub ' this prevents the statment from continuing 
        End If

        If Me.txtCostPerHour.Text = "" Then 'checks to see if it's empty
            MessageBox.Show("The Cost field is empty")
            Me.txtCostPerHour.Focus()
            Exit Sub
        End If
        If Me.txtPowerNeeded.Text = "" Then 'checks to see if power needed field is empty
            MessageBox.Show("The Power Needed field is empty")
            Me.txtPowerNeeded.Focus()
            Exit Sub
        End If
        If Me.txtHoursUsed.Text = "" Then 'checks to see if hours used field is empty
            MessageBox.Show("The Hours Used field is empty")
            Me.txtHoursUsed.Focus()
            Exit Sub
        End If

        decCost = Decimal.Parse(txtCostPerHour.Text) 'converts text to decimal 
        decUsed = Decimal.Parse(txtHoursUsed.Text)
        decNeeded = Decimal.Parse(txtPowerNeeded.Text)
        decTotal = decCost * decNeeded * decUsed 'calculates daily cost

        Me.lblTotalAmount.Text = FormatCurrency(decTotal) 'displays decTotal in currency format

        Me.lblAppliance.Text = Me.cmbApplianceType.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.txtCostPerHour.Clear() 'clears the cost text box
        Me.txtHoursUsed.Clear() 'clears the used text box
        Me.txtPowerNeeded.Clear() 'clears the needed text box
        Me.lblTotalAmount.Text = "$ 0.00" 'puts the total back to zero
        Me.lblAverageCost.Visible = False 'hides the label
        Me.lblAveragePowerNeeded.Visible = False ' hides the label
        Me.cmbApplianceType.Text = "" 'clears the combo box
        Me.lblAppliance.Text = "" 'clears the label 
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'exits the program
    End Sub

    Private Sub cmbApplianceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbApplianceType.SelectedIndexChanged

        Me.lblAverageCost.Text = "National average cost is $0.14" 'sets the value of the label
        If Me.cmbApplianceType.Text = "Refrigerator" Then 'the following if statments check to see what items have been selected in the combo box
            Me.lblAverageCost.Visible = True 'depending on the item selected the statments will make a label visible that will tell the user the average power consumption
            Me.lblAveragePowerNeeded.Visible = True 'of the appliance 
            Me.lblAveragePowerNeeded.Text = "Average power consumption 0.725kwh"
        End If
        If Me.cmbApplianceType.Text = "TV" Then
            Me.lblAverageCost.Visible = True
            Me.lblAveragePowerNeeded.Visible = True
            Me.lblAveragePowerNeeded.Text = "Average power consumption 0.12kwh"
        End If
        If Me.cmbApplianceType.Text = "Heater" Then
            Me.lblAverageCost.Visible = True
            Me.lblAveragePowerNeeded.Visible = True
            Me.lblAveragePowerNeeded.Text = "Average power consumption 15kwh"
        End If
        If Me.cmbApplianceType.Text = "Fan" Then
            Me.lblAverageCost.Visible = True
            Me.lblAveragePowerNeeded.Visible = True
            Me.lblAveragePowerNeeded.Text = "Average power consumption 0.175kwh"
        End If
        If Me.cmbApplianceType.Text = "Dryer" Then
            Me.lblAverageCost.Visible = True
            Me.lblAveragePowerNeeded.Visible = True
            Me.lblAveragePowerNeeded.Text = "Average power consumption 50kwh"
        End If
        If Me.cmbApplianceType.Text = "Oven" Then
            Me.lblAverageCost.Visible = True
            Me.lblAveragePowerNeeded.Visible = True
            Me.lblAveragePowerNeeded.Text = "Average power consumption 12kwh"
        End If
    End Sub
End Class
