' <Chapter 1.2>

    Public Class SMove

        Implements IMove

        Public Sub GoToToilet() Implements IMove.GoToToilet
            MsgBox("Person is going to toilet.")
        End Sub

    End Class