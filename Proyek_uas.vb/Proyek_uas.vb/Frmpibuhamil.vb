Imports System.Data.Odbc
Public Class Frmpibuhamil
   
    Private Sub Frmpibuhamil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from tb_ibuhamil", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_ibuhamil")
        DataGridView1.DataSource = Ds.Tables("tb_ibuhamil")
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class