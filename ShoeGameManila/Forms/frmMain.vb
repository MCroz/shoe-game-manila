Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmPOS.Visible = False
        frmManagement.Visible = True
        frmSearchProducts.Visible = False
        populateCombobox(diagNewProduct.scmbBrand, "Brand", "Name")
        populateCombobox(diagNewProduct.tcmbBrand, "Brand", "Name")

    End Sub
End Class