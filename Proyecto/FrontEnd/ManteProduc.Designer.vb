<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManteProduc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DatosProductos = New System.Windows.Forms.DataGridView()
        Me.txtcantidadmin = New System.Windows.Forms.TextBox()
        Me.txtcantidaddispo = New System.Windows.Forms.TextBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_modificar = New System.Windows.Forms.Button()
        Me.BTN_agregar = New System.Windows.Forms.Button()
        CType(Me.DatosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosProductos
        '
        Me.DatosProductos.AllowUserToAddRows = False
        Me.DatosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosProductos.Location = New System.Drawing.Point(0, 200)
        Me.DatosProductos.Name = "DatosProductos"
        Me.DatosProductos.ReadOnly = True
        Me.DatosProductos.RowHeadersVisible = False
        Me.DatosProductos.Size = New System.Drawing.Size(800, 250)
        Me.DatosProductos.TabIndex = 5
        '
        'txtcantidadmin
        '
        Me.txtcantidadmin.Location = New System.Drawing.Point(107, 97)
        Me.txtcantidadmin.Name = "txtcantidadmin"
        Me.txtcantidadmin.Size = New System.Drawing.Size(150, 20)
        Me.txtcantidadmin.TabIndex = 43
        '
        'txtcantidaddispo
        '
        Me.txtcantidaddispo.Location = New System.Drawing.Point(107, 72)
        Me.txtcantidaddispo.Name = "txtcantidaddispo"
        Me.txtcantidaddispo.Size = New System.Drawing.Size(150, 20)
        Me.txtcantidaddispo.TabIndex = 42
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(107, 47)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(150, 20)
        Me.txtproducto.TabIndex = 41
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(107, 22)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(150, 20)
        Me.txtcodigo.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Cantidad mínima"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Cantidad disponible"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Producto"
        '
        'BTN_modificar
        '
        Me.BTN_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_modificar.Location = New System.Drawing.Point(450, 78)
        Me.BTN_modificar.Name = "BTN_modificar"
        Me.BTN_modificar.Size = New System.Drawing.Size(150, 50)
        Me.BTN_modificar.TabIndex = 45
        Me.BTN_modificar.Text = "Modificar"
        Me.BTN_modificar.UseVisualStyleBackColor = True
        '
        'BTN_agregar
        '
        Me.BTN_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregar.Location = New System.Drawing.Point(450, 22)
        Me.BTN_agregar.Name = "BTN_agregar"
        Me.BTN_agregar.Size = New System.Drawing.Size(150, 50)
        Me.BTN_agregar.TabIndex = 44
        Me.BTN_agregar.Text = "Agregar"
        Me.BTN_agregar.UseVisualStyleBackColor = True
        '
        'ManteProduc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_modificar)
        Me.Controls.Add(Me.BTN_agregar)
        Me.Controls.Add(Me.txtcantidadmin)
        Me.Controls.Add(Me.txtcantidaddispo)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatosProductos)
        Me.Name = "ManteProduc"
        Me.Text = "ManteProduc"
        CType(Me.DatosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatosProductos As DataGridView
    Friend WithEvents txtcantidadmin As TextBox
    Friend WithEvents txtcantidaddispo As TextBox
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_modificar As Button
    Friend WithEvents BTN_agregar As Button
End Class
