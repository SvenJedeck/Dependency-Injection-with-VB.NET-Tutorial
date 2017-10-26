Namespace MyObjects.Persons

    Public Class STalk

        Implements ITalk

        Public Sub SayHello() Implements ITalk.SayHello
            MsgBox("Person: Hello, I am just a person.")
        End Sub

        Public Function WhatTimeIsIt(Optional format As DateFormat = DateFormat.GeneralDate) As Date Implements ITalk.WhatTimeIsIt
            Return CDate(FormatDateTime(Now, format))
        End Function

    End Class

End Namespace
