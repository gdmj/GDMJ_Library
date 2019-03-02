using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDMJ_Library;
using GDMJ_Library.Tools;

namespace LibraryChecker
{
    public partial class Form1 : Form
    {
        SimpleSave SS = new SimpleSave();
        SimpleSave.NewArray SS_Array = new SimpleSave.NewArray("UsersGDMJ");

        // ===HOTKERYS===
        HotKey HotKey = new HotKey("TEST");
        HotKey Debug = new HotKey("DEBUG GDMJ");
        HotKey Plswork = new HotKey("Pls work");
        HotKey DebugHide = new HotKey("DebugHide");
        HotKey Language = new HotKey("Чек руссиан");


        bool Test;

        public Form1()
        {
            InitializeComponent();
            
            if (OneFirstRun.Run() == true)
            {
                Log.New("FirstRun Started");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log.New("Тупые логи");
            int tost = 228;
            Log.New(tost.ToString());
            Log.New("Всё работает", "Works");
            Log.New("Вроде норм", 2);
            Log.hr();
            Log.New("Test", "Works");
            Log.New("Test", "Warning");
            Log.New("Test", "Error");
            Log.New("Test", "FatalError");
            Log.hr();
            Log.New("Test", 0);
            Log.New("Test", 1);
            Log.New("Test", 2);
            Log.New("Test", 3);
            Log.hr();
            Log.New("Test", Log.Mode.Works);
            Log.New("Test", Log.Mode.Warning);
            Log.New("Test", Log.Mode.Error);
            Log.New("Test", Log.Mode.FatalError);
            Log.hr();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Log.New(Convert.ToString(e.KeyCode));

            //LogBox.HotKeyShow(e);

            Test = HotKey.Check(e);

            if (Test == true)
            {
                Log.New("HotKey work", 0);
            }

            if (Debug.Check(e) == true)
            {
                Log.LogBox.Show();
            }

            if (DebugHide.Check(e))
            {
                Log.LogBox.Hide();
            }

            if (Plswork.Check(e))
            {
                Log.New("Pls work", 0);
            }

            if (Language.Check(e))
            {
                Log.New("Чек руссиан work", 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log.LogBox.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Log.New("Pls РАБОТАЙ!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList UsersList = new ArrayList();

            SS.AddVar("name", "Denius");
            SS.AddVar("Corp", "Hornet inc.");
            SS.AddVar("Corp", "GDMJ");

            UsersList.Add("Denius");
            UsersList.Add("Muller");

            SS_Array.AddVar("Glipko");
            SS_Array.AddArray(UsersList);
            SS_Array.AddVar("JonnyTheCat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList AL = new ArrayList();

            Log.New(SS.ReturnVar("name"));
            Log.New(SS.ReturnVar("Corp"));

            Log.New(SS_Array.ReturnVar(0));
            AL.AddRange(SS_Array.ReturnArray());
            foreach (object _o in AL)
            {
                Log.New(_o.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

    }
}
