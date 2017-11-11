<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmByWrapperSimpleInherit
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
        Me.BtnToToilet = New System.Windows.Forms.Button()
        Me.BtnGreat = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'BtnToToilet
        '
        Me.BtnToToilet.Location = New System.Drawing.Point(24, 32)
        Me.BtnToToilet.Name = "BtnToToilet"
        Me.BtnToToilet.Size = New System.Drawing.Size(120, 23)
        Me.BtnToToilet.TabIndex = 0
        Me.BtnToToilet.Text = "To Toilet"
        Me.BtnToToilet.UseVisualStyleBackColor = true
        '
        'BtnGreat
        '
        Me.BtnGreat.Location = New System.Drawing.Point(160, 32)
        Me.BtnGreat.Name = "BtnGreat"
        Me.BtnGreat.Size = New System.Drawing.Size(120, 23)
        Me.BtnGreat.TabIndex = 1
        Me.BtnGreat.Text = "Hello"
        Me.BtnGreat.UseVisualStyleBackColor = true
        '
        'FrmByWrapperSimpleInherit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 120)
        Me.Controls.Add(Me.BtnGreat)
        Me.Controls.Add(Me.BtnToToilet)
        Me.Name = "FrmByWrapperSimpleInherit"
        Me.Text = "German Man"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents BtnToToilet As Button
    Friend WithEvents BtnGreat As Button
End Class
