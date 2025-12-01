Imports System.Data.SqlClient

Module Module1

    Public Const CadenaConexion As String = "Data Source=localhost\sqlexpress;Initial Catalog=SFC;Integrated Security=True;TrustServerCertificate=True"


    Public Operacion As String
    Public sqlinformes As String
    Public IdClienteSelec As Integer
    Public IdMedicamentoSelec As Integer
    Public IdUsuarioSelec As Integer
    Public IdVentaSelec As Integer
    Public IdUsuarioLog As Integer
    Public AccesoLog As Integer

    Public Sub Ejecutar(ByVal cadenaSQL As String)
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando = New SqlClient.SqlCommand
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = cadenaSQL
        Comando.ExecuteNonQuery()

        Conexion.Close()
    End Sub

    Public Sub Recuperar(ByVal cadenaSQL As String, ByRef tabla As DataTable)
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando = New SqlClient.SqlCommand
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = cadenaSQL
        tabla = New DataTable
        tabla.Load(Comando.ExecuteReader)

        Conexion.Close()
    End Sub
    Public Function GenerarHash256(Cadena As String)
        Dim AlgoritmoHash As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim inputBytes() As Byte
        Dim hashBytes() As Byte
        Dim Salida As String

        inputBytes = System.Text.Encoding.UTF8.GetBytes(Cadena)
        hashBytes = AlgoritmoHash.ComputeHash(inputBytes)

        Salida = ""
        For Each b In hashBytes
            Salida = Salida & b.ToString("x2")
        Next

        Return Salida
    End Function
End Module