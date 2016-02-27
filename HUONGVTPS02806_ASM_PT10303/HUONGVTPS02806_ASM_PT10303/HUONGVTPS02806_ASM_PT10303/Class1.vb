'Imports System.Data.SqlClient
'Imports System.Data
Imports System.Data.SqlClient
Module class1
    Public User As DataRow

    Public ds As New DataSet()

    Public ConnectionString As String = "workstation id=PS02806.mssql.somee.com;packet size=4096;user id=votanhuong261212_SQLLogin_1;pwd=ca4er69z5w;data source=PS02806.mssql.somee.com;persist security info=False;initial catalog=PS02806"

    Public Sub ExecuteNonQuery(Sql As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand(Sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub Fill(Sql As String, TableName As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
        Connection.Close()
    End Sub

End Module

'Public Function Loadkhachang() As DataSet
'    Dim chuoiketnoi As String = "workstation id=PS02806.mssql.somee.com;packet size=4096;user id=votanhuong261212_SQLLogin_1;pwd=ca4er69z5w;data source=PS02806.mssql.somee.com;persist security info=False;initial catalog=PS02806"
'    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
'    Dim LoadKH As New SqlDataAdapter("select KHACHHANG.MAKH as 'Mã KH' ,KHACHHANG.TENKH as 'Tên Khách Hàng', KHACHHANG.DIACHI as 'Địa chỉ', KHACHHANG.SDT as 'SĐT',KHACHHANG.GIOITINH AS ' GIỚI TÍNH', KHACHHANG.NGAYSINH from KHACHANG", conn)
'    Dim db As New DataSet
'    conn.Open()
'    LoadKH.Fill(db)
'    conn.Close()
'    Return db
'End Function
'Public Function Loadsanpham() As DataSet
'    Dim chuoiketnoi As String = "workstation id=PS02806.mssql.somee.com;packet size=4096;user id=votanhuong261212_SQLLogin_1;pwd=ca4er69z5w;data source=PS02806.mssql.somee.com;persist security info=False;initial catalog=PS02806"
'    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
'    Dim LoadSP As New SqlDataAdapter("select SANPHAM.TENSP as 'TÊN SP',SANPHAM.MALOAI as 'MA LOAI', SANPHAM.NGAY AS 'NGÀY', SANPHAM.DIACHI AS 'ĐỊA CHỈ', SANPHAM.MASP FROM SANPHAM", conn)
'    Dim db As New DataSet
'    conn.Open()
'    LoadSP.Fill(db)
'    conn.Close()
'    Return db
'End Function

