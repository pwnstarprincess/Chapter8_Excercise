Public Class PartyAffiliations

    Dim Senate As New USSenate()
    Private Sub GetPartyAffiliationsButton_Click(sender As Object, e As EventArgs) Handles GetPartyAffiliationsButton.Click
        RepublicanTextBox.Text = CStr(Senate.GetPartyAffiliations("R", "Senate114.txt"))
        DemocratTextBox.Text = CStr(Senate.GetPartyAffiliations("D", "Senate114.txt"))
        IndependentTextBox.Text = CStr(Senate.GetPartyAffiliations("I", "Senate114.txt"))


    End Sub
End Class
