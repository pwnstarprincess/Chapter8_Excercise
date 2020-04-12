<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewFileForm
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
        Me.NewFileButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewFileButton
        '
        Me.NewFileButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.NewFileButton.Location = New System.Drawing.Point(143, 71)
        Me.NewFileButton.Name = "NewFileButton"
        Me.NewFileButton.Size = New System.Drawing.Size(196, 72)
        Me.NewFileButton.TabIndex = 0
        Me.NewFileButton.Text = "Create New File"
        Me.NewFileButton.UseVisualStyleBackColor = False
        '
        'CreateNewFileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 218)
        Me.Controls.Add(Me.NewFileButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "CreateNewFileForm"
        Me.Text = "U.S. Senate"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewFileButton As Button
End Class
