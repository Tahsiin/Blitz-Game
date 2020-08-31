Public Class Stage1

    'Player MOVEMENT_______________________________________________________________________________________
    Dim P_Left_Mode As Boolean                  'P1 VARS
    Dim P_Right_Mode As Boolean
    Dim Up_Mode As Boolean
    Dim Down_Mode As Boolean

    Dim P2_Left_Mode As Boolean                 'P2 VARS
    Dim P2_Right_Mode As Boolean
    Dim Up_Mode2 As Boolean
    Dim Down_Mode2 As Boolean


    Dim P_Can_Mov_R As Boolean = True           'P1 VARS
    Dim P_Can_Mov_L As Boolean = True
    Dim P_Can_Mov_Down As Boolean = False
    Dim P_Can_Jump As Boolean = True
    Dim Standing As Boolean = True
    Dim Jump_Count As Byte = 0
    Dim Jump_x, Jump_y, Jump_limit_x, Jump_limit_y As Integer
    Dim Jump_x_temp, Jump_y_temp As Integer

    Dim P2_Can_Mov_R As Boolean = True          'P2 VARS
    Dim P2_Can_Mov_L As Boolean = True
    Dim P2_Can_Mov_Down As Boolean = False
    Dim P2_Can_Jump As Boolean = True
    Dim Standing2 As Boolean = True
    Dim Jump_Count2 As Byte = 0
    Dim Jump_x2, Jump_y2, Jump_limit_x2, Jump_limit_y2 As Integer
    Dim Jump_x_temp2, Jump_y_temp2 As Integer


    '----------------------------VAR FOR TIMER REMAINING
    Dim Tmr_count As Integer = 200



    Dim Count_Move As Integer = 0
    Dim Count_Img As Integer = 0

    Dim Count_Move2 As Integer = 0
    Dim Count_Img2 As Integer = 0

    'Setting Timers for MOVEMENT
    Friend WithEvents P_Tmr_Right, P_Tmr_Left, P_Tmr_UP, P_Tmr_Down, P_Tmr_Jump, Tmr_Check As New Timer()
    Friend WithEvents P2_Tmr_Right, P2_Tmr_Left, P2_Tmr_Down, P2_Tmr_Jump, KnifeTmrP1, KnifeTmrP2 As New Timer()
    Friend WithEvents Tmr_Portals As New Timer()
    Dim final_score As Integer = 0


    '--------------NOT change!!!!
    Dim Count As Integer = 0


    'Setting OBSTACLES

    Dim Obstacle(2) As PictureBox


    Dim P1 As New Player()
    Dim P2 As New Player()



    '----------------CREATING KNIFE BOX

    Public Sub Stage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        'Me.UpdateStyles()

        'Setting the 2 classes (characters)

        P1.Max_Life_Point = 200
        P1.Life_Point = 200
        P1.Attack_Point = 15
        P1.Knife_remainder = 30

        P2.Max_Life_Point = 250
        P2.Life_Point = 250
        P2.Attack_Point = CInt(Int((30 * Rnd()) + 1))  'Attack point from 1 to 30
        P2.Knife_remainder = 30

        'Setting The Woods________________________
        Obstacle(0) = Wood_ObH_1
        Obstacle(1) = Ground_Limit_1


        'Setting KNIVES
        With KnifePic1
            .Image = My.Resources.Stages_Res.knife_pic
        End With

        With KnifePic2
            .Image = My.Resources.Stages_Res.knife_pic
        End With

        '______________________________________________________________________________________

        'Disabling Autoscroll
        Panel1.AutoScroll = False
        Me.AutoScroll = False


        P_Right_Mode = True
        P2_Right_Mode = False

        P_Left_Mode = False
        P2_Left_Mode = True

        Player1_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

        'Setting Jump variables____________________________________
        Jump_x = 5
        Jump_x2 = 5
        Jump_y = 15
        Jump_y2 = 15
        Jump_limit_x = 30



        'Setting Timers Intervals____________________________________
        P_Tmr_Right.Interval = 18
        P_Tmr_Left.Interval = 18
        P_Tmr_UP.Interval = 16
        P_Tmr_Down.Interval = 16

        P2_Tmr_Right.Interval = 18
        P2_Tmr_Left.Interval = 18
        P2_Tmr_Down.Interval = 20

        Tmr_Check.Interval = 5
        Tmr_Check.Enabled = True


        'SETTING INTERVALS FOR KNIFE TIMERS
        KnifeTmrP1.Interval = 5
        KnifeTmrP2.Interval = 5



        'Setting remaining time label
        TimeLbl.Text = CStr(Tmr_count)


        'Setting interval for PORTAL TIMER
        Tmr_Portals.Interval = 400
        Tmr_Portals.Enabled = True


    End Sub


    Private Sub P2_Tmr_Right_Tick(sender As Object, e As EventArgs) Handles P2_Tmr_Right.Tick
        If P2_Can_Mov_R Then


            P2_Tmr_Left.Enabled = False
            P2_Right_Mode = True
            P2_Left_Mode = False

            If Count_Move2 = 0 Then
                Select Case Count_Img2
                    Case 0
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run1
                    Case 1
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run2
                    Case 2
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run3
                    Case 3
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run4

                        Count_Img2 = 2
                End Select
                Player2_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                Count_Img2 += 1

            End If
            If Count_Move2 < 2 Then
                Count_Move2 += 1
            Else
                Count_Move2 = 0
            End If

            Player2_Box.Left += 4
        Else
            P2_Tmr_Right.Enabled = False
        End If
    End Sub
    Private Sub P_Tmr_Right_Tick(sender As Object, e As EventArgs) Handles P_Tmr_Right.Tick  'PLAYER MOVES RIGHT
        If P_Can_Mov_R Then


            P_Tmr_Left.Enabled = False
            P_Right_Mode = True
            P_Left_Mode = False

            If Count_Move = 0 Then
                Select Case Count_Img
                    Case 0
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_1L
                    Case 1
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_2L
                    Case 2
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_3L
                    Case 3
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_4L
                    Case 4
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_5L
                    Case 5
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_6L
                        Count_Img = 0
                End Select
                Player1_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                Count_Img += 1

            End If
            If Count_Move < 2 Then
                Count_Move += 1
            Else
                Count_Move = 0
            End If

            Player1_Box.Left += 4
        Else
            P_Tmr_Right.Enabled = False
        End If

    End Sub


    Private Sub P_Tmr_Left_Tick(sender As Object, e As EventArgs) Handles P_Tmr_Left.Tick  'PLAYER MOVES LEFT

        If P_Can_Mov_L Then         'Check if Player can move left
            P_Can_Mov_Down = False
            Standing = True


            P_Tmr_Right.Enabled = False
            P_Left_Mode = True
            P_Right_Mode = False



            If Count_Move = 0 Then
                Select Case Count_Img
                    Case 0
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_1L
                    Case 1
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_2L
                    Case 2
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_3L
                    Case 3
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_4L
                    Case 4
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_5L
                    Case 5
                        Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_6L
                        Count_Img = 0
                End Select

                Count_Img += 1

            End If
            If Count_Move < 2 Then
                Count_Move += 1
            Else
                Count_Move = 0
            End If

            Player1_Box.Left -= 4
        Else
            P_Tmr_Left.Enabled = False
        End If



    End Sub




    Private Sub P2_Tmr_Left_Tick(sender As Object, e As EventArgs) Handles P2_Tmr_Left.Tick  'PLAYER MOVES LEFT

        If P2_Can_Mov_L Then         'Check if Player can move left
            P2_Can_Mov_Down = False
            Standing2 = True


            P2_Tmr_Right.Enabled = False
            P2_Left_Mode = True
            P2_Right_Mode = False



            If Count_Move2 = 0 Then
                Select Case Count_Img2
                    Case 0
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run1
                    Case 1
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run2
                    Case 2
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run3
                    Case 3
                        Player2_Box.Image = My.Resources.Stages_Res.Character2_Run4

                        Count_Img2 = 2
                End Select

                Count_Img2 += 1

            End If
            If Count_Move2 < 2 Then
                Count_Move2 += 1
            Else
                Count_Move2 = 0
            End If

            Player2_Box.Left -= 4
        Else
            P2_Tmr_Left.Enabled = False
        End If



    End Sub


    Private Sub P_Tmr_UP_Tick(sender As Object, e As EventArgs) Handles P_Tmr_UP.Tick 'PLAYER JUMPS_____________________________
        If P_Can_Jump Then
            Standing = False

            'Using temporary variables for jump coords
            Dim new_loc_up As New Point
            new_loc_up.Y = Player1_Box.Location.Y - Jump_y_temp
            If P_Left_Mode Then
                new_loc_up.X = Player1_Box.Location.X - Jump_x_temp
                P_Can_Mov_R = False          'TO RECHECK
                P_Can_Mov_L = True
            End If
            If P_Right_Mode Then
                P_Can_Mov_R = True          'TO RECHECK
                P_Can_Mov_L = False

                new_loc_up.X = Player1_Box.Location.X + Jump_x_temp
                new_loc_up.Y = Player1_Box.Location.Y - Jump_y_temp


            End If
            P_Can_Mov_L = False
            P_Can_Mov_R = False

            Select Case Jump_Count
                Case 1
                    Player1_Box.Image = My.Resources.Stages_Res.CharacA_BefUp1L
                    Player1_Box.Location = new_loc_up


                Case 2
                    Player1_Box.Image = My.Resources.Stages_Res.CharacA_BefUp2L
                    Player1_Box.Location = new_loc_up

                Case 3
                    Player1_Box.Image = My.Resources.Stages_Res.CharacA_BefUp3L
                    Player1_Box.Location = new_loc_up

                Case 4
                    Player1_Box.Image = My.Resources.Stages_Res.CharacA_BefUp4L
                    Player1_Box.Location = new_loc_up

                Case 5
                    Player1_Box.Image = My.Resources.Stages_Res.CharacA_BefUp5L
                    Player1_Box.Location = new_loc_up
                Case 6
                    Player1_Box.Image = My.Resources.Stages_Res.CharacA_Run_1L
                    Player1_Box.Location = new_loc_up

                    Jump_Count = 5
            End Select
            If P_Right_Mode Then
                Player1_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            ' If Jump_y_temp > 5 Then
            'Jump_x_temp += 1
            'End If

            Jump_y_temp -= 1
            Jump_Count += 1

            Dim Count_Check1 As Integer = 0
            Dim Obst_Check_Done As Boolean = False

            While Count_Check1 < Obstacle.Length - 1 And Not Obst_Check_Done

                If Obstacle(Count_Check1).Bounds.IntersectsWith(Player1_Box.Bounds) Then
                    Dim obj_coords As New Point
                    obj_coords.Y = Obstacle(Count_Check1).Location.Y   'y-coord of the object
                    obj_coords.X = Obstacle(Count_Check1).Location.X   'x-coord of the object


                    'Check if Player is below
                    If CInt(Player1_Box.Location.Y) > CInt(Obstacle(Count_Check1).Location.Y) Then
                        Player1_Box.Location = New Point(Player1_Box.Location.X, Obstacle(Count_Check1).Location.Y + Obstacle(Count_Check1).Height)
                        P_Tmr_UP.Enabled = False
                        P_Tmr_Down.Enabled = True
                        P_Can_Mov_Down = True
                        P_Can_Mov_L = False
                        P_Can_Mov_R = False


                        'Check if Player is above

                    ElseIf CInt(Player1_Box.Location.Y + Player1_Box.Height) > CInt(Obstacle(Count_Check1).Location.Y) Then
                        Player1_Box.Location = New Point(Player1_Box.Location.X, Obstacle(Count_Check1).Location.Y - Player1_Box.Height)

                    End If


                    Dim P_bottomL_coords As New Point
                    P_bottomL_coords.Y = P_bottomL_coords.Y + Player1_Box.Height
                    P_bottomL_coords.X = Player1_Box.Location.X

                    Obst_Check_Done = True
                    P_Can_Mov_L = True
                    P_Can_Mov_R = True

                    Obst_Check_Done = True
                    Standing = True
                    P_Tmr_UP.Enabled = False
                    Check_Player_Left_Right()

                Else
                    If Count_Check1 = (Obstacle.Length - 1) Then
                        Obst_Check_Done = True
                    End If
                End If

                Count_Check1 += 1
            End While


        End If
    End Sub





    Private Sub Remain_Tmr_Tick(sender As Object, e As EventArgs) Handles Remain_Tmr.Tick
        If Tmr_count > 0 Then
            Tmr_count -= 1
            TimeLbl.Text = CInt(Tmr_count)
        Else
            If P1.Life_Point < P2.Life_Point Then
                EndGame(P1.Player_Name)
            ElseIf P2.Life_Point < P1.Life_Point Then
                EndGame(P2.Player_Name)
            Else
                EndGame("DRAW")

            End If

        End If
    End Sub



    Private Sub Start_Jumping()
        P_Tmr_UP.Enabled = True
        P_Can_Mov_L = False
        P_Can_Mov_R = False
        P_Tmr_Left.Enabled = False
        P_Tmr_Right.Enabled = False
        Standing = False


        'Temporary Vars used for X and Y coordinates in JUMP
        Jump_x_temp = Jump_x
        Jump_y_temp = Jump_y


    End Sub

    Private Sub Check_Timer_Tick(sender As Object, e As EventArgs) Handles Check_Timer.Tick

    End Sub

    Private Sub Stage1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Checking If Obstacle is at The RIGHT of the Player
        Dim Count_Check1 As Integer = 0
        Dim Obst_Check_Done As Boolean = False

        While Count_Check1 < Obstacle.Length - 1 And Not Obst_Check_Done

            If Obstacle(Count_Check1).Bounds.IntersectsWith(Player1_Box.Bounds) And CInt(Player1_Box.Location.X) < CInt(Obstacle(Count_Check1).Location.X) Then
                Obst_Check_Done = True
                P_Can_Mov_R = False
                Obst_Check_Done = True
                Check_Player_Left_Right()

            ElseIf Obstacle(Count_Check1).Bounds.IntersectsWith(Player1_Box.Bounds) Then
                Obst_Check_Done = True
                P_Can_Mov_L = True
                Obst_Check_Done = True
                Check_Player_Left_Right()

            Else
                P_Can_Mov_R = True
                P_Can_Mov_L = True
                If Count_Check1 = (Obstacle.Length - 1) Then
                    Obst_Check_Done = True
                End If
            End If

            Count_Check1 += 1
        End While





        '_________________________________Move LEFT_______
        If e.KeyCode = Keys.A And P_Can_Mov_L Then

            P_Tmr_Left.Enabled = True
            P_Tmr_Right.Enabled = False

            '_____________________________Move Right________
        ElseIf e.KeyCode = Keys.D And P_Can_Mov_R Then

            P_Tmr_Right.Enabled = True
            P_Tmr_Left.Enabled = False


        End If



        'PLAYER 2 CONDITIONS
        If e.KeyCode = Keys.Left And P2_Can_Mov_L Then
            P2_Tmr_Left.Enabled = True
            P2_Tmr_Right.Enabled = False
        ElseIf e.KeyCode = Keys.Right And P2_Can_Mov_R Then

            P2_Tmr_Right.Enabled = True
            P2_Tmr_Left.Enabled = False

        End If

        'KNIFE THROWING CHECK 
        If e.KeyCode = Keys.R And P1.Can_throw Then

            P1_Throw_Knife()
            P1.Can_throw = False

        End If
        If e.KeyCode = Keys.NumPad0 And P2.Can_throw Then

            P2_Throw_Knife()
            P2.Can_throw = False
        End If


    End Sub


    Private Sub Check_Player_Left_Right()
        If P_Tmr_Left.Enabled Then

            Player1_Box.Image = My.Resources.Stages_Res.CharacA_Stand
            Standing = True
        Else
            If P_Tmr_Right.Enabled Then

                Player1_Box.Image = My.Resources.Stages_Res.CharacA_Stand
                Player1_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            Standing = True
        End If
    End Sub


    Private Sub Check_Player_Left_Right2()
        If P2_Tmr_Left.Enabled Then
            Player2_Box.Image = My.Resources.Stages_Res.Character2_Standing1

            Player2_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            Standing2 = True
        Else
            If P2_Tmr_Right.Enabled Then
                Player2_Box.Image = My.Resources.Stages_Res.Character2_Standing1
            End If
            Standing2 = True
        End If
    End Sub



    Private Sub Stage1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        'Calling the FN to check if player's orientation is LEFT or RIGHT




        If (e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left) Then

            Check_Player_Left_Right2()
            P2_Tmr_Left.Enabled = False
            P2_Tmr_Right.Enabled = False
            Count_Img2 = 0
        End If
        If (e.KeyCode = Keys.A Or e.KeyCode = Keys.D) Then

            Check_Player_Left_Right()
            P_Tmr_Left.Enabled = False
            P_Tmr_Right.Enabled = False

            Count_Img = 0
        End If

    End Sub

    Private Sub Stage1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Standing Then
            If e.KeyChar = Convert.ToChar(32) Then

                If P_Left_Mode Or P_Right_Mode Then
                    Start_Jumping()
                End If

            End If
        End If


    End Sub


    Private Sub P_Tmr_Down_Tick(sender As Object, e As EventArgs) Handles P_Tmr_Down.Tick

        If P_Can_Mov_Down Then
            Player1_Box.Location = New Point(Player1_Box.Location.X, Player1_Box.Location.Y + 4)
            Player1_Box.Image = My.Resources.Stages_Res.CharacA_BefUp1L
            If P_Right_Mode Then
                Player1_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
        Else
            P_Tmr_Down.Enabled = False
        End If


    End Sub

    Private Sub Tmr_Check_Tick(sender As Object, e As EventArgs) Handles Tmr_Check.Tick
        If Player1_Box.Bounds.IntersectsWith(Portal1A.Bounds) Then
            Player1_Box.Location = New Point(Portal1B.Location)
        End If

        If Player1_Box.Bounds.IntersectsWith(Portal2A.Bounds) Then
            Player1_Box.Location = New Point(Portal2B.Location)
        End If


        If Player2_Box.Bounds.IntersectsWith(Portal1A.Bounds) Then
            Player2_Box.Location = New Point(Portal1B.Location)
        End If



        P1.Player_Name = P1Namelbl.Text
        P2.Player_Name = P2Namelbl.Text


        Knife_check_clear()

        Update_HP_Bars()
        Update_Knives_count()


        'When a player dies
        If P1.Life_Point <= 0 Then              'SETTING Winner's name
            EndGame(P2.Player_Name)



            Tmr_Check.Enabled = False
        ElseIf P2.Life_Point <= 0 Then
            EndGame(P1.Player_Name)
            Tmr_Check.Enabled = False
        End If




    End Sub


    Private Sub Update_HP_Bars()
        If P1.Life_Point < 0 Then
            HPBar1.Value = 0
        Else
            HPBar1.Value = P1.Life_Point
        End If

        If P2.Life_Point < 0 Then
            HPBar2.Value = 0
        Else
            HPBar2.Value = P2.Life_Point
        End If
    End Sub

    Private Sub Update_Knives_count()
        remain_knife_lbl1.Text = CStr(P1.Knife_remainder)
        remain_knife_lbl2.Text = CStr(P2.Knife_remainder)
    End Sub

    Private Sub P1_Throw_Knife()
        KnifeTmrP1.Enabled = True
        Panel1.Controls.Add(KnifePic1)
        P1.Knife_remainder -= 1

        'Check if NO remaining knife
        If P1.Knife_remainder = 0 Then
            EndGame(P2.Player_Name)
        End If

        KnifePic1.Visible = True
        If P_Left_Mode Then
            KnifePic1.Location = New Point(Player1_Box.Location.X - 50, Player1_Box.Location.Y + (Player1_Box.Height / 2))
            KnifePic1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            Knife1_Right_Mode = False

        Else
            Knife1_Right_Mode = True
            KnifePic1.Location = New Point(Player1_Box.Location.X + 80, Player1_Box.Location.Y + (Player1_Box.Height / 2))

        End If

    End Sub



    Private Sub P2_Throw_Knife()

        P2.Attack_Point = CInt(Int((50 * Rnd()) + 1))
        KnifeTmrP2.Enabled = True
        Panel1.Controls.Add(KnifePic2)
        KnifePic2.Visible = True

        P2.Knife_remainder -= 1


        'Check if no Remaining knife
        If P2.Knife_remainder = 0 Then
            EndGame(P1.Player_Name)
        End If



        If P2_Left_Mode Then
            KnifePic2.Location = New Point(Player2_Box.Location.X - 50, Player2_Box.Location.Y + (Player2_Box.Height / 2))

            Knife2_Right_Mode = False
        ElseIf P2_Right_Mode Then

            Knife2_Right_Mode = True
            KnifePic2.Location = New Point(Player2_Box.Location.X + 80, Player2_Box.Location.Y + (Player2_Box.Height / 2))
            KnifePic2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        End If
    End Sub
    Dim Knife1_Right_Mode, Knife2_Right_Mode As Boolean

    Private Sub KnifeTmrP1_Tick(sender As Object, e As EventArgs) Handles KnifeTmrP1.Tick


        If Knife1_Right_Mode Then

            KnifePic1.Location = New Point(KnifePic1.Location.X + 6, KnifePic1.Location.Y)

        Else
            KnifePic1.Location = New Point(KnifePic1.Location.X - 6, KnifePic1.Location.Y)

        End If

    End Sub
    Private Sub KnifeTmrP2_Tick(sender As Object, e As EventArgs) Handles KnifeTmrP2.Tick

        If Knife2_Right_Mode Then

            KnifePic2.Location = New Point(KnifePic2.Location.X + 6, KnifePic2.Location.Y)

        Else
            KnifePic2.Location = New Point(KnifePic2.Location.X - 6, KnifePic2.Location.Y)

        End If

    End Sub
    Private Sub Knife_check_clear()

        If KnifePic1.Bounds.IntersectsWith(Player2_Box.Bounds) Then
            P1.Can_throw = True
            KnifeTmrP1.Enabled = False
            KnifePic1.Location = New Point(5, 5)
            KnifePic1.Visible = False
            P2.Life_Point = P2.Life_Point - P1.Attack_Point

        End If
        If KnifePic1.Bounds.IntersectsWith(Bound_Left.Bounds) Or KnifePic1.Bounds.IntersectsWith(Bound_Right.Bounds) Then
            P1.Can_throw = True
            KnifeTmrP1.Enabled = False
            KnifePic1.Location = New Point(5, 5)
            KnifePic1.Visible = False

        End If

        If KnifePic2.Bounds.IntersectsWith(Player1_Box.Bounds) Then
            P2.Can_throw = True
            KnifeTmrP2.Enabled = False
            KnifePic2.Location = New Point(5, 5)
            KnifePic2.Visible = False
            P1.Life_Point = P1.Life_Point - P2.Attack_Point

        End If

        If KnifePic2.Bounds.IntersectsWith(Bound_Left.Bounds) Or KnifePic2.Bounds.IntersectsWith(Bound_Right.Bounds) Then
            P2.Can_throw = True
            KnifeTmrP2.Enabled = False
            KnifePic2.Location = New Point(5, 5)
            KnifePic2.Visible = False

        End If


    End Sub

    Public Sub EndGame(ByVal Winner_Name As String)
        Dim myEndForm = New EndForm()
        myEndForm.Show()


        '--------Setting the final score
        final_score = P1.Life_Point - P2.Life_Point

        If final_score < 0 Then
            final_score = final_score * -1
        End If

        final_score = final_score + Tmr_count

        'displaying score and Winner name
        myEndForm.Score_box.Text = final_score

        myEndForm.Winner_Name_box.Text = Winner_Name
        myEndForm.P1Namelbl.Text = P1.Player_Name
        myEndForm.P2Namelbl.Text = P2.Player_Name
        Me.Hide()


    End Sub


    Dim count_Portal_img As Integer = 0
    Private Sub Tmr_Portals_Tick(sender As Object, e As EventArgs) Handles Tmr_Portals.Tick
        If count_Portal_img <= 5 Then
            Select Case count_Portal_img
                Case 0
                    Portal1A.Image = My.Resources.Stages_Res.PortalA1
                    Portal2A.Image = My.Resources.Stages_Res.PortalA1
                    Portal1B.Image = My.Resources.Stages_Res.PortalB1
                    Portal2B.Image = My.Resources.Stages_Res.PortalB1
                Case 1
                    Portal1A.Image = My.Resources.Stages_Res.PortalA2
                    Portal2A.Image = My.Resources.Stages_Res.PortalA2
                    Portal1B.Image = My.Resources.Stages_Res.PortalB2
                    Portal2B.Image = My.Resources.Stages_Res.PortalB2
                Case 2
                    Portal1A.Image = My.Resources.Stages_Res.PortalA3
                    Portal2A.Image = My.Resources.Stages_Res.PortalA3
                    Portal1B.Image = My.Resources.Stages_Res.PortalB3
                    Portal2B.Image = My.Resources.Stages_Res.PortalB3
                Case 3
                    Portal1A.Image = My.Resources.Stages_Res.PortalA4
                    Portal2A.Image = My.Resources.Stages_Res.PortalA4
                    Portal1B.Image = My.Resources.Stages_Res.PortalB4
                    Portal2B.Image = My.Resources.Stages_Res.PortalB4
                Case 4
                    Portal1A.Image = My.Resources.Stages_Res.PortalA5
                    Portal2A.Image = My.Resources.Stages_Res.PortalA5
                    Portal1B.Image = My.Resources.Stages_Res.PortalB5
                    Portal2B.Image = My.Resources.Stages_Res.PortalB5
                    count_Portal_img = 0


            End Select


        End If
        count_Portal_img += 1
    End Sub
End Class