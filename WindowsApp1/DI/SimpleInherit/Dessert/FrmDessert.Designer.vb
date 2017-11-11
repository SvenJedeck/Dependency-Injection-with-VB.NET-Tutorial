<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDessert
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
        Me.BtnDynamicConstructor = New System.Windows.Forms.Button()
        Me.BtnDynamicProperties = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'BtnDynamicConstructor
        '
        Me.BtnDynamicConstructor.Location = New System.Drawing.Point(24, 40)
        Me.BtnDynamicConstructor.Name = "BtnDynamicConstructor"
        Me.BtnDynamicConstructor.Size = New System.Drawing.Size(176, 24)
        Me.BtnDynamicConstructor.TabIndex = 0
        Me.BtnDynamicConstructor.Text = "DynamicConstructor"
        Me.BtnDynamicConstructor.UseVisualStyleBackColor = true
        '
        'BtnDynamicProperties
        '
        Me.BtnDynamicProperties.Location = New System.Drawing.Point(24, 72)
        Me.BtnDynamicProperties.Name = "BtnDynamicProperties"
        Me.BtnDynamicProperties.Size = New System.Drawing.Size(176, 24)
        Me.BtnDynamicProperties.TabIndex = 1
        Me.BtnDynamicProperties.Text = "DynamicProperties"
        Me.BtnDynamicProperties.UseVisualStyleBackColor = true
        '
        'FrmDessert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnDynamicProperties)
        Me.Controls.Add(Me.BtnDynamicConstructor)
        Me.Name = "FrmDessert"
        Me.Text = "Dessert"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents BtnDynamicConstructor As Button
    Friend WithEvents BtnDynamicProperties As Button
End Class
