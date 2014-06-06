<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Traits
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traits))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Class_Namelbl = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.ComboBox()
        Me.Write_To_File = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.Class_Name = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Key_Abilities = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Skill_Bonus = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Speed = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ClassID = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CCB"
        '
        'Class_Namelbl
        '
        Me.Class_Namelbl.AutoSize = True
        Me.Class_Namelbl.BackColor = System.Drawing.Color.Transparent
        Me.Class_Namelbl.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Class_Namelbl.ForeColor = System.Drawing.Color.White
        Me.Class_Namelbl.Image = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Class_Namelbl.Location = New System.Drawing.Point(117, 21)
        Me.Class_Namelbl.Name = "Class_Namelbl"
        Me.Class_Namelbl.Size = New System.Drawing.Size(309, 43)
        Me.Class_Namelbl.TabIndex = 5
        Me.Class_Namelbl.Text = "(Class Name)"
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Menu.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!)
        Me.Menu.ForeColor = System.Drawing.Color.White
        Me.Menu.FormattingEnabled = True
        Me.Menu.Items.AddRange(New Object() {"Traits", "Features", "Powers", "Feats"})
        Me.Menu.Location = New System.Drawing.Point(475, 18)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(245, 51)
        Me.Menu.TabIndex = 50
        '
        'Write_To_File
        '
        Me.Write_To_File.BackColor = System.Drawing.Color.White
        Me.Write_To_File.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!)
        Me.Write_To_File.Location = New System.Drawing.Point(748, 26)
        Me.Write_To_File.Name = "Write_To_File"
        Me.Write_To_File.Size = New System.Drawing.Size(185, 32)
        Me.Write_To_File.TabIndex = 51
        Me.Write_To_File.Text = "Write To File"
        Me.Write_To_File.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.CustomClassBuilder.My.Resources.Resources.background1
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1177, 1054)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Exit_Btn
        '
        Me.Exit_Btn.BackColor = System.Drawing.Color.White
        Me.Exit_Btn.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(973, 26)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(186, 32)
        Me.Exit_Btn.TabIndex = 54
        Me.Exit_Btn.Text = "Quit to Menu"
        Me.Exit_Btn.UseVisualStyleBackColor = False
        '
        'Class_Name
        '
        Me.Class_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Class_Name.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Class_Name.Location = New System.Drawing.Point(222, 83)
        Me.Class_Name.Name = "Class_Name"
        Me.Class_Name.Size = New System.Drawing.Size(469, 26)
        Me.Class_Name.TabIndex = 56
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(16, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(200, 27)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Class Name"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Description
        '
        Me.Description.AllowDrop = True
        Me.Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Description.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Description.Location = New System.Drawing.Point(222, 113)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Description.Size = New System.Drawing.Size(469, 58)
        Me.Description.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(11, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 27)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Flavour"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label19.Location = New System.Drawing.Point(12, 286)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(204, 27)
        Me.Label19.TabIndex = 91
        Me.Label19.Text = "Key Abilities"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Key_Abilities
        '
        Me.Key_Abilities.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Key_Abilities.CheckOnClick = True
        Me.Key_Abilities.Cursor = System.Windows.Forms.Cursors.Default
        Me.Key_Abilities.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.Key_Abilities.FormattingEnabled = True
        Me.Key_Abilities.HorizontalExtent = 19
        Me.Key_Abilities.HorizontalScrollbar = True
        Me.Key_Abilities.Items.AddRange(New Object() {"Strength", "Charisma", "Constitution", "Wisdom", "Intellegence", "Dexterity"})
        Me.Key_Abilities.Location = New System.Drawing.Point(222, 286)
        Me.Key_Abilities.MultiColumn = True
        Me.Key_Abilities.Name = "Key_Abilities"
        Me.Key_Abilities.ScrollAlwaysVisible = True
        Me.Key_Abilities.Size = New System.Drawing.Size(469, 36)
        Me.Key_Abilities.TabIndex = 92
        Me.Key_Abilities.TabStop = False
        Me.Key_Abilities.UseCompatibleTextRendering = True
        Me.Key_Abilities.UseTabStops = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label2.Location = New System.Drawing.Point(12, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 27)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Implements"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox1.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.HorizontalExtent = 19
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Wands", "Staffs", "Rods", "Orbs", "Tomes"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(222, 327)
        Me.CheckedListBox1.MultiColumn = True
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.ScrollAlwaysVisible = True
        Me.CheckedListBox1.Size = New System.Drawing.Size(469, 36)
        Me.CheckedListBox1.TabIndex = 94
        Me.CheckedListBox1.TabStop = False
        Me.CheckedListBox1.UseCompatibleTextRendering = True
        Me.CheckedListBox1.UseTabStops = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label3.Location = New System.Drawing.Point(12, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 27)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Armor Proficiencies"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox2.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.HorizontalExtent = 19
        Me.CheckedListBox2.HorizontalScrollbar = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Cloth", "Light Shields", "Heavy Shields", "Leather", "Hide", "Chainmail", "Scale", "Plate"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(222, 369)
        Me.CheckedListBox2.MultiColumn = True
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.ScrollAlwaysVisible = True
        Me.CheckedListBox2.Size = New System.Drawing.Size(469, 68)
        Me.CheckedListBox2.TabIndex = 96
        Me.CheckedListBox2.TabStop = False
        Me.CheckedListBox2.UseCompatibleTextRendering = True
        Me.CheckedListBox2.UseTabStops = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label4.Location = New System.Drawing.Point(12, 443)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 27)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Weapon Proficiencies"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.CheckedListBox3.CheckOnClick = True
        Me.CheckedListBox3.ColumnWidth = 180
        Me.CheckedListBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox3.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.HorizontalExtent = 19
        Me.CheckedListBox3.HorizontalScrollbar = True
        Me.CheckedListBox3.Items.AddRange(New Object() {"Simple melee", "Military melee", "Simple ranged", "Military ranged", "Military light blade", "Military heavy blade", "Longspear", "Longsword", "Scimitar", "Short sword", "Dagger", "Quarterstaff", "Shuriken", "Sling", "Club"})
        Me.CheckedListBox3.Location = New System.Drawing.Point(222, 443)
        Me.CheckedListBox3.MultiColumn = True
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.ScrollAlwaysVisible = True
        Me.CheckedListBox3.Size = New System.Drawing.Size(469, 100)
        Me.CheckedListBox3.TabIndex = 98
        Me.CheckedListBox3.TabStop = False
        Me.CheckedListBox3.UseCompatibleTextRendering = True
        Me.CheckedListBox3.UseTabStops = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label5.Location = New System.Drawing.Point(12, 549)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 27)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Bonus To Defense"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.CheckedListBox4.CheckOnClick = True
        Me.CheckedListBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox4.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.HorizontalExtent = 19
        Me.CheckedListBox4.HorizontalScrollbar = True
        Me.CheckedListBox4.Items.AddRange(New Object() {"Reflex", "Will", "Fortitude"})
        Me.CheckedListBox4.Location = New System.Drawing.Point(222, 549)
        Me.CheckedListBox4.MultiColumn = True
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.ScrollAlwaysVisible = True
        Me.CheckedListBox4.Size = New System.Drawing.Size(469, 36)
        Me.CheckedListBox4.TabIndex = 100
        Me.CheckedListBox4.TabStop = False
        Me.CheckedListBox4.UseCompatibleTextRendering = True
        Me.CheckedListBox4.UseTabStops = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(222, 591)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(469, 26)
        Me.TextBox1.TabIndex = 102
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(11, 590)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 27)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Hit points at 1st Level"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(222, 623)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(469, 26)
        Me.TextBox2.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Font = New System.Drawing.Font("BankGothic Lt BT", 9.5!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(11, 622)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 27)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Hit points per level Gained"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TextBox3.Location = New System.Drawing.Point(222, 655)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(469, 26)
        Me.TextBox3.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label9.Location = New System.Drawing.Point(11, 654)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 27)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Healing Surges"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label20.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(12, 687)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(204, 27)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Class Skills"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Skill_Bonus
        '
        Me.Skill_Bonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Skill_Bonus.CheckOnClick = True
        Me.Skill_Bonus.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.Skill_Bonus.FormattingEnabled = True
        Me.Skill_Bonus.Items.AddRange(New Object() {"Acrobatics", "Arcana", "Athletics", "Bluff", "Diplomacy", "Dungeoneering", "Endurance", "Heal", "History", "Insight", "Intimidate", "Nature", "Perception", "Religion", "Stealth", "Streetwise", "Thievery"})
        Me.Skill_Bonus.Location = New System.Drawing.Point(222, 687)
        Me.Skill_Bonus.MultiColumn = True
        Me.Skill_Bonus.Name = "Skill_Bonus"
        Me.Skill_Bonus.Size = New System.Drawing.Size(469, 100)
        Me.Skill_Bonus.Sorted = True
        Me.Skill_Bonus.TabIndex = 108
        Me.Skill_Bonus.TabStop = False
        Me.Skill_Bonus.UseCompatibleTextRendering = True
        Me.Skill_Bonus.UseTabStops = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(16, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 27)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Role"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Speed
        '
        Me.Speed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Speed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Speed.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Speed.FormattingEnabled = True
        Me.Speed.Items.AddRange(New Object() {"Striker", "Defender", "Leader", "Controller"})
        Me.Speed.Location = New System.Drawing.Point(222, 177)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(469, 21)
        Me.Speed.TabIndex = 110
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(16, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 27)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Power source"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Martial", "Arcane", "Divine", "Primal", "Psionic", "Shadow"})
        Me.ComboBox1.Location = New System.Drawing.Point(222, 204)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 112
        '
        'TextBox4
        '
        Me.TextBox4.AllowDrop = True
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TextBox4.Location = New System.Drawing.Point(396, 204)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(295, 76)
        Me.TextBox4.TabIndex = 113
        '
        'TextBox5
        '
        Me.TextBox5.AllowDrop = True
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextBox5.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TextBox5.Location = New System.Drawing.Point(222, 793)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(469, 83)
        Me.TextBox5.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(11, 793)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 27)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Creating"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox6
        '
        Me.TextBox6.AllowDrop = True
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextBox6.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TextBox6.Location = New System.Drawing.Point(222, 882)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(469, 83)
        Me.TextBox6.TabIndex = 117
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(11, 882)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 27)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Supplemental"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.AllowDrop = True
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextBox7.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TextBox7.Location = New System.Drawing.Point(222, 971)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox7.Size = New System.Drawing.Size(469, 83)
        Me.TextBox7.TabIndex = 119
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(11, 971)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 27)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Short Description"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClassID
        '
        Me.ClassID.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClassID.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassID.Location = New System.Drawing.Point(971, 84)
        Me.ClassID.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.ClassID.Name = "ClassID"
        Me.ClassID.Size = New System.Drawing.Size(134, 24)
        Me.ClassID.TabIndex = 121
        Me.ClassID.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label21.Font = New System.Drawing.Font("BankGothic Lt BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label21.Location = New System.Drawing.Point(804, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(161, 24)
        Me.Label21.TabIndex = 120
        Me.Label21.Text = "ClassID"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Traits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1177, 1054)
        Me.Controls.Add(Me.ClassID)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Speed)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Skill_Bonus)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckedListBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckedListBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Key_Abilities)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Class_Name)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.Write_To_File)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Class_Namelbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Traits"
        Me.Text = "Class Traits"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Class_Namelbl As System.Windows.Forms.Label
    Friend WithEvents Menu As System.Windows.Forms.ComboBox
    Friend WithEvents Write_To_File As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
    Friend WithEvents Class_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Key_Abilities As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox3 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox4 As System.Windows.Forms.CheckedListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Skill_Bonus As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Speed As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ClassID As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
