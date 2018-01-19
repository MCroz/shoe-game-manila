Imports JuvyCustomControls

Public Class frmStocks

    Private Sub frmStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FilterTable3("SELECT p.product_name AS [Product Name],COALESCE(SUM(im.quantity), 0 ) AS Quantity FROM InventoryMovement im RIGHT JOIN Product p ON im.productID = p.productID GROUP BY p.product_name", stocksGrid)
        refreshStocksGrid()
    End Sub

    Sub refreshStocksGrid()
        Dim a As New JuvySQLORM(connectionString)
        Dim dT As New DataTable
        dT = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size, current_quantity as [Stock On Hand] FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID ORDER BY Product.productID")
        stocksGrid.DataSource = dT
        stocksGrid.Columns(0).Visible = False
        stocksGrid.Refresh()
        a.CloseConnection()
        dT.Dispose()
    End Sub
End Class