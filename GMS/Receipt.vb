Public Class Receipt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtctrlno.Text = "") Then
            MsgBox("Control No is required!!")
        Else

            txtquantity.Text = Convert.ToInt32(txtqty1.Text) + Convert.ToInt32(txtqty2.Text) + Convert.ToInt32(txtqty3.Text) + Convert.ToInt32(txtqty4.Text)
            txtprice.Text = txtquantity.Text * 15
            Reportviewer.Fullname = txtName.Text
            Reportviewer.ImageNo1 = txtImg1.Text
            Reportviewer.ImageNo2 = txtImg2.Text
            Reportviewer.ImageNo3 = txtImg3.Text
            Reportviewer.ImageNo4 = txtImg4.Text
            Reportviewer.Quantity1 = txtqty1.Text
            Reportviewer.Quantity2 = txtqty2.Text
            Reportviewer.Quantity3 = txtqty3.Text
            Reportviewer.Quantity4 = txtqty4.Text
            Reportviewer.TotalQuantity = txtquantity.Text
            Reportviewer.ControlNo = txtctrlno.Text
            Reportviewer.TotalPrice = txtprice.Text

            Reportviewer.Show()
        End If

    End Sub

    Private Sub Reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtqty1_TextChanged(sender As Object, e As EventArgs) Handles txtqty1.TextChanged


    End Sub

End Class