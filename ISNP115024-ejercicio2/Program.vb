Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Integer
        Do
            // Solicita un número entre 1 y 10
            Console.Write("Introduce un número entre 1 y 10 (0 para salir): ")
            numero = Integer.Parse(Console.ReadLine())

            //Verifica si el número está entre 1 y 10 
            If numero >= 1 And numero <= 10 Then
                // Muestra la tabla de multiplicar
                Console.WriteLine("Tabla de multiplicar del " & numero)
                For i As Integer = 1 To 10
                    Console.WriteLine(numero & " x " & i & " = " & numero * i)
                Next
            ElseIf numero <> 0 Then
                // Si el número no está en el rango permitido
                Console.WriteLine("Por favor, introduce un número entre 1 y 10.")
            End If

            // Termina el bucle cuando el usuario ingrese 0
        Loop While numero <> 0

        // Mensaje de salida del programa
        Console.WriteLine("Fin del programa.")

    End Sub

End Module