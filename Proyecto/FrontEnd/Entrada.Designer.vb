<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entrada
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
        Me.DGV_entrada = New System.Windows.Forms.DataGridView()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBO_Producto = New System.Windows.Forms.ComboBox()
        Me.BTN_agregar = New System.Windows.Forms.Button()
        Me.TXT_identificacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV_productos = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_entrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_entrada
        '
        Me.DGV_entrada.AllowUserToAddRows = False
        Me.DGV_entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_entrada.Location = New System.Drawing.Point(0, 161)
        Me.DGV_entrada.Name = "DGV_entrada"
        Me.DGV_entrada.ReadOnly = True
        Me.DGV_entrada.RowHeadersVisible = False
        Me.DGV_entrada.Size = New System.Drawing.Size(800, 289)
        Me.DGV_entrada.TabIndex = 4
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(117, 37)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(150, 20)
        Me.txtcantidad.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Cantidad a ingresar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Producto"
        '
        'CBO_Producto
        '
        Me.CBO_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_Producto.FormattingEnabled = True
        Me.CBO_Producto.Location = New System.Drawing.Point(117, 12)
        Me.CBO_Producto.Name = "CBO_Producto"
        Me.CBO_Producto.Size = New System.Drawing.Size(150, 21)
        Me.CBO_Producto.TabIndex = 0
        '
        'BTN_agregar
        '
        Me.BTN_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregar.Location = New System.Drawing.Point(117, 89)
        Me.BTN_agregar.Name = "BTN_agregar"
        Me.BTN_agregar.Size = New System.Drawing.Size(150, 50)
        Me.BTN_agregar.TabIndex = 3
        Me.BTN_agregar.Text = "Agregar"
        Me.BTN_agregar.UseVisualStyleBackColor = True
        '
        'TXT_identificacion
        '
        Me.TXT_identificacion.Location = New System.Drawing.Point(117, 63)
        Me.TXT_identificacion.Name = "TXT_identificacion"
        Me.TXT_identificacion.Size = New System.Drawing.Size(150, 20)
        Me.TXT_identificacion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Identificacion"
        '
        'DGV_productos
        '
        Me.DGV_productos.AllowUserToAddRows = False
        Me.DGV_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_productos.Location = New System.Drawing.Point(273, 12)
        Me.DGV_productos.Name = "DGV_productos"
        Me.DGV_productos.ReadOnly = True
        Me.DGV_productos.RowHeadersVisible = False
        Me.DGV_productos.Size = New System.Drawing.Size(515, 127)
        Me.DGV_productos.TabIndex = 55
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGV_productos)
        Me.Controls.Add(Me.TXT_identificacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_agregar)
        Me.Controls.Add(Me.CBO_Producto)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_entrada)
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        CType(Me.DGV_entrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_entrada As DataGridView
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBO_Producto As ComboBox
    Friend WithEvents BTN_agregar As Button
    Friend WithEvents TXT_identificacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV_productos As DataGridView
End Class
