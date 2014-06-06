Public Class Powers
    Dim Power(1) As ClassPowers
    Dim PowerCounter As Integer
    Dim SelectedItem As Integer
    Dim HitLocBef As System.Drawing.Point
    Dim HitLocBefLbl As System.Drawing.Point
    Structure ClassPowers
        Dim PowerLevel As String
        Dim PowerName As String
        Dim Usage As String
        Dim Description As String
        Dim Keywords As String
        Dim ActionType As String
        Dim Range As String
        Dim RangeMod1 As String
        Dim RangeMod2 As String
        Dim Requirement As String
        Dim Target As String
        Dim Attack1, Attack2, AttackMod1, AttackMod2 As String
        Dim Hit As String
        Dim Effect As String
        Dim Special As String
        Dim Miss As String
    End Structure
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PowerCounter = 1
        Power_Name.Text = "New Power"
        Powers_List.SelectedIndex = 0
        Usage.SelectedIndex = 0
        Power_Level.SelectedIndex = 0
        Action_Type.SelectedIndex = 0
        Me.WindowState = FormWindowState.Maximized
        HitLocBefLbl = Hit_Lbl.Location
        HitLocBef = Hit.Location
        Attack_Power.Checked = True
        Menu.SelectedIndex = 2
        PictureBox1.Height = Me.Height
        PictureBox1.Width = Me.Width
    End Sub
    Public Sub ReloadScreen()
        If Powers_List.SelectedIndex <> -1 Then
            SelectedItem = Powers_List.SelectedIndex
            Power_Level.SelectedIndex = Power(Powers_List.SelectedIndex).PowerLevel
            Power_Name.Text = Power(Powers_List.SelectedIndex).PowerName
            Usage.SelectedIndex = Power(Powers_List.SelectedIndex).Usage
            Description.Text = Power(Powers_List.SelectedIndex).Description
            Keywords.Text = Power(Powers_List.SelectedIndex).Keywords
            Action_Type.SelectedIndex = Power(Powers_List.SelectedIndex).ActionType
            Range.Text = Power(Powers_List.SelectedIndex).Range
            Range_Modifier_1.Text = Power(Powers_List.SelectedIndex).RangeMod1
            Range_Modifier_2.Text = Power(Powers_List.SelectedIndex).RangeMod2
            Target.Text = Power(Powers_List.SelectedIndex).Target
            Attack_1.Text = Power(Powers_List.SelectedIndex).Attack1
            Attack_2.Text = Power(Powers_List.SelectedIndex).Attack2
            Attack_Modifier_1.Text = Power(Powers_List.SelectedIndex).AttackMod1
            Hit.Text = Power(Powers_List.SelectedIndex).Hit
            Effect.Text = Power(Powers_List.SelectedIndex).Effect
            Special.Text = Power(Powers_List.SelectedIndex).Special
            Miss.Text = Power(Powers_List.SelectedIndex).Miss
            Requirement.Text = Power(Powers_List.SelectedIndex).Requirement
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If Power_Name.Text <> "" Or Power_Name.Text <> Nothing Then
            If Powers_List.SelectedIndex <> -1 Then
                Powers_List.Items(Powers_List.SelectedIndex) = Power_Name.Text
            End If
        End If
        If Powers_List.SelectedIndex <> -1 Then
            Power(SelectedItem).PowerLevel = Power_Level.SelectedIndex
            Power(SelectedItem).PowerName = Power_Name.Text
            Power(SelectedItem).Usage = Usage.SelectedIndex
            Power(SelectedItem).Description = Description.Text
            Power(SelectedItem).Keywords = Keywords.Text
            Power(SelectedItem).ActionType = Action_Type.SelectedIndex
            Power(SelectedItem).Range = Range.Text
            Power(SelectedItem).RangeMod1 = Range_Modifier_1.Text
            Power(SelectedItem).RangeMod2 = Range_Modifier_2.Text
            Power(SelectedItem).Target = Target.Text
            Power(SelectedItem).Attack1 = Attack_1.Text
            Power(SelectedItem).Attack2 = Attack_2.Text
            Power(SelectedItem).AttackMod1 = Attack_Modifier_1.Text
            Power(SelectedItem).Hit = Hit.Text
            Power(SelectedItem).Effect = Effect.Text
            Power(SelectedItem).Special = Special.Text
            Power(SelectedItem).Miss = Miss.Text
            Power(SelectedItem).Requirement = Requirement.Text
        End If
        If UCase(Range.Text) = "AREA BURST" Then
            Range_Modifier_2.Visible = True
            within.Visible = True
            squares.Visible = True
        Else
            Range_Modifier_2.Visible = False
            within.Visible = False
            squares.Visible = False
        End If
        If UCase(Range.Text) = "MELEE WEAPON" Then
            Range_Modifier_1.Visible = False
        Else
            Range_Modifier_1.Visible = True
        End If
    End Sub

    Private Sub Add_Power_Click(sender As System.Object, e As System.EventArgs) Handles Add_Power.Click
        Powers_List.Items.Add("New Power")
        Powers_List.SelectedIndex = Powers_List.Items.Count - 1
        PowerCounter = PowerCounter + 1
        ReDim Preserve Power(PowerCounter)
        Power(PowerCounter - 1).PowerName = "New Power"
        Power_Name.Text = "New Power"
    End Sub

    Private Sub Powers_List_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Powers_List.SelectedIndexChanged
        If SelectedItem <> Powers_List.SelectedIndex Then
            ReloadScreen()
        End If
    End Sub

    Private Sub Delete_Power_Click(sender As System.Object, e As System.EventArgs) Handles Delete_Power.Click
        If Powers_List.SelectedIndex <> -1 Then
            SelectedItem = Powers_List.SelectedIndex
            PowerCounter = PowerCounter - 1
            Dim x As Integer
            Dim Temparray(PowerCounter + 1) As ClassPowers
            For x = 0 To PowerCounter + 1 Step 1
                Temparray(x).PowerLevel = Power(x).PowerLevel
                Temparray(x).PowerName = Power(x).PowerName
                Temparray(x).Usage = Power(x).Usage
                Temparray(x).Description = Power(x).Description
                Temparray(x).Keywords = Power(x).Keywords
                Temparray(x).ActionType = Power(x).ActionType
                Temparray(x).Range = Power(x).Range
                Temparray(x).RangeMod1 = Power(x).RangeMod1
                Temparray(x).RangeMod2 = Power(x).RangeMod2
                Temparray(x).Target = Power(x).Target
                Temparray(x).Attack1 = Power(x).Attack1
                Temparray(x).Attack2 = Power(x).Attack2
                Temparray(x).AttackMod1 = Power(x).AttackMod1
                Temparray(x).AttackMod2 = Power(x).AttackMod2
                Temparray(x).ActionType = Power(x).ActionType
                Temparray(x).Hit = Power(x).Hit
                Temparray(x).Effect = Power(x).Effect
                Temparray(x).Special = Power(x).Special
                Temparray(x).Miss = Power(x).Miss
                Temparray(x).Requirement = Power(x).Requirement
            Next
            x = 0
            ReDim Power(PowerCounter)
            For c = 0 To PowerCounter Step 1
                If SelectedItem <> c Then
                    x = c
                    If SelectedItem < c Then
                        x = c - 1
                    End If
                    Power(x).PowerLevel = Temparray(c).PowerLevel
                    Power(x).PowerName = Temparray(c).PowerName
                    Power(x).Usage = Temparray(c).Usage
                    Power(x).Description = Temparray(c).Description
                    Power(x).Keywords = Temparray(c).Keywords
                    Power(x).ActionType = Temparray(c).ActionType
                    Power(x).Range = Temparray(c).Range
                    Power(x).RangeMod1 = Temparray(c).RangeMod1
                    Power(x).RangeMod2 = Temparray(c).RangeMod2
                    Power(x).Target = Temparray(c).Target
                    Power(x).Attack1 = Temparray(c).Attack1
                    Power(x).Attack2 = Temparray(c).Attack2
                    Power(x).AttackMod1 = Temparray(c).AttackMod1
                    Power(x).AttackMod2 = Temparray(c).AttackMod2
                    Power(x).ActionType = Temparray(c).ActionType
                    Power(x).Hit = Temparray(c).Hit
                    Power(x).Effect = Temparray(c).Effect
                    Power(x).Special = Temparray(c).Special
                    Power(x).Miss = Temparray(c).Miss
                    Power(x).Requirement = Temparray(c).Requirement
                End If

            Next
            Powers_List.Items.RemoveAt(Powers_List.SelectedIndex)
            If SelectedItem <> 0 Then
                Powers_List.SelectedIndex = SelectedItem - 1
            Else

                If Powers_List.SelectedIndex = -1 And Powers_List.Items.Count >= 1 Then
                    Powers_List.SelectedIndex = 0
                End If
            End If
            ReloadScreen()
        End If
    End Sub
    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        CBB_Menu.Show()
        Traits.Close()
        Feats.Close()
        Features.Close()
        Me.Close()
    End Sub

    Private Sub Write_To_File_Click(sender As System.Object, e As System.EventArgs) Handles Write_To_File.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\CustomPowers.txt"
        Dim writer As New System.IO.StreamWriter(path)
        Dim usage As String
        Dim actiontype As String
        For counter = 0 To PowerCounter - 1
            Select Case Power(counter).Usage
                Case Is = 0
                    usage = "At-Will"
                Case Is = 1
                    usage = "Encounter"
                Case Is = 2
                    usage = "Daily"
            End Select
            Select Case Power(counter).ActionType
                Case Is = 0
                    actiontype = "Standard_Action"
                Case Is = 1
                    actiontype = "Minor_Action"
                Case Is = 2
                    actiontype = "Move_Action"
                Case Is = 3
                    actiontype = "Free_Action"
                Case Is = 4
                    actiontype = "Opportunity_Action"
                Case Is = 5
                    actiontype = "Immediate_Reaction"
                Case Is = 6
                    actiontype = "Immediate_Interrupt"
            End Select
            writer.WriteLine("<RulesElement name = """ & Power(counter).PowerName & """ type=""Power"" internal-id=""ID_FMP_POWER_" & PowerID.Value + counter & """ source=""Dragon Magazine 381"" revision-date=""8/27/2010 11:52:41 AM"" > ")
            If Attack_Power.Checked = True Then
                writer.WriteLine("  <Category> ID_INTERNAL_CATEGORY_ATTACK,ID_INTERNAL_CATEGORY_" & UCase(usage) & ",ID_INTERNAL_CATEGORY_" & UCase(usage) & "_USAGE, ID_FMP_CLASS_" & Traits.ClassID.Value & ",ID_FMP_CATEGORY_21,ID_INTERNAL_CATEGORY_" & UCase(actiontype) & "," & Power(counter).PowerLevel + 1 & " </Category>")
            Else
                writer.WriteLine("  <Category> ID_INTERNAL_CATEGORY_UTILITY,ID_INTERNAL_CATEGORY_" & UCase(usage) & ",ID_INTERNAL_CATEGORY_" & UCase(usage) & "_USAGE, ID_FMP_CLASS_" & Traits.ClassID.Value & ",ID_FMP_CATEGORY_21,ID_INTERNAL_CATEGORY_" & UCase(actiontype) & "," & Power(counter).PowerLevel + 1 & " </Category>")
            End If
            writer.WriteLine("  <Flavor> " & Power(counter).Description & " </Flavor>")
            writer.WriteLine("  <specific name=""Power Usage""> " & usage & " </specific>")
            writer.WriteLine("  <specific name=""_SkillPower"" />")
            If Attack_Power.Checked = True Then
                writer.WriteLine("  <specific name=""Display""> (Class Name) Attack " & Power(counter).PowerLevel + 1 & " </specific>")
            Else
                writer.WriteLine("  <specific name=""Display""> (Class Name) Utility " & Power(counter).PowerLevel + 1 & " </specific>")
            End If
            writer.WriteLine("  <specific name=""Keywords""> " & Power(counter).Keywords & " </specific>")
            Select Case Power(counter).ActionType
                Case Is = 0
                    actiontype = "Standard Action"
                Case Is = 1
                    actiontype = "Minor Action"
                Case Is = 2
                    actiontype = "Move Action"
                Case Is = 3
                    actiontype = "Free Action"
                Case Is = 4
                    actiontype = "Opportunity Action"
                Case Is = 5
                    actiontype = "Immediate Reaction"
                Case Is = 6
                    actiontype = "Immediate Interrupt"
            End Select
            writer.WriteLine("  <specific name=""Action Type""> " & actiontype & "</specific>")
            If UCase(Power(counter).Range) <> "AREA BURST" Then
                writer.WriteLine("  <specific name=""Attack Type""> " & Power(counter).Range & " " & Power(counter).RangeMod1 & " </specific>")
            Else
                writer.WriteLine("  <specific name=""Attack Type""> " & Power(counter).Range & " " & Power(counter).RangeMod1 & " within " & Power(counter).RangeMod2 & " squares </specific>")
            End If
            If Attack_Power.Checked = True Then
                If Power(counter).Requirement <> Nothing Or Power(counter).Requirement <> "" Then
                    writer.WriteLine("  <specific name =""Requirement""> " & Power(counter).Requirement & " </specific>")
                End If
                writer.WriteLine("  <specific name=""Target""> " & Power(counter).Target & ". </specific>")
                If (Power(counter).AttackMod1 = Nothing Or Power(counter).AttackMod1 = "") And (Power(counter).AttackMod2 = Nothing Or Power(counter).AttackMod2 = "") Then
                    writer.WriteLine("  <specific name=""Attack""> " & Power(counter).Attack1 & " Vs. " & Power(counter).Attack2 & " </specific>")
                Else
                    If (Power(counter).AttackMod1 = Nothing Or Power(counter).AttackMod1 = "") And (Power(counter).AttackMod2 <> Nothing Or Power(counter).AttackMod2 <> "") Then
                        writer.WriteLine("  <specific name=""Attack""> " & Power(counter).Attack1 & " Vs. " & Power(counter).Attack2 & " + " & Power(counter).AttackMod2 & " </specific>")
                    Else
                        If (Power(counter).AttackMod1 <> Nothing Or Power(counter).AttackMod1 <> "") And (Power(counter).AttackMod2 = Nothing Or Power(counter).AttackMod2 = "") Then
                            writer.WriteLine("  <specific name=""Attack""> " & Power(counter).Attack1 & " + " & Power(counter).AttackMod1 & " Vs. " & Power(counter).Attack2 & " </specific>")
                        Else

                            If (Power(counter).AttackMod1 <> Nothing Or Power(counter).AttackMod1 <> "") And (Power(counter).AttackMod2 <> Nothing Or Power(counter).AttackMod2 <> "") Then
                                writer.WriteLine("  <specific name=""Attack""> " & Power(counter).Attack1 & " + " & Power(counter).AttackMod1 & " Vs. " & Power(counter).Attack2 & " + " & Power(counter).AttackMod2 & " </specific>")
                            End If
                        End If
                    End If
                End If
                If Power(counter).Hit <> Nothing Or Power(counter).Hit <> "" Then
                    writer.WriteLine("  <specific name=""Hit""> " & Power(counter).Hit & " </specific>")
                End If
            Else
                writer.WriteLine("  <specific name=""Target""> " & Power(counter).Target & ". </specific>")
                If Power(counter).Requirement <> Nothing Or Power(counter).Requirement <> "" Then
                    writer.WriteLine("  <specific name =""Requirement""> " & Power(counter).Requirement & " </specific>")
                End If
            End If
            If Attack_Power.Checked = True Then
                If Power(counter).Effect <> Nothing Or Power(counter).Effect <> "" Then
                    writer.WriteLine("  <specific name=""Effect""> " & Power(counter).Effect & " </specific>")
                End If
                If Power(counter).Special <> Nothing Or Power(counter).Special <> "" Then
                    writer.WriteLine("  <specific name=""Special""> " & Power(counter).Special & " </specific>")
                End If
                If Power(counter).Miss <> Nothing Or Power(counter).Miss <> "" Then
                    writer.WriteLine("  <specific name=""Miss""> " & Power(counter).Miss & " </specific>")
                End If
            Else
                If Power(counter).Hit <> Nothing Or Power(counter).Hit <> "" Then
                    writer.WriteLine("  <specific name=""Effect""> " & Power(counter).Hit & " </specific>")
                End If
            End If
            writer.WriteLine("  <specific name=""_Associated Feats"" />")
            writer.WriteLine("  <specific name=""Class""> ID_FMP_CLASS_" & Traits.ClassID.Value & " </specific>")
            writer.WriteLine("  <specific name=""Level""> " & Power(counter).PowerLevel + 1 & " </specific>")
            If Attack_Power.Checked = True Then
                writer.WriteLine("  <specific name=""Power Type""> Attack </specific>")
            Else
                writer.WriteLine("  <specific name=""Power Type""> Utility </specific>")
            End If

            writer.WriteLine("</RulesElement>")
        Next
        writer.Close()
        MsgBox("Finsihed writing to file on desktop!")
    End Sub


    Private Sub Utility_Power_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Utility_Power.CheckedChanged
        Hit_Lbl.Text = "Effect"
        Hit.Location = Attack_1.Location
        Hit_Lbl.Location = Attack_Lbl.Location
        Effect_Lbl.Visible = False
        Special_Lbl.Visible = False
        Miss_Lbl.Visible = False
        Effect.Visible = False
        Special.Visible = False
        Miss.Visible = False
        Attack_2.Visible = False
        Attack_1.Visible = False
        Plus1.Visible = False
        VS.Visible = False
        Attack_Modifier_1.Visible = False
        Attack_Lbl.Visible = False

    End Sub

    Private Sub Attack_Power_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Attack_Power.CheckedChanged
        Hit_Lbl.Text = "Hit"
        Hit.Location = HitLocBef
        Hit_Lbl.Location = HitLocBefLbl
        Effect_Lbl.Visible = True
        Special_Lbl.Visible = True
        Miss_Lbl.Visible = True
        Effect.Visible = True
        Special.Visible = True
        Miss.Visible = True
        Attack_2.Visible = True
        Attack_1.Visible = True
        Plus1.Visible = True
        VS.Visible = True
        Attack_Modifier_1.Visible = True
        Attack_Lbl.Visible = True
    End Sub


    Private Sub Menu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Menu.SelectedIndexChanged
        Select Case Menu.SelectedIndex
            Case Is = 0
                Me.Hide()
                Traits.Show()
                Traits.Menu.SelectedIndex = 0
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

    Private Sub Powers_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("TEST")
    End Sub
End Class



