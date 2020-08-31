<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.New_game_btn = New System.Windows.Forms.Button()
        Me.Score_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Help_btn = New System.Windows.Forms.Button()
        Me.Blitz_logo1 = New System.Windows.Forms.PictureBox()
        Me.Menu_btns_Panel1 = New System.Windows.Forms.Panel()
        Me.Tmr_C_Name1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tmr_C_Name2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Blitz_logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_btns_Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'New_game_btn
        '
        Me.New_game_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.New_game_btn.BackColor = System.Drawing.Color.Transparent
        Me.New_game_btn.BackgroundImage = Global.Blitz_Game.My.Resources.Menu_Resources.Btn_img_blue1
        resources.ApplyResources(Me.New_game_btn, "New_game_btn")
        Me.New_game_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.New_game_btn.FlatAppearance.BorderSize = 0
        Me.New_game_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.New_game_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.New_game_btn.Name = "New_game_btn"
        Me.New_game_btn.UseVisualStyleBackColor = False
        '
        'Score_btn
        '
        Me.Score_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.Score_btn.BackColor = System.Drawing.Color.Transparent
        Me.Score_btn.BackgroundImage = Global.Blitz_Game.My.Resources.Menu_Resources.Btn_img_blue1
        resources.ApplyResources(Me.Score_btn, "Score_btn")
        Me.Score_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Score_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Score_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Score_btn.Name = "Score_btn"
        Me.Score_btn.UseVisualStyleBackColor = False
        '
        'Exit_btn
        '
        Me.Exit_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.Exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.Exit_btn.BackgroundImage = Global.Blitz_Game.My.Resources.Menu_Resources.Btn_img_blue1
        resources.ApplyResources(Me.Exit_btn, "Exit_btn")
        Me.Exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'Help_btn
        '
        Me.Help_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.Help_btn.BackColor = System.Drawing.Color.Transparent
        Me.Help_btn.BackgroundImage = Global.Blitz_Game.My.Resources.Menu_Resources.Btn_img_blue1
        resources.ApplyResources(Me.Help_btn, "Help_btn")
        Me.Help_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Help_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Help_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Help_btn.Name = "Help_btn"
        Me.Help_btn.UseVisualStyleBackColor = False
        '
        'Blitz_logo1
        '
        Me.Blitz_logo1.BackColor = System.Drawing.Color.Transparent
        Me.Blitz_logo1.BackgroundImage = Global.Blitz_Game.My.Resources.Menu_Resources.Blitz_Logo
        resources.ApplyResources(Me.Blitz_logo1, "Blitz_logo1")
        Me.Blitz_logo1.Name = "Blitz_logo1"
        Me.Blitz_logo1.TabStop = False
        '
        'Menu_btns_Panel1
        '
        Me.Menu_btns_Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Menu_btns_Panel1.Controls.Add(Me.New_game_btn)
        Me.Menu_btns_Panel1.Controls.Add(Me.Blitz_logo1)
        Me.Menu_btns_Panel1.Controls.Add(Me.Score_btn)
        Me.Menu_btns_Panel1.Controls.Add(Me.Exit_btn)
        Me.Menu_btns_Panel1.Controls.Add(Me.Help_btn)
        resources.ApplyResources(Me.Menu_btns_Panel1, "Menu_btns_Panel1")
        Me.Menu_btns_Panel1.Name = "Menu_btns_Panel1"
        '
        'Tmr_C_Name1
        '
        '
        'Tmr_C_Name2
        '
        '
        'Main_Menu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blitz_Game.My.Resources.Menu_Resources.Forest_img_menu1
        Me.Controls.Add(Me.Menu_btns_Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Main_Menu"
        CType(Me.Blitz_logo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_btns_Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents New_game_btn As Button
    Friend WithEvents Score_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Help_btn As Button
    Friend WithEvents Blitz_logo1 As PictureBox
    Friend WithEvents Menu_btns_Panel1 As Panel
    Friend WithEvents Tmr_C_Name1 As Timer
    Friend WithEvents Tmr_C_Name2 As Timer
End Class
