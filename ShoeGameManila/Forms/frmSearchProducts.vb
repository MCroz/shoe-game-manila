Imports JuvyCustomControls

Public Class frmSearchProducts

    Private Sub byNameTextChanged(sender As Object, e As EventArgs) Handles byNameSearchBox.TextChanged
        If byNameSearchBox.Text.Count > 0 Then
            Dim a As New JuvySQLORM(connectionString)
            Dim params() As String = {"%" + byNameSearchBox.Text + "%"}
            a.QuickBind(params)
            productsGrid.DataSource = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],product_description AS [Product Description],product_price AS Price,Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID where product_name LIKE @1 ORDER BY Product.productID")
            productsGrid.Columns(0).Visible = False
            productsGrid.Columns(3).Visible = False
            productsGrid.Columns(4).Visible = False
            productsGrid.Columns(5).Visible = False
            productsGrid.Columns(6).Visible = False
            productsGrid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            productsGrid.Refresh()
            a.CloseConnection()
        Else
            If productsGrid.DataSource Is Nothing Then
                productsGrid.Rows.Clear()
            Else
                productsGrid.DataSource = Nothing
            End If
        End If
    End Sub

    Private Sub frameSizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        productsGrid.Height = Me.Height - 261
    End Sub
End Class