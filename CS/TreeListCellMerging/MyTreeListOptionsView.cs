using System.ComponentModel;
using DevExpress.Utils.Controls;
using DevExpress.XtraTreeList;

namespace TreeListCellMerging
{
	public class MyTreeListOptionsView : TreeListOptionsView
	{
		private bool allowHorzMerge;

		public MyTreeListOptionsView()
			: base()
		{
			allowHorzMerge = false;
		}

		[DefaultValue(false)]
		public bool AllowHorizontalMerge
		{
			get { return allowHorzMerge; }
			set
			{
				if ( allowHorzMerge == value )
					return;
				
				allowHorzMerge = value;
			}
		}

		public override void Assign(BaseOptions options)
		{
			base.Assign(options);
			MyTreeListOptionsView optView = options as MyTreeListOptionsView;
			if ( optView == null )
				return;

			this.allowHorzMerge = optView.AllowHorizontalMerge;
		}
	}
}
