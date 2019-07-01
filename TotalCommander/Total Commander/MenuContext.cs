using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Total_Commander
{
    class MenuContext
    {
        public MenuContext(ContextMenuStrip menu, Point mousepos)
        {
            menu.Show(mousepos);
        }
    }
}
