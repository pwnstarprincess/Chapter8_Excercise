<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SamePartyAffiliation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SamePartyButton = New System.Windows.Forms.Button()
        Me.NumberOfStatesTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SamePartyButton
        '
        Me.SamePartyButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SamePartyButton.Location = New System.Drawing.Point(131, 84)
        Me.SamePartyButton.Name = "SamePartyButton"
        Me.SamePartyButton.Size = New System.Drawing.Size(358, 88)
        Me.SamePartyButton.TabIndex = 0
        Me.SamePartyButton.Text = "Count the Number of States whose Senators have the same Party Affiliation"
        Me.SamePartyButton.UseVisualStyleBackColor = False
        '
        'NumberOfStatesTextBox
        '
        Me.NumberOfStatesTextBox.Location = New System.Drawing.Point(250, 254)
        Me.NumberOfStatesTextBox.Name = "NumberOfStatesTextBox"
        Me.NumberOfStatesTextBox.ReadOnly = True
        Me.NumberOfStatesTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NumberOfStatesTextBox.TabIndex = 1
        '
        'SamePartyAffiliation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 312)
        Me.Controls.Add(Me.NumberOfStatesTextBox)
        Me.Controls.Add(Me.SamePartyButton)
        Me.Name = "SamePartyAffiliation"
        Me.Text = "U.S. Senate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SamePartyButton As Button
    Friend WithEvents NumberOfStatesTextBox As TextBox
End Class
