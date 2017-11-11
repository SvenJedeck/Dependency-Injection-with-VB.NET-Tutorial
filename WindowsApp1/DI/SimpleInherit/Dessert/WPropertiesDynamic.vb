' <Chapter 3.1>

    Namespace DI.SimpleInherit

      Public Class WPropertiesDynamic

        Private ThisPerson As New JGreat
        Public    Greet As CGreat
        Private _language As JGreat.Language

        Public Property Language As JGreat.Language
 
           Get
               Return _language
           End Get

            Set(value As JGreat.Language)
              _language = value
               Greet = New CGreat(ThisPerson.Greet(_language))
            End Set

        End Property

        Public Sub New(language As JGreat.Language)
          
            Language = language

        End Sub

    End Class

    End Namespace

