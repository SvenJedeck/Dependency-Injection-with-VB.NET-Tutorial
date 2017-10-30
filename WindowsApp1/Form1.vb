' <Chapter 3.0>

    Public Class Form1

        Private ThisPersonEnglish As New WPersonEnglish() 
        Private ThisPersonGerman As New WPersonGerman() 

        Private Sub BtnPersonEnglish_Click() Handles BtnPersonEnglish.Click
            ThisPersonEnglish.Greet.SayHello()
        End Sub

        Private Sub BtnPersonGerman_Click() Handles BtnPersonGerman.Click
            ThisPersonGerman.Greet.SayHello
        End Sub

End Class
