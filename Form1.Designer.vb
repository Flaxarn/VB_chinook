﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.grdAlbumLatar = New System.Windows.Forms.DataGridView()
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(267, 478)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 82)
        Me.Panel1.TabIndex = 1
        '
        'grdAlbumLatar
        '
        Me.grdAlbumLatar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAlbumLatar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAlbumLatar.Location = New System.Drawing.Point(267, 0)
        Me.grdAlbumLatar.Name = "grdAlbumLatar"
        Me.grdAlbumLatar.RowHeadersWidth = 62
        Me.grdAlbumLatar.RowTemplate.Height = 33
        Me.grdAlbumLatar.Size = New System.Drawing.Size(649, 478)
        Me.grdAlbumLatar.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 560)
        Me.Controls.Add(Me.grdAlbumLatar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tvwArtisterAlbum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdAlbumLatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvwArtisterAlbum As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grdAlbumLatar As DataGridView
End Class