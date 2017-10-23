<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnVisitorHello = New System.Windows.Forms.Button()
        Me.BtnBartenderHello = New System.Windows.Forms.Button()
        Me.BtnBartenderAskOrder = New System.Windows.Forms.Button()
        Me.BtnVisitorOrderBeer = New System.Windows.Forms.Button()
        Me.BtnBartenderToCounter = New System.Windows.Forms.Button()
        Me.BtnBartenderToToilet = New System.Windows.Forms.Button()
        Me.BtnVisitorToCounter = New System.Windows.Forms.Button()
        Me.BtnVisitorToToilet = New System.Windows.Forms.Button()
        Me.BtnVisitorOrderButtermilk = New System.Windows.Forms.Button()
        Me.BtnVisitorOrderWater = New System.Windows.Forms.Button()
        Me.BtnTime = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'BtnVisitorHello
        '
        Me.BtnVisitorHello.Location = New System.Drawing.Point(40, 48)
        Me.BtnVisitorHello.Name = "BtnVisitorHello"
        Me.BtnVisitorHello.Size = New System.Drawing.Size(144, 23)
        Me.BtnVisitorHello.TabIndex = 0
        Me.BtnVisitorHello.Text = "VisitorHello"
        Me.BtnVisitorHello.UseVisualStyleBackColor = true
        '
        'BtnBartenderHello
        '
        Me.BtnBartenderHello.Location = New System.Drawing.Point(40, 80)
        Me.BtnBartenderHello.Name = "BtnBartenderHello"
        Me.BtnBartenderHello.Size = New System.Drawing.Size(144, 23)
        Me.BtnBartenderHello.TabIndex = 1
        Me.BtnBartenderHello.Text = "BartenderHello"
        Me.BtnBartenderHello.UseVisualStyleBackColor = true
        '
        'BtnBartenderAskOrder
        '
        Me.BtnBartenderAskOrder.Location = New System.Drawing.Point(40, 112)
        Me.BtnBartenderAskOrder.Name = "BtnBartenderAskOrder"
        Me.BtnBartenderAskOrder.Size = New System.Drawing.Size(144, 23)
        Me.BtnBartenderAskOrder.TabIndex = 2
        Me.BtnBartenderAskOrder.Text = "BartenderAskOrder"
        Me.BtnBartenderAskOrder.UseVisualStyleBackColor = true
        '
        'BtnVisitorOrderBeer
        '
        Me.BtnVisitorOrderBeer.Location = New System.Drawing.Point(40, 144)
        Me.BtnVisitorOrderBeer.Name = "BtnVisitorOrderBeer"
        Me.BtnVisitorOrderBeer.Size = New System.Drawing.Size(144, 23)
        Me.BtnVisitorOrderBeer.TabIndex = 3
        Me.BtnVisitorOrderBeer.Text = "Visitor Order Beer"
        Me.BtnVisitorOrderBeer.UseVisualStyleBackColor = true
        '
        'BtnBartenderToCounter
        '
        Me.BtnBartenderToCounter.Location = New System.Drawing.Point(224, 144)
        Me.BtnBartenderToCounter.Name = "BtnBartenderToCounter"
        Me.BtnBartenderToCounter.Size = New System.Drawing.Size(144, 23)
        Me.BtnBartenderToCounter.TabIndex = 7
        Me.BtnBartenderToCounter.Text = "Bartender To Counter"
        Me.BtnBartenderToCounter.UseVisualStyleBackColor = true
        '
        'BtnBartenderToToilet
        '
        Me.BtnBartenderToToilet.Location = New System.Drawing.Point(224, 112)
        Me.BtnBartenderToToilet.Name = "BtnBartenderToToilet"
        Me.BtnBartenderToToilet.Size = New System.Drawing.Size(144, 23)
        Me.BtnBartenderToToilet.TabIndex = 6
        Me.BtnBartenderToToilet.Text = "Bartender To Toilet"
        Me.BtnBartenderToToilet.UseVisualStyleBackColor = true
        '
        'BtnVisitorToCounter
        '
        Me.BtnVisitorToCounter.Location = New System.Drawing.Point(224, 80)
        Me.BtnVisitorToCounter.Name = "BtnVisitorToCounter"
        Me.BtnVisitorToCounter.Size = New System.Drawing.Size(144, 23)
        Me.BtnVisitorToCounter.TabIndex = 5
        Me.BtnVisitorToCounter.Text = "Visitor To Counter"
        Me.BtnVisitorToCounter.UseVisualStyleBackColor = true
        '
        'BtnVisitorToToilet
        '
        Me.BtnVisitorToToilet.Location = New System.Drawing.Point(224, 48)
        Me.BtnVisitorToToilet.Name = "BtnVisitorToToilet"
        Me.BtnVisitorToToilet.Size = New System.Drawing.Size(144, 23)
        Me.BtnVisitorToToilet.TabIndex = 4
        Me.BtnVisitorToToilet.Text = "Visitor To Toilet"
        Me.BtnVisitorToToilet.UseVisualStyleBackColor = true
        '
        'BtnVisitorOrderButtermilk
        '
        Me.BtnVisitorOrderButtermilk.Location = New System.Drawing.Point(40, 208)
        Me.BtnVisitorOrderButtermilk.Name = "BtnVisitorOrderButtermilk"
        Me.BtnVisitorOrderButtermilk.Size = New System.Drawing.Size(144, 23)
        Me.BtnVisitorOrderButtermilk.TabIndex = 8
        Me.BtnVisitorOrderButtermilk.Text = "Visitor Order Buttermilk"
        Me.BtnVisitorOrderButtermilk.UseVisualStyleBackColor = true
        '
        'BtnVisitorOrderWater
        '
        Me.BtnVisitorOrderWater.Location = New System.Drawing.Point(40, 176)
        Me.BtnVisitorOrderWater.Name = "BtnVisitorOrderWater"
        Me.BtnVisitorOrderWater.Size = New System.Drawing.Size(144, 23)
        Me.BtnVisitorOrderWater.TabIndex = 9
        Me.BtnVisitorOrderWater.Text = "Visitor Order Water"
        Me.BtnVisitorOrderWater.UseVisualStyleBackColor = true
        '
        'BtnTime
        '
        Me.BtnTime.Location = New System.Drawing.Point(224, 208)
        Me.BtnTime.Name = "BtnTime"
        Me.BtnTime.Size = New System.Drawing.Size(144, 23)
        Me.BtnTime.TabIndex = 10
        Me.BtnTime.Text = "Time"
        Me.BtnTime.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 365)
        Me.Controls.Add(Me.BtnTime)
        Me.Controls.Add(Me.BtnVisitorOrderWater)
        Me.Controls.Add(Me.BtnVisitorOrderButtermilk)
        Me.Controls.Add(Me.BtnBartenderToCounter)
        Me.Controls.Add(Me.BtnBartenderToToilet)
        Me.Controls.Add(Me.BtnVisitorToCounter)
        Me.Controls.Add(Me.BtnVisitorToToilet)
        Me.Controls.Add(Me.BtnVisitorOrderBeer)
        Me.Controls.Add(Me.BtnBartenderAskOrder)
        Me.Controls.Add(Me.BtnBartenderHello)
        Me.Controls.Add(Me.BtnVisitorHello)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents BtnVisitorHello As Button
    Friend WithEvents BtnBartenderHello As Button
    Friend WithEvents BtnBartenderAskOrder As Button
    Friend WithEvents BtnVisitorOrderBeer As Button
    Friend WithEvents BtnBartenderToCounter As Button
    Friend WithEvents BtnBartenderToToilet As Button
    Friend WithEvents BtnVisitorToCounter As Button
    Friend WithEvents BtnVisitorToToilet As Button
    Friend WithEvents BtnVisitorOrderButtermilk As Button
    Friend WithEvents BtnVisitorOrderWater As Button
    Friend WithEvents BtnTime As Button
End Class
