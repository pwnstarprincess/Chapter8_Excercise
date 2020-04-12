Public Class SamePartyAffiliation

    Dim Senate As New USSenate()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SamePartyButton.Click
        NumberOfStatesTextBox.Text = CStr(Senate.GetSamePartyAffiliationStates("Senate114.txt"))
    End Sub
End Class