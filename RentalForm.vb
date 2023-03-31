Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Dim name As String
    Dim address As String
    Dim city As String
    Dim state As String
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

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SummaryButton.Enabled = False
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        name = NameTextBox.Text
    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged
        address = AddressTextBox.Text
    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged
        city = CityTextBox.Text
    End Sub

    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged
        state = StateTextBox.Text
    End Sub

    Private Sub ZipCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipCodeTextBox.TextChanged
        Try
            zip = CInt(ZipCodeTextBox.Text)
            If Len(zip) < 5 Then
                zipViable = False
            Else
                zipViable = True
            End If

        Catch ex As Exception
            zipViable = False
        End Try
    End Sub

    Private Sub BeginOdometerTextBox_TextChanged(sender As Object, e As EventArgs) Handles BeginOdometerTextBox.TextChanged
        Try
            begin = CInt(BeginOdometerTextBox.Text)
            beginOdometerViable = True
        Catch ex As Exception
            beginOdometerViable = False
        End Try
    End Sub

    Private Sub EndOdometerTextBox_TextChanged(sender As Object, e As EventArgs) Handles EndOdometerTextBox.TextChanged
        Try
            endO = CInt(EndOdometerTextBox.Text)
            endOdometerViable = True
        Catch ex As Exception
            endOdometerViable = False
        End Try
    End Sub

    Private Sub DaysTextBox_TextChanged(sender As Object, e As EventArgs) Handles DaysTextBox.TextChanged
        Try
            days = CInt(DaysTextBox.Text)
            daysViable = True
        Catch ex As Exception
            daysViable = False
        End Try
    End Sub

    Private Sub MilesradioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MilesradioButton.CheckedChanged
        If KilometersradioButton.Checked = True Then
            KilometersradioButton.Checked = False
        ElseIf MilesradioButton.Checked = False Then
            MilesradioButton.Checked = True
        End If
    End Sub

    Private Sub KilometersradioButton_CheckedChanged(sender As Object, e As EventArgs) Handles KilometersradioButton.CheckedChanged
        If MilesradioButton.Checked = True Then
            MilesradioButton.Checked = False
        ElseIf KilometersradioButton.Checked = False Then
            KilometersradioButton.Checked = True
        End If
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If NameTextBox.Text = "" Or AddressTextBox.Text = "" Or CityTextBox.Text = "" Or StateTextBox.Text = "" Or ZipCodeTextBox.Text = "" Or BeginOdometerTextBox.Text = "" Or EndOdometerTextBox.Text = "" Or DaysTextBox.Text = "" Then
            MsgBox("You must fill in all sections.")
            If NameTextBox.Text = "" Then
                NameTextBox.Focus()
            ElseIf AddressTextBox.Text = "" Then
                AddressTextBox.Focus()
            ElseIf CityTextBox.Text = "" Then
                CityTextBox.Focus()
            ElseIf StateTextBox.Text = "" Then
                StateTextBox.Focus()
            ElseIf ZipCodeTextBox.Text = "" Then
                ZipCodeTextBox.Focus()
            ElseIf BeginOdometerTextBox.Text = "" Then
                BeginOdometerTextBox.Focus()
            ElseIf EndOdometerTextBox.Text = "" Then
                EndOdometerTextBox.Focus()
            ElseIf DaysTextBox.Text = "" Then
                DaysTextBox.Focus()
            End If
        ElseIf zipViable = False Then
            MsgBox("You must input a valid zipcode.")
            ZipCodeTextBox.Focus()
            ZipCodeTextBox.Text = ""
        ElseIf beginOdometerViable = False Then
            MsgBox("You must input a beginning odometer value in numbers.")
            BeginOdometerTextBox.Focus()
            BeginOdometerTextBox.Text = ""
        ElseIf endOdometerViable = False Then
            MsgBox("You must input an ending odometer value in numbers.")
            EndOdometerTextBox.Focus()
            EndOdometerTextBox.Text = ""
        ElseIf begin >= endO Then
            MsgBox("The input odometer values is invalid. Make sure the beginning odometer value is less than the ending.")
            BeginOdometerTextBox.Focus()
            BeginOdometerTextBox.Text = ""
            EndOdometerTextBox.Text = ""
        ElseIf days <= 0 Or days > 45 Then
            MsgBox("The input days is invalid. The amount of days must be greater then 0 and no more than 45.")
            DaysTextBox.Focus()
            DaysTextBox.Text = ""
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


        End If
    End Sub

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

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox($"
Total number of customers:          {overallCustomers}
Total distance driven (in miles):   {overallMiles}mi
Total charges:                                ${overallRevenue}")
        ClearButton.PerformClick()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        answerYes = CInt(MsgBox("Do you Wish to quit?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Exit Menu"))
        If answerYes = vbYes Then
            End
        Else

        End If
    End Sub
End Class
