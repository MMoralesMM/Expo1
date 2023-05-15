Imports Capa_Negocio

Public Class Entrada
    Dim obj_entrada As New Capa_Negocio.Entrada
    Dim objProducto As New Productos
    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProductos()
        cargarEntradas()
    End Sub
    Public Sub cargarProductos()
        Dim dtProductos As DataTable = objProducto.leerXML()
        DGV_productos.DataSource = dtProductos

        Me.CBO_Producto.DataSource = dtProductos
        Me.CBO_Producto.DisplayMember = "Producto"
        Me.CBO_Producto.ValueMember = "Codigo"
    End Sub
    Public Sub cargarEntradas()
        Dim obj_producto As New Capa_Negocio.Entrada
        Dim dt_producto As DataTable = obj_producto.leerXML()
        DGV_entrada.DataSource = dt_producto
    End Sub

    Private Sub BTN_agregar_Click(sender As Object, e As EventArgs) Handles BTN_agregar.Click
        Try
            obj_entrada.Nombre = CBO_Producto.Text
            obj_entrada.Cantidad = txtcantidad.Text
            obj_entrada.Identificacion = TXT_identificacion.Text

            obj_entrada.ValidarEntrada()
            obj_entrada.ValidarEmpleado()
            If obj_entrada.Correcto = True Then
                obj_entrada.AgregarProductos()
                obj_entrada.llenarTabla()
                cargarProductos()
                cargarEntradas()

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