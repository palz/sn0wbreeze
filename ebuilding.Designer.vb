<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ebuilding
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.lblStatus = New System.Windows.Forms.Label
        Me.ihelper = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.PictureAnim = New System.Windows.Forms.PictureBox
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAnim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(140, 433)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(512, 15)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 35
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Green
        Me.lblStatus.Location = New System.Drawing.Point(388, 394)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblStatus.TabIndex = 36
        '
        'ihelper
        '
        Me.ihelper.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ihelper.AutoSize = True
        Me.ihelper.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ihelper.ForeColor = System.Drawing.Color.White
        Me.ihelper.Location = New System.Drawing.Point(351, 193)
        Me.ihelper.Name = "ihelper"
        Me.ihelper.Size = New System.Drawing.Size(88, 29)
        Me.ihelper.TabIndex = 38
        Me.ihelper.Text = "ihelper"
        Me.ihelper.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(356, 466)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = Global.sn0wbreeze.My.Resources.Resources.Flake
        Me.logo2.Location = New System.Drawing.Point(352, 39)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 79
        Me.logo2.TabStop = False
        '
        'PictureAnim
        '
        Me.PictureAnim.Image = Global.sn0wbreeze.My.Resources.Resources.spinny
        Me.PictureAnim.InitialImage = Nothing
        Me.PictureAnim.Location = New System.Drawing.Point(224, 162)
        Me.PictureAnim.Name = "PictureAnim"
        Me.PictureAnim.Size = New System.Drawing.Size(357, 265)
        Me.PictureAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureAnim.TabIndex = 41
        Me.PictureAnim.TabStop = False
        Me.PictureAnim.Visible = False
        '
        'ebuilding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PictureAnim)
        Me.Controls.Add(Me.ihelper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ebuilding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ebuilding"
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAnim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents PictureAnim As System.Windows.Forms.PictureBox
    Friend WithEvents ihelper As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
End Class
