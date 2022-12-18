Imports MySql.Data.MySqlClient
Public Class Connection

    Private Const DATABASE = "catetin"
    Private Const USER = "root"
    Private Const PASSWORD = ""
    Private Const SERVER = "localhost"
    Public is_connected As Boolean
    Public Const VAR_DATA_VARIABLE_USERNAME = "USERNAME"



    Public Function connect() As MySqlConnection
        Try
            connect = New MySqlConnection("server=" + SERVER + ";user=" + USER + ";password=" + PASSWORD + ";database=" + DATABASE)
            connect.Open()
            is_connected = True
        Catch ex As Exception
            is_connected = False
        End Try
        Return connect
    End Function
End Class
