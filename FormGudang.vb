Public Class FormGudang
    Private Sub FormGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switch_Panel(Panel_GudangParent, New UserControl_Gudang_KelolaBarang)
    End Sub

    Private Sub FormGudang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Form1.Show()
    End Sub

    Private Sub Button_Gudang_Logout_Click(sender As Object, e As EventArgs) Handles Button_Gudang_Logout.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class