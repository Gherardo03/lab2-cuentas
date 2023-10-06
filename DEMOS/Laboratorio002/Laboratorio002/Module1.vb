Module Module1

    Sub Main()

        Dim totalCompra As Double = 0

        While True
            Console.WriteLine("Ingrese el costo del artículo vendido (o un número negativo para salir): ")
            Dim costo As Double = Convert.ToDouble(Console.ReadLine())

            If costo < 0 Then
                Exit While
            End If

            Console.WriteLine("Ingrese la cantidad de dinero entregada por el cliente: ")
            Dim dineroEntregado As Double = Convert.ToDouble(Console.ReadLine())

            If costo > 500 Then
                costo *= 0.95 ' Aplicar un 5% de descuento si el costo supera los $500
            ElseIf costo > 1000 Then
                costo *= 0.9 ' Aplicar un 10% de descuento si el costo supera los $1000
            End If

            If dineroEntregado > costo Then
                Dim cambio As Double = dineroEntregado - costo
                Console.WriteLine("Cambio a entregar: $" & cambio)
            ElseIf dineroEntregado = costo Then
                Console.WriteLine("Entrega del producto.")
            Else
                Console.WriteLine("El cliente debe pagar $" & (costo - dineroEntregado) & " más para completar la compra.")
                Console.WriteLine("El cliente no posee suficiente dinero. Vuelva pronto por el producto que desea.
                    Recibido por Mauricio Alberto Mendoza Y Gerardo Alexander Cabrera")
            End If

            totalCompra += costo
        End While

        Console.WriteLine("Total de la venta: $" & totalCompra)
        Console.ReadLine()
    End Sub

End Module
