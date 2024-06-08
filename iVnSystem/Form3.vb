Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form3

    Private connectionString As String = "server=localhost;user id=root;password=;database=voting_system"
    Private myCDUserControl As CDUserControl1
    Private myVTUserControl As VTUserControl2

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRoundedCorners()

        myCDUserControl = New CDUserControl1()
        myCDUserControl.Dock = DockStyle.Fill
        myCDUserControl.Visible = False
        Me.Controls.Add(myCDUserControl)

        myVTUserControl = New VTUserControl2()
        myVTUserControl.Dock = DockStyle.Fill
        myVTUserControl.Visible = False
        Me.Controls.Add(myVTUserControl)

        PanelDash.Visible = True
        DTP.Visible = True

        UpdateNotVotedUserCount()
        UpdateUserCount()
        UpdateVoteCount()
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

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Guna2PictureBox1.Visible = True
        btnShow.Visible = False
        btnHide.Visible = True
        Panel1.Visible = False
        Panel1.Width = 150
        Guna2Transition1.ShowSync(Panel1)
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Guna2PictureBox1.Visible = False
        Panel1.Visible = False
        btnHide.Visible = False
        btnShow.Visible = True
        Panel1.Width = 41
        Guna2Transition1.ShowSync(Panel1)
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnCandidates_Click(sender As Object, e As EventArgs) Handles btnCandidates.Click
        myVTUserControl.Visible = False
        myCDUserControl.Visible = True
        DTP.Visible = False
        PanelDash.Visible = False
    End Sub

    Private Sub btnVoters_Click(sender As Object, e As EventArgs) Handles btnVoters.Click
        myCDUserControl.Visible = False
        myVTUserControl.Visible = True
        DTP.Visible = False
        PanelDash.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        myCDUserControl.Visible = False
        myVTUserControl.Visible = False
        DTP.Visible = True
        PanelDash.Visible = True
    End Sub

    Private Sub UpdateUserCount()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM users"
                Using cmd As New MySqlCommand(query, connection)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    labelUser.Text = count.ToString()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateNotVotedUserCount()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE has_voted = 0"
                Using cmd As New MySqlCommand(query, connection)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    labelStillNotVote.Text = count.ToString()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateVoteCount()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT SUM(vote_count) FROM candidates"
                Using cmd As New MySqlCommand(query, connection)
                    Dim totalVotes As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Dim maxVotes As Integer = 200
                    Dim percentage As Double = (totalVotes / maxVotes) * 100

                    ' Ensure the percentage does not exceed 100%
                    If percentage > 100 Then
                        percentage = 100
                    End If

                    labelTurnoutVote.Text = percentage.ToString("0.00") & "%"
                    circleProgressBar.Value = CInt(percentage)
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


End Class
