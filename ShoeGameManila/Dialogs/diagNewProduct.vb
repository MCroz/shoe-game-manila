Imports JuvyCustomControls

Public Class diagNewProduct
    Public selectedID As String


    Private Sub clear()
        scmbBrand.SelectedIndex = -1
        scmbGender.SelectedIndex = -1
        scmbSize.SelectedIndex = -1
        spnameTxtbox.Text = ""
        spdecTxtbox.Text = ""
        scolorTxtbox.Text = ""
        spriceTxtbox.DecimalValue = 1.0
        tcmbBrand.SelectedIndex = -1
        tcmbColor.SelectedIndex = -1
        tcmbGender.SelectedIndex = -1
        tcmbSize.SelectedIndex = -1
        tpdecTxtbox.Text = ""
        tpnameTxtbox.Text = ""
        tpriceTxtbox.DecimalValue = 1.0
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        tpcodeTxtbox.Text = ""
        spcodeTxtbox.Text = ""
    End Sub

    Private Sub FrameOnLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub browserImage_Click(sender As Object, e As EventArgs) Handles browserImage.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub shoesOK_Click(sender As Object, e As EventArgs) Handles shoesOK.Click
        If headerLabel.Text = "Add Product" Then
            If spcodeTxtbox.Text = "" Or scmbGender.SelectedIndex = -1 Or spnameTxtbox.Text = "" Or scmbBrand.SelectedIndex = -1 Or scmbSize.SelectedIndex = -1 Or scolorTxtbox.Text = "" Or PictureBox1.Image Is Nothing Then
                MessageBox.Show("Please Fill All The Fields")
            Else
                Dim a As New JuvySQLORM(connectionString)
                a.AddImageParameters = True
                a.imageData = GetImageDataFromPictureBox(PictureBox1)
                Dim params() As String = {spnameTxtbox.Text, spdecTxtbox.Text, spriceTxtbox.DecimalValue.ToString, "Shoes", scmbBrand.SelectedItem.ToString, scolorTxtbox.Text, scmbSize.SelectedItem.ToString, scmbGender.SelectedItem.ToString, spcodeTxtbox.Text}
                a.QuickBind(params)
                a.NonQuery("INSERT INTO [Product] (product_name,product_description,product_price,product_image,categoryID,brandID,color,size,gender,product_code) VALUES (@1,@2,@3,@image,(SELECT categoryID FROM Category WHERE category_name = @4),(SELECT brandID FROM Brand Where name = @5),@6,@7,@8,@9)")
                a.CloseConnection()

                successMessageBox(frmManagement, "Successfully Added a New Product!")
                clear()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Dim a As New JuvySQLORM(connectionString)
            a.AddImageParameters = True
            a.imageData = GetImageDataFromPictureBox(PictureBox1)
            Dim params() As String = {spnameTxtbox.Text, spdecTxtbox.Text, spriceTxtbox.DecimalValue.ToString, "Shoes", scmbBrand.SelectedItem.ToString, scolorTxtbox.Text, scmbSize.SelectedItem.ToString, scmbGender.SelectedItem.ToString, tpcodeTxtbox.Text, selectedID}
            a.QuickBind(params)
            a.NonQuery("UPDATE Product SET product_name=@1,product_description=@2,product_price=@3,product_image=@image,categoryID = (SELECT categoryID FROM Category WHERE category_name = @4),brandID = (SELECT brandID FROM Brand Where name = @5), date_updated = (getdate()),color = @6, size = @7, gender = @8, product_code = @9 WHERE productID=@10")
            a.CloseConnection()

            successMessageBox(frmManagement, "Successfully Updated the product")
            clear()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub tshirtOKButton_Click(sender As Object, e As EventArgs) Handles tshirtOKButton.Click
        If headerLabel.Text = "Add Product" Then
            If tpcodeTxtbox.Text = "" Or tcmbGender.SelectedIndex = -1 Or tpnameTxtbox.Text = "" Or tcmbBrand.SelectedIndex = -1 Or tcmbSize.SelectedIndex = -1 Or tcmbColor.SelectedIndex = -1 Or PictureBox2.Image Is Nothing Then
                MessageBox.Show("Please Fill All The Fields")
            Else
                Dim a As New JuvySQLORM(connectionString)
                a.AddImageParameters = True
                a.imageData = GetImageDataFromPictureBox(PictureBox2)
                Dim params() As String = {tpnameTxtbox.Text, tpdecTxtbox.Text, tpriceTxtbox.DecimalValue.ToString, "T-Shirt", tcmbBrand.SelectedItem.ToString, tcmbColor.SelectedItem.ToString, tcmbSize.SelectedItem.ToString, tcmbGender.SelectedItem.ToString, tpcodeTxtbox.Text}
                a.QuickBind(params)
                a.NonQuery("INSERT INTO [Product] (product_name,product_description,product_price,product_image,categoryID,brandID,color,size,gender,product_code) VALUES (@1,@2,@3,@image,(SELECT categoryID FROM Category WHERE category_name = @4),(SELECT brandID FROM Brand Where name = @5),@6,@7,@8,@9)")
                a.CloseConnection()

                successMessageBox(frmManagement, "Successfully Added a New Product!")
                clear()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Dim a As New JuvySQLORM(connectionString)
            a.AddImageParameters = True
            a.imageData = GetImageDataFromPictureBox(PictureBox2)
            Dim params() As String = {tpnameTxtbox.Text, tpdecTxtbox.Text, tpriceTxtbox.DecimalValue.ToString, "T-Shirt", tcmbBrand.SelectedItem.ToString, tcmbColor.SelectedItem.ToString, tcmbSize.SelectedItem.ToString, tcmbGender.SelectedItem.ToString, tpcodeTxtbox.Text, selectedID}
            a.QuickBind(params)
            a.NonQuery("UPDATE Product SET product_name=@1,product_description=@2,product_price=@3,product_image=@image,categoryID = (SELECT categoryID FROM Category WHERE category_name = @4),brandID = (SELECT brandID FROM Brand Where name = @5), date_updated = (getdate()),color = @6, size = @7, gender = @8, product_code = @9 WHERE productID=@10")
            a.CloseConnection()

            successMessageBox(frmManagement, "Successfully Updated the product")
            clear()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub tshirtCancelButton_Click(sender As Object, e As EventArgs) Handles tshirtCancelButton.Click
        clear()
        Me.Close()
    End Sub

    Private Sub shoesCancel_Click(sender As Object, e As EventArgs) Handles shoesCancel.Click
        clear()
        Me.Close()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class