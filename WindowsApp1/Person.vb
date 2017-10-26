
    Public Class Person

        Private      ThisPerson As New  Inject

        Private ThisMoving As IMove = ThisPerson.Move
        Public Moving As New Moving(ThisMoving)

    End Class
