' <Chapter 3.1>

    Namespace DI.SimpleInherit.ByInterface

    Public Class SEnglishManGoesToToilet

        Implements IGoToToilet

        Public Sub Go() Implements IGoToToilet.Go
            MsgBox("Man is going to toilet.")
        End Sub

        Public Sub Greet() Implements IGreet.Greet
            MsgBox("Hello, how do you do ?")
        End Sub

    End Class

    End Namespace
