<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Features
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Features))
        Me.Class_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.ComboBox()
        Me.Write_To_File = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Class_Name.TabIndex = 55
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
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "CCB"
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
        Me.Menu.TabIndex = 56
        '
        'Write_To_File
        '
        Me.Write_To_File.BackColor = System.Drawing.Color.White
        Me.Write_To_File.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Write_To_File.Location = New System.Drawing.Point(748, 26)
        Me.Write_To_File.Name = "Write_To_File"
        Me.Write_To_File.Size = New System.Drawing.Size(185, 32)
        Me.Write_To_File.TabIndex = 58
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
        Me.PictureBox1.Size = New System.Drawing.Size(1239, 690)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'Exit_Btn
        '
        Me.Exit_Btn.BackColor = System.Drawing.Color.White
        Me.Exit_Btn.Font = New System.Drawing.Font("BankGothic Lt BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(973, 26)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(186, 32)
        Me.Exit_Btn.TabIndex = 60
        Me.Exit_Btn.Text = "Quit to Menu"
        Me.Exit_Btn.UseVisualStyleBackColor = False
        '
        'Features
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1239, 690)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.Write_To_File)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Class_Name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Features"
        Me.Text = "Features"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Class_Name As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Menu As System.Windows.Forms.ComboBox
    Friend WithEvents Write_To_File As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
End Class
