    Public Class FrmDessert

        Private ThisPersonFix As New DI.SimpleInherit.WConstructorDynamic(DI.SimpleInherit.JGreat.Language.ENGLISH)
        Private ThisPersonDyn As New DI.SimpleInherit.WPropertiesDynamic(DI.SimpleInherit.JGreat.Language.ENGLISH)

        Private Sub BtnDynamicConstructor_Click(sender As Object, e As EventArgs) Handles BtnDynamicConstructor.Click
            ThisPersonFix.Greet.SayHello
        End Sub

        Private Sub BtnDynamicProperties_Click(sender As Object, e As EventArgs) Handles BtnDynamicProperties.Click

            If ThisPersonDyn.Language = DI.SimpleInherit.JGreat.Language.ENGLISH Then

                ThisPersonDyn.Language = DI.SimpleInherit.JGreat.Language.GERMAN
            Else
                ThisPersonDyn.Language = DI.SimpleInherit.JGreat.Language.ENGLISH

            End If

            ThisPersonDyn.Greet.SayHello

        End Sub

    End Class
