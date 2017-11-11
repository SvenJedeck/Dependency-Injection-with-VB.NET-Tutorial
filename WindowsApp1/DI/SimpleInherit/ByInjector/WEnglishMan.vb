' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByInjector

    Public Class WEnglishMan

        Private ThisGreet As New JGreat
        Private ThisToilet As New JGoToToilet

        Public    GoToToilet As New CGoToToilet _
                                ( _
                                    ThisToilet.GoToToilet(JGoToToilet.Gender.MAN), _
                                    ThisGreet.Greet(JGreat.Language.ENGLISH) _
                                )

    End Class

    End Namespace
