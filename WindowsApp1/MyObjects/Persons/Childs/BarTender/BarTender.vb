Namespace MyObjects.Persons.BarTender

    Public Class BarTender

        Private      ThisBarTender As New  Inject

        Private    ThisTalking As      ITalk       = ThisBarTender.Talk
        Public         Talking As New  Talking     ( ThisTalking )

        Private     ThisMoving As      IMove       = ThisBarTender.Move
        Public          Moving As New  Moving      ( ThisMoving )

        Private ThisProperties As      IProperties = ThisBarTender.Properties

            Public Property Properties() As InjProperties
                Get
                    Return _properties
                End Get
                Set(value As InjProperties)
                    _properties = value
                End Set
            End Property
                    Private _properties As New InjProperties(ThisProperties)

    End Class

End Namespace
