<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Powers
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Powers))
        Me.Powers_List = New System.Windows.Forms.ListBox()
        Me.Add_Power = New System.Windows.Forms.Button()
        Me.Delete_Power = New System.Windows.Forms.Button()
        Me.Power_Level = New System.Windows.Forms.ComboBox()
        Me.Power_Name = New System.Windows.Forms.TextBox()
        Me.Usage = New System.Windows.Forms.ComboBox()
        Me.Keywords = New System.Windows.Forms.TextBox()
        Me.Action_Type = New System.Windows.Forms.ComboBox()
        Me.Range = New System.Windows.Forms.ComboBox()
        Me.Attack_Modifier_1 = New System.Windows.Forms.TextBox()
        Me.Target = New System.Windows.Forms.TextBox()
        Me.Attack_1 = New System.Windows.Forms.ComboBox()
        Me.Attack_2 = New System.Windows.Forms.ComboBox()
        Me.Hit = New System.Windows.Forms.TextBox()
        Me.Effect = New System.Windows.Forms.TextBox()
        Me.Special = New System.Windows.Forms.TextBox()
        Me.Miss = New System.Windows.Forms.TextBox()
        Me.Range_Modifier_1 = New System.Windows.Forms.TextBox()
        Me.Range_Modifier_2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.Write_To_File = New System.Windows.Forms.Button()
        Me.PowerID = New System.Windows.Forms.NumericUpDown()
        Me.Requirement = New System.Windows.Forms.TextBox()
        Me.Menu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Requirement_Lbl = New System.Windows.Forms.Label()
        Me.Utility_Power = New System.Windows.Forms.RadioButton()
        Me.Attack_Power = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.squares = New System.Windows.Forms.Label()
        Me.within = New System.Windows.Forms.Label()
        Me.VS = New System.Windows.Forms.Label()
        Me.Plus1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Miss_Lbl = New System.Windows.Forms.Label()
        Me.Special_Lbl = New System.Windows.Forms.Label()
        Me.Effect_Lbl = New System.Windows.Forms.Label()
        Me.Hit_Lbl = New System.Windows.Forms.Label()
        Me.Attack_Lbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Class_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        CType(Me.PowerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Powers_List
        '
        Me.Powers_List.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Powers_List.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Powers_List.ForeColor = System.Drawing.Color.Black
        Me.Powers_List.FormattingEnabled = True
        Me.Powers_List.ItemHeight = 17
        Me.Powers_List.Items.AddRange(New Object() {"New Power"})
        Me.Powers_List.Location = New System.Drawing.Point(719, 160)
        Me.Powers_List.Name = "Powers_List"
        Me.Powers_List.ScrollAlwaysVisible = True
        Me.Powers_List.Size = New System.Drawing.Size(454, 701)
        Me.Powers_List.TabIndex = 20
        '
        'Add_Power
        '
        Me.Add_Power.Font = New System.Drawing.Font("BankGothic Lt BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Power.Location = New System.Drawing.Point(719, 868)
        Me.Add_Power.Name = "Add_Power"
        Me.Add_Power.Size = New System.Drawing.Size(232, 24)
        Me.Add_Power.TabIndex = 21
        Me.Add_Power.Text = "Add Power"
        Me.Add_Power.UseVisualStyleBackColor = True
        '
        'Delete_Power
        '
        Me.Delete_Power.Font = New System.Drawing.Font("BankGothic Lt BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Power.Location = New System.Drawing.Point(952, 868)
        Me.Delete_Power.Name = "Delete_Power"
        Me.Delete_Power.Size = New System.Drawing.Size(221, 24)
        Me.Delete_Power.TabIndex = 22
        Me.Delete_Power.Text = "Delete Power"
        Me.Delete_Power.UseVisualStyleBackColor = True
        '
        'Power_Level
        '
        Me.Power_Level.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Power_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Power_Level.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Power_Level.FormattingEnabled = True
        Me.Power_Level.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.Power_Level.Location = New System.Drawing.Point(179, 124)
        Me.Power_Level.Name = "Power_Level"
        Me.Power_Level.Size = New System.Drawing.Size(469, 26)
        Me.Power_Level.TabIndex = 1
        '
        'Power_Name
        '
        Me.Power_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Power_Name.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Power_Name.Location = New System.Drawing.Point(179, 161)
        Me.Power_Name.Name = "Power_Name"
        Me.Power_Name.Size = New System.Drawing.Size(469, 26)
        Me.Power_Name.TabIndex = 2
        '
        'Usage
        '
        Me.Usage.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Usage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Usage.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Usage.FormattingEnabled = True
        Me.Usage.Items.AddRange(New Object() {"At-Will", "Encounter", "Daily"})
        Me.Usage.Location = New System.Drawing.Point(179, 200)
        Me.Usage.Name = "Usage"
        Me.Usage.Size = New System.Drawing.Size(469, 26)
        Me.Usage.TabIndex = 3
        '
        'Keywords
        '
        Me.Keywords.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Keywords.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Keywords.Location = New System.Drawing.Point(179, 326)
        Me.Keywords.Name = "Keywords"
        Me.Keywords.Size = New System.Drawing.Size(469, 26)
        Me.Keywords.TabIndex = 5
        '
        'Action_Type
        '
        Me.Action_Type.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Action_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Action_Type.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Action_Type.FormattingEnabled = True
        Me.Action_Type.Items.AddRange(New Object() {"Standard Action", "Minor Action", "Move Action", "Free Action", "Opportunity Action", "Immediate Reaction", "Immediate Interrupt"})
        Me.Action_Type.Location = New System.Drawing.Point(179, 365)
        Me.Action_Type.Name = "Action_Type"
        Me.Action_Type.Size = New System.Drawing.Size(469, 26)
        Me.Action_Type.TabIndex = 6
        '
        'Range
        '
        Me.Range.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Range.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Range.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Range.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Range.FormattingEnabled = True
        Me.Range.Items.AddRange(New Object() {"Melee", "Melee Weapon", "Ranged", "Area Burst", "Close Burst", "Close Blast", "Personal", "Line"})
        Me.Range.Location = New System.Drawing.Point(179, 404)
        Me.Range.Name = "Range"
        Me.Range.Size = New System.Drawing.Size(194, 26)
        Me.Range.TabIndex = 7
        '
        'Attack_Modifier_1
        '
        Me.Attack_Modifier_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Attack_Modifier_1.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Attack_Modifier_1.Location = New System.Drawing.Point(348, 508)
        Me.Attack_Modifier_1.Name = "Attack_Modifier_1"
        Me.Attack_Modifier_1.Size = New System.Drawing.Size(37, 26)
        Me.Attack_Modifier_1.TabIndex = 13
        '
        'Target
        '
        Me.Target.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Target.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Target.Location = New System.Drawing.Point(179, 472)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(469, 26)
        Me.Target.TabIndex = 11
        '
        'Attack_1
        '
        Me.Attack_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Attack_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Attack_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Attack_1.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Attack_1.FormattingEnabled = True
        Me.Attack_1.Items.AddRange(New Object() {"Strength", "Charisma", "Constitution", "Wisdom", "Intellegence", "Dexterity"})
        Me.Attack_1.Location = New System.Drawing.Point(179, 508)
        Me.Attack_1.Name = "Attack_1"
        Me.Attack_1.Size = New System.Drawing.Size(133, 26)
        Me.Attack_1.TabIndex = 12
        '
        'Attack_2
        '
        Me.Attack_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Attack_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Attack_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Attack_2.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Attack_2.FormattingEnabled = True
        Me.Attack_2.Items.AddRange(New Object() {"AC", "Fortitude", "Reflex", "Will"})
        Me.Attack_2.Location = New System.Drawing.Point(475, 508)
        Me.Attack_2.Name = "Attack_2"
        Me.Attack_2.Size = New System.Drawing.Size(173, 26)
        Me.Attack_2.TabIndex = 14
        '
        'Hit
        '
        Me.Hit.AllowDrop = True
        Me.Hit.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Hit.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Hit.Location = New System.Drawing.Point(179, 542)
        Me.Hit.Multiline = True
        Me.Hit.Name = "Hit"
        Me.Hit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Hit.Size = New System.Drawing.Size(469, 83)
        Me.Hit.TabIndex = 16
        '
        'Effect
        '
        Me.Effect.AllowDrop = True
        Me.Effect.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Effect.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Effect.Location = New System.Drawing.Point(179, 631)
        Me.Effect.Multiline = True
        Me.Effect.Name = "Effect"
        Me.Effect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Effect.Size = New System.Drawing.Size(469, 83)
        Me.Effect.TabIndex = 17
        '
        'Special
        '
        Me.Special.AllowDrop = True
        Me.Special.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Special.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Special.Location = New System.Drawing.Point(179, 720)
        Me.Special.Multiline = True
        Me.Special.Name = "Special"
        Me.Special.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Special.Size = New System.Drawing.Size(469, 83)
        Me.Special.TabIndex = 18
        '
        'Miss
        '
        Me.Miss.AllowDrop = True
        Me.Miss.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Miss.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Miss.Location = New System.Drawing.Point(179, 809)
        Me.Miss.Multiline = True
        Me.Miss.Name = "Miss"
        Me.Miss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Miss.Size = New System.Drawing.Size(469, 83)
        Me.Miss.TabIndex = 19
        '
        'Range_Modifier_1
        '
        Me.Range_Modifier_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Range_Modifier_1.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Range_Modifier_1.Location = New System.Drawing.Point(379, 404)
        Me.Range_Modifier_1.Name = "Range_Modifier_1"
        Me.Range_Modifier_1.Size = New System.Drawing.Size(37, 26)
        Me.Range_Modifier_1.TabIndex = 8
        '
        'Range_Modifier_2
        '
        Me.Range_Modifier_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Range_Modifier_2.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Range_Modifier_2.Location = New System.Drawing.Point(511, 404)
        Me.Range_Modifier_2.Name = "Range_Modifier_2"
        Me.Range_Modifier_2.Size = New System.Drawing.Size(37, 26)
        Me.Range_Modifier_2.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Exit_Btn
        '
        Me.Exit_Btn.BackColor = System.Drawing.Color.White
        Me.Exit_Btn.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(973, 26)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(186, 32)
        Me.Exit_Btn.TabIndex = 38
        Me.Exit_Btn.Text = "Quit to Menu"
        Me.Exit_Btn.UseVisualStyleBackColor = False
        '
        'Write_To_File
        '
        Me.Write_To_File.BackColor = System.Drawing.Color.White
        Me.Write_To_File.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Write_To_File.Location = New System.Drawing.Point(748, 26)
        Me.Write_To_File.Name = "Write_To_File"
        Me.Write_To_File.Size = New System.Drawing.Size(185, 32)
        Me.Write_To_File.TabIndex = 39
        Me.Write_To_File.Text = "Write To File"
        Me.Write_To_File.UseVisualStyleBackColor = False
        '
        'PowerID
        '
        Me.PowerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PowerID.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerID.Location = New System.Drawing.Point(952, 86)
        Me.PowerID.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.PowerID.Name = "PowerID"
        Me.PowerID.Size = New System.Drawing.Size(134, 24)
        Me.PowerID.TabIndex = 42
        Me.PowerID.Value = New Decimal(New Integer() {50000, 0, 0, 0})
        '
        'Requirement
        '
        Me.Requirement.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Requirement.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Requirement.Location = New System.Drawing.Point(179, 437)
        Me.Requirement.Name = "Requirement"
        Me.Requirement.Size = New System.Drawing.Size(469, 26)
        Me.Requirement.TabIndex = 48
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Menu.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.White
        Me.Menu.FormattingEnabled = True
        Me.Menu.Items.AddRange(New Object() {"Traits", "Features", "Powers", "Feats"})
        Me.Menu.Location = New System.Drawing.Point(475, 18)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(245, 51)
        Me.Menu.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("BankGothic Lt BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(860, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 34)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Power List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Requirement_Lbl
        '
        Me.Requirement_Lbl.BackColor = System.Drawing.Color.MidnightBlue
        Me.Requirement_Lbl.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirement_Lbl.ForeColor = System.Drawing.Color.White
        Me.Requirement_Lbl.Image = CType(resources.GetObject("Requirement_Lbl.Image"), System.Drawing.Image)
        Me.Requirement_Lbl.Location = New System.Drawing.Point(12, 437)
        Me.Requirement_Lbl.Name = "Requirement_Lbl"
        Me.Requirement_Lbl.Size = New System.Drawing.Size(161, 27)
        Me.Requirement_Lbl.TabIndex = 47
        Me.Requirement_Lbl.Text = "Requirement"
        Me.Requirement_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Utility_Power
        '
        Me.Utility_Power.AutoSize = True
        Me.Utility_Power.BackColor = System.Drawing.Color.Transparent
        Me.Utility_Power.BackgroundImage = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Utility_Power.Font = New System.Drawing.Font("BankGothic Lt BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Utility_Power.ForeColor = System.Drawing.Color.White
        Me.Utility_Power.Location = New System.Drawing.Point(311, 86)
        Me.Utility_Power.Name = "Utility_Power"
        Me.Utility_Power.Size = New System.Drawing.Size(225, 32)
        Me.Utility_Power.TabIndex = 46
        Me.Utility_Power.TabStop = True
        Me.Utility_Power.Text = "Utility Power"
        Me.Utility_Power.UseVisualStyleBackColor = False
        '
        'Attack_Power
        '
        Me.Attack_Power.AutoSize = True
        Me.Attack_Power.BackColor = System.Drawing.Color.Transparent
        Me.Attack_Power.BackgroundImage = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Attack_Power.Font = New System.Drawing.Font("BankGothic Lt BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Attack_Power.ForeColor = System.Drawing.Color.White
        Me.Attack_Power.Location = New System.Drawing.Point(61, 86)
        Me.Attack_Power.Name = "Attack_Power"
        Me.Attack_Power.Size = New System.Drawing.Size(230, 32)
        Me.Attack_Power.TabIndex = 45
        Me.Attack_Power.TabStop = True
        Me.Attack_Power.Text = "Attack Power"
        Me.Attack_Power.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label20.Font = New System.Drawing.Font("BankGothic Lt BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label20.Location = New System.Drawing.Point(776, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(161, 24)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "PowerID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'squares
        '
        Me.squares.AutoSize = True
        Me.squares.BackColor = System.Drawing.Color.LightSlateGray
        Me.squares.Font = New System.Drawing.Font("BankGothic Lt BT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.squares.ForeColor = System.Drawing.Color.White
        Me.squares.Image = CType(resources.GetObject("squares.Image"), System.Drawing.Image)
        Me.squares.Location = New System.Drawing.Point(561, 408)
        Me.squares.Name = "squares"
        Me.squares.Size = New System.Drawing.Size(87, 19)
        Me.squares.TabIndex = 0
        Me.squares.Text = "squares"
        '
        'within
        '
        Me.within.AutoSize = True
        Me.within.BackColor = System.Drawing.Color.LightSlateGray
        Me.within.Font = New System.Drawing.Font("BankGothic Lt BT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.within.ForeColor = System.Drawing.Color.White
        Me.within.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.within.Location = New System.Drawing.Point(426, 408)
        Me.within.Name = "within"
        Me.within.Size = New System.Drawing.Size(65, 19)
        Me.within.TabIndex = 0
        Me.within.Text = "within"
        '
        'VS
        '
        Me.VS.AutoSize = True
        Me.VS.BackColor = System.Drawing.Color.LightSlateGray
        Me.VS.Font = New System.Drawing.Font("BankGothic Lt BT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VS.ForeColor = System.Drawing.Color.White
        Me.VS.Image = CType(resources.GetObject("VS.Image"), System.Drawing.Image)
        Me.VS.Location = New System.Drawing.Point(407, 513)
        Me.VS.Name = "VS"
        Me.VS.Size = New System.Drawing.Size(42, 19)
        Me.VS.TabIndex = 0
        Me.VS.Text = "VS."
        '
        'Plus1
        '
        Me.Plus1.AutoSize = True
        Me.Plus1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Plus1.Font = New System.Drawing.Font("BankGothic Lt BT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus1.ForeColor = System.Drawing.Color.White
        Me.Plus1.Image = CType(resources.GetObject("Plus1.Image"), System.Drawing.Image)
        Me.Plus1.Location = New System.Drawing.Point(318, 512)
        Me.Plus1.Name = "Plus1"
        Me.Plus1.Size = New System.Drawing.Size(24, 19)
        Me.Plus1.TabIndex = 33
        Me.Plus1.Text = "+"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(12, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(161, 27)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Power Level"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Miss_Lbl
        '
        Me.Miss_Lbl.BackColor = System.Drawing.Color.MidnightBlue
        Me.Miss_Lbl.Font = New System.Drawing.Font("BankGothic Lt BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Miss_Lbl.ForeColor = System.Drawing.Color.White
        Me.Miss_Lbl.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Miss_Lbl.Location = New System.Drawing.Point(12, 809)
        Me.Miss_Lbl.Name = "Miss_Lbl"
        Me.Miss_Lbl.Size = New System.Drawing.Size(161, 27)
        Me.Miss_Lbl.TabIndex = 0
        Me.Miss_Lbl.Text = "Miss"
        Me.Miss_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Special_Lbl
        '
        Me.Special_Lbl.BackColor = System.Drawing.Color.MidnightBlue
        Me.Special_Lbl.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Special_Lbl.ForeColor = System.Drawing.Color.White
        Me.Special_Lbl.Image = CType(resources.GetObject("Special_Lbl.Image"), System.Drawing.Image)
        Me.Special_Lbl.Location = New System.Drawing.Point(12, 720)
        Me.Special_Lbl.Name = "Special_Lbl"
        Me.Special_Lbl.Size = New System.Drawing.Size(161, 27)
        Me.Special_Lbl.TabIndex = 0
        Me.Special_Lbl.Text = "Special"
        Me.Special_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Effect_Lbl
        '
        Me.Effect_Lbl.BackColor = System.Drawing.Color.MidnightBlue
        Me.Effect_Lbl.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Effect_Lbl.ForeColor = System.Drawing.Color.White
        Me.Effect_Lbl.Image = CType(resources.GetObject("Effect_Lbl.Image"), System.Drawing.Image)
        Me.Effect_Lbl.Location = New System.Drawing.Point(12, 631)
        Me.Effect_Lbl.Name = "Effect_Lbl"
        Me.Effect_Lbl.Size = New System.Drawing.Size(161, 27)
        Me.Effect_Lbl.TabIndex = 0
        Me.Effect_Lbl.Text = "Effect"
        Me.Effect_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Hit_Lbl
        '
        Me.Hit_Lbl.BackColor = System.Drawing.Color.MidnightBlue
        Me.Hit_Lbl.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hit_Lbl.ForeColor = System.Drawing.Color.White
        Me.Hit_Lbl.Image = CType(resources.GetObject("Hit_Lbl.Image"), System.Drawing.Image)
        Me.Hit_Lbl.Location = New System.Drawing.Point(12, 544)
        Me.Hit_Lbl.Name = "Hit_Lbl"
        Me.Hit_Lbl.Size = New System.Drawing.Size(161, 27)
        Me.Hit_Lbl.TabIndex = 0
        Me.Hit_Lbl.Text = "Hit"
        Me.Hit_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Attack_Lbl
        '
        Me.Attack_Lbl.BackColor = System.Drawing.Color.MidnightBlue
        Me.Attack_Lbl.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Attack_Lbl.ForeColor = System.Drawing.Color.White
        Me.Attack_Lbl.Image = CType(resources.GetObject("Attack_Lbl.Image"), System.Drawing.Image)
        Me.Attack_Lbl.Location = New System.Drawing.Point(12, 508)
        Me.Attack_Lbl.Name = "Attack_Lbl"
        Me.Attack_Lbl.Size = New System.Drawing.Size(161, 27)
        Me.Attack_Lbl.TabIndex = 0
        Me.Attack_Lbl.Text = "Attack"
        Me.Attack_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(12, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 27)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Target"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(12, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 27)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Range"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(12, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 27)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Action Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(12, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Keywords"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label5.Location = New System.Drawing.Point(12, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Usage"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label4.Location = New System.Drawing.Point(12, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Power Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Class_Name
        '
        Me.Class_Name.AutoSize = True
        Me.Class_Name.BackColor = System.Drawing.Color.Transparent
        Me.Class_Name.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Class_Name.ForeColor = System.Drawing.Color.White
        Me.Class_Name.Image = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Class_Name.Location = New System.Drawing.Point(117, 21)
        Me.Class_Name.Name = "Class_Name"
        Me.Class_Name.Size = New System.Drawing.Size(309, 43)
        Me.Class_Name.TabIndex = 0
        Me.Class_Name.Text = "(Class Name)"
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
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CCB"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.CustomClassBuilder.My.Resources.Resources.background1
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1232, 902)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(12, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Flavour"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Description
        '
        Me.Description.AllowDrop = True
        Me.Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Description.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.Description.Location = New System.Drawing.Point(179, 237)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Description.Size = New System.Drawing.Size(469, 83)
        Me.Description.TabIndex = 4
        '
        'Powers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1232, 902)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Requirement)
        Me.Controls.Add(Me.Requirement_Lbl)
        Me.Controls.Add(Me.Utility_Power)
        Me.Controls.Add(Me.Attack_Power)
        Me.Controls.Add(Me.PowerID)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Write_To_File)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.squares)
        Me.Controls.Add(Me.within)
        Me.Controls.Add(Me.Range_Modifier_2)
        Me.Controls.Add(Me.Range_Modifier_1)
        Me.Controls.Add(Me.Miss)
        Me.Controls.Add(Me.Special)
        Me.Controls.Add(Me.Effect)
        Me.Controls.Add(Me.Hit)
        Me.Controls.Add(Me.Attack_2)
        Me.Controls.Add(Me.VS)
        Me.Controls.Add(Me.Plus1)
        Me.Controls.Add(Me.Attack_1)
        Me.Controls.Add(Me.Target)
        Me.Controls.Add(Me.Attack_Modifier_1)
        Me.Controls.Add(Me.Range)
        Me.Controls.Add(Me.Action_Type)
        Me.Controls.Add(Me.Keywords)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Usage)
        Me.Controls.Add(Me.Power_Name)
        Me.Controls.Add(Me.Power_Level)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Miss_Lbl)
        Me.Controls.Add(Me.Special_Lbl)
        Me.Controls.Add(Me.Effect_Lbl)
        Me.Controls.Add(Me.Hit_Lbl)
        Me.Controls.Add(Me.Attack_Lbl)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Delete_Power)
        Me.Controls.Add(Me.Add_Power)
        Me.Controls.Add(Me.Powers_List)
        Me.Controls.Add(Me.Class_Name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Powers"
        Me.Text = "Powers"
        CType(Me.PowerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Class_Name As System.Windows.Forms.Label
    Friend WithEvents Powers_List As System.Windows.Forms.ListBox
    Friend WithEvents Add_Power As System.Windows.Forms.Button
    Friend WithEvents Delete_Power As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Attack_Lbl As System.Windows.Forms.Label
    Friend WithEvents Hit_Lbl As System.Windows.Forms.Label
    Friend WithEvents Effect_Lbl As System.Windows.Forms.Label
    Friend WithEvents Special_Lbl As System.Windows.Forms.Label
    Friend WithEvents Miss_Lbl As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Power_Level As System.Windows.Forms.ComboBox
    Friend WithEvents Power_Name As System.Windows.Forms.TextBox
    Friend WithEvents Usage As System.Windows.Forms.ComboBox
    Friend WithEvents Keywords As System.Windows.Forms.TextBox
    Friend WithEvents Action_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Range As System.Windows.Forms.ComboBox
    Friend WithEvents Attack_Modifier_1 As System.Windows.Forms.TextBox
    Friend WithEvents Target As System.Windows.Forms.TextBox
    Friend WithEvents Attack_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Plus1 As System.Windows.Forms.Label
    Friend WithEvents VS As System.Windows.Forms.Label
    Friend WithEvents Attack_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Hit As System.Windows.Forms.TextBox
    Friend WithEvents Effect As System.Windows.Forms.TextBox
    Friend WithEvents Special As System.Windows.Forms.TextBox
    Friend WithEvents Miss As System.Windows.Forms.TextBox
    Friend WithEvents Range_Modifier_1 As System.Windows.Forms.TextBox
    Friend WithEvents Range_Modifier_2 As System.Windows.Forms.TextBox
    Friend WithEvents within As System.Windows.Forms.Label
    Friend WithEvents squares As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
    Friend WithEvents Write_To_File As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PowerID As System.Windows.Forms.NumericUpDown
    Friend WithEvents Attack_Power As System.Windows.Forms.RadioButton
    Friend WithEvents Utility_Power As System.Windows.Forms.RadioButton
    Friend WithEvents Requirement As System.Windows.Forms.TextBox
    Friend WithEvents Requirement_Lbl As System.Windows.Forms.Label
    Friend WithEvents Menu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.TextBox

End Class
