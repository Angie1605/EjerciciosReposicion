Module Module1

    Sub Main()

        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma As Integer
        Dim i As Integer

        Console.WriteLine("Ingrese el primer numero")
        num1 = Console.ReadLine
        Console.WriteLine("Ingrese el segundo numero")
        num2 = Console.ReadLine
        i = num1

        If num1 < num2 Then
            Do
                suma = num1 + suma
                num1 += 1
                i += 1
                Console.WriteLine("La suma del intervalo es", suma)
            Loop Until (i > num2)
        Else
            Console.WriteLine("No se puede continuar")

        End If


    End Sub

End Module
