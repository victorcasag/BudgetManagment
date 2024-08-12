Imports Npgsql

Public Class AddressService
    Private ReadOnly _repository As AddressRepository

    Public Sub New(connection As NpgsqlConnection)
        _repository = New AddressRepository(connection)
    End Sub

    Public Function InsertAddress(address As Address) As Integer
        Return _repository.InsertAddress(address)
    End Function

    Public Function FindById(address As Address) As Address
        Return _repository.FindById(address)
    End Function

End Class
