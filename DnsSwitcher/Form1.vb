Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports Ionic.Zip

Public Class Form1
    Dim QuicksetDnsexe As String
    Dim projectDirectory As String
    Dim QuicksetDnszip As String
    Dim QuicksetDnsdir As String




    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadQuickDns()
    End Sub

    Private Sub DownloadQuickDns()
        projectDirectory = My.Computer.FileSystem.CurrentDirectory
        QuicksetDnsexe = projectDirectory
        QuicksetDnsexe += "/QuicksetDns/QuickSetDNS.exe"
        QuicksetDnszip = projectDirectory
        QuicksetDnszip += "/quicksetdns.zip"
        QuicksetDnsdir = projectDirectory
        QuicksetDnsdir += "/QuicksetDns/"

        If My.Computer.FileSystem.FileExists(QuicksetDnsexe) Then
            GoTo quit
        Else
            MsgBox("QuicksetDns not downloaded or Broken, Downloading now")
            My.Computer.Network.DownloadFile("http://www.nirsoft.net/utils/quicksetdns.zip", QuicksetDnszip)
            Console.WriteLine("Extracting file {0} to {1}", QuicksetDnszip, QuicksetDnsdir)
            Using zip1 As ZipFile = ZipFile.Read(QuicksetDnszip)
                ' AddHandler zip1.ExtractProgress, AddressOf MyExtractProgress
                Dim e As ZipEntry
                ' here, we extract every entry, but we could extract    
                ' based on entry name, size, date, etc.   
                For Each e In zip1
                    e.Extract(QuicksetDnsdir, ExtractExistingFileAction.OverwriteSilently)
                Next
            End Using
            My.Computer.FileSystem.DeleteFile(QuicksetDnszip)
        End If
quit:
    End Sub

End Class
