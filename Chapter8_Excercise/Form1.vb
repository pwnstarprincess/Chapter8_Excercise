'Jennifer Pezzulo
'Chapter 8 Excercise
'April 11, 2020

'Class for form that displays party affiliation counts
Public Class PartyAffiliations
    'Declare USSenate object
    Dim Senate As New USSenate()
    'Sub routine for button click
    Private Sub GetPartyAffiliationsButton_Click(sender As Object, e As EventArgs) Handles GetPartyAffiliationsButton.Click
        'Get Republican, Democrat, and Independent counts for Senate
        RepublicanTextBox.Text = CStr(Senate.GetPartyAffiliations("R", "Senate114.txt"))
        DemocratTextBox.Text = CStr(Senate.GetPartyAffiliations("D", "Senate114.txt"))
        IndependentTextBox.Text = CStr(Senate.GetPartyAffiliations("I", "Senate114.txt"))


    End Sub
End Class
