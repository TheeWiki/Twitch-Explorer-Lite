Public Class Form2

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (Me.CheckBox1.Checked = False) Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If (Me.RadioButton2.Checked) Then
                Form1.WebBrowser1.Navigate("http://www.twitch.tv/" + Me.TextBox1.Text)
            ElseIf (Me.RadioButton1.Checked) Then
                Form1.WebBrowser1.Navigate("http://www.twitch.tv/directory/game/" + Me.TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class