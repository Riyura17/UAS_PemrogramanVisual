Imports System.Data.Odbc
Public Class Frmpenimbangan


    Private Sub btnkembali_Click(sender As System.Object, e As System.EventArgs) Handles btnkembali.Click
        Me.Close()
    End Sub

    Private Sub Frmpenimbangan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from tb_bayi_periksa", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_bayi_periksa")
        DataGridView1.DataSource = Ds.Tables("tb_bayi_periksa")
    End Sub
End Class