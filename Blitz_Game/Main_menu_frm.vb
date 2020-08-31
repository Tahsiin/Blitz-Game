Public Class Main_Menu
    Inherits System.Windows.Forms.Form


    Dim P1Name, P2Name As String



    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                    ControlStyles.UserPaint Or
                    ControlStyles.DoubleBuffer,
                    True
                    )
        Me.UpdateStyles()


    End Sub
    '------------------------When Mouse is over BUTTONS in Menu
    Private Sub Start_btn_MouseHover(sender As Object, e As EventArgs) Handles New_game_btn.MouseHover, Score_btn.MouseHover, Help_btn.MouseHover, Exit_btn.MouseHover
        Dim btn As Button = CType(sender, Button)
        btn.BackgroundImage = My.Resources.Menu_Resources.Btn_img_red1
        Me.Cursor = Cursors.Hand

    End Sub
    '------------------------When Mouse leaves BUTTONS in the Menu
    Private Sub Start_btn_MouseLeave(sender As Object, e As EventArgs) Handles New_game_btn.MouseLeave, Score_btn.MouseLeave, Help_btn.MouseLeave, Exit_btn.MouseLeave
        Dim btn1 As Button = CType(sender, Button)
        btn1.BackgroundImage = My.Resources.Menu_Resources.Btn_img_blue1
        Me.Cursor = Cursors.Arrow

    End Sub
    '-------------------------When we click on the NEW GAME button
    Private Sub New_game_btn_Click(sender As Object, e As EventArgs) Handles New_game_btn.Click

        Menu_btns_Panel1.Enabled = False
        Menu_btns_Panel1.Visible = False
        Set_N_Game()            'call fn
    End Sub


    'Creating new Controls in the Character Creation 
    Dim New_Game_Panel1 As New Panel()
    Dim Ques_char_name As New Label()
    Dim Ques_char_name2 As New Label()


    Dim Key_Type_Tmr1 As New Timer()
    Dim Str_chars() As Char                                '<----Array cntaining the ques_String
    Dim Str_chars2() As Char
    Friend WithEvents Char_Name_box As New TextBox()                     'TextBox to enter char name

    Friend WithEvents Char_Name2_box As New TextBox()


    Private Sub Set_N_Game()


        With New_Game_Panel1
            .Location = New Point(0, 0)
            .Width = 800
            .Height = 600
            .BackColor = Color.Black
        End With
        Me.Controls.Add(New_Game_Panel1)            'Adding Panel to form

        Cursor.Hide()

        Dim Mid_Panel As New Point()
        Mid_Panel.X = 0
        Mid_Panel.Y = New_Game_Panel1.Height / 4

        'Setting of Label for char_name ques
        With Ques_char_name
            .Location = Mid_Panel
            .Text = ""
            .ForeColor = Color.Green
            .Font = New Font("Arial", 25, FontStyle.Bold)
            .Width = 800
            .Height = 130
            .BackColor = Color.Transparent
            .BorderStyle = BorderStyle.None
        End With
        New_Game_Panel1.Controls.Add(Ques_char_name)        'Add Label to Panel

        '-----converting the Str to a char array
        Dim Str_ques As String = "PC>Welcome to Blitz. PC>Enter your Character's name:Player1>"
        Str_chars = Str_ques.ToCharArray

        Me.Text = "Blitz-Console"   'Changing the title of the Menu


        'Playing the keyboard sound
        Try
            My.Computer.Audio.Play(My.Resources.Menu_Resources.Key_Type_sound, AudioPlayMode.BackgroundLoop)

        Catch ex As Exception
            MsgBox("Sound not found")
        End Try

        Tmr_C_Name1.Enabled = True


    End Sub

    'Setting EXIT Button
    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Dim close_result As DialogResult = MessageBox.Show("Are you sure to stop the game?", "Exit", MessageBoxButtons.YesNo)
        If close_result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Dim arr_str_count As Integer = 0
    Private Sub Tmr_C_Name1_Tick(sender As Object, e As EventArgs) Handles Tmr_C_Name1.Tick
        If arr_str_count < Str_chars.Length Then
            Ques_char_name.Text += Str_chars(arr_str_count)
        Else
            My.Computer.Audio.Stop()
            Enter_Char_Details()    'Calling function to enter character details
            arr_str_count = 0
            Tmr_C_Name1.Enabled = False
        End If

        '-------------Putting Newline...Note: Change Value in Condition According to Str
        If arr_str_count = 20 Or arr_str_count = 51 Then
            Ques_char_name.Text += vbCrLf
        End If

        arr_str_count += 1
    End Sub


    Dim Focus_C_Box As Boolean = False
    Dim user_sound_type As Boolean = False
    Private Sub Enter_Char_Details()    'Enter the Character Name


        '----Setting the TxtBox containing Character Name
        With Char_Name_box
            .Name = "Char_Name_box"
            .Text = ""
            .Location = New Point(150, 230)
            .Font = Ques_char_name.Font
            .ForeColor = Color.Green
            .Width = 600
            .Height = 160
            .BackColor = Color.Black
            .BorderStyle = BorderStyle.None
        End With

        user_sound_type = True          '----allow the event Sound_KeyDown to trigger
        New_Game_Panel1.Controls.Add(Char_Name_box)

        Char_Name_box.BringToFront()
        Char_Name_box.Focus()


    End Sub
    '--------------------------------Event to output Sound each time a key is pressed
    Private Sub Sound_KeyDown(sender As Object, e As EventArgs) Handles Char_Name_box.TextChanged
        If user_sound_type = True Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.Menu_Resources.Typing_1Key_sound, playMode:=AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Char_Name_box_Enter(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Char_Name_box.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Check_Name()
        End If



    End Sub
    Private Sub Check_Name()
        If Len(Char_Name_box.Text) <> 0 Then

            P1Name = Char_Name_box.Text

            Enter_Char2_Details()        '---Call Clear_controls in panel1
        End If
    End Sub


    Private Sub Enter_Char2_Details()

        With Char_Name2_box
            .Name = "Char_Name2_box"
            .Text = ""
            .Location = New Point(150, 275)
            .Font = Ques_char_name.Font
            .ForeColor = Color.Green
            .BackColor = Color.White
            .Width = 600
            .Height = 160
            .BackColor = Color.Black
            .BorderStyle = BorderStyle.None
        End With

        New_Game_Panel1.Controls.Add(Char_Name2_box)

        Char_Name2_box.BringToFront()

        With Ques_char_name2
            .Location = New Point(0, 275)
            .Text = ""
            .ForeColor = Color.Green
            .Font = New Font("Arial", 25, FontStyle.Bold)
            .Width = 800
            .Height = 130
            .BackColor = Color.Transparent
            .BorderStyle = BorderStyle.None
        End With
        New_Game_Panel1.Controls.Add(Ques_char_name2)        'Add Label to Panel


        'Configuring the animation for 2nd textbox and label

        Dim Str_ques2 As String = " Player2<"
        Str_chars2 = Str_ques2.ToCharArray

        'Playing the keyboard sound
        Try
            My.Computer.Audio.Play(My.Resources.Menu_Resources.Key_Type_sound, AudioPlayMode.BackgroundLoop)

        Catch ex As Exception
            MsgBox("Sound not found")
        End Try

        Tmr_C_Name2.Enabled = True


    End Sub

    Dim New_Game_Panel2 As New Panel()

    '------Setting the 2nd panel and clearing the first one
    Private Sub Clear_cntrl_Panel1()


        Me.Controls.Add(New_Game_Panel2)
        New_Game_Panel1.Dispose()
        With New_Game_Panel2
            .Location = New Point(0, 0)
            .Width = 800
            .Height = 600
        End With

    End Sub

    Private Sub Tmr_C_Name2_Tick(sender As Object, e As EventArgs) Handles Tmr_C_Name2.Tick
        If arr_str_count < Str_chars2.Length Then
            Ques_char_name2.Text += Str_chars2(arr_str_count)
        Else
            My.Computer.Audio.Stop()
            Char_Name2_box.Focus()

            Tmr_C_Name2.Enabled = False

            Confirm_Char_Details2()    'Calling function to enter character details

        End If
        arr_str_count += 1
    End Sub

    Private Sub Confirm_Char_Details2()
        If Len(Char_Name2_box.Text) <> 0 Then

            P2Name = Char_Name2_box.Text
            start_Game()
            'Call fn to OPEN STAGE

        End If


    End Sub

    Public Sub start_Game()
        Dim myStage As New Stage1()
        myStage.Show()
        myStage.P1Namelbl.Text = P1Name
        myStage.P2Namelbl.Text = P2Name
        Me.Hide()
        Me.Close()

    End Sub

    Private Sub Load_btn_Click(sender As Object, e As EventArgs) Handles Score_btn.Click

        Dim display_scoreform As New DisplayScore()
        display_scoreform.Show()


    End Sub

    Private Sub Help_btn_Click(sender As Object, e As EventArgs) Handles Help_btn.Click
        Dim howtoplay As New HowToPlay()
        howtoplay.Show()
    End Sub

    Private Sub Char_Name2_box_Enter(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Char_Name2_box.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Confirm_Char_Details2()
        End If



    End Sub
End Class
