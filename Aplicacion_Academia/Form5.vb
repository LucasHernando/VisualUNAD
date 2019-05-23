Public Class Form5
    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim acumula As Integer
        Dim respuesta1 As Char
        Dim respuesta2 As Char
        Dim respuesta3 As Char
        Dim respuesta4 As Char
        Dim respuesta5 As Char
        Dim respuesta6 As Char
        Dim respuesta7 As Char
        Dim respuesta8 As Char
        Dim respuesta9 As Char
        Dim respuesta10 As Char
        acumula = 0

        respuesta1 = "INCORRECTA"
        respuesta2 = "INCORRECTA"
        respuesta3 = "INCORRECTA"
        respuesta4 = "INCORRECTA"
        respuesta5 = "INCORRECTA"
        respuesta6 = "INCORRECTA"
        respuesta7 = "INCORRECTA"
        respuesta8 = "INCORRECTA"
        respuesta9 = "INCORRECTA"
        respuesta10 = "INCORRECTA"


        If Op1a.Checked = True And Op1b.Checked = True And Op1d.Checked = True Then
            acumula = acumula + 0
            respuesta1 = "INCORRECTA"

        End If
        If Op1c.Checked = True Then
            acumula = acumula + 1
            respuesta1 = "CORRECTA"
        End If

        If Op2a.Checked = True And Op2b.Checked = True And Op2c.Checked = True Then
            acumula = acumula + 0
            respuesta2 = "INCORRECTA"
        End If
        If Op2d.Checked = True Then
            acumula = acumula + 1
            respuesta2 = "CORRECTA"
        End If

        If Op3a.Checked = True And Op3b.Checked = True And Op3c.Checked = True Then
            acumula = acumula + 0
            respuesta3 = "INCORRECTA"
        End If
        If Op3d.Checked = True Then
            acumula = acumula + 1
            respuesta3 = "CORRECTA"
        End If

        If Op4a.Checked = True And Op4b.Checked = True And Op4c.Checked = True Then
            acumula = acumula + 0
            respuesta4 = "INCORRECTA"
        End If
        If Op4d.Checked = True Then
            acumula = acumula + 1
            respuesta4 = "CORRECTA"
        End If

        If Op5b.Checked = True And Op5c.Checked = True And Op5d.Checked = True Then
            acumula = acumula + 0
            respuesta5 = "INCORRECTA"
        End If
        If Op5a.Checked = True Then
            acumula = acumula + 1
            respuesta5 = "CORRECTA"
        End If

        If Op6a.Checked = True And Op6c.Checked = True And Op6d.Checked = True Then
            acumula = acumula + 0
            respuesta6 = "INCORRECTA"
        End If
        If Op6b.Checked = True Then
            acumula = acumula + 1
            respuesta6 = "CORRECTA"
        End If

        If Op7a.Checked = True And Op7b.Checked = True And Op7d.Checked = True Then
            acumula = acumula + 0
            respuesta7 = "INCORRECTA"
        End If
        If Op7c.Checked = True Then
            acumula = acumula + 1
            respuesta7 = "CORRECTA"
        End If

        If Op8a.Checked = True And Op8c.Checked = True And Op8d.Checked = True Then
            acumula = acumula + 0
            respuesta8 = "INCORRECTA"
        End If
        If Op8b.Checked = True Then
            acumula = acumula + 1
            respuesta8 = "CORRECTA"
        End If

        If Op9a.Checked = True And Op9b.Checked = True And Op9c.Checked = True Then
            acumula = acumula + 0
            respuesta9 = "INCORRECTA"
        End If
        If Op9d.Checked = True Then
            acumula = acumula + 1
            respuesta9 = "CORRECTA"
        End If

        If Op10b.Checked = True And Op10c.Checked = True And Op10d.Checked = True Then
            acumula = acumula + 0
            respuesta10 = "INCORRECTA"
        End If
        If Op10a.Checked = True Then
            acumula = acumula + 1
            respuesta10 = "CORRECTA"
        End If

        resultado.Text = acumula


        Op1a.Enabled = False
        Op1b.Enabled = False
        Op1c.Enabled = False
        Op1d.Enabled = False

        Op2a.Enabled = False
        Op2b.Enabled = False
        Op2c.Enabled = False
        Op2d.Enabled = False

        Op3a.Enabled = False
        Op3b.Enabled = False
        Op3c.Enabled = False
        Op3d.Enabled = False

        Op4a.Enabled = False
        Op4b.Enabled = False
        Op4c.Enabled = False
        Op4d.Enabled = False

        Op5a.Enabled = False
        Op5b.Enabled = False
        Op5c.Enabled = False
        Op5d.Enabled = False

        Op6a.Enabled = False
        Op6b.Enabled = False
        Op6c.Enabled = False
        Op6d.Enabled = False

        Op7a.Enabled = False
        Op7b.Enabled = False
        Op7c.Enabled = False
        Op7d.Enabled = False

        Op8a.Enabled = False
        Op8b.Enabled = False
        Op8c.Enabled = False
        Op8d.Enabled = False

        Op9a.Enabled = False
        Op9b.Enabled = False
        Op9c.Enabled = False
        Op9d.Enabled = False

        Op10a.Enabled = False
        Op10b.Enabled = False
        Op10c.Enabled = False
        Op10d.Enabled = False


        Label46.Visible = True
        Label46.Text = respuesta1

        Label45.Visible = True
        Label45.Text = respuesta2

        Label44.Visible = True
        Label44.Text = respuesta3

        Label43.Visible = True
        Label43.Text = respuesta4

        Label42.Visible = True
        Label42.Text = respuesta5

        Label41.Visible = True
        Label41.Text = respuesta6

        Label40.Visible = True
        Label40.Text = respuesta7

        Label39.Visible = True
        Label39.Text = respuesta8

        Label38.Visible = True
        Label38.Text = respuesta9

        Label37.Visible = True
        Label37.Text = respuesta10


        If acumula < 6 Then
            Dim diaologo As DialogResult = MessageBox.Show("Has perdido la evaluacion, intenta de nuevo")
            Button2.Enabled = False
        ElseIf acumula > 6 And acumula < 9 Then
            Dim diaologo As DialogResult = MessageBox.Show("Has pasado la evaluacion, procede al siguiente nivel")
            Button2.Enabled = True
        ElseIf acumula = 10 Then
            Dim diaologo As DialogResult = MessageBox.Show("Exelente evaluacion, procede")
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Op1a.Checked = False
        Op1b.Checked = False
        Op1c.Checked = False
        Op1d.Checked = False

        Op2a.Checked = False
        Op2b.Checked = False
        Op2c.Checked = False
        Op2d.Checked = False

        Op3a.Checked = False
        Op3b.Checked = False
        Op3c.Checked = False
        Op3d.Checked = False

        Op4a.Checked = False
        Op4b.Checked = False
        Op4c.Checked = False
        Op4d.Checked = False

        Op5a.Checked = False
        Op5b.Checked = False
        Op5c.Checked = False
        Op5d.Checked = False

        Op6a.Checked = False
        Op6b.Checked = False
        Op6c.Checked = False
        Op6d.Checked = False

        Op7a.Checked = False
        Op7b.Checked = False
        Op7c.Checked = False
        Op7d.Checked = False

        Op8a.Checked = False
        Op8b.Checked = False
        Op8c.Checked = False
        Op8d.Checked = False

        Op9a.Checked = False
        Op9b.Checked = False
        Op9c.Checked = False
        Op9d.Checked = False

        Op10a.Checked = False
        Op10b.Checked = False
        Op10c.Checked = False
        Op10d.Checked = False

        Op1a.Enabled = True
        Op1b.Enabled = True
        Op1c.Enabled = True
        Op1d.Enabled = True

        Op2a.Enabled = True
        Op2b.Enabled = True
        Op2c.Enabled = True
        Op2d.Enabled = True

        Op3a.Enabled = True
        Op3b.Enabled = True
        Op3c.Enabled = True
        Op3d.Enabled = True

        Op4a.Enabled = True
        Op4b.Enabled = True
        Op4c.Enabled = True
        Op4d.Enabled = True

        Op5a.Enabled = True
        Op5b.Enabled = True
        Op5c.Enabled = True
        Op5d.Enabled = True

        Op6a.Enabled = True
        Op6b.Enabled = True
        Op6c.Enabled = True
        Op6d.Enabled = True

        Op7a.Enabled = True
        Op7b.Enabled = True
        Op7c.Enabled = True
        Op7d.Enabled = True

        Op8a.Enabled = True
        Op8b.Enabled = True
        Op8c.Enabled = True
        Op8d.Enabled = True

        Op9a.Enabled = True
        Op9b.Enabled = True
        Op9c.Enabled = True
        Op9d.Enabled = True

        Op10a.Enabled = True
        Op10b.Enabled = True
        Op10c.Enabled = True
        Op10d.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Dim acumula As Integer
        Dim respuesta1 As Char
        Dim respuesta2 As Char
        Dim respuesta3 As Char
        Dim respuesta4 As Char
        Dim respuesta5 As Char
        Dim respuesta6 As Char
        Dim respuesta7 As Char
        Dim respuesta8 As Char
        Dim respuesta9 As Char
        Dim respuesta10 As Char
        acumula = 0

        respuesta1 = "INCORRECTA"
        respuesta2 = "INCORRECTA"
        respuesta3 = "INCORRECTA"
        respuesta4 = "INCORRECTA"
        respuesta5 = "INCORRECTA"
        respuesta6 = "INCORRECTA"
        respuesta7 = "INCORRECTA"
        respuesta8 = "INCORRECTA"
        respuesta9 = "INCORRECTA"
        respuesta10 = "INCORRECTA"


        If Op1a.Checked = True And Op1b.Checked = True And Op1d.Checked = True Then
            acumula = acumula + 0
            respuesta1 = "INCORRECTA"

        End If
        If Op1c.Checked = True Then
            acumula = acumula + 1
            respuesta1 = "CORRECTA"
        End If

        If Op2a.Checked = True And Op2b.Checked = True And Op2c.Checked = True Then
            acumula = acumula + 0
            respuesta2 = "INCORRECTA"
        End If
        If Op2d.Checked = True Then
            acumula = acumula + 1
            respuesta2 = "CORRECTA"
        End If

        If Op3a.Checked = True And Op3b.Checked = True And Op3c.Checked = True Then
            acumula = acumula + 0
            respuesta3 = "INCORRECTA"
        End If
        If Op3d.Checked = True Then
            acumula = acumula + 1
            respuesta3 = "CORRECTA"
        End If

        If Op4a.Checked = True And Op4b.Checked = True And Op4c.Checked = True Then
            acumula = acumula + 0
            respuesta4 = "INCORRECTA"
        End If
        If Op4d.Checked = True Then
            acumula = acumula + 1
            respuesta4 = "CORRECTA"
        End If

        If Op5b.Checked = True And Op5c.Checked = True And Op5d.Checked = True Then
            acumula = acumula + 0
            respuesta5 = "INCORRECTA"
        End If
        If Op5a.Checked = True Then
            acumula = acumula + 1
            respuesta5 = "CORRECTA"
        End If

        If Op6a.Checked = True And Op6c.Checked = True And Op6d.Checked = True Then
            acumula = acumula + 0
            respuesta6 = "INCORRECTA"
        End If
        If Op6b.Checked = True Then
            acumula = acumula + 1
            respuesta6 = "CORRECTA"
        End If

        If Op7a.Checked = True And Op7b.Checked = True And Op7d.Checked = True Then
            acumula = acumula + 0
            respuesta7 = "INCORRECTA"
        End If
        If Op7c.Checked = True Then
            acumula = acumula + 1
            respuesta7 = "CORRECTA"
        End If

        If Op8a.Checked = True And Op8c.Checked = True And Op8d.Checked = True Then
            acumula = acumula + 0
            respuesta8 = "INCORRECTA"
        End If
        If Op8b.Checked = True Then
            acumula = acumula + 1
            respuesta8 = "CORRECTA"
        End If

        If Op9a.Checked = True And Op9b.Checked = True And Op9c.Checked = True Then
            acumula = acumula + 0
            respuesta9 = "INCORRECTA"
        End If
        If Op9d.Checked = True Then
            acumula = acumula + 1
            respuesta9 = "CORRECTA"
        End If

        If Op10b.Checked = True And Op10c.Checked = True And Op10d.Checked = True Then
            acumula = acumula + 0
            respuesta10 = "INCORRECTA"
        End If
        If Op10a.Checked = True Then
            acumula = acumula + 1
            respuesta10 = "CORRECTA"
        End If

        resultado.Text = acumula


        Op1a.Enabled = False
        Op1b.Enabled = False
        Op1c.Enabled = False
        Op1d.Enabled = False

        Op2a.Enabled = False
        Op2b.Enabled = False
        Op2c.Enabled = False
        Op2d.Enabled = False

        Op3a.Enabled = False
        Op3b.Enabled = False
        Op3c.Enabled = False
        Op3d.Enabled = False

        Op4a.Enabled = False
        Op4b.Enabled = False
        Op4c.Enabled = False
        Op4d.Enabled = False

        Op5a.Enabled = False
        Op5b.Enabled = False
        Op5c.Enabled = False
        Op5d.Enabled = False

        Op6a.Enabled = False
        Op6b.Enabled = False
        Op6c.Enabled = False
        Op6d.Enabled = False

        Op7a.Enabled = False
        Op7b.Enabled = False
        Op7c.Enabled = False
        Op7d.Enabled = False

        Op8a.Enabled = False
        Op8b.Enabled = False
        Op8c.Enabled = False
        Op8d.Enabled = False

        Op9a.Enabled = False
        Op9b.Enabled = False
        Op9c.Enabled = False
        Op9d.Enabled = False

        Op10a.Enabled = False
        Op10b.Enabled = False
        Op10c.Enabled = False
        Op10d.Enabled = False


        Label46.Visible = True
        Label46.Text = respuesta1

        Label45.Visible = True
        Label45.Text = respuesta2

        Label44.Visible = True
        Label44.Text = respuesta3

        Label43.Visible = True
        Label43.Text = respuesta4

        Label42.Visible = True
        Label42.Text = respuesta5

        Label41.Visible = True
        Label41.Text = respuesta6

        Label40.Visible = True
        Label40.Text = respuesta7

        Label39.Visible = True
        Label39.Text = respuesta8

        Label38.Visible = True
        Label38.Text = respuesta9

        Label37.Visible = True
        Label37.Text = respuesta10


        If acumula < 6 Then
            Dim diaologo As DialogResult = MessageBox.Show("Has perdido la evaluacion, intenta de nuevo")
            Button2.Enabled = False
        ElseIf acumula > 6 And acumula < 9 Then
            Dim diaologo As DialogResult = MessageBox.Show("Has pasado la evaluacion, procede al siguiente nivel")
            Button2.Enabled = True
        ElseIf acumula = 10 Then
            Dim diaologo As DialogResult = MessageBox.Show("Exelente evaluacion, procede")
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label53.Text += 1
        If Label53.Text = "60" Then
            Label54.Text += 1
            Label53.Text = "00"
        End If

        If Label54.Text = "3" And Label53.Text = "00" Then
            Timer1.Stop()
            Dim diaologo As DialogResult = MessageBox.Show("Lo sentimos la evaluacion no fie realizada en el tiempo estipulado")
            Close()
        End If


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class