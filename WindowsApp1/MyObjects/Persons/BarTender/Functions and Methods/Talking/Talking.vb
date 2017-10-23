Namespace MyObjects.Persons.BarTender

    Public Class Talking
    ' Child/ServiceObject

        Private ReadOnly _talking As ITalk

        Public Sub New(talking As ITalk)
            _talking = talking
        End Sub

        Public Sub AskOrder()
            _talking.AskOrder
        End Sub

        Public Sub SayHello()
            _talking.SayHello
        End Sub

        Public Function WhatTimeIsIt() As Date
            Return _talking.WhatTimeIsIt
        End Function

    End Class

End Namespace
