Imports Capa_Negocio
Public Class ManteProduc
    Private Sub BTN_agregar_Click(sender As Object, e As EventArgs) Handles BTN_agregar.Click
        Try
            Dim obj_productos As New Productos
            obj_productos.Codigo = txtcodigo.Text
            obj_productos.Nombre = txtproducto.Text
            obj_productos.Cantidaddispo = txtcantidaddispo.Text
            obj_productos.Cantidadmin = txtcantidadmin.Text

            obj_productos.ValidarProducto()
            obj_productos.ExisteProducto()
            obj_productos.llenarTabla()
            cargar()

            txtcodigo.Text = ""
            txtproducto.Text = ""
            txtcantidaddispo.Text = ""
            txtcantidadmin.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cargar()
        Dim obj_producto As New Productos
        Dim dt_producto As DataTable = obj_producto.leerXML()
        DatosProductos.DataSource = dt_producto
    End Sub

    Private Sub ManteProduc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub BTN_modificar_Click(sender As Object, e As EventArgs) Handles BTN_modificar.Click
        Try
            Dim i As Integer
            i = DatosProductos.CurrentRow.Index
            Dim obj_productos As New Productos
            obj_productos.Codigo = DatosProductos.Item(0, i).Value()
            obj_productos.Nombre = txtproducto.Text
            obj_productos.Cantidaddispo = DatosProductos.Item(2, i).Value()
            obj_productos.Cantidadmin = txtcantidadmin.Text

            obj_productos.ValidarProducto()
            obj_productos.ModificarProducto()
            cargar()

            txtcodigo.Text = ""
            txtproducto.Text = ""
            txtcantidaddispo.Text = ""
            txtcantidadmin.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DatosProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosProductos.CellClick
        Dim i As Integer
        i = DatosProductos.CurrentRow.Index
        txtcodigo.Text = DatosProductos.Item(0, i).Value()
        txtproducto.Text = DatosProductos.Item(1, i).Value()
        txtcantidaddispo.Text = DatosProductos.Item(2, i).Value()
        txtcantidadmin.Text = DatosProductos.Item(3, i).Value()
    End Sub

    Private Sub BTN_actualizar_Click(sender As Object, e As EventArgs)
        cargar()
    End Sub
End Class