Public Class frmCustomer

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtid.Text <> "" And txtnm.Text <> "" And txtphno.Text <> "" And txtemail.Text <> "" And txtadd.Text <> "" Then
            Module1.inupdel("insert into Customer values(" & CInt(txtid.Text) & ",'" & txtnm.Text & "','" & txtphno.Text & "','" & txtemail.Text & "','" & txtadd.Text & "')")
            MsgBox("Data Inserted")
        Else
            MsgBox("Data not Inserted")
        End If
    End Sub


    Private Sub frmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Module1.connect()
    End Sub

    Private Sub txtadd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtadd.GotFocus
        Dim f As Boolean
        f = Module1.validateEmail(txtemail.Text)
        If f = False Then
            MsgBox("Enter valid Email", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
            txtemail.Select()
        End If
        txtadd.Clear()
    End Sub

    Private Sub txtnm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnm.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = " " Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            'nothing to do valid character
        Else
            e.KeyChar = ""
            txtnm.Select()
            MsgBox("Enter only Alphabets", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub txtphno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphno.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Convert.ToChar(Keys.Back) Then

        Else
            e.KeyChar = ""
            txtphno.Select()
            MsgBox("Enter only Numbers", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub txtphno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtphno.Leave
        Try

            If txtphno.Text.Substring(0, 1) >= 7 And txtphno.Text.Length = 10 Then

            Else

                txtphno.Select()
                MsgBox("Enter valid mobile", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class