Module Module1

    Sub Main()
            Dim costo As Double
            Dim dineroEntregado As Double
            Dim cambio As Double
        Dim totalCompra As Double = 0

        Console.WriteLine("Ingrese el costo del artículo: ")
            costo = Double.Parse(Console.ReadLine())

            Console.WriteLine("Ingrese la cantidad de dinero entregada por el cliente: ")
            dineroEntregado = Double.Parse(Console.ReadLine())

        If dineroEntregado > costo Then
            cambio = dineroEntregado - costo
            Console.WriteLine("Cambio a entregar: $" & cambio)
        ElseIf dineroEntregado = costo Then
            Console.WriteLine("Entrega del producto realizada. Gracias por su compra lo esperamos nuevamente.")

        Else
            Console.WriteLine("El cliente debe pagar $" & (costo - dineroEntregado) & " adicional para completar el pago.")
            Console.WriteLine("¿Desea pagar la cantidad restante? (S/N)")
            Dim opcion As Char = Char.Parse(Console.ReadLine())
            If opcion = "S" Or opcion = "s" Then
                Console.WriteLine("Entrega del producto realizada. Gracias por su compra.")
            Else
                Console.WriteLine("El cliente no posee suficiente dinero. Vuelva pronto por el producto que desea.")
            End If
        End If

        Console.WriteLine("Atendio Mauricio Alberto Y Gerardo Cabrera")

        Console.ReadLine()
        End Sub
    End Module








