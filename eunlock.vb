Public Class eunlock
    Private Sub eunlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = iPhoneModel
        Label3.Left = (Me.Width / 2) - (Label3.Width / 2)
        If egeneral.chkNOR.Checked = True Then
            ebootlogos.MdiParent = MDIMain
            ebootlogos.Show()
            Me.Hide()
        Else
            Label15.Text = "Your device is an: " & iPhoneModel
        End If
    End Sub
    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub

    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flakeselect
    End Sub
    Private Sub Label15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.TextChanged
        Label15.Left = (Me.Width / 2) - (Label15.Width / 2)
    End Sub

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        ecustomapps.MdiParent = MDIMain
        ecustomapps.Show()
        Me.Hide()
    End Sub

    Private Sub arrow_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseEnter
        arrow.Image = My.Resources.Arrowhilite
    End Sub

    Private Sub arrow_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseDown
        arrow.Image = My.Resources.arrowpress
    End Sub

    Private Sub arrow_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseLeave
        arrow.Image = My.Resources.Arrow
    End Sub

    Private Sub arrow_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseUp
        arrow.Image = My.Resources.Arrowhilite
    End Sub
    Private Sub Label3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.TextChanged
        Label3.Left = (Me.Width / 2) - (Label3.Width / 2)
    End Sub
End Class