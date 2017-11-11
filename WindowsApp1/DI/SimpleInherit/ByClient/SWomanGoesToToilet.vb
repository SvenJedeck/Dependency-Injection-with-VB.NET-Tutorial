' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByClient

    Public Class SWomanGoesToToilet

        Implements IGoToilet

        Public Sub Go() Implements IGoToilet.Go
            MsgBox("Woman is going to toilet.")
        End Sub

    End Class

    End Namespace
