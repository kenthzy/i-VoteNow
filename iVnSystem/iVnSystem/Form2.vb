Imports System.Drawing.Drawing2D

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRoundedCorners()
    End Sub
    Private Sub SetRoundedCorners()
        ' Define the size of the rounded corners
        Dim cornerRadius As Integer = 20

        ' Create a new GraphicsPath
        Dim path As New GraphicsPath()

        ' Add rounded rectangle to the path
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(Me.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(Me.Width - cornerRadius, Me.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, Me.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        path.CloseFigure()

        ' Set the form's region to the rounded rectangle
        Me.Region = New Region(path)
    End Sub

    ' Override the OnResize event to maintain rounded corners on resizing
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        SetRoundedCorners()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class