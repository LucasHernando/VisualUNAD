Imports MySql.Data.MySqlClient

Public Class Persona

    Dim Servidor As String = "127.0.0.1"
    Dim Usuario As String = "root"
    Dim Base As String = "curso_unad"
    Dim Contraseña As String = ""


    Public Sub IngresoPersona(ByVal pTipDoc As String, pDocumento As Integer, pPnombre As String,
                       pSnombre As String, pPapellido As String, pSapellido As String,
                       pTelefono As Integer, pCorreo As String, pContraseña As String, pRcontraseña As String)

        Try
            Conexion = New MySqlConnection
            Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "
            Dim readMysql As MySqlDataReader

            Conexion.Open()

            Dim IngPersona = "INSERT INTO curso_unad.personas (tipo_personas,id_persona,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,telefono_personas,correo_personas,contrasena,re_contrasena) VALUES ('" & pTipDoc & "','" & pDocumento & "','" & pPnombre & "','" & pSnombre & "','" & pPapellido & "','" & pSapellido & "','" & pTelefono & "','" & pCorreo & "','" & pContraseña & "','" & pRcontraseña & "')"

            Dim insert = New MySqlCommand(IngPersona, Conexion)
            readMysql = insert.ExecuteReader
            Conexion.Clone()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

        MessageBox.Show("La persona ha sido ingresada en el sistema")

    End Sub

    Public Sub ActualizaPersona(ByVal pContraseña As String, pRecontraseña As String, pId As Integer)
        Try
            Conexion = New MySqlConnection
            Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "
            Dim readMysql As MySqlDataReader

            Conexion.Open()

            Dim ActPersona = "UPDATE curso_unad.personas SET contrasena='" & pContraseña & "',re_contrasena'" & pRecontraseña & "' WHERE id_persona="

            Dim Update = New MySqlCommand(ActPersona, Conexion)
            readMysql = Update.ExecuteReader
            Conexion.Clone()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

        MessageBox.Show("La persona ha sido persona ha sido ha sido actualizada en el sistema")

    End Sub

    Public Sub Consultar(ByVal pId As Integer)
        Dim ConsulPersona = New Form4()

        Try
            Conexion = New MySqlConnection
            Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "


            Conexion.Open()

            Dim ActPersona = "SELECT * FROM personas  WHERE id_persona='" & pId & "'"

            Dim Update = New MySqlCommand(ActPersona, Conexion)

            Dim readMysql As MySqlDataReader
            readMysql = Update.ExecuteReader
            If readMysql.Read() Then



                ConsulPersona.ComboBox2.Text = readMysql.Item("tipo_personas").ToString()
                ConsulPersona.TextBox1.Text = readMysql.Item("id_persona").ToString()
                ConsulPersona.TextBox2.Text = readMysql.Item("primer_nombre").ToString()
                ConsulPersona.TextBox3.Text = readMysql.Item("segundo_nombre").ToString()
                ConsulPersona.TextBox4.Text = readMysql.Item("primer_apellido").ToString()
                ConsulPersona.TextBox5.Text = readMysql.Item("segundo_apellido").ToString()
                ConsulPersona.TextBox6.Text = readMysql.Item("telefono_personas").ToString()
                ConsulPersona.TextBox7.Text = readMysql.Item("correo_personas").ToString()

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



    Public Function Autentificacion(ByVal pUsuario As Integer, pContraseña As String)
        Dim AutUsuarios As String
        Dim AutContraseña As String
        Dim Valida As Boolean

        Valida = False

        Try
            Conexion = New MySqlConnection
            Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "


            Conexion.Open()

            Dim AutUsuario = "SELECT * FROM personas  WHERE id_persona='" & pUsuario & "'"

            Dim Verifica = New MySqlCommand(AutUsuario, Conexion)

            Dim readMysql As MySqlDataReader
            readMysql = Verifica.ExecuteReader
            If readMysql.Read() Then

                AutUsuarios = readMysql.GetInt64("id_persona")
                AutContraseña = readMysql.GetString("contrasena")


                If AutUsuarios = pUsuario And AutContraseña = pContraseña Then
                    Valida = True
                Else
                    MessageBox.Show("El Usuario o contraseña no son correctos")
                End If

            Else
                MessageBox.Show("La Persona no ha sdo encontrada en el sistema")
            End If
            readMysql.Close()
            Conexion.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

        Return Valida
    End Function

    Public Function eliminarPersona(ByVal pId As Integer)
        Dim valiElim As Boolean
        Try
            Conexion = New MySqlConnection
            Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "

            valiElim = False

            Conexion.Open()

            Dim DetPersona = "DELETE FROM personas WHERE id_persona='" & pId & "'"

            Dim Delete = New MySqlCommand(DetPersona, Conexion)
            'Dim readMysql As MySqlDataReader
            'readMysql = Delete.ExecuteReader


            Dim i As Integer = Delete.ExecuteNonQuery()
            If (i > 0) Then
                valiElim = True
                MessageBox.Show("La persona ha sido eliminada")
            Else
                MessageBox.Show("La persona no se encuentra")
            End If

            Conexion.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

        Return valiElim

    End Function
End Class
