<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.LabelCalendar = New System.Windows.Forms.Label()
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelEvents = New System.Windows.Forms.Label()
        Me.TextBoxEvent = New System.Windows.Forms.TextBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelEvent = New System.Windows.Forms.Label()
        Me.ListBoxMyEvents = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ΡυθμίσηςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΡολόιToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΑναλογικόToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΨηφιακόToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΈξοδοςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΠληροφορίεςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelHelp = New System.Windows.Forms.Label()
        Me.PictureBoxHelp = New System.Windows.Forms.PictureBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.PictureBoxHelp2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBoxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHelp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendar1.Location = New System.Drawing.Point(17, 72)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'LabelCalendar
        '
        Me.LabelCalendar.AutoSize = True
        Me.LabelCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelCalendar.Location = New System.Drawing.Point(12, 34)
        Me.LabelCalendar.Name = "LabelCalendar"
        Me.LabelCalendar.Size = New System.Drawing.Size(153, 29)
        Me.LabelCalendar.TabIndex = 1
        Me.LabelCalendar.Text = "Ημερολόγιο"
        '
        'LabelClock
        '
        Me.LabelClock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClock.AutoSize = True
        Me.LabelClock.Font = New System.Drawing.Font("Digit", 45.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClock.Location = New System.Drawing.Point(6, 253)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(178, 60)
        Me.LabelClock.TabIndex = 2
        Me.LabelClock.Text = "Clock"
        Me.LabelClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'LabelEvents
        '
        Me.LabelEvents.AutoSize = True
        Me.LabelEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelEvents.Location = New System.Drawing.Point(276, 37)
        Me.LabelEvents.Name = "LabelEvents"
        Me.LabelEvents.Size = New System.Drawing.Size(108, 25)
        Me.LabelEvents.TabIndex = 4
        Me.LabelEvents.Text = "Εργασίες"
        '
        'TextBoxEvent
        '
        Me.TextBoxEvent.Location = New System.Drawing.Point(365, 262)
        Me.TextBoxEvent.Name = "TextBoxEvent"
        Me.TextBoxEvent.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxEvent.TabIndex = 7
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(365, 235)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxDate.TabIndex = 8
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(287, 238)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(72, 13)
        Me.LabelDate.TabIndex = 10
        Me.LabelDate.Text = "Ημερομηνία: "
        '
        'LabelEvent
        '
        Me.LabelEvent.AutoSize = True
        Me.LabelEvent.Location = New System.Drawing.Point(298, 265)
        Me.LabelEvent.Name = "LabelEvent"
        Me.LabelEvent.Size = New System.Drawing.Size(55, 13)
        Me.LabelEvent.TabIndex = 11
        Me.LabelEvent.Text = "Εργασία: "
        '
        'ListBoxMyEvents
        '
        Me.ListBoxMyEvents.FormattingEnabled = True
        Me.ListBoxMyEvents.Location = New System.Drawing.Point(281, 72)
        Me.ListBoxMyEvents.Name = "ListBoxMyEvents"
        Me.ListBoxMyEvents.Size = New System.Drawing.Size(225, 95)
        Me.ListBoxMyEvents.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Δημιουργία Εργασίας"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΡυθμίσηςToolStripMenuItem, Me.ΠληροφορίεςToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ΡυθμίσηςToolStripMenuItem
        '
        Me.ΡυθμίσηςToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΡολόιToolStripMenuItem, Me.ΈξοδοςToolStripMenuItem})
        Me.ΡυθμίσηςToolStripMenuItem.Name = "ΡυθμίσηςToolStripMenuItem"
        Me.ΡυθμίσηςToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ΡυθμίσηςToolStripMenuItem.Text = "Ρυθμίσης"
        '
        'ΡολόιToolStripMenuItem
        '
        Me.ΡολόιToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΑναλογικόToolStripMenuItem, Me.ΨηφιακόToolStripMenuItem})
        Me.ΡολόιToolStripMenuItem.Name = "ΡολόιToolStripMenuItem"
        Me.ΡολόιToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ΡολόιToolStripMenuItem.Text = "Μορφή Ρολογιού"
        '
        'ΑναλογικόToolStripMenuItem
        '
        Me.ΑναλογικόToolStripMenuItem.Name = "ΑναλογικόToolStripMenuItem"
        Me.ΑναλογικόToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ΑναλογικόToolStripMenuItem.Text = "Αναλογικό"
        '
        'ΨηφιακόToolStripMenuItem
        '
        Me.ΨηφιακόToolStripMenuItem.Name = "ΨηφιακόToolStripMenuItem"
        Me.ΨηφιακόToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ΨηφιακόToolStripMenuItem.Text = "Ψηφιακό"
        '
        'ΈξοδοςToolStripMenuItem
        '
        Me.ΈξοδοςToolStripMenuItem.Name = "ΈξοδοςToolStripMenuItem"
        Me.ΈξοδοςToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ΈξοδοςToolStripMenuItem.Text = "Έξοδος"
        '
        'ΠληροφορίεςToolStripMenuItem
        '
        Me.ΠληροφορίεςToolStripMenuItem.Name = "ΠληροφορίεςToolStripMenuItem"
        Me.ΠληροφορίεςToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ΠληροφορίεςToolStripMenuItem.Text = "Πληροφορίες"
        '
        'LabelHelp
        '
        Me.LabelHelp.AutoSize = True
        Me.LabelHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelHelp.Location = New System.Drawing.Point(301, 170)
        Me.LabelHelp.Name = "LabelHelp"
        Me.LabelHelp.Size = New System.Drawing.Size(230, 15)
        Me.LabelHelp.TabIndex = 17
        Me.LabelHelp.Text = "Διπλό κλίκ στην εργασία για επεξεργασία." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelHelp.Visible = False
        '
        'PictureBoxHelp
        '
        Me.PictureBoxHelp.Image = Global.myCalendar.My.Resources.Resources.Info_Simple_svg
        Me.PictureBoxHelp.Location = New System.Drawing.Point(281, 170)
        Me.PictureBoxHelp.Name = "PictureBoxHelp"
        Me.PictureBoxHelp.Size = New System.Drawing.Size(14, 15)
        Me.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHelp.TabIndex = 16
        Me.PictureBoxHelp.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSave.ForeColor = System.Drawing.Color.Green
        Me.ButtonSave.Location = New System.Drawing.Point(436, 288)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(85, 25)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Δημιουργία"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.ForeColor = System.Drawing.Color.Maroon
        Me.ButtonDelete.Location = New System.Drawing.Point(345, 288)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(85, 25)
        Me.ButtonDelete.TabIndex = 18
        Me.ButtonDelete.Text = "Διαγραφή"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'PictureBoxHelp2
        '
        Me.PictureBoxHelp2.Image = Global.myCalendar.My.Resources.Resources.Info_Simple_svg
        Me.PictureBoxHelp2.Location = New System.Drawing.Point(516, 206)
        Me.PictureBoxHelp2.Name = "PictureBoxHelp2"
        Me.PictureBoxHelp2.Size = New System.Drawing.Size(17, 16)
        Me.PictureBoxHelp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHelp2.TabIndex = 19
        Me.PictureBoxHelp2.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(551, 334)
        Me.Controls.Add(Me.PictureBoxHelp2)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelHelp)
        Me.Controls.Add(Me.PictureBoxHelp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxMyEvents)
        Me.Controls.Add(Me.LabelEvent)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.TextBoxEvent)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelEvents)
        Me.Controls.Add(Me.LabelClock)
        Me.Controls.Add(Me.LabelCalendar)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Ημερολόγιο"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBoxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHelp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents LabelCalendar As Label
    Friend WithEvents LabelClock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelEvents As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxEvent As TextBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelEvent As Label
    Friend WithEvents ListBoxMyEvents As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ΡυθμίσηςToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΡολόιToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΈξοδοςToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΠληροφορίεςToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΑναλογικόToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΨηφιακόToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxHelp As PictureBox
    Friend WithEvents LabelHelp As Label
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents PictureBoxHelp2 As PictureBox
End Class
