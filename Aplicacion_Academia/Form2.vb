Public Class Form2
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim PersonaAut As New Persona()

        Dim id_persona As Integer
        Dim blnCel As Boolean = Integer.TryParse(TextBox1.Text, id_persona)

        If PersonaAut.Autentificacion(id_persona, TextBox2.Text) = True Then

            Dim iniForm As New Form_principal()
            iniForm.Show()

        Else
            Return
        End If

    End Sub
End Class