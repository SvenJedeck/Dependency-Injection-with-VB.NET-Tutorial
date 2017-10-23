Namespace MyObjects.Persons.BarTender

    Public Class SMove

        Implements IMove

        Public Sub GoToBehindCounter() Implements IMove.GoToBehindCounter
            MsgBox("BarTender is going behind his counter.")
        End Sub

        Public Sub GoToToilet() Implements IMove.GoToToilet
            MsgBox("BarTender is going to toilet.")
        End Sub

    End Class

End Namespace
