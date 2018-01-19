Public Class frmDiscount

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub cdPercentBtn_Click(sender As Object, e As EventArgs) Handles cdPercentBtn.Click
        cdPercentTxtbox.Visible = True
        cdPesoTxtbox.Visible = False
        cdPercentBtn.IsTab = True
        cdPercentBtn.selected = True
        cdPesoBtn.IsTab = False
        cdPesoBtn.selected = False
    End Sub

    Private Sub cdPesoBtn_Click(sender As Object, e As EventArgs) Handles cdPesoBtn.Click
        cdPercentTxtbox.Visible = False
        cdPesoTxtbox.Visible = True
        cdPercentBtn.IsTab = False
        cdPercentBtn.selected = False
        cdPesoBtn.IsTab = True
        cdPesoBtn.selected = True
    End Sub

    Private Sub idPercentBtn_Click(sender As Object, e As EventArgs) Handles idPercentBtn.Click
        idPercentTxtbox.Visible = True
        idPesoTxtbox.Visible = False
        idPercentBtn.IsTab = True
        idPercentBtn.selected = True
        idPesoBtn.IsTab = False
        idPesoBtn.selected = False
    End Sub

    Private Sub idPesoBtn_Click(sender As Object, e As EventArgs) Handles idPesoBtn.Click
        idPercentTxtbox.Visible = False
        idPesoTxtbox.Visible = True
        idPercentBtn.IsTab = False
        idPercentBtn.selected = False
        idPesoBtn.IsTab = True
        idPesoBtn.selected = True
    End Sub
End Class