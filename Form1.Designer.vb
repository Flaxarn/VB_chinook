<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tvwArtisterAlbum = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRaderaLat = New System.Windows.Forms.Button()
        Me.btnRaderaAlbum = New System.Windows.Forms.Button()
        Me.btnRaderaArtist = New System.Windows.Forms.Button()
        Me.btnNyLat = New System.Windows.Forms.Button()
        Me.btnNyttAlbum = New System.Windows.Forms.Button()
        Me.btnNyArtist = New System.Windows.Forms.Button()
        Me.grdAlbumLatar = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.grdAlbumLatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvwArtisterAlbum
        '
        Me.tvwArtisterAlbum.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvwArtisterAlbum.Location = New System.Drawing.Point(0, 0)
        Me.tvwArtisterAlbum.Name = "tvwArtisterAlbum"
        Me.tvwArtisterAlbum.Size = New System.Drawing.Size(267, 560)
        Me.tvwArtisterAlbum.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRaderaLat)
        Me.Panel1.Controls.Add(Me.btnRaderaAlbum)
        Me.Panel1.Controls.Add(Me.btnRaderaArtist)
        Me.Panel1.Controls.Add(Me.btnNyLat)
        Me.Panel1.Controls.Add(Me.btnNyttAlbum)
        Me.Panel1.Controls.Add(Me.btnNyArtist)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(267, 478)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 82)
        Me.Panel1.TabIndex = 1
        '
        'btnRaderaLat
        '
        Me.btnRaderaLat.Enabled = False
        Me.btnRaderaLat.Location = New System.Drawing.Point(661, 23)
        Me.btnRaderaLat.Name = "btnRaderaLat"
        Me.btnRaderaLat.Size = New System.Drawing.Size(112, 34)
        Me.btnRaderaLat.TabIndex = 5
        Me.btnRaderaLat.Text = "Radera Låt"
        Me.btnRaderaLat.UseVisualStyleBackColor = True
        '
        'btnRaderaAlbum
        '
        Me.btnRaderaAlbum.Enabled = False
        Me.btnRaderaAlbum.Location = New System.Drawing.Point(511, 23)
        Me.btnRaderaAlbum.Name = "btnRaderaAlbum"
        Me.btnRaderaAlbum.Size = New System.Drawing.Size(143, 34)
        Me.btnRaderaAlbum.TabIndex = 4
        Me.btnRaderaAlbum.Text = "Radera Album"
        Me.btnRaderaAlbum.UseVisualStyleBackColor = True
        '
        'btnRaderaArtist
        '
        Me.btnRaderaArtist.Enabled = False
        Me.btnRaderaArtist.Location = New System.Drawing.Point(360, 23)
        Me.btnRaderaArtist.Name = "btnRaderaArtist"
        Me.btnRaderaArtist.Size = New System.Drawing.Size(145, 34)
        Me.btnRaderaArtist.TabIndex = 3
        Me.btnRaderaArtist.Text = "Radera Artist"
        Me.btnRaderaArtist.UseVisualStyleBackColor = True
        '
        'btnNyLat
        '
        Me.btnNyLat.Location = New System.Drawing.Point(242, 23)
        Me.btnNyLat.Name = "btnNyLat"
        Me.btnNyLat.Size = New System.Drawing.Size(112, 34)
        Me.btnNyLat.TabIndex = 2
        Me.btnNyLat.Text = "Ny Låt"
        Me.btnNyLat.UseVisualStyleBackColor = True
        '
        'btnNyttAlbum
        '
        Me.btnNyttAlbum.Location = New System.Drawing.Point(124, 23)
        Me.btnNyttAlbum.Name = "btnNyttAlbum"
        Me.btnNyttAlbum.Size = New System.Drawing.Size(112, 34)
        Me.btnNyttAlbum.TabIndex = 1
        Me.btnNyttAlbum.Text = "Nytt Album"
        Me.btnNyttAlbum.UseVisualStyleBackColor = True
        '
        'btnNyArtist
        '
        Me.btnNyArtist.Location = New System.Drawing.Point(6, 23)
        Me.btnNyArtist.Name = "btnNyArtist"
        Me.btnNyArtist.Size = New System.Drawing.Size(112, 34)
        Me.btnNyArtist.TabIndex = 0
        Me.btnNyArtist.Text = "Ny Artist"
        Me.btnNyArtist.UseVisualStyleBackColor = True
        '
        'grdAlbumLatar
        '
        Me.grdAlbumLatar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAlbumLatar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAlbumLatar.Location = New System.Drawing.Point(267, 0)
        Me.grdAlbumLatar.Name = "grdAlbumLatar"
        Me.grdAlbumLatar.RowHeadersWidth = 62
        Me.grdAlbumLatar.RowTemplate.Height = 33
        Me.grdAlbumLatar.Size = New System.Drawing.Size(778, 478)
        Me.grdAlbumLatar.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 560)
        Me.Controls.Add(Me.grdAlbumLatar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tvwArtisterAlbum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdAlbumLatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvwArtisterAlbum As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grdAlbumLatar As DataGridView
    Friend WithEvents btnNyLat As Button
    Friend WithEvents btnNyttAlbum As Button
    Friend WithEvents btnNyArtist As Button
    Friend WithEvents btnRaderaArtist As Button
    Friend WithEvents btnRaderaLat As Button
    Friend WithEvents btnRaderaAlbum As Button
End Class
