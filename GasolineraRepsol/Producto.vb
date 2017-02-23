Public Class Producto
    'Código del producto
    Private codigo As Integer
    'Nombre del producto
    Private nombre As String
    'Precio del producto
    Private precio As Single
    'Proveedor del producto

    '----- Métodos getter -----

    'Método getter del atributo código
    Public Function getCodigo() As Integer
        Return Me.codigo
    End Function

    'Método getter del atributo nombre
    Public Function getNombre() As String
        Return Me.nombre
    End Function

    'Método getter del atributo precio
    Public Function getPrecio() As Single
        Return Me.precio
    End Function

End Class
