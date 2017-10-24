Namespace MyObjects.Persons.Visitor

    Public Class STalk

        Implements ITalk

        Public Sub SayHello() Implements ITalk.SayHello
            MsgBox("Visitor: Hey Ho @All")
        End Sub

        Public Sub Order(drink As ITalk.Drinks) Implements ITalk.Order
            MsgBox("Visitor: I'd like to drink a glas of " & drink.ToString &  ".")
        End Sub

        Public Function WhatTimeIsIt(Optional format As DateFormat = DateFormat.GeneralDate) As Date Implements Persons.ITalk.WhatTimeIsIt
            Return CDate(FormatDateTime(Now, format))
        End Function


    End Class

End Namespace
