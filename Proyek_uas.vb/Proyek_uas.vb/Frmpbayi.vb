Imports System.Data.Odbc
Public Class Frmpbayi

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Btnkembali.Click
        Me.Close()
    End Sub

    Private Sub Frmpbayi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBoxnama.Text = ""
        TextBoxTTLBayi.Text = ""
        TextBoxtempat.Text = ""
        ComboBoxJenkel.Text = ""
        TextBoxUsiabayi.Text = ""
        Btntambah.Text = "INPUT"
        Btnedit.Text = "EDIT"
        Btnhapus.Text = "HAPUS"
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from tb_bayi", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_bayi")
        DataGridView1.DataSource = Ds.Tables("tb_bayi")

    End Sub

    Private Sub Btntambah_Click(sender As System.Object, e As System.EventArgs) Handles Btntambah.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBoxnama.Text = "" Or TextBoxTTLBayi.Text = "" Or TextBoxtempat.Text = "" Or ComboBoxJenkel.Text = "" Or TextBoxUsiabayi.Text = "" Then
            MsgBox("pastikan semua data terisi")
            Exit Sub
        Else

            Call Koneksi()
            Cmd = New OdbcCommand("select * from tb_bayi where nik='" & TextBox1.Text & "'", Conn)
            Cmd.ExecuteReader()
                Call Koneksi()

                Dim inputdata As String
                inputdata = "insert into tb_bayi values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBoxnama.Text & "','" & TextBoxTTLBayi.Text & "', '" & TextBoxtempat.Text & "', '" & ComboBoxJenkel.Text & "','" & TextBoxUsiabayi.Text & "')"
                Cmd = New OdbcCommand(inputdata, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("input data berhasil")
                Call kondisiawal()

            End If
    End Sub
End Class
