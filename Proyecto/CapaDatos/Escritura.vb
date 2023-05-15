Imports System.Xml
Public Class Escritura
    Dim _tabla As DataTable

#Region "Propiedades"
    Public Property Tabla As DataTable
        Get
            Return _tabla
        End Get
        Set(value As DataTable)
            _tabla = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Sub EscribirFuncionario()
        Dim _archivo As New XmlTextWriter("Funcionarios.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Funcionarios")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Funcionario")

            _archivo.WriteStartElement("Identificacion")
            _archivo.WriteString(Fila("Identificacion"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Nombre")
            _archivo.WriteString(Fila("Nombre"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("PApellido")
            _archivo.WriteString(Fila("Primer Apellido"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("SApellido")
            _archivo.WriteString(Fila("Segundo Apellido"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Usuario")
            _archivo.WriteString(Fila("Usuario"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Clave")
            _archivo.WriteString(Fila("Clave"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Estado")
            _archivo.WriteString(Fila("Estado"))
            _archivo.WriteEndElement()

            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()
        _archivo.Close()
    End Sub
    Sub EscribirEmpleado()
        Dim _archivo As New XmlTextWriter("Empleados.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Empleados")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Empleado")

            _archivo.WriteStartElement("Identificacion")
            _archivo.WriteString(Fila("Identificacion"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Nombre")
            _archivo.WriteString(Fila("Nombre"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("PApellido")
            _archivo.WriteString(Fila("Primer Apellido"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("SApellido")
            _archivo.WriteString(Fila("Segundo Apellido"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Departamento")
            _archivo.WriteString(Fila("Departamento"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Proyecto")
            _archivo.WriteString(Fila("Proyecto"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Telefono")
            _archivo.WriteString(Fila("Telefono"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Correo")
            _archivo.WriteString(Fila("Correo"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Estado")
            _archivo.WriteString(Fila("Estado"))
            _archivo.WriteEndElement()

            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()
        _archivo.Close()
    End Sub
    Sub EscribirProducto()
        Dim _archivo As New XmlTextWriter("Productos.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Productos")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Producto")

            _archivo.WriteStartElement("Codigo")
            _archivo.WriteString(Fila("Codigo"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Producto")
            _archivo.WriteString(Fila("Producto"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Cantidaddisponible")
            _archivo.WriteString(Fila("Cantidad disponible"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Cantidadminima")
            _archivo.WriteString(Fila("Cantidad minima"))
            _archivo.WriteEndElement()

            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()
        _archivo.Close()
    End Sub
    Sub EscribirEntrada()
        Dim _archivo As New XmlTextWriter("Entradas.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Entradas")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Entrada")

            _archivo.WriteStartElement("Producto")
            _archivo.WriteString(Fila("Producto"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Cantidad")
            _archivo.WriteString(Fila("Cantidad"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Fecha")
            _archivo.WriteString(Fila("Fecha"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Movimiento")
            _archivo.WriteString(Fila("Movimiento"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Empleado")
            _archivo.WriteString(Fila("Empleado"))
            _archivo.WriteEndElement()

            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()
        _archivo.Close()
    End Sub
    Sub EscribirSalida()
        Dim _archivo As New XmlTextWriter("Salidas.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Salidas")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Salida")

            _archivo.WriteStartElement("Producto")
            _archivo.WriteString(Fila("Producto"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Cantidad")
            _archivo.WriteString(Fila("Cantidad"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Fecha")
            _archivo.WriteString(Fila("Fecha"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Movimiento")
            _archivo.WriteString(Fila("Movimiento"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Empleado")
            _archivo.WriteString(Fila("Empleado"))
            _archivo.WriteEndElement()

            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()
        _archivo.Close()
    End Sub
    Sub EscribirSistemadecompras()
        Dim _archivo As New XmlTextWriter("Sistema de compras.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Productos")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Producto")

            _archivo.WriteStartElement("Fecha")
            _archivo.WriteString(Fila("Fecha"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Codigo")
            _archivo.WriteString(Fila("Codigo"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Producto")
            _archivo.WriteString(Fila("Producto"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Cantidaddisponible")
            _archivo.WriteString(Fila("Cantidad disponible"))
            _archivo.WriteEndElement()

            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()
        _archivo.Close()
    End Sub
#End Region
End Class
