Imports Npgsql

Public Class SchoolService
    Private ReadOnly _repository As SchoolRepository

    Public Sub New(connection As NpgsqlConnection)
        _repository = New SchoolRepository(connection)
    End Sub

    Public Function CreateSchool(school As School) As Integer
        Return _repository.InsertSchool(school)
    End Function
    Public Function FindId(school As School) As Integer
        Return _repository.FindId(school)
    End Function

    Public Function FindById(school As School) As School
        Return _repository.FindById(school)
    End Function

End Class
