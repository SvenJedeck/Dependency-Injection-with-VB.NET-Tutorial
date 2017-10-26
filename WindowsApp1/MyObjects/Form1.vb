Imports MyObjects.Persons
Imports MyObjects.Persons.BarTender
Imports MyObjects.Persons.Visitor
Imports VisitorDrinks = MyObjects.Persons.Visitor.ITalk.Drinks

    Public Class Form1

        Private ThisBarTender As New BarTender
        Private ThisVisitor As New Visitor

        Private ThisPerson As New Person("Peter", CDate("01.06.2001")) 

        Private Sub BtnVisitorHello_Click(sender As Object, e As EventArgs) Handles BtnVisitorHello.Click
            ThisVisitor.Talking.SayHello
        End Sub

        Private Sub BtnBartenderHello_Click(sender As Object, e As EventArgs) Handles BtnBartenderHello.Click
            ThisBarTender.Talking.SayHello
        End Sub

        Private Sub BtnBartenderAskOrder_Click(sender As Object, e As EventArgs) Handles BtnBartenderAskOrder.Click
            ThisBarTender.Talking.AskOrder
        End Sub

        Private Sub BtnVisitorToToilet_Click(sender As Object, e As EventArgs) Handles BtnVisitorToToilet.Click
            ThisVisitor.Moving.GoToToilet
        End Sub

        Private Sub BtnVisitorToCounter_Click(sender As Object, e As EventArgs) Handles BtnVisitorToCounter.Click
            ThisVisitor.Moving.GoToFrontCounter
        End Sub

        Private Sub BtnBartenderToToilet_Click(sender As Object, e As EventArgs) Handles BtnBartenderToToilet.Click
            ThisBarTender.Moving.GoToToilet
        End Sub

        Private Sub BtnBartenderToCounter_Click(sender As Object, e As EventArgs) Handles BtnBartenderToCounter.Click
            ThisBarTender.Moving.GoToBehindCounter
            ThisBarTender.Properties.Name = "John Doe"
            MessageBox.Show("Bartender Name: " &   ThisBarTender.Properties.Name)
            ThisBarTender.Properties.BirthDay = Now
            MessageBox.Show("Bartender Birthday: " &   ThisBarTender.Properties.BirthDay)
        End Sub

        Private Sub BtnVisitorOrder_Click(sender As Object, e As EventArgs) Handles BtnVisitorOrderBeer.Click
            ThisVisitor.Talking.Order(VisitorDrinks.BEER)
        End Sub

        Private Sub BtnVisitorOrderWater_Click(sender As Object, e As EventArgs) Handles BtnVisitorOrderWater.Click
            ThisVisitor.Talking.Order(VisitorDrinks.WATER)
        End Sub

        Private Sub BtnVisitorOrderButtermilk_Click(sender As Object, e As EventArgs) Handles BtnVisitorOrderButtermilk.Click
            ThisVisitor.Talking.Order(VisitorDrinks.BUTTERMILK)
        End Sub

        Private Sub BtnTime_Click(sender As Object, e As EventArgs) Handles BtnTime.Click
            MessageBox.Show("Visitor: The Bartender told me the time: " &   ThisBarTender.Talking.WhatTimeIsIt)
        End Sub

        Private Sub BtnPerson_Click(sender As Object, e As EventArgs) Handles BtnPerson.Click

            MessageBox.Show("Persons Birthday: " &   ThisPerson.Properties.BirthDay & vbCrLf & _
                            "Persons Name: " &   ThisPerson.Properties.Name)

            ThisPerson.Moving.GoToToilet(ThisPerson.Properties.Name)

            ThisPerson.Talking.SayHello

        End Sub

    End Class
