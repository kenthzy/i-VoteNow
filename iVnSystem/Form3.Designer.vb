<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnOut = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnVoters = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnCandidates = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.btnShow = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnHide = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Panel1.Controls.Add(Me.btnOut)
        Me.Panel1.Controls.Add(Me.btnVoters)
        Me.Panel1.Controls.Add(Me.btnCandidates)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 672)
        Me.Panel1.TabIndex = 0
        '
        'Guna2Separator1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.FillColor = System.Drawing.Color.White
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 558)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(178, 20)
        Me.Guna2Separator1.TabIndex = 2
        '
        'btnOut
        '
        Me.btnOut.BackColor = System.Drawing.Color.Transparent
        Me.btnOut.CustomImages.Image = Global.iVnSystem.My.Resources.Resources.sign_out_left_2_svgrepo_com
        Me.btnOut.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Transition1.SetDecoration(Me.btnOut, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOut.FillColor = System.Drawing.Color.Transparent
        Me.btnOut.FillColor2 = System.Drawing.Color.Transparent
        Me.btnOut.FocusedColor = System.Drawing.Color.Transparent
        Me.btnOut.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOut.ForeColor = System.Drawing.Color.White
        Me.btnOut.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOut.Location = New System.Drawing.Point(3, 593)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(205, 51)
        Me.btnOut.TabIndex = 2
        Me.btnOut.Text = "Sign Out"
        '
        'btnVoters
        '
        Me.btnVoters.BackColor = System.Drawing.Color.Transparent
        Me.btnVoters.CustomImages.Image = Global.iVnSystem.My.Resources.Resources.vote_2_svgrepo_com
        Me.btnVoters.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Transition1.SetDecoration(Me.btnVoters, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnVoters.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVoters.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVoters.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVoters.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVoters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVoters.FillColor = System.Drawing.Color.Transparent
        Me.btnVoters.FillColor2 = System.Drawing.Color.Transparent
        Me.btnVoters.FocusedColor = System.Drawing.Color.Transparent
        Me.btnVoters.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoters.ForeColor = System.Drawing.Color.White
        Me.btnVoters.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVoters.Location = New System.Drawing.Point(0, 263)
        Me.btnVoters.Name = "btnVoters"
        Me.btnVoters.Size = New System.Drawing.Size(202, 51)
        Me.btnVoters.TabIndex = 2
        Me.btnVoters.Text = "Voters"
        Me.btnVoters.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnVoters.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnCandidates
        '
        Me.btnCandidates.BackColor = System.Drawing.Color.Transparent
        Me.btnCandidates.CustomImages.Image = Global.iVnSystem.My.Resources.Resources.users_svgrepo_com
        Me.btnCandidates.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Transition1.SetDecoration(Me.btnCandidates, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnCandidates.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCandidates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCandidates.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCandidates.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCandidates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCandidates.FillColor = System.Drawing.Color.Transparent
        Me.btnCandidates.FillColor2 = System.Drawing.Color.Transparent
        Me.btnCandidates.FocusedColor = System.Drawing.Color.Transparent
        Me.btnCandidates.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCandidates.ForeColor = System.Drawing.Color.White
        Me.btnCandidates.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCandidates.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCandidates.Location = New System.Drawing.Point(0, 212)
        Me.btnCandidates.Name = "btnCandidates"
        Me.btnCandidates.Size = New System.Drawing.Size(202, 51)
        Me.btnCandidates.TabIndex = 2
        Me.btnCandidates.Text = "Candidates"
        Me.btnCandidates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCandidates.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.CustomImages.Image = Global.iVnSystem.My.Resources.Resources.rate_svgrepo_com
        Me.btnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Transition1.SetDecoration(Me.btnDashboard, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FillColor2 = System.Drawing.Color.Transparent
        Me.btnDashboard.FocusedColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(0, 161)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(202, 51)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.TextOffset = New System.Drawing.Point(40, 0)
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.iVnSystem.My.Resources.Resources.ivnLogo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(48, 34)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(80, 76)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1182, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'btnShow
        '
        Me.btnShow.Animated = True
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Transition1.SetDecoration(Me.btnShow, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnShow.FillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.Location = New System.Drawing.Point(29, 547)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnShow.Size = New System.Drawing.Size(40, 40)
        Me.btnShow.TabIndex = 2
        Me.btnShow.UseTransparentBackground = True
        Me.btnShow.Visible = False
        '
        'btnHide
        '
        Me.btnHide.Animated = True
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Transition1.SetDecoration(Me.btnHide, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHide.FillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Image = CType(resources.GetObject("btnHide.Image"), System.Drawing.Image)
        Me.btnHide.Location = New System.Drawing.Point(179, 547)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnHide.Size = New System.Drawing.Size(40, 40)
        Me.btnHide.TabIndex = 2
        Me.btnHide.UseTransparentBackground = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1227, 672)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVoters As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnCandidates As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnOut As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnHide As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
End Class
