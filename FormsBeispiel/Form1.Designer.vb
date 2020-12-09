<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Me.Btn_KlickMich = New System.Windows.Forms.Button()
        Me.Btn_Zwei = New System.Windows.Forms.Button()
        Me.Cbx_Haken = New System.Windows.Forms.CheckBox()
        Me.Cbb_Auswahl = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Lbl_Ausgabe = New System.Windows.Forms.Label()
        Me.Tbx_Input = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffenenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_MessageBox = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_KlickMich
        '
        Me.Btn_KlickMich.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_KlickMich.Location = New System.Drawing.Point(71, 60)
        Me.Btn_KlickMich.Name = "Btn_KlickMich"
        Me.Btn_KlickMich.Size = New System.Drawing.Size(148, 45)
        Me.Btn_KlickMich.TabIndex = 0
        Me.Btn_KlickMich.Text = "Klick Mich"
        Me.Btn_KlickMich.UseVisualStyleBackColor = True
        '
        'Btn_Zwei
        '
        Me.Btn_Zwei.Location = New System.Drawing.Point(51, 128)
        Me.Btn_Zwei.Name = "Btn_Zwei"
        Me.Btn_Zwei.Size = New System.Drawing.Size(168, 59)
        Me.Btn_Zwei.TabIndex = 1
        Me.Btn_Zwei.Text = "Moin"
        Me.Btn_Zwei.UseVisualStyleBackColor = True
        '
        'Cbx_Haken
        '
        Me.Cbx_Haken.AutoSize = True
        Me.Cbx_Haken.Checked = True
        Me.Cbx_Haken.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Cbx_Haken.Location = New System.Drawing.Point(131, 228)
        Me.Cbx_Haken.Name = "Cbx_Haken"
        Me.Cbx_Haken.Size = New System.Drawing.Size(108, 21)
        Me.Cbx_Haken.TabIndex = 2
        Me.Cbx_Haken.Text = "Hak mich ab"
        Me.Cbx_Haken.UseVisualStyleBackColor = True
        '
        'Cbb_Auswahl
        '
        Me.Cbb_Auswahl.FormattingEnabled = True
        Me.Cbb_Auswahl.Items.AddRange(New Object() {"Eintrag 1", "Auswahl 2", "Item 3"})
        Me.Cbb_Auswahl.Location = New System.Drawing.Point(315, 60)
        Me.Cbb_Auswahl.Name = "Cbb_Auswahl"
        Me.Cbb_Auswahl.Size = New System.Drawing.Size(229, 24)
        Me.Cbb_Auswahl.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(647, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 142)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gruppe 1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(740, 201)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(740, 228)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(27, 31)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(27, 58)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Lbl_Ausgabe
        '
        Me.Lbl_Ausgabe.AutoSize = True
        Me.Lbl_Ausgabe.Location = New System.Drawing.Point(312, 128)
        Me.Lbl_Ausgabe.Name = "Lbl_Ausgabe"
        Me.Lbl_Ausgabe.Size = New System.Drawing.Size(122, 17)
        Me.Lbl_Ausgabe.TabIndex = 7
        Me.Lbl_Ausgabe.Text = "Ich bin ein String!!!"
        '
        'Tbx_Input
        '
        Me.Tbx_Input.AcceptsReturn = True
        Me.Tbx_Input.AcceptsTab = True
        Me.Tbx_Input.Location = New System.Drawing.Point(315, 190)
        Me.Tbx_Input.Multiline = True
        Me.Tbx_Input.Name = "Tbx_Input"
        Me.Tbx_Input.Size = New System.Drawing.Size(272, 122)
        Me.Tbx_Input.TabIndex = 8
        Me.Tbx_Input.Text = "EINGABE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(950, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffenenToolStripMenuItem, Me.SchließenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ÖffenenToolStripMenuItem
        '
        Me.ÖffenenToolStripMenuItem.Name = "ÖffenenToolStripMenuItem"
        Me.ÖffenenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ÖffenenToolStripMenuItem.Text = "Öffenen"
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SchließenToolStripMenuItem.Text = "Schließen"
        '
        'Btn_MessageBox
        '
        Me.Btn_MessageBox.Location = New System.Drawing.Point(83, 325)
        Me.Btn_MessageBox.Name = "Btn_MessageBox"
        Me.Btn_MessageBox.Size = New System.Drawing.Size(94, 42)
        Me.Btn_MessageBox.TabIndex = 10
        Me.Btn_MessageBox.Text = "Öffne MB"
        Me.Btn_MessageBox.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 401)
        Me.Controls.Add(Me.Btn_MessageBox)
        Me.Controls.Add(Me.Tbx_Input)
        Me.Controls.Add(Me.Lbl_Ausgabe)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Btn_Zwei)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cbb_Auswahl)
        Me.Controls.Add(Me.Cbx_Haken)
        Me.Controls.Add(Me.Btn_KlickMich)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mein besonders schönes Fenster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_KlickMich As Button
    Friend WithEvents Btn_Zwei As Button
    Friend WithEvents Cbx_Haken As CheckBox
    Friend WithEvents Cbb_Auswahl As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Lbl_Ausgabe As Label
    Friend WithEvents Tbx_Input As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖffenenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_MessageBox As Button
End Class
