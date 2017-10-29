' <Chapter 2.2>

      Public Class JGoToToilet

        Public Enum GoToToiletService
            MAN
            WOMAN
        End Enum

        Public Function GoToToilet(serviceSelection As GoToToiletService) As IGoToToilet

          Select Case serviceSelection

            Case GoToToiletService.MAN
                 Return New SManGoesToToilet

            Case GoToToiletService.WOMAN
                 Return New SWomanGoesToToilet

            End Select

        End Function

      End Class

