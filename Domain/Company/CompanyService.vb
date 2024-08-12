Imports Npgsql

Public Class CompanyService
    Private ReadOnly _repository As CompanyRepository

    Public Sub New(connection As NpgsqlConnection)
        _repository = New CompanyRepository(connection)
    End Sub

    Public Function InsertCompany(company As Company) As Integer
        Return _repository.InsertCompany(company)
    End Function

    Public Function FindId(company As Company) As Integer
        Return _repository.FindId(company)
    End Function

    Public Function FindCompany(company As Company) As Company
        Return _repository.FindCompany(company)
    End Function


End Class
