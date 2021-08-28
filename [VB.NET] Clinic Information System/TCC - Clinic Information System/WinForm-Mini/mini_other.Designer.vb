<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mini_other
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mini_other))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.l_idx = New System.Windows.Forms.Label()
        Me.l_date = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.line_1 = New System.Windows.Forms.Label()
        Me.data_view = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.q1 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.q2 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.q2_1 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.q3 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.q4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.q5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(815, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 183
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(277, 453)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(809, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 30)
        Me.Button2.TabIndex = 181
        Me.Button2.Text = "Print Record"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 17)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "'Other Health Information' order by Date."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 453)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 17)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Printing 'Present History' are includes 'Medical History' and"
        '
        'l_idx
        '
        Me.l_idx.AutoSize = True
        Me.l_idx.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_idx.Location = New System.Drawing.Point(761, 24)
        Me.l_idx.Name = "l_idx"
        Me.l_idx.Size = New System.Drawing.Size(48, 18)
        Me.l_idx.TabIndex = 179
        Me.l_idx.Text = "11010"
        Me.l_idx.Visible = False
        '
        'l_date
        '
        Me.l_date.AutoSize = True
        Me.l_date.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_date.Location = New System.Drawing.Point(840, 24)
        Me.l_date.Name = "l_date"
        Me.l_date.Size = New System.Drawing.Size(80, 18)
        Me.l_date.TabIndex = 180
        Me.l_date.Text = "6/23/2017"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Exo 2", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 35)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Other Health Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(238, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(737, 19)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "_________________________________________________________________________________" & _
    "__________"
        '
        'line_1
        '
        Me.line_1.AutoSize = True
        Me.line_1.BackColor = System.Drawing.Color.Transparent
        Me.line_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.line_1.ForeColor = System.Drawing.Color.DarkGray
        Me.line_1.Location = New System.Drawing.Point(235, 35)
        Me.line_1.Name = "line_1"
        Me.line_1.Size = New System.Drawing.Size(737, 19)
        Me.line_1.TabIndex = 175
        Me.line_1.Text = "_________________________________________________________________________________" & _
    "__________"
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Exo 2", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_view.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_view.DefaultCellStyle = DataGridViewCellStyle2
        Me.data_view.Dock = System.Windows.Forms.DockStyle.Left
        Me.data_view.Location = New System.Drawing.Point(10, 10)
        Me.data_view.Name = "data_view"
        Me.data_view.Size = New System.Drawing.Size(219, 492)
        Me.data_view.TabIndex = 173
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(10, 502)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 10)
        Me.Panel2.TabIndex = 172
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(992, 10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(10, 502)
        Me.FlowLayoutPanel1.TabIndex = 171
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 502)
        Me.Panel1.TabIndex = 170
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1002, 10)
        Me.Panel17.TabIndex = 169
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(247, 65)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(328, 22)
        Me.Label41.TabIndex = 184
        Me.Label41.Text = "Other health conditions not listed ?"
        '
        'q1
        '
        Me.q1.AutoSize = True
        Me.q1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.q1.Location = New System.Drawing.Point(299, 87)
        Me.q1.Name = "q1"
        Me.q1.Size = New System.Drawing.Size(15, 22)
        Me.q1.TabIndex = 184
        Me.q1.Text = ":"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(247, 109)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(319, 22)
        Me.Label42.TabIndex = 185
        Me.Label42.Text = "Are you taking any medications ?"
        '
        'q2
        '
        Me.q2.AutoSize = True
        Me.q2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2.Location = New System.Drawing.Point(561, 109)
        Me.q2.Name = "q2"
        Me.q2.Size = New System.Drawing.Size(40, 22)
        Me.q2.TabIndex = 184
        Me.q2.Text = "Yes"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(261, 131)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(460, 22)
        Me.Label45.TabIndex = 186
        Me.Label45.Text = "If yes, please indicate name of drug and dosage."
        '
        'q2_1
        '
        Me.q2_1.AutoSize = True
        Me.q2_1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.q2_1.Location = New System.Drawing.Point(318, 155)
        Me.q2_1.Name = "q2_1"
        Me.q2_1.Size = New System.Drawing.Size(15, 22)
        Me.q2_1.TabIndex = 184
        Me.q2_1.Text = ":"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(247, 177)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(246, 23)
        Me.Label46.TabIndex = 187
        Me.Label46.Text = "During and after exercise,"
        '
        'q3
        '
        Me.q3.BackColor = System.Drawing.SystemColors.Control
        Me.q3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.q3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.q3.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.q3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.q3.Location = New System.Drawing.Point(322, 212)
        Me.q3.Name = "q3"
        Me.q3.ReadOnly = True
        Me.q3.Size = New System.Drawing.Size(598, 82)
        Me.q3.TabIndex = 188
        Me.q3.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(299, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 22)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = ":"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(248, 297)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(724, 22)
        Me.Label55.TabIndex = 189
        Me.Label55.Text = "Have you been medically evaluate as a result of any  of the above symptoms"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(248, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 22)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "during exercise ?"
        '
        'q4
        '
        Me.q4.AutoSize = True
        Me.q4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4.Location = New System.Drawing.Point(405, 320)
        Me.q4.Name = "q4"
        Me.q4.Size = New System.Drawing.Size(40, 22)
        Me.q4.TabIndex = 184
        Me.q4.Text = "Yes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(248, 358)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(328, 22)
        Me.Label11.TabIndex = 184
        Me.Label11.Text = "Other health conditions not listed ?"
        '
        'q5
        '
        Me.q5.AutoSize = True
        Me.q5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.q5.Location = New System.Drawing.Point(299, 388)
        Me.q5.Name = "q5"
        Me.q5.Size = New System.Drawing.Size(15, 22)
        Me.q5.TabIndex = 184
        Me.q5.Text = ":"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(277, 450)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(695, 46)
        Me.Panel3.TabIndex = 190
        '
        'mini_other
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 512)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.q3)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.q4)
        Me.Controls.Add(Me.q2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.q2_1)
        Me.Controls.Add(Me.q5)
        Me.Controls.Add(Me.q1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.l_idx)
        Me.Controls.Add(Me.l_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.line_1)
        Me.Controls.Add(Me.data_view)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel17)
        Me.MaximizeBox = False
        Me.Name = "mini_other"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mini_other"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents l_idx As System.Windows.Forms.Label
    Friend WithEvents l_date As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents line_1 As System.Windows.Forms.Label
    Friend WithEvents data_view As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents q1 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents q2 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents q2_1 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents q3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents q4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents q5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
