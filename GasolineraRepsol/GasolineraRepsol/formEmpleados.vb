Public Class formEmpleados
    Private expandir_direccion As Boolean = False
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub formEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboTipoVia.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bm As Bitmap = pictureLogo.Image
        bm.RotateFlip(RotateFlipType.Rotate90FlipX)
        Me.pictureLogo.Image = bm
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bm As Bitmap = pictureLogo.Image
        bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Me.pictureLogo.Image = bm
    End Sub

    '----------- Gestión del formulario de dirección -----------'

    'Método encargado de rotar la imagen del picturebox.
    Private Sub rotar_imagen()
        Dim bm As Bitmap = pictureLogo.Image

        If expandir_direccion = False Then
            bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Else
            bm.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If

        Me.pictureLogo.Image = bm
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
    Private Sub pictureLogo_Click(sender As Object, e As EventArgs) Handles pictureLogo.Click
        rotar_imagen()
        mostrar_panelDireccion()
        expandir_direccion = Not expandir_direccion
    End Sub


    
    Private Sub timerMostrarPanel_Tick(sender As Object, e As EventArgs) Handles timerMostrarPanel.Tick
        If panelDireccion.Location.Y < 350 Then
            panelDireccion.SetBounds(panelDireccion.Location.X, panelDireccion.Location.Y + 7, panelDireccion.Width, panelDireccion.Height)

        Else
            timerMostrarPanel.Stop()
        End If
    End Sub

    Private Sub timerEsconderPanel_Tick(sender As Object, e As EventArgs) Handles timerEsconderPanel.Tick
        If panelDireccion.Location.Y > 50 Then
            panelDireccion.SetBounds(panelDireccion.Location.X, panelDireccion.Location.Y - 7, panelDireccion.Width, panelDireccion.Height)
        Else
            timerEsconderPanel.Stop()
        End If
    End Sub
End Class