Imports System.Data.Odbc
Public Class Frmpemeriksaan

    Private Sub Frmpemeriksaan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from tb_ibuhamil_periksa", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_ibuhamil_periksa")
        DataGridView1.DataSource = Ds.Tables("tb_ibuhamil_periksa")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class