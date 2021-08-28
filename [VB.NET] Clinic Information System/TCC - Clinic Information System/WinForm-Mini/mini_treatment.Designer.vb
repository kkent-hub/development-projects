<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mini_treatment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mini_treatment))
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.line_1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t_id = New System.Windows.Forms.TextBox()
        Me.t_name = New System.Windows.Forms.TextBox()
        Me.t_cy = New System.Windows.Forms.TextBox()
        Me.t_comp = New System.Windows.Forms.TextBox()
        Me.t_inter = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t_remarks = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.l_idx = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(61, 74)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(109, 21)
        Me.Label29.TabIndex = 165
        Me.Label29.Text = "ID / LRN No. :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Exo 2", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 35)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "Treatment"
        '
        'line_1
        '
        Me.line_1.AutoSize = True
        Me.line_1.BackColor = System.Drawing.Color.Transparent
        Me.line_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.line_1.ForeColor = System.Drawing.Color.DarkGray
        Me.line_1.Location = New System.Drawing.Point(12, 35)
        Me.line_1.Name = "line_1"
        Me.line_1.Size = New System.Drawing.Size(745, 19)
        Me.line_1.TabIndex = 194
        Me.line_1.Text = "_________________________________________________________________________________" & _
    "___________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Course and Year :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Complaints :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 21)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Intervention :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(12, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(745, 19)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "___________"
        '
        't_id
        '
        Me.t_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_id.Location = New System.Drawing.Point(176, 72)
        Me.t_id.Name = "t_id"
        Me.t_id.ReadOnly = True
        Me.t_id.Size = New System.Drawing.Size(139, 26)
        Me.t_id.TabIndex = 195
        '
        't_name
        '
        Me.t_name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_name.Location = New System.Drawing.Point(176, 104)
        Me.t_name.Name = "t_name"
        Me.t_name.ReadOnly = True
        Me.t_name.Size = New System.Drawing.Size(549, 26)
        Me.t_name.TabIndex = 196
        '
        't_cy
        '
        Me.t_cy.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_cy.Location = New System.Drawing.Point(176, 136)
        Me.t_cy.Name = "t_cy"
        Me.t_cy.ReadOnly = True
        Me.t_cy.Size = New System.Drawing.Size(170, 26)
        Me.t_cy.TabIndex = 195
        '
        't_comp
        '
        Me.t_comp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_comp.Location = New System.Drawing.Point(176, 168)
        Me.t_comp.Multiline = True
        Me.t_comp.Name = "t_comp"
        Me.t_comp.Size = New System.Drawing.Size(549, 48)
        Me.t_comp.TabIndex = 196
        '
        't_inter
        '
        Me.t_inter.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_inter.Location = New System.Drawing.Point(176, 222)
        Me.t_inter.Multiline = True
        Me.t_inter.Name = "t_inter"
        Me.t_inter.Size = New System.Drawing.Size(549, 48)
        Me.t_inter.TabIndex = 196
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(587, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 30)
        Me.Button2.TabIndex = 197
        Me.Button2.Text = "Add Record"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Remarks :"
        '
        't_remarks
        '
        Me.t_remarks.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_remarks.Location = New System.Drawing.Point(176, 276)
        Me.t_remarks.Name = "t_remarks"
        Me.t_remarks.Size = New System.Drawing.Size(549, 26)
        Me.t_remarks.TabIndex = 195
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(571, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 30)
        Me.Button1.TabIndex = 197
        Me.Button1.Text = "Save Changes"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'l_idx
        '
        Me.l_idx.AutoSize = True
        Me.l_idx.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_idx.Location = New System.Drawing.Point(323, 35)
        Me.l_idx.Name = "l_idx"
        Me.l_idx.Size = New System.Drawing.Size(32, 21)
        Me.l_idx.TabIndex = 165
        Me.l_idx.Text = "idx"
        '
        'mini_treatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 390)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.t_inter)
        Me.Controls.Add(Me.t_comp)
        Me.Controls.Add(Me.t_name)
        Me.Controls.Add(Me.t_remarks)
        Me.Controls.Add(Me.t_cy)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.line_1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l_idx)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mini_treatment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treatment | Fill up - Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents line_1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents t_id As System.Windows.Forms.TextBox
    Friend WithEvents t_name As System.Windows.Forms.TextBox
    Friend WithEvents t_cy As System.Windows.Forms.TextBox
    Friend WithEvents t_comp As System.Windows.Forms.TextBox
    Friend WithEvents t_inter As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents t_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents l_idx As System.Windows.Forms.Label
End Class
