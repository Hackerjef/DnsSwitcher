Imports System.IO
Imports System.IO.Compression

Module Module1
    Private projectDirectory As String
    Private QuicksetDnsexe As String
    Private QuicksetDnszip As String
    Private QuicksetDnsdir As String


    Sub Main()
        projectDirectory = My.Computer.FileSystem.CurrentDirectory
        QuicksetDnsexe = projectDirectory
        QuicksetDnsexe += "/QuicksetDns/QuickSetDNS.exe"
        QuicksetDnszip = projectDirectory
        QuicksetDnszip += "/quicksetdns.zip"
        QuicksetDnsdir = projectDirectory
        QuicksetDnsdir += "/QuicksetDns/"

        If My.Computer.FileSystem.FileExists(QuicksetDnsexe) Then
            End
        Else
            MsgBox("QuicksetDns not downloaded, Downloading now")
            My.Computer.Network.DownloadFile("http://www.nirsoft.net/utils/quicksetdns.zip", QuicksetDnszip)


        End If
    End Sub

End Module
