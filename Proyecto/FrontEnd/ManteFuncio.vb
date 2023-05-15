Imports Capa_Negocio
Public Class ManteFuncio
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try
            Dim obj_funcionario As New Funcionarios
            obj_funcionario.Identificacion = txtidentificacion.Text
            obj_funcionario.Nombre = txtnombre.Text
            obj_funcionario.Papellido = txtpapellido.Text
            obj_funcionario.Sapellido = txtsapellido.Text
            obj_funcionario.Usuario = txtusuario.Text
            obj_funcionario.Clave = txtclave.Text
            obj_funcionario.Estado = SeleccionEstado.Text

            obj_funcionario.ValidarFuncionario()
            obj_funcionario.ExisteFuncionario()
            obj_funcionario.llenarTabla()
            cargar()

            txtidentificacion.Text = ""
            txtnombre.Text = ""
            txtpapellido.Text = ""
            txtsapellido.Text = ""
            txtusuario.Text = ""
            txtclave.Text = ""
            SeleccionEstado.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cargar()
        Dim obj_funcionario As New Funcionarios
        Dim dt_funcionario As DataTable = obj_funcionario.leerXML()
        DatosFuncionarios.DataSource = dt_funcionario
    End Sub

    Private Sub ManteFuncio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            Dim i As Integer
            i = DatosFuncionarios.CurrentRow.Index
            Dim obj_funcionario As New Funcionarios
            obj_funcionario.Identificacion = DatosFuncionarios.Item(0, i).Value()
            obj_funcionario.Nombre = txtnombre.Text
            obj_funcionario.Papellido = txtpapellido.Text
            obj_funcionario.Sapellido = txtsapellido.Text
            obj_funcionario.Usuario = txtusuario.Text
            obj_funcionario.Clave = txtclave.Text
            obj_funcionario.Estado = SeleccionEstado.Text

            obj_funcionario.ValidarFuncionario()
            obj_funcionario.ModificarFuncionario()
            cargar()

            txtidentificacion.Text = ""
            txtnombre.Text = ""
            txtpapellido.Text = ""
            txtsapellido.Text = ""
            txtusuario.Text = ""
            txtclave.Text = ""
            SeleccionEstado.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DatosFuncionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosFuncionarios.CellClick
        Dim i As Integer
        i = DatosFuncionarios.CurrentRow.Index
        txtidentificacion.Text = DatosFuncionarios.Item(0, i).Value()
        txtnombre.Text = DatosFuncionarios.Item(1, i).Value()
        txtpapellido.Text = DatosFuncionarios.Item(2, i).Value()
        txtsapellido.Text = DatosFuncionarios.Item(3, i).Value()
        txtusuario.Text = DatosFuncionarios.Item(4, i).Value()
        txtclave.Text = DatosFuncionarios.Item(5, i).Value()
        SeleccionEstado.Text = DatosFuncionarios.Item(6, i).Value()
    End Sub
End Class