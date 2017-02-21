<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblApellidosEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNumeroEmpleado = New System.Windows.Forms.TextBox()
        Me.lblNumeroEmpleado = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTfno = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.panelDireccion = New System.Windows.Forms.GroupBox()
        Me.txtPuerta = New System.Windows.Forms.TextBox()
        Me.lblPuerta = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboTipoVia = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.pictureLogo = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerMostrarPanel = New System.Windows.Forms.Timer(Me.components)
        Me.timerEsconderPanel = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelDireccion.SuspendLayout()
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(206, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 29)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(19, 59)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(108, 13)
        Me.lblNombreEmpleado.TabIndex = 4
        Me.lblNombreEmpleado.Text = "Nombre de empleado"
        '
        'lblApellidosEmpleado
        '
        Me.lblApellidosEmpleado.AutoSize = True
        Me.lblApellidosEmpleado.Location = New System.Drawing.Point(19, 90)
        Me.lblApellidosEmpleado.Name = "lblApellidosEmpleado"
        Me.lblApellidosEmpleado.Size = New System.Drawing.Size(115, 13)
        Me.lblApellidosEmpleado.TabIndex = 5
        Me.lblApellidosEmpleado.Text = "Apellidos del empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(153, 56)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreEmpleado.TabIndex = 6
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(153, 90)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidos.TabIndex = 7
        '
        'txtNumeroEmpleado
        '
        Me.txtNumeroEmpleado.Location = New System.Drawing.Point(153, 20)
        Me.txtNumeroEmpleado.Name = "txtNumeroEmpleado"
        Me.txtNumeroEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroEmpleado.TabIndex = 9
        '
        'lblNumeroEmpleado
        '
        Me.lblNumeroEmpleado.AutoSize = True
        Me.lblNumeroEmpleado.Location = New System.Drawing.Point(19, 23)
        Me.lblNumeroEmpleado.Name = "lblNumeroEmpleado"
        Me.lblNumeroEmpleado.Size = New System.Drawing.Size(108, 13)
        Me.lblNumeroEmpleado.TabIndex = 8
        Me.lblNumeroEmpleado.Text = "Nombre de empleado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(19, 129)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(115, 13)
        Me.lblDNI.TabIndex = 10
        Me.lblDNI.Text = "Apellidos del empleado"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'lblTfno
        '
        Me.lblTfno.AutoSize = True
        Me.lblTfno.Location = New System.Drawing.Point(19, 167)
        Me.lblTfno.Name = "lblTfno"
        Me.lblTfno.Size = New System.Drawing.Size(115, 13)
        Me.lblTfno.TabIndex = 12
        Me.lblTfno.Text = "Apellidos del empleado"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(153, 209)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 15
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(19, 209)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(115, 13)
        Me.lblMail.TabIndex = 14
        Me.lblMail.Text = "Apellidos del empleado"
        '
        'panelDireccion
        '
        Me.panelDireccion.Controls.Add(Me.txtPuerta)
        Me.panelDireccion.Controls.Add(Me.lblPuerta)
        Me.panelDireccion.Controls.Add(Me.TextBox5)
        Me.panelDireccion.Controls.Add(Me.Label1)
        Me.panelDireccion.Controls.Add(Me.comboTipoVia)
        Me.panelDireccion.Controls.Add(Me.TextBox4)
        Me.panelDireccion.Controls.Add(Me.lblPiso)
        Me.panelDireccion.Controls.Add(Me.txtCalle)
        Me.panelDireccion.Location = New System.Drawing.Point(23, 50)
        Me.panelDireccion.Name = "panelDireccion"
        Me.panelDireccion.Size = New System.Drawing.Size(436, 224)
        Me.panelDireccion.TabIndex = 16
        Me.panelDireccion.TabStop = False
        Me.panelDireccion.Text = "Dirección"
        '
        'txtPuerta
        '
        Me.txtPuerta.Location = New System.Drawing.Point(387, 49)
        Me.txtPuerta.Name = "txtPuerta"
        Me.txtPuerta.Size = New System.Drawing.Size(34, 20)
        Me.txtPuerta.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.txtPuerta, "Aquí va la puerta de la residencia.")
        '
        'lblPuerta
        '
        Me.lblPuerta.AutoSize = True
        Me.lblPuerta.Location = New System.Drawing.Point(336, 52)
        Me.lblPuerta.Name = "lblPuerta"
        Me.lblPuerta.Size = New System.Drawing.Size(45, 13)
        Me.lblPuerta.TabIndex = 23
        Me.lblPuerta.Text = "Puerta *"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(127, 93)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(72, 20)
        Me.TextBox5.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.TextBox5, "Código postal de la dirección.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Código postal *"
        '
        'comboTipoVia
        '
        Me.comboTipoVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipoVia.FormattingEnabled = True
        Me.comboTipoVia.Items.AddRange(New Object() {"Calle", "Avenida", "Travesía", "Bulevar", "Arroyo", "Barrio", "Callejón", "Camino", "Camino alto", "Camino bajo", "Camino viejo", "Campillo", "Carretera", "Cerrillo", "Costanilla", "Cuesta", "Ensanche", "Extrarradio", "Vereda", "Rambla", "Pradera", "Plaza"})
        Me.comboTipoVia.Location = New System.Drawing.Point(14, 50)
        Me.comboTipoVia.Name = "comboTipoVia"
        Me.comboTipoVia.Size = New System.Drawing.Size(90, 21)
        Me.comboTipoVia.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(288, 49)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(34, 20)
        Me.TextBox4.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.TextBox4, "Aquí va el número de tu piso (sólo números).")
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(248, 53)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(34, 13)
        Me.lblPiso.TabIndex = 18
        Me.lblPiso.Text = "Piso *"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(127, 50)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(100, 20)
        Me.txtCalle.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtCalle, "Aquí va el nombre de la vía.")
        '
        'pictureLogo
        '
        Me.pictureLogo.Image = Global.GasolineraRepsol.My.Resources.Resources.Expand_Arrow_Filled
        Me.pictureLogo.Location = New System.Drawing.Point(0, 255)
        Me.pictureLogo.Name = "pictureLogo"
        Me.pictureLogo.Size = New System.Drawing.Size(22, 22)
        Me.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureLogo.TabIndex = 17
        Me.pictureLogo.TabStop = False
        '
        'timerMostrarPanel
        '
        Me.timerMostrarPanel.Interval = 1
        '
        'timerEsconderPanel
        '
        Me.timerEsconderPanel.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtNumeroEmpleado)
        Me.Panel1.Controls.Add(Me.pictureLogo)
        Me.Panel1.Controls.Add(Me.lblNombreEmpleado)
        Me.Panel1.Controls.Add(Me.lblApellidosEmpleado)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.txtNombreEmpleado)
        Me.Panel1.Controls.Add(Me.lblMail)
        Me.Panel1.Controls.Add(Me.txtApellidos)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.lblNumeroEmpleado)
        Me.Panel1.Controls.Add(Me.lblTfno)
        Me.Panel1.Controls.Add(Me.lblDNI)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(23, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 277)
        Me.Panel1.TabIndex = 18
        '
        'formEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 590)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelDireccion)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "formEmpleados"
        Me.Text = "formEmpleados"
        Me.panelDireccion.ResumeLayout(False)
        Me.panelDireccion.PerformLayout()
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblApellidosEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroEmpleado As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTfno As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents panelDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents pictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents comboTipoVia As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblPiso As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtPuerta As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPuerta As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timerMostrarPanel As System.Windows.Forms.Timer
    Friend WithEvents timerEsconderPanel As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
