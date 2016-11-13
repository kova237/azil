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

    Private Sub azilanti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_16014_DBDataSet1.azilanti' table. You can move, or remove it, as needed.
        Me.AzilantiTableAdapter1.Fill(Me._16014_DBDataSet1.azilanti)
    End Sub

    Private Sub AzilantiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AzilantiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AzilantiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._16014_DBDataSet)

    End Sub

    Private Sub AzilantiDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AzilantiDataGridView.CellContentClick

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.AzilantiTableAdapter1.FillByName(Me._16014_DBDataSet1.azilanti, TextBox4.Text)


    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Me.AzilantiTableAdapter1.FillBySurname(Me._16014_DBDataSet1.azilanti, TextBox5.Text)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=16014_DB;User ID=16014_User; Password=eY4PSzGY"
        Dim reader As SqlDataReader

        Try
            conn.Open()
            Dim upit As String
            upit = "update azilanti set ime= '" & TextBox6.Text & "' ,prezime= '" & TextBox8.Text & "' ,status= '" & TextBox9.Text & "' ,nacionalnost= '" & TextBox10.Text & "',datum_rođenja= '" & DateTimePicker3.Text & "',datum_dolaska= '" & DateTimePicker2.Text & "',datum_odlaska= '" & DateTimePicker1.Text & "' where azilant_id= '" & TextBox11.Text & "' "

            cmd = New SqlCommand(upit, conn)
            reader = cmd.ExecuteReader
            MessageBox.Show("Zapis je izmjenjen")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=16014_DB;User ID=16014_User; Password=eY4PSzGY"
        Dim reader As SqlDataReader

        Try
            conn.Open()
            Dim upit As String


            Select Case MsgBox("Jeste li sigurni da želite izbrisati?", MsgBoxStyle.YesNoCancel, "caption")
                Case MsgBoxResult.Yes

                    upit = "delete from azilanti where azilant_id= '" & TextBox11.Text & "' "

                    cmd = New SqlCommand(upit, conn)
                    reader = cmd.ExecuteReader
                    MessageBox.Show("Zapis je izbrisan")
                    conn.Close()
                Case MsgBoxResult.No
                Case MsgBoxResult.Cancel
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try

    End Sub
End Class