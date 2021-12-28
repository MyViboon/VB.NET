Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ProductID.Text = "" Then
            MsgBox("กรุณากรอกรหัสสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductName.Text = "" Then
            MsgBox("กรุณากรอกชื่อสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductPrice.Text = "" Then
            MsgBox("กรุณากรอกราคาสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductQty.Text = "" Then
            MsgBox("กรุณากรอกจำนวนสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductType.Text = "" Then
            MsgBox("กรุณาระบุประเภทสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductUnit.Text = "" Then
            MsgBox("กรุณาระบุหน่วยสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'เช็ค DATA ID
        Dim checkdata As DataTable = executesql("SELECT Product_ID FROM TBL_INVENTORY WHERE Product_ID ='" & ProductID.Text & "'")
        If checkdata.Rows.Count > 0 Then
            MsgBox("มีรหัสสินค้าซ้ำในระบบ ไม่อนุญาติให้เพิ่มข้อมูล", MsgBoxStyle.Critical)
            Exit Sub
        End If

        executesql("INSERT INTO TBL_INVENTORY(Product_ID, Product_Name, Product_Price, Product_Qty, Product_Type, Product_Unit)VALUES('" & ProductID.Text & "','" & ProductName.Text & "','" & ProductPrice.Text & "',
    '" & ProductQty.Text & "','" & ProductType.Text & "','" & ProductUnit.Text & "')")
        MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
        ProductID.Clear()
        ProductName.Clear()
        ProductPrice.Clear()
        ProductQty.Clear()
        ProductType.Clear()
        ProductUnit.Clear()

        'แสดงข้อมูลใน Table
        LOADTABLEDATA()

    End Sub
    Sub LOADTABLEDATA()
        Dim LOADDATA As DataTable = executesql("SELECT * FROM TBL_INVENTORY ")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        DataGridView1.Columns(1).HeaderText = "ชื่อสินค้า"
        DataGridView1.Columns(2).HeaderText = "ราคาสินค้า"
        DataGridView1.Columns(3).HeaderText = "จำนวน"
        DataGridView1.Columns(4).HeaderText = "ประเภทสินค้า"
        DataGridView1.Columns(5).HeaderText = "หน่วยนับ"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N2"
    End Sub
    Private Sub ProductPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub ProductQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case Else
                e.Handled = True
                'MessageBox.Show("สามารถกดได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADTABLEDATA()
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            executesql("DELETE FROM TBL_INVENTORY WHERE PRODUCT_ID = '" & DataGridView1.CurrentRow.Cells(0).Value & "'")
            MsgBox("ลบข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
            LOADTABLEDATA()
        Catch ex As Exception
            MsgBox("ไม่มีข้อมูลลบ", MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ProductID.Text = DataGridView1.CurrentRow.Cells(0).Value
        ProductName.Text = DataGridView1.CurrentRow.Cells(1).Value
        ProductPrice.Text = DataGridView1.CurrentRow.Cells(2).Value
        ProductPrice.Text = CDbl(ProductPrice.Text).ToString("##,##0.00")
        ProductQty.Text = DataGridView1.CurrentRow.Cells(3).Value
        ProductType.Text = DataGridView1.CurrentRow.Cells(4).Value
        ProductUnit.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ProductID.Text = "" Then
            MsgBox("กรุณากรอกรหัสสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductName.Text = "" Then
            MsgBox("กรุณากรอกชื่อสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductPrice.Text = "" Then
            MsgBox("กรุณากรอกราคาสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductQty.Text = "" Then
            MsgBox("กรุณากรอกจำนวนสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductType.Text = "" Then
            MsgBox("กรุณาระบุประเภทสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProductUnit.Text = "" Then
            MsgBox("กรุณาระบุหน่วยสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If

        executesql("UPDATE TBL_INVENTORY SET Product_Name ='" & ProductName.Text & "',Product_Price = '" & ProductPrice.Text & "',Product_Qty = '" & ProductQty.Text & "',Product_Type = '" & ProductType.Text & "',Product_Unit = '" & ProductUnit.Text & "'WHERE Product_ID = '" & ProductID.Text & "'")
        ProductID.Clear()
        ProductName.Clear()
        ProductPrice.Clear()
        ProductQty.Clear()
        ProductType.Clear()
        ProductUnit.Clear()
        MsgBox("แก้ไขเรียบร้อยแล้ว", MsgBoxStyle.Information)
        LOADTABLEDATA()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ProductID.Clear()
        ProductName.Clear()
        ProductPrice.Clear()
        ProductQty.Clear()
        ProductType.Clear()
        ProductUnit.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ProductSell.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        day.Text = Now.ToShortDateString
        time.Text = TimeOfDay
    End Sub
End Class