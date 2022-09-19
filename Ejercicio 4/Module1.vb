Module Module1

    Sub Main()
        Dim num As Integer
        Dim i = 1
        Dim Factorial = 1

        Console.WriteLine("Ingrese un numero entero")
        num = Console.ReadLine

        While i <= num
            Factorial *= i
            i += 1
        End While
        Console.WriteLine("El factorial del numero {0} es: {1}", num, Factorial)

    End Sub

End Module
