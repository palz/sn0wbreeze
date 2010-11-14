Public Class About

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Credits.MdiParent = MDIMain
        Credits.Show()
        Me.Close()
        Form1.Enabled = True
        Me.Dispose()
    End Sub


    Private Sub Process1_Exited(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process1.Exited

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Check4Updates.Show()
        Check4Updates.MdiParent = MDIMain
        Me.Dispose()
    End Sub

  
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class