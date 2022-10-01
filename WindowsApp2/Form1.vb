Imports System.Data.SqlClient

Public Class Form1
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        Me.Close()
    End Sub
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            baglan.ConnectionString = "Data Source=DESKTOP-HNPHR2I,1453;Network Library=DBMSSOCN;MultipleActiveResultSets=True;  initial catalog=deneme;User ID=sa;Password=1453"
            baglan.Open()
            bilgi.Text = "bağlantı yapıldı"

        Catch ex As Exception
            bilgi.Text = "baglantı yok"
        End Try
        Veri()
    End Sub

    Sub Veri()
        cmd.Parameters.Clear()
        ds.Reset()
        cmd.CommandText = "select * from deneme"
        cmd.Connection = baglan
        adp.SelectCommand = cmd
        adp.Fill(ds, "veriler")
        DataGridView1.DataSource = ds.Tables("veriler")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        baglan.Close()

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Form2.Show()


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Form3.Label4.Text = DataGridView1.CurrentRow.Cells("id").Value
        Form3.urunad.Text = DataGridView1.CurrentRow.Cells("urunad").Value
        Form3.marka.Text = DataGridView1.CurrentRow.Cells("marka").Value
        Form3.ısbnkod.Text= DataGridView1.CurrentRow.Cells("ısbnkod").Value

        Form3.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        cmd.Parameters.Clear()
        cmd.CommandText = "delete from deneme where id=@id"
        cmd.Connection = baglan
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = DataGridView1.CurrentRow.Cells("id").Value
        cmd.ExecuteNonQuery()
        Veri()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
