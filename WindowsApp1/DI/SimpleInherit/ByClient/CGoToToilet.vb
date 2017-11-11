' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByClient

    Public Class CGoToToilet

        Inherits DI.SimpleInherit.CGreat

        Private ReadOnly _goToToilet As IGoToilet

        Public Sub New(goToToilet As IGoToilet, greet As DI.SimpleInherit.IGreet)
        MyBase.New(greet)
            _goToToilet = goToToilet
        End Sub

        Public Sub Go()
            _goToToilet.Go
        End Sub

    End Class

    End Namespace
