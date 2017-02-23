

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

    Private listaCamposEmpleados As New List(Of String)
    Private listaCamposSocios As New List(Of String)

    '------------------- Constructor -------------------

    Public Sub New(ByVal tipoConstructor As String)

        If tipoConstructor Like "constructorEmpleados" Then

            listaCamposEmpleados.Add("nombre")
            listaCamposEmpleados.Add("apellidos")
            listaCamposEmpleados.Add("dni")
            listaCamposEmpleados.Add("telefono")
            listaCamposEmpleados.Add("email")
            listaCamposEmpleados.Add("direccion")
            listaCamposEmpleados.Add("rol")
            listaCamposEmpleados.Add("fecha")

        ElseIf tipoConstructor Like "constructorSocios" Then

            listaCamposSocios.Add("nombre")
            listaCamposSocios.Add("apellidos")
            listaCamposSocios.Add("dni")
            listaCamposSocios.Add("tipo tarjeta")
            listaCamposSocios.Add("telefono")
            listaCamposSocios.Add("dni")
            listaCamposSocios.Add("email")
            listaCamposSocios.Add("direccion")

        End If

    End Sub

    '------------------- Gestión de datos -------------------

    ' Insertar datos dependiendo de la lista de datos recibida y del nombre de la tabla en la cual queremos insertar
    Public Function insertar(ByVal listaDatos As List(Of String), ByVal nombreTabla As String) As DataSet

        Dim comando As OleDbCommand

        Dim sentenciaInsert As String
        Dim stringInsertInto As String = "INSERT INTO" & nombreTabla & "("
        Dim stringValues As String = ") VALUES ("

        If nombreTabla Like "empleados" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 0 To listaCamposEmpleados.Count

                    comando.Parameters.AddWithValue(listaCamposEmpleados(i), listaDatos(i))

                    If i > 1 Then
                        stringInsertInto += "," & listaCamposEmpleados(i)
                        stringValues += ",@" & listaCamposEmpleados(i)
                    Else
                        stringInsertInto += listaCamposEmpleados(i)
                        stringValues += "@" & listaCamposEmpleados(i)
                    End If

                Next

                stringValues += ")"

                sentenciaInsert = stringInsertInto + stringValues

            Catch ex As Exception
                MsgBox("Ha ocurrido un error.")
            End Try

        ElseIf nombreTabla Like "socios" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 0 To listaCamposSocios.Count

                    comando.Parameters.AddWithValue(listaCamposSocios(i), listaDatos(i))

                    If i > 1 Then
                        stringInsertInto += "," & listaCamposSocios(i)
                        stringValues += ",@" & listaCamposSocios(i)
                    Else
                        stringInsertInto += listaCamposSocios(i)
                        stringValues += "@" & listaCamposSocios(i)
                    End If

                Next

                stringValues += ")"

                sentenciaInsert = stringInsertInto + stringValues

            Catch ex As Exception
                MsgBox("Ha ocurrido un error.")
            End Try

        End If

        conexion.Close()
        Return dataSet
        'gridview.DataSource = dataSet
        'gridview.DataMember = "Tabla"

    End Function

    Public Sub eliminar(ByVal listaDatos As List(Of String), ByVal nombreTabla As String)

        Dim comando As OleDbCommand
        Dim contador_camposValidos As Integer = 0
        Dim sentencia As String = "DELETE FROM " & nombreTabla & " WHERE"

        If nombreTabla Like "empleados" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 0 To listaDatos.Count - 1 'Iteramos la lista de parámetros recibidos
                    If listaDatos(i) Is Nothing Then 'Si no son nulos (el usuario ha introducido un valor), agregamos a la cadena de la sentencia la cláusula where correspondiente a los campo/valor iterados
                        contador_camposValidos = contador_camposValidos + 1
                        comando.Parameters.AddWithValue(listaCamposEmpleados(i), listaDatos(i))

                        If contador_camposValidos > 1 Then '
                            sentencia = sentencia & " " & "AND"
                        End If
                        sentencia = sentencia & " " & listaCamposEmpleados(i) & " = @" & listaCamposEmpleados(i)
                    End If
                Next

                comando.Connection = conexion
                comando.CommandText = sentencia

                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Ha ocurrido un error.")
            End Try

        ElseIf nombreTabla Like "socios" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 0 To listaDatos.Count - 1 'Iteramos la lista de parámetros recibidos
                    If listaDatos(i) Is Nothing Then 'Si no son nulos (el usuario ha introducido un valor), agregamos a la cadena de la sentencia la cláusula where correspondiente a los campo/valor iterados
                        contador_camposValidos = contador_camposValidos + 1
                        comando.Parameters.AddWithValue(listaCamposSocios(i), listaDatos(i))

                        If contador_camposValidos > 1 Then '
                            sentencia = sentencia & " " & "AND"
                        End If
                        sentencia = sentencia & " " & listaCamposSocios(i) & "= @" & listaCamposSocios(i)
                    End If
                Next

                comando.Connection = conexion
                comando.CommandText = sentencia

                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Ha ocurrido un error.")
            End Try

        End If

        conexion.Close()

    End Sub

    Public Function modificar(ByVal listaDatos As List(Of String), ByVal nombreTabla As String) As DataSet

        Dim comando As OleDbCommand
        Dim contador_camposValidos As Integer = 0
        Dim sentenciaModificar As String = "UPDATE " & nombreTabla & " SET "

        If nombreTabla Like "empleados" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 1 To listaDatos.Count - 1 'Iteramos la lista de parámetros recibidos
                    If listaDatos(i) IsNot Nothing Then 'Si no son nulos (el usuario ha introducido un valor), agregamos a la cadena de la sentencia la cláusula where correspondiente a los campo/valor iterados
                        contador_camposValidos = contador_camposValidos + 1
                        comando.Parameters.AddWithValue(listaCamposEmpleados(i), listaDatos(i))

                        If contador_camposValidos > 1 Then '
                            sentenciaModificar += ", "
                        End If
                        sentenciaModificar += " " & listaCamposEmpleados(i) & " = @" & listaCamposEmpleados(i)
                    End If
                Next

                sentenciaModificar += "WHERE numero = " & listaDatos(1)

                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Ha ocurrido un error.")
            End Try

        ElseIf nombreTabla Like "socios" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 1 To listaDatos.Count - 1 'Iteramos la lista de parámetros recibidos
                    If listaDatos(i) IsNot Nothing Then 'Si no son nulos (el usuario ha introducido un valor), agregamos a la cadena de la sentencia la cláusula where correspondiente a los campo/valor iterados
                        contador_camposValidos = contador_camposValidos + 1
                        comando.Parameters.AddWithValue(listaCamposSocios(i), listaDatos(i))

                        If contador_camposValidos > 1 Then '
                            sentenciaModificar += ", "
                        End If
                        sentenciaModificar += " " & listaCamposSocios(i) & " = @" & listaCamposSocios(i)
                    End If
                Next

                sentenciaModificar += "WHERE numero = " & listaDatos(1)

                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Ha ocurrido un error.")
            End Try
        End If    

        conexion.Close()
        Return dataSet

    End Function

    Public Function buscar(ByVal listaDatos As List(Of String), ByVal nombreTabla As String) As DataSet

        Dim comando As OleDbCommand
        Dim contador_camposValidos As Integer = 0
        Dim sentenciaBuscar As String = "Select * from " & nombreTabla & " WHERE "

        If nombreTabla Like "empleados" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 0 To listaDatos.Count - 1
                    If listaDatos(i) IsNot Nothing Then
                        contador_camposValidos += 1
                        comando.Parameters.AddWithValue(listaCamposEmpleados(i), conexion)

                        If contador_camposValidos > 1 Then '
                            sentenciaBuscar = sentenciaBuscar & " " & "AND"
                        End If
                        sentenciaBuscar = sentenciaBuscar & " " & listaCamposEmpleados(i) & " = @" & listaCamposEmpleados(i)

                    End If
                Next
            Catch ex As Exception

            End Try

        ElseIf nombreTabla Like "socios" Then

            Try
                comando = New OleDbCommand()
                conexion.Open()

                For i = 0 To listaDatos.Count - 1
                    If listaDatos(i) IsNot Nothing Then
                        contador_camposValidos += 1
                        comando.Parameters.AddWithValue(listaCamposSocios(i), conexion)

                        If contador_camposValidos > 1 Then '
                            sentenciaBuscar = sentenciaBuscar & " " & "AND"
                        End If
                        sentenciaBuscar = sentenciaBuscar & " " & listaCamposSocios(i) & " = @" & listaCamposSocios(i)

                    End If
                Next
            Catch ex As Exception

            End Try

        End If

        Return dataSet
    End Function

    Public Function obtenerTodosRegistros()

        Dim comando As OleDbCommand
        conexion.Open()

        Dim stentenciaBuscarTodos = "SELECT * from empleados"



        Return dataSet
    End Function

End Class
