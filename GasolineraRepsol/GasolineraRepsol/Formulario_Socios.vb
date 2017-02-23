Public Class Formulario_Socios

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
    ' EVENTOS BOTÓN SOCIOS-----------------------------

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
    ' EVENTOS BOTÓN EMPLEADOS-----------------------------

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
    ' EVENTOS BOTÓN PROVEEDORES-----------------------------

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
    ' EVENTOS BOTÓN REPOSTAJE-----------------------------

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
    ' EVENTOS BOTÓN LOGOUT-----------------------------

    Private Sub btn_Empleados_Click(sender As Object, e As EventArgs) Handles btn_Empleados.Click

        Dim formularioEmpleados As New Formulario_Empleados
        formularioEmpleados.Show()
        Me.Hide()

    End Sub

    Private Sub btn_Proveedores_Click(sender As Object, e As EventArgs) Handles btn_Proveedores.Click

        Dim formularioProveedores As New Formulario_Proveedores
        formularioProveedores.Show()
        Me.Hide()
    End Sub



End Class