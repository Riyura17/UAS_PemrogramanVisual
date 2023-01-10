<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpenimbangan
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
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.Btnhapus = New System.Windows.Forms.Button()
        Me.Btnbatal = New System.Windows.Forms.Button()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Btnsimpan = New System.Windows.Forms.Button()
        Me.Btntambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxNORTU = New System.Windows.Forms.TextBox()
        Me.TextBoxNL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Btncetak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxNik = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.LightBlue
        Me.btnkembali.FlatAppearance.BorderSize = 0
        Me.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnkembali.Location = New System.Drawing.Point(357, 449)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(514, 25)
        Me.btnkembali.TabIndex = 83
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
        Me.Btnhapus.Location = New System.Drawing.Point(796, 420)
        Me.Btnhapus.Name = "Btnhapus"
        Me.Btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.Btnhapus.TabIndex = 82
        Me.Btnhapus.Text = "Hapus"
        Me.Btnhapus.UseVisualStyleBackColor = False
        '
        'Btnbatal
        '
        Me.Btnbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnbatal.FlatAppearance.BorderSize = 0
        Me.Btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbatal.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btnbatal.Location = New System.Drawing.Point(687, 420)
        Me.Btnbatal.Name = "Btnbatal"
        Me.Btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.Btnbatal.TabIndex = 81
        Me.Btnbatal.Text = "Batal"
        Me.Btnbatal.UseVisualStyleBackColor = False
        '
        'Btnedit
        '
        Me.Btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnedit.FlatAppearance.BorderSize = 0
        Me.Btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnedit.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btnedit.Location = New System.Drawing.Point(577, 421)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(75, 23)
        Me.Btnedit.TabIndex = 80
        Me.Btnedit.Text = "Edit"
        Me.Btnedit.UseVisualStyleBackColor = False
        '
        'Btnsimpan
        '
        Me.Btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnsimpan.FlatAppearance.BorderSize = 0
        Me.Btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsimpan.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsimpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btnsimpan.Location = New System.Drawing.Point(467, 420)
        Me.Btnsimpan.Name = "Btnsimpan"
        Me.Btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.Btnsimpan.TabIndex = 79
        Me.Btnsimpan.Text = "Simpan"
        Me.Btnsimpan.UseVisualStyleBackColor = False
        '
        'Btntambah
        '
        Me.Btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btntambah.FlatAppearance.BorderSize = 0
        Me.Btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btntambah.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntambah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btntambah.Location = New System.Drawing.Point(359, 420)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(75, 23)
        Me.Btntambah.TabIndex = 78
        Me.Btntambah.Text = "Tambah"
        Me.Btntambah.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(357, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 193)
        Me.DataGridView1.TabIndex = 77
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(424, 150)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(204, 20)
        Me.TextBox4.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(354, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Pencarian"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 287)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 74
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(145, 261)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 20)
        Me.TextBox3.TabIndex = 73
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(145, 235)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 20)
        Me.TextBox2.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 15)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "JENIS KELAMIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "USIA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 15)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "TTL"
        '
        'TextBoxNORTU
        '
        Me.TextBoxNORTU.Location = New System.Drawing.Point(145, 208)
        Me.TextBoxNORTU.Name = "TextBoxNORTU"
        Me.TextBoxNORTU.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNORTU.TabIndex = 61
        '
        'TextBoxNL
        '
        Me.TextBoxNL.Location = New System.Drawing.Point(145, 182)
        Me.TextBoxNL.Name = "TextBoxNL"
        Me.TextBoxNL.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNL.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(17, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "NAMA ORTU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "NAMA LENGKAP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "NIK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(333, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 25)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "DAFTAR PENIMBANGAN"
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RectangleShape2.Location = New System.Drawing.Point(-1, -12)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(901, 86)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(899, 488)
        Me.ShapeContainer1.TabIndex = 84
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LineShape1.BorderWidth = 10
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 21
        Me.LineShape1.X2 = 290
        Me.LineShape1.Y1 = 327
        Me.LineShape1.Y2 = 327
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.RectangleShape5.BorderWidth = 3
        Me.RectangleShape5.CornerRadius = 10
        Me.RectangleShape5.Location = New System.Drawing.Point(346, 200)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(534, 212)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.RectangleShape4.BorderWidth = 3
        Me.RectangleShape4.CornerRadius = 10
        Me.RectangleShape4.Location = New System.Drawing.Point(346, 141)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(299, 38)
        '
        'Btncetak
        '
        Me.Btncetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btncetak.FlatAppearance.BorderSize = 0
        Me.Btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncetak.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncetak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btncetak.Location = New System.Drawing.Point(657, 148)
        Me.Btncetak.Name = "Btncetak"
        Me.Btncetak.Size = New System.Drawing.Size(75, 23)
        Me.Btncetak.TabIndex = 85
        Me.Btncetak.Text = "CETAK"
        Me.Btncetak.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(367, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 88
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
        Me.Label2.TabIndex = 87
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
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "BIDAN KOKOM"
        '
        'ComboBoxNik
        '
        Me.ComboBoxNik.FormattingEnabled = True
        Me.ComboBoxNik.Location = New System.Drawing.Point(146, 152)
        Me.ComboBoxNik.Name = "ComboBoxNik"
        Me.ComboBoxNik.Size = New System.Drawing.Size(149, 21)
        Me.ComboBoxNik.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(17, 352)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 15)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Tanggal Pemeriksaan"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(145, 347)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker1.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(18, 382)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 15)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Berat Badan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(18, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 15)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "Tinggi Badan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 377)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(65, 20)
        Me.TextBox1.TabIndex = 94
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(146, 406)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(65, 20)
        Me.TextBox5.TabIndex = 95
        '
        'Frmpenimbangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 488)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBoxNik)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btncetak)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.Btnhapus)
        Me.Controls.Add(Me.Btnbatal)
        Me.Controls.Add(Me.Btnedit)
        Me.Controls.Add(Me.Btnsimpan)
        Me.Controls.Add(Me.Btntambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxNORTU)
        Me.Controls.Add(Me.TextBoxNL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frmpenimbangan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmpenimbangan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents Btnhapus As System.Windows.Forms.Button
    Friend WithEvents Btnbatal As System.Windows.Forms.Button
    Friend WithEvents Btnedit As System.Windows.Forms.Button
    Friend WithEvents Btnsimpan As System.Windows.Forms.Button
    Friend WithEvents Btntambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNORTU As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNL As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Btncetak As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNik As System.Windows.Forms.ComboBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
End Class
