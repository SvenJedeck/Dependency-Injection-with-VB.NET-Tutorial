' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByClient

    Public Class WGermanWoman

        Private ThisPersonToToilet As New JGoToToilet
        Private ThisPersonGreat As New JGreat

        Public    ToToilet As New CGoToToilet(ThisPersonToToilet.GoToToilet(JGoToToilet.Gender.WOMAN), ThisPersonGreat.Greet(JGreat.Language.GERMAN))

    End Class

    End Namespace
