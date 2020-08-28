Option Strict On
Option Explicit On
Option Compare Binary


Module TrapingErrors

    Sub Main()

        Dim userInput As String
        Dim userNumber As Integer



        Do
            'While userInput <> "Q" Or userInput <> "q"
            Console.WriteLine("type a numer and press enter. enter Q to quit.")
            userInput$ = Console.ReadLine()
            Try
                'try to convert user input from string to integer
                userNumber% = CInt(userInput$)
                Console.WriteLine(userInput & "+ 5 is: ")
                Console.WriteLine(userNumber% + 5)
            Catch ex As InvalidCastException
                Console.WriteLine("I asked  for a number.... you entered: " & userInput)
            Catch ex As InvalidCastException
                Console.WriteLine(userInput & "is to big!!")
            Catch ex As Exception
                Console.WriteLine("you broke it!!")
                Console.WriteLine(ex.Message)
            Finally
                'alway runs
            End Try
            'End While
        Loop Until userInput$ = "Q" Or userInput$ = "q"


        Console.ReadLine()

    End Sub

End Module
