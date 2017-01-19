Imports System.Data.SqlClient
Imports System.Data

Public Class namirnice
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





    Private Sub namirnice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connectToDatabase()
        Dim reader As SqlDataReader

        Dim upit As String
        upit = "update namirnice set meso= '" & TextBox1.Text & "' ,voce= '" & TextBox2.Text & "' ,povrce= '" & TextBox3.Text & "' ,mlijecni_proizvodi= '" & TextBox4.Text & "',higijenske_potrepstine= '" & TextBox5.Text & "',ostalo= '" & TextBox6.Text & "' where namirnica_id=1 "

        cmd = New SqlCommand(upit, conn)
        reader = cmd.ExecuteReader
        MessageBox.Show("Zapis je izmjenjen")
        disconnectDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim da As SqlDataAdapter

        Dim sql As String


        connectToDatabase()
        sql = "select * from namirnice "

        da = New SqlDataAdapter(sql, conn)
        da.Fill(ds, "namirnice")
        TextBox1.Text = ds.Tables("namirnice").Rows(0).Item(1)
        TextBox2.Text = ds.Tables("namirnice").Rows(0).Item(2)
        TextBox3.Text = ds.Tables("namirnice").Rows(0).Item(3)
        TextBox4.Text = ds.Tables("namirnice").Rows(0).Item(4)
        TextBox5.Text = ds.Tables("namirnice").Rows(0).Item(5)
        TextBox6.Text = ds.Tables("namirnice").Rows(0).Item(6)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        poc_zaslon.Show()
    End Sub
End Class