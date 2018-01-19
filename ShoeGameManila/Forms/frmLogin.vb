Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Login(username.Text, password.Text) = True Then
            If CurrentAccessLevel = "Administrator" Then
                My.Application.ApplicationContext.MainForm = frmMain
                Me.Close()
                frmMain.Show()
            Else
                My.Application.ApplicationContext.MainForm = frmMain
                Me.Close()
                frmMain.Show()
            End If
        Else
            MsgBox("Login Failed", vbExclamation)
        End If
    End Sub
End Class