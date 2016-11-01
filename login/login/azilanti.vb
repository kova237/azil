Imports System.Data.SqlClient
Imports System.Data


Public Class azilanti


    Dim conn As SqlConnection
    Dim cmd As SqlCommand



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conn = New SqlConnection
        conn.ConnectionString = "Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=16014_DB;User ID=16014_User; Password=eY4PSzGY"
        Dim reader As SqlDataReader

        Try
            conn.Open()
            Dim upit As String
            upit = "insert into azilanti (ime,prezime,status,nacionalnost,datum_rođenja,datum_dolaska,datum_odlaska) values ('" & TextBox1.Text & "' ,'" & TextBox2.Text & "' ,'" & TextBox7.Text & "' ,'" & TextBox3.Text & "','" & datum_rođenja.Text & "','" & datum_dolaska.Text & "','" & datum_odlaska.Text & "' )"

            cmd = New SqlCommand(upit, conn)
            reader = cmd.ExecuteReader
            MessageBox.Show("Zapis je spremljen")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox2.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        poc_zaslon.Show()

    End Sub
End Class