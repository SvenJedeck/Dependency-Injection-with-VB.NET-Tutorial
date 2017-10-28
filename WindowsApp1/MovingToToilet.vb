' <Chapter 2.1>

    Public Class MovingToToilet
    ' Client, the dependend object. 
 
        Private ReadOnly _moveing As IMoveToToilet

        Public Sub New(moveing As IMoveToToilet)
            _moveing = moveing
        End Sub

        Public Sub GoToToilet()
            _moveing.GoToToilet
        End Sub

    End Class

