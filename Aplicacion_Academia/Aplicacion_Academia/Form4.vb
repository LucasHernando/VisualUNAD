Imports Libreria.Libreria


Public Class Form4
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim tra As New Libreria.Libreria()

        Dim telefono As Integer
        Dim blnTel As Boolean = Integer.TryParse(TextBox1.Text, telefono)

        Dim cedula As Integer
        Dim blnCel As Boolean = Integer.TryParse(TextBox1.Text, cedula)


        tra.IngresoPersona(ComboBox2.Text, cedula, TextBox2.Text, TextBox3.Text, TextBox4.Text,
                           TextBox5.Text, telefono, TextBox7.Text, TextBox8.Text, TextBox9.Text)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class