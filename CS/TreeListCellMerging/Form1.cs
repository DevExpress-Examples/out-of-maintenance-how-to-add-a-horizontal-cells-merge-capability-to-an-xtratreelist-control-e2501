using System;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;

namespace TreeListCellMerging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.departmentsTableAdapter.Fill(this.departmentsDataSet.Departments);
            treeList1.ExpandAll();
        }
    }
}