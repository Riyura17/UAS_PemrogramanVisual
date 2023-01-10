Imports System.Data.Odbc
Module Module1

    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Dr As OdbcDataReader
    Public Ds As DataSet
    Public Cmd As OdbcCommand


    Public MyDB As String

    Public Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 8.0 ANSI Driver};database=project_visual;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module