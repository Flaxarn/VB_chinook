Public Class Form1

    Private artistNode As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Fyll trädvyn vid formulärinläsning
        reloadTree()
    End Sub

    Private Sub reloadTree()

        ' Rensa tidigare innehåll
        tvwArtisterAlbum.Nodes.Clear()

        Dim dt As DataTable = hamtaData("SELECT * FROM artists")
        fyllTrad(dt, 0, Nothing, "Name", "Artistid")

        ' Sortera trädet
        tvwArtisterAlbum.Sort()
    End Sub

    Private Sub fyllTrad(tabell As DataTable, parentID As Integer, nod As TreeNode, title As String, tag As String)

        ' Rekursiv funktion för att fylla trädvyn

        ' Loopa igenom hela tabellen
        For Each row As DataRow In tabell.Rows
            ' Skapa en ny trädnod och sätt texten på noden
            Dim child As New TreeNode()
            child.Text = row(title).ToString

            ' Sätt en tag som gör det möjligt att söka efter "barn" till noden
            child.Tag = tag & "= " & row(tag.ToString)

            If parentID = 0 Then
                ' Vi har en rotnod (=artist), lägg till den nya noden i trädvyn
                tvwArtisterAlbum.Nodes.Add(child)

                Dim dtChild As DataTable = hamtaData("SELECT * FROM albums WHERE " & child.Tag)
                fyllTrad(dtChild, row(tag), child, "Title", "AlbumId")

                If artistNode = row("ArtistId") Then
                    tvwArtisterAlbum.SelectedNode = child
                    child.Expand()
                    child.EnsureVisible()
                    child.Checked = True
                End If
            Else

                ' Vi har en barn nod (=Album), lägg till i en befintligt nod i trädvyn
                nod.Nodes.Add(child)
            End If
        Next
    End Sub

    Private Sub tvwArtisterAlbum_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwArtisterAlbum.AfterSelect

        Dim nod As TreeNode

        ' Disable radera knapp som default
        btnRaderaArtist.Enabled = False
        btnRaderaAlbum.Enabled = False

        If IsNothing(e.Node.Parent) Then

            ' Det är en artistnod => visa album i gridvyn
            showDataGrid("SELECT * FROM albums WHERE " & e.Node.Tag)
            grdAlbumLatar.Columns(0).Visible = False
            grdAlbumLatar.Columns(2).Visible = False

            If e.Node.Nodes.Count = 0 Then
                btnRaderaArtist.Enabled = True
            End If

            nod = e.Node
        Else

            ' Det är en albumnod => visa låtar i gridvyn
            showDataGrid("SELECT * FROM tracks WHERE " & e.Node.Tag)
            btnRaderaAlbum.Enabled = True
            nod = e.Node.Parent
        End If

        ' HItta artistId från nodens tag
        artistNode = Val(Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1))
    End Sub

    Private Sub showDataGrid(sql As String)

        ' Rensa befintlig data
        grdAlbumLatar.DataSource = Nothing

        ' Hämta nya data
        grdAlbumLatar.DataSource = hamtaData(sql)

        ' Justera bred på kolumner
        grdAlbumLatar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub

    Private Sub btnNyArtist_Click(sender As Object, e As EventArgs) Handles btnNyArtist.Click

        If frmNyArtist.ShowDialog = DialogResult.OK Then

            reloadTree()
        End If
    End Sub

    Private Sub btnNyttAlbum_Click(sender As Object, e As EventArgs) Handles btnNyttAlbum.Click
        Dim artistID As String
        Dim nod As TreeNode

        If IsNothing(tvwArtisterAlbum.SelectedNode.Parent) Then

            ' Vi har en artist markerad, id finns i slutet på nodens tag
            nod = tvwArtisterAlbum.SelectedNode

        Else
            nod = tvwArtisterAlbum.SelectedNode.Parent
            ' Vi har ett nytt album markerat, artistens id finns i slutet på föräldranodens tag
        End If

        ' Hitta artistId från nodens tag
        artistID = Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1)

        ' Sätt artistID och namn i det nya formuläret
        frmNyttAlbum.txtArtistID.Text = artistID
        frmNyttAlbum.artistnamn = nod.Text

        If frmNyttAlbum.ShowDialog() = DialogResult.OK Then
            reloadTree()
        End If
    End Sub

    Private Sub btnRaderaArtist_Click(sender As Object, e As EventArgs) Handles btnRaderaArtist.Click
        Dim artistID As String
        Dim nod As TreeNode

        ' Kolla om artistnod
        If IsNothing(tvwArtisterAlbum.SelectedNode.Parent) Then
            ' Hitta artistId från nodens tag
            nod = tvwArtisterAlbum.SelectedNode
            artistID = Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1)
            raderaArtist(artistID)
        End If
    End Sub

    Private Sub raderaArtist(id As String)
        ' Lokal dataadapter för att spara
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("SELECT * FROM artists WHERE artistID =" & id, cnChinook)

        ' Använd en CommandBuilder för att spara
        Dim comBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim ds As New DataSet

        ' Fyll dataset med info från databas
        dataAdapter.Fill(ds, "Artister")

        ' Ta bort första raden
        ds.Tables("Artister").Rows(0).Delete()

        ' Radera från databasen
        dataAdapter.Update(ds, "Artister")

        reloadTree()
    End Sub

    Private Sub btnRaderaAlbum_Click(sender As Object, e As EventArgs) Handles btnRaderaAlbum.Click
        Dim albumID As String
        Dim nod As TreeNode

        ' Kolla om artistnod
        If Not IsNothing(tvwArtisterAlbum.SelectedNode.Parent) Then
            ' Hitta albumId från nodens tag
            nod = tvwArtisterAlbum.SelectedNode
            albumID = Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1)
            raderaAlbum(albumID)
        End If
    End Sub

    Private Sub raderaAlbum(id As String)

        ' Lokal dataadapter för att spara
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("SELECT * FROM albums WHERE albumId =" & id, cnChinook)

        ' Använd en CommandBuilder för att spara
        Dim comBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim ds As New DataSet

        ' Fyll dataset med info från databas
        dataAdapter.Fill(ds, "Album")

        ' Ta bort första raden
        ds.Tables("Album").Rows(0).Delete()

        ' Radera från databasen
        dataAdapter.Update(ds, "Album")

        reloadTree()
    End Sub
End Class
