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
        Me.DTP = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.PanelDash = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.circleProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.labelTurnoutVote = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel6 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel5 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.labelStillNotVote = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDash.SuspendLayout()
        Me.Guna2GradientPanel3.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel4.SuspendLayout()
        Me.circleProgressBar.SuspendLayout()
        Me.Guna2GradientPanel6.SuspendLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel5.SuspendLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DTP
        '
        Me.DTP.BackColor = System.Drawing.Color.Transparent
        Me.DTP.Checked = True
        Me.Guna2Transition1.SetDecoration(Me.DTP, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DTP.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.DTP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.ForeColor = System.Drawing.Color.White
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP.Location = New System.Drawing.Point(739, 0)
        Me.DTP.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(253, 36)
        Me.DTP.TabIndex = 3
        Me.DTP.Value = New Date(2024, 6, 2, 23, 37, 28, 176)
        '
        'PanelDash
        '
        Me.PanelDash.BackColor = System.Drawing.Color.Transparent
        Me.PanelDash.Controls.Add(Me.DTP)
        Me.PanelDash.Controls.Add(Me.Label11)
        Me.PanelDash.Controls.Add(Me.Guna2GradientPanel3)
        Me.PanelDash.Controls.Add(Me.Guna2GradientPanel4)
        Me.PanelDash.Controls.Add(Me.Guna2GradientPanel6)
        Me.PanelDash.Controls.Add(Me.Guna2GradientPanel5)
        Me.PanelDash.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2Transition1.SetDecoration(Me.PanelDash, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelDash.Location = New System.Drawing.Point(115, 47)
        Me.PanelDash.Name = "PanelDash"
        Me.PanelDash.Size = New System.Drawing.Size(1002, 597)
        Me.PanelDash.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(29, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 38)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Dashboard"
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2GradientPanel3.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel3.Controls.Add(Me.Guna2Button2)
        Me.Guna2GradientPanel3.Controls.Add(Me.labelUser)
        Me.Guna2GradientPanel3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientPanel3.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(36, 322)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(287, 180)
        Me.Guna2GradientPanel3.TabIndex = 0
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(31, 69)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(80, 74)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 6
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(75, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Users"
        '
        'Guna2Button2
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(0, 3)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(284, 48)
        Me.Guna2Button2.TabIndex = 5
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.labelUser, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labelUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUser.ForeColor = System.Drawing.Color.White
        Me.labelUser.Location = New System.Drawing.Point(149, 97)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(57, 38)
        Me.labelUser.TabIndex = 4
        Me.labelUser.Text = "10"
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.Controls.Add(Me.circleProgressBar)
        Me.Guna2GradientPanel4.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel4.Controls.Add(Me.Guna2Button3)
        Me.Guna2GradientPanel4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientPanel4.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(376, 102)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(287, 400)
        Me.Guna2GradientPanel4.TabIndex = 0
        '
        'circleProgressBar
        '
        Me.circleProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.circleProgressBar.Controls.Add(Me.labelTurnoutVote)
        Me.Guna2Transition1.SetDecoration(Me.circleProgressBar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.circleProgressBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.circleProgressBar.FillThickness = 15
        Me.circleProgressBar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.circleProgressBar.ForeColor = System.Drawing.Color.White
        Me.circleProgressBar.Location = New System.Drawing.Point(42, 114)
        Me.circleProgressBar.Minimum = 0
        Me.circleProgressBar.Name = "circleProgressBar"
        Me.circleProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.circleProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.circleProgressBar.ProgressThickness = 15
        Me.circleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circleProgressBar.Size = New System.Drawing.Size(197, 197)
        Me.circleProgressBar.TabIndex = 1
        Me.circleProgressBar.Text = "Guna2CircleProgressBar1"
        '
        'labelTurnoutVote
        '
        Me.labelTurnoutVote.AutoSize = True
        Me.labelTurnoutVote.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.labelTurnoutVote, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labelTurnoutVote.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTurnoutVote.ForeColor = System.Drawing.Color.White
        Me.labelTurnoutVote.Location = New System.Drawing.Point(52, 81)
        Me.labelTurnoutVote.Name = "labelTurnoutVote"
        Me.labelTurnoutVote.Size = New System.Drawing.Size(93, 38)
        Me.labelTurnoutVote.TabIndex = 4
        Me.labelTurnoutVote.Text = "11 %"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Turnout Votes"
        '
        'Guna2Button3
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(0, 3)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(284, 48)
        Me.Guna2Button3.TabIndex = 5
        '
        'Guna2GradientPanel6
        '
        Me.Guna2GradientPanel6.Controls.Add(Me.Guna2PictureBox5)
        Me.Guna2GradientPanel6.Controls.Add(Me.Label9)
        Me.Guna2GradientPanel6.Controls.Add(Me.Guna2Button5)
        Me.Guna2GradientPanel6.Controls.Add(Me.Label10)
        Me.Guna2GradientPanel6.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientPanel6.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel6.Location = New System.Drawing.Point(708, 325)
        Me.Guna2GradientPanel6.Name = "Guna2GradientPanel6"
        Me.Guna2GradientPanel6.Size = New System.Drawing.Size(287, 180)
        Me.Guna2GradientPanel6.TabIndex = 0
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox5.Image = CType(resources.GetObject("Guna2PictureBox5.Image"), System.Drawing.Image)
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(54, 66)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(67, 74)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox5.TabIndex = 6
        Me.Guna2PictureBox5.TabStop = False
        Me.Guna2PictureBox5.UseTransparentBackground = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(83, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 23)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Candidates"
        '
        'Guna2Button5
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Location = New System.Drawing.Point(0, 3)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(284, 48)
        Me.Guna2Button5.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(148, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 38)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "28"
        '
        'Guna2GradientPanel5
        '
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2PictureBox4)
        Me.Guna2GradientPanel5.Controls.Add(Me.Label7)
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2Button4)
        Me.Guna2GradientPanel5.Controls.Add(Me.Label8)
        Me.Guna2GradientPanel5.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientPanel5.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel5.Location = New System.Drawing.Point(708, 102)
        Me.Guna2GradientPanel5.Name = "Guna2GradientPanel5"
        Me.Guna2GradientPanel5.Size = New System.Drawing.Size(287, 180)
        Me.Guna2GradientPanel5.TabIndex = 0
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(54, 66)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(67, 74)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox4.TabIndex = 6
        Me.Guna2PictureBox4.TabStop = False
        Me.Guna2PictureBox4.UseTransparentBackground = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(97, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Positions"
        '
        'Guna2Button4
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(0, 3)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(284, 48)
        Me.Guna2Button4.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(158, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 38)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "7"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2GradientPanel2.Controls.Add(Me.labelStillNotVote)
        Me.Guna2GradientPanel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientPanel2.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(36, 102)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(287, 180)
        Me.Guna2GradientPanel2.TabIndex = 0
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(44, 66)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(67, 74)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 6
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Users Not Voted Yet"
        '
        'Guna2Button1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(284, 48)
        Me.Guna2Button1.TabIndex = 5
        '
        'labelStillNotVote
        '
        Me.labelStillNotVote.AutoSize = True
        Me.labelStillNotVote.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.labelStillNotVote, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labelStillNotVote.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStillNotVote.ForeColor = System.Drawing.Color.White
        Me.labelStillNotVote.Location = New System.Drawing.Point(132, 92)
        Me.labelStillNotVote.Name = "labelStillNotVote"
        Me.labelStillNotVote.Size = New System.Drawing.Size(57, 38)
        Me.labelStillNotVote.TabIndex = 4
        Me.labelStillNotVote.Text = "14"
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
        Me.Controls.Add(Me.PanelDash)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDash.ResumeLayout(False)
        Me.PanelDash.PerformLayout()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel4.ResumeLayout(False)
        Me.Guna2GradientPanel4.PerformLayout()
        Me.circleProgressBar.ResumeLayout(False)
        Me.circleProgressBar.PerformLayout()
        Me.Guna2GradientPanel6.ResumeLayout(False)
        Me.Guna2GradientPanel6.PerformLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel5.ResumeLayout(False)
        Me.Guna2GradientPanel5.PerformLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DTP As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents PanelDash As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labelStillNotVote As Label
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labelUser As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents circleProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents labelTurnoutVote As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel5 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2GradientPanel6 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
