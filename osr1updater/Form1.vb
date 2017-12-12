
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.FileSystem.DeleteFile("OSR1.exe")
        My.Computer.Network.DownloadFile("http://vbprogrameles.us.lt/updater/OSR1.exe", "OSR1.exe", "", "", True, 600, False)







    End Sub




    Private Sub Button1_ClientSizeChanged(sender As Object, e As EventArgs) Handles Button1.ClientSizeChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.vbprogrameles.us.lt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("OSR1.exe")
    End Sub
End Class
