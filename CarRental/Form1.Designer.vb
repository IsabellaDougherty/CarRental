<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.BeginningOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.NumberOfDaysLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(188, 11)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CustomerNameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(188, 40)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 23)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(188, 69)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(188, 98)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StateTextBox.TabIndex = 3
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(188, 127)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ZipTextBox.TabIndex = 4
        '
        'BeginningOdometerReadingTextBox
        '
        Me.BeginningOdometerReadingTextBox.Location = New System.Drawing.Point(188, 156)
        Me.BeginningOdometerReadingTextBox.Name = "BeginningOdometerReadingTextBox"
        Me.BeginningOdometerReadingTextBox.Size = New System.Drawing.Size(100, 23)
        Me.BeginningOdometerReadingTextBox.TabIndex = 5
        '
        'EndingOdometerReadingTextBox
        '
        Me.EndingOdometerReadingTextBox.Location = New System.Drawing.Point(188, 185)
        Me.EndingOdometerReadingTextBox.Name = "EndingOdometerReadingTextBox"
        Me.EndingOdometerReadingTextBox.Size = New System.Drawing.Size(100, 23)
        Me.EndingOdometerReadingTextBox.TabIndex = 6
        '
        'NumberOfDaysTextBox
        '
        Me.NumberOfDaysTextBox.Location = New System.Drawing.Point(188, 214)
        Me.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox"
        Me.NumberOfDaysTextBox.Size = New System.Drawing.Size(100, 23)
        Me.NumberOfDaysTextBox.TabIndex = 7
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(12, 14)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(94, 15)
        Me.CustomerNameLabel.TabIndex = 8
        Me.CustomerNameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 43)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(49, 15)
        Me.AddressLabel.TabIndex = 9
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(12, 72)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(28, 15)
        Me.CityLabel.TabIndex = 10
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(12, 101)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(33, 15)
        Me.StateLabel.TabIndex = 11
        Me.StateLabel.Text = "State"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(12, 130)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(55, 15)
        Me.ZipLabel.TabIndex = 12
        Me.ZipLabel.Text = "Zip Code"
        '
        'BeginningOdometerReadingLabel
        '
        Me.BeginningOdometerReadingLabel.AutoSize = True
        Me.BeginningOdometerReadingLabel.Location = New System.Drawing.Point(12, 159)
        Me.BeginningOdometerReadingLabel.Name = "BeginningOdometerReadingLabel"
        Me.BeginningOdometerReadingLabel.Size = New System.Drawing.Size(164, 15)
        Me.BeginningOdometerReadingLabel.TabIndex = 13
        Me.BeginningOdometerReadingLabel.Text = "Beginning Odometer Reading"
        '
        'EndingOdometerReadingLabel
        '
        Me.EndingOdometerReadingLabel.AutoSize = True
        Me.EndingOdometerReadingLabel.Location = New System.Drawing.Point(12, 188)
        Me.EndingOdometerReadingLabel.Name = "EndingOdometerReadingLabel"
        Me.EndingOdometerReadingLabel.Size = New System.Drawing.Size(147, 15)
        Me.EndingOdometerReadingLabel.TabIndex = 14
        Me.EndingOdometerReadingLabel.Text = "Ending Odometer Reading"
        '
        'NumberOfDaysLabel
        '
        Me.NumberOfDaysLabel.AutoSize = True
        Me.NumberOfDaysLabel.Location = New System.Drawing.Point(12, 217)
        Me.NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        Me.NumberOfDaysLabel.Size = New System.Drawing.Size(95, 15)
        Me.NumberOfDaysLabel.TabIndex = 15
        Me.NumberOfDaysLabel.Text = "Number Of Days"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumberOfDaysLabel)
        Me.Controls.Add(Me.EndingOdometerReadingLabel)
        Me.Controls.Add(Me.BeginningOdometerReadingLabel)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Controls.Add(Me.NumberOfDaysTextBox)
        Me.Controls.Add(Me.EndingOdometerReadingTextBox)
        Me.Controls.Add(Me.BeginningOdometerReadingTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents BeginningOdometerReadingTextBox As TextBox
    Friend WithEvents EndingOdometerReadingTextBox As TextBox
    Friend WithEvents NumberOfDaysTextBox As TextBox
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents BeginningOdometerReadingLabel As Label
    Friend WithEvents EndingOdometerReadingLabel As Label
    Friend WithEvents NumberOfDaysLabel As Label
End Class
