Namespace MyObjects.Persons

    Public Class Person

        Private      ThisPerson As New  Inject

        Private ThisTalking As ITalk = ThisPerson.Talk
        Public Talking As New Talking(ThisTalking)

        Private ThisMoving As IMove = ThisPerson.Move
        Public Moving As New Moving(ThisMoving)

        Private ThisProperties As      IProperties = ThisPerson.Properties

            Public Property Properties() As InjProperties
                Get
                    Return _properties
                End Get
                Set(value As InjProperties)
                    _properties = value
                End Set
            End Property
                    Private _properties As New InjProperties(ThisProperties)

        Public Sub New(personName As String, birthDay As Date)

            _properties.BirthDay = birthDay
            _properties.Name = personName

        End Sub


    End Class

End Namespace
