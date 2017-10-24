Namespace MyObjects.Persons.Visitor

    Public Class Visitor

        Private   ThisVisitor As New  Inject

        Private   ThisTalking As      ITalk       = ThisVisitor.Talk
        Public        Talking As New  Talking     ( ThisTalking )

        Private    ThisMoving As      IMove       = ThisVisitor.Move
        Public         Moving As New  Moving      ( ThisMoving )

    End Class

End Namespace
