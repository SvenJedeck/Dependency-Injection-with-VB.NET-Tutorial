' <Chapter 1.2>

    Public Class SWomanMovesToilet

        Implements IMove

        Public Sub GoToToilet() Implements IMove.GoToToilet
            MsgBox("Woman is going to toilet.")
        End Sub

    End Class