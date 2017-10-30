' <Chapter 3.0>

    Public Class JGreat

        Public Enum Language
            ENGLISH
            GERMAN
        End Enum

        Public Function Greet(language As Language) As IGreet

            Select Case language

                Case Language.ENGLISH
                    Return New SGreetEnglish

                Case Language.GERMAN
                    Return New SGreetGerman
            End Select

        End Function

    End Class

