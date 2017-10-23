Namespace MyObjects.Persons.BarTender

    Public Class Inject
    ' Mother/Injector

        Public Function Talk() As ITalk
            Return New STalk
        End Function

        Public Function Move() As IMove
            Return New SMove
        End Function

        Public Function Properties() As IProperties
            Return New SProperties
        End Function

    End Class

End Namespace
