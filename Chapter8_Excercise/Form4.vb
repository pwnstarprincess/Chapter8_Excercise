'JEnnifer Pezzulo
'Chapter 8 Excercise
'April 11, 2020

'Class for the form that displays the senators for a state
Public Class DisplaySenators
    'Instantiate a USSenate object
    Dim Senate As New USSenate()

    'When the form is loaded...
    Private Sub DisplaySenators_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the States ListBox with the states from the Senate114 file as the source
        ListStates.DataSource = Senate.GetListofStates("Senate114.txt").ToList
    End Sub

    'When a state is selected from the states listbox...
    Private Sub ListStates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListStates.SelectedIndexChanged
        'Populate the senators for the given state passing in the Senate114 membership list as currently selected state as the parameter
        ListSenators.DataSource = Senate.GetSenatorsForState("Senate114.txt", ListStates.SelectedItem.ToString()).ToList
        'Nothing needs to be selected
        ListSenators.SelectedItem = Nothing

    End Sub
End Class