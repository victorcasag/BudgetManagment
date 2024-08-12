Imports Npgsql

Public Class BudgetRepository
    Private _connection As NpgsqlConnection

    Public Sub New(connection As NpgsqlConnection)
        _connection = connection
    End Sub

    Public Function InsertBudget(budget As BudgetDTO) As Integer
        Dim query As String = "INSERT INTO otomar_app_budget.budget (id_note, id_company, id_school) VALUES (@NoteId, @CompanyId, @SchoolId) RETURNING id;"
        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@NoteId", budget.NoteId)
            command.Parameters.AddWithValue("@CompanyId", budget.CompanyId)
            command.Parameters.AddWithValue("@SchoolId", budget.SchoolId)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function
End Class
