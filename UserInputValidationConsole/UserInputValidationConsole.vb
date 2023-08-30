Option Explicit On
Option Strict On

Module UserInputValidationConsole

    Sub Main()
        'TO DO
        'Prompt user for number between 1 and 10 or "q" to quit
        'reflect the user input to console
        'Check if the input is a number
        'if user enteted "q" or "Q" then quit the program
        'Check if the input is within bounds
        'Continue "loop" until the user uneter a valid number or enters "q"
        'If yes congradulate the user and start over

        Dim userInput As String
        Dim userNumber As Integer

        'initial prompt
        Console.WriteLine("Please enter a number from 1 to 10")
        Console.WriteLine("Enter 'q' to quit")

        'Get user input
        userInput = Console.ReadLine()
        'reflect the user input back to the console
        Console.WriteLine($"You entered: {userInput}")

        'attempt to convert the user input to an integer
        Try
            userNumber = CInt(userInput)
        Catch ex As Exception
            Console.WriteLine($"Sorry... {userInput} is not a number.")
        End Try

        'pause for user to read console before exit
        Console.Read()
    End Sub

End Module
