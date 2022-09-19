Module Module1

    Sub Main()

        Dim num1 As Integer


        Console.WriteLine("Ingrese el primer numero")
        num1 = Console.ReadLine
        While num1 <> 1
            If num1 Mod 2 = 0 Then
                num1 /= 2
            ElseIf num1 Mod 2 <> 0 Then
                num1 = (num1 * 3) + 1

            End If

            Console.WriteLine(num1)

        End While

    End Sub

End Module
