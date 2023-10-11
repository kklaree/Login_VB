Module Module1
    Sub UserLogin()

        Dim username As String = "admin"
        Dim password As String = "password"
        Dim user As String = ""
        Dim pass As String = ""
        Dim attempts As Integer = 3

        Do
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("     LOGIN")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.Write("          Enter username: ")
            user = Console.ReadLine()
            Console.WriteLine("")
            Console.Write("          Enter password: ")
            pass = Console.ReadLine()
            Console.WriteLine("")

            If user = username And pass = password Then
                Console.WriteLine("")
                Console.WriteLine("     Login successful! Press any key to continue...")
                Console.ReadKey()
                Console.Clear()
                Calculation()
            Else
                Console.WriteLine("")
                Console.WriteLine("     Login failed. Press any key to try again.")
                Console.WriteLine("")
                Console.WriteLine("     Attempts remaining: " & attempts - 1)
                Console.WriteLine("")
                attempts -= 1
                Console.ReadKey()
                Console.Clear()

                If attempts = 0 Then
                    LoginFailed()
                End If

            End If

        Loop While user <> username Or pass <> password

    End Sub

    Sub LoginFailed()
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("     Login failed. You have used all your attempts.")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.Write("     Do you want to try again? [ Y / N ]: ")
        Dim opt As String = Console.ReadLine()

        If opt = "y" Or opt = "Y" Then
            Console.Clear()
            UserLogin()
        ElseIf opt = "n" Or opt = "N" Then
            Environment.Exit(0)
        Else
            Console.WriteLine("")
            Console.WriteLine("     Invalid input. Try again")
            Console.ReadKey()
            Console.Clear()
            LoginFailed()
        End If

    End Sub

    Sub Calculation()
        Dim num1 As Double
        Dim num2 As Double
        Dim result As Double
        Dim opt As String

        Try
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("     CALCULATOR")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.Write("          Enter first number: ")
            num1 = Console.ReadLine()
            Console.WriteLine("")
            Console.Write("          Enter second number: ")
            num2 = Console.ReadLine()

            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("     Choose an operation to perform:")
            Console.WriteLine("")
            Console.WriteLine("          Press [1] for Addition")
            Console.WriteLine("          Press [2] for Subtraction")
            Console.WriteLine("          Press [3] for Multiplication")
            Console.WriteLine("          Press [4] for Division")
            Console.WriteLine("          Press [5] to perform all operation")
            Console.WriteLine("          Press [6] to exit")
            Console.WriteLine("")
            Console.Write("          Select an option: ")
            opt = Console.ReadLine()
            Console.WriteLine("")
            Console.WriteLine("")

            If opt = "1" Then
                result = num1 + num2
                Console.WriteLine("     Addition:     " & num1 & " + " & num2 & " = " & result)
                Console.ReadKey()
                Console.Clear()
                CalcuMenu()
            ElseIf opt = "2" Then
                result = num1 - num2
                Console.WriteLine("     Subtraction:     " & num1 & " - " & num2 & " = " & result)
                Console.ReadKey()
                Console.Clear()
                CalcuMenu()
            ElseIf opt = "3" Then
                result = num1 * num2
                Console.WriteLine("     Multiplication:     " & num1 & " x " & num2 & " = " & result)
                Console.ReadKey()
                Console.Clear()
                CalcuMenu()
            ElseIf opt = "4" Then
                result = num1 / num2

                If num2 = 0 Then
                    Console.WriteLine("     Division:     Cannot be divided by zero.")
                    Console.ReadKey()
                    Console.Clear()
                Else
                    Console.WriteLine("     Division:     " & num1 & " / " & num2 & " = " & result)
                    Console.ReadKey()
                    Console.Clear()
                End If

                CalcuMenu()

            ElseIf opt = "5" Then
                result = num1 + num2
                Console.WriteLine("     Addition:           " & num1 & " + " & num2 & " = " & result)
                result = num1 - num2
                Console.WriteLine("     Subtraction:        " & num1 & " - " & num2 & " = " & result)
                result = num1 * num2
                Console.WriteLine("     Multiplication:     " & num1 & " x " & num2 & " = " & result)
                result = num1 / num2

                If num2 = 0 Then
                    Console.WriteLine("     Division:           Cannot be divided by zero.")
                Else
                    Console.WriteLine("     Division:           " & num1 & " / " & num2 & " = " & result)
                End If

                Console.ReadKey()
                Console.Clear()
                CalcuMenu()
            ElseIf opt = "6" Then
                Environment.Exit(0)
            Else
                Console.WriteLine("     Invalid input! Press any key to try again...")
                Console.ReadKey()
                Console.Clear()
                Calculation()
            End If

        Catch ex As Exception
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("     An error occured: " & ex.Message)
            Console.WriteLine("")
            Console.WriteLine("     Press any key to try again...")
            Console.ReadKey()
            Console.Clear()
            Calculation()

        End Try

    End Sub

    Sub CalcuMenu()
        Dim opt As String

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("     Choose an action to perform:")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("          Press [1] to continue using calculator")
        Console.WriteLine("          Press [2] to logout")
        Console.WriteLine("          Press [3] to exit")
        Console.WriteLine("")
        Console.Write("          Select an option: ")
        opt = Console.ReadLine()
        Console.WriteLine("")
        Console.Clear()

        If opt = "1" Then
            Calculation()
        ElseIf opt = "2" Then
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("     Logged out successfully! Press any key to return to login page...")
            Console.ReadKey()
            Console.Clear()
            UserLogin()
        ElseIf opt = "3" Then
            Environment.Exit(0)
        Else
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("     Invalid input! Press any key to try again...")
            Console.ReadKey()
            Console.Clear()
            CalcuMenu()
        End If

    End Sub

    Sub Main()
        UserLogin()
    End Sub

End Module
