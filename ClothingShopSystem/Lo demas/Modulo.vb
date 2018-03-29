Imports System.Data.SqlClient
Imports System.Configuration
Module Modulo

    Public moduloUsuario As String

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
        Return "C:\Users\oscar\Documents\GitHub\ClothingShopSystem\ClothingShopSystem\Reportes\ReportesLibros"
    End Function

    Public Function OpenBitacora()
        Dim conexionBitacora As New SqlConnection("Data Source = LAPTOP-JHARA789\KARINSPC; initial catalog='Bitacora'; Integrated Security = True")

        Return conexionBitacora
    End Function

    Public Function cerrarBitacora()
        Dim conexionBitacora As New SqlConnection("Data Source = LAPTOP-JHARA789\KARINSPC; initial catalog='Bitacora'; Integrated Security = True")

        conexionBitacora.Close()

        Return conexionBitacora
    End Function

    Public Function OpenMaster()
        Dim conexionBitacora As New SqlConnection("Data Source = LAPTOP-JHARA789\KARINSPC; initial catalog='master'; Integrated Security = True")

        Return conexionBitacora
    End Function

    Public Function cerrarMaster()
        Dim conexionBitacora As New SqlConnection("Data Source = LAPTOP-JHARA789\KARINSPC; initial catalog='master'; Integrated Security = True")

        conexionBitacora.Close()

        Return conexionBitacora
    End Function

    Public Function quitarComillas(message As String)
        While message.Contains("'")
            Dim x As Integer = message.IndexOf("'")
            message = message.Remove(x, 1)
        End While
        Return message
    End Function

    Public Function OpenHistorico()
        Dim conexionBitacora As New SqlConnection("Data Source = LAPTOP-JHARA789\KARINSPC; initial catalog='hdboClothingShopSystem'; Integrated Security = True")

        Return conexionBitacora
    End Function

    Public Function cerrarHistorico()
        Dim conexionBitacora As New SqlConnection("Data Source = LAPTOP-JHARA789\KARINSPC; initial catalog='dboClothingShopSystem'; Integrated Security = True")

        conexionBitacora.Close()

        Return conexionBitacora
    End Function
End Module

