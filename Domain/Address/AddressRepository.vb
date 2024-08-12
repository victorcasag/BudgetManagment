Imports Npgsql

Public Class AddressRepository
    Private _connection As NpgsqlConnection

    Public Sub New(connection As NpgsqlConnection)
        _connection = connection
    End Sub

    Public Function InsertAddress(address As Address) As Integer
        Dim ultimoID As Integer = 0

        Dim query As String = "INSERT INTO OTOMAR_APP_BUDGET.ADDRESS (STREET, NUMBER, CITY) VALUES (@street, @number, @city) RETURNING id;"

        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@street", address.Street)
            command.Parameters.AddWithValue("@number", address.Number)
            command.Parameters.AddWithValue("@city", address.City)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using

    End Function

    Public Function FindById(address As Address) As Address

        Dim query = "SELECT STREET, NUMBER, CITY FROM OTOMAR_APP_BUDGET.ADDRESS WHERE ID =" & address.Id

        Using Command As New NpgsqlCommand(query, _connection)
            Using reader As NpgsqlDataReader = Command.ExecuteReader()
                If reader.Read() Then

                    Dim retrievedAddress As New Address() With {
                        .Street = reader.GetString(0),
                        .Number = reader.GetString(1),
                        .City = reader.GetString(2)
                    }

                    Return retrievedAddress
                Else
                    Return Nothing
                End If
            End Using
        End Using



    End Function

End Class
