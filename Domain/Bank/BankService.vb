Imports Npgsql

Public Class BankService
    Private ReadOnly _repository As BankRepository

    Public Sub New(connection As NpgsqlConnection)
        _repository = New BankRepository(connection)
    End Sub

    Public Function InsertBank(bank As Bank) As Integer
        Return _repository.InsertBank(bank)
    End Function

    Public Function FindById(bank As Bank) As Bank
        Return _repository.FindById(bank)
    End Function

End Class
