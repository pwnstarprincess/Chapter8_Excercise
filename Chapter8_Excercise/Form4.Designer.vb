<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplaySenators
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListStates = New System.Windows.Forms.ListBox()
        Me.ListSenators = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "State:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(500, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senators:"
        '
        'ListStates
        '
        Me.ListStates.FormattingEnabled = True
        Me.ListStates.ItemHeight = 20
        Me.ListStates.Location = New System.Drawing.Point(124, 144)
        Me.ListStates.Name = "ListStates"
        Me.ListStates.Size = New System.Drawing.Size(241, 244)
        Me.ListStates.TabIndex = 3
        '
        'ListSenators
        '
        Me.ListSenators.FormattingEnabled = True
        Me.ListSenators.ItemHeight = 20
        Me.ListSenators.Location = New System.Drawing.Point(504, 144)
        Me.ListSenators.Name = "ListSenators"
        Me.ListSenators.Size = New System.Drawing.Size(239, 84)
        Me.ListSenators.TabIndex = 4
        '
        'DisplaySenators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListSenators)
        Me.Controls.Add(Me.ListStates)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DisplaySenators"
        Me.Text = "U.S. Senate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListStates As ListBox
    Friend WithEvents ListSenators As ListBox
End Class
