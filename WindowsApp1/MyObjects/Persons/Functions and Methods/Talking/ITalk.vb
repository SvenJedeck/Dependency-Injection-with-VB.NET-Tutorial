Namespace MyObjects.Persons

    Public Interface ITalk

        Sub SayHello()

        Function WhatTimeIsIt(Optional format As DateFormat = DateFormat.GeneralDate) As Date

    End Interface

End Namespace
