<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.beam_width = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.area_steel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.steel_fy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.conc_fc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cover = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.beam_depth = New System.Windows.Forms.TextBox()
        Me.rtf = New System.Windows.Forms.RichTextBox()
        Me.calculate_button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Width of Beam (b)"
        '
        'beam_width
        '
        Me.beam_width.Location = New System.Drawing.Point(273, 10)
        Me.beam_width.Name = "beam_width"
        Me.beam_width.Size = New System.Drawing.Size(85, 22)
        Me.beam_width.TabIndex = 0
        Me.beam_width.Text = "12"
        Me.beam_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(364, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "inch"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Area of Reinforcement (As)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(364, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "sq. inch"
        '
        'area_steel
        '
        Me.area_steel.Location = New System.Drawing.Point(273, 150)
        Me.area_steel.Name = "area_steel"
        Me.area_steel.Size = New System.Drawing.Size(85, 22)
        Me.area_steel.TabIndex = 5
        Me.area_steel.Text = "1.2"
        Me.area_steel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tensile Strength of Rebar (fy)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(364, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "psi"
        '
        'steel_fy
        '
        Me.steel_fy.Location = New System.Drawing.Point(273, 122)
        Me.steel_fy.Name = "steel_fy"
        Me.steel_fy.Size = New System.Drawing.Size(85, 22)
        Me.steel_fy.TabIndex = 4
        Me.steel_fy.Text = "60000"
        Me.steel_fy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Compressive Strength of Concrete (f'c)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "psi"
        '
        'conc_fc
        '
        Me.conc_fc.Location = New System.Drawing.Point(273, 94)
        Me.conc_fc.Name = "conc_fc"
        Me.conc_fc.Size = New System.Drawing.Size(85, 22)
        Me.conc_fc.TabIndex = 3
        Me.conc_fc.Text = "3000"
        Me.conc_fc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cover to Center of Rebar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "inch"
        '
        'cover
        '
        Me.cover.Location = New System.Drawing.Point(273, 66)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(85, 22)
        Me.cover.TabIndex = 2
        Me.cover.Text = "2.5"
        Me.cover.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Overall Depth of Beam (h)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "inch"
        '
        'beam_depth
        '
        Me.beam_depth.Location = New System.Drawing.Point(273, 38)
        Me.beam_depth.Name = "beam_depth"
        Me.beam_depth.Size = New System.Drawing.Size(85, 22)
        Me.beam_depth.TabIndex = 1
        Me.beam_depth.Text = "24"
        Me.beam_depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rtf
        '
        Me.rtf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtf.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtf.Location = New System.Drawing.Point(10, 10)
        Me.rtf.Name = "rtf"
        Me.rtf.Size = New System.Drawing.Size(834, 690)
        Me.rtf.TabIndex = 0
        Me.rtf.TabStop = False
        Me.rtf.Text = ""
        '
        'calculate_button
        '
        Me.calculate_button.Location = New System.Drawing.Point(273, 187)
        Me.calculate_button.Name = "calculate_button"
        Me.calculate_button.Size = New System.Drawing.Size(125, 34)
        Me.calculate_button.TabIndex = 6
        Me.calculate_button.Text = "Calculate"
        Me.calculate_button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rtf)
        Me.Panel1.Location = New System.Drawing.Point(440, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(856, 712)
        Me.Panel1.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(12, 675)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5)
        Me.Label13.Size = New System.Drawing.Size(408, 47)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Source Code is available at" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://github.com/usmanshamsi/SDU-1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AcceptButton = Me.calculate_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 731)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.calculate_button)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.area_steel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.beam_width)
        Me.Controls.Add(Me.steel_fy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.beam_depth)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.conc_fc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cover)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SDU-1 (Rectangular Beam Analysis)"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents beam_width As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents area_steel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents steel_fy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents conc_fc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cover As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents beam_depth As System.Windows.Forms.TextBox
    Friend WithEvents rtf As System.Windows.Forms.RichTextBox
    Friend WithEvents calculate_button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
