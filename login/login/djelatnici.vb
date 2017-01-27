Imports System.Data.SqlClient
Imports System.Data


Public Class djelatnici

    Public Shared korime As String

    Dim conn As SqlConnection
    Dim cmd As SqlCommand

    Sub connectToDatabase()
        conn = New SqlConnection(
            "Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=16014_DB;User ID=16014_User; Password=eY4PSzGY")
        conn.Open()

    End Sub

    Sub disconnectDatabase()
        conn.Close()

    End Sub
    Private Sub djelatnici_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            MsgBox("Unesite djelatnikov ID")
        ElseIf IsNumeric(TextBox4.Text) Then
        Else
            MsgBox("Djelatnikov ID može biti samo broj")
            TextBox4.Clear()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connectToDatabase()
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        If IsNumeric(TextBox4.Text) Then


            cmd.CommandText = "Select ime from djelatnici where djelatnik_id='" & TextBox4.Text & "'"

            TextBox1.Text = cmd.ExecuteScalar

            cmd.CommandText = "Select prezime from djelatnici where djelatnik_id='" & TextBox4.Text & "'"

            TextBox2.Text = cmd.ExecuteScalar

            cmd.CommandText = "Select broj_odrađenih_sati from djelatnici where djelatnik_id='" & TextBox4.Text & "'"

            TextBox3.Text = cmd.ExecuteScalar

            If TextBox1.Text = "" Then
                MsgBox("Ne postoji djelatnik s tim ID brojem")
            End If
            disconnectDatabase()
        Else
            MsgBox("Djelatnikov ID može biti samo broj")
        End If

        disconnectDatabase()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connectToDatabase()
        Dim reader As SqlDataReader

        If korime = "ivan" Or korime = "maja" Then
            If IsNumeric(TextBox4.Text) Then
                Try

                    Dim upit As String
                    upit = "update djelatnici set broj_odrađenih_sati= '" & TextBox3.Text & "' where djelatnik_id='" & TextBox4.Text & "' "

                    cmd = New SqlCommand(upit, conn)
                    reader = cmd.ExecuteReader
                    If TextBox1.Text = "" Then
                        MsgBox("Nema djelatnika pod tim ID brojem")
                    Else

                        MessageBox.Show("Zapis je izmjenjen")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    disconnectDatabase()

                End Try
            Else
                MsgBox("Djelatnikov ID može biti samo broj")

            End If

        Else
            MessageBox.Show("niste ovlašteni za mijenjanje broja odrađenih sati")
        End If
        disconnectDatabase()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        poc_zaslon.Show()
    End Sub
End Class