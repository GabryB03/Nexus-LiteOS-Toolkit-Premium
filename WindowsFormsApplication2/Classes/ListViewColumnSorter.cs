using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200003E RID: 62
	internal class ListViewColumnSorter : IComparer
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00002209 File Offset: 0x00000409
		public ListViewColumnSorter()
		{
			this._columnToSort = 0;
			this._sortOrder = SortOrder.None;
			this._comparer = new CaseInsensitiveComparer();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0008B50C File Offset: 0x0008970C
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002232 File Offset: 0x00000432
		public int CurrentColumn
		{
			get
			{
				return this._columnToSort;
			}
			set
			{
				this._columnToSort = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0008B524 File Offset: 0x00089724
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000223B File Offset: 0x0000043B
		public SortOrder SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				this._sortOrder = value;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0008B53C File Offset: 0x0008973C
		public int Compare(object x, object y)
		{
			int num = 0;
			ListViewItem listViewItem;
			ListViewItem listViewItem2;
			do
			{
				if (num == 2)
				{
					listViewItem = (ListViewItem)y;
					num = 3;
				}
				if (num == 1)
				{
					listViewItem2 = (ListViewItem)x;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			int num2;
			try
			{
				num2 = this._comparer.Compare(Convert.ToInt64(listViewItem2.SubItems[this._columnToSort].Text), Convert.ToInt64(listViewItem.SubItems[this._columnToSort].Text));
			}
			catch
			{
				num2 = this._comparer.Compare(listViewItem2.SubItems[this._columnToSort].Text, listViewItem.SubItems[this._columnToSort].Text);
			}
			int num3;
			if (this._sortOrder == SortOrder.Ascending)
			{
				num3 = num2;
			}
			else if (this._sortOrder == SortOrder.Descending)
			{
				num3 = -num2;
			}
			else
			{
				num3 = 0;
			}
			return num3;
		}

		// Token: 0x0400038A RID: 906
		private int _columnToSort;

		// Token: 0x0400038B RID: 907
		private SortOrder _sortOrder;

		// Token: 0x0400038C RID: 908
		private CaseInsensitiveComparer _comparer;
	}
}
