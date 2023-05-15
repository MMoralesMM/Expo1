Imports Capa_Negocio
Public Class Login
    Dim obj_iniciar As New Funcionarios
    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Try
            obj_iniciar.Usuario = txtusuario.Text
            obj_iniciar.Clave = txtcontra.Text

            obj_iniciar.ValidadCredenciales()

            If obj_iniciar.Correcto = True Then
                Me.Hide()
                Principal.Show()
                MessageBox.Show(text:="El inicio de sesion fue exitoso", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(text:="El inicio de sesion fue erróneo", "Inicio de sesión erróneo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Registro.Show()
    End Sub
End Class