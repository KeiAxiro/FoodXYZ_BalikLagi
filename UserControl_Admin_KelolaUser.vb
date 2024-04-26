Public Class UserControl_Admin_KelolaUser
    Private Sub UserControl_Admin_KelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisi_Awal()
    End Sub
    Sub Kondisi_Awal()
        Call Kondisi_Input(False)
        Call Clear_Input()

        Button_KelolaUser_Tambah.Enabled = True
        Button_KelolaUser_Edit.Enabled = False
        Button_KelolaUser_Hapus.Enabled = False
    End Sub
    Sub Kondisi_Input(Kondisi As Boolean)
        ComboBox_TipeUser.Enabled = Kondisi
        TextBox_Alamat.Enabled = Kondisi
        TextBox_Nama.Enabled = Kondisi
        TextBox_Username.Enabled = Kondisi
        TextBox_Telepon.Enabled = Kondisi
        TextBox_Password.Enabled = Kondisi
    End Sub
    Sub Clear_Input()

    End Sub

End Class
