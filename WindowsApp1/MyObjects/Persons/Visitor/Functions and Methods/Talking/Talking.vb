Namespace MyObjects.Persons.Visitor

    Public Class Talking
    ' Child/ServiceObject

        Private ReadOnly _talking As ITalk

        Public Sub New(talking As ITalk)
            _talking = talking
        End Sub

        Public Sub Order(drink As ITalk.Drinks)
            _talking.Order(drink)
        End Sub

        Public Sub SayHello()
            _talking.SayHello
        End Sub

    End Class

End Namespace
