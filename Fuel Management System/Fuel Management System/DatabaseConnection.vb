Imports System.Data.Sqlite
Public Class DatabaseConnection
  Public Property Connection As SQLiteConnection
  Public Property Command As SQLiteCommand
    Sub New()
        ' open a new connection when the class instantiated
        Dim connection = New SQLiteConnection("Data Source=database.sqlite;Version=3;")
        'connection.Open()
        Dim command = connection.CreateCommand()

        'assign these variables to the properties for external classes to use
        Me.Connection = connection
        Me.Command = command
    End Sub
End Class
