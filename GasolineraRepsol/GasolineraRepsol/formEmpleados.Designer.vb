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
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblApellidosEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtApellidosEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNumeroEmpleado = New System.Windows.Forms.TextBox()
        Me.lblCodigoEmpleado = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.lblTfno = New System.Windows.Forms.Label()
        Me.txtMailEmpleado = New System.Windows.Forms.TextBox()
        Me.lblMailEmpleado = New System.Windows.Forms.Label()
        Me.panelDireccion = New System.Windows.Forms.GroupBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtPuerta = New System.Windows.Forms.TextBox()
        Me.lblPuerta = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.comboTipoVia = New System.Windows.Forms.ComboBox()
        Me.txtPortal = New System.Windows.Forms.TextBox()
        Me.lblPortal = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerMostrarPanel = New System.Windows.Forms.Timer(Me.components)
        Me.timerEsconderPanel = New System.Windows.Forms.Timer(Me.components)
        Me.panelDatosEmpleado = New System.Windows.Forms.Panel()
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.btnCalendario = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblDireccionDesplegable = New System.Windows.Forms.Label()
        Me.pictureDireccion = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.panelDireccion.SuspendLayout()
        Me.panelDatosEmpleado.SuspendLayout()
        CType(Me.pictureDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(657, 50)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(97, 29)
        Me.btnInsertar.TabIndex = 1
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(657, 106)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 29)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(657, 163)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 29)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(12, 49)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(108, 13)
        Me.lblNombreEmpleado.TabIndex = 4
        Me.lblNombreEmpleado.Text = "Nombre de empleado"
        '
        'lblApellidosEmpleado
        '
        Me.lblApellidosEmpleado.AutoSize = True
        Me.lblApellidosEmpleado.Location = New System.Drawing.Point(5, 77)
        Me.lblApellidosEmpleado.Name = "lblApellidosEmpleado"
        Me.lblApellidosEmpleado.Size = New System.Drawing.Size(115, 13)
        Me.lblApellidosEmpleado.TabIndex = 5
        Me.lblApellidosEmpleado.Text = "Apellidos del empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(145, 46)
        Me.txtNombreEmpleado.MaxLength = 30
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(200, 20)
        Me.txtNombreEmpleado.TabIndex = 6
        '
        'txtApellidosEmpleado
        '
        Me.txtApellidosEmpleado.Location = New System.Drawing.Point(145, 74)
        Me.txtApellidosEmpleado.MaxLength = 42
        Me.txtApellidosEmpleado.Name = "txtApellidosEmpleado"
        Me.txtApellidosEmpleado.Size = New System.Drawing.Size(268, 20)
        Me.txtApellidosEmpleado.TabIndex = 7
        '
        'txtNumeroEmpleado
        '
        Me.txtNumeroEmpleado.Location = New System.Drawing.Point(145, 20)
        Me.txtNumeroEmpleado.MaxLength = 2
        Me.txtNumeroEmpleado.Name = "txtNumeroEmpleado"
        Me.txtNumeroEmpleado.Size = New System.Drawing.Size(36, 20)
        Me.txtNumeroEmpleado.TabIndex = 9
        Me.txtNumeroEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigoEmpleado
        '
        Me.lblCodigoEmpleado.AutoSize = True
        Me.lblCodigoEmpleado.Location = New System.Drawing.Point(16, 23)
        Me.lblCodigoEmpleado.Name = "lblCodigoEmpleado"
        Me.lblCodigoEmpleado.Size = New System.Drawing.Size(104, 13)
        Me.lblCodigoEmpleado.TabIndex = 8
        Me.lblCodigoEmpleado.Text = "Código de empleado"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(145, 100)
        Me.txtDNI.MaxLength = 14
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 11
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(35, 103)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(92, 13)
        Me.lblDNI.TabIndex = 10
        Me.lblDNI.Text = "DNI del empleado"
        '
        'txtTelefonoEmpleado
        '
        Me.txtTelefonoEmpleado.Location = New System.Drawing.Point(145, 136)
        Me.txtTelefonoEmpleado.MaxLength = 9
        Me.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado"
        Me.txtTelefonoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefonoEmpleado.TabIndex = 13
        '
        'lblTfno
        '
        Me.lblTfno.AutoSize = True
        Me.lblTfno.Location = New System.Drawing.Point(12, 139)
        Me.lblTfno.Name = "lblTfno"
        Me.lblTfno.Size = New System.Drawing.Size(115, 13)
        Me.lblTfno.TabIndex = 12
        Me.lblTfno.Text = "Teléfono del empleado"
        '
        'txtMailEmpleado
        '
        Me.txtMailEmpleado.Location = New System.Drawing.Point(145, 172)
        Me.txtMailEmpleado.MaxLength = 50
        Me.txtMailEmpleado.Name = "txtMailEmpleado"
        Me.txtMailEmpleado.Size = New System.Drawing.Size(268, 20)
        Me.txtMailEmpleado.TabIndex = 15
        '
        'lblMailEmpleado
        '
        Me.lblMailEmpleado.AutoSize = True
        Me.lblMailEmpleado.Location = New System.Drawing.Point(26, 175)
        Me.lblMailEmpleado.Name = "lblMailEmpleado"
        Me.lblMailEmpleado.Size = New System.Drawing.Size(101, 13)
        Me.lblMailEmpleado.TabIndex = 14
        Me.lblMailEmpleado.Text = "E-mail del empleado"
        '
        'panelDireccion
        '
        Me.panelDireccion.Controls.Add(Me.lblProvincia)
        Me.panelDireccion.Controls.Add(Me.lblLocalidad)
        Me.panelDireccion.Controls.Add(Me.txtPiso)
        Me.panelDireccion.Controls.Add(Me.lblPiso)
        Me.panelDireccion.Controls.Add(Me.txtProvincia)
        Me.panelDireccion.Controls.Add(Me.txtLocalidad)
        Me.panelDireccion.Controls.Add(Me.txtPuerta)
        Me.panelDireccion.Controls.Add(Me.lblPuerta)
        Me.panelDireccion.Controls.Add(Me.txtCodigoPostal)
        Me.panelDireccion.Controls.Add(Me.lblCodigoPostal)
        Me.panelDireccion.Controls.Add(Me.comboTipoVia)
        Me.panelDireccion.Controls.Add(Me.txtPortal)
        Me.panelDireccion.Controls.Add(Me.lblPortal)
        Me.panelDireccion.Controls.Add(Me.txtCalle)
        Me.panelDireccion.Location = New System.Drawing.Point(150, 150)
        Me.panelDireccion.Name = "panelDireccion"
        Me.panelDireccion.Size = New System.Drawing.Size(480, 224)
        Me.panelDireccion.TabIndex = 16
        Me.panelDireccion.TabStop = False
        Me.panelDireccion.Text = "Dirección"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(222, 138)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.lblProvincia.TabIndex = 30
        Me.lblProvincia.Text = "Provincia"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(19, 138)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 29
        Me.lblLocalidad.Text = "Localidad"
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(396, 49)
        Me.txtPiso.MaxLength = 1
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(34, 20)
        Me.txtPiso.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.txtPiso, "Aquí va el número de tu piso (sólo números).")
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(356, 53)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(27, 13)
        Me.lblPiso.TabIndex = 27
        Me.lblPiso.Text = "Piso"
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(288, 135)
        Me.txtProvincia.MaxLength = 30
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(100, 20)
        Me.txtProvincia.TabIndex = 26
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(91, 135)
        Me.txtLocalidad.MaxLength = 30
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.txtLocalidad.TabIndex = 25
        '
        'txtPuerta
        '
        Me.txtPuerta.Location = New System.Drawing.Point(70, 89)
        Me.txtPuerta.MaxLength = 3
        Me.txtPuerta.Name = "txtPuerta"
        Me.txtPuerta.Size = New System.Drawing.Size(34, 20)
        Me.txtPuerta.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.txtPuerta, "Aquí va la puerta de la residencia.")
        '
        'lblPuerta
        '
        Me.lblPuerta.AutoSize = True
        Me.lblPuerta.Location = New System.Drawing.Point(19, 92)
        Me.lblPuerta.Name = "lblPuerta"
        Me.lblPuerta.Size = New System.Drawing.Size(38, 13)
        Me.lblPuerta.TabIndex = 23
        Me.lblPuerta.Text = "Puerta"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(219, 89)
        Me.txtCodigoPostal.MaxLength = 5
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(72, 20)
        Me.txtCodigoPostal.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.txtCodigoPostal, "Código postal de la dirección.")
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(125, 92)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(71, 13)
        Me.lblCodigoPostal.TabIndex = 21
        Me.lblCodigoPostal.Text = "Código postal"
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
        'txtPortal
        '
        Me.txtPortal.Location = New System.Drawing.Point(288, 49)
        Me.txtPortal.MaxLength = 1
        Me.txtPortal.Name = "txtPortal"
        Me.txtPortal.Size = New System.Drawing.Size(34, 20)
        Me.txtPortal.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtPortal, "Aquí va el número de tu piso (sólo números).")
        '
        'lblPortal
        '
        Me.lblPortal.AutoSize = True
        Me.lblPortal.Location = New System.Drawing.Point(248, 53)
        Me.lblPortal.Name = "lblPortal"
        Me.lblPortal.Size = New System.Drawing.Size(34, 13)
        Me.lblPortal.TabIndex = 18
        Me.lblPortal.Text = "Portal"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(127, 50)
        Me.txtCalle.MaxLength = 40
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(100, 20)
        Me.txtCalle.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtCalle, "Aquí va el nombre de la vía.")
        '
        'timerMostrarPanel
        '
        Me.timerMostrarPanel.Interval = 1
        '
        'timerEsconderPanel
        '
        Me.timerEsconderPanel.Interval = 1
        '
        'panelDatosEmpleado
        '
        Me.panelDatosEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelDatosEmpleado.Controls.Add(Me.txtRol)
        Me.panelDatosEmpleado.Controls.Add(Me.lblRol)
        Me.panelDatosEmpleado.Controls.Add(Me.calendario)
        Me.panelDatosEmpleado.Controls.Add(Me.btnCalendario)
        Me.panelDatosEmpleado.Controls.Add(Me.txtFecha)
        Me.panelDatosEmpleado.Controls.Add(Me.lbl)
        Me.panelDatosEmpleado.Controls.Add(Me.lblDireccionDesplegable)
        Me.panelDatosEmpleado.Controls.Add(Me.txtNumeroEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.pictureDireccion)
        Me.panelDatosEmpleado.Controls.Add(Me.lblNombreEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.lblApellidosEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.txtMailEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.lblMailEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.txtApellidosEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.txtTelefonoEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.lblCodigoEmpleado)
        Me.panelDatosEmpleado.Controls.Add(Me.lblTfno)
        Me.panelDatosEmpleado.Controls.Add(Me.lblDNI)
        Me.panelDatosEmpleado.Controls.Add(Me.txtDNI)
        Me.panelDatosEmpleado.Location = New System.Drawing.Point(150, 50)
        Me.panelDatosEmpleado.Name = "panelDatosEmpleado"
        Me.panelDatosEmpleado.Size = New System.Drawing.Size(484, 334)
        Me.panelDatosEmpleado.TabIndex = 18
        '
        'calendario
        '
        Me.calendario.Location = New System.Drawing.Point(230, 256)
        Me.calendario.MaxDate = New Date(2001, 2, 21, 0, 0, 0, 0)
        Me.calendario.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.calendario.Name = "calendario"
        Me.calendario.TabIndex = 21
        Me.calendario.Visible = False
        '
        'btnCalendario
        '
        Me.btnCalendario.Image = Global.GasolineraRepsol.My.Resources.Resources.Calendar
        Me.btnCalendario.Location = New System.Drawing.Point(230, 247)
        Me.btnCalendario.Name = "btnCalendario"
        Me.btnCalendario.Size = New System.Drawing.Size(39, 37)
        Me.btnCalendario.TabIndex = 21
        Me.btnCalendario.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(145, 256)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(74, 20)
        Me.txtFecha.TabIndex = 20
        Me.txtFecha.Text = "16/10/1990"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(19, 256)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(93, 13)
        Me.lbl.TabIndex = 19
        Me.lbl.Text = "Fecha Nacimiento"
        '
        'lblDireccionDesplegable
        '
        Me.lblDireccionDesplegable.AutoSize = True
        Me.lblDireccionDesplegable.Location = New System.Drawing.Point(68, 303)
        Me.lblDireccionDesplegable.Name = "lblDireccionDesplegable"
        Me.lblDireccionDesplegable.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccionDesplegable.TabIndex = 18
        Me.lblDireccionDesplegable.Text = "Dirección"
        Me.lblDireccionDesplegable.Visible = False
        '
        'pictureDireccion
        '
        Me.pictureDireccion.Image = Global.GasolineraRepsol.My.Resources.Resources.Expand_Arrow_Filled
        Me.pictureDireccion.Location = New System.Drawing.Point(22, 303)
        Me.pictureDireccion.Name = "pictureDireccion"
        Me.pictureDireccion.Size = New System.Drawing.Size(22, 22)
        Me.pictureDireccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureDireccion.TabIndex = 17
        Me.pictureDireccion.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(657, 217)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(97, 29)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(779, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(502, 183)
        Me.DataGridView1.TabIndex = 20
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(145, 209)
        Me.txtRol.MaxLength = 50
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(268, 20)
        Me.txtRol.TabIndex = 23
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(104, 212)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(23, 13)
        Me.lblRol.TabIndex = 22
        Me.lblRol.Text = "Rol"
        '
        'formEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 492)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.panelDatosEmpleado)
        Me.Controls.Add(Me.panelDireccion)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Name = "formEmpleados"
        Me.Text = "formEmpleados"
        Me.panelDireccion.ResumeLayout(False)
        Me.panelDireccion.PerformLayout()
        Me.panelDatosEmpleado.ResumeLayout(False)
        Me.panelDatosEmpleado.PerformLayout()
        CType(Me.pictureDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblApellidosEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidosEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblTfno As System.Windows.Forms.Label
    Friend WithEvents txtMailEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblMailEmpleado As System.Windows.Forms.Label
    Friend WithEvents panelDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents pictureDireccion As System.Windows.Forms.PictureBox
    Friend WithEvents comboTipoVia As System.Windows.Forms.ComboBox
    Friend WithEvents txtPortal As System.Windows.Forms.TextBox
    Friend WithEvents lblPortal As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtPuerta As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPuerta As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents timerMostrarPanel As System.Windows.Forms.Timer
    Friend WithEvents timerEsconderPanel As System.Windows.Forms.Timer
    Friend WithEvents panelDatosEmpleado As System.Windows.Forms.Panel
    Friend WithEvents lblDireccionDesplegable As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnCalendario As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents lblPiso As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Public WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
End Class
