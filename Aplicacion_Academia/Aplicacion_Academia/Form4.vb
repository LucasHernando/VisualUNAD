<<<<<<< HEAD
﻿Imports MySql.Data.MySqlClient
=======
﻿Imports Libreria.Libreria
>>>>>>> 2001f5f3988032497ea1fc0cafa26b7536a85e5d


Public Class Form4
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

<<<<<<< HEAD


        If TextBox8.Text = TextBox9.Text Then

            Dim telefono As Integer
            Dim blnTel As Boolean = Integer.TryParse(TextBox1.Text, telefono)

            Dim cedula As Integer
            Dim blnCel As Boolean = Integer.TryParse(TextBox1.Text, cedula)


            Dim Persona As New Persona()
            Persona.IngresoPersona(ComboBox2.Text, cedula, TextBox2.Text, TextBox3.Text, TextBox4.Text,
                               TextBox5.Text, telefono, TextBox7.Text, TextBox8.Text, TextBox9.Text)
        Else
            MessageBox.Show("La constraseñas no conciden, intente de nuevo")
        End If



=======
        Dim tra As New Libreria.Libreria()

        Dim telefono As Integer
        Dim blnTel As Boolean = Integer.TryParse(TextBox1.Text, telefono)

        Dim cedula As Integer
        Dim blnCel As Boolean = Integer.TryParse(TextBox1.Text, cedula)


        tra.IngresoPersona(ComboBox2.Text, cedula, TextBox2.Text, TextBox3.Text, TextBox4.Text,
                           TextBox5.Text, telefono, TextBox7.Text, TextBox8.Text, TextBox9.Text)
>>>>>>> 2001f5f3988032497ea1fc0cafa26b7536a85e5d
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
<<<<<<< HEAD

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim PersonaBusca As New Persona()

        Dim cedula As Integer
        Dim blnCel As Boolean = Integer.TryParse(TextBox1.Text, cedula)


        Dim Servidor As String = "127.0.0.1"
        Dim Usuario As String = "root"
        Dim Base As String = "curso_unad"
        Dim Contraseña As String = ""

        TextBox8.Visible = False
        TextBox9.Visible = False
        'PersonaBusca.Consultar(cedula)

        Try
            Conexion = New MySqlConnection
            Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "


            Conexion.Open()

            Dim ActPersona = "SELECT * FROM personas  WHERE id_persona='" & cedula & "'"

            Dim Update = New MySqlCommand(ActPersona, Conexion)

            Dim readMysql As MySqlDataReader
            readMysql = Update.ExecuteReader
            If readMysql.Read() Then



                Me.ComboBox2.Text = readMysql.Item("tipo_personas").ToString()
                Me.TextBox1.Text = readMysql.Item("id_persona").ToString()
                Me.TextBox2.Text = readMysql.Item("primer_nombre").ToString()
                Me.TextBox3.Text = readMysql.Item("segundo_nombre").ToString()
                Me.TextBox4.Text = readMysql.Item("primer_apellido").ToString()
                Me.TextBox5.Text = readMysql.Item("segundo_apellido").ToString()
                Me.TextBox6.Text = readMysql.Item("telefono_personas").ToString()
                Me.TextBox7.Text = readMysql.Item("correo_personas").ToString()
                'ConsulPersona.TextBox8.Text = readMysql("contraseña").ToString()
                'ConsulPersona.TextBox9.Text = readMysql("re_contraseña").ToString()

            Else
                MessageBox.Show("La Persona no ha sdo encontrada en el sistema")
            End If
            readMysql.Close()
            Conexion.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
=======
>>>>>>> 2001f5f3988032497ea1fc0cafa26b7536a85e5d
End Class