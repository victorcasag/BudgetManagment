Imports Npgsql

Public Class NoteRepository
    Private _connection As NpgsqlConnection

    Public Sub New(connection As NpgsqlConnection)
        _connection = connection
    End Sub

    Public Function InsertNote(note As Note) As Integer
        Dim query As String = "INSERT INTO OTOMAR_APP_BUDGET.note (number_note, date_budget, total_products, total, discount, id_school, id_company, PDDE) VALUES (@NumberNote, @DateBudget, @TotalProducts, @Total, @Discount, @SchoolId, @CompanyId, @PDDE) RETURNING id;"
        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@NumberNote", note.NumberNote)
            command.Parameters.AddWithValue("@DateBudget", note.DateBudget)
            command.Parameters.AddWithValue("@TotalProducts", note.TotalProducts)
            command.Parameters.AddWithValue("@PDDE", note.PDDE)
            command.Parameters.AddWithValue("@Total", note.Total)
            command.Parameters.AddWithValue("@Discount", note.Discount)
            command.Parameters.AddWithValue("@SchoolId", note.SchoolId)
            command.Parameters.AddWithValue("@CompanyId", note.CompanyId)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function

    Public Function FindId(note As Note) As String

        Dim query = "SELECT ID FROM OTOMAR_APP_BUDGET.NOTE WHERE NUMBER_NOTE = @NumberNote" 'falta colocar a empresa, a nota pode existir em diferentes empresas

        Dim param = note.NumberNote

        Using command As New NpgsqlCommand(query, _connection)
            command.Parameters.AddWithValue("@NumberNote", param)

            Return command.ExecuteScalar()

        End Using

    End Function

End Class
