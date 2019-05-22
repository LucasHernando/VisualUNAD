Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Libreria




    Public Sub IngresoPersona(ByVal pTipDoc As String, pDocumento As Integer, pPnombre As String,
                       pSnombre As String, pPapellido As String, pSapellido As String,
                       pTelefono As Integer, pCorreo As String, pContraseña As String, pRcontraseña As String)




        ' conexion_db()

        Dim Servidor As String = "127.0.0.1"
        Dim Usuario As String = "root"
        Dim Base As String = "curso_unad"
        Dim Contraseña As String = ""

        Conexion = New MySqlConnection
        Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contraseña & "'; "
        Conexion.Open()

        Dim IngPersona = "INSERT INTO personas (tipo_personas,id_persona,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,
        telefono_personas,correo_personas,contraseña,re_contraseña) VALUES ('" & pTipDoc & "','" & pDocumento & "',
        '" & pPnombre & "','" & pSnombre & "','" & pPapellido & "','" & pSapellido & "','" & pTelefono & "',
        '" & pContraseña & "','" & pRcontraseña & "')"
        Dim insert = New MySqlCommand(IngPersona, Conexion)

        MessageBox.Show("La persona ha sido ingresada en el sistema")

    End Sub


End Class
