Imports Capa_Negocio
Public Class ManteEmple

    Private Sub BTN_agregar_Click(sender As Object, e As EventArgs) Handles BTN_agregar.Click
        Try
            Dim obj_empleado As New Empleados
            obj_empleado.Identificacion = txtidentificacion.Text
            obj_empleado.Nombre = txtnombre.Text
            obj_empleado.Papellido = txtpapellido.Text
            obj_empleado.Sapellido = txtsapellido.Text
            obj_empleado.Departamento = Selecciondepartamento.Text
            obj_empleado.Proyecto = txtproyecto.Text
            obj_empleado.Telefono = txttelefono.Text
            obj_empleado.Correo = txtcorreo.Text
            obj_empleado.Estado = SeleccionEstado.Text

            obj_empleado.ValidarEmpleado()
            obj_empleado.ExisteEmpleado()
            obj_empleado.llenarTabla()
            cargar()

            txtidentificacion.Text = ""
            txtnombre.Text = ""
            txtpapellido.Text = ""
            txtsapellido.Text = ""
            Selecciondepartamento.Text = ""
            txtproyecto.Text = ""
            txttelefono.Text = ""
            txtcorreo.Text = ""
            SeleccionEstado.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTN_modificar_Click(sender As Object, e As EventArgs) Handles BTN_modificar.Click
        Try
            Dim i As Integer
            i = DatosEmpleados.CurrentRow.Index
            Dim obj_empleado As New Empleados
            obj_empleado.Identificacion = DatosEmpleados.Item(0, i).Value()
            obj_empleado.Nombre = txtnombre.Text
            obj_empleado.Papellido = txtpapellido.Text
            obj_empleado.Sapellido = txtsapellido.Text
            obj_empleado.Departamento = Selecciondepartamento.Text
            obj_empleado.Proyecto = txtproyecto.Text
            obj_empleado.Telefono = txttelefono.Text
            obj_empleado.Correo = txtcorreo.Text
            obj_empleado.Estado = SeleccionEstado.Text

            obj_empleado.ValidarEmpleado()
            obj_empleado.ModificarEmpleado()
            cargar()

            txtidentificacion.Text = ""
            txtnombre.Text = ""
            txtpapellido.Text = ""
            txtsapellido.Text = ""
            Selecciondepartamento.Text = ""
            txtproyecto.Text = ""
            txttelefono.Text = ""
            txtcorreo.Text = ""
            SeleccionEstado.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ManteEmple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Public Sub cargar()
        Dim obj_empleado As New Empleados
        Dim dt_empleado As DataTable = obj_empleado.leerXML()
        DatosEmpleados.DataSource = dt_empleado
    End Sub

    Private Sub DatosEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosEmpleados.CellClick
        Dim i As Integer
        i = DatosEmpleados.CurrentRow.Index
        txtidentificacion.Text = DatosEmpleados.Item(0, i).Value()
        txtnombre.Text = DatosEmpleados.Item(1, i).Value()
        txtpapellido.Text = DatosEmpleados.Item(2, i).Value()
        txtsapellido.Text = DatosEmpleados.Item(3, i).Value()
        Selecciondepartamento.Text = DatosEmpleados.Item(4, i).Value()
        txtproyecto.Text = DatosEmpleados.Item(5, i).Value()
        txttelefono.Text = DatosEmpleados.Item(6, i).Value()
        txtcorreo.Text = DatosEmpleados.Item(7, i).Value()
        SeleccionEstado.Text = DatosEmpleados.Item(8, i).Value()
    End Sub
End Class