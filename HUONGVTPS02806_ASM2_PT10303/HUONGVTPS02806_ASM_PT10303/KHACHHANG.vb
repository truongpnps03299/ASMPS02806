'Imports System.Data.SqlClient
'Imports System.Data.DataTable
Public Class KHACHHANG

    Private Sub KHACHHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillkhachhang()
    End Sub


    Private Sub Fillkhachhang()
        Dim Sql As String =
            <sql>
                SELECT * FROM KHACHHANG
            </sql>
        Fill(Sql, "khachhang")
        bs.DataSource = ds.Tables("khachhang")
        dgv.DataSource = bs
        bs.ResetBindings(False)
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Try
            Dim RowView As DataRowView = bs.Current
            Dim Row As DataRow = RowView.Row

            txtmakh.Text = Row("MAKH")
            txttenkh.Text = Row("TENKH")
            txtdiachi.Text = Row("DIACHI")
            txtsdt.Text = Row("SDT")
            txtgioitinh.Text = Row("GIOITINH")
            txtngaysinh.Text = Row("NGAYSINH")
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btxthem_Click(sender As Object, e As EventArgs) Handles btxthem.Click
        Dim Sql As String =
                   <sql>
                        INSERT INTO KHACHHANG (MAKH, TENKH, DIACHI, SDT, GIOITINH, NGAYSINH)
                        VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}',N'{5}')
                    </sql>
        Sql = String.Format(Sql, txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsdt.Text, txtgioitinh.Text, txtngaysinh.Text)

        ExecuteNonQuery(Sql)

        fillkhachhang()
    End Sub




    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Sql As String = <sql>
                                DELETE FROM KHACHHANG
                                WHERE        (Makh = N'{0}')
                            </sql>
        Sql = String.Format(Sql, txtmakh.Text)
        ExecuteNonQuery(Sql)

        fillkhachhang()
    End Sub



    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Sql As String =
                    <sql>
                        UPDATE KHACHHANG
                        SET  TENKH = N'{0}', DIACHI = '{1}', SDT = '{2}', GIOITINH = '{3}' ,NGAYSINH = N'{4}'
                        WHERE MAKH = N'{5}'
                    </sql>
        Sql = String.Format(Sql, txttenkh.Text, txtdiachi.Text, txtsdt.Text, txtgioitinh.Text, txtngaysinh.Text, txtmakh.Text)

        ExecuteNonQuery(Sql)

        FillKHACHHANG()
    End Sub

    'Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=PS02806.mssql.somee.com;packet size=4096;user id=votanhuong261212_SQLLogin_1;pwd=ca4er69z5w;data source=PS02806.mssql.somee.com;persist security info=False;initial catalog=PS02806"
    'Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)


    'Private Sub btxthem_Click(sender As Object, e As EventArgs) Handles btxthem.Click
    '    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    '    connect.Open()
    '    Dim xem As SqlDataAdapter = New SqlDataAdapter("select KHACHHANG.MAKH as 'Mã KH' ,KHACHHANG.TENKH as 'Tên Khách Hàng', KHACHHANG.DIACHI as 'Địa chỉ', KHACHHANG.SDT as 'SĐT',KHACHHANG.GIOITINH AS ' GIỚI TÍNH', KHACHHANG.NGAYSINH from KHACHHANG", connect)
    '    Try
    '        If txtmakh.Text = "" Then
    '            MessageBox.Show("Bạn cần nhập mã KHÁCH HÀNG", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

    '        Else
    '            db.Clear()
    '            dgv.DataSource = Nothing
    '            xem.Fill(db)
    '            If db.Rows.Count > 0 Then
    '                dgv.DataSource = db.DefaultView
    '                txtmakh.Text = Nothing

    '            Else
    '                MessageBox.Show("Không tìm thấy")
    '                txtmakh.Text = Nothing
    '            End If
    '        End If
    '        connect.Close()
    '    Catch ex As Exception
    '    End Try

    'End Sub

    'Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
    '    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    '    connect.Open()
    '    Dim Sql As String = <sql>
    '                            DELETE FROM LopHoc
    '                            WHERE        (MaLH = N'{0}')
    '                        </sql>
    '    Sql = String.Format(Sql, txtmakh.Text)

    'End Sub

    'Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
    '    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    '    Dim Sql As String = <sql>
    '            INSERT INTO KHACHHANG (MAKH, TENKH, DIACHI, SDT, GIOITINH, NGAYSINH)
    '            VALUES (N'{0}', N'{1}', N'{2}',N'{3}',N'{4}',N'{5}')
    '        </sql>
    '    Sql = String.Format(Sql, txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsdt.Text, txtgioitinh.Text, txtngaysinh.Text)
    '    ExecuteNonQuery(Sql)

    '    Fillkhachang()
    'End Sub



   
End Class