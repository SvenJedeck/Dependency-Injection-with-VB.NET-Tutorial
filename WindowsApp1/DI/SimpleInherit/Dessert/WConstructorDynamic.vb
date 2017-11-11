' <Chapter 3.1>

    Namespace DI.SimpleInherit

      Public Class WConstructorDynamic

        Private ThisPerson As New JGreat
        Public    Greet As CGreat

        Public Sub New(language As JGreat.Language)
          
            Greet = New CGreat(ThisPerson.Greet(language))

        End Sub

    End Class

    End Namespace
