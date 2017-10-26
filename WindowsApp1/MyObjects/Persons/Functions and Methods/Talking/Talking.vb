Namespace MyObjects.Persons

    Public Class Talking

        Private ReadOnly _talking As ITalk

        Public Sub New(talking As ITalk)
            _talking = talking
        End Sub

        Public Sub SayHello()
            _talking.SayHello
        End Sub

        Public Function WhatTimeIsIt() As Date
            Return _talking.WhatTimeIsIt
        End Function

    End Class

End Namespace
