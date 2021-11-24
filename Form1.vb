Public Class Form1
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
            Else

                ' Vi har en barn nod (=Album), lägg till i en befintligt nod i trädvyn
                nod.Nodes.Add(child)
            End If
        Next
    End Sub

    Private Sub tvwArtisterAlbum_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwArtisterAlbum.AfterSelect

        If IsNothing(e.Node.Parent) Then

            ' Det är en artistnod => visa album i gridvyn
            showDataGrid("SELECT * FROM albums WHERE " & e.Node.Tag)
            grdAlbumLatar.Columns(0).Visible = False
            grdAlbumLatar.Columns(2).Visible = False
        Else

            ' Det är en albumnod => visa låtar i gridvyn
            showDataGrid("SELECT * FROM tracks WHERE " & e.Node.Tag)

        End If
    End Sub

    Private Sub showDataGrid(sql As String)

        ' Rensa befintlig data
        grdAlbumLatar.DataSource = Nothing

        ' Hämta nya data
        grdAlbumLatar.DataSource = hamtaData(sql)

        ' Justera bred på kolumner
        grdAlbumLatar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub
End Class
