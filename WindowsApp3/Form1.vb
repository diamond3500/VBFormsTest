Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewMethod()
    End Sub

    Private Sub NewMethod()
        ToolStripProgressBar1.Increment(1)
        MsgBox("Successfully Incremented")
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
End Class