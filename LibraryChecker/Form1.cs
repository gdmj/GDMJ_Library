using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDMJ_Library;
using GDMJ_Library.Class;

namespace LibraryChecker
{
    public partial class Form1 : Form
    {
        LogBox LogBox = new LogBox();
        OneFirstRun OneFirstRun = new OneFirstRun();
        Tools.HotKey HotKey = new Tools.HotKey("TEST");
        Tools.HotKey Debug = new Tools.HotKey("DEBUGGDMJ");

        bool Test;

        public Form1()
        {
            InitializeComponent();
            
            if (OneFirstRun.Run() == true)
            {
                LogBox.Log("FirstRun Started");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogBox.Log("Тупые логи");
            int tost = 228;
            LogBox.Log(tost.ToString());
            LogBox.Log("Всё работает", "Works");
            LogBox.Log("Вроде норм", 2);

            LogBox.Log("Test", "Works");
            LogBox.Log("Test", "Warning");
            LogBox.Log("Test", "Error");
            LogBox.Log("Test", "FatalError");

            LogBox.Log("Test", 0);
            LogBox.Log("Test", 1);
            LogBox.Log("Test", 2);
            LogBox.Log("Test", 3);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            LogBox.Log(Convert.ToString(e.KeyCode));

            //LogBox.HotKeyShow(e);

            Test = HotKey.Check(e);

            if (Test == true)
            {
                LogBox.Log("HotKey work", 0);
            }

            if (Debug.Check(e) == true)
            {
                LogBox.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogBox.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
