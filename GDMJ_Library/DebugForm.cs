using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDMJ_Library
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        private DebugForm DForm = new DebugForm();

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBoxLog.Items.Add(Const.LibraryName + Const.LibraryVersion + " loaded.");
        }

        private void DebugForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DForm.Hide();
        }
    }
}
