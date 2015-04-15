Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class DangNhap

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim ConnectString As String = "workstation id=PS02000.mssql.somee.com;packet size=4096;user id=thangnttps02000_SQLLogin_1;pwd=18101995Aa;data source=PS02000.mssql.somee.com;persist security info=False;initial catalog=PS02000"
        Dim Connect As SqlConnection = New SqlConnection(ConnectString)
        Dim SqlAdapter As New SqlDataAdapter("select * from NhanVien where NhanVien= '" & txtLogin.Text & "' and Matkhau='" & txtPassword.Text & "' ", ConnectString)
        Dim KetQua As New DataTable

        Try
            Connect.Open()
            SqlAdapter.Fill(KetQua)
            If KetQua.Rows.Count > 0 Then
                MessageBox.Show("Đã kết nối thành công!")

                Me.Hide()
                Main.Show()

            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
