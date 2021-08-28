<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mini_medical_01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mini_medical_01))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.t_comp = New System.Windows.Forms.TextBox()
        Me.t_name = New System.Windows.Forms.TextBox()
        Me.t_num = New System.Windows.Forms.TextBox()
        Me.t_cy = New System.Windows.Forms.TextBox()
        Me.t_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.line_1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.l_idx = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.t_time = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.t_medical_D = New System.Windows.Forms.ComboBox()
        Me.l_id = New System.Windows.Forms.Label()
        Me.l_stock = New System.Windows.Forms.Label()
        Me.l_stockOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(571, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 30)
        Me.Button1.TabIndex = 215
        Me.Button1.Text = "Save Changes"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(587, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 30)
        Me.Button2.TabIndex = 214
        Me.Button2.Text = "Add Record"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        't_comp
        '
        Me.t_comp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_comp.Location = New System.Drawing.Point(175, 170)
        Me.t_comp.Multiline = True
        Me.t_comp.Name = "t_comp"
        Me.t_comp.Size = New System.Drawing.Size(549, 48)
        Me.t_comp.TabIndex = 212
        '
        't_name
        '
        Me.t_name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_name.Location = New System.Drawing.Point(175, 106)
        Me.t_name.Name = "t_name"
        Me.t_name.ReadOnly = True
        Me.t_name.Size = New System.Drawing.Size(549, 26)
        Me.t_name.TabIndex = 211
        '
        't_num
        '
        Me.t_num.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_num.Location = New System.Drawing.Point(176, 255)
        Me.t_num.Name = "t_num"
        Me.t_num.Size = New System.Drawing.Size(139, 26)
        Me.t_num.TabIndex = 209
        '
        't_cy
        '
        Me.t_cy.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_cy.Location = New System.Drawing.Point(175, 138)
        Me.t_cy.Name = "t_cy"
        Me.t_cy.ReadOnly = True
        Me.t_cy.Size = New System.Drawing.Size(170, 26)
        Me.t_cy.TabIndex = 208
        '
        't_id
        '
        Me.t_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_id.Location = New System.Drawing.Point(175, 74)
        Me.t_id.Name = "t_id"
        Me.t_id.ReadOnly = True
        Me.t_id.Size = New System.Drawing.Size(139, 26)
        Me.t_id.TabIndex = 210
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Exo 2", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 35)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "Medical"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(12, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(745, 19)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "___________"
        '
        'line_1
        '
        Me.line_1.AutoSize = True
        Me.line_1.BackColor = System.Drawing.Color.Transparent
        Me.line_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.line_1.ForeColor = System.Drawing.Color.DarkGray
        Me.line_1.Location = New System.Drawing.Point(11, 37)
        Me.line_1.Name = "line_1"
        Me.line_1.Size = New System.Drawing.Size(745, 19)
        Me.line_1.TabIndex = 207
        Me.line_1.Text = "_________________________________________________________________________________" & _
    "___________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 21)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Medical Dispensed :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 21)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "No. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Complaints :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Course and Year :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "Name :"
        '
        'l_idx
        '
        Me.l_idx.AutoSize = True
        Me.l_idx.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_idx.Location = New System.Drawing.Point(322, 37)
        Me.l_idx.Name = "l_idx"
        Me.l_idx.Size = New System.Drawing.Size(32, 21)
        Me.l_idx.TabIndex = 204
        Me.l_idx.Text = "idx"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(60, 76)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(109, 21)
        Me.Label29.TabIndex = 198
        Me.Label29.Text = "ID / LRN No. :"
        '
        't_time
        '
        Me.t_time.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.t_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.t_time.Location = New System.Drawing.Point(383, 257)
        Me.t_time.Name = "t_time"
        Me.t_time.Size = New System.Drawing.Size(200, 26)
        Me.t_time.TabIndex = 216
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(323, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 21)
        Me.Label8.TabIndex = 202
        Me.Label8.Text = "Time :"
        '
        't_medical_D
        '
        Me.t_medical_D.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.t_medical_D.FormattingEnabled = True
        Me.t_medical_D.Location = New System.Drawing.Point(176, 223)
        Me.t_medical_D.Name = "t_medical_D"
        Me.t_medical_D.Size = New System.Drawing.Size(548, 28)
        Me.t_medical_D.TabIndex = 217
        '
        'l_id
        '
        Me.l_id.AutoSize = True
        Me.l_id.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_id.Location = New System.Drawing.Point(347, 187)
        Me.l_id.Name = "l_id"
        Me.l_id.Size = New System.Drawing.Size(35, 21)
        Me.l_id.TabIndex = 203
        Me.l_id.Text = "l_id"
        '
        'l_stock
        '
        Me.l_stock.AutoSize = True
        Me.l_stock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_stock.Location = New System.Drawing.Point(388, 187)
        Me.l_stock.Name = "l_stock"
        Me.l_stock.Size = New System.Drawing.Size(62, 21)
        Me.l_stock.TabIndex = 203
        Me.l_stock.Text = "l_stock"
        '
        'l_stockOut
        '
        Me.l_stockOut.AutoSize = True
        Me.l_stockOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_stockOut.Location = New System.Drawing.Point(456, 187)
        Me.l_stockOut.Name = "l_stockOut"
        Me.l_stockOut.Size = New System.Drawing.Size(93, 21)
        Me.l_stockOut.TabIndex = 203
        Me.l_stockOut.Text = "l_stockOut"
        '
        'mini_medical_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 367)
        Me.Controls.Add(Me.t_medical_D)
        Me.Controls.Add(Me.t_time)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.t_name)
        Me.Controls.Add(Me.t_num)
        Me.Controls.Add(Me.t_cy)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.line_1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l_idx)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t_comp)
        Me.Controls.Add(Me.l_stockOut)
        Me.Controls.Add(Me.l_stock)
        Me.Controls.Add(Me.l_id)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mini_medical_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical | Fill up - Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents t_comp As System.Windows.Forms.TextBox
    Friend WithEvents t_name As System.Windows.Forms.TextBox
    Friend WithEvents t_num As System.Windows.Forms.TextBox
    Friend WithEvents t_cy As System.Windows.Forms.TextBox
    Friend WithEvents t_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents line_1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents l_idx As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents t_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents t_medical_D As System.Windows.Forms.ComboBox
    Friend WithEvents l_id As System.Windows.Forms.Label
    Friend WithEvents l_stock As System.Windows.Forms.Label
    Friend WithEvents l_stockOut As System.Windows.Forms.Label
End Class
