<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SANPHAM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblten = New System.Windows.Forms.Label()
        Me.lblmaloai = New System.Windows.Forms.Label()
        Me.lblngay = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txtngay = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btndong = New System.Windows.Forms.Button()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblten
        '
        Me.lblten.AutoSize = True
        Me.lblten.Location = New System.Drawing.Point(37, 17)
        Me.lblten.Name = "lblten"
        Me.lblten.Size = New System.Drawing.Size(46, 13)
        Me.lblten.TabIndex = 0
        Me.lblten.Text = "Tên SP:"
        '
        'lblmaloai
        '
        Me.lblmaloai.AutoSize = True
        Me.lblmaloai.Location = New System.Drawing.Point(37, 50)
        Me.lblmaloai.Name = "lblmaloai"
        Me.lblmaloai.Size = New System.Drawing.Size(48, 13)
        Me.lblmaloai.TabIndex = 0
        Me.lblmaloai.Text = "Mã Loại:"
        '
        'lblngay
        '
        Me.lblngay.AutoSize = True
        Me.lblngay.Location = New System.Drawing.Point(37, 88)
        Me.lblngay.Name = "lblngay"
        Me.lblngay.Size = New System.Drawing.Size(35, 13)
        Me.lblngay.TabIndex = 0
        Me.lblngay.Text = "Ngày:"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(37, 127)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(44, 13)
        Me.lbldiachi.TabIndex = 0
        Me.lbldiachi.Text = "Địa Chỉ:"
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(37, 163)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(42, 13)
        Me.lblmasp.TabIndex = 0
        Me.lblmasp.Text = "Mã SP:"
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(124, 11)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(162, 20)
        Me.txttensp.TabIndex = 1
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(124, 47)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(162, 20)
        Me.txtmaloai.TabIndex = 2
        '
        'txtngay
        '
        Me.txtngay.Location = New System.Drawing.Point(124, 85)
        Me.txtngay.Name = "txtngay"
        Me.txtngay.Size = New System.Drawing.Size(162, 20)
        Me.txtngay.TabIndex = 3
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(124, 124)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(162, 20)
        Me.txtdiachi.TabIndex = 4
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(124, 160)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(162, 20)
        Me.txtmasp.TabIndex = 5
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 190)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(548, 138)
        Me.dgv.TabIndex = 6
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(390, 17)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 7
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(390, 60)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 7
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(390, 98)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 7
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btndong
        '
        Me.btndong.Location = New System.Drawing.Point(390, 137)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(75, 23)
        Me.btndong.TabIndex = 7
        Me.btndong.Text = "Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'SANPHAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 340)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtngay)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.lblmasp)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblngay)
        Me.Controls.Add(Me.lblmaloai)
        Me.Controls.Add(Me.lblten)
        Me.Name = "SANPHAM"
        Me.Text = "SẢN PHẨM"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblten As System.Windows.Forms.Label
    Friend WithEvents lblmaloai As System.Windows.Forms.Label
    Friend WithEvents lblngay As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txtngay As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btndong As System.Windows.Forms.Button
    Friend WithEvents bs As System.Windows.Forms.BindingSource
End Class
