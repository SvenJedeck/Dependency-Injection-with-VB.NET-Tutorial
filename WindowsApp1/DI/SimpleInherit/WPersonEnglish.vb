' <Chapter 3.1>

    Namespace DI.SimpleInherit

      Public Class WPersonEnglish

        Private ThisPerson As New JGreat
        Public    Greet As New CGreat(ThisPerson.Greet(JGreat.Language.ENGLISH))

      End Class

    End Namespace
