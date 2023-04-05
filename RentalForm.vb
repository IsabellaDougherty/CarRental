Option Explicit On
Option Strict On
Option Compare Binary

'Isabella Dougherty
''RCET0265
'Spring 2023
'Car Rental
'https://github.com/IsabellaDougherty/CarRental.git

Imports System.IO

Public Class RentalForm
    Dim name As String
    Dim address As String
    Dim city As String
    Dim state As String
    Dim zipCode As String
    Dim answerYes As Integer
    Dim zip As Integer
    Dim begin As Integer
    Dim endO As Integer
    Dim days As Integer
    Dim mileage As Double
    Dim discount As Double
    Dim dayCharge As Double
    Dim totalCost As Double
    Dim overallMiles As Double
    Dim overallCustomers As Integer
    Dim overallRevenue As Double
    Dim miles As Double
    Dim zipViable As Boolean
    Dim beginOdometerViable As Boolean
    Dim endOdometerViable As Boolean
    Dim beginLessEnd As Boolean
    Dim daysViable As Boolean

    'Disables the summary button on loading of the form
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SummaryButton.Enabled = False
    End Sub

    'Sets the name variable to the text in the name text box when the text changes
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        name = NameTextBox.Text
        NameTextBox.BackColor = Color.White
    End Sub

    'Sets the address variable to the text in the address text box when the text changes
    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged
        address = AddressTextBox.Text
        AddressTextBox.BackColor = Color.White
    End Sub

    'Sets the city variable to the text in the city text box when the text changes
    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged
        city = CityTextBox.Text
        CityTextBox.BackColor = Color.White
    End Sub

    'Sets the state variable to the text in the state text box when the text changes
    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged
        state = StateTextBox.Text
        StateTextBox.BackColor = Color.White
    End Sub

    'Sets the zip variable and zip code variable to the text in the zip code text box when the text changes. If the zip code is not a number, sets a variable
    'so that when the calculate button is hit the user will be alerted
    Private Sub ZipCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipCodeTextBox.TextChanged
        Try
            ZipCodeTextBox.BackColor = Color.White
            zip = CInt(ZipCodeTextBox.Text)
            zipCode = ZipCodeTextBox.Text
            If Len(zipCode) < 5 Then
                zipViable = False
            Else
                zipViable = True
            End If
        Catch ex As Exception
            zipViable = False
        End Try
    End Sub

    'Sets the begin variable to the text in the begin odometer text box when the text changes. If the begin odometer is not a number,
    'sets a boolean so when the calculate button is hit the user will be alerted
    Private Sub BeginOdometerTextBox_TextChanged(sender As Object, e As EventArgs) Handles BeginOdometerTextBox.TextChanged
        Try
            BeginOdometerTextBox.BackColor = Color.White
            begin = CInt(BeginOdometerTextBox.Text)
            beginOdometerViable = True
        Catch ex As Exception
            beginOdometerViable = False
        End Try
    End Sub

    'Sets the endO variable to the text in the end odometer text box when the text changes. If the end odometer is not a number,
    'sets a boolean so when the calculate button is hit the user will be alerted
    Private Sub EndOdometerTextBox_TextChanged(sender As Object, e As EventArgs) Handles EndOdometerTextBox.TextChanged
        Try
            EndOdometerTextBox.BackColor = Color.White
            endO = CInt(EndOdometerTextBox.Text)
            endOdometerViable = True
        Catch ex As Exception
            endOdometerViable = False
        End Try
    End Sub

    'Sets the days variable to the text in the days text box when the text changes. If the days variable is not a number,
    'sets a boolean so when the calculate button is hit the user will be alerted
    Private Sub DaysTextBox_TextChanged(sender As Object, e As EventArgs) Handles DaysTextBox.TextChanged
        Try
            DaysTextBox.BackColor = Color.White
            days = CInt(DaysTextBox.Text)
            daysViable = True
        Catch ex As Exception
            daysViable = False
        End Try
    End Sub

    'Makes it so either the Miles radio button or the Kilometers radio button is hit but only one and never both.
    Private Sub MilesradioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MilesradioButton.CheckedChanged
        If KilometersradioButton.Checked = True Then
            KilometersradioButton.Checked = False
        ElseIf MilesradioButton.Checked = False Then
            MilesradioButton.Checked = True
        End If
    End Sub

    'Makes it so either the Miles radio button or the Kilometers radio button is hit but only one and never both.
    Private Sub KilometersradioButton_CheckedChanged(sender As Object, e As EventArgs) Handles KilometersradioButton.CheckedChanged
        If MilesradioButton.Checked = True Then
            MilesradioButton.Checked = False
        ElseIf KilometersradioButton.Checked = False Then
            KilometersradioButton.Checked = True
        End If
    End Sub

    'Checks for any errors in the form filling out that need to be adressed. If any need to be adressed the focus is placed on that text box
    'and the text box is cleared. If there is no errors, the cost and discounts are calculated and displayed while disabling the form and calculate button
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim wrong As String
        If NameTextBox.Text = "" Or AddressTextBox.Text = "" Or CityTextBox.Text = "" Or StateTextBox.Text = "" Or ZipCodeTextBox.Text = "" Or BeginOdometerTextBox.Text = "" Or EndOdometerTextBox.Text = "" Or DaysTextBox.Text = "" Then
            wrong += "You must fill in all sections.
