Class TheArtOfScience
   Sub Main() 
      
      'Declare Variables
      Dim x As Integer
      Dim y As Integer
      Dim total As Integer
            
      'Write Output
      Console.WriteLine("Welcome to The Art of Science!")
      Console.WriteLine("This program will calculate the sum of two numbers")
      
      'Read user input
      Console.Write("Please enter the first number: ")
      x = Console.ReadLine
      Console.Write("Please enter the second number: ")
      y = Console.ReadLine
      
      'Calculate Total
      total = x + y
      
      'Print Total
      Console.WriteLine("The total sum is " & total)
      
      'Create Loops
      Dim index As Integer
      
      'Begin Loop
      While (index < 10)
         index = index + 1
         Console.WriteLine("The Art of Science is number " & index)
      End While
      
      'End Program
      Console.WriteLine("Thank you for using The Art Of Science!")
      Console.WriteLine("Press any key to exit")
      Console.ReadKey(True)
      
   End Sub
End Class