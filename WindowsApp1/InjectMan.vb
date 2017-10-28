' <Chapter 2.1>

    Public Class InjectMan

        Public Function Move() As IMoveToToilet
            Return New SManMovesToilet
        End Function

    End Class