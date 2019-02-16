using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDMJ_Library
{
    public class LogBox
    {
        private DebugForm DForm = new DebugForm();
        private Debug Debug = new Debug();

        private void ListBoxAdd(string Text)
        {
            DForm.ListBoxLog.Items.Add(Text);
        }

        public LogBox()
        {
            ListBoxAdd(Debug.showinfo());
        }

        public void Show()
        {
            DForm.Show();
        }

        public void Hide()
        {
            DForm.Close();
        }

        public void Log(string Text)
        {
            ListBoxAdd(Text);
        }
    }
}
