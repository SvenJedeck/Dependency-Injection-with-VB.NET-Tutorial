' <Chapter 3.1>

    Namespace DI.SimpleInherit

    Public Class SGreetEnglish

        Implements IGreet

        Public Sub Greet() Implements IGreet.Greet
            MsgBox("Hello, how do you do ?")
        End Sub

    End Class

    End Namespace
