Imports System.IO
Imports System.Xml
Public Class Lectura
    Dim _archivo As New XmlDocument

#Region "Propiedades"
    Public Property Archivo As XmlDocument
        Get
            Return _archivo
        End Get
        Set(value As XmlDocument)
            _archivo = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function verificarXMLF()
        Return File.Exists("Funcionarios.xml")
    End Function

    Public Function leerXMLF()
        Archivo.Load("Funcionarios.xml")
        Return Archivo
    End Function
    Public Function verificarXMLE()
        Return File.Exists("Empleados.xml")
    End Function

    Public Function leerXMLE()
        Archivo.Load("Empleados.xml")
        Return Archivo
    End Function
    Public Function verificarXMLP()
        Return File.Exists("Productos.xml")
    End Function

    Public Function leerXMLP()
        Archivo.Load("Productos.xml")
        Return Archivo
    End Function
    Public Function verificarXMLPE()
        Return File.Exists("Entradas.xml")
    End Function

    Public Function leerXMLPE()
        Archivo.Load("Entradas.xml")
        Return Archivo
    End Function
    Public Function verificarXMLPS()
        Return File.Exists("Salidas.xml")
    End Function

    Public Function leerXMLPS()
        Archivo.Load("Salidas.xml")
        Return Archivo
    End Function
#End Region
End Class