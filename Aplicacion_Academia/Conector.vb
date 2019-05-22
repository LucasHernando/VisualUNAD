Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Module Conector

    Public Conexion As MySqlConnection

    Public Sub conexion_db()

        Dim Servidor As String = "127.0.0.1"
        Dim Usuario As String = "root"
        Dim Base As String = "curso_unad"
        Dim Contraseña As String = ""


        Try
            Conexion = New MySqlConnection
            Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "
            Conexion.Open()



            If Conexion.State = ConnectionState.Open Then

                MessageBox.Show("Conexion establecida")
            Else
                MessageBox.Show("Conexion no establecida")
            End If


        Catch ex As Exception
            MessageBox.Show(Err.Description)

        End Try

    End Sub



End Module
