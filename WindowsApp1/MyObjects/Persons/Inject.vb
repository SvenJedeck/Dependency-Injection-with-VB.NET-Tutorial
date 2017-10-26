Namespace MyObjects.Persons

    Public Class Inject

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
