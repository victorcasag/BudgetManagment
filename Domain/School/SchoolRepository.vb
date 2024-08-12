Imports Npgsql

Public Class SchoolRepository
    Private _connection As NpgsqlConnection

    Public Sub New(connection As NpgsqlConnection)
        _connection = connection
    End Sub

    Public Function InsertSchool(school As School) As Integer
        Dim query As String = "INSERT INTO OTOMAR_APP_BUDGET.school (name, phone, CNPJ, id_address) VALUES (@Name, @Phone, @CNPJ, @AddressId) RETURNING id;"
        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@Name", school.Name)
            command.Parameters.AddWithValue("@Phone", school.Phone)
            command.Parameters.AddWithValue("@CNPJ", school.CNPJ)
            command.Parameters.AddWithValue("@AddressId", school.IdAddress)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function

    Public Function FindId(school As School) As String

        Dim query = "SELECT ID FROM OTOMAR_APP_BUDGET.SCHOOL WHERE NAME LIKE @SchoolName"

        Dim param = "%" & school.Name & "%"

        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@SchoolName", param)

            Return command.ExecuteScalar()

        End Using

    End Function

    Public Function FindById(school As School) As School

        Dim query = "SELECT ID, NAME, PHONE, CNPJ, ID_ADDRESS FROM OTOMAR_APP_BUDGET.SCHOOL WHERE NAME LIKE @SchoolName"

        Dim param = "%" & school.Name & "%"

        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@SchoolName", param)

            Using reader As NpgsqlDataReader = command.ExecuteReader()
                If reader.Read() Then

                    Dim retrievedSchool As New School() With {
                        .Id = reader.GetInt32(0),
                        .Name = reader.GetString(1),
                        .Phone = reader.GetString(2),
                        .CNPJ = reader.GetString(3),
                        .IdAddress = reader.GetInt32(4)
                    }

                    Return retrievedSchool
                Else
                    Return Nothing
                End If
            End Using

        End Using

    End Function

End Class
