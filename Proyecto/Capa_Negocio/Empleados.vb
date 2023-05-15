Imports CapaDatos
Imports System.Xml

Public Class Empleados
    Dim _identificacion As String
    Dim _nombre As String
    Dim _papellido As String
    Dim _sapellido As String
    Dim _departamento As String
    Dim _proyecto As String
    Dim _telefono As String
    Dim _correo As String
    Dim _estado As String

#Region "Propiedades"
    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
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
    Public Property Papellido As String
        Get
            Return _papellido
        End Get
        Set(value As String)
            _papellido = value
        End Set
    End Property
    Public Property Sapellido As String
        Get
            Return _sapellido
        End Get
        Set(value As String)
            _sapellido = value
        End Set
    End Property
    Public Property Departamento As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property Proyecto As String
        Get
            Return _proyecto
        End Get
        Set(value As String)
            _proyecto = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Tablaempleados()
        Dim tabla_empleados As New DataTable
        Dim columnaTabla As New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Identificacion"
        columnaTabla.Caption = "Identificacion"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Nombre"
        columnaTabla.Caption = "Nombre"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Primer Apellido"
        columnaTabla.Caption = "Primer Apellido"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Segundo Apellido"
        columnaTabla.Caption = "Segundo Apellido"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Departamento"
        columnaTabla.Caption = "Departamento"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Proyecto"
        columnaTabla.Caption = "Proyecto"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Telefono"
        columnaTabla.Caption = "Telefono"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Correo"
        columnaTabla.Caption = "Correo"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Estado"
        columnaTabla.Caption = "Estado"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_empleados.Columns.Add(columnaTabla)
        Return tabla_empleados
    End Function
    Sub ValidarEmpleado()
        If Not IsNumeric(_identificacion) Or _identificacion.Trim.Length <> 9 Then
            Throw New Exception("La identificación debe tener un tamaño de 9 dígitos y ser numérico")
        End If
        If IsNumeric(_nombre) Or _nombre.Trim.Length = 0 Then
            Throw New Exception("El nombre no debe contener números o estar en blanco")
        End If
        If IsNumeric(_papellido) Or _papellido.Trim.Length = 0 Then
            Throw New Exception("El primer apellido no debe contener números o estar en blanco")
        End If
        If IsNumeric(_sapellido) Or _sapellido.Trim.Length = 0 Then
            Throw New Exception("El segundo apellido no debe contener números o estar en blanco")
        End If
        If _departamento = "" Then
            Throw New Exception("Debe de seleccionar un departamento")
        End If
        If _departamento = "Construcción" Then
            If IsNumeric(_proyecto) Or _proyecto.Trim.Length = 0 Then
                Throw New Exception("El proyecto no debe contener números o estar en blanco")
            End If
        Else
            Proyecto = "No aplica"
        End If
        If Not IsNumeric(_telefono) Or _telefono.Trim.Length <> 8 Then
            Throw New Exception("El telefono debe tener un tamaño de 8 digitos y ser numerico")
        End If
        If _correo.Trim.Length = 0 Then
            Throw New Exception("El correo no debe estar en blanco")
        End If
        If _estado = "" Then
            Throw New Exception("Debe de seleccionar un estado")
        End If
    End Sub
    Sub ExisteEmpleado()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_empleado As DataTable = Me.Tablaempleados.copy
        If obj_datos_Lectura.verificarXMLE Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLE()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")
            Dim fila As DataRow

            For Each empleado As XmlNode In listaXML
                fila = dt_empleado.NewRow
                If Identificacion = empleado("Identificacion").InnerText Then
                    Throw New Exception("Ya hay un usuario registrado con el mismo número de cédula")
                End If
            Next
        End If
    End Sub
    Sub ModificarEmpleado()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_empleado As DataTable = Me.Tablaempleados.copy
        If obj_datos_Lectura.verificarXMLE Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLE()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")

            Dim _archivo As New XmlTextWriter("Empleados.xml", Text.Encoding.UTF8)
            _archivo.WriteStartDocument()
            _archivo.WriteStartElement("Empleados")
            Dim fila As DataRow

            For Each empleado As XmlNode In listaXML
                fila = dt_empleado.NewRow
                If Identificacion = empleado("Identificacion").InnerText Then
                    fila("Identificacion") = Identificacion
                    fila("Nombre") = Nombre
                    fila("Primer Apellido") = Papellido
                    fila("Segundo Apellido") = Sapellido
                    fila("Departamento") = Departamento
                    fila("Proyecto") = Proyecto
                    fila("Telefono") = Telefono
                    fila("Correo") = Correo
                    fila("Estado") = Estado

                    _archivo.WriteStartElement("Empleado")

                    _archivo.WriteStartElement("Identificacion")
                    _archivo.WriteString(fila("Identificacion"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Nombre")
                    _archivo.WriteString(fila("Nombre"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("PApellido")
                    _archivo.WriteString(fila("Primer Apellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("SApellido")
                    _archivo.WriteString(fila("Segundo Apellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Departamento")
                    _archivo.WriteString(fila("Departamento"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Proyecto")
                    _archivo.WriteString(fila("Proyecto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Telefono")
                    _archivo.WriteString(fila("Telefono"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Correo")
                    _archivo.WriteString(fila("Correo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Estado")
                    _archivo.WriteString(fila("Estado"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                Else
                    fila("Identificacion") = empleado("Identificacion").InnerText
                    fila("Nombre") = empleado("Nombre").InnerText
                    fila("Primer Apellido") = empleado("PApellido").InnerText
                    fila("Segundo Apellido") = empleado("SApellido").InnerText
                    fila("Departamento") = empleado("Departamento").InnerText
                    fila("Proyecto") = empleado("Proyecto").InnerText
                    fila("Telefono") = empleado("Telefono").InnerText
                    fila("Correo") = empleado("Correo").InnerText
                    fila("Estado") = empleado("Estado").InnerText

                    _archivo.WriteStartElement("Empleado")

                    _archivo.WriteStartElement("Identificacion")
                    _archivo.WriteString(fila("Identificacion"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Nombre")
                    _archivo.WriteString(fila("Nombre"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("PApellido")
                    _archivo.WriteString(fila("Primer Apellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("SApellido")
                    _archivo.WriteString(fila("Segundo Apellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Departamento")
                    _archivo.WriteString(fila("Departamento"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Proyecto")
                    _archivo.WriteString(fila("Proyecto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Telefono")
                    _archivo.WriteString(fila("Telefono"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Correo")
                    _archivo.WriteString(fila("Correo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Estado")
                    _archivo.WriteString(fila("Estado"))
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
        Dim dt_empleado As DataTable = Me.Tablaempleados.copy
        If obj_datos_Lectura.verificarXMLE Then
            dt_empleado = Me.leerXML
        End If

        Dim fila As DataRow
        fila = dt_empleado.NewRow

        fila("Identificacion") = Identificacion
        fila("Nombre") = Nombre
        fila("Primer Apellido") = Papellido
        fila("Segundo Apellido") = Sapellido
        fila("Departamento") = Departamento
        fila("Proyecto") = Proyecto
        fila("Telefono") = Telefono
        fila("Correo") = Correo
        fila("Estado") = Estado

        dt_empleado.Rows.Add(fila)

        Dim obj_datos As New Escritura
        obj_datos.Tabla = dt_empleado

        obj_datos.EscribirEmpleado()
    End Sub
    Public Function leerXML()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_empleado As DataTable = Me.Tablaempleados.copy
        If obj_datos_Lectura.verificarXMLE Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLE()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")
            Dim fila As DataRow

            For Each empleado As XmlNode In listaXML
                fila = dt_empleado.NewRow
                fila("Identificacion") = empleado("Identificacion").InnerText
                fila("Nombre") = empleado("Nombre").InnerText
                fila("Primer Apellido") = empleado("PApellido").InnerText
                fila("Segundo Apellido") = empleado("SApellido").InnerText
                fila("Departamento") = empleado("Departamento").InnerText
                fila("Proyecto") = empleado("Proyecto").InnerText
                fila("Telefono") = empleado("Telefono").InnerText
                fila("Correo") = empleado("Correo").InnerText
                fila("Estado") = empleado("Estado").InnerText
                dt_empleado.Rows.Add(fila)
            Next
        End If
        Return dt_empleado
    End Function
#End Region
End Class