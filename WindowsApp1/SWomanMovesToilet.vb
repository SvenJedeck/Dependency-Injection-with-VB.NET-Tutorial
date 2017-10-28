' <Chapter 2.1>

    Public Class SWomanMovesToilet

        Implements IMoveToToilet

        Public Sub GoToToilet() Implements IMoveToToilet.GoToToilet
            MsgBox("Woman is going to toilet.")
        End Sub

    End Class