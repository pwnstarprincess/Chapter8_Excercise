Public Class DisplaySenators

    Dim Senate As New USSenate()

    Private Sub DisplaySenators_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListStates.DataSource = Senate.GetListofStates("Senate114.txt").ToList
    End Sub

    Private Sub ListStates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListStates.SelectedIndexChanged

        ListSenators.DataSource = Senate.GetSenatorsForState("Senate114.txt", ListStates.SelectedItem.ToString()).ToList
        ListSenators.SelectedItem = Nothing

    End Sub
End Class