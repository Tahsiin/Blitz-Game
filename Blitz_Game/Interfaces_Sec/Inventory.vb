Public Class Inventory
    Dim Ready_to_move As Boolean
    Dim LeftSet As Boolean
    Dim TopSet As Boolean

    Dim HoldLeft As Integer
    Dim HoldTop As Integer

    Dim OffLeft As Integer
    Dim OffTop As Integer
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Location = New Point(0, 0)
        TextBox1.Text = PictureBox1.Location.X
        TextBox2.Text = PictureBox2.Location.Y


    End Sub
End Class