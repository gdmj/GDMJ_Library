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

namespace LibraryChecker
{
    public partial class Form1 : Form
    {
        LogBox LogBox = new LogBox();

        public Form1()
        {
            InitializeComponent();
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
            
            LogBox.HotKeyShow(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogBox.Show();
        }
    }
}
