Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic
Imports System.Collections
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub OnListBoxDataBinding(ByVal sender As Object, ByVal e As EventArgs)
		Dim listBox As ASPxListBox = TryCast(sender, ASPxListBox)
		Dim container As GridViewDataItemTemplateContainer = CType(listBox.NamingContainer, GridViewDataItemTemplateContainer)
		Session("CategoryID") = container.KeyValue
		listBox.DataSource = AccessDataSource1
	End Sub
End Class

