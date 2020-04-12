'JEnnifer Pezzulo
'Chapter 8 Excercise
'April 11, 2020

'Class for form that shows states with two senators from same party
Public Class SamePartyAffiliation
    'Instantiate USSenate object
    Dim Senate As New USSenate()

    'When button is clicked...
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SamePartyButton.Click

        'Put results from GetSamePartyAffiliationStates as String into Textbox
        NumberOfStatesTextBox.Text = CStr(Senate.GetSamePartyAffiliationStates("Senate114.txt"))
    End Sub
End Class