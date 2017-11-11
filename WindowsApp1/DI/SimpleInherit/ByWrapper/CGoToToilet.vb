' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByWrapper

    Public Class CGoToToilet

        Private ReadOnly _goToToilet As IGoToilet

        Public Sub New(goToToilet As IGoToilet)
            _goToToilet = goToToilet
        End Sub

        Public Sub Go()
            _goToToilet.Go
        End Sub

    End Class

    End Namespace
