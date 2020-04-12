Public Class SenateMainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GenNewSenateButton.Click
        Dim newFileForm As New CreateNewFileForm()
        newFileForm.Show()
    End Sub

    Private Sub PartyAffiliationButton_Click(sender As Object, e As EventArgs) Handles PartyAffiliationButton.Click
        Dim partyForm As New PartyAffiliations()
        partyForm.Show()
    End Sub

    Private Sub SamePartyButton_Click(sender As Object, e As EventArgs) Handles SamePartyButton.Click
        Dim sameAffiliationForm As New SamePartyAffiliation()
        sameAffiliationForm.Show()
    End Sub

    Private Sub QuerySenatorsButton_Click(sender As Object, e As EventArgs) Handles QuerySenatorsButton.Click
        Dim senatorForm As New DisplaySenators()
        senatorForm.Show()

    End Sub

    Private Sub SenateMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PartyAffiliationButton.Enabled = False
        SamePartyButton.Enabled = False
        QuerySenatorsButton.Enabled = False
    End Sub
End Class