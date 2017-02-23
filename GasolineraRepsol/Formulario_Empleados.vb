Public Class Formulario_Empleados

    Private expandir_direccion As Boolean = False
    Private mostrar_calendario As Boolean = False
    Private accesoDatos As AccesoDatos

    Private Sub formEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboTipoVia.SelectedIndex = 0
    End Sub

    ' ---- Método con el cual recogemos la lista de datos de los text box
    Private Function rellenarListaDatos() As List(Of String)

        Dim listaDatos As New List(Of String)

        Dim direccion As String
        direccion = comboTipoVia.Text & "," & txtCalle.Text & "," & txtPortal.Text & "," & txtPiso.Text & "," & txtPuerta.Text & "," & txtCodigoPostal.Text & "," & txtLocalidad.Text & "," & txtProvincia.Text

        listaDatos.Add(txtNombreEmpleado.Text)
        listaDatos.Add(txtApellidosEmpleado.Text)
        listaDatos.Add(txtDNI.Text)
        listaDatos.Add(txtTelefonoEmpleado.Text)
        listaDatos.Add(txtMailEmpleado.Text)
        listaDatos.Add(direccion)
        listaDatos.Add(txtRol.Text)
        listaDatos.Add(txtFecha.Text)

        Return listaDatos

    End Function

    ' ------ INSERTAR -------
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        accesoDatos = New AccesoDatos("constructorEmpleados")

        Dim listaDatos As List(Of String)

        listaDatos = rellenarListaDatos()

        accesoDatos.insertar(listaDatos, "empleados")

    End Sub

    ' ------ ELIMINAR ----------
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        accesoDatos = New AccesoDatos("constructorEmpleados")

        Dim listaDatos As List(Of String)

        listaDatos = rellenarListaDatos()

        accesoDatos.eliminar(listaDatos, "empleados")

    End Sub

    ' ------ MODIFICAR -------
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        accesoDatos = New AccesoDatos("constructorEmpleados")
        Dim listaDatos As New List(Of String)

        Dim direccion As String
        direccion = comboTipoVia.Text & "," & txtCalle.Text & "," & txtPortal.Text & "," & txtPiso.Text & "," & txtPuerta.Text & "," & txtCodigoPostal.Text & "," & txtLocalidad.Text & "," & txtProvincia.Text

        listaDatos = rellenarListaDatos()

        accesoDatos.modificar(listaDatos, "empleados")

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        accesoDatos = New AccesoDatos("constructorEmpleados")
        Dim listaDatos As New List(Of String)

        Dim direccion As String
        direccion = comboTipoVia.Text & "," & txtCalle.Text & "," & txtPortal.Text & "," & txtPiso.Text & "," & txtPuerta.Text & "," & txtCodigoPostal.Text & "," & txtLocalidad.Text & "," & txtProvincia.Text

        listaDatos = rellenarListaDatos()

        accesoDatos.buscar(listaDatos, "empleados")

    End Sub

    '----------- Gestión del formulario de dirección -----------

    'Método encargado de rotar la imagen del picturebox.
    Private Sub rotar_imagen()
        Dim bm As Bitmap = pictureDireccion.Image

        If expandir_direccion = False Then
            bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Else
            bm.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If

        Me.pictureDireccion.Image = bm
    End Sub

    'Método encargado de mostrar el formulario de la dirección.
    Private Sub mostrar_panelDireccion()
        If expandir_direccion = False Then
            timerEsconderPanel.Stop()
            timerMostrarPanel.Start()
        Else
            timerMostrarPanel.Stop()
            timerEsconderPanel.Start()
        End If
    End Sub

    'Listener del picturebox pictureLogo
    Private Sub pictureDireccion_Click(sender As Object, e As EventArgs) Handles pictureDireccion.Click
        rotar_imagen()
        mostrar_panelDireccion()

        If expandir_direccion = False Then
            lblDireccionDesplegable.Text = ""
        Else
            lblDireccionDesplegable.Text = "Dirección"
        End If
        expandir_direccion = Not expandir_direccion

    End Sub

    Private Sub timerMostrarPanel_Tick(sender As Object, e As EventArgs) Handles timerMostrarPanel.Tick

    End Sub

    Private Sub timerEsconderPanel_Tick(sender As Object, e As EventArgs) Handles timerEsconderPanel.Tick

    End Sub

    'Método encargado de  posicionar la flecha y el label de la dirección
    Private Sub posicionar_direccion(ByVal x As Integer, ByVal y As Integer)
        pictureDireccion.SetBounds(x, y, pictureDireccion.Width, pictureDireccion.Height)
        lblDireccionDesplegable.SetBounds(x, y, lblDireccionDesplegable.Width, lblDireccionDesplegable.Height)
    End Sub


    '------------------------------------------ Gestión del calendario ------------------------------------------'

    'Método encargado de  posicionar la flecha y el label de la dirección en función del calendario.
    Private Sub mover_direccion()
        If mostrar_calendario = True Then
            posicionar_direccion(pictureDireccion.Location.X, 303)


            If expandir_direccion = True Then
                panelDireccion.SetBounds(panelDireccion.Location.X, 400, panelDireccion.Width, panelDireccion.Height)
            End If
        Else
            posicionar_direccion(pictureDireccion.Location.X, 396)

            If expandir_direccion = True Then
                panelDireccion.SetBounds(panelDireccion.Location.X, 500, panelDireccion.Width, panelDireccion.Height)
            End If
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendario.DateChanged
        txtFecha.Text = CStr(calendario.SelectionRange.Start)
    End Sub

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles btnCalendario.Click
        If mostrar_calendario = False Then
            btnCalendario.SetBounds(169, 287, btnCalendario.Width, btnCalendario.Height)
            panelDatosEmpleado.Height = 428
        Else
            btnCalendario.SetBounds(230, 247, btnCalendario.Width, btnCalendario.Height)
            panelDatosEmpleado.Height = 350
            If Height > 700 Then
                Height = Height - 78
            End If

        End If
        mover_direccion()
        mostrar_calendario = Not mostrar_calendario
        calendario.Visible = mostrar_calendario
    End Sub
    ' EVENTOS BOTÓN SOCIOS-----------------------------
    Private Sub btn_Socios_MouseHover(sender As Object, e As EventArgs) Handles btn_Socios.MouseHover

        btn_Socios.Location = New Point(19, 5)
        btn_Socios.Size = New Size(155, 169)
        btn_Socios.FlatAppearance.BorderColor = Color.Gold

    End Sub

    Private Sub btn_Socios_MouseLeave(sender As Object, e As EventArgs) Handles btn_Socios.MouseLeave

        btn_Socios.Location = New Point(19, 15)
        btn_Socios.Size = New Size(136, 143)
        btn_Socios.FlatAppearance.BorderColor = Color.White

    End Sub

    ' EVENTOS BOTÓN EMPLEADOS-----------------------------
    Private Sub btn_Empleados_MouseHover(sender As Object, e As EventArgs) Handles btn_Empleados.MouseHover

        btn_Empleados.Location = New Point(13, 165)
        btn_Empleados.Size = New Size(161, 161)
        btn_Empleados.FlatAppearance.BorderColor = Color.Gold

    End Sub

    Private Sub btn_Empleados_MouseLeave(sender As Object, e As EventArgs) Handles btn_Empleados.MouseLeave

        btn_Empleados.Location = New Point(19, 180)
        btn_Empleados.Size = New Size(136, 146)
        btn_Empleados.FlatAppearance.BorderColor = Color.White

    End Sub

    ' EVENTOS BOTÓN PROVEEDORES-----------------------------
    Private Sub btn_Proveedores_MouseHover(sender As Object, e As EventArgs) Handles btn_Proveedores.MouseHover

        btn_Proveedores.Location = New Point(3, 327)
        btn_Proveedores.Size = New Size(171, 160)
        btn_Proveedores.FlatAppearance.BorderColor = Color.Gold

    End Sub

    Private Sub btn_Proveedores_MouseLeave(sender As Object, e As EventArgs) Handles btn_Proveedores.MouseLeave

        btn_Proveedores.Location = New Point(19, 332)
        btn_Proveedores.Size = New Size(136, 146)
        btn_Proveedores.FlatAppearance.BorderColor = Color.White

    End Sub

    ' EVENTOS BOTÓN REPOSTAJE-----------------------------

    Private Sub btn_Repostaje_MouseHover(sender As Object, e As EventArgs) Handles btn_Repostaje.MouseHover

        btn_Repostaje.Location = New Point(19, 475)
        btn_Repostaje.Size = New Size(155, 165)
        btn_Repostaje.FlatAppearance.BorderColor = Color.Gold

    End Sub

    Private Sub btn_Repostaje_MouseLeave(sender As Object, e As EventArgs) Handles btn_Repostaje.MouseLeave

        btn_Repostaje.Location = New Point(19, 493)
        btn_Repostaje.Size = New Size(136, 146)
        btn_Repostaje.FlatAppearance.BorderColor = Color.White

    End Sub

    ' EVENTOS BOTÓN LOGOUT-----------------------------
    Private Sub btn_LogOut_MouseHover(sender As Object, e As EventArgs) Handles btn_LogOut.MouseHover

        btn_LogOut.Location = New Point(4, 654)
        btn_LogOut.Size = New Size(171, 156)
        btn_LogOut.FlatAppearance.BorderColor = Color.Gold

    End Sub

    Private Sub btn_LogOut_MouseLeave(sender As Object, e As EventArgs) Handles btn_LogOut.MouseLeave

        btn_LogOut.Location = New Point(19, 660)
        btn_LogOut.Size = New Size(136, 146)
        btn_LogOut.FlatAppearance.BorderColor = Color.White

    End Sub


    ' ------------------------------------------------ LLAMADA A OTROS FORMULARIOS -------------------------------------------------------------
    Private Sub btn_Socios_Click(sender As Object, e As EventArgs) Handles btn_Socios.Click

        Dim formularioSocios As New Formulario_Socios
        formularioSocios.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Proveedores_Click(sender As Object, e As EventArgs) Handles btn_Proveedores.Click

        Dim formularioProveedores As New Formulario_Proveedores
        formularioProveedores.Show()
        Me.Hide()

    End Sub
   
End Class