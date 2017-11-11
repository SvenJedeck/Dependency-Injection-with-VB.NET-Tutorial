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
        Me.BtnByWrapper = New System.Windows.Forms.Button()
        Me.BtnByClient = New System.Windows.Forms.Button()
        Me.BtnDessert = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'BtnByWrapper
        '
        Me.BtnByWrapper.Location = New System.Drawing.Point(24, 160)
        Me.BtnByWrapper.Name = "BtnByWrapper"
        Me.BtnByWrapper.Size = New System.Drawing.Size(144, 23)
        Me.BtnByWrapper.TabIndex = 11
        Me.BtnByWrapper.Text = "By Wrapper"
        Me.BtnByWrapper.UseVisualStyleBackColor = true
        '
        'BtnByClient
        '
        Me.BtnByClient.Location = New System.Drawing.Point(24, 128)
        Me.BtnByClient.Name = "BtnByClient"
        Me.BtnByClient.Size = New System.Drawing.Size(144, 23)
        Me.BtnByClient.TabIndex = 12
        Me.BtnByClient.Text = "By Client"
        Me.BtnByClient.UseVisualStyleBackColor = true
        '
        'BtnDessert
        '
        Me.BtnDessert.Location = New System.Drawing.Point(24, 192)
        Me.BtnDessert.Name = "BtnDessert"
        Me.BtnDessert.Size = New System.Drawing.Size(144, 23)
        Me.BtnDessert.TabIndex = 13
        Me.BtnDessert.Text = "Dessert"
        Me.BtnDessert.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 365)
        Me.Controls.Add(Me.BtnDessert)
        Me.Controls.Add(Me.BtnByClient)
        Me.Controls.Add(Me.BtnByWrapper)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents BtnByWrapper As Button
    Friend WithEvents BtnByClient As Button
    Friend WithEvents BtnDessert As Button
End Class
