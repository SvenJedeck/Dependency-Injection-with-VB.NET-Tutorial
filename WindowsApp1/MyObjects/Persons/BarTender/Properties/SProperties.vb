Namespace MyObjects.Persons.BarTender

    Public Class SProperties 

        Implements IProperties

        Public Property Name As String Implements Persons.IProperties.Name
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property
            Private _name As String

    End Class

End Namespace
