Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Libreria




    Public Sub IngresoPersona(ByVal pTipDoc As String, pDocumento As Integer, pPnombre As String,
                       pSnombre As String, pPapellido As String, pSapellido As String,
                       pTelefono As Integer, pCorreo As String, pContrase�a As String, pRcontrase�a As String)




        ' conexion_db()

        Dim Servidor As String = "127.0.0.1"
        Dim Usuario As String = "root"
        Dim Base As String = "curso_unad"
        Dim Contrase�a As String = ""

        Conexion = New MySqlConnection
        Conexion.ConnectionString = "server='" & Servidor & "';database='" & Base & "';user id='" & Usuario & "';password='" & Contrase�a & "'; "
        Conexion.Open()

        Dim IngPersona = "INSERT INTO personas (tipo_personas,id_persona,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,
        telefono_personas,correo_personas,contrase�a,re_contrase�a) VALUES ('" & pTipDoc & "','" & pDocumento & "',
        '" & pPnombre & "','" & pSnombre & "','" & pPapellido & "','" & pSapellido & "','" & pTelefono & "',
        '" & pContrase�a & "','" & pRcontrase�a & "')"
        Dim insert = New MySqlCommand(IngPersona, Conexion)

        MessageBox.Show("La persona ha sido ingresada en el sistema")

    End Sub


End Class
