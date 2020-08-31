<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Score_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Winner_Name_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GameOver = New System.Windows.Forms.PictureBox()
        Me.P2Namelbl = New System.Windows.Forms.Label()
        Me.P1Namelbl = New System.Windows.Forms.Label()
        Me.Finish_btn = New System.Windows.Forms.Button()
        Me.Replay_btn = New System.Windows.Forms.Button()
        Me.RCounterlbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Score_box)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Winner_Name_box)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GameOver)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 399)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Blitz_Game.My.Resources.Stages_Res.gameoverpic
        Me.PictureBox1.Location = New System.Drawing.Point(293, 238)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 73)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Score_box
        '
        Me.Score_box.BackColor = System.Drawing.Color.Black
        Me.Score_box.Enabled = False
        Me.Score_box.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_box.ForeColor = System.Drawing.Color.Red
        Me.Score_box.Location = New System.Drawing.Point(564, 330)
        Me.Score_box.Name = "Score_box"
        Me.Score_box.Size = New System.Drawing.Size(100, 40)
        Me.Score_box.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(28, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 45)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Winner:"
        '
        'Winner_Name_box
        '
        Me.Winner_Name_box.BackColor = System.Drawing.SystemColors.InfoText
        Me.Winner_Name_box.Enabled = False
        Me.Winner_Name_box.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winner_Name_box.ForeColor = System.Drawing.Color.Silver
        Me.Winner_Name_box.Location = New System.Drawing.Point(164, 326)
        Me.Winner_Name_box.Name = "Winner_Name_box"
        Me.Winner_Name_box.Size = New System.Drawing.Size(266, 47)
        Me.Winner_Name_box.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(459, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score:"
        '
        'GameOver
        '
        Me.GameOver.BackgroundImage = Global.Blitz_Game.My.Resources.Stages_Res.blood_PNG6110
        Me.GameOver.Location = New System.Drawing.Point(13, -85)
        Me.GameOver.Name = "GameOver"
        Me.GameOver.Size = New System.Drawing.Size(889, 396)
        Me.GameOver.TabIndex = 0
        Me.GameOver.TabStop = False
        '
        'P2Namelbl
        '
        Me.P2Namelbl.AutoSize = True
        Me.P2Namelbl.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.P2Namelbl.Location = New System.Drawing.Point(553, 489)
        Me.P2Namelbl.Name = "P2Namelbl"
        Me.P2Namelbl.Size = New System.Drawing.Size(58, 13)
        Me.P2Namelbl.TabIndex = 6
        Me.P2Namelbl.Text = "P2Namelbl"
        Me.P2Namelbl.Visible = False
        '
        'P1Namelbl
        '
        Me.P1Namelbl.AutoSize = True
        Me.P1Namelbl.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.P1Namelbl.Location = New System.Drawing.Point(617, 489)
        Me.P1Namelbl.Name = "P1Namelbl"
        Me.P1Namelbl.Size = New System.Drawing.Size(58, 13)
        Me.P1Namelbl.TabIndex = 5
        Me.P1Namelbl.Text = "P1Namelbl"
        Me.P1Namelbl.Visible = False
        '
        'Finish_btn
        '
        Me.Finish_btn.BackColor = System.Drawing.Color.Red
        Me.Finish_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finish_btn.ForeColor = System.Drawing.Color.White
        Me.Finish_btn.Location = New System.Drawing.Point(506, 405)
        Me.Finish_btn.Name = "Finish_btn"
        Me.Finish_btn.Size = New System.Drawing.Size(146, 70)
        Me.Finish_btn.TabIndex = 1
        Me.Finish_btn.Text = "Finish"
        Me.Finish_btn.UseVisualStyleBackColor = False
        '
        'Replay_btn
        '
        Me.Replay_btn.BackColor = System.Drawing.Color.Red
        Me.Replay_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Replay_btn.ForeColor = System.Drawing.Color.White
        Me.Replay_btn.Location = New System.Drawing.Point(163, 405)
        Me.Replay_btn.Name = "Replay_btn"
        Me.Replay_btn.Size = New System.Drawing.Size(166, 70)
        Me.Replay_btn.TabIndex = 7
        Me.Replay_btn.Text = "Replay?"
        Me.Replay_btn.UseVisualStyleBackColor = False
        '
        'RCounterlbl
        '
        Me.RCounterlbl.AutoSize = True
        Me.RCounterlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCounterlbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RCounterlbl.Location = New System.Drawing.Point(222, 477)
        Me.RCounterlbl.Name = "RCounterlbl"
        Me.RCounterlbl.Size = New System.Drawing.Size(39, 29)
        Me.RCounterlbl.TabIndex = 8
        Me.RCounterlbl.Text = "10"
        '
        'EndForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(890, 511)
        Me.Controls.Add(Me.RCounterlbl)
        Me.Controls.Add(Me.Replay_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.P2Namelbl)
        Me.Controls.Add(Me.P1Namelbl)
        Me.Controls.Add(Me.Finish_btn)
        Me.Name = "EndForm"
        Me.Text = "EndForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameOver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameOver As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Finish_btn As Button
    Friend WithEvents Winner_Name_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Score_box As TextBox
    Friend WithEvents P2Namelbl As Label
    Friend WithEvents P1Namelbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Replay_btn As Button
    Friend WithEvents RCounterlbl As Label
End Class
