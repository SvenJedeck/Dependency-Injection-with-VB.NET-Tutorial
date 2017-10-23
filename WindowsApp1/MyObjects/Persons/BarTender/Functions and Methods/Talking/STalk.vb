Namespace MyObjects.Persons.BarTender

    Public Class STalk

        Implements ITalk

        Public Sub AskOrder() Implements ITalk.AskOrder
            MsgBox("BarTender: Hey Dude, wanna drink something ?")
        End Sub

        Public Sub SayHello() Implements ITalk.SayHello
            MsgBox("BarTender: Folks, you are welcome.")
        End Sub

        Public Function WhatTimeIsIt(Optional format As DateFormat = DateFormat.GeneralDate) As Date Implements Persons.ITalk.WhatTimeIsIt
            Return CDate(FormatDateTime(Now, format))
        End Function

    End Class

End Namespace
