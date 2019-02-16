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
    public class Debug
    {
        public string showinfo()
        {
            string rinfo = Const.LibraryName + Const.LibraryVersion + " loaded.";
            return rinfo;
        }
    }
}
