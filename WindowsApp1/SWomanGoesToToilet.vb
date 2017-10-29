' <Chapter 2.1>

      Public Class SWomanGoesToToilet

        Implements IGoToToilet

        Public Sub Go() Implements IGoToToilet.Go
            MsgBox("Woman is going to toilet.")
        End Sub

      End Class
