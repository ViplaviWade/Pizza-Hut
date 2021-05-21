Public Class frmImage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        frmLogin.Show()


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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'frmCustomer .Show 
        frmLogin.Select()
    End Sub

    Private Sub frmImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
