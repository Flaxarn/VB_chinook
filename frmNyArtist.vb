Public Class frmNyArtist
    Private Sub btnSparaArtist_Click(sender As Object, e As EventArgs) Handles btnSparaArtist.Click

        ' Lokal dataadapter för att spara
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("SELECT * FROM artists", cnChinook)

        ' Använd en CommandBuilder för att spara
        Dim comBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim ds As New DataSet

        ' Fyll dataset med info från databas
        dataAdapter.Fill(ds, "Artister")

        ' Skapa en datarow för att lägga till artisten
        Dim dr As DataRow
        dr = ds.Tables("Artister").NewRow
        ds.Tables("Artister").Rows.Add(dr)

        ' Tilldela värdet
        dr.Item("Name") = txtArtist.Text

        ' Skriv till databasen
        dataAdapter.Update(ds, "Artister")

        ' Hämta senaste uppdaterade raden
        Dim dt As DataTable = hamtaData("SELECT last_insert_rowid()")
        Form1.artistNode = dt.Rows(0)(0)

        ' Meddela att allt gick bra till anropande formulär och stäng aktuellt formulär
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmNyArtist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Töm txt ruta för ny artist
        txtArtist.Text = ""
    End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click

        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class