Public Class Traits

    Private Sub Traits_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Menu.SelectedIndex = 0
        Me.WindowState = FormWindowState.Maximized
        PictureBox1.Height = Me.Height
        PictureBox1.Width = Me.Width
    End Sub

    Private Sub Menu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Menu.SelectedIndexChanged
        Select Case Menu.SelectedIndex
            Case Is = 2
                Me.Hide()
                Powers.Show()
                Powers.Menu.SelectedIndex = 2
            Case Is = 1
                Me.Hide()
                Features.Show()
                Features.Menu.SelectedIndex = 1
            Case Is = 3
                Me.Hide()
                Feats.Show()
                Feats.Menu.SelectedIndex = 3
        End Select
    End Sub

    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        CBB_Menu.Show()
        Me.Close()
        Feats.Close()
        Features.Close()
        Powers.Close()
    End Sub
    Private Sub Exit_Btn_MouseEnter(sender As Object, e As System.EventArgs) Handles Exit_Btn.MouseLeave
        Exit_Btn.BackColor = Color.Blue
        Exit_Btn.ForeColor = Color.White
    End Sub

    Private Sub Exit_Btn_MouseLeave(sender As Object, e As System.EventArgs) Handles Exit_Btn.MouseLeave
        Exit_Btn.BackColor = Color.White
        Exit_Btn.ForeColor = Color.Black
    End Sub

    Private Sub Traits_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        PictureBox1.Height = Me.Height
        PictureBox1.Width = Me.Width
    End Sub
    Private Sub Write_To_File_MouseEnter(sender As Object, e As System.EventArgs) Handles Write_To_File.MouseEnter
        Write_To_File.BackColor = Color.Blue
        Write_To_File.ForeColor = Color.White
    End Sub

    Private Sub Write_To_File_MouseLeave(sender As Object, e As System.EventArgs) Handles Write_To_File.MouseLeave
        Write_To_File.BackColor = Color.White
        Write_To_File.ForeColor = Color.Black
    End Sub

End Class