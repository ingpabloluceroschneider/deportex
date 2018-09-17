Public Class Articulo
    Dim _BD As New Conexion
    Public Property cod_articulo As String
    Public Property id_marca As Integer
    Public Property nombre As String
    Public Property precio As Double

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Articulos("
        sql &= "cod_articulo, id_marca, nombre"
        sql &= "precio)"
        sql &= "VALUES ("
        sql &= "'" & _cod_articulo & "'"
        sql &= ",'" & _id_marca & "'"
        sql &= "," & _nombre
        sql &= "," & _precio & "')"
        Me._BD.INS_MOD_BOR(sql)

    End Sub
    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE Articulos "
        sql &= "SET cod_articulo = '" & Me._cod_articulo & "'"
        sql &= ", id_marca = '" & Me._id_marca & "'"
        sql &= ", nombre = '" & Me._nombre & "'"
        sql &= ", precio = " & Me._precio

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cod_articulo As String)
        Dim sql As String = ""
        sql &= "DELETE FROM Articulo"
        sql &= " WHERE cod_articulo = " & _cod_articulo

        Me._BD.INS_MOD_BOR(sql)

    End Sub

End Class
