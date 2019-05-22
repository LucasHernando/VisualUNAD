Imports MySql.Data.MySqlClient

Public Class Elimina
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ProElim As New Persona

        Dim cedula As Integer
        Dim PeId As Boolean = Integer.TryParse(TextBox1.Text, cedula)

        ProElim.eliminarPersona(cedula)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class