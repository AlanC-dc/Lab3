<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblEmp1Avg = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtEmp1Display = New System.Windows.Forms.TextBox()
        Me.txtEmp2Display = New System.Windows.Forms.TextBox()
        Me.lblEmp2Avg = New System.Windows.Forms.Label()
        Me.txtEmp3Display = New System.Windows.Forms.TextBox()
        Me.lblEmp3Avg = New System.Windows.Forms.Label()
        Me.lblCompAvg = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(12, 39)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(48, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtInput.Location = New System.Drawing.Point(66, 41)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(62, 22)
        Me.txtInput.TabIndex = 2
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtInput, "Input the number of units shipped for the current day")
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(13, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(47, 23)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmp1Avg
        '
        Me.lblEmp1Avg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp1Avg.Location = New System.Drawing.Point(16, 226)
        Me.lblEmp1Avg.Name = "lblEmp1Avg"
        Me.lblEmp1Avg.Size = New System.Drawing.Size(116, 29)
        Me.lblEmp1Avg.TabIndex = 9
        Me.lblEmp1Avg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblEmp1Avg, "Displays the calculated average units shipped for employee 1")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(16, 306)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(116, 33)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnEnter, "Confirm current textbox input")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(138, 306)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 33)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnReset, "Reset the entire application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(252, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 33)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnExit, "Exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtEmp1Display
        '
        Me.txtEmp1Display.Location = New System.Drawing.Point(16, 89)
        Me.txtEmp1Display.Multiline = True
        Me.txtEmp1Display.Name = "txtEmp1Display"
        Me.txtEmp1Display.ReadOnly = True
        Me.txtEmp1Display.Size = New System.Drawing.Size(116, 134)
        Me.txtEmp1Display.TabIndex = 6
        Me.txtEmp1Display.TabStop = False
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtEmp1Display, "Displays all previous day inputs")
        '
        'txtEmp2Display
        '
        Me.txtEmp2Display.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp2Display.Location = New System.Drawing.Point(138, 89)
        Me.txtEmp2Display.Multiline = True
        Me.txtEmp2Display.Name = "txtEmp2Display"
        Me.txtEmp2Display.ReadOnly = True
        Me.txtEmp2Display.Size = New System.Drawing.Size(108, 134)
        Me.txtEmp2Display.TabIndex = 7
        Me.txtEmp2Display.TabStop = False
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtEmp2Display, "Displays all previous day inputs")
        '
        'lblEmp2Avg
        '
        Me.lblEmp2Avg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp2Avg.Location = New System.Drawing.Point(138, 226)
        Me.lblEmp2Avg.Name = "lblEmp2Avg"
        Me.lblEmp2Avg.Size = New System.Drawing.Size(108, 29)
        Me.lblEmp2Avg.TabIndex = 10
        Me.lblEmp2Avg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblEmp2Avg, "Displays the calculated average units shipped for employee 2")
        '
        'txtEmp3Display
        '
        Me.txtEmp3Display.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp3Display.Location = New System.Drawing.Point(252, 89)
        Me.txtEmp3Display.Multiline = True
        Me.txtEmp3Display.Name = "txtEmp3Display"
        Me.txtEmp3Display.ReadOnly = True
        Me.txtEmp3Display.Size = New System.Drawing.Size(123, 134)
        Me.txtEmp3Display.TabIndex = 8
        Me.txtEmp3Display.TabStop = False
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtEmp3Display, "Displays all previous day inputs")
        '
        'lblEmp3Avg
        '
        Me.lblEmp3Avg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp3Avg.Location = New System.Drawing.Point(252, 226)
        Me.lblEmp3Avg.Name = "lblEmp3Avg"
        Me.lblEmp3Avg.Size = New System.Drawing.Size(123, 29)
        Me.lblEmp3Avg.TabIndex = 11
        Me.lblEmp3Avg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblEmp3Avg, "Displays the calculated average units shipped for employee 3")
        '
        'lblCompAvg
        '
        Me.lblCompAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCompAvg.Location = New System.Drawing.Point(16, 270)
        Me.lblCompAvg.Name = "lblCompAvg"
        Me.lblCompAvg.Size = New System.Drawing.Size(359, 33)
        Me.lblCompAvg.TabIndex = 12
        Me.lblCompAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblCompAvg, "Displays the average of all 3 employees")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(25, 66)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(148, 66)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(269, 66)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(387, 345)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblCompAvg)
        Me.Controls.Add(Me.lblEmp3Avg)
        Me.Controls.Add(Me.txtEmp3Display)
        Me.Controls.Add(Me.lblEmp2Avg)
        Me.Controls.Add(Me.txtEmp2Display)
        Me.Controls.Add(Me.txtEmp1Display)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblEmp1Avg)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblEmp1Avg As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageUnitsShippedTips As ToolTip
    Friend WithEvents txtEmp1Display As TextBox
    Friend WithEvents txtEmp2Display As TextBox
    Friend WithEvents lblEmp2Avg As Label
    Friend WithEvents txtEmp3Display As TextBox
    Friend WithEvents lblEmp3Avg As Label
    Friend WithEvents lblCompAvg As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
End Class
