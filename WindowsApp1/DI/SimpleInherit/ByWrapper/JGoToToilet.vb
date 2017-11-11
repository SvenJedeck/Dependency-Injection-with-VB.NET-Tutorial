' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByWrapper

    Public Class JGoToToilet

    Public Enum Gender
        MAN
        WOMAN
    End Enum

        Public Function GoToToilet(gender As Gender) As IGoToilet

            Select Case gender
                Case Gender.MAN
                    Return New SManGoesToilet
    
                Case Gender.WOMAN
                    Return New SWomanGoesToToilet
            End Select

        End Function

    End Class

    End Namespace
