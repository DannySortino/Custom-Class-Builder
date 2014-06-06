Public Class Races
    Dim count As Integer
    Dim index As Integer

    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        CBB_Menu.Show()
        Me.Close()
    End Sub
    Private Sub Races_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Race_Name.Text = "Race Name"
        Me.WindowState = FormWindowState.Maximized
        PictureBox1.Height = Me.Size.Height
        PictureBox1.Width = Me.Size.Width
    End Sub

    Private Sub Race_Name_TextChanged(sender As System.Object, e As System.EventArgs) Handles Race_Name.TextChanged
        If Len(Race_Name.Text) < 13 Then
            Race_Namelbl.Text = Race_Name.Text
        Else
            If Race_Namelbl.Text.Contains("-") Then
            Else
                Race_Namelbl.Text = Race_Namelbl.Text & "-"
            End If
        End If
    End Sub
    Private Sub Ability_Score_Bonus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ability_Score_Bonus.MouseUp
        If Ability_Score_Bonus.CheckedItems.Count > 5 Then
            Ability_Score_Bonus.SetItemChecked(Ability_Score_Bonus.SelectedIndex, CheckState.Unchecked)
        End If
    End Sub

    Private Sub Skill_Bonus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Skill_Bonus.MouseUp
        If Skill_Bonus.CheckedItems.Count > 2 Then
            Skill_Bonus.SetItemChecked(Skill_Bonus.SelectedIndex, CheckState.Unchecked)
        End If
    End Sub

    Private Sub Write_To_File_Click(sender As System.Object, e As System.EventArgs) Handles Write_To_File.Click
        Dim test As String
        Try
            test = Ability_Score_Bonus.CheckedItems.Item(1)
        Catch ex As Exception
            MsgBox("You must choose at least two Ability Score Bonuses")
            Exit Sub
        End Try
        Try
            test = Skill_Bonus.CheckedItems.Item(1)
        Catch ex As Exception
            MsgBox("You must choose two Skill Bonuses")
            Exit Sub
        End Try
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\CustomRace.txt"
        Dim writer As New System.IO.StreamWriter(path)
        writer.WriteLine("<RulesElement name =""" & Race_Name.Text & """ type=""Race"" internal-id=""ID_FMP_RACE_" & RaceID.Value & """ source=""Player's Handbook"" revision-date=""8/27/2010 12:39:01 PM"">")
        writer.WriteLine("  <Prereqs> ~" & UCase(Race_Name.Text) & " </Prereqs>")
        writer.WriteLine("  <Flavor> " & Flavor.Text & "</Flavor>")
        writer.WriteLine("  <specific name=""Size""> " & Size.Text & " </specific>")
        writer.WriteLine("  <specific name=""Speed""> " & Speed.Text & " squares </specific>")
        writer.WriteLine("  <specific name=""Characteristics""> " & Characteristics.Text & " </specific>")
        writer.WriteLine("  <specific name=""Physical Qualities""> " & Physical_Qualities.Text & " </specific>")
        writer.WriteLine("  <specific name=""Playing""> " & Playing.Text & " </specific>")
        writer.WriteLine("  <specific name=""Vision""> " & Vision.Text & " </specific>")
        writer.WriteLine("  <specific name=""Average Height""> " & Average_Height1.Text & "' " & Average_Height2.Text & """ -" & Average_Height3.Text & "' " & Average_Height4.Text & """ </specific>")
        writer.WriteLine("  <specific name=""Average Weight""> " & Average_Weight1.Text & "-" & Average_Weight2.Text & " lb. </specific>")
        Try
            test = Ability_Score_Bonus.CheckedItems.Item(2)
            Try
                test = Ability_Score_Bonus.CheckedItems.Item(3)
                Try
                    test = Ability_Score_Bonus.CheckedItems.Item(4)
                    writer.WriteLine("  <specific name=""Ability Scores""> +2 " & Ability_Score_Bonus.CheckedItems.Item(0) & ", +2 " & Ability_Score_Bonus.CheckedItems.Item(1) & ", +2 " & Ability_Score_Bonus.CheckedItems.Item(2) & ", +2 " & Ability_Score_Bonus.CheckedItems.Item(3) & " or +2 " & Ability_Score_Bonus.CheckedItems.Item(4) & " </specific>")
                Catch ex As Exception
                    writer.WriteLine("  <specific name=""Ability Scores""> +2 " & Ability_Score_Bonus.CheckedItems.Item(0) & ", +2 " & Ability_Score_Bonus.CheckedItems.Item(1) & ", +2 " & Ability_Score_Bonus.CheckedItems.Item(2) & " or +2 " & Ability_Score_Bonus.CheckedItems.Item(3) & " </specific>")
                End Try
            Catch ex As Exception
                writer.WriteLine("  <specific name=""Ability Scores""> +2 " & Ability_Score_Bonus.CheckedItems.Item(0) & ", +2 " & Ability_Score_Bonus.CheckedItems.Item(1) & " or +2 " & Ability_Score_Bonus.CheckedItems.Item(2) & " </specific>")
            End Try
        Catch ex As Exception
            writer.WriteLine("  <specific name=""Ability Scores""> +2 " & Ability_Score_Bonus.CheckedItems.Item(0) & " or +2 " & Ability_Score_Bonus.CheckedItems.Item(1) & " </specific>")
        End Try
        writer.WriteLine("  <specific name=""Languages""> Choice of any two </specific>")
        writer.WriteLine("  <specific name=""Skill Bonuses""> +2 " & Skill_Bonus.CheckedItems.Item(0) & ", +2 " & Skill_Bonus.CheckedItems.Item(1) & " </specific>")
        writer.WriteLine("  <specific name=""Male Names""> " & Male_Names.Text & " </specific>")
        writer.WriteLine("  <specific name=""Female Names""> " & Female_Names.Text & " </specific>")
        writer.WriteLine("  <specific name=""Short Description""> " & Short_Description.Text & " </specific>")
        writer.WriteLine("  <specific name=""Racial Traits""> ID_FMP_RACIAL_TRAIT_379 </specific>")
        writer.WriteLine("  <rules>")
        writer.WriteLine("      <grant name=""ID_INTERNAL_GRANTS_" & UCase(Race_Name.Text) & """ type=""Grants"" />")
        writer.WriteLine("      <statadd name =""Speed"" value=""+" & Speed.Text & """ />")
        writer.WriteLine("      <textstring name=""Average Height"" value=""" & Average_Height1.Text & "' " & Average_Height2.Text & "&quot;-" & Average_Height3.Text & "' " & Average_Height4.Text & "&quot;"" />")
        writer.WriteLine("      <textstring name=""Average Weight"" value=""" & Average_Weight1.Text & "-" & Average_Weight2.Text & " lb."" />")
        writer.WriteLine("      <textstring name=""Size"" value=""" & Size.Text & """ />")
        writer.WriteLine("      <select type=""Language"" number=""2"" Category=""Starting"" />")
        Select Case Ability_Score_Bonus.CheckedItems.Count
            Case Is = 1
                writer.WriteLine("      <select type=""Race Ability Bonus"" number=""1"" Category=""" & Ability_Score_Bonus.CheckedItems.Item(0) & """ />")
            Case Is = 2
                writer.WriteLine("      <select type=""Race Ability Bonus"" number=""1"" Category=""" & Ability_Score_Bonus.CheckedItems.Item(0) & "|" & Ability_Score_Bonus.CheckedItems.Item(1) & """ />")
            Case Is = 3
                writer.WriteLine("      <select type=""Race Ability Bonus"" number=""1"" Category=""" & Ability_Score_Bonus.CheckedItems.Item(0) & "|" & Ability_Score_Bonus.CheckedItems.Item(1) & "|" & Ability_Score_Bonus.CheckedItems.Item(2) & """ />")
            Case Is = 4
                writer.WriteLine("      <select type=""Race Ability Bonus"" number=""1"" Category=""" & Ability_Score_Bonus.CheckedItems.Item(0) & "|" & Ability_Score_Bonus.CheckedItems.Item(1) & "|" & Ability_Score_Bonus.CheckedItems.Item(2) & "|" & Ability_Score_Bonus.CheckedItems.Item(3) & """ />")
            Case Is = 5
                writer.WriteLine("      <select type=""Race Ability Bonus"" number=""1"" Category=""" & Ability_Score_Bonus.CheckedItems.Item(0) & "|" & Ability_Score_Bonus.CheckedItems.Item(1) & "|" & Ability_Score_Bonus.CheckedItems.Item(2) & "|" & Ability_Score_Bonus.CheckedItems.Item(3) & "|" & Ability_Score_Bonus.CheckedItems.Item(4) & """ />")
        End Select
        writer.WriteLine("  </rules>")
        writer.WriteLine("")
        writer.WriteLine("</RulesElement>")
        writer.WriteLine()
        writer.WriteLine("   <RulesElement name=""" & Race_Name.Text & """ type=""Grants"" internal-id=""ID_INTERNAL_GRANTS_" & UCase(Race_Name.Text) & """ source=""Player's Handbook"">")
        writer.WriteLine("		<specific name=""_SupportsID""> ID_FMP_RACE_" & RaceID.Value & " </specific>")
        writer.WriteLine("		<rules>")
        writer.WriteLine("			<grant name=""ID_INTERNAL_SIZE_" & UCase(Size.Text) & """ type=""Size"" />")
        writer.WriteLine("			<grant name=""ID_INTERNAL_VISION_" & UCase(Vision.Text) & """ type=""Vision"" />")
        writer.WriteLine("          <grant name=""ID_FMP_RACIAL_TRAIT_379"" type=""Racial Trait"" />")
        writer.WriteLine("          <grant name=""ID_TER_RACIAL_TRAIT_0001"" type=""Racial Trait"" />")
        writer.WriteLine("			<grant name=""ID_INTERNAL_RACIAL_TRAIT_" & UCase(Skill_Bonus.CheckedItems.Item(0)) & "_BONUS"" type=""Racial Trait"" />")
        writer.WriteLine("			<grant name=""ID_INTERNAL_RACIAL_TRAIT_" & UCase(Skill_Bonus.CheckedItems.Item(1)) & "_BONUS"" type=""Racial Trait"" />")
        writer.WriteLine("		</rules>")
        writer.WriteLine("")
        writer.WriteLine("  </RulesElement>")
        writer.WriteLine("")



        writer.Close()
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

End Class