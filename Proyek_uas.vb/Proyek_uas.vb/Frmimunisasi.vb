Imports System.Data.Odbc
Public Class Frmimunisasi

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Frmimunisasi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from tb_imunisasi", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_imunisasi")
        DataGridView1.DataSource = Ds.Tables("tb_imunisasi")
    End Sub
End Class