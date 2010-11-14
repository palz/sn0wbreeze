<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.logo1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.simpletext = New System.Windows.Forms.Label
        Me.expertext = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.description = New System.Windows.Forms.Label
        Me.description2 = New System.Windows.Forms.Label
        Me.Description3 = New System.Windows.Forms.Label
        Me.Process1 = New System.Diagnostics.Process
        Me.Process2 = New System.Diagnostics.Process
        Me.scheck = New System.Windows.Forms.PictureBox
        Me.echeck = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Process3 = New System.Diagnostics.Process
        Me.arrow = New System.Windows.Forms.PictureBox
        CType(Me.logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.echeck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo1
        '
        Me.logo1.BackColor = System.Drawing.Color.Black
        Me.logo1.Image = CType(resources.GetObject("logo1.Image"), System.Drawing.Image)
        Me.logo1.Location = New System.Drawing.Point(15, 12)
        Me.logo1.Name = "logo1"
        Me.logo1.Size = New System.Drawing.Size(87, 117)
        Me.logo1.TabIndex = 12
        Me.logo1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(108, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(639, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Please select a mode, then click the arrow continue."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, 233)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 60)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(98, 299)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(602, 62)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'simpletext
        '
        Me.simpletext.AutoSize = True
        Me.simpletext.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpletext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.simpletext.Location = New System.Drawing.Point(309, 248)
        Me.simpletext.Name = "simpletext"
        Me.simpletext.Size = New System.Drawing.Size(181, 31)
        Me.simpletext.TabIndex = 20
        Me.simpletext.Text = "Simple Mode"
        '
        'expertext
        '
        Me.expertext.AutoSize = True
        Me.expertext.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expertext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.expertext.Location = New System.Drawing.Point(311, 310)
        Me.expertext.Name = "expertext"
        Me.expertext.Size = New System.Drawing.Size(177, 31)
        Me.expertext.TabIndex = 21
        Me.expertext.Text = "Expert Mode"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(98, 233)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(602, 60)
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(98, 299)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(602, 62)
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.ForeColor = System.Drawing.Color.White
        Me.description.Location = New System.Drawing.Point(12, 396)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(77, 25)
        Me.description.TabIndex = 24
        Me.description.Text = "Label2"
        '
        'description2
        '
        Me.description2.AutoSize = True
        Me.description2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description2.ForeColor = System.Drawing.Color.White
        Me.description2.Location = New System.Drawing.Point(12, 421)
        Me.description2.Name = "description2"
        Me.description2.Size = New System.Drawing.Size(77, 25)
        Me.description2.TabIndex = 25
        Me.description2.Text = "Label3"
        '
        'Description3
        '
        Me.Description3.AutoSize = True
        Me.Description3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description3.ForeColor = System.Drawing.Color.White
        Me.Description3.Location = New System.Drawing.Point(12, 446)
        Me.Description3.Name = "Description3"
        Me.Description3.Size = New System.Drawing.Size(77, 25)
        Me.Description3.TabIndex = 26
        Me.Description3.Text = "Label3"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Process2
        '
        Me.Process2.StartInfo.Domain = ""
        Me.Process2.StartInfo.LoadUserProfile = False
        Me.Process2.StartInfo.Password = Nothing
        Me.Process2.StartInfo.StandardErrorEncoding = Nothing
        Me.Process2.StartInfo.StandardOutputEncoding = Nothing
        Me.Process2.StartInfo.UserName = ""
        Me.Process2.SynchronizingObject = Me
        '
        'scheck
        '
        Me.scheck.Image = CType(resources.GetObject("scheck.Image"), System.Drawing.Image)
        Me.scheck.Location = New System.Drawing.Point(17, 233)
        Me.scheck.Name = "scheck"
        Me.scheck.Size = New System.Drawing.Size(59, 60)
        Me.scheck.TabIndex = 29
        Me.scheck.TabStop = False
        '
        'echeck
        '
        Me.echeck.Image = CType(resources.GetObject("echeck.Image"), System.Drawing.Image)
        Me.echeck.Location = New System.Drawing.Point(17, 299)
        Me.echeck.Name = "echeck"
        Me.echeck.Size = New System.Drawing.Size(59, 60)
        Me.echeck.TabIndex = 30
        Me.echeck.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(385, 518)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Label3"
        '
        'Process3
        '
        Me.Process3.StartInfo.Domain = ""
        Me.Process3.StartInfo.LoadUserProfile = False
        Me.Process3.StartInfo.Password = Nothing
        Me.Process3.StartInfo.StandardErrorEncoding = Nothing
        Me.Process3.StartInfo.StandardOutputEncoding = Nothing
        Me.Process3.StartInfo.UserName = ""
        Me.Process3.SynchronizingObject = Me
        '
        'arrow
        '
        Me.arrow.Enabled = False
        Me.arrow.Image = Global.sn0wbreeze.My.Resources.Resources.Arrowgray
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(64, 63)
        Me.arrow.TabIndex = 32
        Me.arrow.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.echeck)
        Me.Controls.Add(Me.scheck)
        Me.Controls.Add(Me.Description3)
        Me.Controls.Add(Me.description2)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.expertext)
        Me.Controls.Add(Me.simpletext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo1)
        Me.Controls.Add(Me.arrow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "sn0wbreeze "
        CType(Me.logo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.echeck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents simpletext As System.Windows.Forms.Label
    Friend WithEvents expertext As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents description As System.Windows.Forms.Label
    Friend WithEvents description2 As System.Windows.Forms.Label
    Friend WithEvents Description3 As System.Windows.Forms.Label
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents Process2 As System.Diagnostics.Process
    Friend WithEvents echeck As System.Windows.Forms.PictureBox
    Friend WithEvents scheck As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Process3 As System.Diagnostics.Process
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
End Class
