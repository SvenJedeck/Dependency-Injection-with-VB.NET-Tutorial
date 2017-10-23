Namespace MyObjects.Persons.Visitor

    Public Class Inject
    ' Mother/Injector

        Public Function Talk() As ITalk
            Return New STalk
        End Function

        Public Function Move() As IMove
            Return New SMove
        End Function

    End Class

End Namespace
