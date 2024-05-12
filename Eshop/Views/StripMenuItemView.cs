using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Views
{
    internal class StripMenuItemView
    {
        public ToolStripMenuItem ToolStripMenuItem { get; set; }
        public Type FormType { get; set; }
        public int UserID { get; set; }

        public StripMenuItemView()
        {
            this.UserID = 0;
        }

        public StripMenuItemView(ToolStripMenuItem toolStripMenuItem, Type formType)
        {
            this.ToolStripMenuItem = toolStripMenuItem;
            this.FormType = formType;
            this.UserID = 0;
        }
    }
}
