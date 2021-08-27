<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616750/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5188)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [frmMain.cs](./CS/frmMain.cs) (VB: [frmMain.vb](./VB/frmMain.vb))
* [RibbonLogoHelper.cs](./CS/LogoHelper/RibbonLogoHelper.cs) (VB: [RibbonLogoHelper.vb](./VB/LogoHelper/RibbonLogoHelper.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to draw a logo on RibbonControl


<p>This example demonstrates how to create a helper component that allows drawing a logo at the right side of the RibbonControl.<br><br></p>
<p><strong>IMPORTANT:</strong> Starting with v16.2, RibbonControl provides the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraBars.Ribbon.RibbonControl.Image.property">RibbonControl.Image Property</a> that allows you to put a background image to the control. If the built-in alignment options aren't enough for you, use this example.</p>
<br>
<p>To use this helper in your project, drop it onto the form from the Visual Studio ToolBox (you need to rebuild the project first). Then, set the RibbonControl and Image properties. If you wish to provide more complex logic, for example, draw this logo on a specific Ribbon page, go to the RibbonLogoHelper.DrawRibbonLogo method and add the required condition there.</p>

<br/>


