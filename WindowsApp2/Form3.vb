Imports System.Data.SqlClient
Imports System.Reflection.Emit
Public Class Form3

    Dim cmd1 As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd1.Parameters.Clear()
        cmd1.CommandText = "update deneme set urunad=@urunad,marka=@marka,ısbnkod=@ısbnkod where id=@id"
        cmd1.Connection = baglan
        cmd1.Parameters.Add("@urunad", SqlDbType.VarChar).Value = urunad.Text
        cmd1.Parameters.Add("@marka", SqlDbType.VarChar).Value = marka.Text
        cmd1.Parameters.Add("@ısbnkod", SqlDbType.Int).Value = ısbnkod.Text
        cmd1.Parameters.Add("@id", SqlDbType.Int).Value = Label4.Text
        cmd1.ExecuteNonQuery()
        Form1.Veri()

        Me.Close()

    End Sub
End Class