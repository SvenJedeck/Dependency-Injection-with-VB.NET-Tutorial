Namespace MyObjects.Persons

    Public Class SMove

        Implements IMove

        Public Sub GoToToilet() Implements IMove.GoToToilet
            MsgBox("Person is going to toilet.")
        End Sub

        Public Sub GoToToilet(personName As String) Implements IMove.GoToToilet
            MsgBox(personName & " is going to toilet.")
        End Sub
    End Class

End Namespace
