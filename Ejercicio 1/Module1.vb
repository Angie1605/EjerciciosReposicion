Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer

        Console.WriteLine("Escriba el valor de X")
        num1 = Console.ReadLine()
        Console.WriteLine("Escriba el valor de Y")
        num2 = Console.ReadLine()
        Console.WriteLine("La potencia es: ")
        Console.WriteLine(potencia(num1, num2))



    End Sub
    Public Function potencia(num1 As Integer, num2 As Integer) As Integer

        Return (num1 ^ num2)

    End Function
End Module
