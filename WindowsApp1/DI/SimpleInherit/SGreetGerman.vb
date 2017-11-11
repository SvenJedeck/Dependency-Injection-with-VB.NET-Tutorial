' <Chapter 3.1>

      Namespace DI.SimpleInherit

      Public Class SGreetGerman

        Implements IGreet

        Public Sub Greet() Implements IGreet.Greet
            MsgBox("Hallo, wie geht es ?")
        End Sub

      End Class

      End Namespace
