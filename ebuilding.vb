Imports System.Threading
'Imports Ionic.Zip

Public Class ebuilding
    Dim ProcessID As Integer


    Private Sub ChangeLabelText()
        lblStatus.Text = LabelText
        lblStatus.Left = (Width / 2) - (lblStatus.Width / 2)
    End Sub

    Private Sub ChangeProgressbar()
        ProgressValue = ProgressValue * 4 ' 4 = 100 / 26 steps
        If ProgressValue > 100 Then ProgressValue = 100
        ProgressBar.Value = ProgressValue
    End Sub

    Private Sub HideWheel()
        PictureAnim.Visible = False
        Cursor = Cursors.Default
    End Sub

    Private Sub BuildError()
        ipsw = ""
        iPhoneModel = ""
        UserMode = ""
        ipswBuilding = False
        ExitFlag = False
        ipswFailed = False
        Cursor = Cursors.Default
        Fail.MdiParent = MDIMain
        Fail.Show()
        Me.Close()
    End Sub

    Private Sub BuildComplete()
        ipsw = ""
        UserMode = ""
        'Not needed yez err $$ !!!
        ipswBuilding = False
        ExitFlag = False
        ipswFailed = False
        Cursor = Cursors.Default
        done.MdiParent = MDIMain
        done.Show()
        Me.Close()
    End Sub

    Private Sub CancelBuild()
        lblStatus.Text = "Canceling"
        lblStatus.Left = (Width / 2) - (lblStatus.Width / 2)

        Call ipswCleanup()
        ipswBuilding = False
        ExitFlag = False
        ipswFailed = False
        ipsw = ""
        iPhoneModel = ""
        UserMode = ""

        lblStatus.Text = "Cancelled"
        lblStatus.Left = (Width / 2) - (lblStatus.Width / 2)

        Cursor = Cursors.Default

        Form2.MdiParent = MDIMain
        Form2.Show()
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub MakeItSn0w(ByVal State As Object)
        Try
            If UserMode = "Simple Mode" Then
                If iPhoneModel.Substring(0, 6) = "iPhone" Then
                    Dim Answer
                    Answer = MsgBox("Do you want to activate your iPhone?", MsgBoxStyle.YesNo, "You wantz Hacktivation?")
                    If Answer = vbYes Then ActivatePhone = True
                End If
            End If
            'get keys etc. for iPhone model
            Call GetIPSWVars()

            ipswBuilding = True

            LabelText = "Checking for any old files"
            lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

            Call ipswCleanup()

            'cancel pressed?
            If ExitFlag = True Then
                Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                Exit Sub
            End If

            'iRyourRepos.SaveFile(tempPath & "\CustomRepos.txt", _
            'RichTextBoxStreamType.PlainText)


            LabelText = "Extracting resources..."
            lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

            Call ExtractResourcesAdvanced()

            'extract bundle
            If File_Exists(tempPath & "\" & Bundle & ".zip") = False Then SaveToDisk(Bundle & ".zip", tempPath & "\" & Bundle & ".zip")
            'Using zip1 As ZipFile = ZipFile.Read(tempPath & "\" & Bundle & ".zip")
            'zip1.ExtractAll(tempPath & "\", True)
            'zip1.Dispose()
            'End Using
            UnZip(tempPath & "\" & Bundle & ".zip", tempPath & "\", 4096)

            If File_Exists(tempPath & "\" & Bundle & ".zip") = True Then File_Delete(tempPath & "\" & Bundle & ".zip")

            Sleep(1000)

            'IPSW extraction
            LabelText = "Extracting IPSW..."
            lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

            Call ExtractIPSW()

            LabelText = "Done Extracting IPSW..."
            lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

            'cancel pressed?
            If ExitFlag = True Then
                Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                Exit Sub
            End If

            'update progress bar
            ProgressValue = 1
            ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

            Sleep(1000)

            '***********NOR****************************

            If NOR = True Then

                'Kernel Patching
                LabelText = "Patching Kernel..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchKernel()

                LabelText = "Done Patching Kernel..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 2
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Ramdisk Decryption
                LabelText = "Decrypting Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call DecryptRamdisk()

                LabelText = "Done Decrypting Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 5
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Ramdisk Patching
                LabelText = "Patching NOR..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchNOR()

                LabelText = "Done Patching NOR..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 10
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Rebuilding  ramdisk
                LabelText = "Rebuilding Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call RebuildRamdisk()

                LabelText = "Done Rebuilding Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 15
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Custom boot/recovery logos
                LabelText = "Uploading Custom Images..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call AddCustomImages()

                LabelText = "Done Uploading Custom Images..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 16
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))


                'Adding custom logos
                LabelText = "Adding Custom Boot Logos..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call AddBootLogo()

                LabelText = "Done Adding Custom Boot Logos..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 17
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))


                'iBSS Decryption
                LabelText = "Patching iBSS..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchiBSS()

                LabelText = "Done Patching iBSS..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 18
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'iBEC Patching
                LabelText = "Patching iBEC..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchiBEC()

                LabelText = "Done Patching iBEC..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 19
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'WTF Patching
                If PatchWTF = True Then
                    LabelText = "Patching WTF..."
                    lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                    Call PatchWTF2()

                    LabelText = "Done Patching WTF..."
                    lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                    'cancel pressed?
                    If ExitFlag = True Then
                        Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                        Exit Sub
                    End If

                    'update progress bar
                    ProgressValue = 20
                    ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                End If

                'LLB Patching
                LabelText = "Patching LLB..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchLLB()

                LabelText = "Done Patching LLB..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 22
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'iBoot Patching
                LabelText = "Patching iBoot..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchiBoot()

                LabelText = "Done Patching iBoot..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'Deletion of unrequired files
                LabelText = "Deleting Unrequired Files..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call DeleteUnrequiredFilesNOR()

                LabelText = "Done Deleting Unrequired Files..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    If ipswFailed = True Then
                        Invoke(CType(AddressOf BuildError, MethodInvoker))
                    Else
                        Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    End If
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 23
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Zipping IPSW
                LabelText = "Creating IPSW..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call CreateIPSW()

                LabelText = "Done Creating IPSW..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'update progress bar
                ProgressValue = 25
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))


                'Cleaning Up
                LabelText = "Cleaning Up..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call ipswCleanup()

                LabelText = "Done Cleaning Up..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'update progress bar
                ProgressValue = 30
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))



            Else

                'Kernel Patching
                LabelText = "Patching Kernel..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchKernel()

                LabelText = "Done Patching Kernel..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 2
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Sleep(2000)

                'RootFS Decryption
                LabelText = "Decrypting RootFS..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call DecryptRoofFS()

                LabelText = "Done Decrypting..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 3
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Sleep(2000)

                'Adding Cydia
                LabelText = "Preparing to add Cydia..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))


                'Call Stash_Da_Shit()

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'Sleep(2000)

                'Adding Cydia
                LabelText = "Adding Cydia..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

               
                Call AddCydia()


                LabelText = "Done Adding Cydia..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 4
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))


                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 6
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                LabelText = "Adding Debs..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Invoke(CType(AddressOf AddDebs, MethodInvoker))

                LabelText = "Done Adding Debs..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 8
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'FSTAB Patching
                LabelText = "Patching FSTAB..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchFSTAB()

                LabelText = "Done Patching FSTAB..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 9
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Patching Services
                LabelText = "Patching Services..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchServices()

                LabelText = "Done Patching Services..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 10
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Add Custom Options from General
                LabelText = "Adding Custom Options..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call CustomOptions40()

                LabelText = "Done Adding Custom Options..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 10
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))


                'Custom boot/recovery logos
                LabelText = "Preinstalling Custom Repos..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call AddCustomRepos()

                LabelText = "Done Preinstalling Custom Repos..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 12
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Uploading PWNED Kernel
                LabelText = "Uploading PWNED Kernel..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'Call Uploadkernel()

                LabelText = "Done Uploading PWNED Kernel..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 12
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                Try
                    'Hactivating
                    If ActivatePhone = True And iPhoneModel.Substring(0, 6) = "iPhone" Then
                        LabelText = "Hacktivating iPhone..."
                        lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                        Call HacktivatePhone()

                        LabelText = "Done Hacktivating..."
                        lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                        'cancel pressed?
                        If ExitFlag = True Then
                            Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                            Exit Sub
                        End If

                        'update progress bar
                        ProgressValue = 13
                        ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))
                    End If
                Catch Ex As Exception
                End Try

                'Apply Seatbelt Fix
                LabelText = "Adding Seatbelt Fix..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call SeatbeltFix()

                LabelText = "Done Seatbelt Fix..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
                'update progress bar
                ProgressValue = 14
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                LabelText = "Adding comex's sexy kernel exploit ;D..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call AddUltimateness()

                LabelText = "Done Adding comex's sexy kernel exploit ;D..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
                'update progress bar
                ProgressValue = 16
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                If InstallSSH = True Then

                    'Apply Seatbelt Fix
                    LabelText = "Installing SSH..."
                    lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                    Call InstallingSSH()

                    LabelText = "Done Installing SSH..."
                    lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
                    'update progress bar
                    ProgressValue = 17
                    ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                    'cancel pressed?
                    If ExitFlag = True Then
                        Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                        Exit Sub
                    End If

                End If

                'Rebuilding RootFS 
                LabelText = "Rebuilding RootFS..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call RebuildRootFS()

                LabelText = "Done Rebuilding RootFS..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 18
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Ramdisk Decryption
                LabelText = "Decrypting Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call DecryptRamdisk()

                LabelText = "Done Decrypting Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 18
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Ramdisk Patching
                LabelText = "Patching Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchRamdisk()

                LabelText = "Done Patching Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 18
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Rebuilding  ramdisk
                LabelText = "Rebuilding Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call RebuildRamdisk()

                LabelText = "Done Rebuilding Ramdisk..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 18
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'iBSS Decryption
                LabelText = "Patching iBSS..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchiBSS()

                LabelText = "Done Patching iBSS..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 18
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'iBEC Patching
                LabelText = "Patching iBEC..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchiBEC()

                LabelText = "Done Patching iBEC..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 19
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'WTF Patching
                If PatchWTF = True Then
                    LabelText = "Patching WTF..."
                    lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                    Call PatchWTF2()

                    LabelText = "Done Patching WTF..."
                    lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                    'cancel pressed?
                    If ExitFlag = True Then
                        Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                        Exit Sub
                    End If

                    'update progress bar
                    ProgressValue = 20
                    ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                End If

                'Custom boot/recovery logos
                LabelText = "Uploading Custom Images..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

      
                Call AddCustomImages()



                LabelText = "Done Uploading Custom Images..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 16
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))


                'Adding custom logos
                LabelText = "Adding Custom Boot Logos..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))


                Call AddBootLogo()
     
                LabelText = "Done Adding Custom Boot Logos..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 21
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'LLB Patching
                LabelText = "Patching LLB..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchLLB()

                LabelText = "Done Patching LLB..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 22
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'iBoot Patching
                LabelText = "Patching iBoot..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call PatchiBoot()

                LabelText = "Done Patching iBoot..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    Exit Sub
                End If


                'update progress bar
                ProgressValue = 23
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Deletion of unrequired files
                LabelText = "Deleting Unrequired Files..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call DeleteUnrequiredFiles()

                LabelText = "Done Deleting Unrequired Files..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'cancel pressed?
                If ExitFlag = True Then
                    If ipswFailed = True Then
                        Invoke(CType(AddressOf BuildError, MethodInvoker))
                    Else
                        Invoke(CType(AddressOf CancelBuild, MethodInvoker))
                    End If
                    Exit Sub
                End If

                'update progress bar
                ProgressValue = 24
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                'Zipping IPSW
                LabelText = "Creating IPSW..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call CreateIPSW()

                LabelText = "Done Creating IPSW..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'update progress bar
                ProgressValue = 25
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))


                'Cleaning Up
                LabelText = "Cleaning Up..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                Call ipswCleanup()

                LabelText = "Done Cleaning Up..."
                lblStatus.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))

                'update progress bar
                ProgressValue = 26
                ProgressBar.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

            End If
            Sleep(2000)

            ':D DONE!
            Invoke(CType(AddressOf BuildComplete, MethodInvoker))
        Catch ex As Exception
            ErrorMessage = Err.Description
            Invoke(CType(AddressOf BuildError, MethodInvoker))
        End Try
    End Sub

    Private Sub sbuilding_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        PictureAnim.Refresh()
    End Sub



    Private Sub sbuilding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ihelper.Text = iPhoneModel
        Me.ihelper.Left = (Me.Width / 2) - (Me.ihelper.Width / 2)

        Cursor = Cursors.WaitCursor
        PictureAnim.Refresh()
        PictureAnim.Visible = True

        'My.Application.Info.DirectoryPath

        ihelpertext = ihelper.Text
        'run in separate thread

        ThreadPool.QueueUserWorkItem(AddressOf MakeItSn0w)
    End Sub


    Private Sub ihelper_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ihelper.TextChanged
        Me.ihelper.Left = (Me.Width / 2) - (Me.ihelper.Width / 2)
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If ipswBuilding = False Then
            iPhoneModel = ""
            Expert.Label2.Text = " "
            CancelBuild()
            Exit Sub
        End If

        Dim Answer
        Answer = MsgBox("Cancel building of IPSW?", MsgBoxStyle.Question + vbYesNo, "sn0wbreeze")

        If Answer = vbYes Then
            iPhoneModel = ""
            lblStatus.Text = "Cancelling. Waiting for current process to complete..."
            lblStatus.Left = (Width / 2) - (lblStatus.Width / 2)
            btnCancel.Enabled = False
            ExitFlag = True
        End If
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        If ipswBuilding Then Cursor = Cursors.WaitCursor
    End Sub

    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.Image = My.Resources.Flakeselect
    End Sub

    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.Image = My.Resources.Flake
    End Sub



    Private Sub PictureAnim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureAnim.Click

    End Sub

    Private Sub logo2_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect

    End Sub

    Private Sub logo2_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flake

    End Sub

    Private Sub ProgressBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar.Click

    End Sub

    Private Sub ebuilding_MaximumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximumSizeChanged

    End Sub
End Class