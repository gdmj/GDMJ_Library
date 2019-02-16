using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDMJ_Library.Class
{
    class LogBox
    {
        private ListBox LBox;

        public LogBox(ListBox _LBox)
        {
            LBox = _LBox;
        }

        public void Log(String _Text)
        {
            LBox.Items.Add(_Text);
        }
    }
}
