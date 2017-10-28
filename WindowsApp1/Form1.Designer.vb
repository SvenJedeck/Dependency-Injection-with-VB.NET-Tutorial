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
        Me.BtnWoman = New System.Windows.Forms.Button()
        Me.BtnMan = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'BtnWoman
        '
        Me.BtnWoman.Location = New System.Drawing.Point(24, 32)
        Me.BtnWoman.Name = "BtnWoman"
        Me.BtnWoman.Size = New System.Drawing.Size(144, 23)
        Me.BtnWoman.TabIndex = 11
        Me.BtnWoman.Text = "Woman"
        Me.BtnWoman.UseVisualStyleBackColor = true
        '
        'BtnMan
        '
        Me.BtnMan.Location = New System.Drawing.Point(192, 32)
        Me.BtnMan.Name = "BtnMan"
        Me.BtnMan.Size = New System.Drawing.Size(144, 23)
        Me.BtnMan.TabIndex = 12
        Me.BtnMan.Text = "Man"
        Me.BtnMan.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 184)
        Me.Controls.Add(Me.BtnMan)
        Me.Controls.Add(Me.BtnWoman)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents BtnWoman As Button
    Friend WithEvents BtnMan As Button
End Class
