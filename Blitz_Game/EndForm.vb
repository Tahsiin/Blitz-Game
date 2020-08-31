Imports System.Data.OleDb

Public Class EndForm

    Dim P1Name As String
    Friend WithEvents Replay_Tmr As New Timer()
    Dim Counter_replay As Integer = 10
    'SETTING THE CONNECTION STRING

    Dim mysr As IO.StreamReader = IO.File.OpenText("ConnectionSTR.txt")
    Dim ConnStr As String = mysr.ReadLine


    Public Sub Btn_Click(sender As Object, e As EventArgs) Handles Finish_btn.Click

        'Returning to MAIN MENU
        Main_Menu.Show()

        Me.Close()
    End Sub

    Private Sub EndForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Replay_Tmr.Interval = 1000
        Replay_Tmr.Enabled = True
        Check_Replay_Count()
        Cursor.Show()


        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = ConnStr

        Dim str As String
        str = "INSERT INTO Display_Score([Player1_Name],[Player2_Name],[Winner],[score]) VALUES (?,?,?,?)"


        Dim cmd As New OleDb.OleDbCommand(str, conn)
        cmd.Parameters.Add(New OleDbParameter("Player1_Name", P1Namelbl.Text))
        cmd.Parameters.Add(New OleDbParameter("Player2_Name", P2Namelbl.Text))
        cmd.Parameters.Add(New OleDbParameter("Winner", Winner_Name_box.Text))
        cmd.Parameters.Add(New OleDbParameter("Score", Score_box.Text))
        cmd.Connection = conn
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()

    End Sub
    Private Sub Check_Replay_Count()
        If Counter_replay >= 0 Then
            RCounterlbl.Text = CStr(Counter_replay)
        Else
            Replay_btn.Visible = False
            Replay_btn.Enabled = False
            RCounterlbl.Visible = False
        End If
        Counter_replay -= 1
    End Sub
    Private Sub Replay_Tmr_Tick(sender As Object, e As EventArgs) Handles Replay_Tmr.Tick
        Check_Replay_Count()
    End Sub
    Public Sub Replay_btn_Click(sender As Object, e As EventArgs) Handles Replay_btn.Click
        Dim Stage1New As New Stage1()
        Stage1New.Show()
        Me.Close()
    End Sub
End Class