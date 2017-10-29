' <Chapter 2.2>

      Public Class Form1

        Private   ThisWoman As New Woman() 
        Private     ThisMan As New Man() 

        Private Sub BtnWoman_Click() Handles BtnWoman.Click
            ThisWoman.GoToToilet.Go()
        End Sub

        Private Sub BtnMan_Click() Handles BtnMan.Click
            ThisMan.GoToToilet.Go()
        End Sub

      End Class
