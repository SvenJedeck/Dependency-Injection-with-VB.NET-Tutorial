Namespace MyObjects.Persons.Visitor

    Public Class SMove

        Implements IMove

        Public Sub GoToFrontCounter() Implements IMove.GoToFrontCounter
            MsgBox("Visitor is going to the front of the counter")
        End Sub

        Public Sub GoToToilet() Implements IMove.GoToToilet
            MsgBox("Visitor is going to the toilet.")
        End Sub

        Public Sub GoToToilet(personName As String) Implements Persons.IMove.GoToToilet
            MsgBox("Visitor " & personName & " is going to the toilet.")
        End Sub

    End Class

End Namespace
