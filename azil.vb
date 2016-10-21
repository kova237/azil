Imports System.Data.SqlClient
Imports System.Data


Public Class Form1

    Private da As SqlDataAdapter
    Private conn As New SqlConnection
    Private conStr As String = "Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=16014_DB;User ID=16014_User; Password=eY4PSzGY"
    Private cmd As SqlCommand
    Private sql As String


    Private Sub connection()

        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = conStr
            conn.Open()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        connection()
        sql = "Select * from login Where korisničko_ime= '" & txtUsername.Text & "' And lozinka='" & txtPassword.Text & "' "
        da = New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds, "login")
        If txtUsername.Text = "" Then
            MsgBox("Unesite korisničko ime")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Unesite lozinku")
        Else
            If ds.Tables("login").Rows.Count <> 0 Then

                Form2.Show()
                Me.Hide()
            Else
                MsgBox("Neuspješno logiranje")
            End If
            
            End If
            conn.Close()

    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        Me.Close()

    End Sub
End Class
