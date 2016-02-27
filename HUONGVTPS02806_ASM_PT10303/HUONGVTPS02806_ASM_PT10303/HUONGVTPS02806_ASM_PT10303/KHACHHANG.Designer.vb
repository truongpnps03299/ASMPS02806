<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KHACHHANG
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
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.lblngaysinh = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.txtngaysinh = New System.Windows.Forms.TextBox()
        Me.btxthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btndong = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.Location = New System.Drawing.Point(42, 9)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(43, 13)
        Me.lblmakh.TabIndex = 0
        Me.lblmakh.Text = "Mả KH:"
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.Location = New System.Drawing.Point(42, 36)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(47, 13)
        Me.lbltenkh.TabIndex = 0
        Me.lbltenkh.Text = "Tên KH:"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(42, 64)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(44, 13)
        Me.lbldiachi.TabIndex = 0
        Me.lbldiachi.Text = "Địa Chỉ:"
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Location = New System.Drawing.Point(42, 98)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(32, 13)
        Me.lblsdt.TabIndex = 0
        Me.lblsdt.Text = "SDT:"
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.Location = New System.Drawing.Point(42, 128)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(54, 13)
        Me.lblgioitinh.TabIndex = 0
        Me.lblgioitinh.Text = "Giới Tính:"
        '
        'lblngaysinh
        '
        Me.lblngaysinh.AutoSize = True
        Me.lblngaysinh.Location = New System.Drawing.Point(42, 159)
        Me.lblngaysinh.Name = "lblngaysinh"
        Me.lblngaysinh.Size = New System.Drawing.Size(59, 13)
        Me.lblngaysinh.TabIndex = 0
        Me.lblngaysinh.Text = "Ngày Sinh:"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(127, 6)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(172, 20)
        Me.txtmakh.TabIndex = 1
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(127, 34)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(172, 20)
        Me.txttenkh.TabIndex = 2
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(127, 63)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(172, 20)
        Me.txtdiachi.TabIndex = 3
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(127, 95)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(172, 20)
        Me.txtsdt.TabIndex = 4
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(127, 125)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(172, 20)
        Me.txtgioitinh.TabIndex = 5
        '
        'txtngaysinh
        '
        Me.txtngaysinh.Location = New System.Drawing.Point(127, 156)
        Me.txtngaysinh.Name = "txtngaysinh"
        Me.txtngaysinh.Size = New System.Drawing.Size(172, 20)
        Me.txtngaysinh.TabIndex = 6
        '
        'btxthem
        '
        Me.btxthem.Location = New System.Drawing.Point(390, 12)
        Me.btxthem.Name = "btxthem"
        Me.btxthem.Size = New System.Drawing.Size(75, 23)
        Me.btxthem.TabIndex = 2
        Me.btxthem.Text = "Thêm"
        Me.btxthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(390, 49)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(390, 89)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 4
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btndong
        '
        Me.btndong.Location = New System.Drawing.Point(390, 128)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(75, 23)
        Me.btndong.TabIndex = 5
        Me.btndong.Text = "Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(24, 187)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(518, 146)
        Me.dgv.TabIndex = 6
        '
        'KHACHHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 342)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btxthem)
        Me.Controls.Add(Me.txtngaysinh)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.lblngaysinh)
        Me.Controls.Add(Me.lblgioitinh)
        Me.Controls.Add(Me.lblsdt)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.lblmakh)
        Me.Name = "KHACHHANG"
        Me.Text = "KHÁCH HÀNG"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents lblngaysinh As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtgioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtngaysinh As System.Windows.Forms.TextBox
    Friend WithEvents btxthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btndong As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents bs As System.Windows.Forms.BindingSource
End Class
