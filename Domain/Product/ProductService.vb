Imports Npgsql

Public Class ProductService
    Private ReadOnly _repository As ProductRepository

    Public Sub New(connection As NpgsqlConnection)
        _repository = New ProductRepository(connection)
    End Sub

    Public Function CreateProduct(product As Product) As Integer
        Return _repository.InsertProduct(product)
    End Function
End Class
