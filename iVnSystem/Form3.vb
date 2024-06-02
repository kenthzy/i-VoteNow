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
    End Sub

    Private Sub btnVoters_Click(sender As Object, e As EventArgs) Handles btnVoters.Click
        myCDUserControl.Visible = False
        myVTUserControl.Visible = True
    End Sub

End Class
