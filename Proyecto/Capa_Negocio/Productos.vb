Imports CapaDatos
Imports System.Xml

Public Class Productos
    Dim _codigo As String
    Dim _nombre As String
    Dim _cantidaddispo As Integer
    Dim _cantidadmin As Integer

#Region "Propiedades"
    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Cantidaddispo As Integer
        Get
            Return _cantidaddispo
        End Get
        Set(value As Integer)
            _cantidaddispo = value
        End Set
    End Property

    Public Property Cantidadmin As Integer
        Get
            Return _cantidadmin
        End Get
        Set(value As Integer)
            _cantidadmin = value
        End Set
    End Property


#End Region

#Region "Metodos"
    Public Function Tablaproductos()
        Dim tabla_productos As New DataTable
        Dim columnaTabla As New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Codigo"
        columnaTabla.Caption = "Codigo"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_productos.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Producto"
        columnaTabla.Caption = "Producto"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_productos.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Cantidad disponible"
        columnaTabla.Caption = "Cantidad disponible"
        columnaTabla.DataType = Type.GetType("System.Int32")

        tabla_productos.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Cantidad minima"
        columnaTabla.Caption = "Cantidad minima"
        columnaTabla.DataType = Type.GetType("System.Int32")

        tabla_productos.Columns.Add(columnaTabla)
        Return tabla_productos
    End Function
    Sub ValidarProducto()
        If Not IsNumeric(_codigo) Then
            Throw New Exception("El codigo debe ser numérico")
        End If
        If IsNumeric(_nombre) Or _nombre.Trim.Length = 0 Then
            Throw New Exception("El producto no debe contener números o estar en blanco")
        End If
        If Not IsNumeric(Cantidaddispo) Or Cantidaddispo <= 0 Or Cantidaddispo.ToString.Trim.Length = 0 Then
            Throw New Exception("La cantidad disponible debe ser mayor a 0 o no estar en blanco")
        End If
        If Not IsNumeric(Cantidadmin) Or Cantidadmin <= 0 Or Cantidadmin.ToString.Trim.Length = 0 Then
            Throw New Exception("La cantidad minima debe ser mayor a 0 o no estar en blanco")
        End If
    End Sub
    Sub ExisteProducto()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_producto As DataTable = Me.Tablaproductos.copy
        If obj_datos_Lectura.verificarXMLP Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLP()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dt_producto.NewRow
                If Codigo = producto("Codigo").InnerText Then
                    Throw New Exception("Ya hay un producto registrado con el mismo codigo")
                End If
            Next
        End If
    End Sub
    Sub ModificarProducto()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_producto As DataTable = Me.Tablaproductos.copy
        If obj_datos_Lectura.verificarXMLP Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLP()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")

            Dim _archivo As New XmlTextWriter("Productos.xml", Text.Encoding.UTF8)
            _archivo.WriteStartDocument()
            _archivo.WriteStartElement("Productos")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dt_producto.NewRow
                If Codigo = producto("Codigo").InnerText Then
                    fila("Codigo") = Codigo
                    fila("Producto") = Nombre
                    fila("Cantidad disponible") = Cantidaddispo
                    fila("Cantidad minima") = Cantidadmin

                    _archivo.WriteStartElement("Producto")

                    _archivo.WriteStartElement("Codigo")
                    _archivo.WriteString(fila("Codigo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Producto")
                    _archivo.WriteString(fila("Producto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Cantidaddisponible")
                    _archivo.WriteString(fila("Cantidad disponible"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Cantidadminima")
                    _archivo.WriteString(fila("Cantidad minima"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                Else
                    fila("Codigo") = producto("Codigo").InnerText
                    fila("Producto") = producto("Producto").InnerText
                    fila("Cantidad disponible") = producto("Cantidaddisponible").InnerText
                    fila("Cantidad minima") = producto("Cantidadminima").InnerText

                    _archivo.WriteStartElement("Producto")

                    _archivo.WriteStartElement("Codigo")
                    _archivo.WriteString(fila("Codigo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Producto")
                    _archivo.WriteString(fila("Producto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Cantidaddisponible")
                    _archivo.WriteString(fila("Cantidad disponible"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Cantidadminima")
                    _archivo.WriteString(fila("Cantidad minima"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                End If
            Next
            _archivo.WriteEndElement()
            _archivo.WriteEndDocument()

            _archivo.Flush()
            _archivo.Close()
        End If
    End Sub
    Public Sub llenarTabla()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_producto As DataTable = Me.Tablaproductos.copy
        If obj_datos_Lectura.verificarXMLP Then
            dt_producto = Me.leerXML
        End If

        Dim fila As DataRow
        fila = dt_producto.NewRow

        fila("Codigo") = Codigo
        fila("Producto") = Nombre
        fila("Cantidad disponible") = Cantidaddispo
        fila("Cantidad minima") = Cantidadmin

        dt_producto.Rows.Add(fila)

        Dim obj_datos As New Escritura
        obj_datos.Tabla = dt_producto

        obj_datos.EscribirProducto()
    End Sub
    Public Function leerXML()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_producto As DataTable = Me.Tablaproductos.copy
        If obj_datos_Lectura.verificarXMLP Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLP()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dt_producto.NewRow
                fila("Codigo") = producto("Codigo").InnerText
                fila("Producto") = producto("Producto").InnerText
                fila("Cantidad disponible") = producto("Cantidaddisponible").InnerText
                fila("Cantidad minima") = producto("Cantidadminima").InnerText
                dt_producto.Rows.Add(fila)
            Next
        End If
        Return dt_producto
    End Function
#End Region
End Class