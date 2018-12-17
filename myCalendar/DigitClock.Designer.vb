<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DigitClock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DigitClock))
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelClock
        '
        Me.LabelClock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelClock.AutoSize = True
        Me.LabelClock.Font = New System.Drawing.Font("Digit", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClock.Location = New System.Drawing.Point(12, 31)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(200, 65)
        Me.LabelClock.TabIndex = 0
        Me.LabelClock.Text = "Clock"
        '
        'Timer1
        '
        '
        'DigitClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 131)
        Me.Controls.Add(Me.LabelClock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DigitClock"
        Me.Text = "Ψηφιακό Ρολόι"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelClock As Label
    Friend WithEvents Timer1 As Timer
End Class
