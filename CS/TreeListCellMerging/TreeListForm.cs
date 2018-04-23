using System;
using System.Windows.Forms;

namespace TreeListCellMerging
{
    public partial class TreeListForm : Form
    {
        public TreeListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.departmentsTableAdapter.Fill(this.departmentsDataSet.Departments);
            treeList1.ExpandAll();
        }
        private void treeList1_AllowMergeRowCells(object sender, AllowMergeRowCellsEventArgs e)
        {
            if(e.Node.HasChildren == true)
                e.Merge = DevExpress.Utils.DefaultBoolean.True;
            else
                e.Merge = DevExpress.Utils.DefaultBoolean.Default;
        }
    }
}