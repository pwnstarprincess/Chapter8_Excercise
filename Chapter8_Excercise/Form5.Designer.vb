<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SenateMainForm
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
        Me.GenNewSenateButton = New System.Windows.Forms.Button()
        Me.PartyAffiliationButton = New System.Windows.Forms.Button()
        Me.SamePartyButton = New System.Windows.Forms.Button()
        Me.QuerySenatorsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GenNewSenateButton
        '
        Me.GenNewSenateButton.BackColor = System.Drawing.SystemColors.Control
        Me.GenNewSenateButton.Location = New System.Drawing.Point(73, 62)
        Me.GenNewSenateButton.Name = "GenNewSenateButton"
        Me.GenNewSenateButton.Size = New System.Drawing.Size(197, 57)
        Me.GenNewSenateButton.TabIndex = 0
        Me.GenNewSenateButton.Text = "New Senate Generator"
        Me.GenNewSenateButton.UseVisualStyleBackColor = False
        '
        'PartyAffiliationButton
        '
        Me.PartyAffiliationButton.BackColor = System.Drawing.SystemColors.Control
        Me.PartyAffiliationButton.Location = New System.Drawing.Point(516, 62)
        Me.PartyAffiliationButton.Name = "PartyAffiliationButton"
        Me.PartyAffiliationButton.Size = New System.Drawing.Size(197, 57)
        Me.PartyAffiliationButton.TabIndex = 1
        Me.PartyAffiliationButton.Text = "Party Affiliation Form"
        Me.PartyAffiliationButton.UseVisualStyleBackColor = False
        '
        'SamePartyButton
        '
        Me.SamePartyButton.BackColor = System.Drawing.SystemColors.Control
        Me.SamePartyButton.Location = New System.Drawing.Point(73, 237)
        Me.SamePartyButton.Name = "SamePartyButton"
        Me.SamePartyButton.Size = New System.Drawing.Size(197, 57)
        Me.SamePartyButton.TabIndex = 2
        Me.SamePartyButton.Text = "Same Party Affiliation Form"
        Me.SamePartyButton.UseVisualStyleBackColor = False
        '
        'QuerySenatorsButton
        '
        Me.QuerySenatorsButton.BackColor = System.Drawing.SystemColors.Control
        Me.QuerySenatorsButton.Location = New System.Drawing.Point(516, 237)
        Me.QuerySenatorsButton.Name = "QuerySenatorsButton"
        Me.QuerySenatorsButton.Size = New System.Drawing.Size(197, 57)
        Me.QuerySenatorsButton.TabIndex = 3
        Me.QuerySenatorsButton.Text = "Query Senators Per State"
        Me.QuerySenatorsButton.UseVisualStyleBackColor = False
        '
        'SenateMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.QuerySenatorsButton)
        Me.Controls.Add(Me.SamePartyButton)
        Me.Controls.Add(Me.PartyAffiliationButton)
        Me.Controls.Add(Me.GenNewSenateButton)
        Me.Name = "SenateMainForm"
        Me.Text = "U.S. Senate"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GenNewSenateButton As Button
    Friend WithEvents PartyAffiliationButton As Button
    Friend WithEvents SamePartyButton As Button
    Friend WithEvents QuerySenatorsButton As Button
End Class
