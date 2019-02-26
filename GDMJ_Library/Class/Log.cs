using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDMJ_Library.Tools;

namespace GDMJ_Library
{
    public static class Log
    {
        //LogBox LogBox = new LogBox();
        private static DebugForm DForm = new DebugForm();
        private static Debug Debug = new Debug();
        private static HotKey HKShow = new HotKey("DEBUG GDMJ");

        public enum Mode
        {
            Works,
            Warning,
            Error,
            FatalError
        }

        private static void ListBoxAdd(string Text)
        {
            DForm.ListBoxLog.Items.Insert(0, Text);
        }

        public static void New(string Text)
        {
            DateTime DateTimeNow = DateTime.Now;
            ListBoxAdd("             " + DateTimeNow.ToLongTimeString() + " ===> " + Text);
        }

        public static void New(string Text, string Mode)
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

            ListBoxAdd(Prefix + Text);
        }

        public static void New(string Text, int Mode)
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

            ListBoxAdd(Prefix + Text);
        }

        public static void New(string Text, Log.Mode Mode)
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

            ListBoxAdd(Prefix + Text);
        }

        public static void hr()
        {
            ListBoxAdd("======================================================================");
        }

        public static void br()
        {
            ListBoxAdd("");
        }

        public static class LogBox
        {


            static int letter = 0;
            static int clicks = 0;

            

            public static void Show()
            {
                DForm.Show();
            }

            public static void Hide()
            {
                DForm.Hide();
            }





            public static void HotKeyShow(KeyEventArgs e)
            {
                HKShow.Check(e);
            }
        }
    }
}
