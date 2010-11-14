'w3st05
Imports Ionic.Zip
Imports ICSharpCode.SharpZipLib.Zip
Imports ICSharpCode.SharpZipLib.Zip.Compression
Imports System.IO

Module modIPSW
    'custom vars
    Public FINALRESIZE As String = ""
    Public IPSWVersion As String = ""
    Public iPhoneModel As String = ""
    Public iPod2GModel As String = ""
    Public iDevice As String = ""
    Public PreviousModel As String = ""
    Public PreviousVersion As String = ""
    Public UserMode As String = ""
    Public ipsw As String = ""
    Public iBootyPath As String = ""
    Public NOR As Boolean = False
    Public PartitionSize As Integer = 800
    Public ActivatePhone As Boolean = False
    Public EnableMultiTasking As Boolean = False
    Public EnablePercentage As Boolean = False
    Public EnableWallpaper As Boolean = False
    Public EnableHDR As Boolean = False
    Public InstallSSH As Boolean = False
    Public UseUniPod As Boolean = False
    Public NORFlashDisabled As Boolean = False
    Public iBootyMethod As Boolean = False
    Public CydiaSelected As Boolean = True
    Public RockSelected As Boolean = False
    Public BootNeuter As Boolean = False
    Public BootneuterSelected As Boolean = False
    Public UseCustomBootLogo As Boolean = True
    Public BootLogo As String = "BootLogo.png"
    Public VerboseMode As Boolean = False
    Public UseCustomRecoveryLogo As Boolean = True
    Public RecoveryLogo As String = "RecoveryLogo.png"
    Public UseCustomLockBackground As Boolean = True
    Public CustomApps As String = ""
    Public DoIpatchKernel As Boolean = False
    Public DoIGiveAshit As Boolean = False
    Public This3GSisold As Boolean = False
    Public DoIDeleteBuildManifest As Boolean = False
    Public UseComexsAwesomeKernelExploit As Boolean = False
    Public ThisiPodisMB As Boolean = False

    'build vars
    Public Bundle As String = ""
    Public Kernel As String = ""
    Public KernelPatched As String = ""
    Public ModelVar As String = ""
    Public RootFS As String = ""
    Public RootFSKey As String = ""
    Public Ramdisk As String = ""
    Public Board As String = ""
    Public RamdiskIV As String = ""
    Public RamdiskKey As String = ""
    Public iBootkIV As String = ""
    Public iBootKey As String = ""
    Public iBECIV As String = ""
    Public iBECKey As String = ""
    Public iBSSIV As String = ""
    Public iBSSKey As String = ""
    Public LLBIV As String = ""
    Public LLBKey As String = ""
    Public applelogoIV As String = ""
    Public applelogoKey As String = ""
    Public DeviceTreeIV As String = ""
    Public DeviceTreeKey As String = ""
    Public RecoveryModeIV As String = ""
    Public RecoveryModeKey As String = ""
    Public KernelCacheIV As String = ""
    Public KernelCacheKey As String = ""
    Public RootFSsize As Integer = 1
    Public WTFIV As String = ""
    Public WTFKey As String = ""
    Public WTF2IV As String = ""
    Public WTF2Key As String = ""
    Public PatchWTF As Boolean = False
    Public Unwanted As String = ""
    Public WeNeedDeviceTree As Boolean = False
    Public Sub GetIPSWVars()
        
        If iPhoneModel = "iPad" And IPSWVersion = "3.2.2" Then
            Bundle = "iPad1,1_3.2.2_7B500.bundle"
            Kernel = "s5l8930x"
            ModelVar = "k48ap"
            Board = "k48"
            RootFS = "018-8370-001"
            RootFSKey = "18ae1e76e7bcf6478321f42888606ca2d998cffab1ee8c7ca6b15d57b1a7254f8a608823"
            Ramdisk = "018-8375-001"
            RamdiskIV = "309d4fc146b47f43e8bc27133d7ce6bc"
            RamdiskKey = "f45eaec8b6c17af7c6071635a313572b1b0208bc445cfb6c1d60b6bf377e6653"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "3a0ad7cf0f172bc3736af2099a4a89b4"
            iBSSKey = "0dcdc5bdc0d991020222c0e7b7d11305466f0ef831964c5fc9325f05e32b1a09"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "018-8374-001"
            RootFSsize = 1024
            UseComexsAwesomeKernelExploit = True
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "iPhone 3G" And IPSWVersion = "4.1" Then
            Bundle = "iPhone1,2_4.1_8B117.bundle"
            Kernel = "s5l8900x"
            ModelVar = "n82ap"
            Board = "n82"
            RootFS = "018-7060-114"
            RootFSKey = "4C3C83D3899EA9BEF415B1C9C656AAEF966B2362494D2C9093A9283D388257562A228C86"
            Ramdisk = "018-7079-079"
            RamdiskIV = "a0fc6ca4ef7ef305d975e7f881ddcc7f"
            RamdiskKey = "18eab1ba646ae018b013bc959001fbde"
            iBootkIV = "4c8dd5528dcf283bec1ecd8d741aa540"
            iBootKey = "9b5a1fc8c62912cc1404a6bd5cc45685"
            iBECIV = ""
            iBECKey = ""
            iBSSIV = ""
            iBSSKey = ""
            LLBIV = ""
            LLBKey = ""
            KernelCacheIV = "7238dcea75bf213eff209825a03add51"
            KernelCacheKey = "0295d4ef87b9db687b44f54c8585d2b6"
            applelogoIV = "9cdcfbdf36175c103d4f3d4993bc8423"
            applelogoKey = "91f2b4c9a8a69f502a294200472059f3"
            RecoveryModeIV = "8926b78e0a2b9e4ec9dd34b0f99148fb"
            RecoveryModeKey = "536e5c0303edd8f11ca90535c0770963"
            Unwanted = "018-7072-079"
            PatchWTF = True
            RootFSsize = "800"
            DoIDeleteBuildManifest = True
            UseComexsAwesomeKernelExploit = True
        ElseIf iPhoneModel = "iPod Touch 2G" And IPSWVersion = "4.1" Then
            Bundle = "iPod2,1_4.1_8B117.bundle"
            Kernel = "s5l8720x"
            ModelVar = "n72ap"
            Board = "n72"
            RootFS = "018-7058-113"
            RootFSKey = "aec4d2f3c6a4e70ea6cea074f65812d2a34b180cc92b817edcd867167e7a91c5beb942f0"
            Ramdisk = "018-7103-078"
            RamdiskIV = "58df0d0655bbdda2a0f1c09333940701"
            RamdiskKey = "fbf443110eb11d8d1aacdbe39167de09"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "f7ed98e14e9f7f01397639a4424ef175"
            iBSSKey = "abcc0848b65d7e2e675f8030ea37f325"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = "57d4e27152d39af674492eb0a8252de3"
            KernelCacheKey = "7c07730b6ceb8b217653ff5161988b24"
            Unwanted = "018-7104-078"
            RootFSsize = 800
            DoIDeleteBuildManifest = False
            UseComexsAwesomeKernelExploit = True
        ElseIf iPhoneModel = "iPod Touch 3G" And IPSWVersion = "4.1" Then
            Bundle = "iPod3,1_4.1_8B117.bundle"
            Kernel = "s5l8922x"
            ModelVar = "n18ap"
            Board = "n18"
            RootFS = "018-7116-114"
            RootFSKey = "69e2ca7a250765c95a703081d1195e681fbe82f31162b79fd2b70754629b0352694b9eda"
            Ramdisk = "018-7081-078"
            RamdiskIV = "1edc4378f31ce728a2412ff93c78b8dd"
            RamdiskKey = "425f8a7bdac80a9678c78317a0ddbb91abb52a2fd1ff45f46c3e6db392155db9"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "45e620eb1cabe17cb5e25018e628160e"
            iBSSKey = "1b45e1726a88d3e89a203a59544b853c531758dd3c6f15fd9fa24cfa4ebc949d"
            LLBIV = ""
            LLBKey = ""
            DeviceTreeIV = ""
            DeviceTreeKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "018-7108-078"
            RootFSsize = 800
            DoIDeleteBuildManifest = False
            UseComexsAwesomeKernelExploit = True
        ElseIf iPhoneModel = "iPod Touch 4" And IPSWVersion = "4.1" Then
            Bundle = "iPod4,1_4.1_8B117.bundle"
            Kernel = "s5l8930x"
            ModelVar = "n81ap"
            Board = "n81"
            RootFS = "018-7062-093"
            RootFSKey = "e7de54b25167afc66e381ade1d5e25c6392757497cfd92826a3111772731ba0b70742b90"
            Ramdisk = "018-7082-092"
            RamdiskIV = "103ae8786d55bebdea996a56706641c9"
            RamdiskKey = "a80b3c27041f09d4554bbf4af59dd5bcea38bd4fe2faf82d8d6f62853ec6b337"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "c58929f652c1c086f70f941f3bb31058"
            iBSSKey = "358e67475d675410517ccbfcbbc38fa4c56d0e892b627460851a1fa5e9b430ab"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "018-7074-092"
            RootFSsize = 800
            UseComexsAwesomeKernelExploit = True
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "iPod Touch 4" And IPSWVersion = "4.1-2" Then
            Bundle = "iPod4,1_4.1_8B118.bundle"
            Kernel = "s5l8930x"
            ModelVar = "n81ap"
            Board = "n81"
            RootFS = "018-9391-001"
            RootFSKey = "770b58765a3345004528fd9a2cbb7c3105137d0bd3a134a24679e6e173f32636d0485d06"
            Ramdisk = "018-9394-001"
            RamdiskIV = "e869e35fae9877bcba930e66e1536fc6"
            RamdiskKey = "205d0b4636400b08cd0b86a4afdec9d7fc79267f3146a00ce9bb4f3d987a1547"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "c58929f652c1c086f70f941f3bb31058"
            iBSSKey = "358e67475d675410517ccbfcbbc38fa4c56d0e892b627460851a1fa5e9b430ab"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "018-9392-001"
            RootFSsize = 800
            UseComexsAwesomeKernelExploit = True
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "iPhone 3GS" And IPSWVersion = "4.1" Then
            Bundle = "iPhone2,1_4.1_8B117.bundle"
            Kernel = "s5l8920x"
            ModelVar = "n88ap"
            Board = "n88"
            RootFS = "018-7061-122"
            RootFSKey = "01155a88dc41d6bdb6ba368719853e7e68fb0076dbfaafe8e0801256c724b103f2e271ca"
            Ramdisk = "018-7080-079"
            RamdiskIV = "214388b7e0589464bf59966524ae2ea4"
            RamdiskKey = "581f739963fc3fdbf70dfc695b35d43662a0069b501cb715264c32428e759cba"
            iBootkIV = "7106d9c8e81c4d6bed474f5f3caef4bb"
            iBootKey = "45c562f5250aa5537e77772b87704a9162a55e78d73ccf18324b6e1386a693f1"
            iBECIV = "434539b5e293220a6b43862689fcefb4"
            iBECKey = "aec9e91b1cb738115371804fa13ee2710fa83c4d1b9203d36586dbe88579a630"
            iBSSIV = "966fdb6312a3cd35703e7a1e8bb4cce6"
            iBSSKey = "81d26076947f2a50c0d31766f7e5f3b73ec198a1e0c50064a03b9e74bd0cbf91"
            LLBIV = "3db3ccef9c2bbb1bc6f86568d28b5c73"
            LLBKey = "f56b34c613699b1fea7fae9ad9978e8b90be1f1045a8e908269d75db0527dea0"
            applelogoIV = "4223d5a6bc4d358031df8958c427a369"
            applelogoKey = "fdd2a888a079b6421e19bc7e03d5242ffe7822029bab5c030377e9eb5a98ccb3"
            RecoveryModeIV = "e8c3811707b35b14431f1e8a72923a77"
            RecoveryModeKey = "b29af745abac499138e73642a5259cd71dde3640ed981ae9728dfefe59e876bf"
            KernelCacheIV = "401e9002de3d0d0f76cb7c0927700714"
            KernelCacheKey = "0400cdef4c3a31feee7ff283ccc0c5b66432cd92430a07a1835143e53ed1e088"
            Unwanted = "018-7073-079"
            RootFSsize = "800"
            DoIDeleteBuildManifest = False
            UseComexsAwesomeKernelExploit = True
        ElseIf iPhoneModel = "iPhone 4" And IPSWVersion = "4.1" Then
            Bundle = "iPhone3,1_4.1_8B117.bundle"
            Kernel = "s5l8930x"
            ModelVar = "n90ap"
            Board = "n90"
            RootFS = "018-7063-114"
            RootFSKey = "2ab6aea67470994ec3453791ac75f6497c081edd1991e560a61dd666ac4b73f43c781739"
            Ramdisk = "018-7082-092"
            RamdiskIV = "103ae8786d55bebdea996a56706641c9"
            RamdiskKey = "a80b3c27041f09d4554bbf4af59dd5bcea38bd4fe2faf82d8d6f62853ec6b337"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "c2c5416472e5a0d6f0a25a123d5a2b1c"
            iBSSKey = "1fbc7dcafaec21a150a51eb0eb99367550e24a077b128831b28c065e61f894a0"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "018-7074-092"
            RootFSsize = 860
            UseComexsAwesomeKernelExploit = True
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "Apple TV 2" And IPSWVersion = "4.1" Then
            Bundle = "AppleTV2,1_4.1_8M89.bundle"
            Kernel = "s5l8930x"
            ModelVar = "k66ap"
            Board = "k66"
            RootFS = "018-8609-066"
            RootFSKey = "31c700a852f1877c88efc05bc5c63e8c7f081c4cb28d024ed7f9b0dbc98c7e1406e499c6"
            Ramdisk = "018-8618-062"
            RamdiskIV = "5fe67aa4b1ad60114ed6c661f3e3fd64"
            RamdiskKey = "5fa15fe83e35b0a6ec1e4fccd70bced808037f42966425f7f6b499feae3772b8"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "921a1405543996714f80d2fb1f8d0242"
            iBSSKey = "e31d511699eb9564c7174932e595e75f08aaa11d392d9026f28fe60ede336fc2"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "018-8613-062"
            RootFSsize = 800
            UseComexsAwesomeKernelExploit = True
            DoIDeleteBuildManifest = False
        Else
            RootFSsize = ""
            Bundle = ""
            Kernel = ""
            KernelPatched = ""
            ModelVar = ""
            RootFS = ""
            RootFSKey = ""
            Ramdisk = ""
            RamdiskIV = ""
            RamdiskKey = ""
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = ""
            iBSSKey = ""
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = ""
        End If
    End Sub
    Public Sub ExtractIPSW()
        Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(ipsw)
            zip1.ExtractAll(tempPath & "\IPSW\")
            zip1.Dispose()
        End Using
    End Sub
    Public Sub PatchKernel()
        If UseComexsAwesomeKernelExploit = True Then
            If iPhoneModel = "iPod Touch 2G" Then
                cmdline = DFU.quote.Text & tempPath & "\xpwntool.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\kernelcache.release." & Board & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\kernelcache.release." & Board & ".decrypted" & DFU.quote.Text & " -iv " & KernelCacheIV & " -k " & KernelCacheKey
                ExecCmd(cmdline, True)
                cmdline = DFU.quote.Text & tempPath & "\bspatch.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\kernelcache.release." & Board & ".decrypted" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\kernelcache.release." & Board & ".pwned1" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\kernelcache.release.patch"""
                ExecCmd(cmdline, True)
                cmdline = DFU.quote.Text & tempPath & "\xpwntool.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\kernelcache.release." & Board & ".pwned1" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\kernelcache.release.pwned" & DFU.quote.Text & " -t " & DFU.quote.Text & tempPath & "\IPSW\kernelcache.release." & Board & DFU.quote.Text & " -iv " & KernelCacheIV & " -k " & KernelCacheKey
                ExecCmd(cmdline, True)

                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\kernelcache.release." & Board & ".decrypted"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\kernelcache.release." & Board & ".pwned1"" /f /q"""
                ExecCmd(cmdline, True)

                'Patch this shit!!! =)
                '
                'I got no idea why the dev-team did it the hard way... =/

                cmdline = "cmd /c RENAME " & DFU.quote.Text & tempPath & "\IPSW\Restore.plist" & DFU.quote.Text & " " & DFU.quote.Text & "Restore.plist.orig" & DFU.quote.Text
                ExecCmd(cmdline, True)
                cmdline = "cmd /c RENAME " & DFU.quote.Text & tempPath & "\IPSW\BuildManifest.plist" & DFU.quote.Text & " " & DFU.quote.Text & "BuildManifest.plist.orig" & DFU.quote.Text
                ExecCmd(cmdline, True)

                cmdline = DFU.quote.Text & tempPath & "\bspatch.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Restore.plist.orig" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Restore.plist" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\Restore.patch"""
                ExecCmd(cmdline, True)
                cmdline = DFU.quote.Text & tempPath & "\bspatch.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\BuildManifest.plist.orig" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\BuildManifest.plist" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\BuildManifest.patch"""
                ExecCmd(cmdline, True)

                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Restore.plist.orig"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\BuildManifest.plist.orig"" /f /q"""
                ExecCmd(cmdline, True)
            End If
            Exit Sub
        End If

    End Sub
    Public Sub DecryptRoofFS()
        cmdline = "cmd /c ""rename """ & tempPath & "\ipsw\" & RootFS & ".dmg"" """ & RootFS & ".dmg.orig"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\dmg.exe"" extract """ & tempPath & "\IPSW\" & RootFS & ".dmg.orig"" """ & tempPath & "\IPSW\DECRYPTED.dmg""" & " -k " & RootFSKey
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\ipsw\" & RootFS & ".dmg.orig"""
        ExecCmd(cmdline, True)
    End Sub
    Public Function ConvertMegabytesToBytes(ByVal megabytes As Double) As Double
        If iPhoneModel = "iPod Touch 2G" Then
            FINALRESIZE = 800000000
        Else
            FINALRESIZE = megabytes * 1048576
        End If
    End Function
    Public Sub AddCydia()
        ConvertMegabytesToBytes(PartitionSize)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" grow " & FINALRESIZE
        ExecCmd(cmdline, True)
        If File_Exists(tempPath & "\Cydia.tar") = False Then
            SaveToDisk("Cydia.zip", tempPath & "\Cydia.zip")
            Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(tempPath & "\Cydia.zip")
                zip1.ExtractAll(tempPath & "\", True)
                zip1.Dispose()
            End Using
        End If

        File_Delete(tempPath & "\Cydia.zip")

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" untar """ & tempPath & "\Cydia.tar"""
        ExecCmd(cmdline, True)

        File_Delete(tempPath & "\Cydia.tar")
    End Sub
    Public Sub AddDebs()
        Dim DoNotInstallDebs = "bash" 'separate by , - name,name2,name3 etc.
        Dim installDeb As Boolean = True
        Dim DoNotInstallDebsArray
        DoNotInstallDebsArray = Split(DoNotInstallDebs, ",")

        If UserMode = "Simple" Then
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" addall """ & tempPath & "\debs"""
            ExecCmd(cmdline, True)
        ElseIf UserMode = "Expert" Then

            'main deb
            For Each item In ecustomapps.lvSelectPackages.Items
                If item.Checked = True Then

                    'check to see if it should be installed
                    For Each deb In DoNotInstallDebsArray
                        If item.SubItems(4).text.indexof(deb) <> -1 Then
                            'we have a match
                            installDeb = False
                        End If
                    Next

                    If installDeb = True Then File_Copy(tempPath & "\debsCustom\" & item.SubItems(4).Text, tempPath & "\debs\private\var\root\Media\Cydia\AutoInstall\" & item.SubItems(4).Text, True)
                    installDeb = True


                    'dependants
                    If item.SubItems(5).Text <> "" Then
                        Dim dependants
                        dependants = Split(item.SubItems(5).Text, ",")
                        For Each item2 In dependants

                            'check to see if it should be installed
                            For Each deb In DoNotInstallDebsArray
                                If item2.indexof(deb) <> -1 Then
                                    'we have a match
                                    installDeb = False
                                End If
                            Next

                            If installDeb = True Then File_Copy(tempPath & "\debsCustom\" & item2, tempPath & "\debs\private\var\root\Media\Cydia\AutoInstall\" & item2, True)
                            installDeb = True
                        Next
                    End If
                End If
            Next

            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" addall """ & tempPath & "\debs"""
            ExecCmd(cmdline, True)
        End If
    End Sub
    Public Sub PatchFSTAB()
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv etc/fstab etc/fstab_orig"
        ExecCmd(cmdline, True)
        SaveToDisk("fstab.pwned", tempPath & "\fstab.pwned")
        Sleep(1000)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\fstab.pwned"" etc/fstab"
        ExecCmd(cmdline, True)
    End Sub
    Public Sub PatchServices()
        If iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract System/Library/Lockdown/Services.plist """ & tempPath & "\Services.plist.orig"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv System/Library/Lockdown/Services.plist System/Library/Lockdown/Services.plist.orig"
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\Services.plist.orig"" """ & tempPath & "\Services.plist"" """ & tempPath & "\Services.patch"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\Services.plist"" System/Library/Lockdown/Services.plist"""
            ExecCmd(cmdline, True)
        Else
            Exit Sub
        End If
    End Sub
    Public Sub DecryptRamdisk()
        cmdline = "cmd /c ""rename """ & tempPath & "\IPSW\" & Ramdisk & ".dmg"" """ & Ramdisk & ".dmg.orig"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\" & Ramdisk & ".dmg.orig"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" -iv " & RamdiskIV & " -k " & RamdiskKey & """"
        ExecCmd(cmdline, True)
    End Sub
    Public Sub PatchNOR()
        If iPhoneModel = "iPod Touch 3G" Then
            'HOW DID YOU EVEN GET HERE?
            'Do Nothing
            Exit Sub
        Else
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" rm /usr/local/share/restore/PASS.png"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" extract /usr/sbin/asr """ & tempPath & "\asr.orig"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\asr.orig"" """ & tempPath & "\asr"" """ & tempPath & "\asr.patch"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\asr"" /usr/sbin/asr"""
            ExecCmd(cmdline, True)
            If PartitionSize <> RootFSsize Then
                ReplateText(tempPath & "\optionsNOR.plist", tempPath & "\optionsNORCustom.plist", "<integer>800</integer>", "<integer>" & PartitionSize & "</integer>")
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\optionsNORCustom.plist"" /usr/local/share/restore/options.plist"""
                ExecCmd(cmdline, True)
            Else
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\optionsNOR.plist"" /usr/local/share/restore/options.plist"""
                ExecCmd(cmdline, True)
            End If
            cmdline = "cmd /c ""DEL """ & tempPath & "\optionsNORCustom.plist"" /f /q"""
            ExecCmd(cmdline, True)
        End If
    End Sub
    Public Sub PatchRestoredExternal()
        'Patching Restored_External -- START

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" extract /usr/local/bin/restored_external """ & tempPath & "\restored_external.orig"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" rm /usr/local/bin/restored_external"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\restored_external.orig"" """ & tempPath & "\restored_external.pwned"" """ & tempPath & "\restoredexternal.patch"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\restored_external.pwned"" /usr/local/bin/restored_external"""
        ExecCmd(cmdline, True)

        'Stupid Permissions...
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" chmod 100755 /usr/local/bin/restored_external"""
        ExecCmd(cmdline, True)


        cmdline = "cmd /c ""DEL """ & tempPath & "\restored_external.orig"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\restored_external.pwned"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\restoredexternal.patch"" /f /q"""
        ExecCmd(cmdline, True)
        'Patching Restored_External -- STOP

    End Sub
    Public Sub Stash_Da_Shit()
        Exit Sub
        'This is experimental atm.
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mkdir private/var/stash"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv Applications private/var/stash/Applications"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink Applications private/var/stash/Applications"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv Library/Ringtones private/var/stash/Ringtones"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink Library/Ringtones private/var/stash/Ringtones"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv Library/Wallpaper private/var/stash/Wallpaper"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink Library/Wallpaper private/var/stash/Wallpaper"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv usr/bin private/var/stash/bin"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink usr/bin private/var/stash/bin"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv usr/include private/var/stash/include"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink usr/include private/var/stash/include"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv usr/lib/pam private/var/stash/pam"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink usr/lib/pam private/var/stash/pam"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv usr/libexec private/var/stash/libexec"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink usr/libexec private/var/stash/libexec"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv usr/share private/var/stash/share"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" symlink usr/share private/var/stash/share"""
        ExecCmd(cmdline, True)

    End Sub
    Public Sub AddUltimateness()
        If iPhoneModel = "iPad" Then
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /System/Library/CoreServices/SpringBoard.app/K48AP.plist """ & tempPath & "\K48AP.plist.orig"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\K48AP.plist.orig"" """ & tempPath & "\K48AP.plist"" """ & tempPath & "\K48AP.patch"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\K48AP.plist"" /System/Library/CoreServices/SpringBoard.app/K48AP.plist"""
            ExecCmd(cmdline, True)
        End If
        If UseComexsAwesomeKernelExploit = True Then
            'Adding it... -- START

            'libgmalloc
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\libgmalloc.dylib"" /usr/lib/libgmalloc.dylib"""
            ExecCmd(cmdline, True)

            'pf2
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\pf2"" /usr/lib/pf2"""
            ExecCmd(cmdline, True)

            cmdline = "cmd /c ""DEL """ & tempPath & "\pf2"" /f /q"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\libgmalloc.dylib"" /f /q"""
            ExecCmd(cmdline, True)

            'Fucking Permissions... -_-
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" chmod 100755 usr/lib/libgmalloc.dylib"
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" chmod 100755 usr/lib/pf2"
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" chmod 100755 /private/var/db/.launchd_use_gmalloc"
            ExecCmd(cmdline, True)
            'Adding it... -- STOP
        Else
            Exit Sub
        End If


    End Sub
    Public Sub PatchRamdisk()
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" grow 16000000"""
        ExecCmd(cmdline, True)
        Sleep(1000)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" extract /usr/sbin/asr """ & tempPath & "\asr.orig"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\asr.orig"" """ & tempPath & "\asr"" """ & tempPath & "\asr.patch"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\asr"" /usr/sbin/asr"""
        ExecCmd(cmdline, True)

        'Sexiness -- START
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" rm /usr/share/progressui/images-1x/applelogo.png"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" rm /usr/share/progressui/images-2x/applelogo.png"""
        ExecCmd(cmdline, True)

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\applelogox1.png"" /usr/share/progressui/images-1x/applelogo.png"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\applelogox2.png"" /usr/share/progressui/images-2x/applelogo.png"""
        ExecCmd(cmdline, True)
        'Sexiness -- STOP


        If UseComexsAwesomeKernelExploit = True Then
            Call PatchRestoredExternal()
        End If
        If NORFlashDisabled = True Then
            ReplateText(tempPath & "\options.plist", tempPath & "\options2.plist", "<--DO-I-FLASH-NOR1-->", "<key>FlashNOR</key>")
            ReplateText(tempPath & "\options2.plist", tempPath & "\options3.plist", "<--DO-I-FLASH-NOR2-->", "<false/>")
        Else
            ReplateText(tempPath & "\options.plist", tempPath & "\options2.plist", "<--DO-I-FLASH-NOR1-->", "")
            ReplateText(tempPath & "\options2.plist", tempPath & "\options3.plist", "<--DO-I-FLASH-NOR2-->", "")
        End If
        If UserMode = "Simple" Or PartitionSize = 800 Then
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\options3.plist"" /usr/local/share/restore/options.plist"""
            ExecCmd(cmdline, True)
        Else
            'size changed so create custom options.plist
            ReplateText(tempPath & "\options3.plist", tempPath & "\optionsCustom.plist", "<integer>800</integer>", "<integer>" & PartitionSize & "</integer>")
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" add """ & tempPath & "\optionsCustom.plist"" /usr/local/share/restore/options.plist"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\optionsCustom.plist"" /f /q"""
            ExecCmd(cmdline, True)
        End If

    End Sub
    Public Sub AddCustomRepos()
        Exit Sub
        ecustomapps.RepoNumber = ecustomapps.lvManageSources.Items.Count
        ecustomapps.NumberDoneSoFar = 0
        Do Until ecustomapps.NumberDoneSoFar = ecustomapps.RepoNumber
            ecustomapps.RichTextBox1.Text += ecustomapps.lvManageSources.Items.Item(ecustomapps.NumberDoneSoFar).ToString & " ./" & Chr(13)
            ecustomapps.NumberDoneSoFar = ecustomapps.NumberDoneSoFar + 1
        Loop

        FileOpen(1, tempPath & "\CustomRepos.txt", OpenMode.Output)
        PrintLine(1, ecustomapps.RichTextBox1.Text)
        FileClose()

        ReplateText(tempPath & "\CustomRepos.txt", tempPath & "\CustomRepos1.txt", "ListViewItem: {http://apt.saurik.com/dists/tangelo/main/binary-iphoneos-arm} ./", "#")
        ReplateText(tempPath & "\CustomRepos1.txt", tempPath & "\CustomRepos2.txt", "ListViewItem: {http://apt.bigboss.us.com/repofiles/cydia/dists/stable/main/binary-iphoneos-arm} ./", "#Generated By:")
        ReplateText(tempPath & "\CustomRepos2.txt", tempPath & "\CustomRepos3.txt", "ListViewItem: {http://apt.modmyi.com/dists/stable/main/binary-iphoneos-arm} ./", "#sn0wbreeze V" & Check4Updates.sn0wbreezeVersion)
        ReplateText(tempPath & "\CustomRepos3.txt", tempPath & "\CustomRepos4.txt", "ListViewItem: {http://cydia.zodttd.com/repo/cydia} ./", "#http://ih8sn0w.com")
        ReplateText(tempPath & "\CustomRepos4.txt", tempPath & "\CustomRepos5.txt", "ListViewItem: {http://repo666.ultrasn0w.com} ./", "#")
        ReplateText(tempPath & "\CustomRepos5.txt", tempPath & "\CustomRepos6.txt", "ListViewItem:", "")
        ReplateText(tempPath & "\CustomRepos6.txt", tempPath & "\CustomRepos7.txt", "{", "")
        ReplateText(tempPath & "\CustomRepos7.txt", tempPath & "\CustomRepos8.txt", "}", "")
        ReplateText(tempPath & "\CustomRepos8.txt", tempPath & "\CustomRepos-Final.txt", " http://", "deb http://")

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\CustomRepos-Final.txt"" /etc/apt/sources.list.d/cydia.list"""
        ExecCmd(cmdline, True)
    End Sub
    Public Sub RebuildRamdisk()
        cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" """ & tempPath & "\IPSW\" & Ramdisk & ".dmg"" -t """ & tempPath & "\IPSW\" & Ramdisk & ".dmg.orig"" -iv " & RamdiskIV & " -k " & RamdiskKey
        ExecCmd(cmdline, True)
        Sleep(1000)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\" & Ramdisk & ".dmg.orig"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\ramdisk_decrypted.dmg"" /f /q"""
        ExecCmd(cmdline, True)
    End Sub
    Public Sub PatchiBSS()
        'For Use in iREB -- Start
        If iPhoneModel = "iPhone 2G" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPhone2G.True")
        ElseIf iPhoneModel = "iPhone 3G" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPhone3G.True")
        ElseIf iPhoneModel = "iPhone 3GS" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPhone3GS.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPhone 4" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPhone4.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPod Touch 1G" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPod1G.True")
        ElseIf iPhoneModel = "iPod Touch 2G" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPod2G.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPod Touch 3G" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPod3G.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPod Touch 4" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPod4.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPad" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPad.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "Apple TV 2" Then
            SaveToDisk("wait.img3", tempPath2 & "\AppleTV2.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        End If
        'For use in iREB -- End
        If iPhoneModel = "iPhone 2G" Or iPhoneModel = "iPhone 3G" Or iPhoneModel = "iPod Touch 1G" Then
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu"" """ & tempPath2 & "\iBSS." & ModelVar & ".RELEASE.dfu"" """ & tempPath & "\iBSS." & ModelVar & ".RELEASE-iREB.patch"""
            ExecCmd(cmdline, True)
            cmdline = DFU.quote.Text & tempPath & "\xpwntool.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath2 & "\iBSS." & ModelVar & ".RELEASE.dfu" & DFU.quote.Text & " " & DFU.quote.Text & tempPath2 & "\iBSS." & ModelVar & ".RELEASE.dfu.d" & DFU.quote.Text
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath2 & "\iBSS." & ModelVar & ".RELEASE.dfu.d"" """ & tempPath2 & "\iBSS.payload"" """ & tempPath & "\iBSS." & ModelVar & ".RELEASE-312.payload.patch"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath2 & "\iBSS." & ModelVar & ".RELEASE.dfu.d"" /f /q"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\iBSS." & ModelVar & ".RELEASE-312.payload.patch"" /f /q"""
            ExecCmd(cmdline, True)
        End If

        cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu"" ""iBSS." & ModelVar & ".RELEASE.dfu.orig"""
        ExecCmd(cmdline, True)

        If iBSSIV = "" Then
            cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched"" """ & tempPath & "\iBSS." & ModelVar & ".RELEASE.patch"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu"" -t """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig"""
            ExecCmd(cmdline, True)
        Else
            cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted"" -iv " & iBSSIV & " -k " & iBSSKey & """"
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched"" """ & tempPath & "\iBSS." & ModelVar & ".RELEASE.patch"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched"" """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu"" -t """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig""" & " -iv " & iBSSIV & " -k " & iBSSKey
            ExecCmd(cmdline, True)
        End If

        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig"" /f /q"""
        ExecCmd(cmdline, True)
    End Sub
    Public Sub PatchiBEC()
        If iPhoneModel = "iPhone 3G" Then
            cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu"" ""iBEC." & ModelVar & ".RELEASE.dfu.orig"""
            ExecCmd(cmdline, True)

            If iBECIV = "" Then
                cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.d"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.d"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath & "\iBEC." & ModelVar & ".RELEASE.patch"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu"" -t """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.orig"""
                ExecCmd(cmdline, True)
            Else
                cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.d""" & " -iv " & iBECIV & " -k " & iBECKey
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.d"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath & "\iBEC." & ModelVar & ".RELEASE.patch"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu"" -t """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.orig""" & " -iv " & iBECIV & " -k " & iBECKey
                ExecCmd(cmdline, True)
            End If

            If iPhoneModel = "iPhone 3G" Then
                cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.d"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.d"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath & "\iBEC." & ModelVar & ".RELEASE-iREB.patch"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath2 & "\iBEC." & ModelVar & ".RELEASE.dfu"" -t """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.orig"""
                ExecCmd(cmdline, True)
                SaveToDisk("wait.img3", tempPath2 & "\wait.img3")
                SaveToDisk("itunnel.exe", tempPath2 & "\itunnel.exe")
                cmdline = "cmd /c COPY /Y " & DFU.quote.Text & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu" & DFU.quote.Text & " " & DFU.quote.Text & tempPath2 & "\iBEC." & ModelVar & ".RELEASE.dfu" & DFU.quote.Text
                ExecCmd(cmdline, True)
                cmdline = "cmd /c COPY /Y " & DFU.quote.Text & tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu" & DFU.quote.Text & " " & DFU.quote.Text & tempPath2 & "\iBSS." & ModelVar & ".RELEASE-proper.dfu" & DFU.quote.Text
                ExecCmd(cmdline, True)
            End If

        Else
            Exit Sub
        End If
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.orig"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.d"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.pwned"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.patched"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\iBEC." & ModelVar & ".RELEASE.dfu.decrypted"" /f /q"""
        ExecCmd(cmdline, True)
    End Sub
    Public Sub PatchWTF2()
        'Copy WTF Driver (For iREB Use)
        cmdline = "cmd /c COPY /Y " & DFU.quote.Text & tempPath & "\IPSW\Firmware\dfu\WTF.s5l8900xall.RELEASE.dfu" & DFU.quote.Text & " " & DFU.quote.Text & tempPath2 & "\WTF.s5l8900xall.RELEASE.dfu" & DFU.quote.Text
        ExecCmd(cmdline, True)

        cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu"" ""WTF." & ModelVar & ".RELEASE.dfu.orig"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.d"
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.d"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath & "\WTF." & ModelVar & ".RELEASE.patch"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.pwned"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu"" -t " & DFU.quote.Text & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.orig" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.pwned"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.d"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\WTF." & ModelVar & ".RELEASE.dfu.orig"" /f /q"""
        ExecCmd(cmdline, True)

        'Second WTF Patches

        cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu"" ""WTF." & Kernel & "all.RELEASE.dfu.orig"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.d"
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.d"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.pwned"" """ & tempPath & "\WTF." & Kernel & "all.RELEASE.patch"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\xpwntool.exe"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.pwned"" """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu"" -t " & DFU.quote.Text & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.orig" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.pwned"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.d"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\dfu\WTF." & Kernel & "all.RELEASE.dfu.orig"" /f /q"""
        ExecCmd(cmdline, True)
    End Sub
    Public Sub AddBootLogo()
        If iPhoneModel = "iPhone 3G" Then

            SaveToDisk("BootLogo.png", tempPath & "\BootLogo.png")
            If UserMode = "Simple" Or (UserMode = "Expert" And UseCustomBootLogo = True) Then
                cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\applelogo." & Kernel & ".img3 "" ""applelogo." & Kernel & ".img3.orig"""
                ExecCmd(cmdline, True)
                cmdline = DFU.quote.Text & tempPath & "\imagetool.exe" & DFU.quote.Text & " inject " & DFU.quote.Text & tempPath & "\" & BootLogo & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\applelogo." & Kernel & ".img3" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\applelogo." & Kernel & ".img3.orig" & DFU.quote.Text & " " & applelogoIV & " " & applelogoKey
                ExecCmd(cmdline, True)

                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\applelogo." & Kernel & ".img3.orig"" /f /q"""
                ExecCmd(cmdline, True)
            End If
            File_Delete(tempPath & "\BootLogo.png")
        End If
    End Sub
    Public Sub AddCustomImages()
        If iPhoneModel = "iPhone 3G" Then
            SaveToDisk("RecoveryLogo.png", tempPath & "\RecoveryLogo.png")
            If UserMode = "Simple" Then
                cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3 "" ""recoverymode." & Kernel & ".img3.orig"""
                ExecCmd(cmdline, True)
                cmdline = DFU.quote.Text & tempPath & "\imagetool.exe" & DFU.quote.Text & " inject " & DFU.quote.Text & tempPath & "\" & RecoveryLogo & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3.orig" & DFU.quote.Text & " " & RecoveryModeIV & " " & RecoveryModeKey
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3.orig"" /f /q"""
                ExecCmd(cmdline, True)
            ElseIf UserMode = "Expert" Then
                If UseCustomRecoveryLogo = True Then
                    cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3 "" ""recoverymode." & Kernel & ".img3.orig"""
                    ExecCmd(cmdline, True)
                    cmdline = DFU.quote.Text & tempPath & "\imagetool.exe" & DFU.quote.Text & " inject " & DFU.quote.Text & tempPath & "\" & RecoveryLogo & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3.orig" & DFU.quote.Text & " " & RecoveryModeIV & " " & RecoveryModeKey
                    ExecCmd(cmdline, True)
                    cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3.orig"" /f /q"""
                    ExecCmd(cmdline, True)
                End If
            End If
            File_Delete(tempPath & "\RecoveryLogo.png")
        End If

    End Sub
    Public Sub PatchLLB()
        If iPhoneModel = "iPhone 3G" Then
            cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3"" ""LLB." & ModelVar & ".RELEASE.img3.orig"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3.orig"" """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3"" """ & tempPath & "\LLB." & ModelVar & ".RELEASE.patch"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3.orig""  /f /q"""
            ExecCmd(cmdline, True)
        End If
    End Sub
    Public Sub InstallingSSH()
        If File_Exists(tempPath & "\OpenSSH.tar") = False Then
            SaveToDisk("OpenSSH.zip", tempPath & "\OpenSSH.zip")
            Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(tempPath & "\OpenSSH.zip")
                zip1.ExtractAll(tempPath & "\", True)
                zip1.Dispose()
            End Using
        End If
        File_Delete(tempPath & "\OpenSSH.zip")

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" untar """ & tempPath & "\OpenSSH.tar"""
        ExecCmd(cmdline, True)

        InstallSSH = False
        File_Delete(tempPath & "\OpenSSH.tar")
    End Sub
    Public Sub Uploadkernel()
        If UseComexsAwesomeKernelExploit = True Then
            If iPhoneModel = "iPhone 3G" Then
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\IPSW\kernelcache.release." & Board & """ System/Library/Caches/com.apple.kernelcaches/kernelcache"
                ExecCmd(cmdline, True)
            End If
            Exit Sub
        End If
    End Sub
    Public Sub HacktivatePhone()
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /usr/libexec/lockdownd """ & tempPath & "\lockdownd.orig"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\lockdownd.orig"" """ & tempPath & "\lockdownd"" """ & tempPath & "\lockdownd.patch"""
        ExecCmd(cmdline, True)
        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\lockdownd"" /usr/libexec/lockdownd"""
        ExecCmd(cmdline, True)
        Try
            If File_Exists(tempPath & "\debs\private\var\root\Media\Cydia\AutoInstall\youtubefix1.deb") = False Then
                Dim DownloadBootN As String
                DownloadBootN = "http://youtubefix.ih8sn0w.com/"
                Dim clientBootN = New System.Net.WebClient()
                clientBootN.DownloadFile(DownloadBootN, tempPath & "\debs\private\var\root\Media\Cydia\AutoInstall\youtubefix1.deb")
            End If
            Sleep(1000)
        Catch ex As Exception
        End Try

        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" addall """ & tempPath & "\debs"""
        ExecCmd(cmdline, True)
    End Sub
    Public Sub SeatbeltFix()
        Try
            If IPSWVersion = "3.0" Or IPSWVersion = "3.0.1" Or IPSWVersion = "3.1" Or IPSWVersion = "3.1.1" Or IPSWVersion = "3.1.2" Or IPSWVersion = "3.1.3" Or IPSWVersion = "4.1" Then
                Exit Sub
            Else
                If UseComexsAwesomeKernelExploit = True Then
                    If iPhoneModel = "iPhone 3G" Then
                        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /Applications/MobileSafari.app/MobileSafari """ & tempPath & "\MobileSafari.orig"""
                        ExecCmd(cmdline, True)
                        cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\MobileSafari.orig"" """ & tempPath & "\MobileSafari.pwned"" """ & tempPath & "\MobileSafari.patch"""
                        ExecCmd(cmdline, True)
                        cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\MobileSafari.pwned"" /Applications/MobileSafari.app/MobileSafari"""
                        ExecCmd(cmdline, True)
                        Sleep(1000)
                        cmdline = "cmd /c ""DEL """ & tempPath & "\MobileSafari.orig"" /f /q"""
                        ExecCmd(cmdline, True)
                        cmdline = "cmd /c ""DEL """ & tempPath & "\MobileSafari.pwned"" /f /q"""
                        ExecCmd(cmdline, True)
                    End If
                    Exit Sub
                End If
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /Applications/MobileSafari.app/MobileSafari """ & tempPath & "\MobileSafari.orig"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\MobileSafari.orig"" """ & tempPath & "\MobileSafari.pwned"" """ & tempPath & "\MobileSafari.patch"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\MobileSafari.pwned"" /Applications/MobileSafari.app/MobileSafari"""
                ExecCmd(cmdline, True)
                Sleep(1000)
                cmdline = "cmd /c ""DEL """ & tempPath & "\MobileSafari.orig"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\MobileSafari.pwned"" /f /q"""
                ExecCmd(cmdline, True)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SeatbeltFix_old()
        Try
            If IPSWVersion = "3.0" Or IPSWVersion = "3.0.1" Or IPSWVersion = "3.1" Or IPSWVersion = "3.1.1" Or IPSWVersion = "3.1.2" Or IPSWVersion = "3.1.3" Or IPSWVersion = "4.1" Then
                Exit Sub
            Else
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /Applications/MobileSafari.app/MobileSafari """ & tempPath & "\MobileSafari.orig"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\MobileSafari.orig"" """ & tempPath & "\MobileSafari.pwned"" """ & tempPath & "\MobileSafari.patch"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\MobileSafari.pwned"" /Applications/MobileSafari.app/MobileSafari"""
                ExecCmd(cmdline, True)
                Sleep(1000)
                cmdline = "cmd /c ""DEL """ & tempPath & "\MobileSafari.orig"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\MobileSafari.pwned"" /f /q"""
                ExecCmd(cmdline, True)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub CustomOptions40()
        If iPhoneModel = "iPad" Then
            'GTFO iPad!!!!
            Exit Sub
        End If
        If iPhoneModel = "iPod Touch 4" Then
            Exit Sub
            'iPod Touch 4 Options -- Not ready yet.

            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /System/Library/CoreServices/SpringBoard.app/N81AP.plist """ & tempPath & "\N81AP.plist.orig"""
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\N81AP.plist.orig"" """ & tempPath & "\N81AP.plist.pwned"" """ & tempPath & "\SpringBoardN81AP.patch"""
            ExecCmd(cmdline, True)


            If EnableHDR = True Then
                ReplateText(tempPath & "\N81AP.plist.pwned", tempPath & "\N81AP.plist.pwned1", "<!--ADDOPTIONS1--!>", "<key>hdr-image-capture</key><true/>")
            Else
                ReplateText(tempPath & "\N81AP.plist.pwned", tempPath & "\N81AP.plist.pwned1", "<!--ADDOPTIONS1--!>", "")
            End If

            'Send Back to iPod mofo
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\N81AP.plist.pwned1"" /System/Library/CoreServices/SpringBoard.app/N81AP.plist"""
            ExecCmd(cmdline, True)
            MsgBox("I UPPED IT!")
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" mv System/Library/PrivateFrameworks/Celestial.framework/N81/AVCapture.plist System/Library/PrivateFrameworks/Celestial.framework/N81/AVCapture.plist.orig"
            ExecCmd(cmdline, True)
            cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\AVCapture.plist"" /System/Library/PrivateFrameworks/Celestial.framework/N81/AVCapture.plist"""
            ExecCmd(cmdline, True)


            cmdline = "cmd /c ""DEL """ & tempPath & "\N81AP.plist.orig"" /f /q"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\N81AP.plist.pwned"" /f /q"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\N81AP.plist.pwned"" /f /q"""
            ExecCmd(cmdline, True)
        End If
        If IPSWVersion = "3.0" Or IPSWVersion = "3.0.1" Or IPSWVersion = "3.1" Or IPSWVersion = "3.1.1" Or IPSWVersion = "3.1.2" Or IPSWVersion = "3.1.3" Or IPSWVersion = "3.2" Or IPSWVersion = "3.2.1" Or IPSWVersion = "3.2.2" Then
            Exit Sub
        Else
            If iPhoneModel = "iPod Touch 2G" Then
                'iPod 2G options
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /System/Library/CoreServices/SpringBoard.app/N72AP.plist """ & tempPath & "\N72AP.plist.orig"""
                ExecCmd(cmdline, True)
                'Apply General Patch
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /Applications/Preferences.app/General.plist """ & tempPath & "\General.plist.orig"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\General.plist.orig"" """ & tempPath & "\General.plist.pwned"" """ & tempPath & "\General.patch"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\General.plist.pwned"" /Applications/Preferences.app/General.plist"""
                ExecCmd(cmdline, True)
                'End Of General Patch
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\N72AP.plist.orig"" """ & tempPath & "\N72AP.plist.pwned"" """ & tempPath & "\SpringBoardN72AP.patch"""
                ExecCmd(cmdline, True)
                If EnableWallpaper = True Then
                    ReplateText(tempPath & "\N72AP.plist.pwned", tempPath & "\N72AP.plist.pwned2", "<!--ADDOPTIONS1--!>", "<key>homescreen-wallpaper</key><true/>")
                Else
                    ReplateText(tempPath & "\N72AP.plist.pwned", tempPath & "\N72AP.plist.pwned2", "<!--ADDOPTIONS1--!>", "")
                End If
                If EnablePercentage = True Then
                    ReplateText(tempPath & "\N72AP.plist.pwned2", tempPath & "\N72AP.plist.pwned3", "<!--ADDOPTIONS2--!>", "<key>gas-gauge-battery</key><true/>")
                Else
                    ReplateText(tempPath & "\N72AP.plist.pwned2", tempPath & "\N72AP.plist.pwned3", "<!--ADDOPTIONS2--!>", "")
                End If
                If EnableMultiTasking = True Then
                    ReplateText(tempPath & "\N72AP.plist.pwned3", tempPath & "\N72AP.plist.pwned4", "<!--ADDOPTIONS3--!>", "<key>multitasking</key><true/>")
                Else
                    ReplateText(tempPath & "\N72AP.plist.pwned3", tempPath & "\N72AP.plist.pwned4", "<!--ADDOPTIONS3--!>", "")
                End If
                'Send Back final version.
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\N72AP.plist.pwned4"" /System/Library/CoreServices/SpringBoard.app/N72AP.plist"""
                ExecCmd(cmdline, True)
                Sleep(1000)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N72AP.plist.orig"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N72AP.plist.pwned"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N72AP.plist.pwned2"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N72AP.plist.pwned3"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N72AP.plist.pwned4"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\General.plist.pwned"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\General.plist.orig"" /f /q"""
                ExecCmd(cmdline, True)
            End If

            If iPhoneModel = "iPhone 3G" Then
                'iPhone 3G options
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /System/Library/CoreServices/SpringBoard.app/N82AP.plist """ & tempPath & "\N82AP.plist.orig"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\N82AP.plist.orig"" """ & tempPath & "\N82AP.plist.pwned"" """ & tempPath & "\SpringBoardN82AP.patch"""
                ExecCmd(cmdline, True)
                If EnableWallpaper = True Then
                    ReplateText(tempPath & "\N82AP.plist.pwned", tempPath & "\N82AP.plist.pwned2", "<!--ADDOPTIONS1--!>", "<key>homescreen-wallpaper</key><true/>")
                Else
                    ReplateText(tempPath & "\N82AP.plist.pwned", tempPath & "\N82AP.plist.pwned2", "<!--ADDOPTIONS1--!>", "")
                End If
                If EnablePercentage = True Then
                    ReplateText(tempPath & "\N82AP.plist.pwned2", tempPath & "\N82AP.plist.pwned3", "<!--ADDOPTIONS2--!>", "<key>gas-gauge-battery</key><true/>")
                Else
                    ReplateText(tempPath & "\N82AP.plist.pwned2", tempPath & "\N82AP.plist.pwned3", "<!--ADDOPTIONS2--!>", "")
                End If
                If EnableMultiTasking = True Then
                    ReplateText(tempPath & "\N82AP.plist.pwned3", tempPath & "\N82AP.plist.pwned4", "<!--ADDOPTIONS3--!>", "<key>multitasking</key><true/>")
                Else
                    ReplateText(tempPath & "\N82AP.plist.pwned3", tempPath & "\N82AP.plist.pwned4", "<!--ADDOPTIONS3--!>", "")
                End If
                If IPSWVersion = "4.0" Or IPSWVersion = "4.0.1" Or IPSWVersion = "4.0.2" Then
                    cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\N82AP.plist.pwned4"" /System/Library/CoreServices/SpringBoard.app/N82AP.plist"""
                    ExecCmd(cmdline, True)
                Else
                    If EnableHDR = True Then
                        ReplateText(tempPath & "\N82AP.plist.pwned4", tempPath & "\N82AP.plist.pwned5", "<!--ADDOPTIONS4--!>", "<key>hdr-image-capture</key><true/>")
                    Else
                        ReplateText(tempPath & "\N82AP.plist.pwned4", tempPath & "\N82AP.plist.pwned5", "<!--ADDOPTIONS4--!>", "")
                    End If
                    cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\N82AP.plist.pwned5"" /System/Library/CoreServices/SpringBoard.app/N82AP.plist"""
                    ExecCmd(cmdline, True)
                End If

                'Send Back final version.
                Sleep(1000)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N82AP.plist.orig"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N82AP.plist.pwned"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N82AP.plist.pwned2"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N82AP.plist.pwned3"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N82AP.plist.pwned4"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N82AP.plist.pwned5"" /f /q"""
                ExecCmd(cmdline, True)
            End If

            If IPSWVersion = "4.0" Or IPSWVersion = "4.0.1" Or IPSWVersion = "4.0.2" Then
                Exit Sub
            End If
            'ANYTHING AFTER 4.1 will run here

            If iPhoneModel = "iPhone 3GS" Then
                '3GS Options
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" extract /System/Library/CoreServices/SpringBoard.app/N88AP.plist """ & tempPath & "\N88AP.plist.orig"""
                ExecCmd(cmdline, True)
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\N88AP.plist.orig"" """ & tempPath & "\N88AP.plist.pwned"" """ & tempPath & "\SpringBoardN88AP.patch"""
                ExecCmd(cmdline, True)

                If EnableHDR = True Then
                    ReplateText(tempPath & "\N88AP.plist.pwned", tempPath & "\N88AP.plist.pwned1", "<!--ADDOPTIONS1--!>", "<key>hdr-image-capture</key><true/>")
                Else
                    ReplateText(tempPath & "\N88AP.plist.pwned", tempPath & "\N88AP.plist.pwned1", "<!--ADDOPTIONS1--!>", "")
                End If
                'Send Back 3GS mofo
                cmdline = """" & tempPath & "\hfsplus.exe"" """ & tempPath & "\IPSW\DECRYPTED.dmg"" add """ & tempPath & "\N88AP.plist.pwned1"" /System/Library/CoreServices/SpringBoard.app/N88AP.plist"""
                ExecCmd(cmdline, True)

                cmdline = "cmd /c ""DEL """ & tempPath & "\N88AP.plist.orig"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N88AP.plist.pwned"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = "cmd /c ""DEL """ & tempPath & "\N88AP.plist.pwned"" /f /q"""
                ExecCmd(cmdline, True)
            End If
        End If
    End Sub
    Public Sub RebuildRootFS()
        cmdline = """" & tempPath & "\dmg.exe"" build """ & tempPath & "\IPSW\DECRYPTED.dmg"" """ & tempPath & "\IPSW\" & RootFS & ".dmg"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\DECRYPTED.dmg"" /f /q"""
        ExecCmd(cmdline, True)
    End Sub
    Public Sub PatchiBoot()
        If iPhoneModel = "iPhone 3G" Then
            cmdline = "cmd /c ""RENAME """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3"" ""iBoot." & ModelVar & ".RELEASE.img3.orig"""
            ExecCmd(cmdline, True)
            If iBootkIV = "" Then
                cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\dfu\iBoot." & ModelVar & ".RELEASE.dfu.orig"" """ & tempPath & "\IPSW\Firmware\dfu\iBoot." & ModelVar & ".RELEASE.dfu"" """ & tempPath & "\iBoot." & ModelVar & ".RELEASE.patch"""
                ExecCmd(cmdline, True)
            Else
                If VerboseMode = True Then
                    cmdline = """" & tempPath & "\xpwntool.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted" & DFU.quote.Text & " -iv " & iBootkIV & " -k " & iBootKey
                    ExecCmd(cmdline, True)
                    cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted"" """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched"" """ & tempPath & "\iBoot." & ModelVar & ".RELEASE.Verbose.patch"""
                    ExecCmd(cmdline, True)
                    cmdline = """" & tempPath & "\xpwntool.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3" & DFU.quote.Text & " -t " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig" & DFU.quote.Text & " -iv " & iBootkIV & " -k " & iBootKey
                    ExecCmd(cmdline, True)
                Else
                    cmdline = """" & tempPath & "\xpwntool.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted" & DFU.quote.Text & " -iv " & iBootkIV & " -k " & iBootKey
                    ExecCmd(cmdline, True)
                    cmdline = """" & tempPath & "\bspatch.exe"" """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted"" """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched"" """ & tempPath & "\iBoot." & ModelVar & ".RELEASE.patch"""
                    ExecCmd(cmdline, True)
                    cmdline = """" & tempPath & "\xpwntool.exe" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3" & DFU.quote.Text & " -t " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig" & DFU.quote.Text & " -iv " & iBootkIV & " -k " & iBootKey
                    ExecCmd(cmdline, True)
                End If
            End If

            cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig"" /f /q"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched"" /f /q"""
            ExecCmd(cmdline, True)
            cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted"" /f /q"""
            ExecCmd(cmdline, True)
        Else
            Exit Sub

        End If
    End Sub
    Public Sub DeleteUnrequiredFilesNOR()

        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\BuildManifest.plist"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\" & Unwanted & ".dmg"" /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\" & RootFS & ".dmg"" /f /q"""
        ExecCmd(cmdline, True)

        If File_Exists(tempPath & "\IPSW\" & Unwanted & ".dmg") = True Then
            ErrorMessage = "Failed deleting unrequired files"
            ipswFailed = True
            ExitFlag = True
        End If

        If File_Exists(tempPath & "\IPSW\" & RootFS & ".dmg") = True Then
            ErrorMessage = "Failed deleting unrequired files"
            ipswFailed = True
            ExitFlag = True
        End If
    End Sub
    Public Sub DeleteUnrequiredFiles()
        If DoIDeleteBuildManifest = True Then
            cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\BuildManifest.plist"" /f /q"""
            ExecCmd(cmdline, True)
        End If

        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\SpringBoardN82AP.patch" & DFU.quote.Text & " /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\MobileSafari.patch" & DFU.quote.Text & " /f /q"""
        ExecCmd(cmdline, True)

        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\options.plist" & DFU.quote.Text & " /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\options2.plist" & DFU.quote.Text & " /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\options3.plist" & DFU.quote.Text & " /f /q"""
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\optionsNOR.plist" & DFU.quote.Text & " /f /q"""
        ExecCmd(cmdline, True)


        cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\" & Unwanted & ".dmg"" /f /q"""
        ExecCmd(cmdline, True)
        File_Delete(tempPath & "\IPSW\" & Unwanted & ".dmg")
    End Sub
    Public Sub CreateIPSW()
        'get desktop folder
        Dim obj As Object
        obj = CreateObject("WScript.Shell")

        If NOR = True Then
            'delete ipsw if already exists
            If File_Exists(obj.SpecialFolders("desktop") & "\sn0wbreeze_NOR_" & iPhoneModel & "-" & IPSWVersion & ".ipsw") = True Then
                File_Delete(obj.SpecialFolders("desktop") & "\sn0wbreeze_NOR_" & iPhoneModel & "-" & IPSWVersion & ".ipsw")
            End If

            'Zip(tempPath & "\ipsw\", obj.SpecialFolders("desktop") & "\sn0wbreeze_NOR_" & iPhoneModel & ".ipsw", "")

            Using zip1 As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
                zip1.AddDirectory(tempPath & "\ipsw\")
                zip1.Save(obj.SpecialFolders("desktop") & "\sn0wbreeze_NOR_" & iPhoneModel & "-" & IPSWVersion & ".ipsw")
            End Using
        Else
            'delete ipsw if already exists
            If File_Exists(obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & "-" & IPSWVersion & ".ipsw") = True Then
                File_Delete(obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & "-" & IPSWVersion & ".ipsw")
            End If
            'Zip(tempPath & "\ipsw\", obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & ".ipsw", "")
            Using zip1 As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
                zip1.AddDirectory(tempPath & "\ipsw\")
                zip1.Save(obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & "-" & IPSWVersion & ".ipsw")
            End Using

        End If
    End Sub
    Public Sub Zip(ByVal inputFolderPath As String, ByVal outputPathAndFile As String, ByVal password As String)
        Dim ar As ArrayList = GenerateFileList(inputFolderPath)
        ' generate file list
        Dim TrimLength As Integer = (Directory.GetParent(inputFolderPath)).ToString().Length
        ' find number of chars to remove // from orginal file path
        TrimLength += 1
        'remove '\'
        Dim ostream As FileStream
        Dim obuffer As Byte()
        Dim outPath As String = outputPathAndFile
        Dim oZipStream As New ZipOutputStream(File.Create(outPath))
        ' create zip stream
        If password IsNot Nothing AndAlso password <> [String].Empty Then
            oZipStream.Password = password
        End If
        oZipStream.SetLevel(0)
        ' maximum compression
        Dim oZipEntry As ICSharpCode.SharpZipLib.Zip.ZipEntry
        For Each Fil As String In ar
            ' for each file, generate a zipentry
            oZipEntry = New ICSharpCode.SharpZipLib.Zip.ZipEntry(Fil.Remove(0, TrimLength))
            oZipStream.PutNextEntry(oZipEntry)
            If Not Fil.EndsWith("/") Then
                ' if a file ends with '/' its a directory
                ostream = File.OpenRead(Fil)
                obuffer = New Byte(ostream.Length - 1) {}
                ostream.Read(obuffer, 0, obuffer.Length)
                oZipStream.Write(obuffer, 0, obuffer.Length)
            End If
        Next
        oZipStream.Finish()
        oZipStream.Close()
    End Sub
    Private Function GenerateFileList(ByVal Dir As String) As ArrayList
        Dim fils As New ArrayList()
        Dim Empty As Boolean = True
        For Each file As String In Directory.GetFiles(Dir)
            ' add each file in directory
            fils.Add(file)
            Empty = False
        Next

        If Empty Then
            If Directory.GetDirectories(Dir).Length = 0 Then
                ' if directory is completely empty, add it
                fils.Add(Dir)
            End If
        End If

        For Each dirs As String In Directory.GetDirectories(Dir)
            ' recursive
            For Each obj As Object In GenerateFileList(dirs)
                fils.Add(obj)
            Next
        Next
        ' return file list
        Return fils
    End Function
    Public Sub ZipOLD(ByVal SrcFile As String, ByVal DstFile As String, ByVal BufferSize As Integer)

        Dim astrFileNames() As String = Directory.GetFiles(SrcFile)
        Dim astrDirectoryNames() As String = Directory.GetDirectories(SrcFile)
        Dim strmZipOutputStream As ZipOutputStream

        strmZipOutputStream = New ZipOutputStream(File.Create(DstFile))

        REM Compression Level: 0-9
        REM 0: no(Compression)
        REM 9: maximum compression
        strmZipOutputStream.SetLevel(0)

        Dim strFile As String

        For Each strFolder In astrDirectoryNames

            For Each strFile In astrFileNames

                Dim strmFile As FileStream = File.OpenRead(strFile)
                Dim abyBuffer(strmFile.Length - 1) As Byte

                strmFile.Read(abyBuffer, 0, abyBuffer.Length)

                Dim IndexStart As Integer = strFile.IndexOf("\ipsw\") + 6
                Dim IndexEnd As Integer = Strings.Len(strFile) - (strFile.IndexOf("\ipsw\") + 6)
                strFile = strFile.Substring(IndexStart, IndexEnd)

                Dim objZipEntry As ICSharpCode.SharpZipLib.Zip.ZipEntry = New ICSharpCode.SharpZipLib.Zip.ZipEntry(strFile)

                objZipEntry.DateTime = DateTime.Now
                objZipEntry.Size = strmFile.Length
                strmFile.Close()
                strmZipOutputStream.PutNextEntry(objZipEntry)
                strmZipOutputStream.Write(abyBuffer, 0, abyBuffer.Length)
            Next

        Next

        strmZipOutputStream.Finish()
        strmZipOutputStream.Close()
    End Sub
    Public Sub UnZip(ByVal SrcFile As String, ByVal DstFile As String, ByVal BufferSize As Integer)

        Dim fileName As String = SrcFile 'Path.GetFullPath("../AcapCopy.zip")
        Dim destPath As String = DstFile 'Path.GetFullPath("../Unzipped/")

        If Not Directory.Exists(destPath) Then
            Directory.CreateDirectory(destPath)
        End If

        Dim inStream As New ZipInputStream(File.OpenRead(fileName))
        Dim outStream As FileStream

        Dim entry As ICSharpCode.SharpZipLib.Zip.ZipEntry
        Dim buff(BufferSize - 1) As Byte
        Dim bytes As Integer

        Do While True
            entry = inStream.GetNextEntry()

            If entry Is Nothing Then
                Exit Do
            End If

            If entry.IsDirectory = True Then
                Create_Directory(destPath + entry.Name)
            Else
                outStream = File.Create(destPath + entry.Name, BufferSize)

                Do While True
                    bytes = inStream.Read(buff, 0, BufferSize)
                    If bytes = 0 Then
                        Exit Do
                    End If

                    outStream.Write(buff, 0, bytes)
                Loop

                outStream.Close()
            End If

        Loop

        inStream.Close()
    End Sub
End Module
