Public Class Expert

    Private Sub General_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.Click
        buildcheck.Hide()
        arrowgray.Hide()
        generalcheck.Show()
        uncheck.Hide()
        cpcheck.Hide()
        logocheck.Hide()
    End Sub

    Private Sub General_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.MouseEnter
        General.Image = My.Resources.GeneralHighlight1
    End Sub

    Private Sub General_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.MouseLeave
        General.Image = My.Resources.GeneralNorm1
    End Sub

    Private Sub cpackage_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.MouseEnter
        cpackage.Image = My.Resources.CustomPKGHighLight1
    End Sub

    Private Sub cpackage_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.MouseLeave
        cpackage.Image = My.Resources.CustomPKGNorm1
    End Sub

    Private Sub unlocks_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.MouseEnter
        unlocks.Image = My.Resources.UNLOCKHighLight1
    End Sub

    Private Sub unlocks_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.MouseLeave
        unlocks.Image = My.Resources.UNLOCKNorm1
    End Sub

    Private Sub eForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label2.Text = iPhoneModel & " -- " & IPSWVersion
        buildcheck.Hide()
        uncheck.Hide()
        cpcheck.Hide()
        logocheck.Hide()
        generalcheck.Hide()
        If iPhoneModel = "iPod Touch 1G" Or iPhoneModel = "iPod Touch 2G" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            unlocks.Enabled = False
        ElseIf iPhoneModel = "iPhone 2G" Or iPhoneModel = "iPhone 3G" Or iPhoneModel = "iPhone 3GS" Or iPhoneModel = "iPhone 4" Then
            unlocks.Enabled = True
            unlocks.Show()
        End If
        If UseComexsAwesomeKernelExploit = True Then
            bootlogos.Enabled = False
        Else
            bootlogos.Enabled = True
            bootlogos.Show()
        End If
        If iPhoneModel = "iPhone 3G" Or This3GSisold = True Or ThisiPodisMB = True Then
            bootlogos.Enabled = True
            bootlogos.Show()
        End If
    End Sub

    Private Sub cpackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.Click
        If egeneral.chkNOR.Checked = True Then
            MsgBox("This feature is not available with the NOR-Only IPSW option")
        Else
            cpackage.Image = My.Resources.CustomPKGHighLight1
            arrowgray.Hide()
            cpcheck.Show()
            uncheck.Hide()
            logocheck.Hide()
            generalcheck.Hide()
            buildcheck.Hide()
        End If
    End Sub

    Private Sub installers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If egeneral.chkNOR.Checked = True Then
            MsgBox("This feature is not available with the NOR-Only IPSW option")
        Else
            arrowgray.Hide()
            uncheck.Hide()
            generalcheck.Hide()
            cpcheck.Hide()
            logocheck.Hide()
            buildcheck.Hide()
        End If
    End Sub

    Private Sub unlocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.Click
        If iPhoneModel = "iPod Touch 2G" Then
            unlocks.Enabled = False
        End If
        If egeneral.chkNOR.Checked = True Then
            MsgBox("This feature is not available with the NOR-Only IPSW option")
        Else
            unlocks.Image = My.Resources.UNLOCKHighLight1
            arrowgray.Hide()
            uncheck.Show()
            cpcheck.Hide()
            generalcheck.Hide()
            logocheck.Hide()
            buildcheck.Hide()
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.MouseEnter
        bootlogos.Image = My.Resources.BootLogosHighLight1
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.MouseLeave
        bootlogos.Image = My.Resources.BootLogosNorm1
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.MouseLeave
        build.Image = My.Resources.BuildNorm
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.MouseEnter
        build.Image = My.Resources.BuildHighlight
    End Sub

    Private Sub arrowgray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        If generalcheck.Visible = True Then
            egeneral.MdiParent = MDIMain
            egeneral.Show()
            Me.Hide()
        ElseIf uncheck.Visible = True Then
            If Label2.Text = "iPod Touch 1G" Or Label2.Text = "iPod Touch 2G" Then
                MsgBox("You cannot use unlocks on an iPod Touch", MsgBoxStyle.Information, "sn0wbreeze Lite 3.1.2")
            End If
            If Label2.Text = "iPhone 3GS" Or Label2.Text = "iPhone 3G" Or Label2.Text = "iPhone 2G" Then
                eunlock.MdiParent = MDIMain
                eunlock.Show()
                Me.Hide()
            End If
        ElseIf cpcheck.Visible = True Then
            ecustomapps.MdiParent = MDIMain
            ecustomapps.Show()
            Me.Hide()
        ElseIf logocheck.Visible = True Then
            ebootlogos.MdiParent = MDIMain
            ebootlogos.Show()
            Me.Hide()
        ElseIf buildcheck.Visible = True Then
            ebuilding.MdiParent = MDIMain
            ebuilding.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub

    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flake
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

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.Click
        bootlogos.Image = My.Resources.BootLogosNorm1
        arrowgray.Hide()
        uncheck.Hide()
        cpcheck.Hide()
        generalcheck.Hide()
        logocheck.Show()
        buildcheck.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.Click
        uncheck.Hide()
        arrowgray.Hide()
        cpcheck.Hide()
        generalcheck.Hide()
        logocheck.Hide()
        buildcheck.Show()
        build.Image = My.Resources.BuildHighlight

    End Sub

    Private Sub General_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.DoubleClick
        egeneral.MdiParent = MDIMain
        egeneral.Show()
        Me.Hide()
    End Sub
    Private Sub unlocks_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.DoubleClick
        If egeneral.chkNOR.Checked = True Then
            MsgBox("This feature is not available with the NOR-Only IPSW option")
        Else
            eunlock.MdiParent = MDIMain
            eunlock.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cpackage_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.DoubleClick
        If egeneral.chkNOR.Checked = True Then
            MsgBox("This feature is not available with the NOR-Only IPSW option")
        Else
            ecustomapps.MdiParent = MDIMain
            ecustomapps.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub bootlogos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.DoubleClick
        ebootlogos.MdiParent = MDIMain
        ebootlogos.Show()
        Me.Hide()
    End Sub

    Private Sub build_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.DoubleClick
        ebuilding.MdiParent = MDIMain
        ebuilding.Show()
        Me.Hide()
    End Sub

    Private Sub arrowgray_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrowgray.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub eForm2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub eForm2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If generalcheck.Visible = True Then
                egeneral.MdiParent = MDIMain
                egeneral.Show()
                Me.Hide()
            ElseIf uncheck.Visible = True Then
                If Label2.Text = "iPod Touch 1G" Or Label2.Text = "iPod Touch 2G" Then
                    MsgBox("You cannot use unlocks on an iPod Touch", MsgBoxStyle.Information, "sn0wbreeze Lite 3.1.2")
                End If
                If Label2.Text = "iPhone 3GS" Or Label2.Text = "iPhone 3G" Or Label2.Text = "iPhone 2G" Then
                    eunlock.MdiParent = MDIMain
                    eunlock.Show()
                    Me.Hide()
                End If
            ElseIf cpcheck.Visible = True Then
                ecustomapps.MdiParent = MDIMain
                ecustomapps.Show()
                Me.Hide()
            ElseIf logocheck.Visible = True Then
                ebootlogos.MdiParent = MDIMain
                ebootlogos.Show()
                Me.Hide()
            ElseIf buildcheck.Visible = True Then
                ebuilding.MdiParent = MDIMain
                ebuilding.Show()
            End If
            Me.Hide()
        End If
    End Sub
End Class