' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByInjector

    Public Class SManGoesToilet

        Implements IGoToilet

        Public Sub Go() Implements IGoToilet.Go
            MsgBox("Man is going to toilet.")
        End Sub

    End Class

    End Namespace
