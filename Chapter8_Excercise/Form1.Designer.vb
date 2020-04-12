<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartyAffiliations
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
        Me.GetPartyAffiliationsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DemocratTextBox = New System.Windows.Forms.TextBox()
        Me.RepublicanTextBox = New System.Windows.Forms.TextBox()
        Me.IndependentTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GetPartyAffiliationsButton
        '
        Me.GetPartyAffiliationsButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GetPartyAffiliationsButton.Location = New System.Drawing.Point(224, 78)
        Me.GetPartyAffiliationsButton.Name = "GetPartyAffiliationsButton"
        Me.GetPartyAffiliationsButton.Size = New System.Drawing.Size(259, 67)
        Me.GetPartyAffiliationsButton.TabIndex = 0
        Me.GetPartyAffiliationsButton.Text = "Get Party Affiliations"
        Me.GetPartyAffiliationsButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Democrats:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Republicans:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Independents:"
        '
        'DemocratTextBox
        '
        Me.DemocratTextBox.Location = New System.Drawing.Point(382, 191)
        Me.DemocratTextBox.Name = "DemocratTextBox"
        Me.DemocratTextBox.ReadOnly = True
        Me.DemocratTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DemocratTextBox.TabIndex = 4
        '
        'RepublicanTextBox
        '
        Me.RepublicanTextBox.Location = New System.Drawing.Point(382, 264)
        Me.RepublicanTextBox.Name = "RepublicanTextBox"
        Me.RepublicanTextBox.ReadOnly = True
        Me.RepublicanTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RepublicanTextBox.TabIndex = 5
        '
        'IndependentTextBox
        '
        Me.IndependentTextBox.Location = New System.Drawing.Point(383, 334)
        Me.IndependentTextBox.Name = "IndependentTextBox"
        Me.IndependentTextBox.ReadOnly = True
        Me.IndependentTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IndependentTextBox.TabIndex = 6
        '
        'PartyAffiliations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 440)
        Me.Controls.Add(Me.IndependentTextBox)
        Me.Controls.Add(Me.RepublicanTextBox)
        Me.Controls.Add(Me.DemocratTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetPartyAffiliationsButton)
        Me.Name = "PartyAffiliations"
        Me.Text = "U.S. Senate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetPartyAffiliationsButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DemocratTextBox As TextBox
    Friend WithEvents RepublicanTextBox As TextBox
    Friend WithEvents IndependentTextBox As TextBox
End Class
