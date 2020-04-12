Public Class USSenate
    Public Function GetInputData(data As String) As String()

        Return System.IO.File.ReadAllLines(data)

    End Function

    Public Function Compute114Congress() As String()

        Return GetInputData("Senate113.txt").Except(GetInputData("RetiredSen.txt")).ToArray().Union(GetInputData("NewSen.txt")).ToArray()

    End Function

    Public Function HasSameParty(ByVal state As String, data As String) As Boolean

        Dim query = From senate In GetInputData(data)
                    Let aff = senate.Split(","c)(2)
                    Let st = senate.Split(","c)(1)
                    Where st = state
                    Select aff, st

        If query.Count = 2 Then
            If query(0).aff = query(1).aff Then
                Return True
            End If
        End If

        Return False


    End Function

    Public Function GetPartyAffiliations(party As String, data As String) As Integer
        Dim query = From Senate In GetInputData(data)
                    Let aff = Senate.Split(","c)(2)
                    Where aff = party
                    Select aff
        Return query.Count
    End Function

    Public Function GetSamePartyAffiliationStates(data As String) As Integer

        Dim query = From Senate In GetInputData(data)
                    Let line = Senate.Split(","c)
                    Let state = line(1)
                    Where HasSameParty(state, data) = True
                    Select state
                    Distinct

        Return query.Count()
    End Function

    Public Function GetListofStates(data As String) As IEnumerable(Of String)
        Dim states = From senate In GetInputData(data)
                     Let state = senate.Split(","c)(1)
                     Order By state Ascending
                     Select state
                     Distinct

        Return states
    End Function

    Public Function GetSenatorsForState(data As String, selectedState As String) As IEnumerable(Of String)
        Dim senators = From senate In GetInputData(data)
                       Let name = senate.Split(","c)(0)
                       Let state = senate.Split(","c)(1)
                       Where state = selectedState
                       Select name

        Return senators
    End Function



End Class
