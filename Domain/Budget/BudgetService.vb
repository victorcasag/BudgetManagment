Imports Npgsql

Public Class BudgetService
    Private ReadOnly _repository As BudgetRepository

    Public Sub New(connection As NpgsqlConnection)
        _repository = New BudgetRepository(connection)
    End Sub

    Public Function CreateBudget(budget As BudgetDTO) As Integer
        Return _repository.InsertBudget(budget)
    End Function
End Class
