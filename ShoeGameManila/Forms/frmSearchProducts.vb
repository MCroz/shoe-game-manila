Imports JuvyCustomControls

Public Class frmSearchProducts

    Sub clear()
        lblProductCode.Text = ""
        lblProductName.Text = ""
        lblDescription.Text = ""
        lblPrice.Text = ""
        lblBrand.Text = ""
        lblGender.Text = ""
        lblColor.Text = ""
        lblSize.Text = ""
        lblCurrentStock.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub byNameTextChanged(sender As Object, e As EventArgs) Handles byNameSearchBox.TextChanged
        If byNameSearchBox.Text.Count > 0 Then
            clear()
            Dim a As New JuvySQLORM(connectionString)
            Dim params() As String = {"%" + byNameSearchBox.Text + "%"}
            a.QuickBind(params)
            productsGrid.DataSource = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],product_description AS [Product Description],product_price AS Price,Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size, current_quantity FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID where product_name LIKE @1 ORDER BY Product.productID")
            productsGrid.Columns(0).Visible = False
            productsGrid.Columns(3).Visible = False
            productsGrid.Columns(4).Visible = False
            productsGrid.Columns(5).Visible = False
            productsGrid.Columns(6).Visible = False
            productsGrid.Columns(10).Visible = False
            productsGrid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            productsGrid.Refresh()
            a.CloseConnection()
            productsGrid.ClearSelection()
        Else
            If productsGrid.DataSource Is Nothing Then
                productsGrid.Rows.Clear()
                clear()
            Else
                productsGrid.DataSource = Nothing
                clear()
            End If
        End If
    End Sub

    Private Sub frameSizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        productsGrid.Height = Me.Height - 261
    End Sub

    Private Sub productsGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productsGrid.CellContentClick

    End Sub

    Private Sub productsGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles productsGrid.CellClick
        If productsGrid.SelectedRows.Count > 0 Then
            lblProductCode.Text = productsGrid.SelectedRows(0).Cells.Item(1).Value.ToString
            lblProductName.Text = productsGrid.SelectedRows(0).Cells.Item(2).Value.ToString
            lblDescription.Text = productsGrid.SelectedRows(0).Cells.Item(3).Value.ToString
            Dim price As Decimal = productsGrid.SelectedRows(0).Cells.Item(4).Value
            lblPrice.Text = price.ToString("C2")
            lblBrand.Text = productsGrid.SelectedRows(0).Cells.Item(6).Value.ToString
            lblGender.Text = productsGrid.SelectedRows(0).Cells.Item(7).Value.ToString
            lblColor.Text = productsGrid.SelectedRows(0).Cells.Item(8).Value.ToString
            lblSize.Text = productsGrid.SelectedRows(0).Cells.Item(9).Value.ToString
            lblCurrentStock.Text = productsGrid.SelectedRows(0).Cells.Item(10).Value.ToString
            PictureBox1.Image = getImageByID(productsGrid.SelectedRows(0).Cells.Item(0).Value.ToString, "productID", "Product", "product_image")
        End If
    End Sub

    Private Sub byCodeSearchBoxTextChanged(sender As Object, e As EventArgs) Handles byCodeSearchBox.TextChanged
        If byCodeSearchBox.Text.Count > 0 Then
            clear()
            Dim a As New JuvySQLORM(connectionString)
            Dim params() As String = {"%" + byCodeSearchBox.Text + "%"}
            a.QuickBind(params)
            productsGrid.DataSource = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],product_description AS [Product Description],product_price AS Price,Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size, current_quantity FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID where product_code LIKE @1 ORDER BY Product.productID")
            productsGrid.Columns(0).Visible = False
            productsGrid.Columns(3).Visible = False
            productsGrid.Columns(4).Visible = False
            productsGrid.Columns(5).Visible = False
            productsGrid.Columns(6).Visible = False
            productsGrid.Columns(10).Visible = False
            productsGrid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            productsGrid.Refresh()
            a.CloseConnection()
            productsGrid.ClearSelection()
        Else
            If productsGrid.DataSource Is Nothing Then
                productsGrid.Rows.Clear()
                clear()
            Else
                productsGrid.DataSource = Nothing
                clear()
            End If
        End If
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If productsGrid.SelectedRows.Count > 0 Then

        Else

        End If
    End Sub
End Class