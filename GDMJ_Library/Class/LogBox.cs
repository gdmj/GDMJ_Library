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
            DForm.Hide();
        }

        public void Log(string Text)
        {
            DateTime DateTimeNow = DateTime.Now;
            ListBoxAdd(DateTimeNow + " =================> " + Text);
        }

        public void Log(string Text, string Mode)
        {
            DateTime DateTimeNow = DateTime.Now;
            string Prefix = null;
            switch (Mode)
            {
                case "Works":      Prefix = "[Works]      " + DateTimeNow + " ===> "; break;
                case "Warning":    Prefix = "[Warning]    " + DateTimeNow + " ===> "; break;
                case "Error":      Prefix = "[Error]      " + DateTimeNow + " ===> "; break;
                case "FatalError": Prefix = "[FatalError] " + DateTimeNow + " ===> "; break;
            }

            ListBoxAdd(Prefix + Text);
        }

        public void Log(string Text, int Mode)
        {
            DateTime DateTimeNow = DateTime.Now;
            string Prefix = null;
            switch (Mode)
            {
                case 0: Prefix = "[Works]      " + DateTimeNow + " ===> "; break;
                case 1: Prefix = "[Warning]    " + DateTimeNow + " ===> "; break;
                case 2: Prefix = "[Error]      " + DateTimeNow + " ===> "; break;
                case 3: Prefix = "[FatalError] " + DateTimeNow + " ===> "; break;
            }

            ListBoxAdd(Prefix + Text);
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
