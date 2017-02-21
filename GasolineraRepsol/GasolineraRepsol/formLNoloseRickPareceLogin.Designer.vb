<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLNoloseRickPareceLogin
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
        Me.txtNickUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblContrasenya = New System.Windows.Forms.Label()
        Me.txtContrasenya = New System.Windows.Forms.TextBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNickUsuario
        '
        Me.txtNickUsuario.Location = New System.Drawing.Point(173, 42)
        Me.txtNickUsuario.Name = "txtNickUsuario"
        Me.txtNickUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtNickUsuario.TabIndex = 0
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(57, 45)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(96, 13)
        Me.lblNombreUsuario.TabIndex = 1
        Me.lblNombreUsuario.Text = "Nombre de usuario"
        '
        'lblContrasenya
        '
        Me.lblContrasenya.AutoSize = True
        Me.lblContrasenya.Location = New System.Drawing.Point(38, 84)
        Me.lblContrasenya.Name = "lblContrasenya"
        Me.lblContrasenya.Size = New System.Drawing.Size(115, 13)
        Me.lblContrasenya.TabIndex = 3
        Me.lblContrasenya.Text = "Contraseña del usuario"
        '
        'txtContrasenya
        '
        Me.txtContrasenya.Location = New System.Drawing.Point(173, 81)
        Me.txtContrasenya.Name = "txtContrasenya"
        Me.txtContrasenya.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasenya.TabIndex = 2
        '
        'btnAcceder
        '
        Me.btnAcceder.Location = New System.Drawing.Point(136, 136)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceder.TabIndex = 4
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'formLNoloseRickPareceLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 183)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.lblContrasenya)
        Me.Controls.Add(Me.txtContrasenya)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.txtNickUsuario)
        Me.Name = "formLNoloseRickPareceLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNickUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasenya As System.Windows.Forms.Label
    Friend WithEvents txtContrasenya As System.Windows.Forms.TextBox
    Friend WithEvents btnAcceder As System.Windows.Forms.Button

End Class
