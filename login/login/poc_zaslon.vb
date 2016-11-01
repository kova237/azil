Public Class poc_zaslon

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        djelatnici.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        azilanti.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        namirnice.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class