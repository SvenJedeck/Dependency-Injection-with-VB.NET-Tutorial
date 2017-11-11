' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByInjector

    Public Class CGoToToilet

        Private ReadOnly _goToToilet As IGoToilet
        Private ReadOnly _greet As DI.SimpleInherit.IGreet

        Public Sub New(goToToilet As IGoToilet, greet As DI.SimpleInherit.IGreet)
            _goToToilet = goToToilet
            _greet = greet
        End Sub

        Public Sub Go()
            _goToToilet.Go
        End Sub

        Public Sub SayHello()
            _greet.Greet
        End Sub

    End Class

    End Namespace
