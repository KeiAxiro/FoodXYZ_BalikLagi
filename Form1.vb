Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Call Koneksi()
        Dim GetUserData As String = "SELECT * FROM tbl_user WHERE username = @_username AND password = @_password"
        Cmd = New SqlClient.SqlCommand(GetUserData, Conn)
        Cmd.Parameters.AddWithValue("@_username", TextBox_Username.Text)
        Cmd.Parameters.AddWithValue("@_password", TextBox_Password.Text)
        Srd = Cmd.ExecuteReader
        If Srd.HasRows Then
            Srd.Read()
            If Srd.Item("tipe_user").Equals("ADMIN") Then
                FormAdmin.Show()
                Me.Hide()
            ElseIf Srd.Item("tipe_user").Equals("GUDANG") Then
                FormGudang.Show()
                Me.Hide()
            ElseIf Srd.Item("tipe_user").Equals("KASIR") Then
                MsgBox("njd")
            Else
                MsgBox("Terjadi Kesalahan", vbOKOnly, "Warning")
            End If
            Call WriteLog("Login", Srd.Item("id_user"))

        Else
            Label_Validation.ForeColor = Color.Red
            Label_Validation.Text = "Username Atau Password Salah!"
        End If
    End Sub

    Private Sub Panel_Username_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Username.Paint
        Call DrawLine(e, TextBox_Username)
    End Sub
    Private Sub Panel_Password_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Password.Paint
        Call DrawLine(e, TextBox_Password)
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        TextBox_Username.Clear()
        TextBox_Password.Clear()
        Label_Validation.ForeColor = Color.Green
        Label_Validation.Text = "Berhasil Di Reset"
    End Sub

End Class
