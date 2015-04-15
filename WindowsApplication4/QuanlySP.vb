Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class QuanlySP

    Private Sub QuanlySP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ConnectString As String = "workstation id=PS02000.mssql.somee.com;packet size=4096;user id=thangnttps02000_SQLLogin_1;pwd=18101995Aa;data source=PS02000.mssql.somee.com;persist security info=False;initial catalog=PS02000"
    Dim Connect As SqlConnection = New SqlConnection(ConnectString)
        Dim SqlAdapter As New SqlDataAdapter("select * from SanPham", ConnectString)
        Dim KetQua As New DataTable


        Try
            Connect.Open()
            SqlAdapter.Fill(KetQua)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = KetQua
        Connect.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaSP.Text = DataGridView1.Item(0, index).Value
        txtTenSP.Text = DataGridView1.Item(1, index).Value
        txtDongia.Text = DataGridView1.Item(2, index).Value
        txtSoluong.Text = DataGridView1.Item(3, index).Value
        txtchitiet.Text = DataGridView1.Item(4, index).Value
        txtloaisp.Text = DataGridView1.Item(5, index).Value
    End Sub

    
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

    End Sub
End Class