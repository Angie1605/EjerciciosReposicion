Module Module1

    Sub Main()
        Dim numero As Integer
        Dim raizDigital As Integer

        Console.WriteLine("Ingrese un numero entero")
        numero = Console.ReadLine

        While numero > 0
            raizDigital += (numero Mod 10)
            numero /= 10
        End While

        Console.WriteLine("La raiz digital del numero es: {0}", raizDigital)

    End Sub

End Module
