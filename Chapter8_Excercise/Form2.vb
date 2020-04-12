'JEnnifer Pezzulo
'Chapter 8 Excercise
'April 11, 2020


Public Class CreateNewFileForm

    Dim Senate As New USSenate()
    Private Sub CreateNewFile()

        System.IO.File.WriteAllLines("Senate114.txt", Senate.Compute114Congress())

        SenateMainForm.PartyAffiliationButton.Enabled = True
        SenateMainForm.SamePartyButton.Enabled = True
        SenateMainForm.QuerySenatorsButton.Enabled = True
        SenateMainForm.GenNewSenateButton.Enabled = False

        Me.Close()

    End Sub

    Private Sub NewFileButton_Click(sender As Object, e As EventArgs) Handles NewFileButton.Click

        CreateNewFile()

    End Sub
End Class