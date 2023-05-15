Imports System.Xml
Imports CapaDatos

Public Class Funcionarios
    Dim _identificacion As String
    Dim _nombre As String
    Dim _papellido As String
    Dim _sapellido As String
    Dim _usuario As String
    Dim _clave As String
    Dim _estado As String
    Dim _correcto As Boolean = False

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
    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property
    Public Property Clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
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

    Public Property Correcto As Boolean
        Get
            Return _correcto
        End Get
        Set(value As Boolean)
            _correcto = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Tablafuncionarios()
        Dim tabla_funcionarios As New DataTable
        Dim columnaTabla As New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Identificacion"
        columnaTabla.Caption = "Identificacion"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_funcionarios.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Nombre"
        columnaTabla.Caption = "Nombre"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_funcionarios.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Primer Apellido"
        columnaTabla.Caption = "Primer Apellido"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_funcionarios.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Segundo Apellido"
        columnaTabla.Caption = "Segundo Apellido"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_funcionarios.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Usuario"
        columnaTabla.Caption = "Usuario"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_funcionarios.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Clave"
        columnaTabla.Caption = "Clave"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_funcionarios.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Estado"
        columnaTabla.Caption = "Estado"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_funcionarios.Columns.Add(columnaTabla)
        Return tabla_funcionarios
    End Function
    Sub ValidadCredenciales()
        If _usuario.Trim.Length = 0 Or _clave.Trim.Length = 0 Then
            Throw New Exception("Usuario o contraseña vacíos")
        End If
        If _clave.Trim.Length = 0 Then
            Throw New Exception("Usuario o contraseña vacíos")
        End If
        Dim obj_datos_Lectura As New Lectura
        Dim dt_funcionario As DataTable = Me.Tablafuncionarios.copy
        If obj_datos_Lectura.verificarXMLF Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLF()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")
            Dim fila As DataRow

            For Each funcionario As XmlNode In listaXML
                fila = dt_funcionario.NewRow
                If Usuario = funcionario("Usuario").InnerText Then
                    If Clave = funcionario("Clave").InnerText Then
                        If "Activo" = funcionario("Estado").InnerText Then
                            Correcto = True
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Sub ValidarFuncionario()
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
        If _usuario.Trim.Length = 0 Then
            Throw New Exception("El usuario no debe estar en blanco")
        End If
        If _clave.Trim.Length = 0 Then
            Throw New Exception("La clave no debe estar en blanco")
        End If
        If _estado = "" Then
            Throw New Exception("Debe de seleccionar un estado")
        End If

    End Sub
    Sub ExisteFuncionario()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_funcionario As DataTable = Me.Tablafuncionarios.copy
        If obj_datos_Lectura.verificarXMLF Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLF()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")
            Dim fila As DataRow

            For Each funcionario As XmlNode In listaXML
                fila = dt_funcionario.NewRow
                If Identificacion = funcionario("Identificacion").InnerText Then
                    Throw New Exception("Ya hay un usuario registrado con el mismo número de cédula")
                End If
            Next
        End If
    End Sub
    Sub ModificarFuncionario()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_funcionario As DataTable = Me.Tablafuncionarios.copy
        If obj_datos_Lectura.verificarXMLF Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLF()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")

            Dim _archivo As New XmlTextWriter("Funcionarios.xml", Text.Encoding.UTF8)
            _archivo.WriteStartDocument()
            _archivo.WriteStartElement("Funcionarios")
            Dim fila As DataRow

            For Each funcionario As XmlNode In listaXML
                fila = dt_funcionario.NewRow
                If Identificacion = funcionario("Identificacion").InnerText Then
                    fila("Identificacion") = Identificacion
                    fila("Nombre") = Nombre
                    fila("Primer Apellido") = Papellido
                    fila("Segundo Apellido") = Sapellido
                    fila("Usuario") = Usuario
                    fila("Clave") = Clave
                    fila("Estado") = Estado

                    _archivo.WriteStartElement("Funcionario")

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

                    _archivo.WriteStartElement("Usuario")
                    _archivo.WriteString(fila("Usuario"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Clave")
                    _archivo.WriteString(fila("Clave"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Estado")
                    _archivo.WriteString(fila("Estado"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                Else
                    fila("Identificacion") = funcionario("Identificacion").InnerText
                    fila("Nombre") = funcionario("Nombre").InnerText
                    fila("Primer Apellido") = funcionario("PApellido").InnerText
                    fila("Segundo Apellido") = funcionario("SApellido").InnerText
                    fila("Usuario") = funcionario("Usuario").InnerText
                    fila("Clave") = funcionario("Clave").InnerText
                    fila("Estado") = funcionario("Estado").InnerText

                    _archivo.WriteStartElement("Funcionario")

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

                    _archivo.WriteStartElement("Usuario")
                    _archivo.WriteString(fila("Usuario"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Clave")
                    _archivo.WriteString(fila("Clave"))
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
        Dim dt_funcionario As DataTable = Me.Tablafuncionarios.copy
        If obj_datos_Lectura.verificarXMLF Then
            dt_funcionario = Me.leerXML
        End If

        Dim fila As DataRow
        fila = dt_funcionario.NewRow

        fila("Identificacion") = Identificacion
        fila("Nombre") = Nombre
        fila("Primer Apellido") = Papellido
        fila("Segundo Apellido") = Sapellido
        fila("Usuario") = Usuario
        fila("Clave") = Clave
        fila("Estado") = Estado

        dt_funcionario.Rows.Add(fila)

        Dim obj_datos As New Escritura
        obj_datos.Tabla = dt_funcionario

        obj_datos.EscribirFuncionario()
    End Sub
    Public Function leerXML()
        Dim obj_datos_Lectura As New Lectura
        Dim dt_funcionario As DataTable = Me.Tablafuncionarios.copy
        If obj_datos_Lectura.verificarXMLF Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerXMLF()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")
            Dim fila As DataRow

            For Each funcionario As XmlNode In listaXML
                fila = dt_funcionario.NewRow
                fila("Identificacion") = funcionario("Identificacion").InnerText
                fila("Nombre") = funcionario("Nombre").InnerText
                fila("Primer Apellido") = funcionario("PApellido").InnerText
                fila("Segundo Apellido") = funcionario("SApellido").InnerText
                fila("Usuario") = funcionario("Usuario").InnerText
                fila("Clave") = funcionario("Clave").InnerText
                fila("Estado") = funcionario("Estado").InnerText
                dt_funcionario.Rows.Add(fila)
            Next
        End If
        Return dt_funcionario
    End Function
#End Region
End Class