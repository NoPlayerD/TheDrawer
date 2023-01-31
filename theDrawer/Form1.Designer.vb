<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EkleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosyaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KlasorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OluşturToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KlasorToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategorieLocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KlasörToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OluşturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KlasörToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonumaGitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UygulamaVeriKonumuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktifKlasörKonumuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(782, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "FullScreen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.LargeImageList = Me.imageList1
        Me.ListView1.Location = New System.Drawing.Point(169, 48)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(237, 330)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(28, 28)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListView2
        '
        Me.ListView2.AllowDrop = True
        Me.ListView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListView2.ForeColor = System.Drawing.Color.White
        Me.ListView2.LargeImageList = Me.imageList2
        Me.ListView2.Location = New System.Drawing.Point(412, 48)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(237, 330)
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'imageList2
        '
        Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList2.Images.SetKeyName(0, "folder.ico")
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(655, 48)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(217, 324)
        Me.ListBox2.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(12, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "O"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(797, 386)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 25)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EkleToolStripMenuItem1, Me.OluşturToolStripMenuItem1, Me.OpenLocationToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 422)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EkleToolStripMenuItem1
        '
        Me.EkleToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem1, Me.KlasorToolStripMenuItem2, Me.CategoryToolStripMenuItem})
        Me.EkleToolStripMenuItem1.Name = "EkleToolStripMenuItem1"
        Me.EkleToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.EkleToolStripMenuItem1.Text = "Add"
        '
        'DosyaToolStripMenuItem1
        '
        Me.DosyaToolStripMenuItem1.Name = "DosyaToolStripMenuItem1"
        Me.DosyaToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.DosyaToolStripMenuItem1.Text = "File"
        '
        'KlasorToolStripMenuItem2
        '
        Me.KlasorToolStripMenuItem2.Name = "KlasorToolStripMenuItem2"
        Me.KlasorToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
        Me.KlasorToolStripMenuItem2.Text = "Folder"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'OluşturToolStripMenuItem1
        '
        Me.OluşturToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KlasorToolStripMenuItem3, Me.CategorieToolStripMenuItem})
        Me.OluşturToolStripMenuItem1.Name = "OluşturToolStripMenuItem1"
        Me.OluşturToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.OluşturToolStripMenuItem1.Text = "Create"
        '
        'KlasorToolStripMenuItem3
        '
        Me.KlasorToolStripMenuItem3.Name = "KlasorToolStripMenuItem3"
        Me.KlasorToolStripMenuItem3.Size = New System.Drawing.Size(122, 22)
        Me.KlasorToolStripMenuItem3.Text = "Folder"
        '
        'CategorieToolStripMenuItem
        '
        Me.CategorieToolStripMenuItem.Name = "CategorieToolStripMenuItem"
        Me.CategorieToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CategorieToolStripMenuItem.Text = "Category"
        '
        'OpenLocationToolStripMenuItem
        '
        Me.OpenLocationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategorieLocToolStripMenuItem, Me.DataLocToolStripMenuItem})
        Me.OpenLocationToolStripMenuItem.Name = "OpenLocationToolStripMenuItem"
        Me.OpenLocationToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.OpenLocationToolStripMenuItem.Text = "Open Location"
        '
        'CategorieLocToolStripMenuItem
        '
        Me.CategorieLocToolStripMenuItem.Name = "CategorieLocToolStripMenuItem"
        Me.CategorieLocToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CategorieLocToolStripMenuItem.Text = "Category Loc."
        '
        'DataLocToolStripMenuItem
        '
        Me.DataLocToolStripMenuItem.Name = "DataLocToolStripMenuItem"
        Me.DataLocToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DataLocToolStripMenuItem.Text = "Data Loc."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EkleToolStripMenuItem
        '
        Me.EkleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KlasörToolStripMenuItem, Me.DosyaToolStripMenuItem})
        Me.EkleToolStripMenuItem.Name = "EkleToolStripMenuItem"
        Me.EkleToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EkleToolStripMenuItem.Text = ".Ekle"
        '
        'KlasörToolStripMenuItem
        '
        Me.KlasörToolStripMenuItem.Name = "KlasörToolStripMenuItem"
        Me.KlasörToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.KlasörToolStripMenuItem.Text = "Klasör"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'OluşturToolStripMenuItem
        '
        Me.OluşturToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KlasörToolStripMenuItem1})
        Me.OluşturToolStripMenuItem.Name = "OluşturToolStripMenuItem"
        Me.OluşturToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OluşturToolStripMenuItem.Text = ".Oluştur"
        '
        'KlasörToolStripMenuItem1
        '
        Me.KlasörToolStripMenuItem1.Name = "KlasörToolStripMenuItem1"
        Me.KlasörToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.KlasörToolStripMenuItem1.Text = "Klasör"
        '
        'KonumaGitToolStripMenuItem
        '
        Me.KonumaGitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UygulamaVeriKonumuToolStripMenuItem, Me.AktifKlasörKonumuToolStripMenuItem})
        Me.KonumaGitToolStripMenuItem.Name = "KonumaGitToolStripMenuItem"
        Me.KonumaGitToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KonumaGitToolStripMenuItem.Text = ".Konuma git"
        '
        'UygulamaVeriKonumuToolStripMenuItem
        '
        Me.UygulamaVeriKonumuToolStripMenuItem.Name = "UygulamaVeriKonumuToolStripMenuItem"
        Me.UygulamaVeriKonumuToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.UygulamaVeriKonumuToolStripMenuItem.Text = "Uygulama veri konumu"
        '
        'AktifKlasörKonumuToolStripMenuItem
        '
        Me.AktifKlasörKonumuToolStripMenuItem.Name = "AktifKlasörKonumuToolStripMenuItem"
        Me.AktifKlasörKonumuToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AktifKlasörKonumuToolStripMenuItem.Text = "Aktif klasör konumu"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(151, 324)
        Me.ListBox1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackgroundImage = Global.theDrawer.My.Resources.Resources.reset_32
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(766, 386)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 25)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkRed
        Me.PictureBox1.Location = New System.Drawing.Point(155, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(477, 35)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 446)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.85R
        Me.ShowIcon = False
        Me.Text = "TheDrawer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KlasörToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OluşturToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KlasörToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KonumaGitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UygulamaVeriKonumuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AktifKlasörKonumuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents EkleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DosyaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KlasorToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents OluşturToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KlasorToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents OpenLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategorieLocToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataLocToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents imageList1 As ImageList
    Friend WithEvents imageList2 As ImageList
    Friend WithEvents CategorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer2 As Timer
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
