' <Chapter 3.0>

    Public Class SGreetEnglish

        Implements IGreet

        Public Sub Greet() Implements IGreet.Greet
            MsgBox("Hello, how do you do ?")
        End Sub

    End Class