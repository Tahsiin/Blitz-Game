Imports System.Data.OleDb
Public Class DisplayScore

    'SETTING CONNECTION STRING
    Dim mysr As IO.StreamReader = IO.File.OpenText("ConnectionSTR.txt")
    Dim ConnStr As String = mysr.ReadLine


    Private Sub DisplayScore_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = ConnStr
        Dim Adapter As New OleDb.OleDbDataAdapter("SELECT * FROM Display_Score", conn)
        Dim ds As New DataSet
        Adapter.Fill(ds, "Dsply_Score")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Dsply_Score"

        conn.Close()

        ComboBox1.Items.Add("---select---")

        ComboBox1.Items.Add("Highest score")
        ComboBox1.Items.Add("Lowest_score")





    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If ComboBox1.SelectedIndex = 2 Then
            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = ConnStr
            Dim Adapter As New OleDb.OleDbDataAdapter("SELECT * FROM Display_Score ORDER BY Score Desc", conn)
            Dim ds As New DataSet
            Adapter.Fill(ds, "Dsply_Score")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Dsply_Score"


            conn.Close()

        End If


        If ComboBox1.SelectedIndex = 1 Then
            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = ConnStr
            Dim Adapter As New OleDb.OleDbDataAdapter("SELECT * FROM Display_Score ORDER BY Score Asc", conn)
            Dim ds As New DataSet
            Adapter.Fill(ds, "Dsply_Score")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Dsply_Score"

            conn.Close()

        End If





    End Sub
End Class