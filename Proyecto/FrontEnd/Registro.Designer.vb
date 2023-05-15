<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtsapellido = New System.Windows.Forms.TextBox()
        Me.txtpapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtidentificacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SeleccionEstado = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(122, 136)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(150, 20)
        Me.txtclave.TabIndex = 5
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(122, 112)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(150, 20)
        Me.txtusuario.TabIndex = 4
        '
        'txtsapellido
        '
        Me.txtsapellido.Location = New System.Drawing.Point(122, 87)
        Me.txtsapellido.Name = "txtsapellido"
        Me.txtsapellido.Size = New System.Drawing.Size(150, 20)
        Me.txtsapellido.TabIndex = 3
        '
        'txtpapellido
        '
        Me.txtpapellido.Location = New System.Drawing.Point(122, 62)
        Me.txtpapellido.Name = "txtpapellido"
        Me.txtpapellido.Size = New System.Drawing.Size(150, 20)
        Me.txtpapellido.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(122, 37)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(150, 20)
        Me.txtnombre.TabIndex = 1
        '
        'txtidentificacion
        '
        Me.txtidentificacion.Location = New System.Drawing.Point(122, 12)
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Size = New System.Drawing.Size(150, 20)
        Me.txtidentificacion.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Clave"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Segundo Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Identificación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre"
        '
        'SeleccionEstado
        '
        Me.SeleccionEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeleccionEstado.FormattingEnabled = True
        Me.SeleccionEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.SeleccionEstado.Location = New System.Drawing.Point(122, 162)
        Me.SeleccionEstado.Name = "SeleccionEstado"
        Me.SeleccionEstado.Size = New System.Drawing.Size(150, 21)
        Me.SeleccionEstado.TabIndex = 6
        Me.SeleccionEstado.UseWaitCursor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(122, 189)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(150, 50)
        Me.btn_agregar.TabIndex = 7
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.txtsapellido)
        Me.Controls.Add(Me.txtpapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtidentificacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SeleccionEstado)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtclave As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtsapellido As TextBox
    Friend WithEvents txtpapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtidentificacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SeleccionEstado As ComboBox
    Friend WithEvents btn_agregar As Button
End Class
