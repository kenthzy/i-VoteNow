Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form2

    Private connectionString As String = "server=localhost;user id=root;password=;database=voting_system"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRoundedCorners()
    End Sub
    Private Sub SetRoundedCorners()
        Dim cornerRadius As Integer = 20

        Dim path As New GraphicsPath()

        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(Me.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(Me.Width - cornerRadius, Me.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, Me.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
    End Sub


    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        SetRoundedCorners()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim name As String = txtName.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPass.Text
        Dim repeatPassword As String = txtRepeatPass.Text

        If password <> repeatPassword Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO admins (name, username, password) VALUES (@name, @username, @password)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sign up successful.")
                    Me.Hide()
                    Form1.Show()
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


End Class