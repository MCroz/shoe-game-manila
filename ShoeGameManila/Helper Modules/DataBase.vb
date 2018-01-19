Imports System.IO
Imports JuvyCustomControls
Imports System.Data.SqlClient
Imports Syncfusion.Windows.Forms.Tools

Module DataBase
    Function Login(ByVal username As String, ByVal password As String)
        Dim a As New JuvySQLORM(connectionString)
        Dim dT As New DataTable
        Dim params() As String = {username, password}
        a.QuickBind(params)
        dT = a.Select("Select userID, username, name,access_level,user_image from [User] where username COLLATE Latin1_General_CS_AI = @1 and password COLLATE Latin1_General_CS_AI = @2")
        If dT.Rows.Count > 0 Then
            CurrentUserID = dT.Rows(0).Item(0).ToString
            CurrentUsername = dT.Rows(0).Item(1).ToString
            CurrentAccessLevel = dT.Rows(0).Item(3).ToString
            CurrentName = dT.Rows(0).Item(2).ToString
            a.CloseConnection()
            dT.Dispose()
            Return True
        Else
            a.CloseConnection()
            dT.Dispose()
            Return False
        End If
    End Function

    Public Sub FilterTable(ByVal sql As String, ByVal datagrid As MetroFramework.Controls.MetroGrid)
        Dim a As New JuvySQLORM(connectionString)
        Dim dT As New DataTable
        dT = a.Select(sql)
        datagrid.DataSource = dT
        datagrid.Refresh()
        a.CloseConnection()
        dT.Dispose()
    End Sub

    Public Sub populateCombobox(ByVal cmbBox As ComboBoxAdv, ByVal table As String, ByVal fieldToBePopulate As String)
        Dim a As New JuvySQLORM(connectionString)
        Dim dT As New DataTable
        dT = a.Select("SELECT " & fieldToBePopulate & " from " & table)
        Dim index As Integer
        cmbBox.Items.Clear()
        For index = 0 To dT.Rows.Count - 1
            cmbBox.Items.Add(dT.Rows(index).Item(0))
        Next
        a.CloseConnection()
        dT.Dispose()
    End Sub

    Public Function getImageByID(ByVal selectedID As String, ByVal PrimaryKeyColumnName As String, ByVal table As String, ByVal imageColumnName As String)
        Dim a As New JuvySQLORM(connectionString)
        Dim params() As String = {selectedID}
        a.QuickBind(params)
        Dim imageData As Byte() = DirectCast(a.Select("SELECT " & imageColumnName & " from " & table & " where " & PrimaryKeyColumnName & " = @1").Rows(0).Item(0), Byte())
        a.CloseConnection()
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                Return Image.FromStream(ms, True)
            End Using
        Else
            Return Nothing
        End If
    End Function

    Public Sub DeleteByID(ByVal selectedID As String, ByVal PrimaryKeyColumnName As String, ByVal table As String)
        Dim a As New JuvySQLORM(connectionString)
        Dim params() As String = {selectedID}
        a.QuickBind(params)
        a.NonQuery("DELETE from " & table & " where " & PrimaryKeyColumnName & " = @1")
        a.CloseConnection()
    End Sub

    Public Function RefreshProductsGrid()
        Dim a As New JuvySQLORM(connectionString)
        Dim dT As New DataTable
        dT = a.Select("SELECT productID AS ID,product_code as [Product Code],product_name AS [Product Name],product_description AS [Product Description],product_price AS Price,Category.category_name AS [Category Name], Brand.name as Brand, gender as Gender, color as Color, size as Size FROM Product INNER JOIN Category ON Category.categoryID = Product.categoryID INNER JOIN Brand ON Product.brandID = Brand.brandID ORDER BY Product.productID")
        a.CloseConnection()
        Return dT
    End Function

    Public Sub FilterTable2(ByVal sql As String, ByVal datagrid As MetroFramework.Controls.MetroGrid)
        Dim sqlcon As New SqlConnection(connectionString2)
        Dim cmd As New SqlCommand(sql, sqlcon)

        Dim adapteer As New SqlDataAdapter
        Dim table As New DataTable
        Dim bs As New BindingSource

        adapteer.SelectCommand = cmd
        adapteer.Fill(table)
        bs.DataSource = table

        datagrid.DataSource = bs
        adapteer.Update(table)
        sqlcon.Close()
    End Sub

    Public Sub FilterTable3(ByVal sql As String, ByVal datagrid As Bunifu.Framework.UI.BunifuCustomDataGrid)
        Dim sqlcon As New SqlConnection(connectionString2)
        Dim cmd As New SqlCommand(sql, sqlcon)

        Dim adapteer As New SqlDataAdapter
        Dim table As New DataTable
        Dim bs As New BindingSource

        adapteer.SelectCommand = cmd
        adapteer.Fill(table)
        bs.DataSource = table

        datagrid.DataSource = bs
        adapteer.Update(table)
        sqlcon.Close()
    End Sub
End Module
