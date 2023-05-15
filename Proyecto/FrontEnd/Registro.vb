Imports Capa_Negocio
Public Class Registro
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
            MessageBox.Show("El funcionario se ingreso correctamente.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class