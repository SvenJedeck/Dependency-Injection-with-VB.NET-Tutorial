' <Chapter 2.1>

    Public Class CGoToToilet
    ' Client, the dependend object. 
 
        Private ReadOnly _goToToilet As IGoToToilet

        Public Sub New(goToToilet As IGoToToilet)
            _goToToilet = goToToilet
        End Sub

        Public Sub Go()
            _goToToilet.Go
        End Sub

    End Class

