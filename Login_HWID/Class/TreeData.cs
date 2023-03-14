using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Login_HWID.Class
{
	// Token: 0x02000080 RID: 128
	public class TreeData<T> : IEnumerable<TreeData<T>>, IEnumerable
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00002EFD File Offset: 0x000010FD
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00002F05 File Offset: 0x00001105
		public T Data { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00002F0E File Offset: 0x0000110E
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00002F16 File Offset: 0x00001116
		public TreeData<T> Parent { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00002F1F File Offset: 0x0000111F
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00002F27 File Offset: 0x00001127
		public ICollection<TreeData<T>> Children { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00002F30 File Offset: 0x00001130
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00002F38 File Offset: 0x00001138
		public string Tag { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00002F41 File Offset: 0x00001141
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00002F49 File Offset: 0x00001149
		public string Name { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00002F52 File Offset: 0x00001152
		public bool Root
		{
			get
			{
				return this.Parent == null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00002F5D File Offset: 0x0000115D
		public bool HasChildren
		{
			get
			{
				return this.Children.Count > 0;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00194B3C File Offset: 0x00192D3C
		public int Level
		{
			get
			{
				int num;
				if (this.Root)
				{
					num = 0;
				}
				else
				{
					num = this.Parent.Level + 1;
				}
				return num;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00002F71 File Offset: 0x00001171
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00002F79 File Offset: 0x00001179
		private ICollection<TreeData<T>> ItemCollection { get; set; }

		// Token: 0x06000A9D RID: 2717 RVA: 0x00002F82 File Offset: 0x00001182
		public TreeData(T data)
		{
			this.Data = data;
			this.Children = new LinkedList<TreeData<T>>();
			this.ItemCollection = new LinkedList<TreeData<T>>();
			this.ItemCollection.Add(this);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00194B6C File Offset: 0x00192D6C
		public TreeData<T> AddChild(T childItem)
		{
			int num = 0;
			TreeData<T> treeData3;
			do
			{
				TreeData<T> treeData;
				if (num == 2)
				{
					treeData.Parent = this;
					num = 3;
				}
				TreeData<T> treeData2;
				if (num == 4)
				{
					this.Children.Add(treeData2);
					num = 5;
				}
				if (num == 6)
				{
					treeData3 = treeData2;
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 5)
				{
					this.AddToSearch(treeData2);
					num = 6;
				}
				if (num == 3)
				{
					treeData2 = treeData;
					num = 4;
				}
				if (num == 1)
				{
					treeData = new TreeData<T>(childItem);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
			return treeData3;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00194C98 File Offset: 0x00192E98
		private void AddToSearch(TreeData<T> item)
		{
			int num = 0;
			do
			{
				bool flag;
				if (num == 2)
				{
					flag = this.Parent != null;
					num = 3;
				}
				if (num == 4)
				{
					this.Parent.AddToSearch(item);
					num = 5;
				}
				if (num == 3)
				{
					if (!flag)
					{
						break;
					}
					num = 4;
				}
				if (num == 1)
				{
					this.ItemCollection.Add(item);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00194D78 File Offset: 0x00192F78
		public TreeData<T> FindTreeItem(Func<TreeData<T>, bool> predicate)
		{
			int num = 0;
			TreeData<T> treeData;
			while (num != 2)
			{
				if (num == 1)
				{
					treeData = this.ItemCollection.FirstOrDefault(predicate);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return treeData;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00194DF0 File Offset: 0x00192FF0
		IEnumerator IEnumerable.GetEnumerator()
		{
			int num = 0;
			IEnumerator enumerator;
			while (num != 2)
			{
				if (num == 1)
				{
					enumerator = this.GetEnumerator();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return enumerator;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00194E60 File Offset: 0x00193060
		public IEnumerator<TreeData<T>> GetEnumerator()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			TreeData<T>.<GetEnumerator>d__35 <GetEnumerator>d__ = new TreeData<T>.<GetEnumerator>d__35(0);
			<GetEnumerator>d__.<>4__this = this;
			return <GetEnumerator>d__;
		}
	}
}
