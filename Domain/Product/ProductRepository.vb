Imports Npgsql

Public Class ProductRepository
    Private _connection As NpgsqlConnection

    Public Sub New(connection As NpgsqlConnection)
        _connection = connection
    End Sub

    Public Function InsertProduct(product As Product) As Integer
        Dim query As String = "INSERT INTO otomar_app_budget.product (code, name, quantity, value_unit, value_total, id_note, id_company, id_school) 
                            VALUES (@Code, @Name, @Quantity, @ValueUnit, @ValueTotal, @NoteId, @CompanyId, @SchoolId) RETURNING id;"
        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@Code", product.Code)
            command.Parameters.AddWithValue("@Name", product.Name)
            command.Parameters.AddWithValue("@Quantity", product.Quantity)
            command.Parameters.AddWithValue("@ValueUnit", product.ValueUnit)
            command.Parameters.AddWithValue("@ValueTotal", product.ValueTotal)
            command.Parameters.AddWithValue("@NoteId", product.NoteId)
            command.Parameters.AddWithValue("@CompanyId", product.CompanyId)
            command.Parameters.AddWithValue("@SchoolId", product.SchoolId)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function



End Class
