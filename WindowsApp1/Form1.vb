' Chapter 01

    Public Class Form1

        Private ThisPerson As New Person() 

        Private Sub BtnPerson_Click(sender As Object, e As EventArgs) Handles BtnPerson.Click

            ThisPerson.Moving.GoToToilet()

        End Sub

    End Class
