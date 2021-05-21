Imports System.Text.RegularExpressions
Imports System.data.OleDb

Module Module1
    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public nval As Integer
    Public adpt As OleDbDataAdapter

    Public Sub connect()

        '  If con.State = ConnectionState.Open Then
        'con.Close()

        '  End If
        'con.Open()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Boht Hard\Pizza Hut\Pizza Hut\Database\Pizza Hut.mdb"
        con.Open()
        'MsgBox("Connected")

    End Sub

    Public Sub inupdel(ByVal q As String)
        cmd = New OleDbCommand(q, con)

        nval = cmd.ExecuteScalar
        Try

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Public Function validateEmail(ByVal emailAddress) As Boolean
        ' Dim email As New Regex("^(?[^@]+)@(?.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
End Module


