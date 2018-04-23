Imports DevExpress.XtraBars.Ribbon
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing

Namespace DevExpress.XtraBars.Ribbon
	<DesignerCategory(""), Designer("")>
	Public Class RibbonLogoHelper
		Inherits Component

		Private _Image As Image
		Private _RibbonControl As RibbonControl

		Public Property RibbonControl() As RibbonControl
			Get
				Return _RibbonControl
			End Get
			Set(ByVal value As RibbonControl)
				If value Is _RibbonControl Then
					Return
				End If
				Dim prevValue As RibbonControl = _RibbonControl
				_RibbonControl = value
				OnRibbonChanged(prevValue, _RibbonControl)
			End Set
		End Property

		Private Sub OnRibbonChanged(ByVal prevValue As RibbonControl, ByVal ribbonControl As RibbonControl)
			If prevValue IsNot Nothing Then
				RemoveHandler prevValue.Paint, AddressOf ribbonControl_Paint
			End If
			If ribbonControl IsNot Nothing Then
				AddHandler ribbonControl.Paint, AddressOf ribbonControl_Paint
				ribbonControl.Invalidate()
			End If

		End Sub

		Private Sub ribbonControl_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
			DrawRibbonLogo(e.Graphics)
		End Sub


		Public Property Image() As Image
			Get
				Return _Image
			End Get
			Set(ByVal value As Image)
				If value Is _Image Then
					Return
				End If
				_Image = value
				OnImageChanged()
			End Set
		End Property



		Private Sub OnImageChanged()
			If RibbonControl IsNot Nothing Then
				RibbonControl.Invalidate()
			End If
		End Sub

		Private Sub DrawRibbonLogo(ByVal graphics As Graphics)
			If Image Is Nothing Then
				Return
			End If
			Dim ribbonViewInfo As RibbonViewInfo = RibbonControl.ViewInfo
			If ribbonViewInfo Is Nothing Then
				Return
			End If
			Dim panelViewInfo As RibbonPanelViewInfo = ribbonViewInfo.Panel
			If panelViewInfo Is Nothing Then
				Return
			End If
			Dim bounds As Rectangle = panelViewInfo.Bounds
			Dim minX As Integer = bounds.X
			Dim groups As RibbonPageGroupViewInfoCollection = panelViewInfo.Groups
			If groups Is Nothing Then
				Return
			End If
			If groups.Count > 0 Then
				minX = groups(groups.Count - 1).Bounds.Right
			End If
			If bounds.Height < Image.Height Then
				Return
			End If
			Dim offset As Integer = (bounds.Height - Image.Height) \ 2
			Dim width As Integer = Image.Width + 15
			bounds.X = bounds.Width - width
			If bounds.X < minX Then
				Return
			End If
			bounds.Width = width
			bounds.Y += offset
			bounds.Height = Image.Height
			graphics.DrawImage(Image, New Rectangle(bounds.Location, Image.Size), New Rectangle(Point.Empty, Image.Size), GraphicsUnit.Pixel)
		End Sub

	End Class
End Namespace
