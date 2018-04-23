Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		<STAThread>
		Shared Sub Main()
			DevExpress.UserSkins.OfficeSkins.Register()
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			Application.Run(New frmMain())
		End Sub

	End Class
End Namespace
