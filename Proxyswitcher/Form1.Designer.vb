<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProxySwitcher
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
        Me.Disable = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Disable
        '
        Me.Disable.Location = New System.Drawing.Point(75, 24)
        Me.Disable.Name = "Disable"
        Me.Disable.Size = New System.Drawing.Size(75, 23)
        Me.Disable.TabIndex = 0
        Me.Disable.Text = "Disable"
        Me.Disable.UseVisualStyleBackColor = True
        '
        'btnEnable
        '
        Me.btnEnable.Location = New System.Drawing.Point(75, 81)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(75, 23)
        Me.btnEnable.TabIndex = 1
        Me.btnEnable.Text = "Enable"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'frmProxySwitcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 141)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.Disable)
        Me.Name = "frmProxySwitcher"
        Me.Text = "Proxy Switcher"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Disable As System.Windows.Forms.Button
    Friend WithEvents btnEnable As System.Windows.Forms.Button

End Class
