Namespace MyObjects.Persons.BarTender

    Public Class Moving
    ' Child/ServiceObject

        Private ReadOnly _moveing As IMove

        Public Sub New(moveing As IMove)
            _moveing = moveing
        End Sub

        Public Sub GoToBehindCounter()
            _moveing.GoToBehindCounter
        End Sub

        Public Sub GoToToilet()
            _moveing.GoToToilet
        End Sub

    End Class

End Namespace
