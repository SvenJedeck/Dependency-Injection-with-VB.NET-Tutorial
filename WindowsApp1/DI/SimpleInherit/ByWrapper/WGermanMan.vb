' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByWrapper

    Public Class WGermanMan

        Inherits DI.SimpleInherit.WPersonGerman

        Private ThisPersonToToilet As New JGoToToilet
        Public  ToToilet As New CGoToToilet(ThisPersonToToilet.GoToToilet(JGoToToilet.Gender.MAN))

    End Class

    End Namespace
