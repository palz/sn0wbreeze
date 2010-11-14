Public Class Form2

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Close()
        End
    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpletext.MouseEnter, PictureBox4.MouseLeave
        PictureBox1.Show()
        PictureBox1.BringToFront()
        description.Text = ""
        description2.Text = ""
        Description3.Text = ""
        simpletext.BringToFront()
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, PictureBox1.MouseEnter
        PictureBox4.Show()
        PictureBox4.BringToFront()
        description.Text = "Simple Mode - Recommended to people that dont know what to add."
        description2.Text = "Simple Mode adds Cydia, afc2, SSH for Apple TV, and other"
        Description3.Text = "recommended stuff automatically."
        PictureBox1.Hide()
        simpletext.SendToBack()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Hide()
        Timer1.Start()
        scheck.Hide()
        echeck.Hide()
        PictureBox5.Hide()
        PictureBox4.Hide()
        description.Text = ""
        description2.Text = ""
        Description3.Text = ""
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox2.Show()
        PictureBox2.BringToFront()
        description.Text = ""
        description2.Text = ""
        Description3.Text = ""
        expertext.BringToFront()
        PictureBox5.Hide()
        UserMode = "Expert"
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, PictureBox2.MouseEnter
        PictureBox5.Show()
        PictureBox5.BringToFront()
        PictureBox2.Hide()
        'description.Text = "FUNCTION DISABLED UNTIL FULL RELEASE."
        description.Text = "Expert Mode lets you have all customizing options at your disposal"
        description2.Text = "Such as custom boot logos, root partition size, installer options"
        Description3.Text = "and unlocks."
        expertext.SendToBack()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub arrowover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        arrow.Show()

    End Sub

    Private Sub Process1_Exited(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process1.Exited, PictureBox4.Click
        description.Text = "Simple Mode - Recommended to people that dont know what to add."
        description2.Text = "Simple Mode adds Cydia, afc2, SSH for Apple TV, and other"
        Description3.Text = "recommended stuff automatically."
        PictureBox4.Show()
        scheck.Show()
        echeck.Hide()
        arrow.Image = My.Resources.Arrow
        arrow.Enabled = True
    End Sub

    Private Sub Process2_Exited(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process2.Exited, PictureBox5.Click
        description2.Text = "Such as custom boot logos, root partition size, installer options"
        Description3.Text = "and unlocks."
        scheck.Hide()
        echeck.Show()
        arrow.Image = My.Resources.Arrow
        arrow.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If scheck.Visible = True Or echeck.Visible = True Then
            Label2.Show()
            Label2.Text = "Click the blue arrow to continue"
        End If
    End Sub

    Private Sub Process3_Exited(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process3.Exited
        Timer1.Stop()
        If echeck.Visible = True Then
            IdentifyIPSW.Show()
            Me.Hide()
        End If
        If scheck.Visible = True Then
            ebuilding.MdiParent = MDIMain
            ebuilding.Show()
            Me.Hide()
        End If
        If scheck.Visible = False And echeck.Visible = False Then
            MsgBox("Please select a mode to continue")
        End If
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseEnter
        arrow.Image = My.Resources.Arrowhilite

    End Sub

    Private Sub arrow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        If echeck.Visible = True Then
            Expert.MdiParent = MDIMain
            UserMode = "Expert"
            Expert.Show()
            Me.Close()
        End If
        If scheck.Visible = True Then
            UserMode = "Simple"
            ebuilding.MdiParent = MDIMain
            ebuilding.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub arrow_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseLeave
        arrow.Image = My.Resources.Arrow
    End Sub

    Private Sub arrow_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseDown
        arrow.Image = My.Resources.arrowpress
    End Sub

    Private Sub arrow_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseUp
        arrow.Image = My.Resources.Arrowhilite
    End Sub
    Private Sub PictureBox4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.DoubleClick
        ebuilding.MdiParent = MDIMain
        ebuilding.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.DoubleClick
        Expert.MdiParent = MDIMain
        Expert.Show()
        Me.Close()
    End Sub
    Private Sub logo1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo1.MouseEnter
        logo1.Image = My.Resources.Flakeselect

    End Sub

    Private Sub logo1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo1.MouseLeave
        logo1.Image = My.Resources.Flake

    End Sub
End Class