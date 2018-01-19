Public Class frmManagement

    Private Sub frameSizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        headerLine.X1 = 0
        headerLine.X2 = Me.Width
    End Sub

    Private Sub navProducts_Click(sender As Object, e As EventArgs) Handles navProducts.Click
        showFormInsidePanel(mainContainer, frmProducts)
        headerLabel.Text = "Products"
    End Sub

    Private Sub navStock_Click(sender As Object, e As EventArgs) Handles navStock.Click
        showFormInsidePanel(mainContainer, frmStocks)
        headerLabel.Text = "Products"
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        frmPOS.Show()
    End Sub
End Class