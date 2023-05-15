Imports Capa_Negocio

Public Class Chequeo
    Dim obj_chequeo As New Sistema_de_Compras
    Private Sub Chequeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_fecha.Text = DateTime.Now.ToString()
        Dim dt_producto As DataTable = obj_chequeo.leerXML()
        DGV_productos.DataSource = dt_producto
    End Sub

    Private Sub BTN_generar_Click(sender As Object, e As EventArgs) Handles BTN_generar.Click
        obj_chequeo.CrearXML()
    End Sub
End Class