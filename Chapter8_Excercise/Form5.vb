'Jennifer Pezzulo
'Chapter 8 Excercise
'April 11, 2020

'Class for the main form

Public Class SenateMainForm

    'On button click show new file form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GenNewSenateButton.Click
        Dim newFileForm As New CreateNewFileForm()
        newFileForm.Show()
    End Sub

    'On button click show pasrty affiliation form
    Private Sub PartyAffiliationButton_Click(sender As Object, e As EventArgs) Handles PartyAffiliationButton.Click
        Dim partyForm As New PartyAffiliations()
        partyForm.Show()
    End Sub

    'On button click show same party affiliation form
    Private Sub SamePartyButton_Click(sender As Object, e As EventArgs) Handles SamePartyButton.Click
        Dim sameAffiliationForm As New SamePartyAffiliation()
        sameAffiliationForm.Show()
    End Sub

    'On button click show diplay senators form
    Private Sub QuerySenatorsButton_Click(sender As Object, e As EventArgs) Handles QuerySenatorsButton.Click
        Dim senatorForm As New DisplaySenators()
        senatorForm.Show()

    End Sub

    'Load the form with all buttons disabled except that which launches the create new file form
    Private Sub SenateMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PartyAffiliationButton.Enabled = False
        SamePartyButton.Enabled = False
        QuerySenatorsButton.Enabled = False
    End Sub
End Class