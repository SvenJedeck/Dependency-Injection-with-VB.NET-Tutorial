Namespace MyObjects.Persons.Visitor

    Public Class Moving
    ' Child/ServiceObject

        Private ReadOnly _moving As IMove

        Public Sub New(moving As IMove)
            _moving = moving
        End Sub

        Public Sub GoToFrontCounter()
            _moving.GoToFrontCounter
        End Sub

        Public Sub GoToToilet()
            _moving.GoToToilet
        End Sub

    End Class

End Namespace
