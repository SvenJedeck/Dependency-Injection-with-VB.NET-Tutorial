
    Public Class Moving

        Private ReadOnly _moveing As IMove

        Public Sub New(moveing As IMove)
            _moveing = moveing
        End Sub

        Public Sub GoToToilet()
            _moveing.GoToToilet
        End Sub

    End Class

