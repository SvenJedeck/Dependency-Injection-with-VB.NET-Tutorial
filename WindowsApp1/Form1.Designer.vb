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
        Me.BtnPersonEnglish = New System.Windows.Forms.Button()
        Me.BtnPersonGerman = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'BtnPersonEnglish
        '
        Me.BtnPersonEnglish.Location = New System.Drawing.Point(24, 32)
        Me.BtnPersonEnglish.Name = "BtnPersonEnglish"
        Me.BtnPersonEnglish.Size = New System.Drawing.Size(144, 23)
        Me.BtnPersonEnglish.TabIndex = 11
        Me.BtnPersonEnglish.Text = "English Person: Hello"
        Me.BtnPersonEnglish.UseVisualStyleBackColor = true
        '
        'BtnPersonGerman
        '
        Me.BtnPersonGerman.Location = New System.Drawing.Point(24, 64)
        Me.BtnPersonGerman.Name = "BtnPersonGerman"
        Me.BtnPersonGerman.Size = New System.Drawing.Size(144, 23)
        Me.BtnPersonGerman.TabIndex = 12
        Me.BtnPersonGerman.Text = "German Person: Hello"
        Me.BtnPersonGerman.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 365)
        Me.Controls.Add(Me.BtnPersonGerman)
        Me.Controls.Add(Me.BtnPersonEnglish)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents BtnPersonEnglish As Button
    Friend WithEvents BtnPersonGerman As Button
End Class
