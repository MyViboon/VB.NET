<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSell
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
        Me.TRID = New System.Windows.Forms.TextBox()
        Me.TRdate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.record = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PROQTY = New System.Windows.Forms.TextBox()
        Me.PRONAME = New System.Windows.Forms.TextBox()
        Me.PROPRICE = New System.Windows.Forms.TextBox()
        Me.PROID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.รหัสสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคา = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.รวมราคา = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumprice = New System.Windows.Forms.TextBox()
        Me.recive = New System.Windows.Forms.TextBox()
        Me.ton = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Name_cust = New System.Windows.Forms.TextBox()
        Me.ID_cust = New System.Windows.Forms.TextBox()
        Me.User_sale = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TRID
        '
        Me.TRID.Location = New System.Drawing.Point(106, 27)
        Me.TRID.Name = "TRID"
        Me.TRID.ReadOnly = True
        Me.TRID.Size = New System.Drawing.Size(116, 20)
        Me.TRID.TabIndex = 0
        '
        'TRdate
        '
        Me.TRdate.Location = New System.Drawing.Point(300, 27)
        Me.TRdate.Name = "TRdate"
        Me.TRdate.ReadOnly = True
        Me.TRdate.Size = New System.Drawing.Size(116, 20)
        Me.TRdate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.delete)
        Me.GroupBox1.Controls.Add(Me.record)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PROQTY)
        Me.GroupBox1.Controls.Add(Me.PRONAME)
        Me.GroupBox1.Controls.Add(Me.PROPRICE)
        Me.GroupBox1.Controls.Add(Me.PROID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลการขาย"
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(479, 52)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(105, 27)
        Me.delete.TabIndex = 19
        Me.delete.Text = "ลบ"
        Me.delete.UseVisualStyleBackColor = True
        '
        'record
        '
        Me.record.Location = New System.Drawing.Point(479, 19)
        Me.record.Name = "record"
        Me.record.Size = New System.Drawing.Size(105, 27)
        Me.record.TabIndex = 18
        Me.record.Text = "ลงข้อมูล"
        Me.record.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "จำนวนสินค้า :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(240, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ราคาสินค้า :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ชื่อสินค้า :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "รหัสสินค้า :"
        '
        'PROQTY
        '
        Me.PROQTY.Location = New System.Drawing.Point(309, 54)
        Me.PROQTY.Name = "PROQTY"
        Me.PROQTY.Size = New System.Drawing.Size(116, 20)
        Me.PROQTY.TabIndex = 7
        '
        'PRONAME
        '
        Me.PRONAME.Location = New System.Drawing.Point(94, 54)
        Me.PRONAME.Name = "PRONAME"
        Me.PRONAME.ReadOnly = True
        Me.PRONAME.Size = New System.Drawing.Size(116, 20)
        Me.PRONAME.TabIndex = 6
        '
        'PROPRICE
        '
        Me.PROPRICE.Location = New System.Drawing.Point(309, 23)
        Me.PROPRICE.Name = "PROPRICE"
        Me.PROPRICE.ReadOnly = True
        Me.PROPRICE.Size = New System.Drawing.Size(116, 20)
        Me.PROPRICE.TabIndex = 5
        '
        'PROID
        '
        Me.PROID.Location = New System.Drawing.Point(94, 23)
        Me.PROID.Name = "PROID"
        Me.PROID.Size = New System.Drawing.Size(116, 20)
        Me.PROID.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 266)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียดการขาย"
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัสสินค้า, Me.ชื่อสินค้า, Me.ราคา, Me.จำนวน, Me.รวมราคา})
        Me.DG.Location = New System.Drawing.Point(5, 26)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.Size = New System.Drawing.Size(593, 234)
        Me.DG.TabIndex = 0
        '
        'รหัสสินค้า
        '
        Me.รหัสสินค้า.HeaderText = "รหัสสินค้า"
        Me.รหัสสินค้า.Name = "รหัสสินค้า"
        Me.รหัสสินค้า.ReadOnly = True
        '
        'ชื่อสินค้า
        '
        Me.ชื่อสินค้า.HeaderText = "ชื่อสินค้า"
        Me.ชื่อสินค้า.Name = "ชื่อสินค้า"
        Me.ชื่อสินค้า.ReadOnly = True
        Me.ชื่อสินค้า.Width = 200
        '
        'ราคา
        '
        Me.ราคา.HeaderText = "ราคา"
        Me.ราคา.Name = "ราคา"
        Me.ราคา.ReadOnly = True
        '
        'จำนวน
        '
        Me.จำนวน.HeaderText = "จำนวน"
        Me.จำนวน.Name = "จำนวน"
        Me.จำนวน.ReadOnly = True
        Me.จำนวน.Width = 50
        '
        'รวมราคา
        '
        Me.รวมราคา.HeaderText = "รวมราคา"
        Me.รวมราคา.Name = "รวมราคา"
        Me.รวมราคา.ReadOnly = True
        '
        'sumprice
        '
        Me.sumprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumprice.Location = New System.Drawing.Point(675, 182)
        Me.sumprice.Multiline = True
        Me.sumprice.Name = "sumprice"
        Me.sumprice.ReadOnly = True
        Me.sumprice.Size = New System.Drawing.Size(116, 30)
        Me.sumprice.TabIndex = 8
        Me.sumprice.Text = "0.00"
        '
        'recive
        '
        Me.recive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recive.Location = New System.Drawing.Point(675, 248)
        Me.recive.Multiline = True
        Me.recive.Name = "recive"
        Me.recive.Size = New System.Drawing.Size(116, 30)
        Me.recive.TabIndex = 9
        Me.recive.Text = "0.00"
        '
        'ton
        '
        Me.ton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ton.Location = New System.Drawing.Point(676, 313)
        Me.ton.Multiline = True
        Me.ton.Name = "ton"
        Me.ton.ReadOnly = True
        Me.ton.Size = New System.Drawing.Size(116, 30)
        Me.ton.TabIndex = 10
        Me.ton.Text = "0.00"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(675, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 65)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "บันทึกข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "เลขที่การขาย :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "วันที่ :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(677, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ราคารวม :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(679, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 29)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "รับเงิน :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(679, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 29)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ทอนเงิน :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Name_cust
        '
        Me.Name_cust.Location = New System.Drawing.Point(666, 117)
        Me.Name_cust.Name = "Name_cust"
        Me.Name_cust.Size = New System.Drawing.Size(116, 20)
        Me.Name_cust.TabIndex = 19
        '
        'ID_cust
        '
        Me.ID_cust.Location = New System.Drawing.Point(666, 75)
        Me.ID_cust.Name = "ID_cust"
        Me.ID_cust.Size = New System.Drawing.Size(116, 20)
        Me.ID_cust.TabIndex = 18
        '
        'User_sale
        '
        Me.User_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_sale.Location = New System.Drawing.Point(500, 20)
        Me.User_sale.Multiline = True
        Me.User_sale.Name = "User_sale"
        Me.User_sale.Size = New System.Drawing.Size(116, 35)
        Me.User_sale.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(695, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "รหัสลูกค้า :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(440, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ชื่อผู้ขาย : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(695, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "ชื่อลูกค้า :"
        '
        'ProductSell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.User_sale)
        Me.Controls.Add(Me.Name_cust)
        Me.Controls.Add(Me.ID_cust)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ton)
        Me.Controls.Add(Me.recive)
        Me.Controls.Add(Me.sumprice)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TRdate)
        Me.Controls.Add(Me.TRID)
        Me.Name = "ProductSell"
        Me.Text = "หน้าขายสินค้า"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TRID As TextBox
    Friend WithEvents TRdate As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PROQTY As TextBox
    Friend WithEvents PRONAME As TextBox
    Friend WithEvents PROPRICE As TextBox
    Friend WithEvents PROID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents sumprice As TextBox
    Friend WithEvents recive As TextBox
    Friend WithEvents ton As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DG As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents รหัสสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ราคา As DataGridViewTextBoxColumn
    Friend WithEvents จำนวน As DataGridViewTextBoxColumn
    Friend WithEvents รวมราคา As DataGridViewTextBoxColumn
    Friend WithEvents delete As Button
    Friend WithEvents record As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Name_cust As TextBox
    Friend WithEvents ID_cust As TextBox
    Friend WithEvents User_sale As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
