Imports JuvyCustomControls

Public Class frmProducts
    Dim selectMode As String = "Name"
    Dim selectedID As String
    Dim rightPanelShown As Boolean = False

    Sub refreshTable()
        Dim a As New JuvySQLORM(connectionString)
        Dim dT As New DataTable
        dT = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],product_description AS [Product Description],product_price AS Price,Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID ORDER BY Product.productID")
        productsGrid.DataSource = dT
        productsGrid.Columns(0).Visible = False
        productsGrid.Refresh()
        countLabel.Text = "Products Count: " + dT.Rows.Count.ToString
        a.CloseConnection()
        dT.Dispose()
    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'refreshTable()
    End Sub

    Private Sub frameSizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        productsGrid.Height = Me.Height - 146
        productsGrid.Width = Me.Width - 20
        countPanel.Width = Me.Width - 830
    End Sub

    Private Sub byCodeButton_Click(sender As Object, e As EventArgs) Handles byCodeButton.Click
        byCodeButton.IsTab = True
        byCodeButton.selected = True
        byNameButton.IsTab = False
        byNameButton.selected = False
        searchTxtbox.WaterMark = "Search by Code"
        selectMode = "Code"
    End Sub

    Private Sub byNameButton_Click(sender As Object, e As EventArgs) Handles byNameButton.Click
        byCodeButton.IsTab = False
        byCodeButton.selected = False
        byNameButton.IsTab = True
        byNameButton.selected = True
        searchTxtbox.WaterMark = "Search by Name"
        selectMode = "Name"
    End Sub

    Private Sub SearchBoxTextChanged(sender As Object, e As EventArgs) Handles searchTxtbox.TextChanged
        If selectMode = "Name" Then
            Dim a As New JuvySQLORM(connectionString)
            Dim params() As String = {"%" + searchTxtbox.Text + "%"}
            a.QuickBind(params)
            Dim dT As New DataTable
            dT = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],product_description AS [Product Description],product_price AS Price,Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID where product_name LIKE @1 ORDER BY Product.productID")
            productsGrid.DataSource = dT
            productsGrid.Refresh()
            countLabel.Text = "Products Count: " + dT.Rows.Count.ToString
            a.CloseConnection()
            dT.Dispose()
        Else
            Dim a As New JuvySQLORM(connectionString)
            Dim params() As String = {"%" + searchTxtbox.Text + "%"}
            a.QuickBind(params)
            Dim dT As New DataTable
            dT = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],product_description AS [Product Description],product_price AS Price,Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID where product_code LIKE @1 ORDER BY Product.productID")
            productsGrid.DataSource = dT
            productsGrid.Refresh()
            countLabel.Text = "Products Count: " + dT.Rows.Count.ToString
            a.CloseConnection()
            dT.Dispose()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If productsGrid.SelectedRows.Count = 0 Then
            errorMessageBox(frmManagement, "No Products Selected")
        Else
            selectedID = productsGrid.SelectedRows(0).Cells.Item(0).Value.ToString
            Dim a As String = questionMessageBox(frmManagement, "Are You Sure You Want To Delete" & vbNewLine _
                               & productsGrid.SelectedRows(0).Cells.Item(1).Value.ToString)
            If a = 6 Then
                DeleteByID(selectedID, "productID", "Product")
                successMessageBox(frmManagement, "Successfully deleted the product!")
                refreshTable()
            End If

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshTable()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        diagNewProduct.headerLabel.Text = "Add Product"
        If diagNewProduct.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RefreshProductsGrid()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If productsGrid.SelectedRows.Count > 0 Then
            diagNewProduct.headerLabel.Text = "Update Product"
            diagNewProduct.selectedID = productsGrid.SelectedRows(0).Cells.Item(0).Value.ToString
            Dim cat As String = productsGrid.SelectedRows(0).Cells.Item(5).Value.ToString

            If cat = "Shoes" Then
                diagNewProduct.AljonCustomTabControl1.SelectedIndex = 0
                diagNewProduct.scmbBrand.SelectedItem = productsGrid.SelectedRows(0).Cells.Item(6).Value.ToString
                diagNewProduct.scmbGender.SelectedItem = productsGrid.SelectedRows(0).Cells.Item(7).Value.ToString
                diagNewProduct.scmbSize.SelectedItem = productsGrid.SelectedRows(0).Cells.Item(9).Value.ToString
                diagNewProduct.spnameTxtbox.Text = productsGrid.SelectedRows(0).Cells.Item(2).Value.ToString
                diagNewProduct.spdecTxtbox.Text = productsGrid.SelectedRows(0).Cells.Item(3).Value.ToString
                diagNewProduct.scolorTxtbox.Text = productsGrid.SelectedRows(0).Cells.Item(8).Value.ToString
                diagNewProduct.spriceTxtbox.DecimalValue = productsGrid.SelectedRows(0).Cells.Item(4).Value
                diagNewProduct.PictureBox1.Image = getImageByID(productsGrid.SelectedRows(0).Cells.Item(0).Value.ToString, "productID", "Product", "product_image")
                diagNewProduct.spcodeTxtbox.Text = productsGrid.SelectedRows(0).Cells.Item(1).Value.ToString
            Else
                diagNewProduct.AljonCustomTabControl1.SelectedIndex = 1
                diagNewProduct.tcmbBrand.SelectedItem = productsGrid.SelectedRows(0).Cells.Item(6).Value.ToString
                diagNewProduct.tcmbColor.SelectedItem = productsGrid.SelectedRows(0).Cells.Item(8).Value.ToString
                diagNewProduct.tcmbGender.SelectedItem = productsGrid.SelectedRows(0).Cells.Item(7).Value.ToString
                diagNewProduct.tcmbSize.SelectedItem = productsGrid.SelectedRows(0).Cells.Item(9).Value.ToString
                diagNewProduct.tpdecTxtbox.Text = productsGrid.SelectedRows(0).Cells.Item(3).Value.ToString
                diagNewProduct.tpnameTxtbox.Text = productsGrid.SelectedRows(0).Cells.Item(2).Value.ToString
                diagNewProduct.tpriceTxtbox.DecimalValue = productsGrid.SelectedRows(0).Cells.Item(4).Value
                diagNewProduct.PictureBox2.Image = getImageByID(productsGrid.SelectedRows(0).Cells.Item(0).Value.ToString, "productID", "Product", "product_image")
                diagNewProduct.tpcodeTxtbox.Text = productsGrid.SelectedRows(0).Cells.Item(1).Value.ToString
            End If

            If diagNewProduct.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshProductsGrid()
            End If
        End If
    End Sub
End Class