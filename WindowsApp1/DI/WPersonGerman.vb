' <Chapter 3.1>

    Namespace DI

      Public Class WPersonGerman

          Private ThisPerson As New JGreat
          Public    Greet As New CGreat(ThisPerson.Greet(JGreat.Language.GERMAN))

      End Class

    End Namespace
