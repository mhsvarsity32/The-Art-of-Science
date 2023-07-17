Public Class Form1

'Declare variables
Dim strTitle As String
Dim intWidth As Integer
Dim intHeight As Integer
 
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 
    'Set form title
    strTitle = "The Art of Science"
    
    'Set form size
    intWidth = 700
    intHeight = 500
    
    'Set form size
    Me.Size = New Size(intWidth, intHeight)
    
    'Set form title
    Me.Text = strTitle
    
    '     
    
End Sub

'------------
 
Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
 
    'Declare variables
    Dim strInput As String
    Dim intA As Integer
    Dim intB As Integer
    Dim intAnswer As Integer
 
    'Get user input
    strInput = InputBox("Enter the first number:")
 
    'Convert input from String to Integer
    intA = CInt(strInput)
 
    'Get user input
    strInput = InputBox("Enter the second number:")
 
    'Convert input from String to Integer
    intB = CInt(strInput)
 
    'Process the data
    intAnswer = intA + intB
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
 
    'Declare variables
    Dim strInput As String
    Dim intA As Integer
    Dim intB As Integer
    Dim intAnswer As Integer
 
    'Get user input
    strInput = InputBox("Enter the first number:")
 
    'Convert input from String to Integer
    intA = CInt(strInput)
 
    'Get user input
    strInput = InputBox("Enter the second number:")
 
    'Convert input from String to Integer
    intB = CInt(strInput)
 
    'Process the data
    intAnswer = intA * intB
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
 
    'Declare variables
    Dim strInput As String
    Dim intA As Integer
    Dim intB As Integer
    Dim intAnswer As Integer
 
    'Get user input
    strInput = InputBox("Enter the first number:")
 
    'Convert input from String to Integer
    intA = CInt(strInput)
 
    'Get user input
    strInput = InputBox("Enter the second number:")
 
    'Convert input from String to Integer
    intB = CInt(strInput)
 
    'Process the data
    intAnswer = intA - intB
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
 
    'Declare variables
    Dim strInput As String
    Dim intA As Integer
    Dim intB As Integer
    Dim intAnswer As Integer
 
    'Get user input
    strInput = InputBox("Enter the first number:")
 
    'Convert input from String to Integer
    intA = CInt(strInput)
 
    'Get user input
    strInput = InputBox("Enter the second number:")
 
    'Convert input from String to Integer
    intB = CInt(strInput)
 
    'Process the data
    intAnswer = intA \ intB
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
 
    'Declare variables
    Dim strInput As String
    Dim intA As Integer
    Dim intB As Integer
    Dim intAnswer As Integer
 
    'Get user input
    strInput = InputBox("Enter the first number:")
 
    'Convert input from String to Integer
    intA = CInt(strInput)
 
    'Get user input
    strInput = InputBox("Enter the second number:")
 
    'Convert input from String to Integer
    intB = CInt(strInput)
 
    'Process the data
    intAnswer = intA Mod intB
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
 
    'Declare variables
    Dim strInput1 As String
    Dim strInput2 As String
    Dim strAnswer As String
 
    'Get user input
    strInput1 = InputBox("Enter the first string:")
 
    'Get user input
    strInput2 = InputBox("Enter the second string:")
 
    'Process the data
    strAnswer = strInput1 & strInput2
 
    'Display the answer
    MessageBox.Show("The answer is: " & strAnswer)
    
End Sub

'------------

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
	
    'Declare variables
    Dim strInput1 As String
    Dim strInput2 As String
    Dim strAnswer As String
 
    'Get user input
    strInput1 = InputBox("Enter the first string:")
 
    'Get user input
    strInput2 = InputBox("Enter the second string:")
 
    'Process the data
    strAnswer = strInput1 + strInput2
 
    'Display the answer
    MessageBox.Show("The answer is: " & strAnswer)
    
End Sub

'------------

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
 
    'Declare variables
    Dim strInput1 As String
    Dim strInput2 As String
    Dim strAnswer As String
 
    'Get user input
    strInput1 = InputBox("Enter the first string:")
 
    'Get user input
    strInput2 = InputBox("Enter the second string:")
 
    'Process the data
    strAnswer = strInput1 & " " & strInput2
 
    'Display the answer
    MessageBox.Show("The answer is: " & strAnswer)
    
End Sub

'------------

Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = intInput \ 10
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = intInput Mod 10
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = intInput \ 100
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = intInput Mod 100
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = intInput \ 1000
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = intInput Mod 1000
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = (intInput \ 10) Mod 10
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = (intInput \ 100) Mod 10
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
 
    'Declare variables
    Dim intInput As Integer
    Dim intAnswer As Integer
 
    'Get user input
    intInput = CInt(InputBox("Enter a number:"))
 
    'Process the data
    intAnswer = (intInput \ 1000) Mod 10
 
    'Display the answer
    MessageBox.Show("The answer is: " & intAnswer)
    
End Sub

'------------

End Class