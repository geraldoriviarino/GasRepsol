Public Class LineaFactura

    Private producto As Producto
    Private cantidad As Integer = 1

    Public Sub New(ByVal producto As Producto)
        Me.producto = producto
    End Sub

    Public Function getProducto() As Producto
        Return Me.producto
    End Function

    Public Function getCantidad() As Integer
        Return Me.cantidad
    End Function

    Public Sub incrementarCantidad()
        cantidad = cantidad + 1
    End Sub

    Public Sub decrementarCantidad()
        cantidad = cantidad - 1
    End Sub

End Class
