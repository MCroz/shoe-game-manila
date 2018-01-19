Imports Transitions
Imports MetroFramework

Module UI_Controls
    Sub closeFrameInPanel(ByVal panelContainer As Panel)
        For Each ctrl As Control In panelContainer.Controls
            panelContainer.Controls.Remove(ctrl)
        Next
    End Sub
    Sub showFormInsidePanel(ByVal panelContainer As Panel, ByVal frameToShow As Form)
        closeFrameInPanel(panelContainer)
        Dim preym As New Windows.Forms.Form
        preym = frameToShow
        preym.TopLevel = False
        preym.Dock = DockStyle.Fill
        preym.Visible = True
        panelContainer.Controls.Add(preym)
    End Sub

    Sub animatePanel(ByVal pane As Panel, ByVal whatToAnimate As String, ByVal newvalue As Integer, ByVal speed As Integer)
        Transitions.Transition.run(pane, whatToAnimate, newvalue, New TransitionType_EaseInEaseOut(speed))
    End Sub

    Sub addFormInsidePanel(ByVal panelContainer As Panel, ByVal frameToShow As Form)
        Dim preym As New Windows.Forms.Form
        preym = frameToShow
        preym.TopLevel = False
        preym.Dock = DockStyle.Fill
        preym.Visible = True
        panelContainer.Controls.Add(preym)
    End Sub

    Sub errorMessageBox(ByVal owner As MetroFramework.Forms.MetroForm, ByVal message As String)
        MetroMessageBox.Show(owner, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Function questionMessageBox(ByVal owner As MetroFramework.Forms.MetroForm, ByVal message As String)
        Return MetroMessageBox.Show(owner, message, "Shoe Game Manila", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Sub successMessageBox(ByVal owner As MetroFramework.Forms.MetroForm, ByVal message As String)
        MetroMessageBox.Show(owner, message, "Shoe Game Manila", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub errorMessageBox(ByVal owner As Form, ByVal message As String)
        MetroMessageBox.Show(owner, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Function questionMessageBox(ByVal owner As Form, ByVal message As String)
        Return MetroMessageBox.Show(owner, message, "Shoe Game Manila", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Sub successMessageBox(ByVal owner As Form, ByVal message As String)
        MetroMessageBox.Show(owner, message, "Shoe Game Manila", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
