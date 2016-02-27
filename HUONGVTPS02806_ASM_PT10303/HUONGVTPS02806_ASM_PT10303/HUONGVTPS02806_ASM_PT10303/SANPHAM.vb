
'Imports System.Data.SqlClient
'Imports System.Data.DataTable
Public Class SANPHAM

    Private Sub SANPHAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSANPHAM()
    End Sub
    Private Sub FillSANPHAM()
        Dim Sql As String =
            <sql>
                SELECT * FROM SANPHAM
            </sql>
        Fill(Sql, "SANPHAM")
        bs.DataSource = ds.Tables("SANPHAM")
        dgv.DataSource = bs()
        bs.ResetBindings(False)
    End Sub




    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged

        Try
            Dim RowView As DataRowView = bs.Current
            Dim Row As DataRow = RowView.Row

            txttensp.Text = Row("TENSP")
            txtmaloai.Text = Row("MALOAI")
            txtngay.Text = Row("NGAY")
            txtdiachi.Text = Row("DIACHI")
            txtmasp.Text = Row("MASP")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim Sql As String =
                   <sql>
                        INSERT INTO LOAISP (MALOAI, TENLOAI)
                        VALUES (N'{0}', N'{1}')
                    </sql>
        Sql = String.Format(Sql, txtmaloai.Text, txtmaloai.Text)

        ExecuteNonQuery(Sql)

        Dim Sql1 As String =
                   <sql>
                        INSERT INTO SANPHAM (TENSP, MALOAI, NGAY, DIACHI, MASP)
                        VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')
                    </sql>
        Sql1 = String.Format(Sql1, txttensp.Text, txtmaloai.Text, txtngay.Text, txtdiachi.Text, txtmasp.Text)

        ExecuteNonQuery(Sql1)

        FillSANPHAM()
    End Sub


    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Sql As String =
                    <sql>
                        UPDATE SANPHAM
                        SET TENSP = N'{0}', MALOAI = N'{1}', NGAY = '{2}', DIACHI = '{3}'
                        WHERE MaSP = N'{4}'
                    </sql>
        Sql = String.Format(Sql, txttensp.Text, txtmaloai.Text, txtngay.Text, txtdiachi.Text, txtmasp.Text)

        ExecuteNonQuery(Sql)

        FillSANPHAM()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click


        Dim Sql As String = <SQL>
            DELETE FROM SANPHAM  
                WHERE        (maloai = N'{0}')
        </SQL>
        Sql = String.Format(Sql, txtmaloai.Text)

        ExecuteNonQuery(Sql)

        FillSANPHAM()
    End Sub

  




    'Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=PS02806.mssql.somee.com;packet size=4096;user id=votanhuong261212_SQLLogin_1;pwd=ca4er69z5w;data source=PS02806.mssql.somee.com;persist security info=False;initial catalog=PS02806"
    'Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)





    'Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

    '    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    '    connect.Open()
    '    Dim xem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.TENSP as 'TÊN SP',SANPHAM.MALOAI as 'MA LOAI', SANPHAM.NGAY AS 'NGÀY', SANPHAM.DIACHI AS 'ĐỊA CHỈ', SANPHAM.MASP FROM SANPHAM", connect)
    '    Try
    '        If txtmasp.Text = "" Then
    '            MessageBox.Show("Bạn cần nhập mã SẢN PHẨM", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

    '        Else
    '            db.Clear()
    '            dgv.DataSource = Nothing
    '            xem.Fill(db)
    '            If db.Rows.Count > 0 Then
    '                dgv.DataSource = db.DefaultView
    '                txtmasp.Text = Nothing

    '            Else
    '                MessageBox.Show("Không tìm thấy")
    '                txtmasp.Text = Nothing
    '            End If
    '        End If
    '        connect.Close()
    '    Catch ex As Exception
    '    End Try

    'End Sub


End Class