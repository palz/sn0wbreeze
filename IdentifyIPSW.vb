Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Management

Public Class IdentifyIPSW
    Public MD51 As Boolean = False
    Public ipswhash As String
    Private WithEvents get_MD5 As System.ComponentModel.BackgroundWorker
    Public Sub get_MD5_hash(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles get_MD5.DoWork

        'MD5 hash provider for computing the hash of the file
        Dim md5 As New MD5CryptoServiceProvider()

        'open the file
        Dim stream As New FileStream(ipsw, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        'calculate the files hash
        md5.ComputeHash(stream)

        'close our stream
        stream.Close()

        'byte array of files hash
        Dim hash As Byte() = md5.Hash

        'string builder to hold the results
        Dim sb As New StringBuilder()

        'loop through each byte in the byte array
        For Each b As Byte In hash
            'format each byte into the proper value and append
            'current value to return value
            sb.Append(String.Format("{0:X2}", b))
        Next

        'return the MD5 hash of the file
        ipswhash = sb.ToString.ToLower
    End Sub
    Private Sub get_md5_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles get_MD5.RunWorkerCompleted
        MDIMain.MenuStrip1.Enabled = True
        Back.Enabled = True
        If ipswhash = "cf6d93fffdc60dcca487a80004d250fa" Then
            IPSWVersion = "3.2.2"
            IPSWvers.Text = "3.2.2 IPSW Verified!"
            ihelper.Text = "iPad"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPad"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.ipad
            UseComexsAwesomeKernelExploit = True
            RootFSsize = 1024
            ' iDevWARN.Show()
            ' iDevWARN.BringToFront()
        ElseIf ipswhash = "8cc589baad3c80dd8324c37d7dc00750" Then
            IPSWVersion = "4.1"
            IPSWvers.Text = "4.1 IPSW Verified!"
            ihelper.Text = "iPhone 3G"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPhone 3G"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.iPhone3G
            UseComexsAwesomeKernelExploit = True
            This3GSisold = True
            ThisiPodisMB = True
            RootFSsize = 800
        ElseIf ipswhash = "9f8a1978f053ec96926e535bb57ac171" Then
            IPSWVersion = "4.1"
            IPSWvers.Text = "4.1 IPSW Verified!"
            ihelper.Text = "iPod Touch 2G"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPod Touch 2G"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.iPod2G
            UseComexsAwesomeKernelExploit = True
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 800
        ElseIf ipswhash = "f3877c6f309730ee31297a06c7a9e82c" Then
            IPSWVersion = "4.1"
            IPSWvers.Text = "4.1 IPSW Verified!"
            ihelper.Text = "iPod Touch 3G"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPod Touch 3G"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.ipt3
            UseComexsAwesomeKernelExploit = True
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 820
        ElseIf ipswhash = "2e634d16d0e01ef70070c9a289e488ca" Then
            IPSWVersion = "4.1"
            IPSWvers.Text = "4.1 (8B117) IPSW Verified!"
            ihelper.Text = "iPod Touch 4"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPod Touch 4"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.ipt4
            UseComexsAwesomeKernelExploit = True
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 820
        ElseIf ipswhash = "0564fcd3f53dd6262b9eb636b7fbe540" Then
            IPSWVersion = "4.1-2"
            IPSWvers.Text = "4.1 (8B118) IPSW Verified!"
            ihelper.Text = "iPod Touch 4"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPod Touch 4"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.ipt4
            UseComexsAwesomeKernelExploit = True
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 820
        ElseIf ipswhash = "e07bee3c03e7a18e5d75fcaa23db17b5" Then
            IPSWVersion = "4.1"
            IPSWvers.Text = "4.1 IPSW Verified!"
            ihelper.Text = "iPhone 3GS"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPhone 3GS"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.iPhone3GS
            UseComexsAwesomeKernelExploit = True
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 820
        ElseIf ipswhash = "ac3031a7b5c013d6a09952b691985878" Then
            IPSWVersion = "4.1"
            IPSWvers.Text = "4.1 IPSW Verified!"
            ihelper.Text = "iPhone 4"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPhone 4"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.i4
            UseComexsAwesomeKernelExploit = True
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 850
        ElseIf ipswhash = "35c8ab4b7e70ab0e47e2f5981e52ba55" Then
            IPSWVersion = "4.1"
            IPSWvers.Text = "4.1 IPSW Verified!"
            ihelper.Text = "Apple TV 2"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "Apple TV 2"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.atv2
            UseComexsAwesomeKernelExploit = True
            RootFSsize = 800
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
        Else
            Status.Show()
            Status.Image = My.Resources.X
            Statuslabelbad.Show()
            statuslabelgood.Hide()
            Label1.Visible = True
            PictureBox2.Visible = False
        End If

        Button1.Visible = True
        Label2.Visible = False
        PictureBox2.Visible = False

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Status.Hide()
            Statuslabelbad.Hide()
            iDevLoaded = False
            ipsw = ""
            ipsw = FileOpenDialog("*.ipsw", "Desktop")
            If ipsw <> "" Then

                'save form position for progress form
                '
                ProgressTop = MDIMain.Top
                ProgressLeft = MDIMain.Left

                Back.Enabled = False
                MDIMain.MenuStrip1.Enabled = False
                get_MD5 = New System.ComponentModel.BackgroundWorker
                get_MD5.WorkerReportsProgress = True
                get_MD5.WorkerSupportsCancellation = True
                get_MD5.RunWorkerAsync()
                Label2.Visible = True
                Label1.Visible = False
                Button1.Visible = False
                PictureBox2.Visible = True
                'ipswhash = getFilesMD5Hash(ipsw)
            End If
        Catch Ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub eForm4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIMain.MenuStrip1.Enabled = True
        PictureBox2.Visible = False
        Label2.Visible = False
        Button1.Visible = True
        Label1.Visible = True
        iPhoneModel = ""
        IPSWvers.Text = ""
        Status.Hide()
        Statuslabelbad.Hide()
        statuslabelgood.Hide()
        ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
    End Sub
    Public Function getFilesMD5Hash(ByVal file As String) As String

        'MD5 hash provider for computing the hash of the file
        Dim md5 As New MD5CryptoServiceProvider()

        'open the file
        Dim stream As New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        'calculate the files hash
        md5.ComputeHash(stream)

        'close our stream
        stream.Close()

        'byte array of files hash
        Dim hash As Byte() = md5.Hash

        'string builder to hold the results
        Dim sb As New StringBuilder()

        'loop through each byte in the byte array
        For Each b As Byte In hash
            'format each byte into the proper value and append
            'current value to return value
            sb.Append(String.Format("{0:X2}", b))
        Next

        'return the MD5 hash of the file
        Return sb.ToString.ToLower()
        iDevLoaded = True
    End Function


    Private Function FileOpenDialog(ByVal strExtension As String, ByVal strInitDir As String) As String

        Dim oFileDialog As New System.Windows.Forms.OpenFileDialog()
        Dim strfilter As String = BuildFilter(strExtension)

        FileOpenDialog = ""

        With oFileDialog
            .Filter = "iPhone/iPod Software File (*.ipsw) |*.ipsw;"
            .DefaultExt = strExtension
            .InitialDirectory = strInitDir
            .ShowDialog()
            If Windows.Forms.DialogResult.OK Then
                FileOpenDialog = .FileName
            ElseIf Windows.Forms.DialogResult.Cancel Then
            End If
        End With

    End Function

    Private Function BuildFilter(ByVal strExtension As String) As String

        BuildFilter = ""

        If strExtension.PadLeft(1) <> "." Then
            BuildFilter = "(*." & strExtension & ")|" & "*." & strExtension
        ElseIf strExtension.PadLeft(1) = "." Then
            BuildFilter = "(*" & strExtension & ")|" & "*" & strExtension
        End If

    End Function

    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub

    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flake
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.ShowDialog()
    End Sub

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Expert.MdiParent = MDIMain
        Expert.Show()
        Me.Close()
    End Sub
    Private Sub ihelper_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ihelper.TextChanged
        ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Expert.MdiParent = MDIMain
        Expert.Show()
        Me.Close()
    End Sub
    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Form1.MdiParent = MDIMain
        Form1.Show()
        Form1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Back_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Back.MouseDown
        Back.Image = My.Resources.CancelClicked
    End Sub

    Private Sub Back_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Back.MouseEnter
        Back.Image = My.Resources.CancelClicked
    End Sub

    Private Sub Back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Back.MouseLeave
        Back.Image = My.Resources.Cancel
    End Sub

    Private Sub Back_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Back.MouseUp
        Back.Image = My.Resources.Cancel
    End Sub

    Private Sub arrow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        PartitionSize = RootFSsize
        Form2.MdiParent = MDIMain
        Form2.Show()
        Me.Close()
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
End Class
