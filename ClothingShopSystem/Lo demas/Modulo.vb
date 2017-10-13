Imports System.Data.SqlClient
Imports System.Configuration
Module Modulo
    Public Function openConnection()
        Dim conexionsql As SqlConnection
        conexionsql = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)

        Return conexionsql
    End Function

    Public Function cerrarConexion()
        Dim conexionsql As SqlConnection
        conexionsql = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)

        conexionsql.Close()

        Return conexionsql
    End Function


End Module

