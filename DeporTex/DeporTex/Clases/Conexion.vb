Public Class Conexion
    Dim conn As OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim _cadena_conexion As String = "Provider=SQLNCLI11;Data Source=laptop-vlng4bcv\sqlexpress"

    Private Sub conectar()
        conn.ConnectionString = _cadena_conexion
        conn.Open()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
    End Sub
    Private Sub cerrar()
        conn.Close()
    End Sub
    Public Sub INS_MOD_BOR(ByVal comando As String)
        Me.conectar()
        cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        cerrar()
    End Sub
    Public Function leo_tabla(ByVal sql As String) As DataTable
        Me.conectar()
        cmd.CommandText = sql
        Dim tabla As New DataTable
        tabla.Load(cmd.ExecuteReader())
        cerrar()
        Return tabla
    End Function
End Class

