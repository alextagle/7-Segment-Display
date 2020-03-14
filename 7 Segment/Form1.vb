Public Class Form1

    Dim segment(25) As PictureBox
    Dim i = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x = 2
        segment(1) = PictureBox1
        segment(2) = PictureBox2
        segment(3) = PictureBox3
        segment(4) = PictureBox4
        segment(5) = PictureBox5
        segment(6) = PictureBox6
        segment(7) = PictureBox7
        segment(8) = PictureBox8
        segment(9) = PictureBox9
        segment(10) = PictureBox10
        segment(11) = PictureBox11
        segment(12) = PictureBox12
        segment(13) = PictureBox13
        segment(14) = PictureBox14
        segment(15) = PictureBox15
        segment(16) = PictureBox16
        segment(17) = PictureBox17
        segment(18) = PictureBox18
        segment(19) = PictureBox19
        segment(20) = PictureBox20
        segment(21) = PictureBox21
        segment(22) = PictureBox22
        segment(23) = PictureBox23
        segment(24) = PictureBox24
        segment(25) = PictureBox25
        Timer1.Start()
        TextBox1.Visible = False


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TextBox1.Text += 1
        If (TextBox1.Text = 11) Then
            TextBox1.Text = 0
        End If
        If (TextBox1.Text = 1) Then
            For i = 1 To 25
                segment(i).BackColor = Color.Silver
            Next
            segment(2).BackColor = Color.Red
            segment(3).BackColor = Color.Red
            segment(4).BackColor = Color.Red
            segment(6).BackColor = Color.Red
            segment(10).BackColor = Color.Red
            segment(11).BackColor = Color.Red
            segment(15).BackColor = Color.Red
            segment(16).BackColor = Color.Red
            segment(20).BackColor = Color.Red
            segment(22).BackColor = Color.Red
            segment(23).BackColor = Color.Red
            segment(24).BackColor = Color.Red
        ElseIf TextBox1.Text = 2 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Silver
            Next
            segment(2).BackColor = Color.Red
            segment(3).BackColor = Color.Red
            segment(8).BackColor = Color.Red
            segment(10).BackColor = Color.Red
            segment(13).BackColor = Color.Red
            segment(18).BackColor = Color.Red
            segment(21).BackColor = Color.Red
            segment(22).BackColor = Color.Red
            segment(23).BackColor = Color.Red
            segment(24).BackColor = Color.Red
            segment(25).BackColor = Color.Red
        ElseIf TextBox1.Text = 3 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Red
            Next
            segment(7).BackColor = Color.Silver
            segment(8).BackColor = Color.Silver
            segment(9).BackColor = Color.Silver
            segment(10).BackColor = Color.Silver
            segment(16).BackColor = Color.Silver
            segment(17).BackColor = Color.Silver
            segment(18).BackColor = Color.Silver
            segment(19).BackColor = Color.Silver

        ElseIf TextBox1.Text = 4 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Silver
            Next
            segment(2).BackColor = Color.Red
            segment(3).BackColor = Color.Red
            segment(4).BackColor = Color.Red
            segment(6).BackColor = Color.Red
            segment(10).BackColor = Color.Red
            segment(12).BackColor = Color.Red
            segment(13).BackColor = Color.Red
            segment(16).BackColor = Color.Red
            segment(20).BackColor = Color.Red
            segment(22).BackColor = Color.Red
            segment(23).BackColor = Color.Red
            segment(24).BackColor = Color.Red
        ElseIf TextBox1.Text = 5 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Silver
            Next
            segment(3).BackColor = Color.Red
            segment(5).BackColor = Color.Red
            segment(6).BackColor = Color.Red
            segment(9).BackColor = Color.Red
            segment(11).BackColor = Color.Red
            segment(12).BackColor = Color.Red
            segment(13).BackColor = Color.Red
            segment(14).BackColor = Color.Red
            segment(15).BackColor = Color.Red
            segment(16).BackColor = Color.Red
            segment(21).BackColor = Color.Red
        ElseIf TextBox1.Text = 6 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Red
            Next
            segment(6).BackColor = Color.Silver
            segment(7).BackColor = Color.Silver
            segment(8).BackColor = Color.Silver
            segment(9).BackColor = Color.Silver
            segment(17).BackColor = Color.Silver
            segment(18).BackColor = Color.Silver
            segment(19).BackColor = Color.Silver
            segment(20).BackColor = Color.Silver
        ElseIf TextBox1.Text = 7 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Red
            Next
            segment(1).BackColor = Color.Silver
            segment(6).BackColor = Color.Silver
            segment(7).BackColor = Color.Silver
            segment(8).BackColor = Color.Silver
            segment(9).BackColor = Color.Silver
            segment(17).BackColor = Color.Silver
            segment(18).BackColor = Color.Silver
            segment(19).BackColor = Color.Silver
            segment(21).BackColor = Color.Silver
            segment(25).BackColor = Color.Silver
        ElseIf TextBox1.Text = 8 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Silver
            Next
            segment(1).BackColor = Color.Red
            segment(2).BackColor = Color.Red
            segment(3).BackColor = Color.Red
            segment(4).BackColor = Color.Red
            segment(5).BackColor = Color.Red
            segment(6).BackColor = Color.Red
            segment(12).BackColor = Color.Red
            segment(18).BackColor = Color.Red
            segment(24).BackColor = Color.Red
        ElseIf TextBox1.Text = 9 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Red
            Next
            segment(1).BackColor = Color.Silver
            segment(5).BackColor = Color.Silver
            segment(7).BackColor = Color.Silver
            segment(8).BackColor = Color.Silver
            segment(9).BackColor = Color.Silver
            segment(17).BackColor = Color.Silver
            segment(18).BackColor = Color.Silver
            segment(19).BackColor = Color.Silver
            segment(21).BackColor = Color.Silver
            segment(25).BackColor = Color.Silver
        ElseIf TextBox1.Text = 10 Then
            For i = 1 To 25
                segment(i).BackColor = Color.Red
            Next
            segment(7).BackColor = Color.Silver
            segment(8).BackColor = Color.Silver
            segment(9).BackColor = Color.Silver
            segment(17).BackColor = Color.Silver
            segment(18).BackColor = Color.Silver
            segment(19).BackColor = Color.Silver
            segment(20).BackColor = Color.Silver
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''segment(1).BackColor = Color.Red
        TextBox1.Text = 0
        For i = 1 To 25
            segment(i).BackColor = Color.Silver
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class
