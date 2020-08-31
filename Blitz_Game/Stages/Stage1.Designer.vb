<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stage1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stage1))
        Me.Gravity_Tmr = New System.Windows.Forms.Timer(Me.components)
        Me.Check_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Remain_Tmr = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Portal2B = New System.Windows.Forms.PictureBox()
        Me.Portal2A = New System.Windows.Forms.PictureBox()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.P2Namelbl = New System.Windows.Forms.Label()
        Me.P1Namelbl = New System.Windows.Forms.Label()
        Me.KnifePic2 = New System.Windows.Forms.PictureBox()
        Me.KnifePic1 = New System.Windows.Forms.PictureBox()
        Me.remain_knife_lbl2 = New System.Windows.Forms.Label()
        Me.Knives = New System.Windows.Forms.Label()
        Me.remain_knife_lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HPBar2 = New System.Windows.Forms.ProgressBar()
        Me.HPBar1 = New System.Windows.Forms.ProgressBar()
        Me.Player2_Box = New System.Windows.Forms.PictureBox()
        Me.Wood_ObH_1 = New System.Windows.Forms.PictureBox()
        Me.Ground_Limit_1 = New System.Windows.Forms.PictureBox()
        Me.Player1_Box = New System.Windows.Forms.PictureBox()
        Me.Portal1A = New System.Windows.Forms.PictureBox()
        Me.Portal1B = New System.Windows.Forms.PictureBox()
        Me.Bound_Left = New System.Windows.Forms.PictureBox()
        Me.Bound_Right = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Portal2B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal2A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnifePic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnifePic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wood_ObH_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground_Limit_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal1A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal1B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bound_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bound_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Check_Timer
        '
        Me.Check_Timer.Enabled = True
        Me.Check_Timer.Interval = 1
        '
        'Remain_Tmr
        '
        Me.Remain_Tmr.Enabled = True
        Me.Remain_Tmr.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BackgroundImage = Global.Blitz_Game.My.Resources.Stage1_Res.Stage1_Back
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Portal2B)
        Me.Panel1.Controls.Add(Me.Portal2A)
        Me.Panel1.Controls.Add(Me.TimeLbl)
        Me.Panel1.Controls.Add(Me.P2Namelbl)
        Me.Panel1.Controls.Add(Me.P1Namelbl)
        Me.Panel1.Controls.Add(Me.KnifePic2)
        Me.Panel1.Controls.Add(Me.KnifePic1)
        Me.Panel1.Controls.Add(Me.remain_knife_lbl2)
        Me.Panel1.Controls.Add(Me.Knives)
        Me.Panel1.Controls.Add(Me.remain_knife_lbl1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.HPBar2)
        Me.Panel1.Controls.Add(Me.HPBar1)
        Me.Panel1.Controls.Add(Me.Player2_Box)
        Me.Panel1.Controls.Add(Me.Wood_ObH_1)
        Me.Panel1.Controls.Add(Me.Ground_Limit_1)
        Me.Panel1.Controls.Add(Me.Player1_Box)
        Me.Panel1.Controls.Add(Me.Portal1A)
        Me.Panel1.Controls.Add(Me.Portal1B)
        Me.Panel1.Controls.Add(Me.Bound_Left)
        Me.Panel1.Controls.Add(Me.Bound_Right)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(12, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(1000, 707)
        Me.Panel1.MinimumSize = New System.Drawing.Size(1000, 707)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 707)
        Me.Panel1.TabIndex = 0
        '
        'Portal2B
        '
        Me.Portal2B.BackColor = System.Drawing.Color.Transparent
        Me.Portal2B.Image = Global.Blitz_Game.My.Resources.Stages_Res.PortalB1
        Me.Portal2B.Location = New System.Drawing.Point(502, 521)
        Me.Portal2B.Name = "Portal2B"
        Me.Portal2B.Size = New System.Drawing.Size(77, 105)
        Me.Portal2B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Portal2B.TabIndex = 26
        Me.Portal2B.TabStop = False
        '
        'Portal2A
        '
        Me.Portal2A.BackColor = System.Drawing.Color.Transparent
        Me.Portal2A.Image = Global.Blitz_Game.My.Resources.Stages_Res.PortalA1
        Me.Portal2A.Location = New System.Drawing.Point(552, 116)
        Me.Portal2A.Name = "Portal2A"
        Me.Portal2A.Size = New System.Drawing.Size(77, 104)
        Me.Portal2A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Portal2A.TabIndex = 25
        Me.Portal2A.TabStop = False
        '
        'TimeLbl
        '
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TimeLbl.Location = New System.Drawing.Point(456, 28)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(23, 25)
        Me.TimeLbl.TabIndex = 9
        Me.TimeLbl.Text = "0"
        '
        'P2Namelbl
        '
        Me.P2Namelbl.AutoSize = True
        Me.P2Namelbl.BackColor = System.Drawing.Color.Transparent
        Me.P2Namelbl.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2Namelbl.Location = New System.Drawing.Point(812, 77)
        Me.P2Namelbl.Name = "P2Namelbl"
        Me.P2Namelbl.Size = New System.Drawing.Size(52, 26)
        Me.P2Namelbl.TabIndex = 22
        Me.P2Namelbl.Text = "Label2"
        '
        'P1Namelbl
        '
        Me.P1Namelbl.AutoSize = True
        Me.P1Namelbl.BackColor = System.Drawing.Color.Transparent
        Me.P1Namelbl.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P1Namelbl.Location = New System.Drawing.Point(45, 69)
        Me.P1Namelbl.Name = "P1Namelbl"
        Me.P1Namelbl.Size = New System.Drawing.Size(52, 26)
        Me.P1Namelbl.TabIndex = 21
        Me.P1Namelbl.Text = "Label1"
        '
        'KnifePic2
        '
        Me.KnifePic2.BackColor = System.Drawing.Color.Transparent
        Me.KnifePic2.Location = New System.Drawing.Point(482, 30)
        Me.KnifePic2.Name = "KnifePic2"
        Me.KnifePic2.Size = New System.Drawing.Size(75, 50)
        Me.KnifePic2.TabIndex = 20
        Me.KnifePic2.TabStop = False
        Me.KnifePic2.Visible = False
        '
        'KnifePic1
        '
        Me.KnifePic1.BackColor = System.Drawing.Color.Transparent
        Me.KnifePic1.Location = New System.Drawing.Point(373, 30)
        Me.KnifePic1.Name = "KnifePic1"
        Me.KnifePic1.Size = New System.Drawing.Size(77, 50)
        Me.KnifePic1.TabIndex = 19
        Me.KnifePic1.TabStop = False
        Me.KnifePic1.Visible = False
        '
        'remain_knife_lbl2
        '
        Me.remain_knife_lbl2.AutoSize = True
        Me.remain_knife_lbl2.BackColor = System.Drawing.Color.Transparent
        Me.remain_knife_lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.remain_knife_lbl2.Location = New System.Drawing.Point(628, 57)
        Me.remain_knife_lbl2.Name = "remain_knife_lbl2"
        Me.remain_knife_lbl2.Size = New System.Drawing.Size(23, 25)
        Me.remain_knife_lbl2.TabIndex = 18
        Me.remain_knife_lbl2.Text = "0"
        '
        'Knives
        '
        Me.Knives.AutoSize = True
        Me.Knives.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Knives.Location = New System.Drawing.Point(660, 62)
        Me.Knives.Name = "Knives"
        Me.Knives.Size = New System.Drawing.Size(56, 18)
        Me.Knives.TabIndex = 17
        Me.Knives.Text = ":Knives"
        '
        'remain_knife_lbl1
        '
        Me.remain_knife_lbl1.AutoSize = True
        Me.remain_knife_lbl1.BackColor = System.Drawing.Color.Transparent
        Me.remain_knife_lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.remain_knife_lbl1.Location = New System.Drawing.Point(344, 57)
        Me.remain_knife_lbl1.Name = "remain_knife_lbl1"
        Me.remain_knife_lbl1.Size = New System.Drawing.Size(23, 25)
        Me.remain_knife_lbl1.TabIndex = 16
        Me.remain_knife_lbl1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(282, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Knives:"
        '
        'HPBar2
        '
        Me.HPBar2.Location = New System.Drawing.Point(624, 28)
        Me.HPBar2.Maximum = 250
        Me.HPBar2.Name = "HPBar2"
        Me.HPBar2.Size = New System.Drawing.Size(364, 23)
        Me.HPBar2.TabIndex = 14
        '
        'HPBar1
        '
        Me.HPBar1.Location = New System.Drawing.Point(3, 31)
        Me.HPBar1.Maximum = 200
        Me.HPBar1.Name = "HPBar1"
        Me.HPBar1.Size = New System.Drawing.Size(364, 23)
        Me.HPBar1.TabIndex = 13
        '
        'Player2_Box
        '
        Me.Player2_Box.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Player2_Box.Image = Global.Blitz_Game.My.Resources.Stages_Res.Character2_Standing1
        Me.Player2_Box.Location = New System.Drawing.Point(881, 534)
        Me.Player2_Box.Name = "Player2_Box"
        Me.Player2_Box.Size = New System.Drawing.Size(58, 92)
        Me.Player2_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Player2_Box.TabIndex = 12
        Me.Player2_Box.TabStop = False
        '
        'Wood_ObH_1
        '
        Me.Wood_ObH_1.BackColor = System.Drawing.Color.Transparent
        Me.Wood_ObH_1.BackgroundImage = Global.Blitz_Game.My.Resources.Stage1_Res.wood1_h
        Me.Wood_ObH_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Wood_ObH_1.Location = New System.Drawing.Point(3, 337)
        Me.Wood_ObH_1.Name = "Wood_ObH_1"
        Me.Wood_ObH_1.Size = New System.Drawing.Size(985, 22)
        Me.Wood_ObH_1.TabIndex = 3
        Me.Wood_ObH_1.TabStop = False
        '
        'Ground_Limit_1
        '
        Me.Ground_Limit_1.BackColor = System.Drawing.Color.Transparent
        Me.Ground_Limit_1.Location = New System.Drawing.Point(3, 632)
        Me.Ground_Limit_1.Name = "Ground_Limit_1"
        Me.Ground_Limit_1.Size = New System.Drawing.Size(1948, 10)
        Me.Ground_Limit_1.TabIndex = 1
        Me.Ground_Limit_1.TabStop = False
        '
        'Player1_Box
        '
        Me.Player1_Box.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Player1_Box.Image = CType(resources.GetObject("Player1_Box.Image"), System.Drawing.Image)
        Me.Player1_Box.Location = New System.Drawing.Point(151, 553)
        Me.Player1_Box.Name = "Player1_Box"
        Me.Player1_Box.Size = New System.Drawing.Size(76, 73)
        Me.Player1_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Player1_Box.TabIndex = 8
        Me.Player1_Box.TabStop = False
        '
        'Portal1A
        '
        Me.Portal1A.BackColor = System.Drawing.Color.Transparent
        Me.Portal1A.Image = Global.Blitz_Game.My.Resources.Stages_Res.PortalA1
        Me.Portal1A.Location = New System.Drawing.Point(339, 383)
        Me.Portal1A.Name = "Portal1A"
        Me.Portal1A.Size = New System.Drawing.Size(77, 109)
        Me.Portal1A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Portal1A.TabIndex = 10
        Me.Portal1A.TabStop = False
        '
        'Portal1B
        '
        Me.Portal1B.BackColor = System.Drawing.Color.Transparent
        Me.Portal1B.Image = Global.Blitz_Game.My.Resources.Stages_Res.PortalB1
        Me.Portal1B.Location = New System.Drawing.Point(150, 219)
        Me.Portal1B.Name = "Portal1B"
        Me.Portal1B.Size = New System.Drawing.Size(77, 112)
        Me.Portal1B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Portal1B.TabIndex = 11
        Me.Portal1B.TabStop = False
        '
        'Bound_Left
        '
        Me.Bound_Left.BackColor = System.Drawing.Color.Transparent
        Me.Bound_Left.Location = New System.Drawing.Point(3, 0)
        Me.Bound_Left.Name = "Bound_Left"
        Me.Bound_Left.Size = New System.Drawing.Size(10, 642)
        Me.Bound_Left.TabIndex = 24
        Me.Bound_Left.TabStop = False
        '
        'Bound_Right
        '
        Me.Bound_Right.BackColor = System.Drawing.Color.Transparent
        Me.Bound_Right.Location = New System.Drawing.Point(967, 3)
        Me.Bound_Right.Name = "Bound_Right"
        Me.Bound_Right.Size = New System.Drawing.Size(10, 642)
        Me.Bound_Right.TabIndex = 23
        Me.Bound_Right.TabStop = False
        '
        'Stage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1008, 694)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximumSize = New System.Drawing.Size(1024, 766)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "Stage1"
        Me.Text = "Blitz - Stage 1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Portal2B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal2A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnifePic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnifePic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wood_ObH_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground_Limit_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal1A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal1B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bound_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bound_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ground_Limit_1 As PictureBox
    Friend WithEvents Wood_ObH_1 As PictureBox
    Friend WithEvents Player1_Box As PictureBox
    Friend WithEvents TimeLbl As Label
    Friend WithEvents Gravity_Tmr As Timer
    Friend WithEvents Portal1B As PictureBox
    Friend WithEvents Portal1A As PictureBox
    Friend WithEvents Player2_Box As PictureBox
    Friend WithEvents Check_Timer As Timer
    Friend WithEvents HPBar2 As ProgressBar
    Friend WithEvents HPBar1 As ProgressBar
    Friend WithEvents remain_knife_lbl2 As Label
    Friend WithEvents Knives As Label
    Friend WithEvents remain_knife_lbl1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KnifePic2 As PictureBox
    Friend WithEvents KnifePic1 As PictureBox
    Friend WithEvents P2Namelbl As Label
    Friend WithEvents P1Namelbl As Label
    Friend WithEvents Bound_Right As PictureBox
    Friend WithEvents Bound_Left As PictureBox
    Friend WithEvents Remain_Tmr As Timer
    Friend WithEvents Portal2B As PictureBox
    Friend WithEvents Portal2A As PictureBox
End Class
