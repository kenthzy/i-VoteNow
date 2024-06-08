Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class Form1
    Private connectionString As String = "server=localhost;user id=root;password=;database=voting_system"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://localhost/webDev/index.php")
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPass.Text

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT * FROM admins WHERE username = @username AND password = @password"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Me.Hide()
                    Form3.Show()
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            End Using
        End Using
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
