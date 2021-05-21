Public Class frmLogin

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtUser.Text <> "" And txtPass.Text <> "" Then
            Module1.inupdel("select count(*)from Login where username='" & txtUser.Text & "','" & txtPass.Text & "'")
            If Module1.nval = 1 Then
                MsgBox("Username and Password invalid")
            Else
                MsgBox("Enter username and password")
            End If
        Else
            MsgBox("Not Inserted")

        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Module1.connect()
    End Sub
End Class