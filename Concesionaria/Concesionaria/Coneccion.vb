Imports System.Data.Odbc

Module Coneccion
    Public cmd As OdbcCommand
    Public cnn As OdbcConnection
    Public rs1 As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public rs3 As OdbcDataReader
    Public sql As String

    Public Sub consulta(ByVal x As Integer)
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text

        If x = 1 Then
            rs1 = cmd.ExecuteReader
        ElseIf x = 2 Then
            rs2 = cmd.ExecuteReader
        ElseIf x = 3 Then
            rs3 = cmd.ExecuteReader
        End If

        cmd.Dispose
    End Sub
End Module
