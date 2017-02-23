<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Proveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_LogOut = New System.Windows.Forms.Button()
        Me.btn_Repostaje = New System.Windows.Forms.Button()
        Me.btn_Proveedores = New System.Windows.Forms.Button()
        Me.btn_Empleados = New System.Windows.Forms.Button()
        Me.btn_Socios = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_LogOut)
        Me.Panel1.Controls.Add(Me.btn_Repostaje)
        Me.Panel1.Controls.Add(Me.btn_Proveedores)
        Me.Panel1.Controls.Add(Me.btn_Empleados)
        Me.Panel1.Controls.Add(Me.btn_Socios)
        Me.Panel1.Location = New System.Drawing.Point(12, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 817)
        Me.Panel1.TabIndex = 7
        '
        'btn_LogOut
        '
        Me.btn_LogOut.BackColor = System.Drawing.Color.White
        Me.btn_LogOut.BackgroundImage = Global.GasolineraRepsol.My.Resources.Resources.LogOut
        Me.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_LogOut.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_LogOut.FlatAppearance.BorderSize = 2
        Me.btn_LogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_LogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LogOut.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogOut.Location = New System.Drawing.Point(19, 658)
        Me.btn_LogOut.Name = "btn_LogOut"
        Me.btn_LogOut.Size = New System.Drawing.Size(136, 146)
        Me.btn_LogOut.TabIndex = 4
        Me.btn_LogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_LogOut.UseVisualStyleBackColor = False
        '
        'btn_Repostaje
        '
        Me.btn_Repostaje.BackColor = System.Drawing.Color.White
        Me.btn_Repostaje.BackgroundImage = Global.GasolineraRepsol.My.Resources.Resources.Repostaje
        Me.btn_Repostaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Repostaje.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Repostaje.FlatAppearance.BorderSize = 2
        Me.btn_Repostaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_Repostaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Repostaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Repostaje.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Repostaje.Location = New System.Drawing.Point(19, 493)
        Me.btn_Repostaje.Name = "btn_Repostaje"
        Me.btn_Repostaje.Size = New System.Drawing.Size(136, 146)
        Me.btn_Repostaje.TabIndex = 3
        Me.btn_Repostaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Repostaje.UseVisualStyleBackColor = False
        '
        'btn_Proveedores
        '
        Me.btn_Proveedores.BackColor = System.Drawing.Color.White
        Me.btn_Proveedores.BackgroundImage = Global.GasolineraRepsol.My.Resources.Resources.Proveedores
        Me.btn_Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Proveedores.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Proveedores.FlatAppearance.BorderSize = 2
        Me.btn_Proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Proveedores.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Proveedores.Location = New System.Drawing.Point(19, 332)
        Me.btn_Proveedores.Name = "btn_Proveedores"
        Me.btn_Proveedores.Size = New System.Drawing.Size(136, 146)
        Me.btn_Proveedores.TabIndex = 2
        Me.btn_Proveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Proveedores.UseVisualStyleBackColor = False
        '
        'btn_Empleados
        '
        Me.btn_Empleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Empleados.BackColor = System.Drawing.Color.White
        Me.btn_Empleados.BackgroundImage = Global.GasolineraRepsol.My.Resources.Resources.ImagenEmpleados
        Me.btn_Empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Empleados.FlatAppearance.BorderSize = 2
        Me.btn_Empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Empleados.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Empleados.Location = New System.Drawing.Point(19, 180)
        Me.btn_Empleados.Name = "btn_Empleados"
        Me.btn_Empleados.Size = New System.Drawing.Size(136, 146)
        Me.btn_Empleados.TabIndex = 1
        Me.btn_Empleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Empleados.UseVisualStyleBackColor = False
        '
        'btn_Socios
        '
        Me.btn_Socios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Socios.BackColor = System.Drawing.Color.White
        Me.btn_Socios.BackgroundImage = Global.GasolineraRepsol.My.Resources.Resources.ImagenSocios
        Me.btn_Socios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Socios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Socios.FlatAppearance.BorderSize = 2
        Me.btn_Socios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_Socios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Socios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Socios.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Socios.Location = New System.Drawing.Point(19, 20)
        Me.btn_Socios.Name = "btn_Socios"
        Me.btn_Socios.Size = New System.Drawing.Size(136, 146)
        Me.btn_Socios.TabIndex = 0
        Me.btn_Socios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Socios.UseVisualStyleBackColor = False
        '
        'Formulario_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GasolineraRepsol.My.Resources.Resources.fondorepsol
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formulario_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario_Proveedores"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_LogOut As System.Windows.Forms.Button
    Friend WithEvents btn_Repostaje As System.Windows.Forms.Button
    Friend WithEvents btn_Proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_Empleados As System.Windows.Forms.Button
    Friend WithEvents btn_Socios As System.Windows.Forms.Button
End Class
