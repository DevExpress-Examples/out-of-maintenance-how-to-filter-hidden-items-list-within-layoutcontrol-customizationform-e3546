Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			layoutControl1.RegisterUserCustomizatonForm(GetType(AdvancedCustomizationForm))
		End Sub
	End Class
End Namespace
