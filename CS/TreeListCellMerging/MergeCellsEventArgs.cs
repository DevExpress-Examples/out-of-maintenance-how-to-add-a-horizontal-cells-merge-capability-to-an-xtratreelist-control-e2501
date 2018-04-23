using DevExpress.Utils;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.ViewInfo;
using System;

namespace TreeListCellMerging
{
    public class AllowMergeRowCellsEventArgs : EventArgs
    {
        private string currentCellDisplayText;
        private TreeListColumn currentColumn;
        private DefaultBoolean merge;
        private TreeListNode node;
        private string previousCellDisplayText;
        private TreeListColumn previousColumn;

        public AllowMergeRowCellsEventArgs(RowInfo rowInfo, int currCellIndex, int prevCellIndex)
        {
            node = rowInfo.Node;
            currentColumn = rowInfo.Cells[currCellIndex].Column;
            previousColumn = rowInfo.Cells[prevCellIndex].Column;
            currentCellDisplayText = node.GetDisplayText(currentColumn);
            previousCellDisplayText = node.GetDisplayText(previousColumn);
            merge = DefaultBoolean.Default;
        }

        public string CurrentCellDisplayText {
            get {
                return currentCellDisplayText;
            }
        }

        public TreeListColumn CurrentColumn {
            get {
                return currentColumn;
            }
        }

        public DefaultBoolean Merge {
            get {
                return merge;
            }
            set {
                merge = value;
            }
        }

        public TreeListNode Node {
            get {
                return node;
            }
        }

        public string PreviousCellDisplayText {
            get {
                return previousCellDisplayText;
            }
        }

        public TreeListColumn PreviousColumn {
            get {
                return previousColumn;
            }
        }
    }

    public class AllowMergeColumnCellsEventArgs : EventArgs
    {
        private TreeListColumn column;
        private string currCellVisibleText;
        private TreeListNode currNode;
        private DefaultBoolean merge;
        private string prevCellVisibleText;
        private TreeListNode prevNode;

        public AllowMergeColumnCellsEventArgs(RowInfo rowInfo, int cellIndex)
        {
            currNode = rowInfo.Node;
            prevNode = rowInfo.Node.PrevNode;
            column = rowInfo.Cells[cellIndex].Column;
            currCellVisibleText = currNode.GetDisplayText(column);
            prevCellVisibleText = prevNode.GetDisplayText(column);
            merge = DefaultBoolean.Default;
        }

        public TreeListColumn Column {
            get {
                return column;
            }
        }

        public string CurrCellVisibleText {
            get {
                return currCellVisibleText;
            }
        }

        public TreeListNode CurrNode {
            get {
                return currNode;
            }
        }

        public DefaultBoolean Merge {
            get {
                return merge;
            }
            set {
                merge = value;
            }
        }

        public string PrevCellVisibleText {
            get {
                return prevCellVisibleText;
            }
        }

        public TreeListNode PrevNode {
            get {
                return prevNode;
            }
        }
    }
}
