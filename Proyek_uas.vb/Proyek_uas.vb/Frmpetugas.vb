Imports System.Data.Odbc
Public Class Frmpetugas

    Private Sub btnkembali_Click(sender As System.Object, e As System.EventArgs) Handles btnkembali.Click
        Me.Close()
    End Sub

    Private Sub Frmpetugas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampilDataComboBox()
        Da = New OdbcDataAdapter("select * from tb_petugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_petugas")
        DataGridView1.DataSource = Ds.Tables("tb_petugas")
    End Sub
    Sub kondisiawal()
        TextBoxNIK.Text = ""
        TextBoxNL.Text = ""
        TextBoxTTL.Text = ""
        RichTextBoxALAMAT.Text = ""
        ComboBox1.Text = ""
        TextBoxUMUR.Text = ""
        ComboBox2.Text = ""
        Btntambah.Text = "INPUT"
        Btnedit.Text = "EDIT"
        Btnhapus.Text = "HAPUS"
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from tb_petugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_petugas")
        DataGridView1.DataSource = Ds.Tables("tb_petugas")
    End Sub


    Private Sub Btntambah_Click(sender As System.Object, e As System.EventArgs) Handles Btntambah.Click
        If TextBoxNIK.Text = "" Or TextBoxNL.Text = "" Or TextBoxTTL.Text = "" Or RichTextBoxALAMAT.Text = "" Or ComboBox1.Text = "" Or TextBoxUMUR.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("pastikan semua data terisi")
            Exit Sub
        Else

            Call Koneksi()
            Cmd = New OdbcCommand("select * from tb_petugas where nik='" & TextBoxNIK.Text & "'", Conn)
            Cmd.ExecuteReader()
            Call Koneksi()

            Dim inputdata As String
            inputdata = "insert into tb_petugas values ('" & TextBoxNIK.Text & "','" & TextBoxNL.Text & "','" & TextBoxTTL.Text & "','" & RichTextBoxALAMAT.Text & "', '" & ComboBox1.Text & "', '" & TextBoxUMUR.Text & "','" & ComboBox2.Text & "')"
            Cmd = New OdbcCommand(inputdata, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("input data berhasil")
            Call kondisiawal()
        End If
    End Sub

    Sub tampilDataComboBox()
        Call Koneksi()
        Dim str As String
        str = "select agama from tb_petugas"
        Cmd = New OdbcCommand(str, Conn)
        Dr = Cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read
                ComboBox1.Items.Add(Dr("agama"))
            Loop
        Else

        End If
    End Sub
End Class