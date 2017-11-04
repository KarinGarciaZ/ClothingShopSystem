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

    Public Function obtenerRutaReportes()
        Return "C:\Users\elektramovil\Documents\GitHub\ClothingShopSystem\ClothingShopSystem\Reportes\ReportesLibros"
    End Function

    Public Function OpenBitacora()
        Dim conexionBitacora As New SqlConnection("Data Source = KARINSPC; initial catalog='Bitacora'; Integrated Security = True")

        Return conexionBitacora
    End Function

    Public Function cerrarBitacora()
        Dim conexionBitacora As New SqlConnection("Data Source = KARINSPC; initial catalog='Bitacora'; Integrated Security = True")

        conexionBitacora.Close()

        Return conexionBitacora
    End Function
End Module