"
            If DaysTextBox.Text = "" Then
                DaysTextBox.Focus()
                DaysTextBox.BackColor = Color.PaleVioletRed
            End If
            If EndOdometerTextBox.Text = "" Then
                EndOdometerTextBox.Focus()
                EndOdometerTextBox.BackColor = Color.PaleVioletRed
            End If
            If BeginOdometerTextBox.Text = "" Then
                BeginOdometerTextBox.Focus()
                BeginOdometerTextBox.BackColor = Color.PaleVioletRed
            End If
            If ZipCodeTextBox.Text = "" Then
                ZipCodeTextBox.Focus()
                ZipCodeTextBox.BackColor = Color.PaleVioletRed
            End If
            If StateTextBox.Text = "" Then
                StateTextBox.Focus()
                StateTextBox.BackColor = Color.PaleVioletRed
            End If
            If CityTextBox.Text = "" Then
                CityTextBox.Focus()
                CityTextBox.BackColor = Color.PaleVioletRed
            End If
            If AddressTextBox.Text = "" Then
                AddressTextBox.Focus()
                AddressTextBox.BackColor = Color.PaleVioletRed
            End If
            If NameTextBox.Text = "" Then
                NameTextBox.Focus()
                NameTextBox.BackColor = Color.PaleVioletRed
            End If

            MsgBox(wrong)

        ElseIf zipViable = False Or beginOdometerViable = False Or endOdometerViable = False Or begin >= endO Or begin < 0 Or days <= 0 Or days > 45 Then
            If zipViable = False Then
                wrong += "
You must input a valid zipcode."
                ZipCodeTextBox.Focus()
                ZipCodeTextBox.Text = ""
                ZipCodeTextBox.BackColor = Color.PaleVioletRed
            End If

            If beginOdometerViable = False Then
                wrong += "
You must input a beginning odometer value in numbers."
                BeginOdometerTextBox.Focus()
                BeginOdometerTextBox.Text = ""
                BeginOdometerTextBox.BackColor = Color.PaleVioletRed
            End If

            If endOdometerViable = False Then
                wrong += "
You must input an ending odometer value in numbers."
                EndOdometerTextBox.Focus()
                EndOdometerTextBox.Text = ""
                EndOdometerTextBox.BackColor = Color.PaleVioletRed
            End If

            If begin < 0 Or begin >= endO Then
                wrong += "
The input odometer values is invalid. Make sure the beginning odometer value is less than the ending and neither are negative."
                BeginOdometerTextBox.Focus()
                BeginOdometerTextBox.Text = ""
                EndOdometerTextBox.Text = ""
                BeginOdometerTextBox.BackColor = Color.PaleVioletRed
                EndOdometerTextBox.BackColor = Color.PaleVioletRed
            End If

            If days <= 0 Or days > 45 Then
                wrong += "
