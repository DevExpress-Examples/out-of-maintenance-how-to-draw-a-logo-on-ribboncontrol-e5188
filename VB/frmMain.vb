Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.Tutorials.Controls
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Helpers

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class frmMain
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			SkinHelper.InitSkinGallery(rgbiSkins)
		End Sub


	End Class
End Namespace
