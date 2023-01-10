<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmjadwal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btncetak = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.Btnhapus = New System.Windows.Forms.Button()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Btnupdate = New System.Windows.Forms.Button()
        Me.Btntambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.DateTimePickertgl = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxKode = New System.Windows.Forms.TextBox()
        Me.TextBoxNkegiatan = New System.Windows.Forms.TextBox()
        Me.TextBoxWaktu = New System.Windows.Forms.TextBox()
        Me.TextBoxTempat = New System.Windows.Forms.TextBox()
        Me.TextBoxjenkel = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(367, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Pelayanan Ibu dan Anak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(269, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 15)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Jl. Sukamantri, Kp.Pelaukan, Ds.Suka Raya, Kec. Karang Bahagia 17530"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(355, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 33)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "BIDAN KOKOM"
        '
        'Btncetak
        '
        Me.Btncetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btncetak.FlatAppearance.BorderSize = 0
        Me.Btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncetak.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncetak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btncetak.Location = New System.Drawing.Point(797, 409)
        Me.Btncetak.Name = "Btncetak"
        Me.Btncetak.Size = New System.Drawing.Size(75, 23)
        Me.Btncetak.TabIndex = 149
        Me.Btncetak.Text = "CETAK"
        Me.Btncetak.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.LightBlue
        Me.btnkembali.FlatAppearance.BorderSize = 0
        Me.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnkembali.Location = New System.Drawing.Point(793, 458)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(100, 25)
        Me.btnkembali.TabIndex = 148
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'Btnhapus
        '
        Me.Btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnhapus.FlatAppearance.BorderSize = 0
        Me.Btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnhapus.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnhapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btnhapus.Location = New System.Drawing.Point(18, 377)
        Me.Btnhapus.Name = "Btnhapus"
        Me.Btnhapus.Size = New System.Drawing.Size(159, 23)
        Me.Btnhapus.TabIndex = 147
        Me.Btnhapus.Text = "Hapus"
        Me.Btnhapus.UseVisualStyleBackColor = False
        '
        'Btnedit
        '
        Me.Btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnedit.FlatAppearance.BorderSize = 0
        Me.Btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnedit.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btnedit.Location = New System.Drawing.Point(185, 345)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(159, 23)
        Me.Btnedit.TabIndex = 145
        Me.Btnedit.Text = "Edit"
        Me.Btnedit.UseVisualStyleBackColor = False
        '
        'Btnupdate
        '
        Me.Btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnupdate.FlatAppearance.BorderSize = 0
        Me.Btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnupdate.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btnupdate.Location = New System.Drawing.Point(185, 377)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(159, 23)
        Me.Btnupdate.TabIndex = 144
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = False
        '
        'Btntambah
        '
        Me.Btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btntambah.FlatAppearance.BorderSize = 0
        Me.Btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btntambah.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntambah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btntambah.Location = New System.Drawing.Point(18, 345)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(159, 23)
        Me.Btntambah.TabIndex = 143
        Me.Btntambah.Text = "Tambah"
        Me.Btntambah.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(361, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 192)
        Me.DataGridView1.TabIndex = 142
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(361, 175)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(204, 20)
        Me.TextBox4.TabIndex = 141
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(358, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = "Pencarian"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 15)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "JENIS KELAMIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "TEMPAT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "WAKTU"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(17, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "NAMA KEGIATAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 15)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "MASUKAN TANGGAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "KODE "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(333, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 25)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "JADWAL PELAYANAN"
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RectangleShape2.Location = New System.Drawing.Point(-6, -9)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(901, 86)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(899, 488)
        Me.ShapeContainer1.TabIndex = 160
        Me.ShapeContainer1.TabStop = False
        '
        'DateTimePickertgl
        '
        Me.DateTimePickertgl.Location = New System.Drawing.Point(168, 204)
        Me.DateTimePickertgl.Name = "DateTimePickertgl"
        Me.DateTimePickertgl.Size = New System.Drawing.Size(159, 20)
        Me.DateTimePickertgl.TabIndex = 161
        '
        'TextBoxKode
        '
        Me.TextBoxKode.Location = New System.Drawing.Point(168, 176)
        Me.TextBoxKode.Name = "TextBoxKode"
        Me.TextBoxKode.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxKode.TabIndex = 162
        '
        'TextBoxNkegiatan
        '
        Me.TextBoxNkegiatan.Location = New System.Drawing.Point(168, 230)
        Me.TextBoxNkegiatan.Name = "TextBoxNkegiatan"
        Me.TextBoxNkegiatan.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxNkegiatan.TabIndex = 163
        '
        'TextBoxWaktu
        '
        Me.TextBoxWaktu.Location = New System.Drawing.Point(168, 256)
        Me.TextBoxWaktu.Name = "TextBoxWaktu"
        Me.TextBoxWaktu.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxWaktu.TabIndex = 164
        '
        'TextBoxTempat
        '
        Me.TextBoxTempat.Location = New System.Drawing.Point(168, 282)
        Me.TextBoxTempat.Name = "TextBoxTempat"
        Me.TextBoxTempat.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxTempat.TabIndex = 165
        '
        'TextBoxjenkel
        '
        Me.TextBoxjenkel.Location = New System.Drawing.Point(168, 308)
        Me.TextBoxjenkel.Name = "TextBoxjenkel"
        Me.TextBoxjenkel.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxjenkel.TabIndex = 166
        '
        'Frmjadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 488)
        Me.Controls.Add(Me.TextBoxjenkel)
        Me.Controls.Add(Me.TextBoxTempat)
        Me.Controls.Add(Me.TextBoxWaktu)
        Me.Controls.Add(Me.TextBoxNkegiatan)
        Me.Controls.Add(Me.TextBoxKode)
        Me.Controls.Add(Me.DateTimePickertgl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btncetak)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.Btnhapus)
        Me.Controls.Add(Me.Btnedit)
        Me.Controls.Add(Me.Btnupdate)
        Me.Controls.Add(Me.Btntambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frmjadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmjadwal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btncetak As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents Btnhapus As System.Windows.Forms.Button
    Friend WithEvents Btnedit As System.Windows.Forms.Button
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Btntambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents DateTimePickertgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxKode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNkegiatan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxWaktu As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTempat As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxjenkel As System.Windows.Forms.TextBox
End Class
