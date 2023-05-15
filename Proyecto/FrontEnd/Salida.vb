Imports Capa_Negocio

Public Class Salida
    Dim obj_salida As New Capa_Negocio.Salida
    Dim objProducto As New Productos
    Private Sub Salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProductos()
        cargarSalidas()
    End Sub
    Public Sub cargarProductos()
        Dim dtProductos As DataTable = objProducto.leerXML()
        DGV_productos.DataSource = dtProductos

        Me.CBO_Producto.DataSource = dtProductos
        Me.CBO_Producto.DisplayMember = "Producto"
        Me.CBO_Producto.ValueMember = "Codigo"
    End Sub
    Public Sub cargarSalidas()
        Dim obj_producto As New Capa_Negocio.Salida
        Dim dt_producto As DataTable = obj_producto.leerXML()
        DGV_salida.DataSource = dt_producto
    End Sub

    Private Sub BTN_agregar_Click(sender As Object, e As EventArgs) Handles BTN_agregar.Click
        Try
            obj_salida.Nombre = CBO_Producto.Text
            obj_salida.Cantidad = txtcantidad.Text
            obj_salida.Identificacion = TXT_identificacion.Text

            obj_salida.ValidarSalida()
            obj_salida.VerificarCantidad()
            obj_salida.ValidarEmpleado()
            If obj_salida.Correcto = True Then
                obj_salida.EliminarProductos()
                obj_salida.llenarTabla()
                cargarProductos()
                cargarSalidas()

                CBO_Producto.Text = ""
                txtcantidad.Text = ""
                TXT_identificacion.Text = ""
            Else
                MessageBox.Show("El empleado esta inactivo o no tenemos empleados con esa identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class