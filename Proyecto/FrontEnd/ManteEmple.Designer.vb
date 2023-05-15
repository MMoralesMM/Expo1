<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManteEmple
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
        Me.BTN_agregar = New System.Windows.Forms.Button()
        Me.txtsapellido = New System.Windows.Forms.TextBox()
        Me.txtpapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtidentificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatosEmpleados = New System.Windows.Forms.DataGridView()
        Me.Selecciondepartamento = New System.Windows.Forms.ComboBox()
        Me.BTN_modificar = New System.Windows.Forms.Button()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SeleccionEstado = New System.Windows.Forms.ComboBox()
        Me.txtproyecto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DatosEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_agregar
        '
        Me.BTN_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregar.Location = New System.Drawing.Point(450, 25)
        Me.BTN_agregar.Name = "BTN_agregar"
        Me.BTN_agregar.Size = New System.Drawing.Size(150, 50)
        Me.BTN_agregar.TabIndex = 9
        Me.BTN_agregar.Text = "Agregar"
        Me.BTN_agregar.UseVisualStyleBackColor = True
        '
        'txtsapellido
        '
        Me.txtsapellido.Location = New System.Drawing.Point(96, 86)
        Me.txtsapellido.Name = "txtsapellido"
        Me.txtsapellido.Size = New System.Drawing.Size(150, 20)
        Me.txtsapellido.TabIndex = 3
        '
        'txtpapellido
        '
        Me.txtpapellido.Location = New System.Drawing.Point(96, 61)
        Me.txtpapellido.Name = "txtpapellido"
        Me.txtpapellido.Size = New System.Drawing.Size(150, 20)
        Me.txtpapellido.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(96, 36)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(150, 20)
        Me.txtnombre.TabIndex = 1
        '
        'txtidentificacion
        '
        Me.txtidentificacion.Location = New System.Drawing.Point(96, 11)
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Size = New System.Drawing.Size(150, 20)
        Me.txtidentificacion.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Segundo Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Identificación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre"
        '
        'DatosEmpleados
        '
        Me.DatosEmpleados.AllowUserToAddRows = False
        Me.DatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosEmpleados.Location = New System.Drawing.Point(0, 250)
        Me.DatosEmpleados.Name = "DatosEmpleados"
        Me.DatosEmpleados.ReadOnly = True
        Me.DatosEmpleados.RowHeadersVisible = False
        Me.DatosEmpleados.Size = New System.Drawing.Size(800, 200)
        Me.DatosEmpleados.TabIndex = 17
        '
        'Selecciondepartamento
        '
        Me.Selecciondepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Selecciondepartamento.FormattingEnabled = True
        Me.Selecciondepartamento.Items.AddRange(New Object() {"Recursos Humanos", "Financiero", "Logística", "Construcción", "Administrativo", "Tecnología"})
        Me.Selecciondepartamento.Location = New System.Drawing.Point(96, 111)
        Me.Selecciondepartamento.Name = "Selecciondepartamento"
        Me.Selecciondepartamento.Size = New System.Drawing.Size(150, 21)
        Me.Selecciondepartamento.TabIndex = 4
        '
        'BTN_modificar
        '
        Me.BTN_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_modificar.Location = New System.Drawing.Point(450, 93)
        Me.BTN_modificar.Name = "BTN_modificar"
        Me.BTN_modificar.Size = New System.Drawing.Size(150, 50)
        Me.BTN_modificar.TabIndex = 10
        Me.BTN_modificar.Text = "Modificar"
        Me.BTN_modificar.UseVisualStyleBackColor = True
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(96, 188)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(150, 20)
        Me.txtcorreo.TabIndex = 7
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(96, 164)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(150, 20)
        Me.txttelefono.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Teléfono"
        '
        'SeleccionEstado
        '
        Me.SeleccionEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeleccionEstado.FormattingEnabled = True
        Me.SeleccionEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.SeleccionEstado.Location = New System.Drawing.Point(96, 214)
        Me.SeleccionEstado.Name = "SeleccionEstado"
        Me.SeleccionEstado.Size = New System.Drawing.Size(150, 21)
        Me.SeleccionEstado.TabIndex = 8
        '
        'txtproyecto
        '
        Me.txtproyecto.Location = New System.Drawing.Point(96, 138)
        Me.txtproyecto.Name = "txtproyecto"
        Me.txtproyecto.Size = New System.Drawing.Size(150, 20)
        Me.txtproyecto.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Proyecto"
        '
        'ManteEmple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtproyecto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SeleccionEstado)
        Me.Controls.Add(Me.BTN_modificar)
        Me.Controls.Add(Me.BTN_agregar)
        Me.Controls.Add(Me.txtsapellido)
        Me.Controls.Add(Me.txtpapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtidentificacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatosEmpleados)
        Me.Controls.Add(Me.Selecciondepartamento)
        Me.Name = "ManteEmple"
        Me.Text = "ManteEmple"
        CType(Me.DatosEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_agregar As Button
    Friend WithEvents txtsapellido As TextBox
    Friend WithEvents txtpapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtidentificacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatosEmpleados As DataGridView
    Friend WithEvents Selecciondepartamento As ComboBox
    Friend WithEvents BTN_modificar As Button
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SeleccionEstado As ComboBox
    Friend WithEvents txtproyecto As TextBox
    Friend WithEvents Label9 As Label
End Class
