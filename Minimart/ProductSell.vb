Public Class ProductSell

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PROID.TextChanged
        Dim productdata As DataTable = executesql("select product_id, product_name, product_price from Tbl_inventory WHERE  product_id='" & PROID.Text & "'")
        If productdata.Rows.Count > 0 Then
            PRONAME.Text = productdata(0)("product_name")
            PROPRICE.Text = productdata(0)("product_price")
        Else
            PRONAME.Clear()
            PROPRICE.Clear()
        End If

    End Sub

    Private Sub recive_TextChanged(sender As Object, e As EventArgs) Handles recive.TextChanged
        Try
            ton.Text = CDbl(recive.Text) - CDbl(sumprice.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub record_Click(sender As Object, e As EventArgs) Handles record.Click
        If PRONAME.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ถูกต้อง !!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If PROQTY.Text = "" Then
            MsgBox("กรุณากรอกจำนวน ?", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If PROQTY.Text = 0 Then
            MsgBox("กรุณากรอกจำนวนขายให้ถูกต้อง!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim ราคารวม As Double = CDbl(PROPRICE.Text) * CDbl(PROQTY.Text)
        DG.Rows.Add(PROID.Text, PRONAME.Text, PROPRICE.Text, PROQTY.Text, ราคารวม)
        PROID.Clear()
        PRONAME.Clear()
        PROPRICE.Clear()
        PROQTY.Clear()
        calc()
    End Sub
    Sub calc()

        Dim ราคารวม As Double
        For i As Integer = 0 To DG.Rows.Count - 1
            ราคารวม += DG.Rows(i).Cells(4).Value
        Next
        sumprice.Text = ราคารวม
        sumprice.Text = CDbl(sumprice.Text).ToString("##,##0.00")
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        DG.Rows.Remove(DG.CurrentRow)
        calc()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TRdate.Text = Now.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ton.Text <= 0 Then
            MsgBox("รับเงินมาไม่ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'บันทึกข้อมูลหลัก
        executesql("INSERT INTO Tbl_Transection(TR_ID, TR_DATE, TR_SUMPRICE, TR_RECIVEMONEY, TR_TONMONEY, ID_Customer, Name_Customer, User_sale )VALUES('" & TRID.Text & "',GETDATE(),'" & sumprice.Text & "','" & recive.Text & "','" & ton.Text & "','" & ID_cust.Text & "','" & Name_cust.Text & "','" & User_sale.Text & "')")

        'บันทึกข้อมูลรอง
        For i As Integer = 0 To DG.Rows.Count - 1
            executesql("INSERT INTO  Tbl_TransectionSaleDetail(TR_ID, PRO_ID, PRO_NAME, PRO_PRICE, PRO_QTY, PRO_SUMPRICE)VALUES('" & TRID.Text & "','" & DG.Rows(i).Cells(0).Value & "','" & DG.Rows(i).Cells(1).Value & "','" & DG.Rows(i).Cells(2).Value & "','" & DG.Rows(i).Cells(3).Value & "','" & DG.Rows(i).Cells(4).Value & "')")
        Next
        MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
        sumprice.Text = "0.00"
        recive.Text = "0.00"
        ton.Text = "0.00"
        ID_cust.Clear()
        Name_cust.Clear()
        DG.Rows.Clear()
        autoid()


    End Sub

    Sub autoid()
        Dim sql As String = "SELECT('TR' + SUBSTRING(CONVERT(NVARCHAR(4), YEAR(GETDATE()) + 543),3,2) + SUBSTRING(REPLACE(CONVERT(NVARCHAR(8), GETDATE(), 103), '/' , ''),3,2) + REPLICATE('0', 6 - LEN(IDENT_CURRENT('Tbl_Transection'))) + CONVERT(NVARCHAR(6), IDENT_CURRENT('Tbl_Transection'))) as autonum"
        Dim data As DataTable = executesql(sql)
        TRID.Text = data(0)("autonum").ToString


    End Sub

    Private Sub ProductSell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoid()

    End Sub

    Private Sub PROID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PROID.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub PROQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PROQTY.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case Else
                e.Handled = True
        End Select
    End Sub

End Class