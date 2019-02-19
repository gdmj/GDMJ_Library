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

        int letter = 0;
        int clicks = 0;

        public enum Mode
        {
            Works,
            Warning,
            Error,
            FatalError
        }

        private void ListBoxAdd(string Text)
        {
            DForm.ListBoxLog.Items.Insert(0, Text);
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
            DForm.Hide();
        }

        public class Log
        {
            LogBox LogBox = new LogBox();

            public Log()
            {

            }

            public void New(string Text)
            {
                DateTime DateTimeNow = DateTime.Now;
                LogBox.ListBoxAdd("             " + DateTimeNow.ToLongTimeString() + " ===> " + Text);
            }

            public void New(string Text, string Mode)
            {
                DateTime DateTimeNow = DateTime.Now;
                string Prefix = null;
                switch (Mode)
                {
                    case "Works": Prefix = "[Works]      " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case "Warning": Prefix = "[Warning]    " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case "Error": Prefix = "[Error]      " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case "FatalError": Prefix = "[FatalError] " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                }

                LogBox.ListBoxAdd(Prefix + Text);
            }

            public void New(string Text, int Mode)
            {
                DateTime DateTimeNow = DateTime.Now;
                string Prefix = null;
                switch (Mode)
                {
                    case 0: Prefix = "[Works]      " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case 1: Prefix = "[Warning]    " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case 2: Prefix = "[Error]      " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case 3: Prefix = "[FatalError] " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                }

                LogBox.ListBoxAdd(Prefix + Text);
            }

            public void New(string Text, LogBox.Mode Mode)
            {
                DateTime DateTimeNow = DateTime.Now;
                string Prefix = null;
                switch (Mode)
                {
                    case Mode.Works: Prefix = "[Works]      " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case Mode.Warning: Prefix = "[Warning]    " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case Mode.Error: Prefix = "[Error]      " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                    case Mode.FatalError: Prefix = "[FatalError] " + DateTimeNow.ToLongTimeString() + " ===> "; break;
                }

                LogBox.ListBoxAdd(Prefix + Text);
            }

            public void hr()
            {
                LogBox.ListBoxAdd("======================================================================");
            }
        }

        

        public void HotKeyShow(KeyEventArgs e)
        {

            clicks++;

            if (e.KeyCode == Keys.D && letter == 0)
            {
                letter++;
            }

            if (e.KeyCode == Keys.E && letter == 1)
            {
                letter++;
            }

            if (e.KeyCode == Keys.B && letter == 2)
            {
                letter++;
            }

            if (e.KeyCode == Keys.U && letter == 3)
            {
                letter++;
            }

            if (e.KeyCode == Keys.G && letter == 4)
            {
                letter++;
            }

            if (e.KeyCode == Keys.G && letter == 5)
            {
                letter++;
            }

            if (e.KeyCode == Keys.D && letter == 6)
            {
                letter++;
            }

            if (e.KeyCode == Keys.M && letter == 7)
            {
                letter++;
            }

            if (e.KeyCode == Keys.J && letter == 8)
            {
                letter++;
            }
            
            if (letter == 9)
            {
                this.Show();
                letter = 0;
            }
            if (clicks == 9 || clicks > letter)
            {
                if (e.KeyCode != Keys.D)
                {
                    letter = 0;
                    clicks = 0;
                }
                else
                {
                    letter = 1;
                    clicks = 1;
                }
            }
        }
    }
}
