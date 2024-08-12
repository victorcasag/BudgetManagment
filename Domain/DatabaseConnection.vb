Imports Npgsql

Public Class DatabaseConnection
    Private Shared _instance As DatabaseConnection
    Private _connection As NpgsqlConnection

    Private Sub New()
        Dim connectionString As String = "Host=localhost;Port=2222;Database=otomar;Username=postgres;Password=root;"
        _connection = New NpgsqlConnection(connectionString)
    End Sub

    Public Shared ReadOnly Property Instance() As DatabaseConnection
        Get
            If _instance Is Nothing Then
                _instance = New DatabaseConnection()
            End If
            Return _instance
        End Get
    End Property

    Public Function OpenConnection() As NpgsqlConnection
        If _connection.State <> ConnectionState.Open Then
            _connection.Open()
        End If
        Return _connection
    End Function

    Public Sub CloseConnection()
        If _connection IsNot Nothing AndAlso _connection.State = ConnectionState.Open Then
            _connection.Close()
        End If
    End Sub

End Class
