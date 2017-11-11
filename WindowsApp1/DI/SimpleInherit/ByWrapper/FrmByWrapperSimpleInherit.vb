' <Chapter 3.1>

    Imports WindowsApp1.DI.SimpleInherit
    Imports WindowsApp1.DI.SimpleInherit.ByWrapper

    Public Class FrmByWrapperSimpleInherit

        Private ThisGermanMan As New DI.SimpleInherit.ByWrapper.WGermanMan

        Private Sub BtnToToilet_Click(sender As Object, e As EventArgs) Handles BtnToToilet.Click
            ThisGermanMan.ToToilet.Go
        End Sub

        Private Sub BtnGreat_Click(sender As Object, e As EventArgs) Handles BtnGreat.Click
            ThisGermanMan.Greet.SayHello
        End Sub

    End Class
