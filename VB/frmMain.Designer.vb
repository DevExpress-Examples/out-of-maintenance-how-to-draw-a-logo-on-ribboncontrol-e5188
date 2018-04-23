Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class frmMain

		#Region "Designer generated code"
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
			Dim toolTipSeparatorItem1 As New DevExpress.Utils.ToolTipSeparatorItem()
			Dim toolTipTitleItem2 As New DevExpress.Utils.ToolTipTitleItem()
			Me.iWeb = New DevExpress.XtraBars.BarButtonItem()
			Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
			Me.iCenter = New DevExpress.XtraBars.BarButtonItem()
			Me.iSelectAll = New DevExpress.XtraBars.BarButtonItem()
			Me.iCopy = New DevExpress.XtraBars.BarButtonItem()
			Me.iCut = New DevExpress.XtraBars.BarButtonItem()
			Me.iPaste = New DevExpress.XtraBars.BarButtonItem()
			Me.iClear = New DevExpress.XtraBars.BarButtonItem()
			Me.iFont = New DevExpress.XtraBars.BarButtonItem()
			Me.beiFontSize = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.bbiFontColorPopup = New DevExpress.XtraBars.BarButtonItem()
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
			Me.iSave = New DevExpress.XtraBars.BarButtonItem()
			Me.iUndo = New DevExpress.XtraBars.BarButtonItem()
			Me.iReplace = New DevExpress.XtraBars.BarButtonItem()
			Me.idNew = New DevExpress.XtraBars.BarButtonItem()
			Me.iClose = New DevExpress.XtraBars.BarButtonItem()
			Me.iSaveAs = New DevExpress.XtraBars.BarButtonItem()
			Me.iPrint = New DevExpress.XtraBars.BarButtonItem()
			Me.iExit = New DevExpress.XtraBars.BarButtonItem()
			Me.iFind = New DevExpress.XtraBars.BarButtonItem()
			Me.iBullets = New DevExpress.XtraBars.BarButtonItem()
			Me.iProtected = New DevExpress.XtraBars.BarButtonItem()
			Me.iBold = New DevExpress.XtraBars.BarButtonItem()
			Me.iItalic = New DevExpress.XtraBars.BarButtonItem()
			Me.iUnderline = New DevExpress.XtraBars.BarButtonItem()
			Me.iAlignLeft = New DevExpress.XtraBars.BarButtonItem()
			Me.iAlignRight = New DevExpress.XtraBars.BarButtonItem()
			Me.iFontColor = New DevExpress.XtraBars.BarButtonItem()
			Me.siPosition = New DevExpress.XtraBars.BarButtonItem()
			Me.siModified = New DevExpress.XtraBars.BarButtonItem()
			Me.siDocName = New DevExpress.XtraBars.BarStaticItem()
			Me.bgFontStyle = New DevExpress.XtraBars.BarButtonGroup()
			Me.bgAlign = New DevExpress.XtraBars.BarButtonGroup()
			Me.bgFont = New DevExpress.XtraBars.BarButtonGroup()
			Me.bgBullets = New DevExpress.XtraBars.BarButtonGroup()
			Me.sbiSave = New DevExpress.XtraBars.BarSubItem()
			Me.sbiPaste = New DevExpress.XtraBars.BarSubItem()
			Me.iPasteSpecial = New DevExpress.XtraBars.BarButtonItem()
			Me.iNew = New DevExpress.XtraBars.BarButtonItem()
			Me.iLargeUndo = New DevExpress.XtraBars.BarLargeButtonItem()
			Me.iTemplate = New DevExpress.XtraBars.BarButtonItem()
			Me.iPaintStyle = New DevExpress.XtraBars.BarButtonItem()
			Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.rgbiFont = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.rgbiFontColor = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.biStyle = New DevExpress.XtraBars.BarEditItem()
			Me.riicStyle = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.ribbonLogoHelper1 = New DevExpress.XtraBars.Ribbon.RibbonLogoHelper()
			DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.riicStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' iWeb
			' 
			Me.iWeb.Caption = "&Developer Express on the Web"
			Me.iWeb.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
			Me.iWeb.Description = "Opens the web page."
			Me.iWeb.Hint = "Developer Express on the Web"
			Me.iWeb.Id = 21
			Me.iWeb.ImageIndex = 24
			Me.iWeb.Name = "iWeb"
			' 
			' iAbout
			' 
			Me.iAbout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.iAbout.Caption = "&About"
			Me.iAbout.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
			Me.iAbout.Description = "Displays the description of this program."
			Me.iAbout.Hint = "Displays the About dialog"
			Me.iAbout.Id = 22
			Me.iAbout.ImageIndex = 28
			Me.iAbout.Name = "iAbout"
			Me.iAbout.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			' 
			' iCenter
			' 
			Me.iCenter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iCenter.Caption = "&Center"
			Me.iCenter.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iCenter.Description = "Centers the selected text."
			Me.iCenter.GroupIndex = 1
			Me.iCenter.Hint = "Center"
			Me.iCenter.Id = 28
			Me.iCenter.ImageIndex = 19
			Me.iCenter.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
			Me.iCenter.Name = "iCenter"
			' 
			' iSelectAll
			' 
			Me.iSelectAll.Caption = "Select A&ll"
			Me.iSelectAll.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iSelectAll.Description = "Selects all text in the active document."
			Me.iSelectAll.Hint = "Selects all text in the active document."
			Me.iSelectAll.Id = 13
			Me.iSelectAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
			Me.iSelectAll.Name = "iSelectAll"
			' 
			' iCopy
			' 
			Me.iCopy.Caption = "&Copy"
			Me.iCopy.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iCopy.Description = "Copies the selection to the Clipboard."
			Me.iCopy.Hint = "Copy"
			Me.iCopy.Id = 10
			Me.iCopy.ImageIndex = 1
			Me.iCopy.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
			Me.iCopy.Name = "iCopy"
			' 
			' iCut
			' 
			Me.iCut.Caption = "Cu&t"
			Me.iCut.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iCut.Description = "Removes the selection from the active document and places it on the Clipboard."
			Me.iCut.Hint = "Cut"
			Me.iCut.Id = 9
			Me.iCut.ImageIndex = 2
			Me.iCut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
			Me.iCut.Name = "iCut"
			' 
			' iPaste
			' 
			Me.iPaste.Caption = "&Paste"
			Me.iPaste.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iPaste.Description = "Inserts the contents of the Clipboard at the insertion point, and replaces any se" & "lection. This command is available only if you have cut or copied a text."
			Me.iPaste.Hint = "Paste"
			Me.iPaste.Id = 11
			Me.iPaste.ImageIndex = 8
			Me.iPaste.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
			Me.iPaste.Name = "iPaste"
			' 
			' iClear
			' 
			Me.iClear.Caption = "Cle&ar"
			Me.iClear.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iClear.Description = "Deletes the selected text without putting it on the Clipboard. This command is av" & "ailable only if a text is selected. "
			Me.iClear.Hint = "Clear"
			Me.iClear.Id = 12
			Me.iClear.ImageIndex = 13
			Me.iClear.Name = "iClear"
			' 
			' iFont
			' 
			Me.iFont.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.iFont.Caption = "&Font..."
			Me.iFont.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iFont.Description = "Changes the font and character spacing formats of the selected text."
			Me.iFont.Hint = "Font Dialog"
			Me.iFont.Id = 17
			Me.iFont.ImageIndex = 4
			Me.iFont.Name = "iFont"
			Me.iFont.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' beiFontSize
			' 
			Me.beiFontSize.Caption = "Font Size"
			Me.beiFontSize.Edit = Me.repositoryItemSpinEdit1
			Me.beiFontSize.Hint = "Font Size"
			Me.beiFontSize.Id = 27
			Me.beiFontSize.Name = "beiFontSize"
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 6, 0, 0, 0})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' bbiFontColorPopup
			' 
			Me.bbiFontColorPopup.ActAsDropDown = True
			Me.bbiFontColorPopup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.bbiFontColorPopup.Caption = "Font Color"
			Me.bbiFontColorPopup.Description = "Formats the selected text with the color you click"
			Me.bbiFontColorPopup.DropDownControl = Me.popupControlContainer1
			Me.bbiFontColorPopup.Hint = "Formats the selected text with the color you click"
			Me.bbiFontColorPopup.Id = 36
			Me.bbiFontColorPopup.Name = "bbiFontColorPopup"
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer1.Location = New System.Drawing.Point(0, 0)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(0, 0)
			Me.popupControlContainer1.TabIndex = 6
			Me.popupControlContainer1.Visible = False
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonText = Nothing
            Me.ribbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {
                            New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")),
                New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")),
                New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")),
                New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")),
                New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d"))
            })
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.iOpen, Me.iSave, Me.iUndo, Me.iReplace, Me.idNew, Me.iClose, Me.iSaveAs, Me.iPrint, Me.iExit, Me.iCut, Me.iCopy, Me.iPaste, Me.iClear, Me.iSelectAll, Me.iFind, Me.iFont, Me.iBullets, Me.iProtected, Me.iWeb, Me.iAbout, Me.iBold, Me.iItalic, Me.iUnderline, Me.iAlignLeft, Me.iCenter, Me.iAlignRight, Me.iFontColor, Me.siPosition, Me.siModified, Me.siDocName, Me.bgFontStyle, Me.bgAlign, Me.bgFont, Me.bgBullets, Me.sbiSave, Me.sbiPaste, Me.iPasteSpecial, Me.iNew, Me.iLargeUndo, Me.iTemplate, Me.iPaintStyle, Me.rgbiSkins, Me.beiFontSize, Me.rgbiFont, Me.bbiFontColorPopup, Me.rgbiFontColor, Me.barEditItem1, Me.biStyle})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 142
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
			Me.ribbonControl1.PageHeaderItemLinks.Add(Me.biStyle)
			Me.ribbonControl1.PageHeaderItemLinks.Add(Me.iAbout)
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemPictureEdit1, Me.riicStyle})
			Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			Me.ribbonControl1.Size = New System.Drawing.Size(886, 146)
			Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iOpen)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iSave)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iUndo)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iReplace, True)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iPaintStyle)
			Me.ribbonControl1.TransparentEditors = True
			' 
			' iOpen
			' 
			Me.iOpen.Caption = "&Open..."
			Me.iOpen.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iOpen.Description = "Opens a file."
			Me.iOpen.Hint = "Open a file"
			Me.iOpen.Id = 1
			Me.iOpen.ImageIndex = 7
			Me.iOpen.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
			Me.iOpen.LargeImageIndex = 9
			Me.iOpen.Name = "iOpen"
			Me.iOpen.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' iSave
			' 
			Me.iSave.Caption = "&Save"
			Me.iSave.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iSave.Description = "Saves the active document with its current file name."
			Me.iSave.Hint = "Saves the active document with its current file name"
			Me.iSave.Id = 3
			Me.iSave.ImageIndex = 10
			Me.iSave.LargeImageIndex = 7
			Me.iSave.Name = "iSave"
			Me.iSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' iUndo
			' 
			Me.iUndo.Caption = "&Undo"
			Me.iUndo.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iUndo.Description = "Reverses the last command or deletes the last entry you typed."
			Me.iUndo.Hint = "Undo"
			Me.iUndo.Id = 8
			Me.iUndo.ImageIndex = 11
			Me.iUndo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
			Me.iUndo.Name = "iUndo"
			' 
			' iReplace
			' 
			Me.iReplace.Caption = "R&eplace..."
			Me.iReplace.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iReplace.Description = "Searches for and replaces the specified text."
			Me.iReplace.Hint = "Replace"
			Me.iReplace.Id = 15
			Me.iReplace.ImageIndex = 14
			Me.iReplace.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
			Me.iReplace.Name = "iReplace"
			' 
			' idNew
			' 
			Me.idNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.idNew.Caption = "New"
			Me.idNew.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.idNew.Description = "Creates a new, blank file."
			Me.idNew.Hint = "Creates a new, blank file"
			Me.idNew.Id = 0
			Me.idNew.ImageIndex = 6
			Me.idNew.LargeImageIndex = 0
			Me.idNew.Name = "idNew"
			' 
			' iClose
			' 
			Me.iClose.Caption = "&Close"
			Me.iClose.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iClose.Description = "Closes the active document."
			Me.iClose.Hint = "Closes the active document"
			Me.iClose.Id = 2
			Me.iClose.ImageIndex = 12
			Me.iClose.LargeImageIndex = 8
			Me.iClose.Name = "iClose"
			Me.iClose.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' iSaveAs
			' 
			Me.iSaveAs.Caption = "Save &As..."
			Me.iSaveAs.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iSaveAs.Description = "Saves the active document with a different file name."
			Me.iSaveAs.Hint = "Saves the active document with a different file name"
			Me.iSaveAs.Id = 4
			Me.iSaveAs.ImageIndex = 21
			Me.iSaveAs.LargeImageIndex = 2
			Me.iSaveAs.Name = "iSaveAs"
			' 
			' iPrint
			' 
			Me.iPrint.Caption = "&Print"
			Me.iPrint.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iPrint.Description = "Prints the active document."
			Me.iPrint.Hint = "Prints the active document"
			Me.iPrint.Id = 5
			Me.iPrint.ImageIndex = 9
			Me.iPrint.LargeImageIndex = 6
			Me.iPrint.Name = "iPrint"
			Me.iPrint.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' iExit
			' 
			Me.iExit.Caption = "E&xit"
			Me.iExit.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iExit.Description = "Closes this program after prompting you to save unsaved document."
			Me.iExit.Hint = "Closes this program after prompting you to save unsaved document."
			Me.iExit.Id = 6
			Me.iExit.ImageIndex = 22
			Me.iExit.LargeImageIndex = 1
			Me.iExit.Name = "iExit"
			' 
			' iFind
			' 
			Me.iFind.Caption = "&Find..."
			Me.iFind.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iFind.Description = "Searches for the specified text."
			Me.iFind.Hint = "Find"
			Me.iFind.Id = 14
			Me.iFind.ImageIndex = 3
			Me.iFind.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
			Me.iFind.Name = "iFind"
			' 
			' iBullets
			' 
			Me.iBullets.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iBullets.Caption = "&Bullets"
			Me.iBullets.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iBullets.Description = "Adds bullets to or removes bullets from selected paragraphs."
			Me.iBullets.Hint = "Bullets"
			Me.iBullets.Id = 18
			Me.iBullets.ImageIndex = 0
			Me.iBullets.Name = "iBullets"
			' 
			' iProtected
			' 
			Me.iProtected.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iProtected.Caption = "P&rotected"
			Me.iProtected.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iProtected.Description = "Protects the selected text."
			Me.iProtected.Hint = "Protects the selected text"
			Me.iProtected.Id = 19
			Me.iProtected.Name = "iProtected"
			' 
			' iBold
			' 
			Me.iBold.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iBold.Caption = "&Bold"
			Me.iBold.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iBold.Description = "Makes selected text and numbers bold. If the selection is already bold, clicking " & "button removes bold formatting."
			Me.iBold.Hint = "Bold"
			Me.iBold.Id = 24
			Me.iBold.ImageIndex = 15
			Me.iBold.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
			Me.iBold.Name = "iBold"
			' 
			' iItalic
			' 
			Me.iItalic.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iItalic.Caption = "&Italic"
			Me.iItalic.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iItalic.Description = "Makes selected text and numbers italic. If the selection is already italic, click" & "ing button removes italic formatting."
			Me.iItalic.Hint = "Italic"
			Me.iItalic.Id = 25
			Me.iItalic.ImageIndex = 16
			Me.iItalic.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
			Me.iItalic.Name = "iItalic"
			' 
			' iUnderline
			' 
			Me.iUnderline.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iUnderline.Caption = "&Underline"
			Me.iUnderline.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iUnderline.Description = "Underlines selected text and numbers. If the selection is already underlined, cli" & "cking button removes underlining."
			Me.iUnderline.Hint = "Underline"
			Me.iUnderline.Id = 26
			Me.iUnderline.ImageIndex = 17
			Me.iUnderline.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
			Me.iUnderline.Name = "iUnderline"
			' 
			' iAlignLeft
			' 
			Me.iAlignLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iAlignLeft.Caption = "Align &Left"
			Me.iAlignLeft.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iAlignLeft.Description = "Aligns the selected text to the left."
			Me.iAlignLeft.GroupIndex = 1
			Me.iAlignLeft.Hint = "Align Left"
			Me.iAlignLeft.Id = 27
			Me.iAlignLeft.ImageIndex = 18
			Me.iAlignLeft.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
			Me.iAlignLeft.Name = "iAlignLeft"
			' 
			' iAlignRight
			' 
			Me.iAlignRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iAlignRight.Caption = "Align &Right"
			Me.iAlignRight.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iAlignRight.Description = "Aligns the selected text to the right."
			Me.iAlignRight.GroupIndex = 1
			Me.iAlignRight.Hint = "Align Right"
			Me.iAlignRight.Id = 29
			Me.iAlignRight.ImageIndex = 20
			Me.iAlignRight.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
			Me.iAlignRight.Name = "iAlignRight"
			' 
			' iFontColor
			' 
			Me.iFontColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.iFontColor.Caption = "Font C&olor"
			Me.iFontColor.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iFontColor.Description = "Formats the selected text with the color you click."
			Me.iFontColor.Hint = "Font Color"
			Me.iFontColor.Id = 30
			Me.iFontColor.ImageIndex = 5
			Me.iFontColor.Name = "iFontColor"
			' 
			' siPosition
			' 
			Me.siPosition.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.siPosition.Id = 0
			Me.siPosition.Name = "siPosition"
			' 
			' siModified
			' 
			Me.siModified.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.siModified.Id = 1
			Me.siModified.ImageIndex = 27
			Me.siModified.Name = "siModified"
			' 
			' siDocName
			' 
			Me.siDocName.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.siDocName.Id = 2
			Me.siDocName.Name = "siDocName"
			Me.siDocName.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' bgFontStyle
			' 
			Me.bgFontStyle.Caption = "FontStyle"
			Me.bgFontStyle.Id = 0
			Me.bgFontStyle.ItemLinks.Add(Me.iBold)
			Me.bgFontStyle.ItemLinks.Add(Me.iItalic)
			Me.bgFontStyle.ItemLinks.Add(Me.iUnderline)
			Me.bgFontStyle.Name = "bgFontStyle"
			' 
			' bgAlign
			' 
			Me.bgAlign.Caption = "Align"
			Me.bgAlign.Id = 0
			Me.bgAlign.ItemLinks.Add(Me.iAlignLeft)
			Me.bgAlign.ItemLinks.Add(Me.iCenter)
			Me.bgAlign.ItemLinks.Add(Me.iAlignRight)
			Me.bgAlign.Name = "bgAlign"
			' 
			' bgFont
			' 
			Me.bgFont.Caption = "Font"
			Me.bgFont.Id = 0
			Me.bgFont.ItemLinks.Add(Me.iFont)
			Me.bgFont.ItemLinks.Add(Me.iFontColor)
			Me.bgFont.Name = "bgFont"
			' 
			' bgBullets
			' 
			Me.bgBullets.Caption = "Bullets"
			Me.bgBullets.Id = 1
			Me.bgBullets.ItemLinks.Add(Me.iBullets)
			Me.bgBullets.ItemLinks.Add(Me.iProtected)
			Me.bgBullets.Name = "bgBullets"
			' 
			' sbiSave
			' 
			Me.sbiSave.Caption = "Save"
			Me.sbiSave.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.sbiSave.Description = "Saves the active document"
			Me.sbiSave.Hint = "Saves the active document"
			Me.sbiSave.Id = 0
			Me.sbiSave.ImageIndex = 10
			Me.sbiSave.LargeImageIndex = 2
            Me.sbiSave.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                            New DevExpress.XtraBars.LinkPersistInfo(Me.iSave),
                New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAs)
            })
            Me.sbiSave.Name = "sbiSave"
            ' 
			' sbiPaste
			' 
			Me.sbiPaste.Caption = "Paste"
			Me.sbiPaste.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.sbiPaste.Description = "Inserts the contents of the Clipboard at the insertion point"
			Me.sbiPaste.Hint = "Inserts the contents of the Clipboard at the insertion point"
			Me.sbiPaste.Id = 1
			Me.sbiPaste.ImageIndex = 8
			Me.sbiPaste.LargeImageIndex = 3
            Me.sbiPaste.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                            New DevExpress.XtraBars.LinkPersistInfo(Me.iPaste),
                New DevExpress.XtraBars.LinkPersistInfo(Me.iPasteSpecial)
            })
            Me.sbiPaste.Name = "sbiPaste"
            ' 
			' iPasteSpecial
			' 
			Me.iPasteSpecial.Caption = "Paste &Special..."
			Me.iPasteSpecial.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iPasteSpecial.Description = "Opens the Paste Special dialog"
			Me.iPasteSpecial.Enabled = False
			Me.iPasteSpecial.Hint = "Opens the Paste Special dialog"
			Me.iPasteSpecial.Id = 3
			Me.iPasteSpecial.ImageIndex = 8
			Me.iPasteSpecial.Name = "iPasteSpecial"
			' 
			' iNew
			' 
			Me.iNew.Caption = "&New"
			Me.iNew.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iNew.Description = "Creates a new, blank file."
			Me.iNew.Hint = "Creates a new, blank file"
			Me.iNew.Id = 0
			Me.iNew.ImageIndex = 6
			Me.iNew.LargeImageIndex = 0
			Me.iNew.Name = "iNew"
			' 
			' iLargeUndo
			' 
			Me.iLargeUndo.Caption = "&Undo"
			Me.iLargeUndo.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iLargeUndo.Hint = "Undo"
			Me.iLargeUndo.Id = 0
			Me.iLargeUndo.ImageIndex = 11
			Me.iLargeUndo.LargeImageIndex = 5
			Me.iLargeUndo.Name = "iLargeUndo"
			' 
			' iTemplate
			' 
			Me.iTemplate.Caption = "Template..."
			Me.iTemplate.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iTemplate.Description = "Creates a new template"
			Me.iTemplate.Enabled = False
			Me.iTemplate.Hint = "Creates a new template"
			Me.iTemplate.Id = 1
			Me.iTemplate.ImageIndex = 6
			Me.iTemplate.Name = "iTemplate"
			' 
			' iPaintStyle
			' 
			Me.iPaintStyle.ActAsDropDown = True
			Me.iPaintStyle.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.iPaintStyle.Caption = "Paint style"
			Me.iPaintStyle.Description = "Select a paint scheme"
			Me.iPaintStyle.Hint = "Select a paint scheme"
			Me.iPaintStyle.Id = 7
			Me.iPaintStyle.ImageIndex = 26
			Me.iPaintStyle.Name = "iPaintStyle"
			' 
			' rgbiSkins
			' 
			Me.rgbiSkins.Caption = "Skins"
			' 
			' 
			' 
			Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiSkins.Id = 13
			Me.rgbiSkins.Name = "rgbiSkins"
			' 
			' rgbiFont
			' 
			Me.rgbiFont.Caption = "Font"
			' 
			' 
			' 
			Me.rgbiFont.Gallery.AllowHoverImages = True
			galleryItemGroup1.Caption = "Main"
			Me.rgbiFont.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.rgbiFont.Id = 29
			Me.rgbiFont.Name = "rgbiFont"
			' 
			' rgbiFontColor
			' 
			Me.rgbiFontColor.Caption = "Color"
			' 
			' 
			' 
			Me.rgbiFontColor.Gallery.ColumnCount = 10
			galleryItemGroup2.Caption = "Main"
			Me.rgbiFontColor.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.rgbiFontColor.Gallery.ImageSize = New System.Drawing.Size(10, 7)
			Me.rgbiFontColor.Id = 37
			Me.rgbiFontColor.Name = "rgbiFontColor"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.barEditItem1.CanOpenEdit = False
			Me.barEditItem1.Edit = Me.repositoryItemPictureEdit1
			Me.barEditItem1.Id = 94
			Me.barEditItem1.Name = "barEditItem1"
			Me.barEditItem1.Width = 130
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.AllowFocused = False
			Me.repositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' biStyle
			' 
			Me.biStyle.Edit = Me.riicStyle
			Me.biStyle.Hint = "Ribbon Style"
			Me.biStyle.Id = 106
			Me.biStyle.Name = "biStyle"
			Me.biStyle.Width = 75
			' 
			' riicStyle
			' 
			Me.riicStyle.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.riicStyle.Appearance.Options.UseFont = True
			Me.riicStyle.AutoHeight = False
			Me.riicStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.riicStyle.Name = "riicStyle"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup10})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Home"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ImageIndex = 1
			Me.ribbonPageGroup1.ItemLinks.Add(Me.idNew)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.iOpen)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.iClose)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.iPrint)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.sbiSave, True)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			toolTipTitleItem1.Text = "Open File Dialog"
			toolTipItem1.Appearance.Image = (DirectCast(resources.GetObject("resource.Image"), System.Drawing.Image))
			toolTipItem1.Appearance.Options.UseImage = True
			toolTipItem1.Image = (DirectCast(resources.GetObject("toolTipItem1.Image"), System.Drawing.Image))
			toolTipItem1.Text = "Show the Open file dialog box"
			toolTipTitleItem2.Appearance.Image = (DirectCast(resources.GetObject("resource.Image1"), System.Drawing.Image))
			toolTipTitleItem2.Appearance.Options.UseImage = True
			toolTipTitleItem2.Image = (DirectCast(resources.GetObject("toolTipTitleItem2.Image"), System.Drawing.Image))
			toolTipTitleItem2.Text = "For more information see help"
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			superToolTip1.Items.Add(toolTipSeparatorItem1)
			superToolTip1.Items.Add(toolTipTitleItem2)
			Me.ribbonPageGroup1.SuperTip = superToolTip1
			Me.ribbonPageGroup1.Text = "File"
			' 
			' ribbonPageGroup10
			' 
			Me.ribbonPageGroup10.ItemLinks.Add(Me.rgbiSkins)
			Me.ribbonPageGroup10.Name = "ribbonPageGroup10"
			Me.ribbonPageGroup10.ShowCaptionButton = False
			Me.ribbonPageGroup10.Text = "Skins"
			' 
			' ribbonStatusBar1
			' 
			Me.ribbonStatusBar1.ItemLinks.Add(Me.siPosition)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.siModified, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.siDocName, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.barEditItem1)
			Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 572)
			Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
			Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
			Me.ribbonStatusBar1.Size = New System.Drawing.Size(886, 27)
			' 
			' ribbonLogoHelper1
			' 
			Me.ribbonLogoHelper1.Image = My.Resources.DevExpress_Logo_Large_Color
			Me.ribbonLogoHelper1.RibbonControl = Me.ribbonControl1
			' 
			' frmMain
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.ClientSize = New System.Drawing.Size(886, 599)
			Me.Controls.Add(Me.ribbonStatusBar1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.IsMdiContainer = True
			Me.Name = "frmMain"
			Me.Ribbon = Me.ribbonControl1
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.StatusBar = Me.ribbonStatusBar1
			Me.Text = "SimplePad (C# Demo)"
			DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.riicStyle, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private iClose As DevExpress.XtraBars.BarButtonItem
		Private iSave As DevExpress.XtraBars.BarButtonItem
		Private iOpen As DevExpress.XtraBars.BarButtonItem
		Private iSaveAs As DevExpress.XtraBars.BarButtonItem
		Private idNew As DevExpress.XtraBars.BarButtonItem
		Private iExit As DevExpress.XtraBars.BarButtonItem
		Private iPrint As DevExpress.XtraBars.BarButtonItem
		Private iClear As DevExpress.XtraBars.BarButtonItem
		Private iPaste As DevExpress.XtraBars.BarButtonItem
		Private iFind As DevExpress.XtraBars.BarButtonItem
		Private iCut As DevExpress.XtraBars.BarButtonItem
		Private iCopy As DevExpress.XtraBars.BarButtonItem
		Private iUndo As DevExpress.XtraBars.BarButtonItem
		Private iReplace As DevExpress.XtraBars.BarButtonItem
		Private iSelectAll As DevExpress.XtraBars.BarButtonItem
		Private iBold As DevExpress.XtraBars.BarButtonItem
		Private iAlignRight As DevExpress.XtraBars.BarButtonItem
		Private iCenter As DevExpress.XtraBars.BarButtonItem
		Private iUnderline As DevExpress.XtraBars.BarButtonItem
		Private iAlignLeft As DevExpress.XtraBars.BarButtonItem
		Private iItalic As DevExpress.XtraBars.BarButtonItem
		Private iFont As DevExpress.XtraBars.BarButtonItem
		Private iBullets As DevExpress.XtraBars.BarButtonItem
		Private iProtected As DevExpress.XtraBars.BarButtonItem
		Private iFontColor As DevExpress.XtraBars.BarButtonItem
		Private iWeb As DevExpress.XtraBars.BarButtonItem
		Private siPosition As DevExpress.XtraBars.BarButtonItem
		Private siModified As DevExpress.XtraBars.BarButtonItem
		Private siDocName As DevExpress.XtraBars.BarStaticItem
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private components As System.ComponentModel.IContainer
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private bgAlign As DevExpress.XtraBars.BarButtonGroup
		Private bgFontStyle As DevExpress.XtraBars.BarButtonGroup
		Private bgFont As DevExpress.XtraBars.BarButtonGroup
		Private bgBullets As DevExpress.XtraBars.BarButtonGroup
		Private sbiSave As DevExpress.XtraBars.BarSubItem
		Private sbiPaste As DevExpress.XtraBars.BarSubItem
		Private iPasteSpecial As DevExpress.XtraBars.BarButtonItem
		Private iNew As DevExpress.XtraBars.BarButtonItem
		Private iLargeUndo As DevExpress.XtraBars.BarLargeButtonItem
		Private iTemplate As DevExpress.XtraBars.BarButtonItem
		Private iPaintStyle As DevExpress.XtraBars.BarButtonItem
		Private rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
		Private ribbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private beiFontSize As DevExpress.XtraBars.BarEditItem
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private rgbiFont As DevExpress.XtraBars.RibbonGalleryBarItem
		Private bbiFontColorPopup As DevExpress.XtraBars.BarButtonItem
		Private rgbiFontColor As DevExpress.XtraBars.RibbonGalleryBarItem
		Private iAbout As DevExpress.XtraBars.BarButtonItem
		Private barEditItem1 As BarEditItem
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private biStyle As BarEditItem
		Private riicStyle As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private ribbonLogoHelper1 As Ribbon.RibbonLogoHelper

	End Class
End Namespace
