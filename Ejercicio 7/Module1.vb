Module Module1

    Sub Main()
        Dim numero As Integer
        Dim suma = 0
        Dim raiz As Integer


        Console.WriteLine("Ingrese un numero entero")
        numero = Console.ReadLine

        While numero > 0
            Dim digito As Integer = (numero Mod 10)
            numero /= 10
            suma += digito
            If suma > 9 Then
                While suma > 0
                    raiz += (suma Mod 10)
                    suma /= 10
                End While
                suma = raiz
            End If
        End While


        Console.WriteLine("La raiz digital del numero es: {0}", suma)

    End Sub

End Module
