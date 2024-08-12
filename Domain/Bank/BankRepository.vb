Imports Npgsql

Public Class BankRepository
    Private _connection As NpgsqlConnection

    Public Sub New(connection As NpgsqlConnection)
        _connection = connection
    End Sub

    Public Function InsertBank(bank As Bank) As Integer
        Dim query As String = "INSERT INTO otomar_app_budget.BANK (agency, name, current_account) VALUES (@Agency, @Name, @CurrentAccount) RETURNING id;"
        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@Agency", bank.Agency)
            command.Parameters.AddWithValue("@Name", bank.Name)
            command.Parameters.AddWithValue("@CurrentAccount", bank.CurrentAccount)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function

    Public Function FindById(bank As Bank) As Bank

        Dim query = "SELECT AGENCY, NAME, CURRENT_ACCOUNT FROM OTOMAR_APP_BUDGET.BANK WHERE ID =" & bank.Id

        Using Command As New NpgsqlCommand(query, _connection)
            Using reader As NpgsqlDataReader = Command.ExecuteReader()
                If reader.Read() Then

                    Dim retrievedBank As New Bank() With {
                        .Agency = reader.GetString(0),
                        .Name = reader.GetString(1),
                        .CurrentAccount = reader.GetString(2)
                    }

                    Return retrievedBank
                Else
                    Return Nothing
                End If
            End Using
        End Using



    End Function
End Class
