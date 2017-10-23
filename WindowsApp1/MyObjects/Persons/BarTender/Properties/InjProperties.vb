Namespace MyObjects.Persons.BarTender

    Public Class InjProperties

        Private _properties As IProperties

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

    End Class

End Namespace
