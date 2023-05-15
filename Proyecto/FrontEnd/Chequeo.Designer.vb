<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chequeo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_productos = New System.Windows.Forms.DataGridView()
        Me.LBL_fecha = New System.Windows.Forms.Label()
        Me.BTN_generar = New System.Windows.Forms.Button()
        CType(Me.DGV_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha de chequeo:"
        '
        'DGV_productos
        '
        Me.DGV_productos.AllowUserToAddRows = False
        Me.DGV_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_productos.Location = New System.Drawing.Point(0, 34)
        Me.DGV_productos.Name = "DGV_productos"
        Me.DGV_productos.ReadOnly = True
        Me.DGV_productos.RowHeadersVisible = False
        Me.DGV_productos.Size = New System.Drawing.Size(800, 350)
        Me.DGV_productos.TabIndex = 7
        '
        'LBL_fecha
        '
        Me.LBL_fecha.AutoSize = True
        Me.LBL_fecha.Location = New System.Drawing.Point(116, 9)
        Me.LBL_fecha.Name = "LBL_fecha"
        Me.LBL_fecha.Size = New System.Drawing.Size(0, 13)
        Me.LBL_fecha.TabIndex = 8
        '
        'BTN_generar
        '
        Me.BTN_generar.Location = New System.Drawing.Point(300, 392)
        Me.BTN_generar.Name = "BTN_generar"
        Me.BTN_generar.Size = New System.Drawing.Size(200, 50)
        Me.BTN_generar.TabIndex = 9
        Me.BTN_generar.Text = "Generar XML"
        Me.BTN_generar.UseVisualStyleBackColor = True
        '
        'Chequeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_generar)
        Me.Controls.Add(Me.LBL_fecha)
        Me.Controls.Add(Me.DGV_productos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Chequeo"
        Me.Text = "Chequeo"
        CType(Me.DGV_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_productos As DataGridView
    Friend WithEvents LBL_fecha As Label
    Friend WithEvents BTN_generar As Button
End Class
