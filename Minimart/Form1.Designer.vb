<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductID = New System.Windows.Forms.TextBox()
        Me.ProductName = New System.Windows.Forms.TextBox()
        Me.ProductPrice = New System.Windows.Forms.TextBox()
        Me.ProductQty = New System.Windows.Forms.TextBox()
        Me.ProductType = New System.Windows.Forms.TextBox()
        Me.ProductUnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.day = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(277, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "บันทึกข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductID
        '
        Me.ProductID.Location = New System.Drawing.Point(103, 60)
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Size = New System.Drawing.Size(255, 20)
        Me.ProductID.TabIndex = 1
        '
        'ProductName
        '
        Me.ProductName.Location = New System.Drawing.Point(103, 86)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Size = New System.Drawing.Size(255, 20)
        Me.ProductName.TabIndex = 2
        '
        'ProductPrice
        '
        Me.ProductPrice.Location = New System.Drawing.Point(103, 112)
        Me.ProductPrice.Name = "ProductPrice"
        Me.ProductPrice.Size = New System.Drawing.Size(255, 20)
        Me.ProductPrice.TabIndex = 3
        '
        'ProductQty
        '
        Me.ProductQty.Location = New System.Drawing.Point(104, 138)
        Me.ProductQty.Name = "ProductQty"
        Me.ProductQty.Size = New System.Drawing.Size(255, 20)
        Me.ProductQty.TabIndex = 4
        '
        'ProductType
        '
        Me.ProductType.Location = New System.Drawing.Point(104, 164)
        Me.ProductType.Name = "ProductType"
        Me.ProductType.Size = New System.Drawing.Size(255, 20)
        Me.ProductType.TabIndex = 5
        '
        'ProductUnit
        '
        Me.ProductUnit.Location = New System.Drawing.Point(104, 190)
        Me.ProductUnit.Name = "ProductUnit"
        Me.ProductUnit.Size = New System.Drawing.Size(255, 20)
        Me.ProductUnit.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "รหัสสินค้า :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ชื่อสินค้า :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ราคาสินค้า :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "จำนวน :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ประเภทสินค้า :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "หน่วย :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(384, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(366, 289)
        Me.DataGridView1.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(190, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "ลบข้อมูล"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(277, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 35)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "แก้ไขข้อมูล"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(190, 238)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 35)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(59, 238)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 76)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "ขายสินค้า"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "วันที่ :"
        '
        'day
        '
        Me.day.AutoSize = True
        Me.day.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day.Location = New System.Drawing.Point(88, 18)
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(57, 20)
        Me.day.TabIndex = 19
        Me.day.Text = "Label8"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.Location = New System.Drawing.Point(225, 18)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(57, 20)
        Me.time.TabIndex = 20
        Me.time.Text = "Label9"
        '
        'Timer1
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(186, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "เวลา :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 336)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.day)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductUnit)
        Me.Controls.Add(Me.ProductType)
        Me.Controls.Add(Me.ProductQty)
        Me.Controls.Add(Me.ProductPrice)
        Me.Controls.Add(Me.ProductName)
        Me.Controls.Add(Me.ProductID)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "หน้าหลัก"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ProductID As TextBox
    Friend WithEvents ProductName As TextBox
    Friend WithEvents ProductPrice As TextBox
    Friend WithEvents ProductQty As TextBox
    Friend WithEvents ProductType As TextBox
    Friend WithEvents ProductUnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents day As Label
    Friend WithEvents time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
End Class
