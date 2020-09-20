Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewMethod()
    End Sub

    Private Sub NewMethod()
        ToolStripProgressBar1.Increment(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Nothing has been written in the TextBox")
        Else
            MsgBox("You wrote something inside the TextBox", MsgBoxStyle.OkCancel, MsgBoxStyle.Information)
            Beep()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DateTimePicker1.Visible = True Then
            DateTimePicker1.Visible = False
        Else
            DateTimePicker1.Visible = False
            DateTimePicker1.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox1.Checked = True Then
            MsgBox("You Checked Number 1", MsgBoxStyle.Information)
        Else
        End If
        If CheckBox2.Checked = True Then
            MsgBox("You Checked Number 2", MsgBoxStyle.Information)
        Else
        End If
        If CheckBox3.Checked = True Then
            MsgBox("You Checked Number 3", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome, to my First Ever Coding Experience!", MsgBoxStyle.Information)
        MsgBox("Warning! there might be Bugs!", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckBox2.Checked = True Then
            Form3.Show()
            MsgBox("Well Done!", MsgBoxStyle.OkCancel)
            If MsgBoxResult.Ok Then
                MsgBox("Im Also Ok")
            End If
        End If
    End Sub

    Private Sub CheckBox1_DoubleClick(sender As Object, e As EventArgs) Handles CheckBox1.DoubleClick
        MsgBox("You clicked too fast on that one sir", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Program Exited", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Form4.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ToolStripProgressBar1.Increment(5)
    End Sub
End Class