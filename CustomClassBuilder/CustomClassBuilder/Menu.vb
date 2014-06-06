Public Class CBB_Menu

    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        End
    End Sub

    Private Sub Menu_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        PictureBox1.Height = Me.Height - 37
        PictureBox1.Width = Me.Width - 15
    End Sub

    Private Sub Menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Height = Me.Height - 37
        PictureBox1.Width = Me.Width - 15
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.dropbox.com/s/9czhm4x2k3vma74/Version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("This is up to date")
        Else
            My.Computer.Network.DownloadFile("https://www.dropbox.com/sh/f9hdiwu4i5m6jjs/AACPDyDNVFi-WeSSn4mQ3vvaa", CurDir)
            Process.Start(CurDir() & "/Setup.exe")
            End
        End If

    End Sub
    Private Sub Custom_Class_Click(sender As System.Object, e As System.EventArgs) Handles Custom_Class.Click
        Me.Hide()
        Traits.Show()
    End Sub

    Private Sub Custom_Race_Click(sender As System.Object, e As System.EventArgs) Handles Custom_Race.Click
        Me.Hide()
        Races.Show()
    End Sub

    Private Sub Custom_Race_MouseEnter(sender As Object, e As System.EventArgs) Handles Custom_Race.MouseEnter
        Custom_Race.BackColor = Color.Blue
        Custom_Race.ForeColor = Color.White
    End Sub

    Private Sub Custom_Race_MouseLeave(sender As Object, e As System.EventArgs) Handles Custom_Race.MouseLeave
        Custom_Race.BackColor = Color.White
        Custom_Race.ForeColor = Color.Black
    End Sub

    Private Sub Custom_Class_MouseEnter(sender As Object, e As System.EventArgs) Handles Custom_Class.MouseEnter
        Custom_Class.BackColor = Color.Blue
        Custom_Class.ForeColor = Color.White
    End Sub

    Private Sub Custom_Class_MouseLeave(sender As Object, e As System.EventArgs) Handles Custom_Class.MouseLeave
        Custom_Class.BackColor = Color.White
        Custom_Class.ForeColor = Color.Black
    End Sub

    Private Sub Exit_Btn_MouseEnter(sender As Object, e As System.EventArgs) Handles Exit_Btn.MouseEnter
        Exit_Btn.BackColor = Color.Blue
        Exit_Btn.ForeColor = Color.White
    End Sub

    Private Sub Exit_Btn_MouseLeave(sender As Object, e As System.EventArgs) Handles Exit_Btn.MouseLeave
        Exit_Btn.BackColor = Color.White
        Exit_Btn.ForeColor = Color.Black
    End Sub
End Class