Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.HitInfo


Namespace LayoutControl_CalcHitInfo
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub layoutControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles layoutControl1.MouseDown
			Dim lc As LayoutControl = TryCast(sender, LayoutControl)
			Dim hi As BaseLayoutItemHitInfo = lc.CalcHitInfo(e.Location)
			Dim currentItem As LayoutControlItem = TryCast(hi.Item, LayoutControlItem)
			If currentItem Is Nothing OrElse hi.HitType <> LayoutItemHitTest.TextArea Then
				Return
			End If
			If currentItem.Control IsNot Nothing Then
				currentItem.Control.Focus()
			End If
		End Sub
	End Class
End Namespace
