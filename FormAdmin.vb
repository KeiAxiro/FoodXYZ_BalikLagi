Public Class FormAdmin
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switch_Panel(Panel_AdminParent, New UserControl_Admin_LogActivity)
    End Sub

    Private Sub Button_Admin_KelolaUser_Click(sender As Object, e As EventArgs) Handles Button_Admin_KelolaUser.Click
        Switch_Panel(Panel_AdminParent, New UserControl_Admin_KelolaUser)
    End Sub

    Private Sub Button_Admin_KelolaLaporan_Click(sender As Object, e As EventArgs) Handles Button_Admin_KelolaLaporan.Click
        Switch_Panel(Panel_AdminParent, New UserControl_Admin_KelolaLaporan)
    End Sub

    Private Sub Button_Admin_Logout_Click(sender As Object, e As EventArgs) Handles Button_Admin_Logout.Click
        Me.Dispose()
        Form1.Show()
    End Sub

    Private Sub FormAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Form1.Show()
    End Sub

End Class