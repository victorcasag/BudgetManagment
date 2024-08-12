Imports Npgsql

Public Class NoteService
    Private ReadOnly _repository As NoteRepository

    Public Sub New(connection As NpgsqlConnection)
        _repository = New NoteRepository(connection)
    End Sub

    Public Function CreateNote(note As Note) As Integer
        Return _repository.InsertNote(note)
    End Function

    Public Function FindId(note As Note) As Integer
        Return _repository.FindId(note)
    End Function
End Class
