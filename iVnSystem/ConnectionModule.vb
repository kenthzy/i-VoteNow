Imports MySql.Data.MySqlClient

Module ConnectionModule

    Private connectionString As String = "server=localhost;user id=root;password=;database=voting_system"

    Public strcon As MySqlConnection = GetConnection()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Public Sub OpenConnection(ByRef connection As MySqlConnection)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection(ByRef connection As MySqlConnection)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while closing the database connection: " & ex.Message)
        End Try
    End Sub
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub
End Module
