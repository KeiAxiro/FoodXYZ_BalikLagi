Public Class Form_Kasir
    Private Sub Form_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switch_Panel(Panel_KasirParent, New UserControl_Kasir_KelolaTransaksi)
    End Sub

    Private Sub Form_Kasir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Form1.Show()
    End Sub
    Private Sub Button_Kasir_Logout_Click(sender As Object, e As EventArgs) Handles Button_Kasir_Logout.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class