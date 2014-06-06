<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CBB_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CBB_Menu))
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.Custom_Class = New System.Windows.Forms.Button()
        Me.Custom_Race = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Main_Menu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exit_Btn
        '
        Me.Exit_Btn.BackColor = System.Drawing.Color.White
        Me.Exit_Btn.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(69, 525)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(250, 59)
        Me.Exit_Btn.TabIndex = 57
        Me.Exit_Btn.Text = "Quit"
        Me.Exit_Btn.UseVisualStyleBackColor = False
        '
        'Custom_Class
        '
        Me.Custom_Class.BackColor = System.Drawing.Color.White
        Me.Custom_Class.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custom_Class.Location = New System.Drawing.Point(69, 313)
        Me.Custom_Class.Name = "Custom_Class"
        Me.Custom_Class.Size = New System.Drawing.Size(250, 59)
        Me.Custom_Class.TabIndex = 58
        Me.Custom_Class.Text = "Custom Class"
        Me.Custom_Class.UseVisualStyleBackColor = False
        '
        'Custom_Race
        '
        Me.Custom_Race.BackColor = System.Drawing.Color.White
        Me.Custom_Race.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custom_Race.Location = New System.Drawing.Point(69, 416)
        Me.Custom_Race.Name = "Custom_Race"
        Me.Custom_Race.Size = New System.Drawing.Size(250, 59)
        Me.Custom_Race.TabIndex = 59
        Me.Custom_Race.Text = "Custom Race"
        Me.Custom_Race.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.CustomClassBuilder.My.Resources.Resources.CCBBackground1
        Me.PictureBox2.Image = Global.CustomClassBuilder.My.Resources.Resources.ccbiconsmall
        Me.PictureBox2.Location = New System.Drawing.Point(69, 95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 200)
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'Main_Menu
        '
        Me.Main_Menu.AutoSize = True
        Me.Main_Menu.BackColor = System.Drawing.Color.Transparent
        Me.Main_Menu.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_Menu.ForeColor = System.Drawing.Color.White
        Me.Main_Menu.Image = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Main_Menu.Location = New System.Drawing.Point(113, 21)
        Me.Main_Menu.Name = "Main_Menu"
        Me.Main_Menu.Size = New System.Drawing.Size(252, 43)
        Me.Main_Menu.TabIndex = 56
        Me.Main_Menu.Text = "Main Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("BankGothic Lt BT", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.CustomClassBuilder.My.Resources.Resources.Background3
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 43)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "CCB"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.CustomClassBuilder.My.Resources.Resources.background1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 643)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'CBB_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(398, 643)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Custom_Race)
        Me.Controls.Add(Me.Custom_Class)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.Main_Menu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CBB_Menu"
        Me.Text = "Menu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Main_Menu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
    Friend WithEvents Custom_Class As System.Windows.Forms.Button
    Friend WithEvents Custom_Race As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
