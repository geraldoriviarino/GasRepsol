

'TODO
'IMPRIMIR 2 TICKETS( con tarjeta) 1 ticket (metalico)
'IMPRIMIR TARJETA ( PARA FABRICARLA CUANDO UN SOCIO SE DA DE ALTA).
'IMPRIMIR 

Imports System.Data.OleDb
Public Class AccesoDatos
    Private strDriver As New String("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Private conexion As New OleDbConnection(strDriver)
    Private dataSet As New DataSet
    Private adaptadorEmpleados As New OleDbDataAdapter("select * from empleados", conexion)
    Private adaptadorSocios As New OleDbDataAdapter("select * from socios", conexion)
    Private lista_campos As New List(Of String)

    '------------------- Constructor -------------------

    Public Sub New()
        lista_campos.Add("nombre")
        lista_campos.Add("apellidos")
        lista_campos.Add("dni")
        lista_campos.Add("telefono")
        lista_campos.Add("email")
        lista_campos.Add("direccion")
        lista_campos.Add("rol")
        lista_campos.Add("fecha")
    End Sub

    '------------------- Gestión de empleados -------------------

    'INSERCIÓN DE EMPLEADO
    Public Function insertar_empleado(ByVal nombre As String, ByVal apellidos As String, ByVal dni As String, ByVal telefono As String, ByVal email As String, ByVal direccion As String, ByVal rol As String, ByVal fecha As String) As DataSet
        Dim comando As OleDbCommand

        Try
            conexion.Open()
            comando = New OleDbCommand("INSERT INTO empleados (nombre, apellidos, dni, telefono, email, direccion, rol, fecha) VALUES (@nombre, @apellidos, @dni, @telefono, @email, @direccion, @rol, @fecha)", conexion)


            comando.Parameters.AddWithValue("nombre", nombre)
            comando.Parameters.AddWithValue("apellidos", apellidos)
            comando.Parameters.AddWithValue("dni", dni)
            comando.Parameters.AddWithValue("telefono", telefono)
            comando.Parameters.AddWithValue("email", email)
            comando.Parameters.AddWithValue("direccion", direccion)
            comando.Parameters.AddWithValue("rol", rol)
            comando.Parameters.AddWithValue("fecha", fecha)

            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Ha ocurrido un error.")
        End Try

        conexion.Close()
        Return dataSet
        'gridview.DataSource = dataSet
        'gridview.DataMember = "Tabla"

    End Function

    Public Sub eliminar_empleado(ByVal parametros As List(Of String))
        Dim comando As OleDbCommand
        Dim contador_camposValidos As Integer = 0
        Dim sentencia As String = "DELETE FROM empleados WHERE"

        Try
            comando = New OleDbCommand()
            conexion.Open()

            For i = 0 To parametros.Count - 1 'Iteramos la lista de parámetros recibidos
                If parametros(i) Is Nothing Then 'Si no son nulos (el usuario ha introducido un valor), agregamos a la cadena de la sentencia la cláusula where correspondiente a los campo/valor iterados
                    contador_camposValidos = contador_camposValidos + 1
                    comando.Parameters.AddWithValue(lista_campos(i), parametros(i))

                    If contador_camposValidos > 1 Then '
                        sentencia = sentencia & " " & "AND"
                    End If
                    sentencia = sentencia & " " & lista_campos(i) & "=@" & lista_campos(i)
                End If
            Next

            comando.Connection = conexion
            comando.CommandText = sentencia

            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Ha ocurrido un error.")
        End Try

        conexion.Close()
    End Sub

    Public Sub modificar_empleado()

    End Sub

    Public Sub buscar_empleado()

    End Sub

    '------------------- Gestión de socios -------------------

    Public Sub insertar_socio()

    End Sub

    Public Sub eliminar_socio()

    End Sub

    Public Sub modificar_socio()

    End Sub

    Public Sub buscar_socio()

    End Sub

    '------------------- Gestión de métodos útiles -------------------

    'String >>> Integer
    Private Function toInteger(ByVal cadena As String) As Integer
        Dim resultado As Integer = -1
        Try
            resultado = CInt(cadena)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
End Class
