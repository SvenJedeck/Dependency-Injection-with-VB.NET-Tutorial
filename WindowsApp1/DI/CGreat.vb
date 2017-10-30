' <Chapter 3.0>

    Public Class CGreat
    ' Client, the dependend object. Obelink called it in his source 'child'.
 
        Private ReadOnly _greet As IGreet

        Public Sub New(greet As IGreet)
            _greet = greet
        End Sub

        Public Sub SayHello()
            _greet.Greet
        End Sub

    End Class

