Module Module1

    Sub Main()
        Dim numero As Integer

        Console.WriteLine("Ingrese un numero")
        numero = Console.ReadLine
        Console.WriteLine("Piramide")
        For i As Integer = 1 To numero Step 1

            For j As Integer = 1 To i Step 1

                Console.Write(i)
            Next
            Console.WriteLine("  ")
        Next




    End Sub

End Module
