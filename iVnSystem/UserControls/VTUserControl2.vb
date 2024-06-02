Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class VTUserControl2

    Private connectionString As String = "server=localhost;user id=root;password=;database=voting_system"

    Private Sub reload(query As String, dgv As DataGridView)
        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE users SET has_voted = 0"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Voted status has been reset successfully.")
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            reload("SELECT student_id, name, has_voted, created_at, email FROM users", DTGLIST2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
