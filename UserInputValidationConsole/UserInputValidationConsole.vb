Option Explicit On
Option Strict On
Option Compare Text

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
        Dim exitFlag As Boolean = False

        Do
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
                'use select case to see if the usernumber is within desired range
                Select Case userNumber
                    Case <= 0
                        Console.WriteLine("I'm sorry, the number should be greater than 0.")
                    Case > 10
                        Console.WriteLine("I'm sorry, the number should be less than 11.")
                    Case 1 To 10
                        Console.WriteLine("Good Job! Your number is within the range asked for.")
                    Case Else
                        Console.WriteLine("Uhhhh.... You aren't suppose to see this.")
                End Select
            Catch ex As Exception
                'option compare text is set to be not case sensitive
                If userInput = "q" Then
                    'if userInput is not a number run the 'catch' code
                    exitFlag = True
                Else
                    Console.WriteLine($"Sorry... {userInput} is not a number.")
                End If
            End Try
        Loop Until exitFlag = True
        Console.WriteLine("Have a nice day!")
        Console.WriteLine("Press enter to exit")

        'pause for user to read console before exit
        Console.Read()
    End Sub

End Module
