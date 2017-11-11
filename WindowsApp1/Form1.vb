' <Chapter 3.1>

    Public Class Form1

        Private ThisPersonEnglish As New DI.SimpleInherit.ByInjector.WEnglishMan() 
        Private ThisPersonGerman As New DI.SimpleInherit.WPersonGerman()

    Private Sub BtnByWrapper_Click(sender As Object, e As EventArgs) Handles BtnByWrapper.Click
        FrmByWrapperSimpleInherit.Show
    End Sub

    Private Sub BtnDessert_Click(sender As Object, e As EventArgs) Handles BtnDessert.Click
        FrmDessert.Show
    End Sub
End Class
