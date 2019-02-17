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

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            LogBox.HotKeyShow(e);
        }
    }
}
