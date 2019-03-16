'Name: Alan Carruthers
'Date : 2/22/2019
'Description: This file will take 7 inputs (one per day) for the number of units shipped on a given day over a week for an employee. It will store the values
' in an array, sum them, and then calculate and display the average number of units shipped per week to the user. It will then repeat for the
' remaining employees until it calculates the company average at the very end.
Option Strict On

Public Class frmAverageUnitsShipped
    'Variable Declaration
    Dim sum As Integer = 0                                               ' Integer to hold the calculated sum of shipped units per employee
    Dim empAverage As Double = 0                                         ' Double to hold the calculated average for the employees
    Dim compAverage As Double = 0                                        ' Double to hold the calculated average for the company
    Const numEmployees As Integer = 3                                    ' Number of employees being used for array
    Const numDays As Integer = 7                                         ' Number of days to calculate for
    Const unitsMax As Integer = 1000                                     ' Max # of units that can be shipped in 1 day
    Const unitsMin As Integer = 0                                        ' Min # of units that can be shipped in 1 day
    Dim unitsArray(numEmployees, numDays) As Integer                     ' Array to store the units shipped for each day
    Dim currentDay As Integer = 1                                        ' Integer for storing the current day for the array and textbox
    Dim convertedInput As Integer                                        ' String for user input
    Dim userInput As String                                              ' User input
    Dim inputValidated As Boolean = False                                ' Boolean for input validation
    Dim arrayCounter As Integer = 0                                      ' Counter to keep track of which employee is being used

    ''' <summary>
    ''' This function will check if a user's input if valid and return True or False
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    Public Function validation(input As String) As Boolean
        'Check if input can be parsed and is within range. Return result.
        If Integer.TryParse(input, convertedInput) AndAlso (convertedInput <= unitsMax) AndAlso (convertedInput >= unitsMin) Then
            inputValidated = True
        Else
            inputValidated = False
        End If
        Return inputValidated
    End Function

    ''' <summary>
    ''' This button will accept the current text in the input textbox as an input
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        userInput = txtInput.Text  ' Assign input textbox entry to userInput variable
        validation(userInput)      ' Call validation method to valide user's input

        ' If the current day is 1-7, continue normal loop
        If (currentDay < numDays) Then
            'If input isn't validated, empty input box and return focus to it and display an error box
            If (inputValidated = False) Then
                MessageBox.Show("Input must be a whole number between 0 and 1000 inclusive. Please try again.")
                txtInput.Focus()
                txtInput.Text = ""
                ' if input is valid
            ElseIf (inputValidated = True) Then
                inputValidated = False
                txtInput.Focus()
                txtInput.Text = ""
                unitsArray(arrayCounter, currentDay - 1) = convertedInput   ' Assign validated input to proper array slot
                currentDay += 1 ' Increment day counter to advance days
                lblDay.Text = "Day " & currentDay
                ' Determine which label to output the user's input to
                If (arrayCounter = 0) Then
                    txtEmp1Display.Text += convertedInput & vbCrLf
                ElseIf (arrayCounter = 1) Then
                    txtEmp2Display.Text += convertedInput & vbCrLf
                ElseIf (arrayCounter = 2) Then
                    txtEmp3Display.Text += convertedInput & vbCrLf
                End If
            End If
            ' If current day is over 7...
        Else
            If (inputValidated = False) Then
                MessageBox.Show("Input must be a whole number between 0 and 1000 inclusive. Please try again.")
                txtInput.Focus()
                txtInput.Text = ""
            ElseIf (inputValidated = True) Then
                inputValidated = False
                txtInput.Focus()
                txtInput.Text = ""
                unitsArray(arrayCounter, currentDay - 1) = convertedInput
                currentDay = 1
                lblDay.Text = "Day " & currentDay
                ' For loop to sum the current employee's shipped units
                For i As Integer = 0 To numDays - 1
                    sum += unitsArray(arrayCounter, i)
                Next i
                arrayCounter += 1     ' Move on to the next employee
                empAverage = sum / numDays ' Calculate the current employee's average
                ' Determine which label to display the average in
                If (arrayCounter = 1) Then
                    txtEmp1Display.Text += convertedInput & vbCrLf
                    lblEmp1Avg.Text = Format(Convert.ToString(empAverage), "Standard")
                ElseIf (arrayCounter = 2) Then
                    txtEmp2Display.Text += convertedInput & vbCrLf
                    lblEmp2Avg.Text = Format(Convert.ToString(empAverage), "Standard")
                ElseIf (arrayCounter = 3) Then
                    txtEmp3Display.Text += convertedInput & vbCrLf
                    lblEmp3Avg.Text = Format(Convert.ToString(empAverage), "Standard")
                End If
                sum = 0 ' Reset sum
                empAverage = 0 ' Reset average
            End If
        End If

            ' Once every employee has 7 inputs
            If (arrayCounter >= 3) Then
            ' Nested for loop to sum the entire array
            For i As Integer = 0 To numEmployees - 1
                For j As Integer = 0 To numDays - 1
                    sum += unitsArray(i, j)
                Next j
            Next i
            ' Calculate the total average and display to user, then disable entry button and textbox.
            compAverage = sum / (numDays * numEmployees)
            lblCompAvg.Text = Format(Convert.ToString(compAverage), "Standard")
            txtInput.ReadOnly = True
            txtInput.Enabled = False
            btnEnter.Enabled = False
            btnReset.Focus()
        End If
    End Sub

    ''' <summary>
    ''' This button will reset the entire form to its default state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset all fields to empty text and make sure input textbox and enter button are both active, then reset appropriate variables
        txtInput.ReadOnly = False
        inputValidated = False
        txtInput.Text = ""
        btnEnter.Enabled = True
        txtInput.Enabled = True
        txtEmp1Display.Text = ""
        txtEmp2Display.Text = ""
        txtEmp3Display.Text = ""
        lblEmp1Avg.Text = ""
        lblEmp2Avg.Text = ""
        lblEmp3Avg.Text = ""
        lblCompAvg.Text = ""
        txtInput.Focus()
        currentDay = 1
        lblDay.Text = "Day 1"
        sum = 0
        compAverage = 0
        empAverage = 0
        arrayCounter = 0
        Array.Clear(unitsArray, 0, unitsArray.Length)
    End Sub

    ''' <summary>
    ''' This button will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Application.Exit()
    End Sub
End Class
