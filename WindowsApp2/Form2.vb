Imports System.Data.SqlClient
Public Class Form2

    Dim cmd1 As New SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(ısbn.Text) = False Then
            MsgBox("sayı gir")
            Exit Sub
        End If
        MessageBox.Show("gırıs")


        cmd1.Parameters.Clear()
        cmd1.CommandText = "insert into deneme (urunad,marka,ısbnkod) values (@urunad,@marka,@ısbnkod)"
        cmd1.Connection = baglan
        cmd1.Parameters.Add("@urunad", SqlDbType.VarChar).Value = urunad.Text
        cmd1.Parameters.Add("@marka", SqlDbType.VarChar).Value = marka.Text
        cmd1.Parameters.Add("@ısbnkod", SqlDbType.VarChar).Value = ısbn.Text
        cmd1.ExecuteNonQuery()
        Form1.Veri()
        Me.Close()
    End Sub
End Class


