Imports System
Imports System.Reflection.Metadata.Ecma335

Module Program
    Sub Main(args As String())
        Console.Write("Enter a score: ")
        Dim score As Integer = Console.ReadLine()
        PrintScore(score)

        Console.WriteLine("Enter the price of the product: ")
        Dim price As Decimal = Console.ReadLine()

        Console.WriteLine("Enter the discount: ")
        Dim discount As Decimal = Console.ReadLine()

        CalculateDiscount(price, discount)

        Console.Write("Enter a number: ")
        Dim number As Integer = Console.ReadLine()
        Console.WriteLine(Factorial(number))

        Console.WriteLine(CalculatePriceWithDiscount(price, discount))

        Console.Write("Enter a number: ")
        Dim number2 As Integer = Console.ReadLine()

        Dim result As Integer = CalculateSum(number2)
        Console.WriteLine("The result is {0}", result)
        Console.WriteLine("Price after by Ref: {0}", number2)
    End Sub

    Sub PrintScore(ByVal average As Integer)
        Select Case average
            Case 90 To 100
                Console.WriteLine("You are approved with A")
            Case 70 To 89
                Console.WriteLine("You are approved with B")
            Case 50 To 69
                Console.WriteLine("You are approved with C")
            Case Else
                Console.WriteLine("You failed!")
        End Select
    End Sub

    Sub CalculateDiscount(ByVal price As Decimal, ByVal discount As Decimal)
        discount /= 100
        Console.WriteLine(price * discount)
    End Sub

    Function Factorial(ByVal number As Integer) As Integer
        Dim result As Integer = 1

        For number = number To 1 Step -1
            result *= number
        Next

        Return result
    End Function

    Function CalculatePriceWithDiscount(ByVal price As Decimal, ByVal discount As Decimal) As Decimal
        discount = (100 - discount) / 100

        Return price * discount
    End Function

    'Pass arguments ByVal the value is duplicated and its copy is passed to the procedure
    'so its original value remains the same as passed outside of the procedure

    'Pass arguments ByRef the alterations made in the argument by the procedure
    'are maitained even outside of the procedure

    Function CalculateSum(ByRef number1 As Integer) As Integer
        number1 += number1

        Return number1
    End Function
End Module