The input days is invalid. The amount of days must be greater then 0 and no more than 45."
                DaysTextBox.Focus()
                DaysTextBox.Text = ""
                DaysTextBox.BackColor = Color.PaleVioletRed
            End If
            MsgBox(wrong)
        Else
            SummaryButton.Enabled = True
            NameTextBox.Enabled = False
            AddressTextBox.Enabled = False
            CityTextBox.Enabled = False
            StateTextBox.Enabled = False
            ZipCodeTextBox.Enabled = False
            BeginOdometerTextBox.Enabled = False
            EndOdometerTextBox.Enabled = False
            DaysTextBox.Enabled = False
            AAAcheckbox.Enabled = False
            Seniorcheckbox.Enabled = False
            MilesradioButton.Enabled = False
            KilometersradioButton.Enabled = False

            overallCustomers += 1
            totalCost += 15 * days
            dayCharge = 15 * days
            If MilesradioButton.Checked = True Then
                miles = endO - begin
            ElseIf KilometersradioButton.Checked = True Then
                miles = 0.62 * (endO - begin)
            End If

            If miles > 200 And miles < 501 Then
                totalCost += (miles - 200) * 0.12
                mileage = (miles - 200) * 0.12
            ElseIf miles > 500 Then
                totalCost += (300 * 0.12) + ((miles - 500) * 0.1)
                mileage = (300 * 0.12) + ((miles - 500) * 0.1)
            End If
            mileage = Math.Round(mileage, 2)

            If AAAcheckbox.Checked = True And Seniorcheckbox.Checked = True Then
                totalCost = totalCost * 0.92
                discount = totalCost * 0.08
            ElseIf Seniorcheckbox.Checked = True Then
                totalCost = totalCost * 0.97
                discount = totalCost * 0.03
            ElseIf AAAcheckbox.Checked = True Then
                totalCost = totalCost * 0.95
                discount = totalCost * 0.05
            End If
            discount = Math.Round(discount, 2)
            totalCost = Math.Round(totalCost, 2)
            overallRevenue += totalCost
            overallMiles += miles

            TotalMilesTextBox.Text = CStr(endO - begin) + " mi"
            MileageChargeTextBox.Text = "$" + CStr(mileage)
            DayChargeTextBox.Text = "$" + CStr(dayCharge)
            TotalDiscountTextBox.Text = "$" + CStr(discount)
            TotalChargeTextBox.Text = "$" + CStr(totalCost)

            CalculateButton.Enabled = False

        End If
    End Sub

    'Clears the form and re-enables the form text boxes and calculate button. 
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Enabled = True
        AddressTextBox.Enabled = True
        CityTextBox.Enabled = True
        StateTextBox.Enabled = True
        ZipCodeTextBox.Enabled = True
        BeginOdometerTextBox.Enabled = True
        EndOdometerTextBox.Enabled = True
        DaysTextBox.Enabled = True
        AAAcheckbox.Enabled = True
        Seniorcheckbox.Enabled = True
        MilesradioButton.Enabled = True
        KilometersradioButton.Enabled = True
        CalculateButton.Enabled = True

        MilesradioButton.Checked = True
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False

        TotalMilesTextBox.Clear()
        MileageChargeTextBox.Clear()
        DayChargeTextBox.Clear()
        TotalDiscountTextBox.Clear()
        TotalChargeTextBox.Clear()
        NameTextBox.Clear()
        AddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipCodeTextBox.Clear()
        BeginOdometerTextBox.Clear()
        EndOdometerTextBox.Clear()
        DaysTextBox.Clear()

        name = ""
        address = ""
        state = ""
        city = ""

        zip = Nothing
        begin = Nothing
        endO = Nothing
        days = Nothing
        miles = Nothing
        mileage = Nothing
        discount = Nothing
        totalCost = Nothing

        zipViable = False
        beginOdometerViable = False
        endOdometerViable = False
        daysViable = False
    End Sub

    'Shows the total revenue from the day, how many customers have been helped, and total miles the cars have driven in a message box
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox($"
Total number of customers:          {overallCustomers}
Total distance driven (in miles):   {overallMiles}mi
Total charges:                                ${overallRevenue}")
        ClearButton.PerformClick()
    End Sub

    'Makes sure the user wants to leave the form with a yes/no message box. If they don't, nothing happens. If they do the program ends.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        answerYes = CInt(MsgBox("Do you wish to quit?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Exit Menu"))
        If answerYes = vbYes Then
            End
        Else

        End If
    End Sub

    'Clicks the calculate button when the claculate option is selected in the file menu if the calculate button is enabled
    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        If CalculateButton.Enabled Then
            CalculateButton.PerformClick()
        Else
            MsgBox("This function is not currently available. Click clear to enter a new customers information")
        End If
    End Sub

    'Clicks the clear button when the clear option is selected in the file menu
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearButton.PerformClick()
    End Sub

    'Clicks the summary button when the clear option is selected in the file menu if the summary button is enabled
    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        If SummaryButton.Enabled Then
            SummaryButton.PerformClick()
        Else
            MsgBox("This function is not currently available. Fill out the information for at least one customer first.")
        End If
    End Sub

    'Clicks the exit button when the exit option is selected in the file menu
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ExitButton.PerformClick()
    End Sub
End Class
