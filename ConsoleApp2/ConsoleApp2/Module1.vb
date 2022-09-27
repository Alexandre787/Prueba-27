Module Module1

    Sub Main()
        Dim catetoA, catetoB, hipotenusa As Double
        Console.WriteLine("Introduzca valor cateto A: ")
        catetoA = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Introduzca valor cateto B: ")
        catetoB = Convert.ToDouble(Console.ReadLine)

        'Calcula
        'hipotenusa = Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2)
        'hipotenusa = Math.Sqrt(hipotenusa)
        hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2))
        hipotenusa = Math.Round(hipotenusa, 2)
        Console.WriteLine("La hipotenusa es: " & hipotenusa)
        Console.ReadLine()





    End Sub

End Module
