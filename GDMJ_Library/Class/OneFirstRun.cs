using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GDMJ_Library.Class
{
    class OneFirstRun
    {
        public void Run()
        {
            if (File.Exists("Not_delete"))
            {
                File.Create("Not_delete");

                try
                {

                }
                catch
                {

                }
            }
        }
    }
}
