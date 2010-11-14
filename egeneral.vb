Public Class egeneral
    Public Ignoreit As Boolean
    Private Sub CheckBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hacktivate.MouseEnter
        Try
            If iPhoneModel.Substring(0, 6) = "iPhone" Then
                Label2.Text = ("This option will activate your iPhone, if you are not on an official cell phone carrier")
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartitionsizeBar.Scroll
        Label3.Text = PartitionsizeBar.Value
        TextRoot.Text = PartitionsizeBar.Value
    End Sub
    Private Sub egeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PartitionsizeBar.Minimum = RootFSsize.ToString
        PartitionsizeBar.Maximum = 7000
        Label3.Text = RootFSsize.ToString
        TextRoot.Text = RootFSsize

        If iPhoneModel = "Apple TV 2" Then
            PartitionsizeBar.Maximum = 1024
        End If

        If iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Or iPhoneModel = "iPod Touch 1G" Or iPhoneModel = "iPod Touch 2G" Then
            Hacktivate.Checked = False
            ActivatePhone = False
            chkNOR.ForeColor = Color.DimGray
            Hacktivate.ForeColor = Color.DimGray
            chkWallpaper.ForeColor = Color.DimGray
            chkBatPercent.ForeColor = Color.DimGray
            ChkNativeTask.ForeColor = Color.DimGray
        Else
            Hacktivate.ForeColor = Color.White
            chkNOR.ForeColor = Color.White
            chkWallpaper.ForeColor = Color.White
            chkBatPercent.ForeColor = Color.White
            ChkNativeTask.ForeColor = Color.White
        End If
        If iPhoneModel = "iPod Touch 2G" Then
            chkWallpaper.ForeColor = Color.White
            chkBatPercent.ForeColor = Color.White
            ChkNativeTask.ForeColor = Color.White
        ElseIf iPhoneModel = "iPod Touch 3G" Then
            Hacktivate.Checked = False
            ActivatePhone = False
            chkNOR.ForeColor = Color.DimGray
            Hacktivate.ForeColor = Color.DimGray
            chkWallpaper.ForeColor = Color.DimGray
            chkBatPercent.ForeColor = Color.White
            ChkNativeTask.ForeColor = Color.DimGray
        End If
        If iPhoneModel = "iPod Touch 2G" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 1G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPad" Then
            Hacktivate.ForeColor = Color.DimGray
            Hacktivate.Checked = False
            ActivatePhone = False
            BasebandWarning.Text = " "
        End If
        If iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPhone 4" Or iPhoneModel = "iPod Touch 3G" Or iPod2GModel = "MC" Then
            chkNOR.ForeColor = Color.DimGray
            'MsgBox("YO")
        End If
        If iPhoneModel = "iPod Touch 2G" Or iPhoneModel = "iPhone 3G" Then
            ChkNativeTask.Enabled = True
            chkBatPercent.Enabled = True
            chkWallpaper.Enabled = True
        End If

        ActivatePhone = True
        Label3.Text = RootFSsize
        RootFSsize = TextRoot.Text
        ' Label3.Text = RootFSsize
        NOR = False
        chkNOR.Checked = False
    End Sub
    Private Sub TextRoot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextRoot.KeyPress
        'Only accept numbers
        If Not Char.IsDigit(e.KeyChar.ToString) Then
            If Not e.KeyChar = vbBack Then e.Handled = True
        End If
    End Sub
    Private Sub TextRoot_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextRoot.Leave
        On Error Resume Next
        If CInt(TextRoot.Text) = "" Then
            'Put nothing here please
        End If
        If CInt(TextRoot.Text) < RootFSsize.ToString Then
            Label2.ForeColor = Color.Red
            Label2.Text = "The the value entered was not valid."
            TextRoot.Text = RootFSsize.ToString
            Timer1.Start()
        End If
    End Sub
    Private Sub TextRoot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextRoot.TextChanged
        If TextRoot.Text = "" Then
            'TextRoot.Text = "600"
        ElseIf TextRoot.Text > 7000 Then
            TextRoot.Text = "7000"
            PartitionSize = TextRoot.Text
        ElseIf TextRoot.Text >= RootFSsize And TextRoot.Text <= 7000 Then
            PartitionsizeBar.Value = TextRoot.Text
            Label2.ForeColor = Color.White
            Label2.Text = ""
            PartitionSize = TextRoot.Text
        Else
            PartitionSize = TextRoot.Text
        End If

    End Sub
    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.Image = My.Resources.Flake
    End Sub
    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.Image = My.Resources.Flakeselect
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label2.ForeColor = Color.Red Then
            Label2.ForeColor = Color.White
            Label2.Text = ""
            Timer1.Stop()
        End If
    End Sub
    Private Sub egeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        On Error Resume Next
        If CInt(TextRoot.Text) = "" Then
            'Put nothing here please
        End If
        If CInt(TextRoot.Text) < RootFSsize.ToString Then
            Label2.ForeColor = Color.Red
            Label2.Text = "The the value entered was not valid."
            TextRoot.Text = RootFSsize.ToString
            Timer1.Start()
        End If
    End Sub
    Private Sub Activatephone_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Hacktivate.Enabled = True Then
            Label2.Text = ("This option will activate your iPhone, if you are not on an official cell phone carrier")
        ElseIf Hacktivate.Enabled = False Then
            Label2.Text = "This option is not available for the iPod Touch"
        End If

    End Sub
    Private Sub Activatephone_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label2.Text = ""
    End Sub
    Private Sub CheckBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hacktivate.MouseLeave
        Label2.Text = ""
    End Sub
    Private Sub logo2_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub
    Private Sub logo2_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flake
    End Sub
    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        If chkNOR.Checked = True Then
            ebootlogos.MdiParent = MDIMain
            ebootlogos.Show()
            Me.Hide()
        Else
            If iPhoneModel = "iPhone 3G" Then
                ebootlogos.MdiParent = MDIMain
                ebootlogos.Show()
                Me.Hide()
                Exit Sub
            End If
            If iPhoneModel = "iPod Touch 2G" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
                ecustomapps.MdiParent = MDIMain
                ecustomapps.Show()
                Me.Hide()
            Else
                PartitionSize = TextRoot.Text
                eunlock.MdiParent = MDIMain
                eunlock.Show()
                Me.Hide()
            End If
            End If
            'save to global variable in memory - check ModMain
    End Sub
    Private Sub arrow_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseEnter
        arrow.Image = My.Resources.Arrowhilite
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
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hacktivate.CheckedChanged
        If iPhoneModel = "iPod Touch 1G" Or iPhoneModel = "iPod Touch 2G" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            Hacktivate.Checked = False
            ActivatePhone = False
            Exit Sub
        End If
        If Hacktivate.Checked = True Then
            ActivatePhone = True
        Else
            ActivatePhone = False
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles WutisNOR.LinkClicked
        MsgBox("Marking the IPSW as a NOR-Only IPSW has 1 major advantage. You can change your Boot Logo without wiping out ANYTHING on your Device, and iPhone Users can make iBoot boot in Verbose without a Restore.", MsgBoxStyle.Information)
    End Sub
    Private Sub chkNOR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNOR.CheckedChanged
        If iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "Apple TV 2" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPad" Or iPhoneModel = "iPhone 4" Or ThisiPodisMB = False Or This3GSisold = False Then
            chkNOR.Checked = False
            NOR = False
            Exit Sub
        End If

        If chkNOR.Checked = True Then
            NOR = True
            Expert.cpackage.Enabled = False
            Expert.unlocks.Enabled = False
            Hacktivate.Enabled = False
            Hacktivate.Visible = False
            PartitionsizeBar.Visible = False
            Label7.Visible = False
            BasebandWarning.Visible = False
            TextRoot.Visible = False
            Label8.Visible = False
            ChkNativeTask.Visible = False
            ChkNativeTask.Enabled = False
            chkBatPercent.Visible = False
            chkBatPercent.Enabled = False
            chkWallpaper.Visible = False
            chkWallpaper.Enabled = False

            chkInstallSSH.Visible = False
            chkInstallSSH.Enabled = False
        Else
            NOR = False
            Expert.cpackage.Enabled = True
            Expert.unlocks.Enabled = True
            PartitionsizeBar.Visible = True
            Label7.Visible = True
            BasebandWarning.Visible = True
            TextRoot.Visible = True
            Label8.Visible = True
            ChkNativeTask.Visible = True
            ChkNativeTask.Enabled = True
            chkBatPercent.Visible = True
            chkBatPercent.Enabled = True
            chkWallpaper.Visible = True
            chkWallpaper.Enabled = True
            chkInstallSSH.Visible = True
            chkInstallSSH.Enabled = True


            If iPhoneModel = "iPod Touch 2G" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Then
                Hacktivate.Visible = False
                Hacktivate.Checked = False
                ActivatePhone = False
                BasebandWarning.Text = " "
            Else
                Hacktivate.Enabled = True
                Hacktivate.Visible = True
            End If

        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWallpaper.CheckedChanged
        If iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            chkWallpaper.Checked = False
            Exit Sub
        End If
        If chkWallpaper.Checked = True Then
            EnableWallpaper = True
            If iPhoneModel = "iPhone 3GS" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPhone 4" Then
                MsgBox("This option is already enabled by Apple.", MsgBoxStyle.Information)
                Me.chkWallpaper.Checked = False
                EnableWallpaper = False
            End If
        Else
            EnableWallpaper = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBatPercent.CheckedChanged
        If iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            chkBatPercent.Checked = False
            Exit Sub
        End If
        If chkBatPercent.Checked = True Then
            EnablePercentage = True
            If iPhoneModel = "iPhone 3GS" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPhone 4" Then
                MsgBox("This option is already enabled by Apple.", MsgBoxStyle.Information)
                Me.chkBatPercent.Checked = False
                EnablePercentage = False
            End If
        Else
            EnablePercentage = False
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkNativeTask.CheckedChanged
        If iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            ChkNativeTask.Checked = False
            Exit Sub
        End If
        If ChkNativeTask.Checked = True Then
            EnableMultiTasking = True
            If iPhoneModel = "iPhone 3GS" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPhone 4" Then
                MsgBox("This option is already enabled by Apple.", MsgBoxStyle.Information)
                Me.ChkNativeTask.Checked = False
                EnableMultiTasking = False
            End If
        Else
            EnableMultiTasking = False
        End If
    End Sub
    Private Sub EnableHDR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IPSWVersion = "3.2.2" Then
            EnableMultiTasking = False
            EnablePercentage = False
            EnableWallpaper = False
        End If
        If iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            EnableMultiTasking = False
            EnablePercentage = False
            EnableWallpaper = False
            EnableHDR = False
            Exit Sub
        End If
    End Sub
    Private Sub InstallSSH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInstallSSH.CheckedChanged
        If chkInstallSSH.Checked = True Then
            InstallSSH = True
            MsgBox("When enabling SSH on your device," & Chr(13) & "Please ensure that you change your password." & Chr(13) & Chr(13) & "You can do that by doing:" & Chr(13) & Chr(13) & "1) Login to SSH (User : root) (Pass : alpine)." & Chr(13) & "2) Type ""passwd"" (No Quotes)." & Chr(13) & "3) Type your new SSH Password.", MsgBoxStyle.Information)
        Else
            InstallSSH = False
        End If
    End Sub
End Class