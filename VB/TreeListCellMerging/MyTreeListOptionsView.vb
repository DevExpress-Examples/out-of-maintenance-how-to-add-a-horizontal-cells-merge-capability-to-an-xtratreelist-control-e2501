Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraTreeList

Namespace TreeListCellMerging
	Public Class MyTreeListOptionsView
		Inherits TreeListOptionsView
		Private allowHorzMerge As Boolean

		Public Sub New()
			MyBase.New()
			allowHorzMerge = False
		End Sub

		<DefaultValue(False)> _
		Public Property AllowHorizontalMerge() As Boolean
			Get
				Return allowHorzMerge
			End Get
			Set(ByVal value As Boolean)
				If allowHorzMerge = value Then
					Return
				End If

				allowHorzMerge = value
			End Set
		End Property

		Public Overrides Sub Assign(ByVal options As BaseOptions)
			MyBase.Assign(options)
			Dim optView As MyTreeListOptionsView = TryCast(options, MyTreeListOptionsView)
			If optView Is Nothing Then
				Return
			End If

			Me.allowHorzMerge = optView.AllowHorizontalMerge
		End Sub
	End Class
End Namespace
