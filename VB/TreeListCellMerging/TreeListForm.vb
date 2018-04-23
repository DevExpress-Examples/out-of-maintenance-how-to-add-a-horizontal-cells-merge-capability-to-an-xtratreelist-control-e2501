Imports System
Imports System.Windows.Forms

Namespace TreeListCellMerging
    Partial Public Class TreeListForm
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.departmentsTableAdapter.Fill(Me.departmentsDataSet.Departments)
            treeList1.ExpandAll()
        End Sub
        Private Sub treeList1_AllowMergeRowCells(ByVal sender As Object, ByVal e As AllowMergeRowCellsEventArgs) Handles treeList1.AllowMergeRowCells
            If e.Node.HasChildren = True Then
                e.Merge = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Merge = DevExpress.Utils.DefaultBoolean.Default
            End If
        End Sub
    End Class
End Namespace