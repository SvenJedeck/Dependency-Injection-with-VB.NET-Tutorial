Namespace MyObjects.Persons.Visitor

    Public Interface ITalk
        Inherits Persons.ITalk

        Enum Drinks
            BEER
            WATER
            BUTTERMILK
        End Enum

        Sub Order(drink As Drinks)

    End Interface

End Namespace
