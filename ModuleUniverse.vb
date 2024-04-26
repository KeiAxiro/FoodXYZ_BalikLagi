Imports System.Data.Common
Imports System.Data.SqlClient

Module ModuleUniverse

    Public Conn As SqlConnection
    Public Cmd As SqlCommand
    Public Srd As SqlDataReader
    Public Sda As SqlDataAdapter
    Public Ds As DataSet

    Public Sub Koneksi()
        Dim MyDB As String = "Data Source=desktop-ig5qtru\sqlexpress;User ID=keidjaru;Password=kei;Initial Catalog=DB_FOODXYZ;Connect Timeout=30;Encrypt=False;"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
    Public Sub DrawLine(e As PaintEventArgs, obj As Control)
        Dim Pen As New Pen(Color.Black, 2)
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(obj.Location.X, obj.Bottom), New Point(obj.Location.X + obj.Size.Width, obj.Bottom))
        End Using
    End Sub
    Public Sub WriteLog(Akt As String, Id_User As Integer)
        Call Koneksi()
        Dim InsertDataLog As String = "INSERT INTO tbl_log(waktu,aktivitas,id_user) VALUES(@_waktu,@_aktivitas,@_id_user)"
        Cmd = New SqlCommand(InsertDataLog, Conn)
        Cmd.Parameters.AddWithValue("@_waktu", DateTime.Now)
        Cmd.Parameters.AddWithValue("@_aktivitas", Akt)
        Cmd.Parameters.AddWithValue("@_id_user", Id_User)

        Cmd.BeginExecuteNonQuery()
    End Sub
    Public Sub Switch_Panel(ParentPanel As Panel, NewUserControl As UserControl)
        ParentPanel.Controls.Clear()
        NewUserControl.BringToFront()
        NewUserControl.Dock = DockStyle.Fill
        ParentPanel.Controls.Add(NewUserControl)
    End Sub
End Module
