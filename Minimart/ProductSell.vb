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
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        DG.Rows.Remove(DG.CurrentRow)
    End Sub
End Class