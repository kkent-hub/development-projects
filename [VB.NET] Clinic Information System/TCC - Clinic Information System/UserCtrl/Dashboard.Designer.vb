<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.border_2 = New System.Windows.Forms.Panel()
        Me.panel_2 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.l_total_male = New System.Windows.Forms.Label()
        Me.l_total_female = New System.Windows.Forms.Label()
        Me.l_total_student = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.l_name_1 = New System.Windows.Forms.Label()
        Me.panel_1 = New System.Windows.Forms.Panel()
        Me.id3 = New System.Windows.Forms.Label()
        Me.id2 = New System.Windows.Forms.Label()
        Me.id1 = New System.Windows.Forms.Label()
        Me.std_img3 = New System.Windows.Forms.PictureBox()
        Me.std_img2 = New System.Windows.Forms.PictureBox()
        Me.std_img1 = New System.Windows.Forms.PictureBox()
        Me.l_description3 = New System.Windows.Forms.Label()
        Me.l_description2 = New System.Windows.Forms.Label()
        Me.l_name_3 = New System.Windows.Forms.Label()
        Me.l_name_2 = New System.Windows.Forms.Label()
        Me.l_description1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.line_1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.border_3 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.t_search = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.data_view = New System.Windows.Forms.DataGridView()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.border_1 = New System.Windows.Forms.Panel()
        Me.Panel10.SuspendLayout()
        Me.panel_2.SuspendLayout()
        Me.panel_1.SuspendLayout()
        CType(Me.std_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.std_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.std_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel10.Controls.Add(Me.Label12)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.DateTimePicker1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(760, 25)
        Me.Panel10.TabIndex = 97
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(27, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 17)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Latest Student Records"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "  "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(33, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 98
        '
        'border_2
        '
        Me.border_2.BackColor = System.Drawing.SystemColors.Control
        Me.border_2.Dock = System.Windows.Forms.DockStyle.Right
        Me.border_2.Location = New System.Drawing.Point(772, 0)
        Me.border_2.Name = "border_2"
        Me.border_2.Size = New System.Drawing.Size(10, 237)
        Me.border_2.TabIndex = 19
        '
        'panel_2
        '
        Me.panel_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.panel_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_2.Controls.Add(Me.MaterialFlatButton1)
        Me.panel_2.Controls.Add(Me.Label17)
        Me.panel_2.Controls.Add(Me.Label16)
        Me.panel_2.Controls.Add(Me.Label15)
        Me.panel_2.Controls.Add(Me.Label14)
        Me.panel_2.Controls.Add(Me.l_total_male)
        Me.panel_2.Controls.Add(Me.l_total_female)
        Me.panel_2.Controls.Add(Me.l_total_student)
        Me.panel_2.Controls.Add(Me.Label13)
        Me.panel_2.Controls.Add(Me.Label10)
        Me.panel_2.Controls.Add(Me.Label7)
        Me.panel_2.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_2.Location = New System.Drawing.Point(782, 0)
        Me.panel_2.Name = "panel_2"
        Me.panel_2.Size = New System.Drawing.Size(388, 237)
        Me.panel_2.TabIndex = 16
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(103, 182)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(200, 36)
        Me.MaterialFlatButton1.TabIndex = 95
        Me.MaterialFlatButton1.Text = "View All Student Records"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        Me.MaterialFlatButton1.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(99, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 20)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "Females          :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(76, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(17, 20)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "  "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(99, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 20)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Males              :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Purple
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(76, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 20)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "  "
        '
        'l_total_male
        '
        Me.l_total_male.AutoSize = True
        Me.l_total_male.BackColor = System.Drawing.Color.Transparent
        Me.l_total_male.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_total_male.ForeColor = System.Drawing.Color.Black
        Me.l_total_male.Location = New System.Drawing.Point(267, 133)
        Me.l_total_male.Name = "l_total_male"
        Me.l_total_male.Size = New System.Drawing.Size(16, 18)
        Me.l_total_male.TabIndex = 94
        Me.l_total_male.Text = "0"
        '
        'l_total_female
        '
        Me.l_total_female.AutoSize = True
        Me.l_total_female.BackColor = System.Drawing.Color.Transparent
        Me.l_total_female.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_total_female.ForeColor = System.Drawing.Color.Black
        Me.l_total_female.Location = New System.Drawing.Point(267, 102)
        Me.l_total_female.Name = "l_total_female"
        Me.l_total_female.Size = New System.Drawing.Size(16, 18)
        Me.l_total_female.TabIndex = 94
        Me.l_total_female.Text = "0"
        '
        'l_total_student
        '
        Me.l_total_student.AutoSize = True
        Me.l_total_student.BackColor = System.Drawing.Color.Transparent
        Me.l_total_student.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_total_student.ForeColor = System.Drawing.Color.Black
        Me.l_total_student.Location = New System.Drawing.Point(267, 69)
        Me.l_total_student.Name = "l_total_student"
        Me.l_total_student.Size = New System.Drawing.Size(16, 18)
        Me.l_total_student.TabIndex = 94
        Me.l_total_student.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(96, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 20)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Total Students :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(76, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 20)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Fake Receipt", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(357, 34)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Student Total View"
        '
        'l_name_1
        '
        Me.l_name_1.AutoSize = True
        Me.l_name_1.BackColor = System.Drawing.Color.Transparent
        Me.l_name_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_name_1.Font = New System.Drawing.Font("Exo 2", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_name_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_name_1.Location = New System.Drawing.Point(84, 36)
        Me.l_name_1.Name = "l_name_1"
        Me.l_name_1.Size = New System.Drawing.Size(17, 25)
        Me.l_name_1.TabIndex = 94
        Me.l_name_1.Text = " "
        '
        'panel_1
        '
        Me.panel_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_1.Controls.Add(Me.id3)
        Me.panel_1.Controls.Add(Me.id2)
        Me.panel_1.Controls.Add(Me.id1)
        Me.panel_1.Controls.Add(Me.std_img3)
        Me.panel_1.Controls.Add(Me.std_img2)
        Me.panel_1.Controls.Add(Me.std_img1)
        Me.panel_1.Controls.Add(Me.l_description3)
        Me.panel_1.Controls.Add(Me.l_description2)
        Me.panel_1.Controls.Add(Me.l_name_3)
        Me.panel_1.Controls.Add(Me.l_name_2)
        Me.panel_1.Controls.Add(Me.l_description1)
        Me.panel_1.Controls.Add(Me.l_name_1)
        Me.panel_1.Controls.Add(Me.Panel10)
        Me.panel_1.Controls.Add(Me.Label3)
        Me.panel_1.Controls.Add(Me.line_1)
        Me.panel_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_1.Location = New System.Drawing.Point(10, 0)
        Me.panel_1.Name = "panel_1"
        Me.panel_1.Size = New System.Drawing.Size(762, 237)
        Me.panel_1.TabIndex = 18
        '
        'id3
        '
        Me.id3.AutoSize = True
        Me.id3.BackColor = System.Drawing.Color.Transparent
        Me.id3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id3.ForeColor = System.Drawing.Color.DarkGray
        Me.id3.Location = New System.Drawing.Point(667, 182)
        Me.id3.Name = "id3"
        Me.id3.Size = New System.Drawing.Size(34, 18)
        Me.id3.TabIndex = 101
        Me.id3.Text = " idx"
        Me.id3.Visible = False
        '
        'id2
        '
        Me.id2.AutoSize = True
        Me.id2.BackColor = System.Drawing.Color.Transparent
        Me.id2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id2.ForeColor = System.Drawing.Color.DarkGray
        Me.id2.Location = New System.Drawing.Point(667, 110)
        Me.id2.Name = "id2"
        Me.id2.Size = New System.Drawing.Size(34, 18)
        Me.id2.TabIndex = 101
        Me.id2.Text = " idx"
        Me.id2.Visible = False
        '
        'id1
        '
        Me.id1.AutoSize = True
        Me.id1.BackColor = System.Drawing.Color.Transparent
        Me.id1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id1.ForeColor = System.Drawing.Color.DarkGray
        Me.id1.Location = New System.Drawing.Point(667, 36)
        Me.id1.Name = "id1"
        Me.id1.Size = New System.Drawing.Size(34, 18)
        Me.id1.TabIndex = 101
        Me.id1.Text = " idx"
        Me.id1.Visible = False
        '
        'std_img3
        '
        Me.std_img3.BackColor = System.Drawing.Color.Transparent
        Me.std_img3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.std_img3.Image = CType(resources.GetObject("std_img3.Image"), System.Drawing.Image)
        Me.std_img3.Location = New System.Drawing.Point(8, 165)
        Me.std_img3.Name = "std_img3"
        Me.std_img3.Size = New System.Drawing.Size(71, 61)
        Me.std_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.std_img3.TabIndex = 100
        Me.std_img3.TabStop = False
        '
        'std_img2
        '
        Me.std_img2.BackColor = System.Drawing.Color.Transparent
        Me.std_img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.std_img2.Image = CType(resources.GetObject("std_img2.Image"), System.Drawing.Image)
        Me.std_img2.Location = New System.Drawing.Point(8, 98)
        Me.std_img2.Name = "std_img2"
        Me.std_img2.Size = New System.Drawing.Size(71, 61)
        Me.std_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.std_img2.TabIndex = 100
        Me.std_img2.TabStop = False
        '
        'std_img1
        '
        Me.std_img1.BackColor = System.Drawing.Color.Transparent
        Me.std_img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.std_img1.Image = CType(resources.GetObject("std_img1.Image"), System.Drawing.Image)
        Me.std_img1.Location = New System.Drawing.Point(8, 31)
        Me.std_img1.Name = "std_img1"
        Me.std_img1.Size = New System.Drawing.Size(71, 61)
        Me.std_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.std_img1.TabIndex = 100
        Me.std_img1.TabStop = False
        '
        'l_description3
        '
        Me.l_description3.AutoSize = True
        Me.l_description3.BackColor = System.Drawing.Color.Transparent
        Me.l_description3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_description3.ForeColor = System.Drawing.Color.DarkGray
        Me.l_description3.Location = New System.Drawing.Point(90, 200)
        Me.l_description3.Name = "l_description3"
        Me.l_description3.Size = New System.Drawing.Size(12, 18)
        Me.l_description3.TabIndex = 94
        Me.l_description3.Text = " "
        '
        'l_description2
        '
        Me.l_description2.AutoSize = True
        Me.l_description2.BackColor = System.Drawing.Color.Transparent
        Me.l_description2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_description2.ForeColor = System.Drawing.Color.DarkGray
        Me.l_description2.Location = New System.Drawing.Point(90, 131)
        Me.l_description2.Name = "l_description2"
        Me.l_description2.Size = New System.Drawing.Size(12, 18)
        Me.l_description2.TabIndex = 94
        Me.l_description2.Text = " "
        '
        'l_name_3
        '
        Me.l_name_3.AutoSize = True
        Me.l_name_3.BackColor = System.Drawing.Color.Transparent
        Me.l_name_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_name_3.Font = New System.Drawing.Font("Exo 2", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_name_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_name_3.Location = New System.Drawing.Point(85, 171)
        Me.l_name_3.Name = "l_name_3"
        Me.l_name_3.Size = New System.Drawing.Size(17, 25)
        Me.l_name_3.TabIndex = 94
        Me.l_name_3.Text = " "
        '
        'l_name_2
        '
        Me.l_name_2.AutoSize = True
        Me.l_name_2.BackColor = System.Drawing.Color.Transparent
        Me.l_name_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_name_2.Font = New System.Drawing.Font("Exo 2", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_name_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_name_2.Location = New System.Drawing.Point(84, 103)
        Me.l_name_2.Name = "l_name_2"
        Me.l_name_2.Size = New System.Drawing.Size(17, 25)
        Me.l_name_2.TabIndex = 94
        Me.l_name_2.Text = " "
        '
        'l_description1
        '
        Me.l_description1.AutoSize = True
        Me.l_description1.BackColor = System.Drawing.Color.Transparent
        Me.l_description1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_description1.ForeColor = System.Drawing.Color.DarkGray
        Me.l_description1.Location = New System.Drawing.Point(90, 63)
        Me.l_description1.Name = "l_description1"
        Me.l_description1.Size = New System.Drawing.Size(12, 18)
        Me.l_description1.TabIndex = 94
        Me.l_description1.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(85, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(577, 19)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "_______________________________________________________________________"
        '
        'line_1
        '
        Me.line_1.AutoSize = True
        Me.line_1.BackColor = System.Drawing.Color.Transparent
        Me.line_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.line_1.ForeColor = System.Drawing.Color.DarkGray
        Me.line_1.Location = New System.Drawing.Point(85, 80)
        Me.line_1.Name = "line_1"
        Me.line_1.Size = New System.Drawing.Size(577, 19)
        Me.line_1.TabIndex = 94
        Me.line_1.Text = "_______________________________________________________________________"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 237)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1160, 10)
        Me.Panel4.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panel_1)
        Me.Panel1.Controls.Add(Me.border_2)
        Me.Panel1.Controls.Add(Me.panel_2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.border_3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 403)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 247)
        Me.Panel1.TabIndex = 61
        '
        'border_3
        '
        Me.border_3.BackColor = System.Drawing.SystemColors.Control
        Me.border_3.Dock = System.Windows.Forms.DockStyle.Left
        Me.border_3.Location = New System.Drawing.Point(0, 0)
        Me.border_3.Name = "border_3"
        Me.border_3.Size = New System.Drawing.Size(10, 247)
        Me.border_3.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.t_search)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1170, 52)
        Me.Panel3.TabIndex = 68
        '
        't_search
        '
        Me.t_search.Depth = 0
        Me.t_search.Font = New System.Drawing.Font("Quicksand Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_search.Hint = "Seach Student here..."
        Me.t_search.Location = New System.Drawing.Point(44, 14)
        Me.t_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.t_search.Name = "t_search"
        Me.t_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.t_search.SelectedText = ""
        Me.t_search.SelectionLength = 0
        Me.t_search.SelectionStart = 0
        Me.t_search.Size = New System.Drawing.Size(302, 23)
        Me.t_search.TabIndex = 110
        Me.t_search.UseSystemPasswordChar = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 109
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(350, 10)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 109
        Me.PictureBox4.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Controls.Add(Me.PictureBox7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1093, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(65, 50)
        Me.Panel5.TabIndex = 97
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(3, 11)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 109
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(36, 11)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 109
        Me.PictureBox7.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(1158, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 50)
        Me.Panel8.TabIndex = 96
        '
        'data_view
        '
        Me.data_view.AllowUserToAddRows = False
        Me.data_view.AllowUserToDeleteRows = False
        Me.data_view.AllowUserToResizeColumns = False
        Me.data_view.AllowUserToResizeRows = False
        Me.data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_view.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Exo 2 Semi Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_view.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_view.DefaultCellStyle = DataGridViewCellStyle2
        Me.data_view.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_view.Location = New System.Drawing.Point(10, 62)
        Me.data_view.Name = "data_view"
        Me.data_view.Size = New System.Drawing.Size(1150, 331)
        Me.data_view.TabIndex = 72
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(0, 62)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 331)
        Me.Panel12.TabIndex = 69
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 52)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1160, 10)
        Me.Panel17.TabIndex = 71
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel16.Location = New System.Drawing.Point(1160, 52)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(10, 341)
        Me.Panel16.TabIndex = 70
        '
        'border_1
        '
        Me.border_1.BackColor = System.Drawing.SystemColors.Control
        Me.border_1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.border_1.Location = New System.Drawing.Point(0, 393)
        Me.border_1.Name = "border_1"
        Me.border_1.Size = New System.Drawing.Size(1170, 10)
        Me.border_1.TabIndex = 64
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.data_view)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.border_1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.Size = New System.Drawing.Size(1170, 650)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.panel_2.ResumeLayout(False)
        Me.panel_2.PerformLayout()
        Me.panel_1.ResumeLayout(False)
        Me.panel_1.PerformLayout()
        CType(Me.std_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.std_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.std_img1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents border_2 As System.Windows.Forms.Panel
    Friend WithEvents panel_2 As System.Windows.Forms.Panel
    Friend WithEvents l_name_1 As System.Windows.Forms.Label
    Friend WithEvents panel_1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents border_3 As System.Windows.Forms.Panel
    Friend WithEvents l_description1 As System.Windows.Forms.Label
    Friend WithEvents l_description3 As System.Windows.Forms.Label
    Friend WithEvents l_description2 As System.Windows.Forms.Label
    Friend WithEvents l_name_3 As System.Windows.Forms.Label
    Friend WithEvents l_name_2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents line_1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents l_total_male As System.Windows.Forms.Label
    Friend WithEvents l_total_female As System.Windows.Forms.Label
    Friend WithEvents l_total_student As System.Windows.Forms.Label
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents t_search As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents data_view As System.Windows.Forms.DataGridView
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents std_img3 As System.Windows.Forms.PictureBox
    Friend WithEvents std_img2 As System.Windows.Forms.PictureBox
    Friend WithEvents std_img1 As System.Windows.Forms.PictureBox
    Friend WithEvents id3 As System.Windows.Forms.Label
    Friend WithEvents id2 As System.Windows.Forms.Label
    Friend WithEvents id1 As System.Windows.Forms.Label
    Friend WithEvents border_1 As System.Windows.Forms.Panel

End Class
