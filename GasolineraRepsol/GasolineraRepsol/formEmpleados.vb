Public Class formEmpleados
    Private expandir_direccion As Boolean = False
    Private mostrar_calendario As Boolean = False
    Private acceso As New AccesoDatos

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub formEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboTipoVia.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim direccion As String
        direccion = comboTipoVia.Text & "," & txtCalle.Text & "," & txtPortal.Text & "," & txtPiso.Text & "," & txtPuerta.Text & "," & txtCodigoPostal.Text & "," & txtLocalidad.Text & "," & txtProvincia.Text
        acceso.insertar_empleado(txtNombreEmpleado.Text, txtApellidosEmpleado.Text, txtDNI.Text, txtTelefonoEmpleado.Text, txtMailEmpleado.Text, direccion, txtRol.Text, txtFecha.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim arra As New List(Of String)
        arra.Add(Nothing)
        arra.Add("hh")
        acceso.eliminar_empleado(arra)
    End Sub

    '----------- Gestión del formulario de dirección -----------'

   

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
        Dim topeInferior_Panel As Integer

        If mostrar_calendario = False Then
            topeInferior_Panel = 400
        Else
            topeInferior_Panel = 500
        End If

        If panelDireccion.Location.Y < topeInferior_Panel Then
            panelDireccion.SetBounds(panelDireccion.Location.X, panelDireccion.Location.Y + 7, panelDireccion.Width, panelDireccion.Height)
            SetBounds(Location.X, Location.Y, Width, Height + 7)
        Else
            timerMostrarPanel.Stop()
        End If
    End Sub

    Private Sub timerEsconderPanel_Tick(sender As Object, e As EventArgs) Handles timerEsconderPanel.Tick
        If panelDireccion.Location.Y > 150 Then
            panelDireccion.SetBounds(panelDireccion.Location.X, panelDireccion.Location.Y - 7, panelDireccion.Width, panelDireccion.Height)
            If Height > 530 Then
                SetBounds(Location.X, Location.Y, Width, Height - 7)
            End If

        Else
            timerEsconderPanel.Stop()
        End If
    End Sub

    'Método encargado de  posicionar la flecha y el label de la dirección
    Private Sub posicionar_direccion(ByVal x As Integer, ByVal y As Integer)
        pictureDireccion.SetBounds(x, y, pictureDireccion.Width, pictureDireccion.Height)
        lblDireccionDesplegable.SetBounds(x, y, lblDireccionDesplegable.Width, lblDireccionDesplegable.Height)
    End Sub

    '----------- Gestión del calendario -----------'


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

    Private Sub lblDNI_Click(sender As Object, e As EventArgs) Handles lblDNI.Click

    End Sub
End Class