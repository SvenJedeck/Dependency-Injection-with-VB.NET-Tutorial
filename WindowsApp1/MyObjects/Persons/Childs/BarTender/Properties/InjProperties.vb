Namespace MyObjects.Persons.BarTender

    Public Class InjProperties

        Private ReadOnly _properties As IProperties

        Public Sub New(properties As IProperties)
            _properties = properties
        End Sub

        Public Property Name() As String
            Get
                Return _properties.Name
            End Get
            Set(value As String)
                _properties.Name = value
            End Set
        End Property     

        Public Property BirthDay() As Date
            Get
                Return _properties.BirthDay
            End Get
            Set(value As Date)
                _properties.BirthDay = value
            End Set
        End Property     

    End Class

End Namespace
