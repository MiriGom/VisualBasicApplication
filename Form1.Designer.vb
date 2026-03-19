<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCheck = New Button()
        txtTemperature = New TextBox()
        btnCountingApp = New Button()
        btnDoWhile = New Button()
        btnListOfFruit = New Button()
        SuspendLayout()
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(45, 40)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(191, 29)
        btnCheck.TabIndex = 0
        btnCheck.Text = "Check Temperature App"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' txtTemperature
        ' 
        txtTemperature.Location = New Point(242, 42)
        txtTemperature.Name = "txtTemperature"
        txtTemperature.Size = New Size(125, 27)
        txtTemperature.TabIndex = 1
        ' 
        ' btnCountingApp
        ' 
        btnCountingApp.Location = New Point(45, 108)
        btnCountingApp.Name = "btnCountingApp"
        btnCountingApp.Size = New Size(201, 77)
        btnCountingApp.TabIndex = 2
        btnCountingApp.Text = "Count Up Odd or Even"
        btnCountingApp.UseVisualStyleBackColor = True
        ' 
        ' btnDoWhile
        ' 
        btnDoWhile.Location = New Point(45, 212)
        btnDoWhile.Name = "btnDoWhile"
        btnDoWhile.Size = New Size(94, 29)
        btnDoWhile.TabIndex = 3
        btnDoWhile.Text = "Do While"
        btnDoWhile.UseVisualStyleBackColor = True
        ' 
        ' btnListOfFruit
        ' 
        btnListOfFruit.Location = New Point(54, 267)
        btnListOfFruit.Name = "btnListOfFruit"
        btnListOfFruit.Size = New Size(94, 29)
        btnListOfFruit.TabIndex = 4
        btnListOfFruit.Text = "Grocieries"
        btnListOfFruit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnListOfFruit)
        Controls.Add(btnDoWhile)
        Controls.Add(btnCountingApp)
        Controls.Add(txtTemperature)
        Controls.Add(btnCheck)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents btnCountingApp As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnListOfFruit As Button

End Class
