Imports System.Data.SQLite

Module modData

    ' Funktion för endast en connection till db
    Public Function cnChinook() As SQLiteConnection

        Dim cnString As New SQLiteConnectionStringBuilder()
        Static cnConnection As SQLiteConnection

        If cnConnection Is Nothing Then

            cnString.DataSource = "..\..\..\chinook.db"
            cnString.ForeignKeys = True

            ' Skapa koppling
            cnConnection = New SQLiteConnection(cnString.ToString)
        End If

        Return cnConnection

    End Function

    ' Function för sql frågor
    Public Function hamtaData(sql As String) As DataTable

        Dim dt As New DataTable()

        ' Skapa kommandoobject
        Dim cmd As New SQLiteCommand(sql, cnChinook)

        ' Exekevera kommandor
        Dim da As New SQLiteDataAdapter(cmd)

        ' Fyll returobject
        da.Fill(dt)

        ' Returnera datatabellen
        Return dt

    End Function

End Module
