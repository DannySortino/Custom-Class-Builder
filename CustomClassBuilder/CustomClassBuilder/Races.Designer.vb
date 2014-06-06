<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Races
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Races))
        Me.Write_To_File = New System.Windows.Forms.Button()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.Race_Namelbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Race_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Flavor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Speed = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Size = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Characteristics = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Physical_Qualities = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Vision = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Average_Height1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Average_Height2 = New System.Windows.Forms.TextBox()
        Me.Average_Height3 = New System.Windows.Forms.TextBox()
        Me.Average_Height4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Average_Weight1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Average_Weight2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Ability_Score_Bonus = New System.Windows.Forms.CheckedListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Skill_Bonus = New System.Windows.Forms.CheckedListBox()
        Me.Male_Names = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Female_Names = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Short_Description = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.RaceID = New System.Windows.Forms.NumericUpDown()
        Me.Playing = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaceID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Write_To_File
        '
        Me.Write_To_File.BackColor = System.Drawing.Color.White
        Me.Write_To_File.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Write_To_File.Location = New System.Drawing.Point(414, 29)
        Me.Write_To_File.Name = "Write_To_File"
        Me.Write_To_File.Size = New System.Drawing.Size(185, 32)
        Me.Write_To_File.TabIndex = 56
        Me.Write_To_File.Text = "Write To File"
        Me.Write_To_File.UseVisualStyleBackColor = False
        '
        'Exit_Btn
        '
        Me.Exit_Btn.BackColor = System.Drawing.Color.White
        Me.Exit_Btn.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(628, 29)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(197, 32)
        Me.Exit_Btn.TabIndex = 55
        Me.Exit_Btn.Text = "Quit to Menu"
        Me.Exit_Btn.UseVisualStyleBackColor = False
        '
        'Race_Namelbl
        '
        Me.Race_Namelbl.BackColor = System.Drawing.Color.Transparent
        Me.Race_Namelbl.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Race_Namelbl.ForeColor = System.Drawing.Color.White
        Me.Race_Namelbl.Image = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Race_Namelbl.Location = New System.Drawing.Point(113, 18)
        Me.Race_Namelbl.Name = "Race_Namelbl"
        Me.Race_Namelbl.Size = New System.Drawing.Size(375, 43)
        Me.Race_Namelbl.TabIndex = 54
        Me.Race_Namelbl.Text = "(Race Name)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 43)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "CCB"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.CustomClassBuilder.My.Resources.Resources.background1
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(837, 969)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'Race_Name
        '
        Me.Race_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Race_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Race_Name.Location = New System.Drawing.Point(216, 111)
        Me.Race_Name.Name = "Race_Name"
        Me.Race_Name.Size = New System.Drawing.Size(609, 20)
        Me.Race_Name.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label4.Location = New System.Drawing.Point(25, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 27)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Race Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Flavor
        '
        Me.Flavor.AllowDrop = True
        Me.Flavor.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Flavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Flavor.Location = New System.Drawing.Point(216, 142)
        Me.Flavor.Multiline = True
        Me.Flavor.Name = "Flavor"
        Me.Flavor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Flavor.Size = New System.Drawing.Size(609, 73)
        Me.Flavor.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(25, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 27)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Flavor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Speed
        '
        Me.Speed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Speed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Speed.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Speed.FormattingEnabled = True
        Me.Speed.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Speed.Location = New System.Drawing.Point(216, 251)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(609, 21)
        Me.Speed.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(25, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 27)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Speed"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Size
        '
        Me.Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Size.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Size.FormattingEnabled = True
        Me.Size.Items.AddRange(New Object() {"Tiny", "Small", "Medium", "Large"})
        Me.Size.Location = New System.Drawing.Point(216, 221)
        Me.Size.Name = "Size"
        Me.Size.Size = New System.Drawing.Size(609, 21)
        Me.Size.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(25, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 27)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Size"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Characteristics
        '
        Me.Characteristics.AllowDrop = True
        Me.Characteristics.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Characteristics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Characteristics.Location = New System.Drawing.Point(216, 285)
        Me.Characteristics.Multiline = True
        Me.Characteristics.Name = "Characteristics"
        Me.Characteristics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Characteristics.Size = New System.Drawing.Size(609, 46)
        Me.Characteristics.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Font = New System.Drawing.Font("BankGothic Lt BT", 13.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(25, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 27)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Characteristics"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Physical_Qualities
        '
        Me.Physical_Qualities.AllowDrop = True
        Me.Physical_Qualities.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Physical_Qualities.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Physical_Qualities.Location = New System.Drawing.Point(216, 341)
        Me.Physical_Qualities.Multiline = True
        Me.Physical_Qualities.Name = "Physical_Qualities"
        Me.Physical_Qualities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Physical_Qualities.Size = New System.Drawing.Size(609, 93)
        Me.Physical_Qualities.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Font = New System.Drawing.Font("BankGothic Lt BT", 12.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(25, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 27)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Physical Qualities"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Vision
        '
        Me.Vision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Vision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Vision.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Vision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Vision.FormattingEnabled = True
        Me.Vision.Items.AddRange(New Object() {"Low-light", "Normal", "True", "Blind"})
        Me.Vision.Location = New System.Drawing.Point(216, 584)
        Me.Vision.Name = "Vision"
        Me.Vision.Size = New System.Drawing.Size(609, 21)
        Me.Vision.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(25, 581)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 27)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Vision"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Average_Height1
        '
        Me.Average_Height1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Average_Height1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Average_Height1.Location = New System.Drawing.Point(216, 616)
        Me.Average_Height1.Name = "Average_Height1"
        Me.Average_Height1.Size = New System.Drawing.Size(86, 20)
        Me.Average_Height1.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label8.Location = New System.Drawing.Point(25, 611)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 27)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Average Height"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(490, 614)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 27)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "to"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Average_Height2
        '
        Me.Average_Height2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Average_Height2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Average_Height2.Location = New System.Drawing.Point(351, 616)
        Me.Average_Height2.Name = "Average_Height2"
        Me.Average_Height2.Size = New System.Drawing.Size(86, 20)
        Me.Average_Height2.TabIndex = 75
        '
        'Average_Height3
        '
        Me.Average_Height3.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Average_Height3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Average_Height3.Location = New System.Drawing.Point(560, 618)
        Me.Average_Height3.Name = "Average_Height3"
        Me.Average_Height3.Size = New System.Drawing.Size(86, 20)
        Me.Average_Height3.TabIndex = 76
        '
        'Average_Height4
        '
        Me.Average_Height4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Average_Height4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Average_Height4.Location = New System.Drawing.Point(687, 618)
        Me.Average_Height4.Name = "Average_Height4"
        Me.Average_Height4.Size = New System.Drawing.Size(92, 20)
        Me.Average_Height4.TabIndex = 77
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(302, 614)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 27)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "'"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(437, 613)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 27)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = """"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(785, 614)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 27)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = """"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(645, 613)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 27)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "'"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Average_Weight1
        '
        Me.Average_Weight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Average_Weight1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Average_Weight1.Location = New System.Drawing.Point(216, 650)
        Me.Average_Weight1.Name = "Average_Weight1"
        Me.Average_Weight1.Size = New System.Drawing.Size(221, 20)
        Me.Average_Weight1.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label15.Location = New System.Drawing.Point(25, 643)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 27)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Average Weight"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(490, 645)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 27)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "to"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Average_Weight2
        '
        Me.Average_Weight2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Average_Weight2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Average_Weight2.Location = New System.Drawing.Point(560, 650)
        Me.Average_Weight2.Name = "Average_Weight2"
        Me.Average_Weight2.Size = New System.Drawing.Size(219, 20)
        Me.Average_Weight2.TabIndex = 85
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label17.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(437, 645)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 27)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "lb"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label18.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(785, 645)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 27)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "lb"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label19.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label19.Location = New System.Drawing.Point(24, 676)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(185, 27)
        Me.Label19.TabIndex = 88
        Me.Label19.Text = "Ability Score Bonus"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ability_Score_Bonus
        '
        Me.Ability_Score_Bonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Ability_Score_Bonus.CheckOnClick = True
        Me.Ability_Score_Bonus.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.Ability_Score_Bonus.FormattingEnabled = True
        Me.Ability_Score_Bonus.HorizontalExtent = 19
        Me.Ability_Score_Bonus.HorizontalScrollbar = True
        Me.Ability_Score_Bonus.Items.AddRange(New Object() {"Strength", "Charisma", "Constitution", "Wisdom", "Intellegence", "Dexterity"})
        Me.Ability_Score_Bonus.Location = New System.Drawing.Point(215, 679)
        Me.Ability_Score_Bonus.MultiColumn = True
        Me.Ability_Score_Bonus.Name = "Ability_Score_Bonus"
        Me.Ability_Score_Bonus.ScrollAlwaysVisible = True
        Me.Ability_Score_Bonus.Size = New System.Drawing.Size(610, 36)
        Me.Ability_Score_Bonus.TabIndex = 90
        Me.Ability_Score_Bonus.TabStop = False
        Me.Ability_Score_Bonus.UseCompatibleTextRendering = True
        Me.Ability_Score_Bonus.UseTabStops = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label20.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(24, 729)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(185, 27)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "Skill Bonus"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Skill_Bonus
        '
        Me.Skill_Bonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Skill_Bonus.CheckOnClick = True
        Me.Skill_Bonus.Font = New System.Drawing.Font("BankGothic Lt BT", 9.35!)
        Me.Skill_Bonus.FormattingEnabled = True
        Me.Skill_Bonus.Items.AddRange(New Object() {"Acrobatics", "Arcana", "Athletics", "Bluff", "Diplomacy", "Dungeoneering", "Endurance", "Heal", "History", "Insight", "Intimidate", "Nature", "Perception", "Religion", "Stealth", "Streetwise", "Thievery"})
        Me.Skill_Bonus.Location = New System.Drawing.Point(215, 729)
        Me.Skill_Bonus.MultiColumn = True
        Me.Skill_Bonus.Name = "Skill_Bonus"
        Me.Skill_Bonus.Size = New System.Drawing.Size(610, 68)
        Me.Skill_Bonus.Sorted = True
        Me.Skill_Bonus.TabIndex = 92
        Me.Skill_Bonus.TabStop = False
        Me.Skill_Bonus.UseCompatibleTextRendering = True
        Me.Skill_Bonus.UseTabStops = False
        '
        'Male_Names
        '
        Me.Male_Names.AllowDrop = True
        Me.Male_Names.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Male_Names.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Male_Names.Location = New System.Drawing.Point(217, 807)
        Me.Male_Names.Multiline = True
        Me.Male_Names.Name = "Male_Names"
        Me.Male_Names.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Male_Names.Size = New System.Drawing.Size(609, 46)
        Me.Male_Names.TabIndex = 94
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label21.Font = New System.Drawing.Font("BankGothic Lt BT", 13.25!)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.Location = New System.Drawing.Point(26, 803)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(185, 27)
        Me.Label21.TabIndex = 93
        Me.Label21.Text = "Male Names"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Female_Names
        '
        Me.Female_Names.AllowDrop = True
        Me.Female_Names.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Female_Names.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Female_Names.Location = New System.Drawing.Point(217, 859)
        Me.Female_Names.Multiline = True
        Me.Female_Names.Name = "Female_Names"
        Me.Female_Names.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Female_Names.Size = New System.Drawing.Size(609, 46)
        Me.Female_Names.TabIndex = 96
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label22.Font = New System.Drawing.Font("BankGothic Lt BT", 13.25!)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(26, 855)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(185, 27)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "Female Names"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Short_Description
        '
        Me.Short_Description.AllowDrop = True
        Me.Short_Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Short_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Short_Description.Location = New System.Drawing.Point(217, 911)
        Me.Short_Description.Multiline = True
        Me.Short_Description.Name = "Short_Description"
        Me.Short_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Short_Description.Size = New System.Drawing.Size(609, 46)
        Me.Short_Description.TabIndex = 98
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label23.Font = New System.Drawing.Font("BankGothic Lt BT", 12.25!)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.Location = New System.Drawing.Point(26, 907)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(185, 27)
        Me.Label23.TabIndex = 97
        Me.Label23.Text = "Short Description"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label24.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Image = Global.CustomClassBuilder.My.Resources.Resources.button
        Me.Label24.Location = New System.Drawing.Point(212, 81)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(185, 27)
        Me.Label24.TabIndex = 99
        Me.Label24.Text = "RaceID"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RaceID
        '
        Me.RaceID.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.RaceID.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!)
        Me.RaceID.Location = New System.Drawing.Point(409, 81)
        Me.RaceID.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.RaceID.Name = "RaceID"
        Me.RaceID.Size = New System.Drawing.Size(120, 27)
        Me.RaceID.TabIndex = 100
        Me.RaceID.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Playing
        '
        Me.Playing.AllowDrop = True
        Me.Playing.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Playing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Playing.Location = New System.Drawing.Point(215, 440)
        Me.Playing.Multiline = True
        Me.Playing.Name = "Playing"
        Me.Playing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Playing.Size = New System.Drawing.Size(609, 138)
        Me.Playing.TabIndex = 102
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label25.Font = New System.Drawing.Font("BankGothic Lt BT", 12.25!)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.Location = New System.Drawing.Point(24, 436)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(185, 27)
        Me.Label25.TabIndex = 101
        Me.Label25.Text = "Playing"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Races
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(837, 969)
        Me.Controls.Add(Me.Write_To_File)
        Me.Controls.Add(Me.Race_Namelbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.Race_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Flavor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Speed)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Size)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Characteristics)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Physical_Qualities)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Vision)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Average_Height1)
        Me.Controls.Add(Me.Average_Height2)
        Me.Controls.Add(Me.Average_Height3)
        Me.Controls.Add(Me.Average_Height4)
        Me.Controls.Add(Me.Average_Weight1)
        Me.Controls.Add(Me.Average_Weight2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Ability_Score_Bonus)
        Me.Controls.Add(Me.Skill_Bonus)
        Me.Controls.Add(Me.Male_Names)
        Me.Controls.Add(Me.Female_Names)
        Me.Controls.Add(Me.Short_Description)
        Me.Controls.Add(Me.RaceID)
        Me.Controls.Add(Me.Playing)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Races"
        Me.Text = "Races"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaceID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Race_Namelbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Write_To_File As System.Windows.Forms.Button
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
    Friend WithEvents Race_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Flavor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Speed As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Size As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Characteristics As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Physical_Qualities As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Vision As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Average_Height1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Average_Height2 As System.Windows.Forms.TextBox
    Friend WithEvents Average_Height3 As System.Windows.Forms.TextBox
    Friend WithEvents Average_Height4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Average_Weight1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Average_Weight2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Ability_Score_Bonus As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Skill_Bonus As System.Windows.Forms.CheckedListBox
    Friend WithEvents Male_Names As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Female_Names As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Short_Description As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents RaceID As System.Windows.Forms.NumericUpDown
    Friend WithEvents Playing As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
