Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim connection As Connection = New Connection()
            Dim connect As MySqlConnection = connection.connect
            Dim username As String = usernameText.Text
            Dim query As String = "INSERT INTO data_variable (code, value) VALUES ('" + Connection.VAR_DATA_VARIABLE_USERNAME + "','" + username + "')"
            Dim cmd As MySqlCommand = New MySqlCommand(query, connect)
            cmd.ExecuteNonQuery()

            Form3.Show()
            Me.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class