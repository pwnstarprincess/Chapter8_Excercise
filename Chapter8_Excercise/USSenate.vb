'JEnnifer Pezzulo
'Chapter 8 Excercise
'April 11, 2020

'USSenate object
Public Class USSenate

    'Function to Get the data from the text file
    Public Function GetInputData(data As String) As String()

        Return System.IO.File.ReadAllLines(data)

    End Function

    'Function to Build the date for the 114 senate
    Public Function Compute114Senate() As String()

        'Return an array of the 113 senate minus the retired senators but including the newly elected senators
        Return GetInputData("Senate113.txt").Except(GetInputData("RetiredSen.txt")).ToArray().Union(GetInputData("NewSen.txt")).ToArray()

    End Function

    'Function to determine if two candidates share the same party for a given state.  Returns true or false
    Public Function HasSameParty(ByVal state As String, data As String) As Boolean

        'Query to select party affiliation and state from data for a given state
        Dim query = From senate In GetInputData(data)
                    Let aff = senate.Split(","c)(2)
                    Let st = senate.Split(","c)(1)
                    Where st = state
                    Select aff, st

        'If the two values returened have matching party affiliations then return true
        If query.Count = 2 Then
            If query(0).aff = query(1).aff Then
                Return True
            End If
        End If
        'If not matching (or not two) return false
        Return False


    End Function

    'Function to get the number of members of a given party
    Public Function GetPartyAffiliations(party As String, data As String) As Integer
        'Query senate for members of a party based on the supplied party parameter
        Dim query = From Senate In GetInputData(data)
                    Let aff = Senate.Split(","c)(2)
                    Where aff = party
                    Select aff

        'Return the number of results
        Return query.Count
    End Function

    'Function to Return the number of states with both senators from the same party
    Public Function GetSamePartyAffiliationStates(data As String) As Integer

        'Query for states with two senators from same party
        Dim query = From Senate In GetInputData(data)
                    Let line = Senate.Split(","c)
                    Let state = line(1)
                    Where HasSameParty(state, data) = True
                    Select state
                    Distinct

        'Return the number of results
        Return query.Count()
    End Function

    'Function to get the list of US states
    Public Function GetListofStates(data As String) As IEnumerable(Of String)
        'Query all states in the Senate input data
        Dim states = From senate In GetInputData(data)
                     Let state = senate.Split(","c)(1)
                     Order By state Ascending
                     Select state
                     Distinct

        'Return the results as IEnumerable
        Return states
    End Function

    'Function to get the senators for a given state based on the selected state and Senate data passed in 
    'As parameters
    Public Function GetSenatorsForState(data As String, selectedState As String) As IEnumerable(Of String)
        Dim senators = From senate In GetInputData(data)
                       Let name = senate.Split(","c)(0)
                       Let state = senate.Split(","c)(1)
                       Where state = selectedState
                       Select name

        'Return the senators as IEnumerable
        Return senators
    End Function



End Class
