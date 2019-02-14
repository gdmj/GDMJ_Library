using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
