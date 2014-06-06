Public Class Features
    Private Sub Menu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Menu.SelectedIndexChanged
        Select Case Menu.SelectedIndex
            Case Is = 2
                Me.Hide()
                Powers.Show()
                Powers.Menu.SelectedIndex = 2
            Case Is = 3
                Me.Hide()
                Feats.Show()
                Feats.Menu.SelectedIndex = 3
            Case Is = 0
                Me.Hide()
                Traits.Show()
                Traits.Menu.SelectedIndex = 0
        End Select
    End Sub
    Private Sub Features_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Menu.SelectedIndex = 1
        Me.WindowState = FormWindowState.Maximized
        PictureBox1.Height = Me.Height - 37
        PictureBox1.Width = Me.Width - 15
    End Sub
    Private Sub Exit_Btn_MouseEnter(sender As Object, e As System.EventArgs) Handles Exit_Btn.MouseEnter
        Exit_Btn.BackColor = Color.Blue
        Exit_Btn.ForeColor = Color.White
    End Sub

    Private Sub Exit_Btn_MouseLeave(sender As Object, e As System.EventArgs) Handles Exit_Btn.MouseLeave
        Exit_Btn.BackColor = Color.White
        Exit_Btn.ForeColor = Color.Black
    End Sub
    Private Sub Write_To_File_MouseEnter(sender As Object, e As System.EventArgs) Handles Write_To_File.MouseEnter
        Write_To_File.BackColor = Color.Blue
        Write_To_File.ForeColor = Color.White
    End Sub

    Private Sub Write_To_File_MouseLeave(sender As Object, e As System.EventArgs) Handles Write_To_File.MouseLeave
        Write_To_File.BackColor = Color.White
        Write_To_File.ForeColor = Color.Black
    End Sub

    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        CBB_Menu.Show()
        Traits.Close()
        Feats.Close()
        Me.Close()
        Powers.Close()
    End Sub

    Private Sub Features_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        PictureBox1.Height = Me.Height - 37
        PictureBox1.Width = Me.Width - 15
    End Sub
End Class