Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '// handle load image blink
        Application.DoEvents()
        Dim connection As Connection = New Connection()

        loadingText.Text = "Try Connect to Database"
        Dim connect As MySqlConnection = connection.connect()

        If (connection.is_connected) Then
            loadingText.Text = "Database Connected"

            Dim query As String = "SELECT * FROM data_variable where code = '" + Connection.VAR_DATA_VARIABLE_USERNAME + "' limit 1"
            Dim cmd As New MySqlCommand(query, connect)
            Dim rd As MySqlDataReader

            rd = cmd.ExecuteReader

            If (rd.Read) Then
                connect.Close()
                Form3.Show()
                Me.Visible = False
            Else
                connect.Close()
                Form2.Show()
                Me.Visible = False
            End If
        Else
            loadingText.Text = "Error: Database Failed to Connect!"
            reconnect.Visible = True
        End If


    End Sub

    Private Sub reconnect_Click(sender As Object, e As EventArgs) Handles reconnect.Click
        Application.Restart()
    End Sub
End Class
