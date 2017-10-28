' <Chapter 1.2>

    Public Class Form1

        Private   ThisWoman As New Woman() 
        Private     ThisMan As New Man() 

        Private Sub BtnWoman_Click() Handles BtnWoman.Click
            ThisWoman.Moving.GoToToilet()
        End Sub

        Private Sub BtnMan_Click() Handles BtnMan.Click
            ThisMan.Moving.GoToToilet()
        End Sub

End Class
