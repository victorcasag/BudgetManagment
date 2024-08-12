Imports System.CodeDom
Imports Npgsql

Public Class CompanyRepository
    Private _connection As NpgsqlConnection

    Public Sub New(connection As NpgsqlConnection)
        _connection = connection
    End Sub

    Public Function InsertCompany(company As Company) As Integer
        Dim query As String = "INSERT INTO otomar_app_budget.company (name, phone, CNPJ, id_bank, id_address) VALUES (@Name, @Phone, @CNPJ, @IdBank, @IdAddress) RETURNING id;"
        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@Name", company.Name)
            command.Parameters.AddWithValue("@Phone", company.Phone)
            command.Parameters.AddWithValue("@CNPJ", company.CNPJ)
            command.Parameters.AddWithValue("@IdBank", company.IdBank)
            command.Parameters.AddWithValue("@IdAddress", company.IdAddress)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function

    Public Function FindId(company As Company) As String

        Dim query = "SELECT ID FROM OTOMAR_APP_BUDGET.COMPANY WHERE NAME LIKE @CompanyName"

        Dim param = "%" & company.Name & "%"

        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@CompanyName", param)

            Return command.ExecuteScalar()

        End Using

    End Function

    Public Function FindCompany(company As Company) As Company

        Dim query = "SELECT ID, NAME, PHONE, ID_BANK, ID_ADDRESS FROM OTOMAR_APP_BUDGET.COMPANY WHERE NAME LIKE @CompanyName"

        Dim param = "%" & company.Name & "%"

        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@CompanyName", param)

            Using reader As NpgsqlDataReader = command.ExecuteReader()
                If reader.Read() Then

                    Dim retrievedCompany As New Company() With {
                        .Id = reader.GetInt32(0),
                        .Name = reader.GetString(1),
                        .Phone = reader.GetString(2),
                        .IdBank = reader.GetInt32(3),
                        .IdAddress = reader.GetInt32(4)
                    }

                    Return retrievedCompany
                Else
                    Return Nothing
                End If
            End Using

        End Using

    End Function

End Class
