Public Class frmNyttAlbum
    Public artistnamn As String
    Private Sub frmNyttAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Rensa textruta för albumnamn
        txtAlbum.Text = ""
        Me.Text = "Nytt album för " & artistnamn
    End Sub
    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click

        ' Lokal dataadapter för att spara
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("SELECT * FROM albums", cnChinook)

        ' Använd en CommandBuilder för att spara
        Dim comBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim ds As New DataSet

        ' Fyll dataset med info från databas
        dataAdapter.Fill(ds, "Album")

        ' Skapa en datarow för att lägga till ett album
        Dim dr As DataRow
        dr = ds.Tables("Album").NewRow
        ds.Tables("Album").Rows.Add(dr)

        ' Tilldela värdet
        dr.Item("Title") = txtAlbum.Text
        dr.Item("ArtistID") = txtArtistID.Text

        ' Skriv till databasen
        dataAdapter.Update(ds, "Album")

        ' Meddela att allt gick bra till anropande formulär och stäng aktuellt formulär
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub


End Class