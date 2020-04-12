'JEnnifer Pezzulo
'Chapter 8 Excercise
'April 11, 2020

'Class for form to create new file
Public Class CreateNewFileForm
    'Instantiate USSenate object
    Dim Senate As New USSenate()

    'Sub routine to create file of 114 senate
    Private Sub CreateNewFile()

        'Write output of compute114Senate to Senate114.txt
        System.IO.File.WriteAllLines("Senate114.txt", Senate.Compute114Senate())
        'Enable buttons now that file has been created
        SenateMainForm.PartyAffiliationButton.Enabled = True
        SenateMainForm.SamePartyButton.Enabled = True
        SenateMainForm.QuerySenatorsButton.Enabled = True
        'Disable because there is no need to rebuild file
        SenateMainForm.GenNewSenateButton.Enabled = False
        'Close this form
        Me.Close()

    End Sub

    Private Sub NewFileButton_Click(sender As Object, e As EventArgs) Handles NewFileButton.Click
        'Run create new file sub routine when button is clicked
        CreateNewFile()

    End Sub
End Class