Namespace MyObjects.Persons.BarTender

    Public Class BarTender

        ' Himself
        Private  ThisBarTender As New  Inject

        ' Group of methods (Talking)
        Private    ThisTalking As      ITalk       = ThisBarTender.Talk
        Public         Talking As New  Talking     ( ThisTalking )

        ' Group of methods (Moving)
        Private     ThisMoving As      IMove       = ThisBarTender.Move
        Public          Moving As New  Moving      ( ThisMoving )

        ' Properties
        Private         ThisProperties As IProperties = ThisBarTender.Properties
        Public Property   Properties() As InjProperties



    End Class

End Namespace
